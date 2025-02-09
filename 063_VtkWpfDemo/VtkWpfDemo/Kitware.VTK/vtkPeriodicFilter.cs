using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPeriodicFilter
/// </summary>
/// <remarks>
///    A filter to produce mapped  periodic
/// multiblock dataset from a single block
///
///
/// Generate periodic dataset by transforming points, vectors, tensors
/// data arrays from an original data array.
/// The generated dataset is of the same type than the input (float or double).
/// This is an abstract class which do not implement the actual transformation.
/// Point coordinates are transformed, as well as all vectors (3-components) and
/// tensors (9 components) in points and cell data arrays.
/// The generated multiblock will have the same tree architecture than the input,
/// except transformed leaves are replaced by a vtkMultipieceDataSet.
/// Supported input leaf dataset type are: vtkPolyData, vtkStructuredGrid
/// and vtkUnstructuredGrid. Other data objects are transformed using the
/// transform filter (at a high cost!).
/// </remarks>
public abstract class vtkPeriodicFilter : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPeriodicFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPeriodicFilter()
	{
		MRClassNameKey = "class vtkPeriodicFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPeriodicFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPeriodicFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPeriodicFilter_AddIndex_01(HandleRef pThis, uint index);

	/// <summary>
	/// Select the periodic pieces indices.
	/// Each node in the multi - block tree is identified by an \c index. The index can
	/// be obtained by performing a preorder traversal of the tree (including empty
	/// nodes). eg. A(B (D, E), C(F, G)).
	/// Inorder traversal yields: A, B, D, E, C, F, G
	/// Index of A is 0, while index of C is 4.
	/// </summary>
	public virtual void AddIndex(uint index)
	{
		vtkPeriodicFilter_AddIndex_01(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPeriodicFilter_GetIterationMode_02(HandleRef pThis);

	/// <summary>
	/// Set/Get Iteration mode.
	/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
	/// VTK_ITERATION_MODE_MAX to generate a full period (default).
	/// </summary>
	public virtual int GetIterationMode()
	{
		return vtkPeriodicFilter_GetIterationMode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPeriodicFilter_GetIterationModeMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Set/Get Iteration mode.
	/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
	/// VTK_ITERATION_MODE_MAX to generate a full period (default).
	/// </summary>
	public virtual int GetIterationModeMaxValue()
	{
		return vtkPeriodicFilter_GetIterationModeMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPeriodicFilter_GetIterationModeMinValue_04(HandleRef pThis);

	/// <summary>
	/// Set/Get Iteration mode.
	/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
	/// VTK_ITERATION_MODE_MAX to generate a full period (default).
	/// </summary>
	public virtual int GetIterationModeMinValue()
	{
		return vtkPeriodicFilter_GetIterationModeMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPeriodicFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPeriodicFilter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPeriodicFilter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPeriodicFilter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPeriodicFilter_GetNumberOfPeriods_07(HandleRef pThis);

	/// <summary>
	/// Set/Get Number of periods.
	/// Used only with ITERATION_MODE_DIRECT_NB.
	/// </summary>
	public virtual int GetNumberOfPeriods()
	{
		return vtkPeriodicFilter_GetNumberOfPeriods_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPeriodicFilter_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPeriodicFilter_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPeriodicFilter_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPeriodicFilter_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPeriodicFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPeriodicFilter NewInstance()
	{
		vtkPeriodicFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPeriodicFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPeriodicFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPeriodicFilter_RemoveAllIndices_11(HandleRef pThis);

	/// <summary>
	/// Clear selected indices tree
	/// </summary>
	public virtual void RemoveAllIndices()
	{
		vtkPeriodicFilter_RemoveAllIndices_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPeriodicFilter_RemoveIndex_12(HandleRef pThis, uint index);

	/// <summary>
	/// Remove an index from selected indices tress
	/// </summary>
	public virtual void RemoveIndex(uint index)
	{
		vtkPeriodicFilter_RemoveIndex_12(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPeriodicFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPeriodicFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPeriodicFilter vtkPeriodicFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPeriodicFilter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPeriodicFilter2 = (vtkPeriodicFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPeriodicFilter2.Register(null);
			}
		}
		return vtkPeriodicFilter2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPeriodicFilter_SetIterationMode_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get Iteration mode.
	/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
	/// VTK_ITERATION_MODE_MAX to generate a full period (default).
	/// </summary>
	public virtual void SetIterationMode(int _arg)
	{
		vtkPeriodicFilter_SetIterationMode_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPeriodicFilter_SetIterationModeToDirectNb_15(HandleRef pThis);

	/// <summary>
	/// Set/Get Iteration mode.
	/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
	/// VTK_ITERATION_MODE_MAX to generate a full period (default).
	/// </summary>
	public void SetIterationModeToDirectNb()
	{
		vtkPeriodicFilter_SetIterationModeToDirectNb_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPeriodicFilter_SetIterationModeToMax_16(HandleRef pThis);

	/// <summary>
	/// Set/Get Iteration mode.
	/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
	/// VTK_ITERATION_MODE_MAX to generate a full period (default).
	/// </summary>
	public void SetIterationModeToMax()
	{
		vtkPeriodicFilter_SetIterationModeToMax_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPeriodicFilter_SetNumberOfPeriods_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get Number of periods.
	/// Used only with ITERATION_MODE_DIRECT_NB.
	/// </summary>
	public virtual void SetNumberOfPeriods(int _arg)
	{
		vtkPeriodicFilter_SetNumberOfPeriods_17(GetCppThis(), _arg);
	}
}
