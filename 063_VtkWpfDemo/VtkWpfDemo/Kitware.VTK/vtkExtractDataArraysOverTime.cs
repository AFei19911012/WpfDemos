using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractDataArraysOverTime
/// </summary>
/// <remarks>
///    extracts array from input dataset over time.
///
/// vtkExtractDataArraysOverTime extracts array from input dataset over time.
/// The filter extracts attribute arrays, based on the chosen field association
/// (vtkExtractDataArraysOverTime::SetFieldAssociation).
///
/// vtkExtractDataArraysOverTime::ReportStatisticsOnly determines if each element
/// is individually tracked or only summary statistics for each timestep are
/// tracked.
///
/// If ReportStatisticsOnly is off, the filter tracks each element in the input
/// over time. It requires that it can identify matching elements from one
/// timestep to another. There are several ways of doing that.
///
/// \li if vtkExtractDataArraysOverTime::UseGlobalIDs is true, then the filter
///     will look for array marked as vtkDataSetAttributes::GLOBALIDS in the
///     input and use that to track the element.
/// \li if vtkExtractDataArraysOverTime::UseGlobalIDs is false or there are no
///     element ids present, then the filter will look for the array chosen for
///     processing using `vtkAlgorithm::SetInputArrayToProcess` at index 0.
/// \li if earlier attempts fail, then simply the element id (i.e. index) is used.
///
/// The output is a vtkMultiBlockDataSet with single level, where leaf nodes can
/// are vtkTable instances.
///
/// The output is structured as follows:
///
/// \li if vtkExtractDataArraysOverTime::ReportStatisticsOnly is true, then the
///     stats are computed per input block (if input is a composite dataset) or on the whole
///     input dataset and placed as blocks named as &lt;tt&gt;stats block=\&lt;block id\&gt;&lt;/tt&gt;.
///     For non-composite input, the single leaf block is output is named as
///     \c stats.
///
/// \li if vtkExtractDataArraysOverTime::ReportStatisticsOnly if off, then each
///    tracked element is placed in a separate output block. The block name is of
///    the form &lt;tt&gt;id=\&lt;id\&gt; block=\&lt;block id\&gt;&lt;/tt&gt; where the \em block= suffix is
///    dropped for non-composite input datasets. If global ids are being used for
///    tracking then the name is simply &lt;tt&gt;gid=\&lt;global id\&gt;&lt;/tt&gt;.
///
/// </remarks>
/// <seealso>
///  vtkPExtractDataArraysOverTime
/// </seealso>
public class vtkExtractDataArraysOverTime : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractDataArraysOverTime";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractDataArraysOverTime()
	{
		MRClassNameKey = "class vtkExtractDataArraysOverTime";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractDataArraysOverTime"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractDataArraysOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractDataArraysOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractDataArraysOverTime New()
	{
		vtkExtractDataArraysOverTime result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractDataArraysOverTime_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractDataArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractDataArraysOverTime()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractDataArraysOverTime_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkExtractDataArraysOverTime_GetFieldAssociation_01(HandleRef pThis);

	/// <summary>
	/// FieldAssociation indicates which attributes to extract over time. This filter
	/// can extract only one type of attribute arrays. Currently, vtkDataObject::FIELD
	/// and vtkDataObject::POINT_THEN_CELL are not supported.
	/// </summary>
	public virtual int GetFieldAssociation()
	{
		return vtkExtractDataArraysOverTime_GetFieldAssociation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractDataArraysOverTime_GetFieldAssociationMaxValue_02(HandleRef pThis);

	/// <summary>
	/// FieldAssociation indicates which attributes to extract over time. This filter
	/// can extract only one type of attribute arrays. Currently, vtkDataObject::FIELD
	/// and vtkDataObject::POINT_THEN_CELL are not supported.
	/// </summary>
	public virtual int GetFieldAssociationMaxValue()
	{
		return vtkExtractDataArraysOverTime_GetFieldAssociationMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractDataArraysOverTime_GetFieldAssociationMinValue_03(HandleRef pThis);

	/// <summary>
	/// FieldAssociation indicates which attributes to extract over time. This filter
	/// can extract only one type of attribute arrays. Currently, vtkDataObject::FIELD
	/// and vtkDataObject::POINT_THEN_CELL are not supported.
	/// </summary>
	public virtual int GetFieldAssociationMinValue()
	{
		return vtkExtractDataArraysOverTime_GetFieldAssociationMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractDataArraysOverTime_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractDataArraysOverTime_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractDataArraysOverTime_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractDataArraysOverTime_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractDataArraysOverTime_GetNumberOfTimeSteps_06(HandleRef pThis);

	/// <summary>
	/// Get the number of time steps
	/// </summary>
	public virtual int GetNumberOfTimeSteps()
	{
		return vtkExtractDataArraysOverTime_GetNumberOfTimeSteps_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractDataArraysOverTime_GetReportStatisticsOnly_07(HandleRef pThis);

	/// <summary>
	/// Instead of breaking a data into a separate time-history
	/// table for each (block,ID)-tuple, you may call
	/// ReportStatisticsOnlyOn(). Then a single table per
	/// block of the input dataset will report the minimum, maximum,
	/// quartiles, and (for numerical arrays) the average and standard
	/// deviation of the data over time.
	///
	/// The default is off to preserve backwards-compatibility.
	/// </summary>
	public virtual bool GetReportStatisticsOnly()
	{
		return (vtkExtractDataArraysOverTime_GetReportStatisticsOnly_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractDataArraysOverTime_GetUseGlobalIDs_08(HandleRef pThis);

	/// <summary>
	/// When ReportStatisticsOnly is false, if UseGlobalIDs is true, then the filter will track
	/// elements using their global ids, if present. Default is true.
	/// </summary>
	public virtual bool GetUseGlobalIDs()
	{
		return (vtkExtractDataArraysOverTime_GetUseGlobalIDs_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractDataArraysOverTime_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractDataArraysOverTime_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractDataArraysOverTime_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractDataArraysOverTime_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractDataArraysOverTime_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractDataArraysOverTime NewInstance()
	{
		vtkExtractDataArraysOverTime result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractDataArraysOverTime_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractDataArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractDataArraysOverTime_ReportStatisticsOnlyOff_13(HandleRef pThis);

	/// <summary>
	/// Instead of breaking a data into a separate time-history
	/// table for each (block,ID)-tuple, you may call
	/// ReportStatisticsOnlyOn(). Then a single table per
	/// block of the input dataset will report the minimum, maximum,
	/// quartiles, and (for numerical arrays) the average and standard
	/// deviation of the data over time.
	///
	/// The default is off to preserve backwards-compatibility.
	/// </summary>
	public virtual void ReportStatisticsOnlyOff()
	{
		vtkExtractDataArraysOverTime_ReportStatisticsOnlyOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractDataArraysOverTime_ReportStatisticsOnlyOn_14(HandleRef pThis);

	/// <summary>
	/// Instead of breaking a data into a separate time-history
	/// table for each (block,ID)-tuple, you may call
	/// ReportStatisticsOnlyOn(). Then a single table per
	/// block of the input dataset will report the minimum, maximum,
	/// quartiles, and (for numerical arrays) the average and standard
	/// deviation of the data over time.
	///
	/// The default is off to preserve backwards-compatibility.
	/// </summary>
	public virtual void ReportStatisticsOnlyOn()
	{
		vtkExtractDataArraysOverTime_ReportStatisticsOnlyOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractDataArraysOverTime_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractDataArraysOverTime SafeDownCast(vtkObjectBase o)
	{
		vtkExtractDataArraysOverTime vtkExtractDataArraysOverTime2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractDataArraysOverTime_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractDataArraysOverTime2 = (vtkExtractDataArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractDataArraysOverTime2.Register(null);
			}
		}
		return vtkExtractDataArraysOverTime2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractDataArraysOverTime_SetFieldAssociation_16(HandleRef pThis, int _arg);

	/// <summary>
	/// FieldAssociation indicates which attributes to extract over time. This filter
	/// can extract only one type of attribute arrays. Currently, vtkDataObject::FIELD
	/// and vtkDataObject::POINT_THEN_CELL are not supported.
	/// </summary>
	public virtual void SetFieldAssociation(int _arg)
	{
		vtkExtractDataArraysOverTime_SetFieldAssociation_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractDataArraysOverTime_SetReportStatisticsOnly_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// Instead of breaking a data into a separate time-history
	/// table for each (block,ID)-tuple, you may call
	/// ReportStatisticsOnlyOn(). Then a single table per
	/// block of the input dataset will report the minimum, maximum,
	/// quartiles, and (for numerical arrays) the average and standard
	/// deviation of the data over time.
	///
	/// The default is off to preserve backwards-compatibility.
	/// </summary>
	public virtual void SetReportStatisticsOnly(bool _arg)
	{
		vtkExtractDataArraysOverTime_SetReportStatisticsOnly_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractDataArraysOverTime_SetUseGlobalIDs_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// When ReportStatisticsOnly is false, if UseGlobalIDs is true, then the filter will track
	/// elements using their global ids, if present. Default is true.
	/// </summary>
	public virtual void SetUseGlobalIDs(bool _arg)
	{
		vtkExtractDataArraysOverTime_SetUseGlobalIDs_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
