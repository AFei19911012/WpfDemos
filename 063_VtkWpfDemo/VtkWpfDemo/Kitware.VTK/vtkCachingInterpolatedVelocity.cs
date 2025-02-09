using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCachingInterpolatedVelocityField
/// </summary>
/// <remarks>
///    Interface for obtaining
/// interpolated velocity values
///
/// vtkCachingInterpolatedVelocityField acts as a continuous velocity field
/// by performing cell interpolation on the underlying vtkDataSet.
/// This is a concrete sub-class of vtkFunctionSet with
/// NumberOfIndependentVariables = 4 (x,y,z,t) and
/// NumberOfFunctions = 3 (u,v,w). Normally, every time an evaluation
/// is performed, the cell which contains the point (x,y,z) has to
/// be found by calling FindCell. This is a computationally expensive
/// operation. In certain cases, the cell search can be avoided or shortened
/// by providing a guess for the cell id. For example, in streamline
/// integration, the next evaluation is usually in the same or a neighbour
/// cell. For this reason, vtkCachingInterpolatedVelocityField stores the last
/// cell id. If caching is turned on, it uses this id as the starting point.
///
/// @warning
/// vtkCachingInterpolatedVelocityField is not thread safe. A new instance should
/// be created by each thread.
///
/// </remarks>
/// <seealso>
///
/// vtkFunctionSet vtkStreamTracer
///
/// @todo
/// Need to clean up style to match vtk/Kitware standards. Please help.
/// </seealso>
public class vtkCachingInterpolatedVelocityField : vtkFunctionSet
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCachingInterpolatedVelocityField";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCachingInterpolatedVelocityField()
	{
		MRClassNameKey = "class vtkCachingInterpolatedVelocityField";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCachingInterpolatedVelocityField"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCachingInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCachingInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vtkCachingInterpolatedVelocityField with no initial data set.
	/// LastCellId is set to -1.
	/// </summary>
	public new static vtkCachingInterpolatedVelocityField New()
	{
		vtkCachingInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCachingInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCachingInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a vtkCachingInterpolatedVelocityField with no initial data set.
	/// LastCellId is set to -1.
	/// </summary>
	public vtkCachingInterpolatedVelocityField()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCachingInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCachingInterpolatedVelocityField_ClearLastCellInfo_01(HandleRef pThis);

	/// <summary>
	/// Set LastCellId to -1 and Cache to nullptr so that the next
	/// search does not start from the previous cell.
	/// </summary>
	public void ClearLastCellInfo()
	{
		vtkCachingInterpolatedVelocityField_ClearLastCellInfo_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCachingInterpolatedVelocityField_FunctionValues_02(HandleRef pThis, IntPtr x, IntPtr f);

	/// <summary>
	/// Evaluate the velocity field, f={u,v,w}, at {x, y, z}.
	/// returns 1 if valid, 0 if test failed
	/// </summary>
	public override int FunctionValues(IntPtr x, IntPtr f)
	{
		return vtkCachingInterpolatedVelocityField_FunctionValues_02(GetCppThis(), x, f);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCachingInterpolatedVelocityField_GetCacheMiss_03(HandleRef pThis);

	/// <summary>
	/// Caching statistics.
	/// </summary>
	public virtual int GetCacheMiss()
	{
		return vtkCachingInterpolatedVelocityField_GetCacheMiss_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCachingInterpolatedVelocityField_GetCellCacheHit_04(HandleRef pThis);

	/// <summary>
	/// Caching statistics.
	/// </summary>
	public virtual int GetCellCacheHit()
	{
		return vtkCachingInterpolatedVelocityField_GetCellCacheHit_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCachingInterpolatedVelocityField_GetDataSetCacheHit_05(HandleRef pThis);

	/// <summary>
	/// Caching statistics.
	/// </summary>
	public virtual int GetDataSetCacheHit()
	{
		return vtkCachingInterpolatedVelocityField_GetDataSetCacheHit_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCachingInterpolatedVelocityField_GetLastLocalCoordinates_06(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Returns the interpolation weights/pcoords cached from last evaluation
	/// if the cached cell is valid (returns 1). Otherwise, it does not
	/// change w and returns 0.
	/// </summary>
	public int GetLastLocalCoordinates(IntPtr pcoords)
	{
		return vtkCachingInterpolatedVelocityField_GetLastLocalCoordinates_06(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCachingInterpolatedVelocityField_GetLastWeights_07(HandleRef pThis, IntPtr w);

	/// <summary>
	/// Returns the interpolation weights/pcoords cached from last evaluation
	/// if the cached cell is valid (returns 1). Otherwise, it does not
	/// change w and returns 0.
	/// </summary>
	public int GetLastWeights(IntPtr w)
	{
		return vtkCachingInterpolatedVelocityField_GetLastWeights_07(GetCppThis(), w);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCachingInterpolatedVelocityField_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCachingInterpolatedVelocityField_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCachingInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCachingInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCachingInterpolatedVelocityField_GetVectorsSelection_10(HandleRef pThis);

	/// <summary>
	/// If you want to work with an arbitrary vector array, then set its name
	/// here. By default this in nullptr and the filter will use the active vector
	/// array.
	/// </summary>
	public virtual string GetVectorsSelection()
	{
		return Marshal.PtrToStringAnsi(vtkCachingInterpolatedVelocityField_GetVectorsSelection_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCachingInterpolatedVelocityField_InsideTest_11(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate the velocity field, f={u,v,w}, at {x, y, z}.
	/// returns 1 if valid, 0 if test failed
	/// </summary>
	public virtual int InsideTest(IntPtr x)
	{
		return vtkCachingInterpolatedVelocityField_InsideTest_11(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCachingInterpolatedVelocityField_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCachingInterpolatedVelocityField_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCachingInterpolatedVelocityField_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCachingInterpolatedVelocityField_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCachingInterpolatedVelocityField_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCachingInterpolatedVelocityField NewInstance()
	{
		vtkCachingInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCachingInterpolatedVelocityField_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCachingInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCachingInterpolatedVelocityField_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCachingInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
	{
		vtkCachingInterpolatedVelocityField vtkCachingInterpolatedVelocityField2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCachingInterpolatedVelocityField_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCachingInterpolatedVelocityField2 = (vtkCachingInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCachingInterpolatedVelocityField2.Register(null);
			}
		}
		return vtkCachingInterpolatedVelocityField2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCachingInterpolatedVelocityField_SelectVectors_17(HandleRef pThis, string fieldName);

	/// <summary>
	/// If you want to work with an arbitrary vector array, then set its name
	/// here. By default this in nullptr and the filter will use the active vector
	/// array.
	/// </summary>
	public void SelectVectors(string fieldName)
	{
		vtkCachingInterpolatedVelocityField_SelectVectors_17(GetCppThis(), fieldName);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCachingInterpolatedVelocityField_SetDataSet_18(HandleRef pThis, int I, HandleRef dataset, byte staticdataset, HandleRef locator);

	/// <summary>
	/// Add a dataset used by the interpolation function evaluation.
	/// </summary>
	public virtual void SetDataSet(int I, vtkDataSet dataset, bool staticdataset, vtkAbstractCellLocator locator)
	{
		vtkCachingInterpolatedVelocityField_SetDataSet_18(GetCppThis(), I, dataset?.GetCppThis() ?? default(HandleRef), (byte)(staticdataset ? 1u : 0u), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCachingInterpolatedVelocityField_SetLastCellInfo_19(HandleRef pThis, long c, int datasetindex);

	/// <summary>
	/// Set LastCellId to c and LastCacheIndex datasetindex, cached from last evaluation.
	/// If c isn't -1 then the corresponding cell is stored in Cache-&gt;Cell.
	/// These values should be valid or an assertion will be triggered.
	/// </summary>
	public void SetLastCellInfo(long c, int datasetindex)
	{
		vtkCachingInterpolatedVelocityField_SetLastCellInfo_19(GetCppThis(), c, datasetindex);
	}
}
