using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkPartitionedDataSetSource
/// </summary>
/// <remarks>
///  a source that produces a vtkPartitionedDataSet.
///
/// vtkPartitionedDataSetSource generates a vtkPartitionedDataSet which is
/// composed of partitions of a given vtkParametricFunction.
/// The resulting partitioned dataset is split among ranks in an even fashion
/// by default.
///
/// The user can pass the parametric function to be used using SetParametricFunction.
/// Otherwise it will default to vtkParametricKlein as its Parametric function.
///
/// The partitioning scheme for the produced vtkPartitionedDataSet can be controlled
/// with the methods: SetNumberOfPartitiones, EnableRank, DisableRank, EnableAllRanks,
/// DisableAllRanks.
///
/// @see vtkParametricFunction
/// @see vtkPartitionedDataSet
/// </remarks>
public class vtkPartitionedDataSetSource : vtkPartitionedDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionedDataSetSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPartitionedDataSetSource()
	{
		MRClassNameKey = "class vtkPartitionedDataSetSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionedDataSetSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPartitionedDataSetSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPartitionedDataSetSource New()
	{
		vtkPartitionedDataSetSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPartitionedDataSetSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPartitionedDataSetSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPartitionedDataSetSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetSource_DisableAllRanks_01(HandleRef pThis);

	/// <summary>
	/// Enable/Disable ranks.
	///
	/// By default every rank is enabled, this default policy will be
	/// changed if DisableAllRanks is used, and again reverted when
	/// EnableAllRanks is used.
	///
	/// EnableRank/DisableRank are used to specify individual exceptions
	/// of the default policy.
	/// </summary>
	public void DisableAllRanks()
	{
		vtkPartitionedDataSetSource_DisableAllRanks_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetSource_DisableRank_02(HandleRef pThis, int rank);

	/// <summary>
	/// Enable/Disable ranks.
	///
	/// By default every rank is enabled, this default policy will be
	/// changed if DisableAllRanks is used, and again reverted when
	/// EnableAllRanks is used.
	///
	/// EnableRank/DisableRank are used to specify individual exceptions
	/// of the default policy.
	/// </summary>
	public void DisableRank(int rank)
	{
		vtkPartitionedDataSetSource_DisableRank_02(GetCppThis(), rank);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetSource_EnableAllRanks_03(HandleRef pThis);

	/// <summary>
	/// Enable/Disable ranks.
	///
	/// By default every rank is enabled, this default policy will be
	/// changed if DisableAllRanks is used, and again reverted when
	/// EnableAllRanks is used.
	///
	/// EnableRank/DisableRank are used to specify individual exceptions
	/// of the default policy.
	/// </summary>
	public void EnableAllRanks()
	{
		vtkPartitionedDataSetSource_EnableAllRanks_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetSource_EnableRank_04(HandleRef pThis, int rank);

	/// <summary>
	/// Enable/Disable ranks.
	///
	/// By default every rank is enabled, this default policy will be
	/// changed if DisableAllRanks is used, and again reverted when
	/// EnableAllRanks is used.
	///
	/// EnableRank/DisableRank are used to specify individual exceptions
	/// of the default policy.
	/// </summary>
	public void EnableRank(int rank)
	{
		vtkPartitionedDataSetSource_EnableRank_04(GetCppThis(), rank);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPartitionedDataSetSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPartitionedDataSetSource_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPartitionedDataSetSource_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPartitionedDataSetSource_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetSource_GetNumberOfPartitions_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of partitions of the resulting PartitionedDataSet.
	/// If not specified, the number of partitions will be the number of enabled
	/// ranks.
	///
	/// SetNumberOfPartitions(0) means auto in this context, the implementation
	/// will decided the optimal number of partitions which by default will be
	/// one partition per each rank.
	/// </summary>
	public virtual int GetNumberOfPartitions()
	{
		return vtkPartitionedDataSetSource_GetNumberOfPartitions_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetSource_GetNumberOfPartitionsMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of partitions of the resulting PartitionedDataSet.
	/// If not specified, the number of partitions will be the number of enabled
	/// ranks.
	///
	/// SetNumberOfPartitions(0) means auto in this context, the implementation
	/// will decided the optimal number of partitions which by default will be
	/// one partition per each rank.
	/// </summary>
	public virtual int GetNumberOfPartitionsMaxValue()
	{
		return vtkPartitionedDataSetSource_GetNumberOfPartitionsMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetSource_GetNumberOfPartitionsMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of partitions of the resulting PartitionedDataSet.
	/// If not specified, the number of partitions will be the number of enabled
	/// ranks.
	///
	/// SetNumberOfPartitions(0) means auto in this context, the implementation
	/// will decided the optimal number of partitions which by default will be
	/// one partition per each rank.
	/// </summary>
	public virtual int GetNumberOfPartitionsMinValue()
	{
		return vtkPartitionedDataSetSource_GetNumberOfPartitionsMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetSource_GetParametricFunction_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the parametric function to be used for this source.
	/// </summary>
	public virtual vtkParametricFunction GetParametricFunction()
	{
		vtkParametricFunction vtkParametricFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetSource_GetParametricFunction_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParametricFunction2 = (vtkParametricFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParametricFunction2.Register(null);
			}
		}
		return vtkParametricFunction2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetSource_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPartitionedDataSetSource_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPartitionedDataSetSource_IsEnabledRank_12(HandleRef pThis, int rank);

	/// <summary>
	/// Enable/Disable ranks.
	///
	/// By default every rank is enabled, this default policy will be
	/// changed if DisableAllRanks is used, and again reverted when
	/// EnableAllRanks is used.
	///
	/// EnableRank/DisableRank are used to specify individual exceptions
	/// of the default policy.
	/// </summary>
	public bool IsEnabledRank(int rank)
	{
		return (vtkPartitionedDataSetSource_IsEnabledRank_12(GetCppThis(), rank) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetSource_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPartitionedDataSetSource_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPartitionedDataSetSource NewInstance()
	{
		vtkPartitionedDataSetSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetSource_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPartitionedDataSetSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPartitionedDataSetSource SafeDownCast(vtkObjectBase o)
	{
		vtkPartitionedDataSetSource vtkPartitionedDataSetSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetSource_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSetSource2 = (vtkPartitionedDataSetSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSetSource2.Register(null);
			}
		}
		return vtkPartitionedDataSetSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetSource_SetNumberOfPartitions_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of partitions of the resulting PartitionedDataSet.
	/// If not specified, the number of partitions will be the number of enabled
	/// ranks.
	///
	/// SetNumberOfPartitions(0) means auto in this context, the implementation
	/// will decided the optimal number of partitions which by default will be
	/// one partition per each rank.
	/// </summary>
	public virtual void SetNumberOfPartitions(int _arg)
	{
		vtkPartitionedDataSetSource_SetNumberOfPartitions_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetSource_SetParametricFunction_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the parametric function to be used for this source.
	/// </summary>
	public void SetParametricFunction(vtkParametricFunction arg0)
	{
		vtkPartitionedDataSetSource_SetParametricFunction_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
