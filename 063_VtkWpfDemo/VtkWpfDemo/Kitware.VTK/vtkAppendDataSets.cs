using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAppendDataSets
/// </summary>
/// <remarks>
///    Appends one or more datasets together into a single output vtkPointSet.
///
/// vtkAppendDataSets is a filter that appends one of more datasets into a single output
/// point set. The type of the output is set with the OutputDataSetType option. Only inputs
/// that can be converted to the selected output dataset type are appended to the output.
/// By default, the output is vtkUnstructuredGrid, and all input types can be appended to it.
/// If the OutputDataSetType is set to produce vtkPolyData, then only datasets that can be
/// converted to vtkPolyData (i.e., vtkPolyData) are appended to the output.
///
/// All cells are extracted and appended, but point and cell attributes (i.e., scalars,
/// vectors, normals, field data, etc.) are extracted and appended only if all datasets
/// have the same point and/or cell attributes available. (For example, if one dataset
/// has scalars but another does not, scalars will not be appended.)
///
/// Points can be merged if MergePoints is set to true. In this case, points are
/// really merged if there are no ghost cells and no global point ids, or if
/// there are global point ids. In the case of the presence of global point ids,
/// the filter exclusively relies on those ids, not checking if points are
/// coincident. It assumes that the global ids were properly set. In the case of
/// the absence of global ids, points within Tolerance are merged.
///
/// </remarks>
/// <seealso>
///
/// vtkAppendFilter vtkAppendPolyData
/// </seealso>
public class vtkAppendDataSets : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAppendDataSets";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAppendDataSets()
	{
		MRClassNameKey = "class vtkAppendDataSets";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendDataSets"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAppendDataSets(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendDataSets_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendDataSets New()
	{
		vtkAppendDataSets result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendDataSets_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendDataSets)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAppendDataSets()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAppendDataSets_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkAppendDataSets_GetMergePoints_01(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note: The filter will only merge points if the ghost cell array doesn't exist
	/// Defaults to Off
	/// </summary>
	public virtual bool GetMergePoints()
	{
		return (vtkAppendDataSets_GetMergePoints_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendDataSets_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAppendDataSets_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendDataSets_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAppendDataSets_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendDataSets_GetOutputDataSetType_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the output type produced by this filter. Only input datasets compatible with the
	/// output type will be merged in the output. For example, if the output type is vtkPolyData, then
	/// blocks of type vtkImageData, vtkStructuredGrid, etc. will not be merged - only vtkPolyData
	/// can be merged into a vtkPolyData. On the other hand, if the output type is
	/// vtkUnstructuredGrid, then blocks of almost any type will be merged in the output.
	/// Valid values are VTK_POLY_DATA and VTK_UNSTRUCTURED_GRID defined in vtkType.h.
	/// Defaults to VTK_UNSTRUCTURED_GRID.
	/// </summary>
	public virtual int GetOutputDataSetType()
	{
		return vtkAppendDataSets_GetOutputDataSetType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendDataSets_GetOutputPointsPrecision_05(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkAppendDataSets_GetOutputPointsPrecision_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendDataSets_GetOutputPointsPrecisionMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMaxValue()
	{
		return vtkAppendDataSets_GetOutputPointsPrecisionMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendDataSets_GetOutputPointsPrecisionMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMinValue()
	{
		return vtkAppendDataSets_GetOutputPointsPrecisionMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAppendDataSets_GetTolerance_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the tolerance to use to find coincident points when `MergePoints`
	/// is `true`. Default is 0.0.
	///
	/// This is simply passed on to the internal vtkLocator used to merge points.
	/// @sa `vtkLocator::SetTolerance`.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkAppendDataSets_GetTolerance_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAppendDataSets_GetToleranceIsAbsolute_09(HandleRef pThis);

	/// <summary>
	/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
	/// The default is to treat it as an absolute tolerance. When off, the
	/// tolerance is multiplied by the diagonal of the bounding box of the input.
	/// </summary>
	public virtual bool GetToleranceIsAbsolute()
	{
		return (vtkAppendDataSets_GetToleranceIsAbsolute_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAppendDataSets_GetToleranceMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the tolerance to use to find coincident points when `MergePoints`
	/// is `true`. Default is 0.0.
	///
	/// This is simply passed on to the internal vtkLocator used to merge points.
	/// @sa `vtkLocator::SetTolerance`.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkAppendDataSets_GetToleranceMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAppendDataSets_GetToleranceMinValue_11(HandleRef pThis);

	/// <summary>
	/// Get/Set the tolerance to use to find coincident points when `MergePoints`
	/// is `true`. Default is 0.0.
	///
	/// This is simply passed on to the internal vtkLocator used to merge points.
	/// @sa `vtkLocator::SetTolerance`.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkAppendDataSets_GetToleranceMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendDataSets_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAppendDataSets_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendDataSets_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAppendDataSets_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendDataSets_MergePointsOff_14(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note: The filter will only merge points if the ghost cell array doesn't exist
	/// Defaults to Off
	/// </summary>
	public virtual void MergePointsOff()
	{
		vtkAppendDataSets_MergePointsOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendDataSets_MergePointsOn_15(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note: The filter will only merge points if the ghost cell array doesn't exist
	/// Defaults to Off
	/// </summary>
	public virtual void MergePointsOn()
	{
		vtkAppendDataSets_MergePointsOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendDataSets_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAppendDataSets NewInstance()
	{
		vtkAppendDataSets result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendDataSets_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendDataSets)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendDataSets_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendDataSets SafeDownCast(vtkObjectBase o)
	{
		vtkAppendDataSets vtkAppendDataSets2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendDataSets_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAppendDataSets2 = (vtkAppendDataSets)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAppendDataSets2.Register(null);
			}
		}
		return vtkAppendDataSets2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendDataSets_SetMergePoints_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note: The filter will only merge points if the ghost cell array doesn't exist
	/// Defaults to Off
	/// </summary>
	public virtual void SetMergePoints(bool _arg)
	{
		vtkAppendDataSets_SetMergePoints_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendDataSets_SetOutputDataSetType_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the output type produced by this filter. Only input datasets compatible with the
	/// output type will be merged in the output. For example, if the output type is vtkPolyData, then
	/// blocks of type vtkImageData, vtkStructuredGrid, etc. will not be merged - only vtkPolyData
	/// can be merged into a vtkPolyData. On the other hand, if the output type is
	/// vtkUnstructuredGrid, then blocks of almost any type will be merged in the output.
	/// Valid values are VTK_POLY_DATA and VTK_UNSTRUCTURED_GRID defined in vtkType.h.
	/// Defaults to VTK_UNSTRUCTURED_GRID.
	/// </summary>
	public virtual void SetOutputDataSetType(int _arg)
	{
		vtkAppendDataSets_SetOutputDataSetType_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendDataSets_SetOutputPointsPrecision_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkAppendDataSets_SetOutputPointsPrecision_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendDataSets_SetTolerance_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the tolerance to use to find coincident points when `MergePoints`
	/// is `true`. Default is 0.0.
	///
	/// This is simply passed on to the internal vtkLocator used to merge points.
	/// @sa `vtkLocator::SetTolerance`.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkAppendDataSets_SetTolerance_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendDataSets_SetToleranceIsAbsolute_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
	/// The default is to treat it as an absolute tolerance. When off, the
	/// tolerance is multiplied by the diagonal of the bounding box of the input.
	/// </summary>
	public virtual void SetToleranceIsAbsolute(bool _arg)
	{
		vtkAppendDataSets_SetToleranceIsAbsolute_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendDataSets_ToleranceIsAbsoluteOff_24(HandleRef pThis);

	/// <summary>
	/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
	/// The default is to treat it as an absolute tolerance. When off, the
	/// tolerance is multiplied by the diagonal of the bounding box of the input.
	/// </summary>
	public virtual void ToleranceIsAbsoluteOff()
	{
		vtkAppendDataSets_ToleranceIsAbsoluteOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendDataSets_ToleranceIsAbsoluteOn_25(HandleRef pThis);

	/// <summary>
	/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
	/// The default is to treat it as an absolute tolerance. When off, the
	/// tolerance is multiplied by the diagonal of the bounding box of the input.
	/// </summary>
	public virtual void ToleranceIsAbsoluteOn()
	{
		vtkAppendDataSets_ToleranceIsAbsoluteOn_25(GetCppThis());
	}
}
