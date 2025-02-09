using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHierarchicalGraphView
/// </summary>
/// <remarks>
///    Accepts a graph and a hierarchy - currently
/// a tree - and provides a hierarchy-aware display.  Currently, this means
/// displaying the hierarchy using a tree layout, then rendering the graph
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
/// Thanks to the turtle with jets for feet, without you this class wouldn't
/// have been possible.
/// </remarks>
public class vtkHierarchicalGraphView : vtkGraphLayoutView
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalGraphView";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHierarchicalGraphView()
	{
		MRClassNameKey = "class vtkHierarchicalGraphView";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalGraphView"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHierarchicalGraphView(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHierarchicalGraphView New()
	{
		vtkHierarchicalGraphView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHierarchicalGraphView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHierarchicalGraphView()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHierarchicalGraphView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkHierarchicalGraphView_ColorGraphEdgesByArrayOff_01(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual void ColorGraphEdgesByArrayOff()
	{
		vtkHierarchicalGraphView_ColorGraphEdgesByArrayOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_ColorGraphEdgesByArrayOn_02(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual void ColorGraphEdgesByArrayOn()
	{
		vtkHierarchicalGraphView_ColorGraphEdgesByArrayOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHierarchicalGraphView_GetBundlingStrength_03(HandleRef pThis);

	/// <summary>
	/// Set the bundling strength.
	/// </summary>
	public virtual double GetBundlingStrength()
	{
		return vtkHierarchicalGraphView_GetBundlingStrength_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHierarchicalGraphView_GetColorGraphEdgesByArray_04(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual bool GetColorGraphEdgesByArray()
	{
		return (vtkHierarchicalGraphView_GetColorGraphEdgesByArray_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphView_GetGraphEdgeColorArrayName_05(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public virtual string GetGraphEdgeColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkHierarchicalGraphView_GetGraphEdgeColorArrayName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphView_GetGraphEdgeLabelArrayName_06(HandleRef pThis);

	/// <summary>
	/// The array to use for edge labeling.  Default is "label".
	/// </summary>
	public virtual string GetGraphEdgeLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkHierarchicalGraphView_GetGraphEdgeLabelArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalGraphView_GetGraphEdgeLabelFontSize_07(HandleRef pThis);

	/// <summary>
	/// The size of the font used for edge labeling
	/// </summary>
	public virtual int GetGraphEdgeLabelFontSize()
	{
		return vtkHierarchicalGraphView_GetGraphEdgeLabelFontSize_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHierarchicalGraphView_GetGraphEdgeLabelVisibility_08(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual bool GetGraphEdgeLabelVisibility()
	{
		return (vtkHierarchicalGraphView_GetGraphEdgeLabelVisibility_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHierarchicalGraphView_GetGraphVisibility_09(HandleRef pThis);

	/// <summary>
	/// Whether the graph edges are visible (default off).
	/// </summary>
	public virtual bool GetGraphVisibility()
	{
		return (vtkHierarchicalGraphView_GetGraphVisibility_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHierarchicalGraphView_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHierarchicalGraphView_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHierarchicalGraphView_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHierarchicalGraphView_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOff_12(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual void GraphEdgeLabelVisibilityOff()
	{
		vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOn_13(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual void GraphEdgeLabelVisibilityOn()
	{
		vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_GraphVisibilityOff_14(HandleRef pThis);

	/// <summary>
	/// Whether the graph edges are visible (default off).
	/// </summary>
	public virtual void GraphVisibilityOff()
	{
		vtkHierarchicalGraphView_GraphVisibilityOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_GraphVisibilityOn_15(HandleRef pThis);

	/// <summary>
	/// Whether the graph edges are visible (default off).
	/// </summary>
	public virtual void GraphVisibilityOn()
	{
		vtkHierarchicalGraphView_GraphVisibilityOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalGraphView_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHierarchicalGraphView_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalGraphView_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHierarchicalGraphView_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphView_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHierarchicalGraphView NewInstance()
	{
		vtkHierarchicalGraphView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphView_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHierarchicalGraphView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphView_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHierarchicalGraphView SafeDownCast(vtkObjectBase o)
	{
		vtkHierarchicalGraphView vtkHierarchicalGraphView2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphView_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHierarchicalGraphView2 = (vtkHierarchicalGraphView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHierarchicalGraphView2.Register(null);
			}
		}
		return vtkHierarchicalGraphView2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_SetBundlingStrength_21(HandleRef pThis, double strength);

	/// <summary>
	/// Set the bundling strength.
	/// </summary>
	public virtual void SetBundlingStrength(double strength)
	{
		vtkHierarchicalGraphView_SetBundlingStrength_21(GetCppThis(), strength);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_SetColorGraphEdgesByArray_22(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual void SetColorGraphEdgesByArray(bool vis)
	{
		vtkHierarchicalGraphView_SetColorGraphEdgesByArray_22(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_SetGraphEdgeColorArrayName_23(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public virtual void SetGraphEdgeColorArrayName(string name)
	{
		vtkHierarchicalGraphView_SetGraphEdgeColorArrayName_23(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_SetGraphEdgeColorToSplineFraction_24(HandleRef pThis);

	/// <summary>
	/// Set the color to be the spline fraction
	/// </summary>
	public virtual void SetGraphEdgeColorToSplineFraction()
	{
		vtkHierarchicalGraphView_SetGraphEdgeColorToSplineFraction_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_SetGraphEdgeLabelArrayName_25(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for edge labeling.  Default is "label".
	/// </summary>
	public virtual void SetGraphEdgeLabelArrayName(string name)
	{
		vtkHierarchicalGraphView_SetGraphEdgeLabelArrayName_25(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_SetGraphEdgeLabelFontSize_26(HandleRef pThis, int size);

	/// <summary>
	/// The size of the font used for edge labeling
	/// </summary>
	public virtual void SetGraphEdgeLabelFontSize(int size)
	{
		vtkHierarchicalGraphView_SetGraphEdgeLabelFontSize_26(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphView_SetGraphEdgeLabelVisibility_27(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual void SetGraphEdgeLabelVisibility(bool vis)
	{
		vtkHierarchicalGraphView_SetGraphEdgeLabelVisibility_27(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphView_SetGraphFromInput_28(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the tree and graph representations to the appropriate input ports.
	/// </summary>
	public vtkDataRepresentation SetGraphFromInput(vtkDataObject input)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphView_SetGraphFromInput_28(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHierarchicalGraphView_SetGraphFromInputConnection_29(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the tree and graph representations to the appropriate input ports.
	/// </summary>
	public vtkDataRepresentation SetGraphFromInputConnection(vtkAlgorithmOutput conn)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphView_SetGraphFromInputConnection_29(GetCppThis(), conn?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkHierarchicalGraphView_SetGraphVisibility_30(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether the graph edges are visible (default off).
	/// </summary>
	public virtual void SetGraphVisibility(bool vis)
	{
		vtkHierarchicalGraphView_SetGraphVisibility_30(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphView_SetHierarchyFromInput_31(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the tree and graph representations to the appropriate input ports.
	/// </summary>
	public vtkDataRepresentation SetHierarchyFromInput(vtkDataObject input)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphView_SetHierarchyFromInput_31(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHierarchicalGraphView_SetHierarchyFromInputConnection_32(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the tree and graph representations to the appropriate input ports.
	/// </summary>
	public vtkDataRepresentation SetHierarchyFromInputConnection(vtkAlgorithmOutput conn)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphView_SetHierarchyFromInputConnection_32(GetCppThis(), conn?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
}
