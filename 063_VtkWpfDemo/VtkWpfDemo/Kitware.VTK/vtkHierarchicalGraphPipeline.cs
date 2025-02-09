using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHierarchicalGraphPipeline
/// </summary>
/// <remarks>
///    helper class for rendering graphs superimposed on a tree.
///
///
/// vtkHierarchicalGraphPipeline renders bundled edges that are meant to be
/// viewed as an overlay on a tree. This class is not for general use, but
/// is used in the internals of vtkRenderedHierarchyRepresentation and
/// vtkRenderedTreeAreaRepresentation.
/// </remarks>
public class vtkHierarchicalGraphPipeline : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalGraphPipeline";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHierarchicalGraphPipeline()
	{
		MRClassNameKey = "class vtkHierarchicalGraphPipeline";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalGraphPipeline"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHierarchicalGraphPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHierarchicalGraphPipeline New()
	{
		vtkHierarchicalGraphPipeline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHierarchicalGraphPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHierarchicalGraphPipeline()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHierarchicalGraphPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkHierarchicalGraphPipeline_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

	/// <summary>
	/// Applies the view theme to this graph.
	/// </summary>
	public virtual void ApplyViewTheme(vtkViewTheme theme)
	{
		vtkHierarchicalGraphPipeline_ApplyViewTheme_01(GetCppThis(), theme?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_ColorEdgesByArrayOff_02(HandleRef pThis);

	/// <summary>
	/// Whether to color the edges by an array.
	/// </summary>
	public virtual void ColorEdgesByArrayOff()
	{
		vtkHierarchicalGraphPipeline_ColorEdgesByArrayOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_ColorEdgesByArrayOn_03(HandleRef pThis);

	/// <summary>
	/// Whether to color the edges by an array.
	/// </summary>
	public virtual void ColorEdgesByArrayOn()
	{
		vtkHierarchicalGraphPipeline_ColorEdgesByArrayOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphPipeline_ConvertSelection_04(HandleRef pThis, HandleRef rep, HandleRef sel, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns a new selection relevant to this graph based on an input
	/// selection and the view that this graph is contained in.
	/// </summary>
	public virtual vtkSelection ConvertSelection(vtkDataRepresentation rep, vtkSelection sel)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphPipeline_ConvertSelection_04(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef), sel?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphPipeline_GetActor_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The actor associated with the hierarchical graph.
	/// </summary>
	public virtual vtkActor GetActor()
	{
		vtkActor vtkActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphPipeline_GetActor_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2 = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2.Register(null);
			}
		}
		return vtkActor2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHierarchicalGraphPipeline_GetBundlingStrength_06(HandleRef pThis);

	/// <summary>
	/// The bundling strength for the bundled edges.
	/// </summary>
	public virtual double GetBundlingStrength()
	{
		return vtkHierarchicalGraphPipeline_GetBundlingStrength_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphPipeline_GetColorArrayName_07(HandleRef pThis);

	/// <summary>
	/// The edge color array.
	/// </summary>
	public virtual string GetColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkHierarchicalGraphPipeline_GetColorArrayName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHierarchicalGraphPipeline_GetColorEdgesByArray_08(HandleRef pThis);

	/// <summary>
	/// Whether to color the edges by an array.
	/// </summary>
	public virtual bool GetColorEdgesByArray()
	{
		return (vtkHierarchicalGraphPipeline_GetColorEdgesByArray_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphPipeline_GetHoverArrayName_09(HandleRef pThis);

	/// <summary>
	/// The array to use while hovering over an edge.
	/// </summary>
	public virtual string GetHoverArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkHierarchicalGraphPipeline_GetHoverArrayName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphPipeline_GetLabelActor_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The actor associated with the hierarchical graph.
	/// </summary>
	public virtual vtkActor2D GetLabelActor()
	{
		vtkActor2D vtkActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphPipeline_GetLabelActor_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2D2 = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2D2.Register(null);
			}
		}
		return vtkActor2D2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphPipeline_GetLabelArrayName_11(HandleRef pThis);

	/// <summary>
	/// The edge label array name.
	/// </summary>
	public virtual string GetLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkHierarchicalGraphPipeline_GetLabelArrayName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphPipeline_GetLabelTextProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The edge label text property.
	/// </summary>
	public virtual vtkTextProperty GetLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphPipeline_GetLabelTextProperty_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkHierarchicalGraphPipeline_GetLabelVisibility_13(HandleRef pThis);

	/// <summary>
	/// The edge label visibility.
	/// </summary>
	public virtual bool GetLabelVisibility()
	{
		return (vtkHierarchicalGraphPipeline_GetLabelVisibility_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHierarchicalGraphPipeline_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHierarchicalGraphPipeline_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHierarchicalGraphPipeline_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHierarchicalGraphPipeline_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalGraphPipeline_GetSplineType_16(HandleRef pThis);

	/// <summary>
	/// The spline mode to use in vtkSplineGraphEdges.
	/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
	/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
	/// The default is BSPLINE.
	/// </summary>
	public virtual int GetSplineType()
	{
		return vtkHierarchicalGraphPipeline_GetSplineType_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHierarchicalGraphPipeline_GetVisibility_17(HandleRef pThis);

	/// <summary>
	/// The visibility of this graph.
	/// </summary>
	public virtual bool GetVisibility()
	{
		return (vtkHierarchicalGraphPipeline_GetVisibility_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalGraphPipeline_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHierarchicalGraphPipeline_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalGraphPipeline_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHierarchicalGraphPipeline_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_LabelVisibilityOff_20(HandleRef pThis);

	/// <summary>
	/// The edge label visibility.
	/// </summary>
	public virtual void LabelVisibilityOff()
	{
		vtkHierarchicalGraphPipeline_LabelVisibilityOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_LabelVisibilityOn_21(HandleRef pThis);

	/// <summary>
	/// The edge label visibility.
	/// </summary>
	public virtual void LabelVisibilityOn()
	{
		vtkHierarchicalGraphPipeline_LabelVisibilityOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphPipeline_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHierarchicalGraphPipeline NewInstance()
	{
		vtkHierarchicalGraphPipeline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphPipeline_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHierarchicalGraphPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_PrepareInputConnections_24(HandleRef pThis, HandleRef graphConn, HandleRef treeConn, HandleRef annConn);

	/// <summary>
	/// Sets the input connections for this graph.
	/// graphConn is the input graph connection.
	/// treeConn is the input tree connection.
	/// annConn is the annotation link connection.
	/// </summary>
	public virtual void PrepareInputConnections(vtkAlgorithmOutput graphConn, vtkAlgorithmOutput treeConn, vtkAlgorithmOutput annConn)
	{
		vtkHierarchicalGraphPipeline_PrepareInputConnections_24(GetCppThis(), graphConn?.GetCppThis() ?? default(HandleRef), treeConn?.GetCppThis() ?? default(HandleRef), annConn?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_RegisterProgress_25(HandleRef pThis, HandleRef view);

	/// <summary>
	/// Register progress with a view.
	/// </summary>
	public void RegisterProgress(vtkRenderView view)
	{
		vtkHierarchicalGraphPipeline_RegisterProgress_25(GetCppThis(), view?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalGraphPipeline_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHierarchicalGraphPipeline SafeDownCast(vtkObjectBase o)
	{
		vtkHierarchicalGraphPipeline vtkHierarchicalGraphPipeline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalGraphPipeline_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHierarchicalGraphPipeline2 = (vtkHierarchicalGraphPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHierarchicalGraphPipeline2.Register(null);
			}
		}
		return vtkHierarchicalGraphPipeline2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_SetBundlingStrength_27(HandleRef pThis, double strength);

	/// <summary>
	/// The bundling strength for the bundled edges.
	/// </summary>
	public virtual void SetBundlingStrength(double strength)
	{
		vtkHierarchicalGraphPipeline_SetBundlingStrength_27(GetCppThis(), strength);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_SetColorArrayName_28(HandleRef pThis, string name);

	/// <summary>
	/// The edge color array.
	/// </summary>
	public virtual void SetColorArrayName(string name)
	{
		vtkHierarchicalGraphPipeline_SetColorArrayName_28(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_SetColorEdgesByArray_29(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color the edges by an array.
	/// </summary>
	public virtual void SetColorEdgesByArray(bool vis)
	{
		vtkHierarchicalGraphPipeline_SetColorEdgesByArray_29(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_SetHoverArrayName_30(HandleRef pThis, string _arg);

	/// <summary>
	/// The array to use while hovering over an edge.
	/// </summary>
	public virtual void SetHoverArrayName(string _arg)
	{
		vtkHierarchicalGraphPipeline_SetHoverArrayName_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_SetLabelArrayName_31(HandleRef pThis, string name);

	/// <summary>
	/// The edge label array name.
	/// </summary>
	public virtual void SetLabelArrayName(string name)
	{
		vtkHierarchicalGraphPipeline_SetLabelArrayName_31(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_SetLabelTextProperty_32(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// The edge label text property.
	/// </summary>
	public virtual void SetLabelTextProperty(vtkTextProperty prop)
	{
		vtkHierarchicalGraphPipeline_SetLabelTextProperty_32(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_SetLabelVisibility_33(HandleRef pThis, byte vis);

	/// <summary>
	/// The edge label visibility.
	/// </summary>
	public virtual void SetLabelVisibility(bool vis)
	{
		vtkHierarchicalGraphPipeline_SetLabelVisibility_33(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_SetSplineType_34(HandleRef pThis, int type);

	/// <summary>
	/// The spline mode to use in vtkSplineGraphEdges.
	/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
	/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
	/// The default is BSPLINE.
	/// </summary>
	public virtual void SetSplineType(int type)
	{
		vtkHierarchicalGraphPipeline_SetSplineType_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_SetVisibility_35(HandleRef pThis, byte vis);

	/// <summary>
	/// The visibility of this graph.
	/// </summary>
	public virtual void SetVisibility(bool vis)
	{
		vtkHierarchicalGraphPipeline_SetVisibility_35(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_VisibilityOff_36(HandleRef pThis);

	/// <summary>
	/// The visibility of this graph.
	/// </summary>
	public virtual void VisibilityOff()
	{
		vtkHierarchicalGraphPipeline_VisibilityOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalGraphPipeline_VisibilityOn_37(HandleRef pThis);

	/// <summary>
	/// The visibility of this graph.
	/// </summary>
	public virtual void VisibilityOn()
	{
		vtkHierarchicalGraphPipeline_VisibilityOn_37(GetCppThis());
	}
}
