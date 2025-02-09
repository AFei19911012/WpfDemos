using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellCenters
/// </summary>
/// <remarks>
///    generate points at center of cells
///
/// vtkCellCenters is a filter that takes as input any dataset and
/// generates on output points at the center of the cells in the dataset.
/// These points can be used for placing glyphs (vtkGlyph3D) or labeling
/// (vtkLabeledDataMapper). (The center is the parametric center of the
/// cell, not necessarily the geometric or bounding box center.) The cell
/// attributes will be associated with the points on output.
///
/// @warning
/// You can choose to generate just points or points and vertex cells.
/// Vertex cells are drawn during rendering; points are not. Use the ivar
/// VertexCells to generate cells.
///
/// @note
/// Empty cells will be ignored but will require a one by one cell to
/// point data copy that will make the processing slower.
///
/// </remarks>
/// <seealso>
///
/// vtkGlyph3D vtkLabeledDataMapper
/// </seealso>
public class vtkCellCenters : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellCenters";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellCenters()
	{
		MRClassNameKey = "class vtkCellCenters";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellCenters"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellCenters(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellCenters_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with vertex cell generation turned off.
	/// </summary>
	public new static vtkCellCenters New()
	{
		vtkCellCenters result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellCenters_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellCenters)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with vertex cell generation turned off.
	/// </summary>
	public vtkCellCenters()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellCenters_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCellCenters_ComputeCellCenters_01(HandleRef dataset, HandleRef centers);

	/// <summary>
	/// Compute centers of cells from a dataset, storing them in the centers array.
	/// </summary>
	public static void ComputeCellCenters(vtkDataSet dataset, vtkDoubleArray centers)
	{
		vtkCellCenters_ComputeCellCenters_01(dataset?.GetCppThis() ?? default(HandleRef), centers?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellCenters_CopyArraysOff_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether input cell data arrays should be passed through (or
	/// copied) as output point data arrays. Default is `true` i.e. the arrays will
	/// be propagated.
	/// </summary>
	public virtual void CopyArraysOff()
	{
		vtkCellCenters_CopyArraysOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellCenters_CopyArraysOn_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether input cell data arrays should be passed through (or
	/// copied) as output point data arrays. Default is `true` i.e. the arrays will
	/// be propagated.
	/// </summary>
	public virtual void CopyArraysOn()
	{
		vtkCellCenters_CopyArraysOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellCenters_GetCopyArrays_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether input cell data arrays should be passed through (or
	/// copied) as output point data arrays. Default is `true` i.e. the arrays will
	/// be propagated.
	/// </summary>
	public virtual bool GetCopyArrays()
	{
		return (vtkCellCenters_GetCopyArrays_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellCenters_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellCenters_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellCenters_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellCenters_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellCenters_GetVertexCells_07(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of vertex cells. The default
	/// is Off.
	/// </summary>
	public virtual bool GetVertexCells()
	{
		return (vtkCellCenters_GetVertexCells_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCenters_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellCenters_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCenters_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellCenters_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellCenters_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCellCenters NewInstance()
	{
		vtkCellCenters result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellCenters_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellCenters)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellCenters_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellCenters SafeDownCast(vtkObjectBase o)
	{
		vtkCellCenters vtkCellCenters2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellCenters_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellCenters2 = (vtkCellCenters)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellCenters2.Register(null);
			}
		}
		return vtkCellCenters2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellCenters_SetCopyArrays_13(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable whether input cell data arrays should be passed through (or
	/// copied) as output point data arrays. Default is `true` i.e. the arrays will
	/// be propagated.
	/// </summary>
	public virtual void SetCopyArrays(bool _arg)
	{
		vtkCellCenters_SetCopyArrays_13(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellCenters_SetVertexCells_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable the generation of vertex cells. The default
	/// is Off.
	/// </summary>
	public virtual void SetVertexCells(bool _arg)
	{
		vtkCellCenters_SetVertexCells_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellCenters_VertexCellsOff_15(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of vertex cells. The default
	/// is Off.
	/// </summary>
	public virtual void VertexCellsOff()
	{
		vtkCellCenters_VertexCellsOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellCenters_VertexCellsOn_16(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of vertex cells. The default
	/// is Off.
	/// </summary>
	public virtual void VertexCellsOn()
	{
		vtkCellCenters_VertexCellsOn_16(GetCppThis());
	}
}
