using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAggregateDataSetFilter
/// </summary>
/// <remarks>
///    Aggregates data sets to a reduced number of processes.
///
/// This class allows polydata and unstructured grids to be aggregated
/// over a smaller set of processes. The derived vtkDIYAggregateDataSetFilter
/// will operate on image data, rectilinear grids and structured grids.
/// </remarks>
public class vtkAggregateDataSetFilter : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAggregateDataSetFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAggregateDataSetFilter()
	{
		MRClassNameKey = "class vtkAggregateDataSetFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAggregateDataSetFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAggregateDataSetFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAggregateDataSetFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAggregateDataSetFilter New()
	{
		vtkAggregateDataSetFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAggregateDataSetFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAggregateDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAggregateDataSetFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAggregateDataSetFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAggregateDataSetFilter_GetMergePoints_01(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note 1: The filter will only merge points if the ghost cell array doesn't exist
	/// Note 2: This option is only taken into account with vtkUnstructuredGrid objects
	/// Defaults to On
	/// </summary>
	public virtual bool GetMergePoints()
	{
		return (vtkAggregateDataSetFilter_GetMergePoints_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAggregateDataSetFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAggregateDataSetFilter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAggregateDataSetFilter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAggregateDataSetFilter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAggregateDataSetFilter_GetNumberOfTargetProcesses_04(HandleRef pThis);

	/// <summary>
	/// Number of target processes. Valid values are between 1 and the total
	/// number of processes. The default is 1. If a value is passed in that
	/// is less than 1 than NumberOfTargetProcesses is changed/kept at 1.
	/// If a value is passed in that is greater than the total number of
	/// processes then NumberOfTargetProcesses is changed/kept at the
	/// total number of processes. This is useful for scripting use cases
	/// where later on the script is run with more processes than the
	/// current amount.
	/// </summary>
	public virtual int GetNumberOfTargetProcesses()
	{
		return vtkAggregateDataSetFilter_GetNumberOfTargetProcesses_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAggregateDataSetFilter_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAggregateDataSetFilter_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAggregateDataSetFilter_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAggregateDataSetFilter_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAggregateDataSetFilter_MergePointsOff_07(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note 1: The filter will only merge points if the ghost cell array doesn't exist
	/// Note 2: This option is only taken into account with vtkUnstructuredGrid objects
	/// Defaults to On
	/// </summary>
	public virtual void MergePointsOff()
	{
		vtkAggregateDataSetFilter_MergePointsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAggregateDataSetFilter_MergePointsOn_08(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note 1: The filter will only merge points if the ghost cell array doesn't exist
	/// Note 2: This option is only taken into account with vtkUnstructuredGrid objects
	/// Defaults to On
	/// </summary>
	public virtual void MergePointsOn()
	{
		vtkAggregateDataSetFilter_MergePointsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAggregateDataSetFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAggregateDataSetFilter NewInstance()
	{
		vtkAggregateDataSetFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAggregateDataSetFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAggregateDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAggregateDataSetFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAggregateDataSetFilter SafeDownCast(vtkObjectBase o)
	{
		vtkAggregateDataSetFilter vtkAggregateDataSetFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAggregateDataSetFilter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAggregateDataSetFilter2 = (vtkAggregateDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAggregateDataSetFilter2.Register(null);
			}
		}
		return vtkAggregateDataSetFilter2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAggregateDataSetFilter_SetMergePoints_12(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note 1: The filter will only merge points if the ghost cell array doesn't exist
	/// Note 2: This option is only taken into account with vtkUnstructuredGrid objects
	/// Defaults to On
	/// </summary>
	public virtual void SetMergePoints(bool _arg)
	{
		vtkAggregateDataSetFilter_SetMergePoints_12(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAggregateDataSetFilter_SetNumberOfTargetProcesses_13(HandleRef pThis, int arg0);

	/// <summary>
	/// Number of target processes. Valid values are between 1 and the total
	/// number of processes. The default is 1. If a value is passed in that
	/// is less than 1 than NumberOfTargetProcesses is changed/kept at 1.
	/// If a value is passed in that is greater than the total number of
	/// processes then NumberOfTargetProcesses is changed/kept at the
	/// total number of processes. This is useful for scripting use cases
	/// where later on the script is run with more processes than the
	/// current amount.
	/// </summary>
	public void SetNumberOfTargetProcesses(int arg0)
	{
		vtkAggregateDataSetFilter_SetNumberOfTargetProcesses_13(GetCppThis(), arg0);
	}
}
