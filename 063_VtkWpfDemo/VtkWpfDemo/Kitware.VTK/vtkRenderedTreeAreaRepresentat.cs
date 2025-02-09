using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRenderedTreeAreaRepresentation
///
///
/// </summary>
public class vtkRenderedTreeAreaRepresentation : vtkRenderedRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedTreeAreaRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRenderedTreeAreaRepresentation()
	{
		MRClassNameKey = "class vtkRenderedTreeAreaRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedTreeAreaRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRenderedTreeAreaRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderedTreeAreaRepresentation New()
	{
		vtkRenderedTreeAreaRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedTreeAreaRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderedTreeAreaRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRenderedTreeAreaRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRenderedTreeAreaRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRenderedTreeAreaRepresentation_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

	/// <summary>
	/// Apply the theme to this view.
	/// </summary>
	public override void ApplyViewTheme(vtkViewTheme theme)
	{
		vtkRenderedTreeAreaRepresentation_ApplyViewTheme_01(GetCppThis(), theme?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOff_02(HandleRef pThis);

	/// <summary>
	/// Whether to show area labels.  Default is off.
	/// </summary>
	public virtual void AreaLabelVisibilityOff()
	{
		vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOn_03(HandleRef pThis);

	/// <summary>
	/// Whether to show area labels.  Default is off.
	/// </summary>
	public virtual void AreaLabelVisibilityOn()
	{
		vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOff_04(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public virtual void ColorAreasByArrayOff()
	{
		vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOn_05(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public virtual void ColorAreasByArrayOn()
	{
		vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOff_06(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual void ColorGraphEdgesByArrayOff()
	{
		vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOn_07(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual void ColorGraphEdgesByArrayOn()
	{
		vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaColorArrayName_08(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring vertices.  Default is "color".
	/// </summary>
	public string GetAreaColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation_GetAreaColorArrayName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaHoverArrayName_09(HandleRef pThis);

	/// <summary>
	/// The name of the array whose value appears when the mouse hovers
	/// over a rectangle in the treemap.
	/// </summary>
	public virtual string GetAreaHoverArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation_GetAreaHoverArrayName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelArrayName_10(HandleRef pThis);

	/// <summary>
	/// The array to use for area labeling.  Default is "label".
	/// </summary>
	public virtual string GetAreaLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation_GetAreaLabelArrayName_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelMapper_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The mapper for rendering labels on areas. This may e.g. be
	/// vtkDynamic2DLabelMapper or vtkTreeMapLabelMapper.
	/// </summary>
	public virtual vtkLabeledDataMapper GetAreaLabelMapper()
	{
		vtkLabeledDataMapper vtkLabeledDataMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedTreeAreaRepresentation_GetAreaLabelMapper_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabeledDataMapper2 = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabeledDataMapper2.Register(null);
			}
		}
		return vtkLabeledDataMapper2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelPriorityArrayName_12(HandleRef pThis);

	/// <summary>
	/// The array to use for area labeling priority.
	/// Default is "GraphVertexDegree".
	/// </summary>
	public virtual string GetAreaLabelPriorityArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation_GetAreaLabelPriorityArrayName_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelTextProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The text property for the area labels.
	/// </summary>
	public virtual vtkTextProperty GetAreaLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedTreeAreaRepresentation_GetAreaLabelTextProperty_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkRenderedTreeAreaRepresentation_GetAreaLabelVisibility_14(HandleRef pThis);

	/// <summary>
	/// Whether to show area labels.  Default is off.
	/// </summary>
	public virtual bool GetAreaLabelVisibility()
	{
		return (vtkRenderedTreeAreaRepresentation_GetAreaLabelVisibility_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLayoutStrategy_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The layout strategy for producing spatial regions for the tree.
	/// </summary>
	public virtual vtkAreaLayoutStrategy GetAreaLayoutStrategy()
	{
		vtkAreaLayoutStrategy vtkAreaLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedTreeAreaRepresentation_GetAreaLayoutStrategy_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaSizeArrayName_16(HandleRef pThis);

	/// <summary>
	/// The array to use for area sizes. Default is "size".
	/// </summary>
	public virtual string GetAreaSizeArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation_GetAreaSizeArrayName_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaToPolyData_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The filter for converting areas to polydata. This may e.g. be
	/// vtkTreeMapToPolyData or vtkTreeRingToPolyData.
	/// The filter must take a vtkTree as input and produce vtkPolyData.
	/// </summary>
	public virtual vtkPolyDataAlgorithm GetAreaToPolyData()
	{
		vtkPolyDataAlgorithm vtkPolyDataAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedTreeAreaRepresentation_GetAreaToPolyData_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataAlgorithm2 = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataAlgorithm2.Register(null);
			}
		}
		return vtkPolyDataAlgorithm2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedTreeAreaRepresentation_GetColorAreasByArray_18(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public virtual bool GetColorAreasByArray()
	{
		return (vtkRenderedTreeAreaRepresentation_GetColorAreasByArray_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_19(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual bool GetColorGraphEdgesByArray()
	{
		return (vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_20(HandleRef pThis, int idx);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual bool GetColorGraphEdgesByArray(int idx)
	{
		return (vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_20(GetCppThis(), idx) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedTreeAreaRepresentation_GetEdgeScalarBarVisibility_21(HandleRef pThis);

	/// <summary>
	/// Visibility of scalar bar actor for edges.
	/// </summary>
	public virtual bool GetEdgeScalarBarVisibility()
	{
		return (vtkRenderedTreeAreaRepresentation_GetEdgeScalarBarVisibility_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_22(HandleRef pThis);

	/// <summary>
	/// Set the bundling strength.
	/// </summary>
	public virtual double GetGraphBundlingStrength()
	{
		return vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_23(HandleRef pThis, int idx);

	/// <summary>
	/// Set the bundling strength.
	/// </summary>
	public virtual double GetGraphBundlingStrength(int idx)
	{
		return vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_23(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_24(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public virtual string GetGraphEdgeColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_25(HandleRef pThis, int idx);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public virtual string GetGraphEdgeColorArrayName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_25(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_26(HandleRef pThis);

	/// <summary>
	/// The array to use for edge labeling.  Default is "label".
	/// </summary>
	public virtual string GetGraphEdgeLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_26(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_27(HandleRef pThis, int idx);

	/// <summary>
	/// The array to use for edge labeling.  Default is "label".
	/// </summary>
	public virtual string GetGraphEdgeLabelArrayName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_27(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The text property for the graph edge labels.
	/// </summary>
	public virtual vtkTextProperty GetGraphEdgeLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_29(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The text property for the graph edge labels.
	/// </summary>
	public virtual vtkTextProperty GetGraphEdgeLabelTextProperty(int idx)
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_29(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_30(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual bool GetGraphEdgeLabelVisibility()
	{
		return (vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_31(HandleRef pThis, int idx);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual bool GetGraphEdgeLabelVisibility(int idx)
	{
		return (vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_31(GetCppThis(), idx) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_32(HandleRef pThis);

	/// <summary>
	/// The name of the array whose value appears when the mouse hovers
	/// over a graph edge.
	/// </summary>
	public virtual string GetGraphHoverArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_32(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_33(HandleRef pThis, int idx);

	/// <summary>
	/// The name of the array whose value appears when the mouse hovers
	/// over a graph edge.
	/// </summary>
	public virtual string GetGraphHoverArrayName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_33(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedTreeAreaRepresentation_GetGraphSplineType_34(HandleRef pThis, int idx);

	/// <summary>
	/// Sets the spline type for the graph edges.
	/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
	/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
	/// The default is BSPLINE.
	/// </summary>
	public virtual int GetGraphSplineType(int idx)
	{
		return vtkRenderedTreeAreaRepresentation_GetGraphSplineType_34(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderedTreeAreaRepresentation_GetNumberOfGenerationsFromBase_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRenderedTreeAreaRepresentation_GetNumberOfGenerationsFromBase_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderedTreeAreaRepresentation_GetNumberOfGenerationsFromBaseType_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRenderedTreeAreaRepresentation_GetNumberOfGenerationsFromBaseType_36(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderedTreeAreaRepresentation_GetShrinkPercentage_37(HandleRef pThis);

	/// <summary>
	/// Set the region shrink percentage between 0.0 and 1.0.
	/// </summary>
	public virtual double GetShrinkPercentage()
	{
		return vtkRenderedTreeAreaRepresentation_GetShrinkPercentage_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedTreeAreaRepresentation_GetUseRectangularCoordinates_38(HandleRef pThis);

	/// <summary>
	/// Whether the area represents radial or rectangular coordinates.
	/// </summary>
	public virtual bool GetUseRectangularCoordinates()
	{
		return (vtkRenderedTreeAreaRepresentation_GetUseRectangularCoordinates_38(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOff_39(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual void GraphEdgeLabelVisibilityOff()
	{
		vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOn_40(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual void GraphEdgeLabelVisibilityOn()
	{
		vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedTreeAreaRepresentation_IsA_41(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRenderedTreeAreaRepresentation_IsA_41(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedTreeAreaRepresentation_IsTypeOf_42(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRenderedTreeAreaRepresentation_IsTypeOf_42(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRenderedTreeAreaRepresentation NewInstance()
	{
		vtkRenderedTreeAreaRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedTreeAreaRepresentation_NewInstance_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderedTreeAreaRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedTreeAreaRepresentation_SafeDownCast_45(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderedTreeAreaRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkRenderedTreeAreaRepresentation vtkRenderedTreeAreaRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedTreeAreaRepresentation_SafeDownCast_45(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderedTreeAreaRepresentation2 = (vtkRenderedTreeAreaRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderedTreeAreaRepresentation2.Register(null);
			}
		}
		return vtkRenderedTreeAreaRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaColorArrayName_46(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for coloring vertices.  Default is "color".
	/// </summary>
	public void SetAreaColorArrayName(string name)
	{
		vtkRenderedTreeAreaRepresentation_SetAreaColorArrayName_46(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaHoverArrayName_47(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the array whose value appears when the mouse hovers
	/// over a rectangle in the treemap.
	/// </summary>
	public virtual void SetAreaHoverArrayName(string _arg)
	{
		vtkRenderedTreeAreaRepresentation_SetAreaHoverArrayName_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelArrayName_48(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for area labeling.  Default is "label".
	/// </summary>
	public virtual void SetAreaLabelArrayName(string name)
	{
		vtkRenderedTreeAreaRepresentation_SetAreaLabelArrayName_48(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelMapper_49(HandleRef pThis, HandleRef mapper);

	/// <summary>
	/// The mapper for rendering labels on areas. This may e.g. be
	/// vtkDynamic2DLabelMapper or vtkTreeMapLabelMapper.
	/// </summary>
	public virtual void SetAreaLabelMapper(vtkLabeledDataMapper mapper)
	{
		vtkRenderedTreeAreaRepresentation_SetAreaLabelMapper_49(GetCppThis(), mapper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelPriorityArrayName_50(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for area labeling priority.
	/// Default is "GraphVertexDegree".
	/// </summary>
	public virtual void SetAreaLabelPriorityArrayName(string name)
	{
		vtkRenderedTreeAreaRepresentation_SetAreaLabelPriorityArrayName_50(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelTextProperty_51(HandleRef pThis, HandleRef tp);

	/// <summary>
	/// The text property for the area labels.
	/// </summary>
	public virtual void SetAreaLabelTextProperty(vtkTextProperty tp)
	{
		vtkRenderedTreeAreaRepresentation_SetAreaLabelTextProperty_51(GetCppThis(), tp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelVisibility_52(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to show area labels.  Default is off.
	/// </summary>
	public virtual void SetAreaLabelVisibility(bool vis)
	{
		vtkRenderedTreeAreaRepresentation_SetAreaLabelVisibility_52(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLayoutStrategy_53(HandleRef pThis, HandleRef strategy);

	/// <summary>
	/// The layout strategy for producing spatial regions for the tree.
	/// </summary>
	public virtual void SetAreaLayoutStrategy(vtkAreaLayoutStrategy strategy)
	{
		vtkRenderedTreeAreaRepresentation_SetAreaLayoutStrategy_53(GetCppThis(), strategy?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaSizeArrayName_54(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for area sizes. Default is "size".
	/// </summary>
	public virtual void SetAreaSizeArrayName(string name)
	{
		vtkRenderedTreeAreaRepresentation_SetAreaSizeArrayName_54(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaToPolyData_55(HandleRef pThis, HandleRef areaToPoly);

	/// <summary>
	/// The filter for converting areas to polydata. This may e.g. be
	/// vtkTreeMapToPolyData or vtkTreeRingToPolyData.
	/// The filter must take a vtkTree as input and produce vtkPolyData.
	/// </summary>
	public virtual void SetAreaToPolyData(vtkPolyDataAlgorithm areaToPoly)
	{
		vtkRenderedTreeAreaRepresentation_SetAreaToPolyData_55(GetCppThis(), areaToPoly?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetColorAreasByArray_56(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public virtual void SetColorAreasByArray(bool vis)
	{
		vtkRenderedTreeAreaRepresentation_SetColorAreasByArray_56(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_57(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual void SetColorGraphEdgesByArray(bool vis)
	{
		vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_57(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_58(HandleRef pThis, byte vis, int idx);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual void SetColorGraphEdgesByArray(bool vis, int idx)
	{
		vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_58(GetCppThis(), (byte)(vis ? 1u : 0u), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetEdgeScalarBarVisibility_59(HandleRef pThis, byte b);

	/// <summary>
	/// Visibility of scalar bar actor for edges.
	/// </summary>
	public virtual void SetEdgeScalarBarVisibility(bool b)
	{
		vtkRenderedTreeAreaRepresentation_SetEdgeScalarBarVisibility_59(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_60(HandleRef pThis, double strength);

	/// <summary>
	/// Set the bundling strength.
	/// </summary>
	public virtual void SetGraphBundlingStrength(double strength)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_60(GetCppThis(), strength);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_61(HandleRef pThis, double strength, int idx);

	/// <summary>
	/// Set the bundling strength.
	/// </summary>
	public virtual void SetGraphBundlingStrength(double strength, int idx)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_61(GetCppThis(), strength, idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_62(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public virtual void SetGraphEdgeColorArrayName(string name)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_62(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_63(HandleRef pThis, string name, int idx);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public virtual void SetGraphEdgeColorArrayName(string name, int idx)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_63(GetCppThis(), name, idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_64(HandleRef pThis);

	/// <summary>
	/// Set the color to be the spline fraction
	/// </summary>
	public virtual void SetGraphEdgeColorToSplineFraction()
	{
		vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_65(HandleRef pThis, int idx);

	/// <summary>
	/// Set the color to be the spline fraction
	/// </summary>
	public virtual void SetGraphEdgeColorToSplineFraction(int idx)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_65(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_66(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for edge labeling.  Default is "label".
	/// </summary>
	public virtual void SetGraphEdgeLabelArrayName(string name)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_66(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_67(HandleRef pThis, string name, int idx);

	/// <summary>
	/// The array to use for edge labeling.  Default is "label".
	/// </summary>
	public virtual void SetGraphEdgeLabelArrayName(string name, int idx)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_67(GetCppThis(), name, idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_68(HandleRef pThis, HandleRef tp);

	/// <summary>
	/// The text property for the graph edge labels.
	/// </summary>
	public virtual void SetGraphEdgeLabelTextProperty(vtkTextProperty tp)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_68(GetCppThis(), tp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_69(HandleRef pThis, HandleRef tp, int idx);

	/// <summary>
	/// The text property for the graph edge labels.
	/// </summary>
	public virtual void SetGraphEdgeLabelTextProperty(vtkTextProperty tp, int idx)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_69(GetCppThis(), tp?.GetCppThis() ?? default(HandleRef), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_70(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual void SetGraphEdgeLabelVisibility(bool vis)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_70(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_71(HandleRef pThis, byte vis, int idx);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual void SetGraphEdgeLabelVisibility(bool vis, int idx)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_71(GetCppThis(), (byte)(vis ? 1u : 0u), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_72(HandleRef pThis, string name);

	/// <summary>
	/// The name of the array whose value appears when the mouse hovers
	/// over a graph edge.
	/// </summary>
	public virtual void SetGraphHoverArrayName(string name)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_72(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_73(HandleRef pThis, string name, int idx);

	/// <summary>
	/// The name of the array whose value appears when the mouse hovers
	/// over a graph edge.
	/// </summary>
	public virtual void SetGraphHoverArrayName(string name, int idx)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_73(GetCppThis(), name, idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphSplineType_74(HandleRef pThis, int type, int idx);

	/// <summary>
	/// Sets the spline type for the graph edges.
	/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
	/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
	/// The default is BSPLINE.
	/// </summary>
	public virtual void SetGraphSplineType(int type, int idx)
	{
		vtkRenderedTreeAreaRepresentation_SetGraphSplineType_74(GetCppThis(), type, idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetLabelRenderMode_75(HandleRef pThis, int mode);

	/// <summary>
	/// Set the label render mode.
	/// QT - Use vtkQtTreeRingLabeler with fitted labeling
	/// and unicode support. Requires VTK_USE_QT to be on.
	/// FREETYPE - Use standard freetype text rendering.
	/// </summary>
	public override void SetLabelRenderMode(int mode)
	{
		vtkRenderedTreeAreaRepresentation_SetLabelRenderMode_75(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetShrinkPercentage_76(HandleRef pThis, double value);

	/// <summary>
	/// Set the region shrink percentage between 0.0 and 1.0.
	/// </summary>
	public virtual void SetShrinkPercentage(double value)
	{
		vtkRenderedTreeAreaRepresentation_SetShrinkPercentage_76(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_SetUseRectangularCoordinates_77(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether the area represents radial or rectangular coordinates.
	/// </summary>
	public virtual void SetUseRectangularCoordinates(bool _arg)
	{
		vtkRenderedTreeAreaRepresentation_SetUseRectangularCoordinates_77(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOff_78(HandleRef pThis);

	/// <summary>
	/// Whether the area represents radial or rectangular coordinates.
	/// </summary>
	public virtual void UseRectangularCoordinatesOff()
	{
		vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOff_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOn_79(HandleRef pThis);

	/// <summary>
	/// Whether the area represents radial or rectangular coordinates.
	/// </summary>
	public virtual void UseRectangularCoordinatesOn()
	{
		vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOn_79(GetCppThis());
	}
}
