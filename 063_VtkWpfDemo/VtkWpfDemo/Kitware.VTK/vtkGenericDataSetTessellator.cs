using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericDataSetTessellator
/// </summary>
/// <remarks>
///    tessellates generic, higher-order datasets into linear cells
///
///
/// vtkGenericDataSetTessellator is a filter that subdivides a
/// vtkGenericDataSet into linear elements (i.e., linear VTK
/// cells). Tetrahedras are produced from 3D cells; triangles from 2D cells;
/// and lines from 1D cells. The subdivision process depends on the cell
/// tessellator associated with the input generic dataset, and its associated
/// error metric. (These can be specified by the user if necessary.)
///
/// This filter is typically used to convert a higher-order, complex dataset
/// represented by a vtkGenericDataSet into a conventional vtkDataSet that can
/// be operated on by linear VTK graphics filters (end of pipeline for
/// rendering).
///
/// </remarks>
/// <seealso>
///
/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric
/// </seealso>
public class vtkGenericDataSetTessellator : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericDataSetTessellator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericDataSetTessellator()
	{
		MRClassNameKey = "class vtkGenericDataSetTessellator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericDataSetTessellator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericDataSetTessellator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSetTessellator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkGenericDataSetTessellator New()
	{
		vtkGenericDataSetTessellator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSetTessellator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericDataSetTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public vtkGenericDataSetTessellator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericDataSetTessellator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSetTessellator_CreateDefaultLocator_01(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkGenericDataSetTessellator_CreateDefaultLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericDataSetTessellator_GetKeepCellIds_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off generation of a cell centered attribute with ids of the
	/// original cells (as an input cell is tessellated into several linear
	/// cells).
	/// The name of the data array is "OriginalIds". It is true by default.
	/// </summary>
	public virtual int GetKeepCellIds()
	{
		return vtkGenericDataSetTessellator_GetKeepCellIds_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSetTessellator_GetLocator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkGenericDataSetTessellator_GetLocator_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGenericDataSetTessellator_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGenericDataSetTessellator_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericDataSetTessellator_GetMerging_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual int GetMerging()
	{
		return vtkGenericDataSetTessellator_GetMerging_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericDataSetTessellator_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericDataSetTessellator_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericDataSetTessellator_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericDataSetTessellator_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericDataSetTessellator_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericDataSetTessellator_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericDataSetTessellator_IsTypeOf_09(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericDataSetTessellator_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSetTessellator_KeepCellIdsOff_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off generation of a cell centered attribute with ids of the
	/// original cells (as an input cell is tessellated into several linear
	/// cells).
	/// The name of the data array is "OriginalIds". It is true by default.
	/// </summary>
	public virtual void KeepCellIdsOff()
	{
		vtkGenericDataSetTessellator_KeepCellIdsOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSetTessellator_KeepCellIdsOn_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off generation of a cell centered attribute with ids of the
	/// original cells (as an input cell is tessellated into several linear
	/// cells).
	/// The name of the data array is "OriginalIds". It is true by default.
	/// </summary>
	public virtual void KeepCellIdsOn()
	{
		vtkGenericDataSetTessellator_KeepCellIdsOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSetTessellator_MergingOff_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void MergingOff()
	{
		vtkGenericDataSetTessellator_MergingOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSetTessellator_MergingOn_13(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void MergingOn()
	{
		vtkGenericDataSetTessellator_MergingOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSetTessellator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkGenericDataSetTessellator NewInstance()
	{
		vtkGenericDataSetTessellator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSetTessellator_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericDataSetTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSetTessellator_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkGenericDataSetTessellator SafeDownCast(vtkObjectBase o)
	{
		vtkGenericDataSetTessellator vtkGenericDataSetTessellator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSetTessellator_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericDataSetTessellator2 = (vtkGenericDataSetTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericDataSetTessellator2.Register(null);
			}
		}
		return vtkGenericDataSetTessellator2;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSetTessellator_SetKeepCellIds_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off generation of a cell centered attribute with ids of the
	/// original cells (as an input cell is tessellated into several linear
	/// cells).
	/// The name of the data array is "OriginalIds". It is true by default.
	/// </summary>
	public virtual void SetKeepCellIds(int _arg)
	{
		vtkGenericDataSetTessellator_SetKeepCellIds_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSetTessellator_SetLocator_18(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / get a spatial locator for merging points. By
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkGenericDataSetTessellator_SetLocator_18(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSetTessellator_SetMerging_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void SetMerging(int _arg)
	{
		vtkGenericDataSetTessellator_SetMerging_19(GetCppThis(), _arg);
	}
}
