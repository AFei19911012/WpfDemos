using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRenderedHierarchyRepresentation
///
///
/// </summary>
public class vtkRenderedHierarchyRepresentation : vtkRenderedGraphRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedHierarchyRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRenderedHierarchyRepresentation()
	{
		MRClassNameKey = "class vtkRenderedHierarchyRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedHierarchyRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRenderedHierarchyRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedHierarchyRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderedHierarchyRepresentation New()
	{
		vtkRenderedHierarchyRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedHierarchyRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderedHierarchyRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRenderedHierarchyRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRenderedHierarchyRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOff_01(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual void ColorGraphEdgesByArrayOff()
	{
		vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOn_02(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual void ColorGraphEdgesByArrayOn()
	{
		vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderedHierarchyRepresentation_GetBundlingStrength_03(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual double GetBundlingStrength()
	{
		return vtkRenderedHierarchyRepresentation_GetBundlingStrength_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderedHierarchyRepresentation_GetBundlingStrength_04(HandleRef pThis, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual double GetBundlingStrength(int idx)
	{
		return vtkRenderedHierarchyRepresentation_GetBundlingStrength_04(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_05(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual bool GetColorGraphEdgesByArray()
	{
		return (vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_06(HandleRef pThis, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual bool GetColorGraphEdgesByArray(int idx)
	{
		return (vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_06(GetCppThis(), idx) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_07(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual string GetGraphEdgeColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_08(HandleRef pThis, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual string GetGraphEdgeColorArrayName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_08(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_09(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual string GetGraphEdgeLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_10(HandleRef pThis, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual string GetGraphEdgeLabelArrayName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_10(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_11(HandleRef pThis);

	/// <summary>
	/// Sets the spline type for the graph edges.
	/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
	/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
	/// The default is BSPLINE.
	/// </summary>
	public virtual int GetGraphEdgeLabelFontSize()
	{
		return vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_12(HandleRef pThis, int idx);

	/// <summary>
	/// Sets the spline type for the graph edges.
	/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
	/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
	/// The default is BSPLINE.
	/// </summary>
	public virtual int GetGraphEdgeLabelFontSize(int idx)
	{
		return vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_12(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_13(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual bool GetGraphEdgeLabelVisibility()
	{
		return (vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_14(HandleRef pThis, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual bool GetGraphEdgeLabelVisibility(int idx)
	{
		return (vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_14(GetCppThis(), idx) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedHierarchyRepresentation_GetGraphSplineType_15(HandleRef pThis, int idx);

	/// <summary>
	/// Sets the spline type for the graph edges.
	/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
	/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
	/// The default is BSPLINE.
	/// </summary>
	public virtual int GetGraphSplineType(int idx)
	{
		return vtkRenderedHierarchyRepresentation_GetGraphSplineType_15(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphVisibility_16(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual bool GetGraphVisibility()
	{
		return (vtkRenderedHierarchyRepresentation_GetGraphVisibility_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphVisibility_17(HandleRef pThis, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual bool GetGraphVisibility(int idx)
	{
		return (vtkRenderedHierarchyRepresentation_GetGraphVisibility_17(GetCppThis(), idx) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderedHierarchyRepresentation_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRenderedHierarchyRepresentation_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderedHierarchyRepresentation_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRenderedHierarchyRepresentation_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOff_20(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual void GraphEdgeLabelVisibilityOff()
	{
		vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOn_21(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual void GraphEdgeLabelVisibilityOn()
	{
		vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_GraphVisibilityOff_22(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual void GraphVisibilityOff()
	{
		vtkRenderedHierarchyRepresentation_GraphVisibilityOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_GraphVisibilityOn_23(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual void GraphVisibilityOn()
	{
		vtkRenderedHierarchyRepresentation_GraphVisibilityOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedHierarchyRepresentation_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRenderedHierarchyRepresentation_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedHierarchyRepresentation_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRenderedHierarchyRepresentation_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedHierarchyRepresentation_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRenderedHierarchyRepresentation NewInstance()
	{
		vtkRenderedHierarchyRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedHierarchyRepresentation_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderedHierarchyRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedHierarchyRepresentation_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderedHierarchyRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkRenderedHierarchyRepresentation vtkRenderedHierarchyRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedHierarchyRepresentation_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderedHierarchyRepresentation2 = (vtkRenderedHierarchyRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderedHierarchyRepresentation2.Register(null);
			}
		}
		return vtkRenderedHierarchyRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetBundlingStrength_29(HandleRef pThis, double strength);

	/// <summary>
	///
	/// </summary>
	public virtual void SetBundlingStrength(double strength)
	{
		vtkRenderedHierarchyRepresentation_SetBundlingStrength_29(GetCppThis(), strength);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetBundlingStrength_30(HandleRef pThis, double strength, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual void SetBundlingStrength(double strength, int idx)
	{
		vtkRenderedHierarchyRepresentation_SetBundlingStrength_30(GetCppThis(), strength, idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_31(HandleRef pThis, byte vis);

	/// <summary>
	///
	/// </summary>
	public virtual void SetColorGraphEdgesByArray(bool vis)
	{
		vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_31(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_32(HandleRef pThis, byte vis, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual void SetColorGraphEdgesByArray(bool vis, int idx)
	{
		vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_32(GetCppThis(), (byte)(vis ? 1u : 0u), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_33(HandleRef pThis, string name);

	/// <summary>
	///
	/// </summary>
	public virtual void SetGraphEdgeColorArrayName(string name)
	{
		vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_33(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_34(HandleRef pThis, string name, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual void SetGraphEdgeColorArrayName(string name, int idx)
	{
		vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_34(GetCppThis(), name, idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_35(HandleRef pThis);

	/// <summary>
	///
	/// </summary>
	public virtual void SetGraphEdgeColorToSplineFraction()
	{
		vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_36(HandleRef pThis, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual void SetGraphEdgeColorToSplineFraction(int idx)
	{
		vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_36(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_37(HandleRef pThis, string name);

	/// <summary>
	///
	/// </summary>
	public virtual void SetGraphEdgeLabelArrayName(string name)
	{
		vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_37(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_38(HandleRef pThis, string name, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual void SetGraphEdgeLabelArrayName(string name, int idx)
	{
		vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_38(GetCppThis(), name, idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_39(HandleRef pThis, int size);

	/// <summary>
	/// Sets the spline type for the graph edges.
	/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
	/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
	/// The default is BSPLINE.
	/// </summary>
	public virtual void SetGraphEdgeLabelFontSize(int size)
	{
		vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_39(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_40(HandleRef pThis, int size, int idx);

	/// <summary>
	/// Sets the spline type for the graph edges.
	/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
	/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
	/// The default is BSPLINE.
	/// </summary>
	public virtual void SetGraphEdgeLabelFontSize(int size, int idx)
	{
		vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_40(GetCppThis(), size, idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_41(HandleRef pThis, byte vis);

	/// <summary>
	///
	/// </summary>
	public virtual void SetGraphEdgeLabelVisibility(bool vis)
	{
		vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_41(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_42(HandleRef pThis, byte vis, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual void SetGraphEdgeLabelVisibility(bool vis, int idx)
	{
		vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_42(GetCppThis(), (byte)(vis ? 1u : 0u), idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphSplineType_43(HandleRef pThis, int type, int idx);

	/// <summary>
	/// Sets the spline type for the graph edges.
	/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
	/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
	/// The default is BSPLINE.
	/// </summary>
	public virtual void SetGraphSplineType(int type, int idx)
	{
		vtkRenderedHierarchyRepresentation_SetGraphSplineType_43(GetCppThis(), type, idx);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphVisibility_44(HandleRef pThis, byte vis);

	/// <summary>
	///
	/// </summary>
	public virtual void SetGraphVisibility(bool vis)
	{
		vtkRenderedHierarchyRepresentation_SetGraphVisibility_44(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedHierarchyRepresentation_SetGraphVisibility_45(HandleRef pThis, byte vis, int idx);

	/// <summary>
	///
	/// </summary>
	public virtual void SetGraphVisibility(bool vis, int idx)
	{
		vtkRenderedHierarchyRepresentation_SetGraphVisibility_45(GetCppThis(), (byte)(vis ? 1u : 0u), idx);
	}
}
