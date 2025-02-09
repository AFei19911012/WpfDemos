using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFeatureEdges
/// </summary>
/// <remarks>
///    extract interior, boundary, non-manifold, and/or
///          sharp edges from polygonal data
///
/// vtkFeatureEdges is a filter to extract special types of edges from
/// input polygonal data. These edges are either 1) boundary (used by
/// one polygon) or a line cell; 2) non-manifold (used by three or more
/// polygons); 3) feature edges (edges used by two triangles and whose
/// dihedral angle &gt; FeatureAngle); or 4) manifold edges (edges used by
/// exactly two polygons). These edges may be extracted in any
/// combination. Edges may also be "colored" (i.e., scalar values assigned)
/// based on edge type. The cell coloring is assigned to the cell data of
/// the extracted edges.
///
/// @warning
/// To see the coloring of the lines you may have to set the ScalarMode
/// instance variable of the mapper to SetScalarModeToUseCellData(). (This
/// is only a problem if there are point data scalars.)
///
/// </remarks>
/// <seealso>
///
/// vtkExtractEdges
/// </seealso>
public class vtkFeatureEdges : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFeatureEdges";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFeatureEdges()
	{
		MRClassNameKey = "class vtkFeatureEdges";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFeatureEdges"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFeatureEdges(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFeatureEdges_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance with feature angle = 30; all types of edges
	/// (except manifold edges) are extracted and colored.
	/// </summary>
	public new static vtkFeatureEdges New()
	{
		vtkFeatureEdges result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFeatureEdges_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct an instance with feature angle = 30; all types of edges
	/// (except manifold edges) are extracted and colored.
	/// </summary>
	public vtkFeatureEdges()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFeatureEdges_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFeatureEdges_BoundaryEdgesOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of boundary edges.
	/// </summary>
	public virtual void BoundaryEdgesOff()
	{
		vtkFeatureEdges_BoundaryEdgesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_BoundaryEdgesOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of boundary edges.
	/// </summary>
	public virtual void BoundaryEdgesOn()
	{
		vtkFeatureEdges_BoundaryEdgesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_ColoringOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of edges by type.
	/// </summary>
	public virtual void ColoringOff()
	{
		vtkFeatureEdges_ColoringOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_ColoringOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of edges by type.
	/// </summary>
	public virtual void ColoringOn()
	{
		vtkFeatureEdges_ColoringOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_CreateDefaultLocator_05(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkFeatureEdges_CreateDefaultLocator_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_ExtractAllEdgeTypesOff_06(HandleRef pThis);

	/// <summary>
	/// Methods for turning the extraction of all types of edges on;
	/// and turning the extraction of all types of edges off.
	/// </summary>
	public void ExtractAllEdgeTypesOff()
	{
		vtkFeatureEdges_ExtractAllEdgeTypesOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_ExtractAllEdgeTypesOn_07(HandleRef pThis);

	/// <summary>
	/// Methods for turning the extraction of all types of edges on;
	/// and turning the extraction of all types of edges off.
	/// </summary>
	public void ExtractAllEdgeTypesOn()
	{
		vtkFeatureEdges_ExtractAllEdgeTypesOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_FeatureEdgesOff_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of feature edges.
	/// </summary>
	public virtual void FeatureEdgesOff()
	{
		vtkFeatureEdges_FeatureEdgesOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_FeatureEdgesOn_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of feature edges.
	/// </summary>
	public virtual void FeatureEdgesOn()
	{
		vtkFeatureEdges_FeatureEdgesOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFeatureEdges_GetBoundaryEdges_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of boundary edges.
	/// </summary>
	public virtual bool GetBoundaryEdges()
	{
		return (vtkFeatureEdges_GetBoundaryEdges_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFeatureEdges_GetColoring_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of edges by type.
	/// </summary>
	public virtual bool GetColoring()
	{
		return (vtkFeatureEdges_GetColoring_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFeatureEdges_GetFeatureAngle_12(HandleRef pThis);

	/// <summary>
	/// Specify the feature angle for extracting feature edges.
	/// </summary>
	public virtual double GetFeatureAngle()
	{
		return vtkFeatureEdges_GetFeatureAngle_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFeatureEdges_GetFeatureAngleMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Specify the feature angle for extracting feature edges.
	/// </summary>
	public virtual double GetFeatureAngleMaxValue()
	{
		return vtkFeatureEdges_GetFeatureAngleMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFeatureEdges_GetFeatureAngleMinValue_14(HandleRef pThis);

	/// <summary>
	/// Specify the feature angle for extracting feature edges.
	/// </summary>
	public virtual double GetFeatureAngleMinValue()
	{
		return vtkFeatureEdges_GetFeatureAngleMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFeatureEdges_GetFeatureEdges_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of feature edges.
	/// </summary>
	public virtual bool GetFeatureEdges()
	{
		return (vtkFeatureEdges_GetFeatureEdges_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFeatureEdges_GetLocator_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get a spatial locator for merging points. By
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFeatureEdges_GetLocator_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkFeatureEdges_GetMTime_17(HandleRef pThis);

	/// <summary>
	/// Return MTime also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkFeatureEdges_GetMTime_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFeatureEdges_GetManifoldEdges_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of manifold edges. This typically
	/// correspond to interior edges.
	/// </summary>
	public virtual bool GetManifoldEdges()
	{
		return (vtkFeatureEdges_GetManifoldEdges_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFeatureEdges_GetNonManifoldEdges_19(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of non-manifold edges.
	/// </summary>
	public virtual bool GetNonManifoldEdges()
	{
		return (vtkFeatureEdges_GetNonManifoldEdges_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFeatureEdges_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFeatureEdges_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFeatureEdges_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFeatureEdges_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFeatureEdges_GetOutputPointsPrecision_22(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output point type. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkFeatureEdges_GetOutputPointsPrecision_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFeatureEdges_GetPassLines_23(HandleRef pThis);

	/// <summary>
	/// Turn on/off passing input lines. If this flag is on, then all cells living inside the `Lines`
	/// cell array of the input are copied into the output.
	///
	/// @note Input poly lines are split into separate lines in the output.
	/// </summary>
	public virtual bool GetPassLines()
	{
		return (vtkFeatureEdges_GetPassLines_23(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFeatureEdges_GetRemoveGhostInterfaces_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off creating edges at ghost interfaces. An edge is at a ghost interface
	/// if it belongs to at least one ghost cell. This is turned on by default.
	/// When turned off, only edges that solely belong to ghost cells are discarded from the output.
	/// When turned on, edges are discarded if the belong to at least one ghost cell.
	///
	/// @note In order for the interfaces between ranks to be removed, ghost cells must be first
	/// generated.
	/// @sa vtkGhostCellsGenerator
	/// </summary>
	public virtual bool GetRemoveGhostInterfaces()
	{
		return (vtkFeatureEdges_GetRemoveGhostInterfaces_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFeatureEdges_IsA_25(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFeatureEdges_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFeatureEdges_IsTypeOf_26(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFeatureEdges_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_ManifoldEdgesOff_27(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of manifold edges. This typically
	/// correspond to interior edges.
	/// </summary>
	public virtual void ManifoldEdgesOff()
	{
		vtkFeatureEdges_ManifoldEdgesOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_ManifoldEdgesOn_28(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of manifold edges. This typically
	/// correspond to interior edges.
	/// </summary>
	public virtual void ManifoldEdgesOn()
	{
		vtkFeatureEdges_ManifoldEdgesOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFeatureEdges_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkFeatureEdges NewInstance()
	{
		vtkFeatureEdges result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFeatureEdges_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_NonManifoldEdgesOff_31(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of non-manifold edges.
	/// </summary>
	public virtual void NonManifoldEdgesOff()
	{
		vtkFeatureEdges_NonManifoldEdgesOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_NonManifoldEdgesOn_32(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of non-manifold edges.
	/// </summary>
	public virtual void NonManifoldEdgesOn()
	{
		vtkFeatureEdges_NonManifoldEdgesOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_PassLinesOff_33(HandleRef pThis);

	/// <summary>
	/// Turn on/off passing input lines. If this flag is on, then all cells living inside the `Lines`
	/// cell array of the input are copied into the output.
	///
	/// @note Input poly lines are split into separate lines in the output.
	/// </summary>
	public virtual void PassLinesOff()
	{
		vtkFeatureEdges_PassLinesOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_PassLinesOn_34(HandleRef pThis);

	/// <summary>
	/// Turn on/off passing input lines. If this flag is on, then all cells living inside the `Lines`
	/// cell array of the input are copied into the output.
	///
	/// @note Input poly lines are split into separate lines in the output.
	/// </summary>
	public virtual void PassLinesOn()
	{
		vtkFeatureEdges_PassLinesOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_RemoveGhostInterfacesOff_35(HandleRef pThis);

	/// <summary>
	/// Turn on/off creating edges at ghost interfaces. An edge is at a ghost interface
	/// if it belongs to at least one ghost cell. This is turned on by default.
	/// When turned off, only edges that solely belong to ghost cells are discarded from the output.
	/// When turned on, edges are discarded if the belong to at least one ghost cell.
	///
	/// @note In order for the interfaces between ranks to be removed, ghost cells must be first
	/// generated.
	/// @sa vtkGhostCellsGenerator
	/// </summary>
	public virtual void RemoveGhostInterfacesOff()
	{
		vtkFeatureEdges_RemoveGhostInterfacesOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_RemoveGhostInterfacesOn_36(HandleRef pThis);

	/// <summary>
	/// Turn on/off creating edges at ghost interfaces. An edge is at a ghost interface
	/// if it belongs to at least one ghost cell. This is turned on by default.
	/// When turned off, only edges that solely belong to ghost cells are discarded from the output.
	/// When turned on, edges are discarded if the belong to at least one ghost cell.
	///
	/// @note In order for the interfaces between ranks to be removed, ghost cells must be first
	/// generated.
	/// @sa vtkGhostCellsGenerator
	/// </summary>
	public virtual void RemoveGhostInterfacesOn()
	{
		vtkFeatureEdges_RemoveGhostInterfacesOn_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFeatureEdges_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkFeatureEdges SafeDownCast(vtkObjectBase o)
	{
		vtkFeatureEdges vtkFeatureEdges2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFeatureEdges_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFeatureEdges2 = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFeatureEdges2.Register(null);
			}
		}
		return vtkFeatureEdges2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_SetBoundaryEdges_38(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the extraction of boundary edges.
	/// </summary>
	public virtual void SetBoundaryEdges(bool _arg)
	{
		vtkFeatureEdges_SetBoundaryEdges_38(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_SetColoring_39(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the coloring of edges by type.
	/// </summary>
	public virtual void SetColoring(bool _arg)
	{
		vtkFeatureEdges_SetColoring_39(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_SetFeatureAngle_40(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the feature angle for extracting feature edges.
	/// </summary>
	public virtual void SetFeatureAngle(double _arg)
	{
		vtkFeatureEdges_SetFeatureAngle_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_SetFeatureEdges_41(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the extraction of feature edges.
	/// </summary>
	public virtual void SetFeatureEdges(bool _arg)
	{
		vtkFeatureEdges_SetFeatureEdges_41(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_SetLocator_42(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / get a spatial locator for merging points. By
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkFeatureEdges_SetLocator_42(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_SetManifoldEdges_43(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the extraction of manifold edges. This typically
	/// correspond to interior edges.
	/// </summary>
	public virtual void SetManifoldEdges(bool _arg)
	{
		vtkFeatureEdges_SetManifoldEdges_43(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_SetNonManifoldEdges_44(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the extraction of non-manifold edges.
	/// </summary>
	public virtual void SetNonManifoldEdges(bool _arg)
	{
		vtkFeatureEdges_SetNonManifoldEdges_44(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_SetOutputPointsPrecision_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output point type. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkFeatureEdges_SetOutputPointsPrecision_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_SetPassLines_46(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off passing input lines. If this flag is on, then all cells living inside the `Lines`
	/// cell array of the input are copied into the output.
	///
	/// @note Input poly lines are split into separate lines in the output.
	/// </summary>
	public virtual void SetPassLines(bool _arg)
	{
		vtkFeatureEdges_SetPassLines_46(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFeatureEdges_SetRemoveGhostInterfaces_47(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off creating edges at ghost interfaces. An edge is at a ghost interface
	/// if it belongs to at least one ghost cell. This is turned on by default.
	/// When turned off, only edges that solely belong to ghost cells are discarded from the output.
	/// When turned on, edges are discarded if the belong to at least one ghost cell.
	///
	/// @note In order for the interfaces between ranks to be removed, ghost cells must be first
	/// generated.
	/// @sa vtkGhostCellsGenerator
	/// </summary>
	public virtual void SetRemoveGhostInterfaces(bool _arg)
	{
		vtkFeatureEdges_SetRemoveGhostInterfaces_47(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
