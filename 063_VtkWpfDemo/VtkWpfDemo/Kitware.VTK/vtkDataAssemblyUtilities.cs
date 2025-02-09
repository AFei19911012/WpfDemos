using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkDataAssemblyUtilities
/// </summary>
/// <remarks>
///  collections of utilities for vtkDataAssembly
///
/// vtkDataAssemblyUtilities provides useful utilities for working with
/// vtkDataAssembly.
/// </remarks>
public class vtkDataAssemblyUtilities : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataAssemblyUtilities";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataAssemblyUtilities()
	{
		MRClassNameKey = "class vtkDataAssemblyUtilities";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataAssemblyUtilities"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataAssemblyUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssemblyUtilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataAssemblyUtilities New()
	{
		vtkDataAssemblyUtilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataAssemblyUtilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataAssemblyUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataAssemblyUtilities()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataAssemblyUtilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssemblyUtilities_GenerateHierarchy_01(HandleRef input, HandleRef hierarchy, HandleRef output);

	/// <summary>
	/// Populates `hierarchy` with a representation of the hierarchy for the given
	/// composite dataset `input`. A hierarchy represents the input dataset's
	/// structure as represented in the dataset itself.
	///
	/// If `output` is non-null, then the input is also
	/// converted to a `vtkPartitionedDataSetCollection`. The vtkDataAssembly on
	/// the `output` is updated to be a copy of the hierarchy with correct dataset
	/// indices so that relationships in the input blocks are preserved.
	///
	/// If input is not a `vtkMultiBlockDataSet`, `vtkPartitionedDataSetCollection`, or
	/// `vtkUniformGridAMR`, then there's no hierarchy to represent and hence this
	/// function will return `false`.
	/// </summary>
	public static bool GenerateHierarchy(vtkCompositeDataSet input, vtkDataAssembly hierarchy, vtkPartitionedDataSetCollection output)
	{
		return (vtkDataAssemblyUtilities_GenerateHierarchy_01(input?.GetCppThis() ?? default(HandleRef), hierarchy?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataAssemblyUtilities_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataAssemblyUtilities_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataAssemblyUtilities_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataAssemblyUtilities_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDataAssemblyUtilities_GetSelectorForCompositeId_04(uint id, HandleRef hierarchy);

	/// <summary>
	/// For a vtkDataAssembly representing an hierarchy, returns the selector for
	/// the given composite id. Note, the selectors maybe best-match. When dealing
	/// with vtkPartitionedDataSetCollection, for example, a composite id may point
	/// to a particular dataset in a nested vtkPartitionedDataSet, however,
	/// selectors are simply not expressive enough to pick a dataset at that level
	/// and hence will simply point to the parent vtkPartitionedDataSet.
	/// </summary>
	public static string GetSelectorForCompositeId(uint id, vtkDataAssembly hierarchy)
	{
		return vtkDataAssemblyUtilities_GetSelectorForCompositeId_04(id, hierarchy?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssemblyUtilities_HierarchyName_05();

	/// <summary>
	/// Returns the named used by VTK to correspond to a vtkDataAssembly
	/// associated with the structure of a composite dataset.
	/// </summary>
	public static string HierarchyName()
	{
		return Marshal.PtrToStringAnsi(vtkDataAssemblyUtilities_HierarchyName_05());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssemblyUtilities_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataAssemblyUtilities_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssemblyUtilities_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataAssemblyUtilities_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssemblyUtilities_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataAssemblyUtilities NewInstance()
	{
		vtkDataAssemblyUtilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataAssemblyUtilities_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataAssemblyUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssemblyUtilities_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataAssemblyUtilities SafeDownCast(vtkObjectBase o)
	{
		vtkDataAssemblyUtilities vtkDataAssemblyUtilities2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataAssemblyUtilities_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataAssemblyUtilities2 = (vtkDataAssemblyUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataAssemblyUtilities2.Register(null);
			}
		}
		return vtkDataAssemblyUtilities2;
	}
}
