using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkPartitionBalancer
/// </summary>
/// <remarks>
///  Balances input partitioned data sets so each rank has the same number of data sets.
///
/// This filter can be applied on `vtkPartitionedDataSet` or `vtkPartitionedDataSetCollection`.
///
/// * Given an input `vtkPartitionedDataSet`, this filter adds
/// `nullptr` instances in the output `vtkPartitionedDataSet` following a pattern specified
/// as parameter. The output partitioned data set will have the same number of partitions across
/// all ranks.
/// * Given an input `vtkPartitionedDataSetCollection`, this filter is applied on each partitioned
/// data set separately, and is producing a `vtkPartitioneDataSetCollection`.
///
/// If some input partitions are `nullptr`, the output will see this partition squeezed out.
/// The filter will treat the input partitioned data set as if this `nullptr` partition was non
/// existent.
///
/// The way the output is laid out is driven by the parameter `Mode`;
/// * `Mode::Expand` generates, per partitioned data set, as many partitions as there are partitions
/// in the input across all ranks.
/// Given a valid partition (not `nullptr`) in the output partitioned data set at index
/// n in rank i, all partitioned data set of all ranks but i have a `nullptr` instance as index n.
/// Output partitions are sorted by rank number. i.e., for i &lt; j, partition at rank i are indexed
/// before partitions of rank j. Here is an example. of what would be generated for a
/// given input. PDC holds for Partitioned Dataset Collection, and PD holds for Partitioned Dataset.
/// @verbatim
/// Input:
/// rank 0: PDC [ PD (DS0, DS1,     DS2) ] [PD (nullptr, DS100) ]
/// rank 1: PDC [ PD (DS3, nullptr, DS4) ] [PD ()               ]
///
/// Output:
/// rank 0: PDC [ PD (DS0,     DS1,     DS2,     nullptr, nullptr) ] [PD (DS100)   ]
/// rank 1: PDC [ PD (nullptr, nullptr, nullptr, DS3,     DS4)     ] [PD (nullptr) ]
/// @endverbatim
/// * `Mode::Squash` generates, per input partitioned data set, the minimum number of partitions
/// possible, appending `nullptr` in ranks lacking partitions. Using the same example as above:
/// @verbatim
/// Input:
/// rank 0: PDC [ PD (DS0, DS1,     DS2) ] [PD (nullptr, DS100) ]
/// rank 1: PDC [ PD (DS3, nullptr, DS4) ] [PD ()               ]
///
/// Output:
/// rank 0: PDC [ PD (DS0, DS1, DS2)     ] [PD (DS100)   ]
/// rank 1: PDC [ PD (DS3, DS4, nullptr) ] [PD (nullptr) ]
/// @endverbatim
/// </remarks>
public class vtkPartitionBalancer : vtkPartitionedDataSetAlgorithm
{
	/// <summary>
	/// Modes defining the layout of the output.
	/// </summary>
	public enum Mode
	{
		/// <summary>enum member</summary>
		Expand,
		/// <summary>enum member</summary>
		Squash
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionBalancer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPartitionBalancer()
	{
		MRClassNameKey = "class vtkPartitionBalancer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionBalancer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPartitionBalancer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionBalancer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPartitionBalancer New()
	{
		vtkPartitionBalancer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionBalancer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPartitionBalancer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPartitionBalancer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPartitionBalancer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPartitionBalancer_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the controller to use. By default
	/// vtkMultiProcessController::GlobalController will be used.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionBalancer_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionBalancer_GetMode_02(HandleRef pThis);

	/// <summary>
	/// Set / Get current layout of the output. Default value is `vtkPartitionBalancer::Squash`.
	/// </summary>
	public virtual int GetMode()
	{
		return vtkPartitionBalancer_GetMode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionBalancer_GetModeMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Set / Get current layout of the output. Default value is `vtkPartitionBalancer::Squash`.
	/// </summary>
	public virtual int GetModeMaxValue()
	{
		return vtkPartitionBalancer_GetModeMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionBalancer_GetModeMinValue_04(HandleRef pThis);

	/// <summary>
	/// Set / Get current layout of the output. Default value is `vtkPartitionBalancer::Squash`.
	/// </summary>
	public virtual int GetModeMinValue()
	{
		return vtkPartitionBalancer_GetModeMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPartitionBalancer_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPartitionBalancer_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPartitionBalancer_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPartitionBalancer_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionBalancer_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPartitionBalancer_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionBalancer_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPartitionBalancer_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionBalancer_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPartitionBalancer NewInstance()
	{
		vtkPartitionBalancer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionBalancer_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPartitionBalancer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionBalancer_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPartitionBalancer SafeDownCast(vtkObjectBase o)
	{
		vtkPartitionBalancer vtkPartitionBalancer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionBalancer_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionBalancer2 = (vtkPartitionBalancer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionBalancer2.Register(null);
			}
		}
		return vtkPartitionBalancer2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionBalancer_SetController_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the controller to use. By default
	/// vtkMultiProcessController::GlobalController will be used.
	/// </summary>
	public void SetController(vtkMultiProcessController arg0)
	{
		vtkPartitionBalancer_SetController_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionBalancer_SetMode_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / Get current layout of the output. Default value is `vtkPartitionBalancer::Squash`.
	/// </summary>
	public virtual void SetMode(int _arg)
	{
		vtkPartitionBalancer_SetMode_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionBalancer_SetModeToExpand_14(HandleRef pThis);

	/// <summary>
	/// Sets filter to expand mode. See example below.
	///
	/// @verbatim
	/// Input:
	/// rank 0: PDC [ PD (DS0, DS1,     DS2) ] [PD (nullptr, DS100) ]
	/// rank 1: PDC [ PD (DS3, nullptr, DS4) ] [PD ()               ]
	///
	/// Output:
	/// rank 0: PDC [ PD (DS0,     DS1,     DS2,     nullptr, nullptr) ] [PD (DS100)   ]
	/// rank 1: PDC [ PD (nullptr, nullptr, nullptr, DS3,     DS4)     ] [PD (nullptr) ]
	/// @endverbatim
	/// </summary>
	public void SetModeToExpand()
	{
		vtkPartitionBalancer_SetModeToExpand_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionBalancer_SetModeToSquash_15(HandleRef pThis);

	/// <summary>
	/// Sets filter to squash mode. See example below.
	///
	/// @verbatim
	/// Input:
	/// rank 0: PDC [ PD (DS0, DS1,     DS2) ] [PD (nullptr, DS100) ]
	/// rank 1: PDC [ PD (DS3, nullptr, DS4) ] [PD ()               ]
	///
	/// Output:
	/// rank 0: PDC [ PD (DS0, DS1, DS2)     ] [PD (DS100)   ]
	/// rank 1: PDC [ PD (DS3, DS4, nullptr) ] [PD (nullptr) ]
	/// @endverbatim
	/// </summary>
	public void SetModeToSquash()
	{
		vtkPartitionBalancer_SetModeToSquash_15(GetCppThis());
	}
}
