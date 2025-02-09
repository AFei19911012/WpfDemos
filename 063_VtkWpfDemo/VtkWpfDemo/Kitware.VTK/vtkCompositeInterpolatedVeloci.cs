using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCompositeInterpolatedVelocityField
/// </summary>
/// <remarks>
///    An abstract class for
///  obtaining the interpolated velocity values at a point
///
///  vtkCompositeInterpolatedVelocityField acts as a continuous velocity field
///  by performing cell interpolation on one or more underlying vtkDataSets. That is,
///  composite datasets are combined to create a continuous velocity field. The default
///  strategy is to use the closest point strategy.
///
/// @warning
///  vtkCompositeInterpolatedVelocityField is not thread safe. A new instance
///  should be created by each thread.
///
/// </remarks>
/// <seealso>
///
///  vtkAbstractInterpolatedVelocityField vtkAMRInterpolatedVelocityField
///  vtkGenericInterpolatedVelocityField vtkCachingInterpolatedVelocityField
///  vtkTemporalInterpolatedVelocityField vtkFunctionSet vtkStreamTracer
/// </seealso>
public class vtkCompositeInterpolatedVelocityField : vtkAbstractInterpolatedVelocityField
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeInterpolatedVelocityField";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompositeInterpolatedVelocityField()
	{
		MRClassNameKey = "class vtkCompositeInterpolatedVelocityField";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeInterpolatedVelocityField"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompositeInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vtkCompositeInterpolatedVelocityField class.
	/// </summary>
	public new static vtkCompositeInterpolatedVelocityField New()
	{
		vtkCompositeInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a vtkCompositeInterpolatedVelocityField class.
	/// </summary>
	public vtkCompositeInterpolatedVelocityField()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCompositeInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeInterpolatedVelocityField_AddDataSet_01(HandleRef pThis, HandleRef dataset, ulong maxCellSize);

	/// <summary>
	/// Add a dataset for implicit velocity function evaluation. If more than
	/// one dataset is added, the evaluation point is searched in all until a
	/// match is found. THIS FUNCTION DOES NOT CHANGE THE REFERENCE COUNT OF
	/// dataset FOR THREAD SAFETY REASONS. MaxCellSize can be passed to avoid
	/// recomputing GetMaxCellSize().
	/// </summary>
	public virtual void AddDataSet(vtkDataSet dataset, ulong maxCellSize)
	{
		vtkCompositeInterpolatedVelocityField_AddDataSet_01(GetCppThis(), dataset?.GetCppThis() ?? default(HandleRef), maxCellSize);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeInterpolatedVelocityField_CopyParameters_02(HandleRef pThis, HandleRef from);

	/// <summary>
	/// Copy essential parameters between instances of this class. See
	/// vtkAbstractInterpolatedVelocityField for more information.
	/// </summary>
	public override void CopyParameters(vtkAbstractInterpolatedVelocityField from)
	{
		vtkCompositeInterpolatedVelocityField_CopyParameters_02(GetCppThis(), from?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeInterpolatedVelocityField_FunctionValues_03(HandleRef pThis, IntPtr x, IntPtr f);

	/// <summary>
	/// Evaluate the velocity field f at point (x, y, z).
	/// </summary>
	public override int FunctionValues(IntPtr x, IntPtr f)
	{
		return vtkCompositeInterpolatedVelocityField_FunctionValues_03(GetCppThis(), x, f);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeInterpolatedVelocityField_GetCacheDataSetHit_04(HandleRef pThis);

	/// <summary>
	/// Get Cache DataSet hits and misses.
	/// </summary>
	public virtual int GetCacheDataSetHit()
	{
		return vtkCompositeInterpolatedVelocityField_GetCacheDataSetHit_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeInterpolatedVelocityField_GetCacheDataSetMiss_05(HandleRef pThis);

	/// <summary>
	/// Get Cache DataSet hits and misses.
	/// </summary>
	public virtual int GetCacheDataSetMiss()
	{
		return vtkCompositeInterpolatedVelocityField_GetCacheDataSetMiss_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeInterpolatedVelocityField_GetLastDataSetIndex_06(HandleRef pThis);

	/// <summary>
	/// Get the most recently visited dataset and its id. The dataset is used
	/// for a guess regarding where the next point will be, without searching
	/// through all datasets. When setting the last dataset, care is needed as
	/// no reference counting or checks are performed. This feature is intended
	/// for custom interpolators only that cache datasets independently.
	/// </summary>
	public virtual int GetLastDataSetIndex()
	{
		return vtkCompositeInterpolatedVelocityField_GetLastDataSetIndex_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeInterpolatedVelocityField_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompositeInterpolatedVelocityField_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompositeInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeInterpolatedVelocityField_InsideTest_09(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Check if point x is inside the dataset.
	/// </summary>
	public int InsideTest(IntPtr x)
	{
		return vtkCompositeInterpolatedVelocityField_InsideTest_09(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeInterpolatedVelocityField_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompositeInterpolatedVelocityField_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeInterpolatedVelocityField_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompositeInterpolatedVelocityField_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeInterpolatedVelocityField_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkCompositeInterpolatedVelocityField NewInstance()
	{
		vtkCompositeInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeInterpolatedVelocityField_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeInterpolatedVelocityField_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkCompositeInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
	{
		vtkCompositeInterpolatedVelocityField vtkCompositeInterpolatedVelocityField2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeInterpolatedVelocityField_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeInterpolatedVelocityField2 = (vtkCompositeInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeInterpolatedVelocityField2.Register(null);
			}
		}
		return vtkCompositeInterpolatedVelocityField2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeInterpolatedVelocityField_SetLastCellId_15(HandleRef pThis, long c, int dataindex);

	/// <summary>
	/// Set the cell id cached by the last evaluation within a specified dataset.
	/// </summary>
	public override void SetLastCellId(long c, int dataindex)
	{
		vtkCompositeInterpolatedVelocityField_SetLastCellId_15(GetCppThis(), c, dataindex);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeInterpolatedVelocityField_SetLastCellId_16(HandleRef pThis, long c);

	/// <summary>
	/// Set the cell id cached by the last evaluation.
	/// </summary>
	public override void SetLastCellId(long c)
	{
		vtkCompositeInterpolatedVelocityField_SetLastCellId_16(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeInterpolatedVelocityField_SnapPointOnCell_17(HandleRef pThis, IntPtr pOrigin, IntPtr pProj);

	/// <summary>
	/// Project the provided point on current cell, current dataset.
	/// </summary>
	public virtual int SnapPointOnCell(IntPtr pOrigin, IntPtr pProj)
	{
		return vtkCompositeInterpolatedVelocityField_SnapPointOnCell_17(GetCppThis(), pOrigin, pProj);
	}
}
