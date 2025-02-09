using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkComputeHistogram2DOutliers
/// </summary>
/// <remarks>
///    compute the outliers in a set
///  of 2D histograms and extract the corresponding row data.
///
///
///  This class takes a table and one or more vtkImageData histograms as input
///  and computes the outliers in that data.  In general it does so by
///  identifying histogram bins that are removed by a median (salt and pepper)
///  filter and below a threshold.  This threshold is automatically identified
///  to retrieve a number of outliers close to a user-determined value.  This
///  value is set by calling SetPreferredNumberOfOutliers(int).
///
///  The image data input can come either as a multiple vtkImageData via the
///  repeatable INPUT_HISTOGRAM_IMAGE_DATA port, or as a single
///  vtkMultiBlockDataSet containing vtkImageData objects as blocks.  One
///  or the other must be set, not both (or neither).
///
///  The output can be retrieved as a set of row ids in a vtkSelection or
///  as a vtkTable containing the actual outlier row data.
///
/// </remarks>
/// <seealso>
///
///  vtkExtractHistogram2D vtkPComputeHistogram2DOutliers
///
/// @par Thanks:
///  Developed by David Feng at Sandia National Laboratories
///             ------------------------------------------------------------------------------
/// </seealso>
public class vtkComputeHistogram2DOutliers : vtkSelectionAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum InputPorts
	{
		/// <summary>enum member</summary>
		INPUT_HISTOGRAMS_IMAGE_DATA = 1,
		/// <summary>enum member</summary>
		INPUT_HISTOGRAMS_MULTIBLOCK = 2,
		/// <summary>enum member</summary>
		INPUT_TABLE_DATA = 0
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum OutputPorts
	{
		/// <summary>enum member</summary>
		OUTPUT_SELECTED_ROWS,
		/// <summary>enum member</summary>
		OUTPUT_SELECTED_TABLE_DATA
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkComputeHistogram2DOutliers";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkComputeHistogram2DOutliers()
	{
		MRClassNameKey = "class vtkComputeHistogram2DOutliers";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkComputeHistogram2DOutliers"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkComputeHistogram2DOutliers(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkComputeHistogram2DOutliers_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkComputeHistogram2DOutliers New()
	{
		vtkComputeHistogram2DOutliers result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkComputeHistogram2DOutliers_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkComputeHistogram2DOutliers()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkComputeHistogram2DOutliers_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkComputeHistogram2DOutliers_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkComputeHistogram2DOutliers_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkComputeHistogram2DOutliers_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkComputeHistogram2DOutliers_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkComputeHistogram2DOutliers_GetOutputTable_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTable GetOutputTable()
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkComputeHistogram2DOutliers_GetOutputTable_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkComputeHistogram2DOutliers_GetPreferredNumberOfOutliers_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetPreferredNumberOfOutliers()
	{
		return vtkComputeHistogram2DOutliers_GetPreferredNumberOfOutliers_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkComputeHistogram2DOutliers_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkComputeHistogram2DOutliers_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkComputeHistogram2DOutliers_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkComputeHistogram2DOutliers_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkComputeHistogram2DOutliers_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkComputeHistogram2DOutliers NewInstance()
	{
		vtkComputeHistogram2DOutliers result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkComputeHistogram2DOutliers_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkComputeHistogram2DOutliers_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkComputeHistogram2DOutliers SafeDownCast(vtkObjectBase o)
	{
		vtkComputeHistogram2DOutliers vtkComputeHistogram2DOutliers2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkComputeHistogram2DOutliers_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkComputeHistogram2DOutliers2 = (vtkComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkComputeHistogram2DOutliers2.Register(null);
			}
		}
		return vtkComputeHistogram2DOutliers2;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkComputeHistogram2DOutliers_SetInputHistogramImageDataConnection_10(HandleRef pThis, HandleRef cxn);

	/// <summary>
	/// Set the input histogram data as a (repeatable) vtkImageData
	/// </summary>
	public void SetInputHistogramImageDataConnection(vtkAlgorithmOutput cxn)
	{
		vtkComputeHistogram2DOutliers_SetInputHistogramImageDataConnection_10(GetCppThis(), cxn?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkComputeHistogram2DOutliers_SetInputHistogramMultiBlockConnection_11(HandleRef pThis, HandleRef cxn);

	/// <summary>
	/// Set the input histogram data as a vtkMultiBlockData set
	/// containing multiple vtkImageData objects.
	/// </summary>
	public void SetInputHistogramMultiBlockConnection(vtkAlgorithmOutput cxn)
	{
		vtkComputeHistogram2DOutliers_SetInputHistogramMultiBlockConnection_11(GetCppThis(), cxn?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkComputeHistogram2DOutliers_SetInputTableConnection_12(HandleRef pThis, HandleRef cxn);

	/// <summary>
	/// Set the source table data, from which data will be filtered.
	/// </summary>
	public void SetInputTableConnection(vtkAlgorithmOutput cxn)
	{
		vtkComputeHistogram2DOutliers_SetInputTableConnection_12(GetCppThis(), cxn?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkComputeHistogram2DOutliers_SetPreferredNumberOfOutliers_13(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetPreferredNumberOfOutliers(int _arg)
	{
		vtkComputeHistogram2DOutliers_SetPreferredNumberOfOutliers_13(GetCppThis(), _arg);
	}
}
