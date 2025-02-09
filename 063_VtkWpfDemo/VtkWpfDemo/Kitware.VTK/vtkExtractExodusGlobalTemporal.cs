using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkExtractExodusGlobalTemporalVariables
/// </summary>
/// <remarks>
///  extract global temporal arrays or suitable field data arrays
///
/// vtkExtractExodusGlobalTemporalVariables extracts field data arrays that it
/// determines to represent temporal quantities. This determination is done as
/// follows:
///
/// * If `AutoDetectGlobalTemporalDataArrays` is true, it checks if to see if the
///   field data has any array with a key named "GLOBAL_TEMPORAL_VARIABLE". If
///   found, only arrays with this key are extracted.
/// * If such an array is not found, or if `AutoDetectGlobalTemporalDataArrays` is
///   false, then all arrays with single tuple are extracted.
///
/// If an array has GLOBAL_TEMPORAL_VARIABLE key in its information, it means
/// that the array has multiple tuples each associated with the specific
/// timestep. This was pattern first introduced in `vtkExodusIIReader` and hence
/// the name for this class. This class was originally only intended to extract
/// such arrays. It has since been expanded to support other arrays in field
/// data.
///
/// If the number of tuples in a GLOBAL_TEMPORAL_VARIABLE array is less than the
/// number of timesteps, we assume that we are dealing with restarted files and
/// hence update the pipeline appropriately to request the remaining tuples
/// iteratively.
///
/// For arrays without GLOBAL_TEMPORAL_VARIABLE, we always iterate over all input
/// timesteps one at a time and accumulate the results.
///
/// </remarks>
/// <seealso>
///  vtkExodusIIReader, vtkExodusIIReader::GLOBAL_TEMPORAL_VARIABLE.
/// </seealso>
public class vtkExtractExodusGlobalTemporalVariables : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractExodusGlobalTemporalVariables";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractExodusGlobalTemporalVariables()
	{
		MRClassNameKey = "class vtkExtractExodusGlobalTemporalVariables";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractExodusGlobalTemporalVariables"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractExodusGlobalTemporalVariables(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractExodusGlobalTemporalVariables_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractExodusGlobalTemporalVariables New()
	{
		vtkExtractExodusGlobalTemporalVariables result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractExodusGlobalTemporalVariables_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractExodusGlobalTemporalVariables()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractExodusGlobalTemporalVariables_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExtractExodusGlobalTemporalVariables_AutoDetectGlobalTemporalDataArraysOff_01(HandleRef pThis);

	/// <summary>
	/// When set to true (default) this filter will check if any of the arrays in
	/// the input field data has a key named `GLOBAL_TEMPORAL_VARIABLE`. If so,
	/// this filter will only extract those arrays. If no such array is found, then
	/// all single-tuple arrays are extracted. Set this to false to disable this
	/// auto-detection and simply extract all single-tuple arrays.
	///
	/// @sa `vtkExodusIIReader::GLOBAL_TEMPORAL_VARIABLE`
	/// </summary>
	public virtual void AutoDetectGlobalTemporalDataArraysOff()
	{
		vtkExtractExodusGlobalTemporalVariables_AutoDetectGlobalTemporalDataArraysOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractExodusGlobalTemporalVariables_AutoDetectGlobalTemporalDataArraysOn_02(HandleRef pThis);

	/// <summary>
	/// When set to true (default) this filter will check if any of the arrays in
	/// the input field data has a key named `GLOBAL_TEMPORAL_VARIABLE`. If so,
	/// this filter will only extract those arrays. If no such array is found, then
	/// all single-tuple arrays are extracted. Set this to false to disable this
	/// auto-detection and simply extract all single-tuple arrays.
	///
	/// @sa `vtkExodusIIReader::GLOBAL_TEMPORAL_VARIABLE`
	/// </summary>
	public virtual void AutoDetectGlobalTemporalDataArraysOn()
	{
		vtkExtractExodusGlobalTemporalVariables_AutoDetectGlobalTemporalDataArraysOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractExodusGlobalTemporalVariables_GetAutoDetectGlobalTemporalDataArrays_03(HandleRef pThis);

	/// <summary>
	/// When set to true (default) this filter will check if any of the arrays in
	/// the input field data has a key named `GLOBAL_TEMPORAL_VARIABLE`. If so,
	/// this filter will only extract those arrays. If no such array is found, then
	/// all single-tuple arrays are extracted. Set this to false to disable this
	/// auto-detection and simply extract all single-tuple arrays.
	///
	/// @sa `vtkExodusIIReader::GLOBAL_TEMPORAL_VARIABLE`
	/// </summary>
	public virtual bool GetAutoDetectGlobalTemporalDataArrays()
	{
		return (vtkExtractExodusGlobalTemporalVariables_GetAutoDetectGlobalTemporalDataArrays_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractExodusGlobalTemporalVariables_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractExodusGlobalTemporalVariables_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractExodusGlobalTemporalVariables_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractExodusGlobalTemporalVariables_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractExodusGlobalTemporalVariables_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractExodusGlobalTemporalVariables NewInstance()
	{
		vtkExtractExodusGlobalTemporalVariables result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractExodusGlobalTemporalVariables_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractExodusGlobalTemporalVariables_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractExodusGlobalTemporalVariables SafeDownCast(vtkObjectBase o)
	{
		vtkExtractExodusGlobalTemporalVariables vtkExtractExodusGlobalTemporalVariables2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractExodusGlobalTemporalVariables_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractExodusGlobalTemporalVariables2 = (vtkExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractExodusGlobalTemporalVariables2.Register(null);
			}
		}
		return vtkExtractExodusGlobalTemporalVariables2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractExodusGlobalTemporalVariables_SetAutoDetectGlobalTemporalDataArrays_11(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default) this filter will check if any of the arrays in
	/// the input field data has a key named `GLOBAL_TEMPORAL_VARIABLE`. If so,
	/// this filter will only extract those arrays. If no such array is found, then
	/// all single-tuple arrays are extracted. Set this to false to disable this
	/// auto-detection and simply extract all single-tuple arrays.
	///
	/// @sa `vtkExodusIIReader::GLOBAL_TEMPORAL_VARIABLE`
	/// </summary>
	public virtual void SetAutoDetectGlobalTemporalDataArrays(bool _arg)
	{
		vtkExtractExodusGlobalTemporalVariables_SetAutoDetectGlobalTemporalDataArrays_11(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
