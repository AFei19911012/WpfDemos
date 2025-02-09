using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkKMeansDistanceFunctor
/// </summary>
/// <remarks>
///    measure distance from k-means cluster centers
///
/// This is an abstract class (with a default concrete subclass) that implements
/// algorithms used by the vtkKMeansStatistics filter that rely on a distance metric.
/// If you wish to use a non-Euclidean distance metric (this could include
/// working with strings that do not have a Euclidean distance metric, implementing
/// k-mediods, or trying distance metrics in norms other than L2), you
/// should subclass vtkKMeansDistanceFunctor.
/// </remarks>
public class vtkKMeansDistanceFunctor : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkKMeansDistanceFunctor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkKMeansDistanceFunctor()
	{
		MRClassNameKey = "class vtkKMeansDistanceFunctor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkKMeansDistanceFunctor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkKMeansDistanceFunctor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansDistanceFunctor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKMeansDistanceFunctor New()
	{
		vtkKMeansDistanceFunctor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansDistanceFunctor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkKMeansDistanceFunctor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkKMeansDistanceFunctor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansDistanceFunctor_AllocateElementArray_01(HandleRef pThis, long size);

	/// <summary>
	/// Allocate an array large enough to hold \a size coordinates and return a void pointer to this
	/// array. This is used by vtkPKMeansStatistics to send (receive) cluster center coordinates to
	/// (from) other processes.
	/// </summary>
	public virtual IntPtr AllocateElementArray(long size)
	{
		return vtkKMeansDistanceFunctor_AllocateElementArray_01(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansDistanceFunctor_CreateCoordinateArray_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a vtkAbstractArray capable of holding cluster center coordinates.
	/// This is used by vtkPKMeansStatistics to hold cluster center coordinates sent to (received from)
	/// other processes.
	/// </summary>
	public virtual vtkAbstractArray CreateCoordinateArray()
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansDistanceFunctor_CreateCoordinateArray_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansDistanceFunctor_DeallocateElementArray_03(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Free an array allocated with AllocateElementArray.
	/// </summary>
	public virtual void DeallocateElementArray(IntPtr arg0)
	{
		vtkKMeansDistanceFunctor_DeallocateElementArray_03(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKMeansDistanceFunctor_GetDataType_04(HandleRef pThis);

	/// <summary>
	/// Return the data type used to store cluster center coordinates.
	/// </summary>
	public virtual int GetDataType()
	{
		return vtkKMeansDistanceFunctor_GetDataType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansDistanceFunctor_GetEmptyTuple_05(HandleRef pThis, long dimension, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an empty tuple. These values are used as cluster center coordinates
	/// when no initial cluster centers are specified.
	/// </summary>
	public virtual vtkVariantArray GetEmptyTuple(long dimension)
	{
		vtkVariantArray vtkVariantArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansDistanceFunctor_GetEmptyTuple_05(GetCppThis(), dimension, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVariantArray2 = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVariantArray2.Register(null);
			}
		}
		return vtkVariantArray2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKMeansDistanceFunctor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkKMeansDistanceFunctor_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKMeansDistanceFunctor_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkKMeansDistanceFunctor_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKMeansDistanceFunctor_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkKMeansDistanceFunctor_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKMeansDistanceFunctor_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkKMeansDistanceFunctor_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansDistanceFunctor_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkKMeansDistanceFunctor NewInstance()
	{
		vtkKMeansDistanceFunctor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansDistanceFunctor_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansDistanceFunctor_PackElements_12(HandleRef pThis, HandleRef curTable, IntPtr vElements);

	/// <summary>
	/// Pack the cluster center coordinates in \a vElements into columns of \a curTable.
	/// This code may assume that the columns in \a curTable are all of the type returned by \a
	/// GetNewVTKArray().
	/// </summary>
	public virtual void PackElements(vtkTable curTable, IntPtr vElements)
	{
		vtkKMeansDistanceFunctor_PackElements_12(GetCppThis(), curTable?.GetCppThis() ?? default(HandleRef), vElements);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansDistanceFunctor_PairwiseUpdate_13(HandleRef pThis, HandleRef clusterCenters, long row, HandleRef data, long dataCardinality, long totalCardinality);

	/// <summary>
	/// This is called once per observation per run per iteration in order to assign the
	/// observation to its nearest cluster center after the distance functor has been
	/// evaluated for all the cluster centers.
	///
	/// The distance functor is responsible for incrementally updating the cluster centers
	/// to account for the assignment.
	/// </summary>
	public virtual void PairwiseUpdate(vtkTable clusterCenters, long row, vtkVariantArray data, long dataCardinality, long totalCardinality)
	{
		vtkKMeansDistanceFunctor_PairwiseUpdate_13(GetCppThis(), clusterCenters?.GetCppThis() ?? default(HandleRef), row, data?.GetCppThis() ?? default(HandleRef), dataCardinality, totalCardinality);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansDistanceFunctor_PerturbElement_14(HandleRef pThis, HandleRef arg0, HandleRef arg1, long arg2, long arg3, long arg4, double arg5);

	/// <summary>
	/// When a cluster center (1) has no observations that are closer to it than other cluster centers
	/// or (2) has exactly the same coordinates as another cluster center, its coordinates should be
	/// perturbed. This function should perform that perturbation.
	///
	/// Since perturbation relies on a distance metric, this function is the responsibility of the
	/// distance functor.
	/// </summary>
	public virtual void PerturbElement(vtkTable arg0, vtkTable arg1, long arg2, long arg3, long arg4, double arg5)
	{
		vtkKMeansDistanceFunctor_PerturbElement_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2, arg3, arg4, arg5);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansDistanceFunctor_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKMeansDistanceFunctor SafeDownCast(vtkObjectBase o)
	{
		vtkKMeansDistanceFunctor vtkKMeansDistanceFunctor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansDistanceFunctor_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKMeansDistanceFunctor2 = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKMeansDistanceFunctor2.Register(null);
			}
		}
		return vtkKMeansDistanceFunctor2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansDistanceFunctor_UnPackElements_16(HandleRef pThis, HandleRef curTable, HandleRef newTable, IntPtr vLocalElements, IntPtr vGlobalElements, int np);

	/// <summary>
	/// Unpack the cluster center coordinates in \a vElements into columns of \a curTable.
	/// This code may assume that the columns in \a curTable are all of the type returned by \a
	/// GetNewVTKArray().
	/// </summary>
	public virtual void UnPackElements(vtkTable curTable, vtkTable newTable, IntPtr vLocalElements, IntPtr vGlobalElements, int np)
	{
		vtkKMeansDistanceFunctor_UnPackElements_16(GetCppThis(), curTable?.GetCppThis() ?? default(HandleRef), newTable?.GetCppThis() ?? default(HandleRef), vLocalElements, vGlobalElements, np);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansDistanceFunctor_UnPackElements_17(HandleRef pThis, HandleRef curTable, IntPtr vLocalElements, long numRows, long numCols);

	/// <summary>
	/// Unpack the cluster center coordinates in \a vElements into columns of \a curTable.
	/// This code may assume that the columns in \a curTable are all of the type returned by \a
	/// GetNewVTKArray().
	/// </summary>
	public virtual void UnPackElements(vtkTable curTable, IntPtr vLocalElements, long numRows, long numCols)
	{
		vtkKMeansDistanceFunctor_UnPackElements_17(GetCppThis(), curTable?.GetCppThis() ?? default(HandleRef), vLocalElements, numRows, numCols);
	}
}
