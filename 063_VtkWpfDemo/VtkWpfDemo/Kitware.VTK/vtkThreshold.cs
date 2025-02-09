using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkThreshold
/// </summary>
/// <remarks>
///    extracts cells where scalar value in cell satisfies threshold criterion
///
/// vtkThreshold is a filter that extracts cells from any dataset type that
/// satisfy a threshold criterion. A cell satisfies the criterion if the
/// scalar value of (every or any) point satisfies the criterion. The
/// criterion can take three forms: 1) greater than a particular value; 2)
/// less than a particular value; or 3) between two values. The output of this
/// filter is an unstructured grid.
///
/// Note that scalar values are available from the point and cell attribute
/// data.  By default, point data is used to obtain scalars, but you can
/// control this behavior. See the AttributeMode ivar below.
///
/// By default only the first scalar value is used in the decision. Use the ComponentMode
/// and SelectedComponent ivars to control this behavior.
///
/// </remarks>
/// <seealso>
///
/// vtkThresholdPoints vtkThresholdTextureCoords
/// </seealso>
public class vtkThreshold : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Possible values for the threshold function:
	/// - THRESHOLD_BETWEEN - Keep values between the lower and upper thresholds.
	/// - THRESHOLD_LOWER - Keep values below the lower threshold.
	/// - THRESHOLD_UPPER - Keep values above the upper threshold.
	/// </summary>
	public enum ThresholdType
	{
		/// <summary>enum member</summary>
		THRESHOLD_BETWEEN,
		/// <summary>enum member</summary>
		THRESHOLD_LOWER,
		/// <summary>enum member</summary>
		THRESHOLD_UPPER
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkThreshold";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkThreshold()
	{
		MRClassNameKey = "class vtkThreshold";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreshold"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThreshold New()
	{
		vtkThreshold result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThreshold_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkThreshold()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkThreshold_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_AllScalarsOff_01(HandleRef pThis);

	/// <summary>
	/// If using scalars from point data, all scalars for all points in a cell
	/// must satisfy the threshold criterion if AllScalars is set. Otherwise,
	/// just a single scalar value satisfying the threshold criterion enables
	/// will extract the cell.
	/// </summary>
	public virtual void AllScalarsOff()
	{
		vtkThreshold_AllScalarsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_AllScalarsOn_02(HandleRef pThis);

	/// <summary>
	/// If using scalars from point data, all scalars for all points in a cell
	/// must satisfy the threshold criterion if AllScalars is set. Otherwise,
	/// just a single scalar value satisfying the threshold criterion enables
	/// will extract the cell.
	/// </summary>
	public virtual void AllScalarsOn()
	{
		vtkThreshold_AllScalarsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_Between_03(HandleRef pThis, double s);

	/// <summary>
	/// Methods used for thresholding. vtkThreshold::Lower returns true if s is lower than the lower
	/// threshold, vtkThreshold::Upper returns true if s is larger than the upper threshold, and
	/// vtkThreshold::Between returns true if s is between the lower and upper thresholds.
	///
	/// @warning These methods use threshold values that can be set with
	/// vtkThreshold::SetLowerThreshold and vtkThreshold::SetUpperThreshold. The threshold
	/// method can be set using vtkThreshold::SetThresholdFunction.
	///
	/// @note They are not protected members for inheritance purposes. The addresses of those methods
	/// are stored in one of this class attributes to figure out which version of the threshold to
	/// apply, which are inaccessible if protected.
	/// </summary>
	public int Between(double s)
	{
		return vtkThreshold_Between_03(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetAllScalars_04(HandleRef pThis);

	/// <summary>
	/// If using scalars from point data, all scalars for all points in a cell
	/// must satisfy the threshold criterion if AllScalars is set. Otherwise,
	/// just a single scalar value satisfying the threshold criterion enables
	/// will extract the cell.
	/// </summary>
	public virtual int GetAllScalars()
	{
		return vtkThreshold_GetAllScalars_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetAttributeMode_05(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (AttributeModeToDefault), the filter will use point
	/// data, and if no point data is available, then cell data is
	/// used. Alternatively you can explicitly set the filter to use point data
	/// (AttributeModeToUsePointData) or cell data (AttributeModeToUseCellData).
	/// </summary>
	public virtual int GetAttributeMode()
	{
		return vtkThreshold_GetAttributeMode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThreshold_GetAttributeModeAsString_06(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (AttributeModeToDefault), the filter will use point
	/// data, and if no point data is available, then cell data is
	/// used. Alternatively you can explicitly set the filter to use point data
	/// (AttributeModeToUsePointData) or cell data (AttributeModeToUseCellData).
	/// </summary>
	public string GetAttributeModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkThreshold_GetAttributeModeAsString_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetComponentMode_07(HandleRef pThis);

	/// <summary>
	/// Control how the decision of in / out is made with multi-component data.
	/// The choices are to use the selected component (specified in the
	/// SelectedComponent ivar), or to look at all components. When looking at
	/// all components, the evaluation can pass if all the components satisfy
	/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
	/// UseSelected.
	/// </summary>
	public virtual int GetComponentMode()
	{
		return vtkThreshold_GetComponentMode_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThreshold_GetComponentModeAsString_08(HandleRef pThis);

	/// <summary>
	/// Control how the decision of in / out is made with multi-component data.
	/// The choices are to use the selected component (specified in the
	/// SelectedComponent ivar), or to look at all components. When looking at
	/// all components, the evaluation can pass if all the components satisfy
	/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
	/// UseSelected.
	/// </summary>
	public string GetComponentModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkThreshold_GetComponentModeAsString_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetComponentModeMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Control how the decision of in / out is made with multi-component data.
	/// The choices are to use the selected component (specified in the
	/// SelectedComponent ivar), or to look at all components. When looking at
	/// all components, the evaluation can pass if all the components satisfy
	/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
	/// UseSelected.
	/// </summary>
	public virtual int GetComponentModeMaxValue()
	{
		return vtkThreshold_GetComponentModeMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetComponentModeMinValue_10(HandleRef pThis);

	/// <summary>
	/// Control how the decision of in / out is made with multi-component data.
	/// The choices are to use the selected component (specified in the
	/// SelectedComponent ivar), or to look at all components. When looking at
	/// all components, the evaluation can pass if all the components satisfy
	/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
	/// UseSelected.
	/// </summary>
	public virtual int GetComponentModeMinValue()
	{
		return vtkThreshold_GetComponentModeMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkThreshold_GetInvert_11(HandleRef pThis);

	/// <summary>
	/// Invert the threshold results. That is, cells that would have been in the output with this
	/// option off are excluded, while cells that would have been excluded from the output are
	/// included.
	/// </summary>
	public virtual bool GetInvert()
	{
		return (vtkThreshold_GetInvert_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkThreshold_GetLowerThreshold_12(HandleRef pThis);

	/// <summary>
	/// Set/get the upper and lower thresholds. The default values are set to +infinity and -infinity,
	/// respectively.
	/// </summary>
	public virtual double GetLowerThreshold()
	{
		return vtkThreshold_GetLowerThreshold_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThreshold_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkThreshold_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThreshold_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkThreshold_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetOutputPointsPrecision_15(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public int GetOutputPointsPrecision()
	{
		return vtkThreshold_GetOutputPointsPrecision_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetPointsDataType_16(HandleRef pThis);

	/// <summary>
	/// Set the data type of the output points (See the data types defined in
	/// vtkType.h). The default data type is float.
	///
	/// These methods are deprecated. Please use the SetOutputPointsPrecision()
	/// and GetOutputPointsPrecision() methods instead.
	/// </summary>
	public int GetPointsDataType()
	{
		return vtkThreshold_GetPointsDataType_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetSelectedComponent_17(HandleRef pThis);

	/// <summary>
	/// When the component mode is UseSelected, this ivar indicated the selected
	/// component. The default value is 0.
	/// </summary>
	public virtual int GetSelectedComponent()
	{
		return vtkThreshold_GetSelectedComponent_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetSelectedComponentMaxValue_18(HandleRef pThis);

	/// <summary>
	/// When the component mode is UseSelected, this ivar indicated the selected
	/// component. The default value is 0.
	/// </summary>
	public virtual int GetSelectedComponentMaxValue()
	{
		return vtkThreshold_GetSelectedComponentMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetSelectedComponentMinValue_19(HandleRef pThis);

	/// <summary>
	/// When the component mode is UseSelected, this ivar indicated the selected
	/// component. The default value is 0.
	/// </summary>
	public virtual int GetSelectedComponentMinValue()
	{
		return vtkThreshold_GetSelectedComponentMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetThresholdFunction_20(HandleRef pThis);

	/// <summary>
	/// Get/Set the threshold method, defining which threshold bounds to use. The default method is
	/// vtkThreshold::Between.
	/// </summary>
	public int GetThresholdFunction()
	{
		return vtkThreshold_GetThresholdFunction_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkThreshold_GetUpperThreshold_21(HandleRef pThis);

	/// <summary>
	/// Set/get the upper and lower thresholds. The default values are set to +infinity and -infinity,
	/// respectively.
	/// </summary>
	public virtual double GetUpperThreshold()
	{
		return vtkThreshold_GetUpperThreshold_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_GetUseContinuousCellRange_22(HandleRef pThis);

	/// <summary>
	/// If this is on (default is off), we will use the continuous interval
	/// [minimum cell scalar, maximum cell scalar] to intersect the threshold bound
	/// , rather than the set of discrete scalar values from the vertices
	/// *WARNING*: For higher order cells, the scalar range of the cell is
	/// not the same as the vertex scalar interval used here, so the
	/// result will not be accurate.
	/// </summary>
	public virtual int GetUseContinuousCellRange()
	{
		return vtkThreshold_GetUseContinuousCellRange_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_InvertOff_23(HandleRef pThis);

	/// <summary>
	/// Invert the threshold results. That is, cells that would have been in the output with this
	/// option off are excluded, while cells that would have been excluded from the output are
	/// included.
	/// </summary>
	public virtual void InvertOff()
	{
		vtkThreshold_InvertOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_InvertOn_24(HandleRef pThis);

	/// <summary>
	/// Invert the threshold results. That is, cells that would have been in the output with this
	/// option off are excluded, while cells that would have been excluded from the output are
	/// included.
	/// </summary>
	public virtual void InvertOn()
	{
		vtkThreshold_InvertOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkThreshold_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkThreshold_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_Lower_27(HandleRef pThis, double s);

	/// <summary>
	/// Methods used for thresholding. vtkThreshold::Lower returns true if s is lower than the lower
	/// threshold, vtkThreshold::Upper returns true if s is larger than the upper threshold, and
	/// vtkThreshold::Between returns true if s is between the lower and upper thresholds.
	///
	/// @warning These methods use threshold values that can be set with
	/// vtkThreshold::SetLowerThreshold and vtkThreshold::SetUpperThreshold. The threshold
	/// method can be set using vtkThreshold::SetThresholdFunction.
	///
	/// @note They are not protected members for inheritance purposes. The addresses of those methods
	/// are stored in one of this class attributes to figure out which version of the threshold to
	/// apply, which are inaccessible if protected.
	/// </summary>
	public int Lower(double s)
	{
		return vtkThreshold_Lower_27(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThreshold_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkThreshold NewInstance()
	{
		vtkThreshold result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThreshold_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThreshold_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThreshold SafeDownCast(vtkObjectBase o)
	{
		vtkThreshold vtkThreshold2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThreshold_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkThreshold2 = (vtkThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkThreshold2.Register(null);
			}
		}
		return vtkThreshold2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetAllScalars_31(HandleRef pThis, int _arg);

	/// <summary>
	/// If using scalars from point data, all scalars for all points in a cell
	/// must satisfy the threshold criterion if AllScalars is set. Otherwise,
	/// just a single scalar value satisfying the threshold criterion enables
	/// will extract the cell.
	/// </summary>
	public virtual void SetAllScalars(int _arg)
	{
		vtkThreshold_SetAllScalars_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetAttributeMode_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (AttributeModeToDefault), the filter will use point
	/// data, and if no point data is available, then cell data is
	/// used. Alternatively you can explicitly set the filter to use point data
	/// (AttributeModeToUsePointData) or cell data (AttributeModeToUseCellData).
	/// </summary>
	public virtual void SetAttributeMode(int _arg)
	{
		vtkThreshold_SetAttributeMode_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetAttributeModeToDefault_33(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (AttributeModeToDefault), the filter will use point
	/// data, and if no point data is available, then cell data is
	/// used. Alternatively you can explicitly set the filter to use point data
	/// (AttributeModeToUsePointData) or cell data (AttributeModeToUseCellData).
	/// </summary>
	public void SetAttributeModeToDefault()
	{
		vtkThreshold_SetAttributeModeToDefault_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetAttributeModeToUseCellData_34(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (AttributeModeToDefault), the filter will use point
	/// data, and if no point data is available, then cell data is
	/// used. Alternatively you can explicitly set the filter to use point data
	/// (AttributeModeToUsePointData) or cell data (AttributeModeToUseCellData).
	/// </summary>
	public void SetAttributeModeToUseCellData()
	{
		vtkThreshold_SetAttributeModeToUseCellData_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetAttributeModeToUsePointData_35(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (AttributeModeToDefault), the filter will use point
	/// data, and if no point data is available, then cell data is
	/// used. Alternatively you can explicitly set the filter to use point data
	/// (AttributeModeToUsePointData) or cell data (AttributeModeToUseCellData).
	/// </summary>
	public void SetAttributeModeToUsePointData()
	{
		vtkThreshold_SetAttributeModeToUsePointData_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetComponentMode_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the decision of in / out is made with multi-component data.
	/// The choices are to use the selected component (specified in the
	/// SelectedComponent ivar), or to look at all components. When looking at
	/// all components, the evaluation can pass if all the components satisfy
	/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
	/// UseSelected.
	/// </summary>
	public virtual void SetComponentMode(int _arg)
	{
		vtkThreshold_SetComponentMode_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetComponentModeToUseAll_37(HandleRef pThis);

	/// <summary>
	/// Control how the decision of in / out is made with multi-component data.
	/// The choices are to use the selected component (specified in the
	/// SelectedComponent ivar), or to look at all components. When looking at
	/// all components, the evaluation can pass if all the components satisfy
	/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
	/// UseSelected.
	/// </summary>
	public void SetComponentModeToUseAll()
	{
		vtkThreshold_SetComponentModeToUseAll_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetComponentModeToUseAny_38(HandleRef pThis);

	/// <summary>
	/// Control how the decision of in / out is made with multi-component data.
	/// The choices are to use the selected component (specified in the
	/// SelectedComponent ivar), or to look at all components. When looking at
	/// all components, the evaluation can pass if all the components satisfy
	/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
	/// UseSelected.
	/// </summary>
	public void SetComponentModeToUseAny()
	{
		vtkThreshold_SetComponentModeToUseAny_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetComponentModeToUseSelected_39(HandleRef pThis);

	/// <summary>
	/// Control how the decision of in / out is made with multi-component data.
	/// The choices are to use the selected component (specified in the
	/// SelectedComponent ivar), or to look at all components. When looking at
	/// all components, the evaluation can pass if all the components satisfy
	/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
	/// UseSelected.
	/// </summary>
	public void SetComponentModeToUseSelected()
	{
		vtkThreshold_SetComponentModeToUseSelected_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetInvert_40(HandleRef pThis, byte _arg);

	/// <summary>
	/// Invert the threshold results. That is, cells that would have been in the output with this
	/// option off are excluded, while cells that would have been excluded from the output are
	/// included.
	/// </summary>
	public virtual void SetInvert(bool _arg)
	{
		vtkThreshold_SetInvert_40(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetLowerThreshold_41(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the upper and lower thresholds. The default values are set to +infinity and -infinity,
	/// respectively.
	/// </summary>
	public virtual void SetLowerThreshold(double _arg)
	{
		vtkThreshold_SetLowerThreshold_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetOutputPointsPrecision_42(HandleRef pThis, int precision);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public void SetOutputPointsPrecision(int precision)
	{
		vtkThreshold_SetOutputPointsPrecision_42(GetCppThis(), precision);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetPointsDataType_43(HandleRef pThis, int type);

	/// <summary>
	/// Set the data type of the output points (See the data types defined in
	/// vtkType.h). The default data type is float.
	///
	/// These methods are deprecated. Please use the SetOutputPointsPrecision()
	/// and GetOutputPointsPrecision() methods instead.
	/// </summary>
	public void SetPointsDataType(int type)
	{
		vtkThreshold_SetPointsDataType_43(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetPointsDataTypeToDouble_44(HandleRef pThis);

	/// <summary>
	/// Set the data type of the output points (See the data types defined in
	/// vtkType.h). The default data type is float.
	///
	/// These methods are deprecated. Please use the SetOutputPointsPrecision()
	/// and GetOutputPointsPrecision() methods instead.
	/// </summary>
	public void SetPointsDataTypeToDouble()
	{
		vtkThreshold_SetPointsDataTypeToDouble_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetPointsDataTypeToFloat_45(HandleRef pThis);

	/// <summary>
	/// Set the data type of the output points (See the data types defined in
	/// vtkType.h). The default data type is float.
	///
	/// These methods are deprecated. Please use the SetOutputPointsPrecision()
	/// and GetOutputPointsPrecision() methods instead.
	/// </summary>
	public void SetPointsDataTypeToFloat()
	{
		vtkThreshold_SetPointsDataTypeToFloat_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetSelectedComponent_46(HandleRef pThis, int _arg);

	/// <summary>
	/// When the component mode is UseSelected, this ivar indicated the selected
	/// component. The default value is 0.
	/// </summary>
	public virtual void SetSelectedComponent(int _arg)
	{
		vtkThreshold_SetSelectedComponent_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetThresholdFunction_47(HandleRef pThis, int function);

	/// <summary>
	/// Get/Set the threshold method, defining which threshold bounds to use. The default method is
	/// vtkThreshold::Between.
	/// </summary>
	public void SetThresholdFunction(int function)
	{
		vtkThreshold_SetThresholdFunction_47(GetCppThis(), function);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetUpperThreshold_48(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the upper and lower thresholds. The default values are set to +infinity and -infinity,
	/// respectively.
	/// </summary>
	public virtual void SetUpperThreshold(double _arg)
	{
		vtkThreshold_SetUpperThreshold_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_SetUseContinuousCellRange_49(HandleRef pThis, int _arg);

	/// <summary>
	/// If this is on (default is off), we will use the continuous interval
	/// [minimum cell scalar, maximum cell scalar] to intersect the threshold bound
	/// , rather than the set of discrete scalar values from the vertices
	/// *WARNING*: For higher order cells, the scalar range of the cell is
	/// not the same as the vertex scalar interval used here, so the
	/// result will not be accurate.
	/// </summary>
	public virtual void SetUseContinuousCellRange(int _arg)
	{
		vtkThreshold_SetUseContinuousCellRange_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreshold_Upper_50(HandleRef pThis, double s);

	/// <summary>
	/// Methods used for thresholding. vtkThreshold::Lower returns true if s is lower than the lower
	/// threshold, vtkThreshold::Upper returns true if s is larger than the upper threshold, and
	/// vtkThreshold::Between returns true if s is between the lower and upper thresholds.
	///
	/// @warning These methods use threshold values that can be set with
	/// vtkThreshold::SetLowerThreshold and vtkThreshold::SetUpperThreshold. The threshold
	/// method can be set using vtkThreshold::SetThresholdFunction.
	///
	/// @note They are not protected members for inheritance purposes. The addresses of those methods
	/// are stored in one of this class attributes to figure out which version of the threshold to
	/// apply, which are inaccessible if protected.
	/// </summary>
	public int Upper(double s)
	{
		return vtkThreshold_Upper_50(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_UseContinuousCellRangeOff_51(HandleRef pThis);

	/// <summary>
	/// If this is on (default is off), we will use the continuous interval
	/// [minimum cell scalar, maximum cell scalar] to intersect the threshold bound
	/// , rather than the set of discrete scalar values from the vertices
	/// *WARNING*: For higher order cells, the scalar range of the cell is
	/// not the same as the vertex scalar interval used here, so the
	/// result will not be accurate.
	/// </summary>
	public virtual void UseContinuousCellRangeOff()
	{
		vtkThreshold_UseContinuousCellRangeOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreshold_UseContinuousCellRangeOn_52(HandleRef pThis);

	/// <summary>
	/// If this is on (default is off), we will use the continuous interval
	/// [minimum cell scalar, maximum cell scalar] to intersect the threshold bound
	/// , rather than the set of discrete scalar values from the vertices
	/// *WARNING*: For higher order cells, the scalar range of the cell is
	/// not the same as the vertex scalar interval used here, so the
	/// result will not be accurate.
	/// </summary>
	public virtual void UseContinuousCellRangeOn()
	{
		vtkThreshold_UseContinuousCellRangeOn_52(GetCppThis());
	}
}
