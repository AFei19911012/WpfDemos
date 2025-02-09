using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractSelectedArraysOverTime
/// </summary>
/// <remarks>
///    extracts a selection over time.
///
/// vtkExtractSelectedArraysOverTime extracts a selection over time.
/// This is combination of two filters, an vtkExtractSelection filter followed by
/// vtkExtractDataArraysOverTime, to do its work.
///
/// The filter has two inputs - 0th input is the temporal data to extracted,
/// while the second input is the selection (vtkSelection) to extract. Based on
/// the type of the selection, this filter setups up properties on the internal
/// vtkExtractDataArraysOverTime instance to produce a reasonable extract.
///
/// The output is a vtkMultiBlockDataSet. See vtkExtractDataArraysOverTime for
/// details on how the output is structured.
/// </remarks>
public class vtkExtractSelectedArraysOverTime : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedArraysOverTime";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractSelectedArraysOverTime()
	{
		MRClassNameKey = "class vtkExtractSelectedArraysOverTime";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedArraysOverTime"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractSelectedArraysOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedArraysOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractSelectedArraysOverTime New()
	{
		vtkExtractSelectedArraysOverTime result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedArraysOverTime_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSelectedArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractSelectedArraysOverTime()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractSelectedArraysOverTime_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedArraysOverTime_GetNumberOfTimeSteps_03(HandleRef pThis);

	/// <summary>
	/// Get the number of time steps
	/// </summary>
	public virtual int GetNumberOfTimeSteps()
	{
		return vtkExtractSelectedArraysOverTime_GetNumberOfTimeSteps_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractSelectedArraysOverTime_GetReportStatisticsOnly_04(HandleRef pThis);

	/// <summary>
	/// Instead of breaking a selection into a separate time-history
	/// table for each (block,ID)-tuple, you may call
	/// ReportStatisticsOnlyOn(). Then a single table per
	/// block of the input dataset will report the minimum, maximum,
	/// quartiles, and (for numerical arrays) the average and standard
	/// deviation of the selection over time.
	///
	/// The default is off to preserve backwards-compatibility.
	/// </summary>
	public virtual bool GetReportStatisticsOnly()
	{
		return (vtkExtractSelectedArraysOverTime_GetReportStatisticsOnly_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedArraysOverTime_GetSelectionExtractor_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the vtkExtractSelection instance used to obtain
	/// array values at each time step. By default, vtkExtractSelection is used.
	/// </summary>
	public vtkExtractSelection GetSelectionExtractor()
	{
		vtkExtractSelection vtkExtractSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedArraysOverTime_GetSelectionExtractor_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractSelection2 = (vtkExtractSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractSelection2.Register(null);
			}
		}
		return vtkExtractSelection2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedArraysOverTime_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractSelectedArraysOverTime_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedArraysOverTime_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractSelectedArraysOverTime_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedArraysOverTime_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractSelectedArraysOverTime NewInstance()
	{
		vtkExtractSelectedArraysOverTime result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedArraysOverTime_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSelectedArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedArraysOverTime_ReportStatisticsOnlyOff_10(HandleRef pThis);

	/// <summary>
	/// Instead of breaking a selection into a separate time-history
	/// table for each (block,ID)-tuple, you may call
	/// ReportStatisticsOnlyOn(). Then a single table per
	/// block of the input dataset will report the minimum, maximum,
	/// quartiles, and (for numerical arrays) the average and standard
	/// deviation of the selection over time.
	///
	/// The default is off to preserve backwards-compatibility.
	/// </summary>
	public virtual void ReportStatisticsOnlyOff()
	{
		vtkExtractSelectedArraysOverTime_ReportStatisticsOnlyOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedArraysOverTime_ReportStatisticsOnlyOn_11(HandleRef pThis);

	/// <summary>
	/// Instead of breaking a selection into a separate time-history
	/// table for each (block,ID)-tuple, you may call
	/// ReportStatisticsOnlyOn(). Then a single table per
	/// block of the input dataset will report the minimum, maximum,
	/// quartiles, and (for numerical arrays) the average and standard
	/// deviation of the selection over time.
	///
	/// The default is off to preserve backwards-compatibility.
	/// </summary>
	public virtual void ReportStatisticsOnlyOn()
	{
		vtkExtractSelectedArraysOverTime_ReportStatisticsOnlyOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedArraysOverTime_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractSelectedArraysOverTime SafeDownCast(vtkObjectBase o)
	{
		vtkExtractSelectedArraysOverTime vtkExtractSelectedArraysOverTime2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedArraysOverTime_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractSelectedArraysOverTime2 = (vtkExtractSelectedArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractSelectedArraysOverTime2.Register(null);
			}
		}
		return vtkExtractSelectedArraysOverTime2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedArraysOverTime_SetReportStatisticsOnly_13(HandleRef pThis, byte _arg);

	/// <summary>
	/// Instead of breaking a selection into a separate time-history
	/// table for each (block,ID)-tuple, you may call
	/// ReportStatisticsOnlyOn(). Then a single table per
	/// block of the input dataset will report the minimum, maximum,
	/// quartiles, and (for numerical arrays) the average and standard
	/// deviation of the selection over time.
	///
	/// The default is off to preserve backwards-compatibility.
	/// </summary>
	public virtual void SetReportStatisticsOnly(bool _arg)
	{
		vtkExtractSelectedArraysOverTime_SetReportStatisticsOnly_13(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedArraysOverTime_SetSelectionConnection_14(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Convenience method to specify the selection connection (2nd input
	/// port)
	/// </summary>
	public void SetSelectionConnection(vtkAlgorithmOutput algOutput)
	{
		vtkExtractSelectedArraysOverTime_SetSelectionConnection_14(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedArraysOverTime_SetSelectionExtractor_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get the vtkExtractSelection instance used to obtain
	/// array values at each time step. By default, vtkExtractSelection is used.
	/// </summary>
	public virtual void SetSelectionExtractor(vtkExtractSelection arg0)
	{
		vtkExtractSelectedArraysOverTime_SetSelectionExtractor_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
