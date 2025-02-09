using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkExtractBlockUsingDataAssembly
/// </summary>
/// <remarks>
///  extract blocks from certain composite datasets
///
/// vtkExtractBlockUsingDataAssembly is intended to extract selected blocks
/// from certain composite datasets. Blocks to extract are selected using
/// selectors. For supported selectors see `vtkDataAssembly::SelectNodes`.
///
/// The specific data-assembly to use to apply the selectors to determine the
/// blocks to extract is chosen using `vtkExtractBlockUsingDataAssembly::SetAssemblyName`.
///
/// @section vtkExtractBlockUsingDataAssembly-SupportedDataTypes Supported Data Types
///
/// This filter accepts `vtkUniformGridAMR`,
/// `vtkMultiBlockDataSet`, and `vtkPartitionedDataSetCollection` (and
/// subclasses). vtkMultiPieceDataSet and vtkPartitionedDataSet are not accepted
/// as inputs since those composite datasets are not comprised of "blocks".
///
/// For vtkOverlappingAMR, since extracting blocks cannot always guarantee a valid
/// overlapping AMR, this filter generates a `vtkPartitionedDataSetCollection`
/// instead. Any blanking information present in the input vtkOverlappingAMR is
/// also discarded for the same reason.
///
/// For all other supported input data types, the type is preserved.
/// </remarks>
public class vtkExtractBlockUsingDataAssembly : vtkCompositeDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractBlockUsingDataAssembly";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractBlockUsingDataAssembly()
	{
		MRClassNameKey = "class vtkExtractBlockUsingDataAssembly";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractBlockUsingDataAssembly"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractBlockUsingDataAssembly(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractBlockUsingDataAssembly_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractBlockUsingDataAssembly New()
	{
		vtkExtractBlockUsingDataAssembly result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractBlockUsingDataAssembly_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractBlockUsingDataAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractBlockUsingDataAssembly()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractBlockUsingDataAssembly_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractBlockUsingDataAssembly_AddSelector_01(HandleRef pThis, string selector);

	/// <summary>
	/// API to set selectors. Multiple selectors can be added using `AddSelector`.
	/// The order in which selectors are specified is not preserved and has no
	/// impact on the result.
	///
	/// `AddSelector` returns true if the selector was added, false if the selector
	/// was already specified and hence not added.
	///
	/// @sa vtkDataAssembly::SelectNodes
	/// </summary>
	public bool AddSelector(string selector)
	{
		return (vtkExtractBlockUsingDataAssembly_AddSelector_01(GetCppThis(), selector) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlockUsingDataAssembly_ClearSelectors_02(HandleRef pThis);

	/// <summary>
	/// API to set selectors. Multiple selectors can be added using `AddSelector`.
	/// The order in which selectors are specified is not preserved and has no
	/// impact on the result.
	///
	/// `AddSelector` returns true if the selector was added, false if the selector
	/// was already specified and hence not added.
	///
	/// @sa vtkDataAssembly::SelectNodes
	/// </summary>
	public void ClearSelectors()
	{
		vtkExtractBlockUsingDataAssembly_ClearSelectors_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractBlockUsingDataAssembly_GetAssemblyName_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the active assembly to use. The chosen assembly is used
	/// in combination with the selectors specified to determine which blocks
	/// are to be extracted.
	///
	/// By default, this is set to
	/// vtkDataAssemblyUtilities::HierarchyName().
	/// </summary>
	public virtual string GetAssemblyName()
	{
		return Marshal.PtrToStringAnsi(vtkExtractBlockUsingDataAssembly_GetAssemblyName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractBlockUsingDataAssembly_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractBlockUsingDataAssembly_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractBlockUsingDataAssembly_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractBlockUsingDataAssembly_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractBlockUsingDataAssembly_GetNumberOfSelectors_06(HandleRef pThis);

	/// <summary>
	/// API to access selectors.
	/// </summary>
	public int GetNumberOfSelectors()
	{
		return vtkExtractBlockUsingDataAssembly_GetNumberOfSelectors_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractBlockUsingDataAssembly_GetPruneDataAssembly_07(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the data assembly is pruned to remove
	/// branches that were not selected.
	/// </summary>
	public virtual bool GetPruneDataAssembly()
	{
		return (vtkExtractBlockUsingDataAssembly_GetPruneDataAssembly_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractBlockUsingDataAssembly_GetSelectSubtrees_08(HandleRef pThis);

	/// <summary>
	/// When set to true (default) subtrees for chosen paths are treated as
	/// selected.
	/// </summary>
	public virtual bool GetSelectSubtrees()
	{
		return (vtkExtractBlockUsingDataAssembly_GetSelectSubtrees_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractBlockUsingDataAssembly_GetSelector_09(HandleRef pThis, int index);

	/// <summary>
	/// API to access selectors.
	/// </summary>
	public string GetSelector(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExtractBlockUsingDataAssembly_GetSelector_09(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractBlockUsingDataAssembly_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractBlockUsingDataAssembly_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractBlockUsingDataAssembly_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractBlockUsingDataAssembly_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractBlockUsingDataAssembly_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractBlockUsingDataAssembly NewInstance()
	{
		vtkExtractBlockUsingDataAssembly result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractBlockUsingDataAssembly_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractBlockUsingDataAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlockUsingDataAssembly_PruneDataAssemblyOff_14(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the data assembly is pruned to remove
	/// branches that were not selected.
	/// </summary>
	public virtual void PruneDataAssemblyOff()
	{
		vtkExtractBlockUsingDataAssembly_PruneDataAssemblyOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlockUsingDataAssembly_PruneDataAssemblyOn_15(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the data assembly is pruned to remove
	/// branches that were not selected.
	/// </summary>
	public virtual void PruneDataAssemblyOn()
	{
		vtkExtractBlockUsingDataAssembly_PruneDataAssemblyOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractBlockUsingDataAssembly_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractBlockUsingDataAssembly SafeDownCast(vtkObjectBase o)
	{
		vtkExtractBlockUsingDataAssembly vtkExtractBlockUsingDataAssembly2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractBlockUsingDataAssembly_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractBlockUsingDataAssembly2 = (vtkExtractBlockUsingDataAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractBlockUsingDataAssembly2.Register(null);
			}
		}
		return vtkExtractBlockUsingDataAssembly2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlockUsingDataAssembly_SelectSubtreesOff_17(HandleRef pThis);

	/// <summary>
	/// When set to true (default) subtrees for chosen paths are treated as
	/// selected.
	/// </summary>
	public virtual void SelectSubtreesOff()
	{
		vtkExtractBlockUsingDataAssembly_SelectSubtreesOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlockUsingDataAssembly_SelectSubtreesOn_18(HandleRef pThis);

	/// <summary>
	/// When set to true (default) subtrees for chosen paths are treated as
	/// selected.
	/// </summary>
	public virtual void SelectSubtreesOn()
	{
		vtkExtractBlockUsingDataAssembly_SelectSubtreesOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlockUsingDataAssembly_SetAssemblyName_19(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the active assembly to use. The chosen assembly is used
	/// in combination with the selectors specified to determine which blocks
	/// are to be extracted.
	///
	/// By default, this is set to
	/// vtkDataAssemblyUtilities::HierarchyName().
	/// </summary>
	public virtual void SetAssemblyName(string _arg)
	{
		vtkExtractBlockUsingDataAssembly_SetAssemblyName_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlockUsingDataAssembly_SetPruneDataAssembly_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default), the data assembly is pruned to remove
	/// branches that were not selected.
	/// </summary>
	public virtual void SetPruneDataAssembly(bool _arg)
	{
		vtkExtractBlockUsingDataAssembly_SetPruneDataAssembly_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlockUsingDataAssembly_SetSelectSubtrees_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default) subtrees for chosen paths are treated as
	/// selected.
	/// </summary>
	public virtual void SetSelectSubtrees(bool _arg)
	{
		vtkExtractBlockUsingDataAssembly_SetSelectSubtrees_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlockUsingDataAssembly_SetSelector_22(HandleRef pThis, string selector);

	/// <summary>
	/// Convenience method to set a single selector.
	/// This clears any other existing selectors.
	/// </summary>
	public void SetSelector(string selector)
	{
		vtkExtractBlockUsingDataAssembly_SetSelector_22(GetCppThis(), selector);
	}
}
