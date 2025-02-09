using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAppendFilter
/// </summary>
/// <remarks>
///    appends one or more datasets together into a single unstructured grid
///
/// vtkAppendFilter is a filter that appends one of more datasets into a single
/// unstructured grid. All geometry is extracted and appended, but point
/// attributes (i.e., scalars, vectors, normals, field data, etc.) are extracted
/// and appended only if all datasets have the point attributes available.
/// (For example, if one dataset has scalars but another does not, scalars will
/// not be appended.)
///
/// You can decide to merge points that are coincident by setting
/// `MergePoints`. If this flag is set, points are merged if they are within
/// `Tolerance` radius. If a point global id array is available (point data named
/// "GlobalPointIds"), then two points are merged if they share the same point global id,
/// without checking for coincident point.
///
/// </remarks>
/// <seealso>
///
/// vtkAppendPolyData
/// </seealso>
public class vtkAppendFilter : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAppendFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAppendFilter()
	{
		MRClassNameKey = "class vtkAppendFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAppendFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendFilter New()
	{
		vtkAppendFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAppendFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAppendFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAppendFilter_GetInput_01(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get any input of this filter.
	/// </summary>
	public new vtkDataSet GetInput(int idx)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendFilter_GetInput_01(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendFilter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get any input of this filter.
	/// </summary>
	public new vtkDataSet GetInput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendFilter_GetInput_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendFilter_GetInputList_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns a copy of the input array.  Modifications to this list
	/// will not be reflected in the actual inputs.
	/// </summary>
	public vtkDataSetCollection GetInputList()
	{
		vtkDataSetCollection vtkDataSetCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendFilter_GetInputList_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetCollection2 = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetCollection2.Register(null);
			}
		}
		return vtkDataSetCollection2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendFilter_GetMergePoints_04(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note: The filter will only merge points if the ghost cell array doesn't exist
	/// Defaults to Off
	/// </summary>
	public virtual int GetMergePoints()
	{
		return vtkAppendFilter_GetMergePoints_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAppendFilter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendFilter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAppendFilter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendFilter_GetOutputPointsPrecision_07(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkAppendFilter_GetOutputPointsPrecision_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendFilter_GetOutputPointsPrecisionMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMaxValue()
	{
		return vtkAppendFilter_GetOutputPointsPrecisionMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendFilter_GetOutputPointsPrecisionMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMinValue()
	{
		return vtkAppendFilter_GetOutputPointsPrecisionMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAppendFilter_GetTolerance_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the tolerance to use to find coincident points when `MergePoints`
	/// is `true`. Default is 0.0.
	///
	/// This is simply passed on to the internal vtkLocator used to merge points.
	/// @sa `vtkLocator::SetTolerance`.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkAppendFilter_GetTolerance_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAppendFilter_GetToleranceIsAbsolute_11(HandleRef pThis);

	/// <summary>
	/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
	/// The default is to treat it as an absolute tolerance. When off, the
	/// tolerance is multiplied by the diagonal of the bounding box of the input.
	/// </summary>
	public virtual bool GetToleranceIsAbsolute()
	{
		return (vtkAppendFilter_GetToleranceIsAbsolute_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAppendFilter_GetToleranceMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Get/Set the tolerance to use to find coincident points when `MergePoints`
	/// is `true`. Default is 0.0.
	///
	/// This is simply passed on to the internal vtkLocator used to merge points.
	/// @sa `vtkLocator::SetTolerance`.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkAppendFilter_GetToleranceMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAppendFilter_GetToleranceMinValue_13(HandleRef pThis);

	/// <summary>
	/// Get/Set the tolerance to use to find coincident points when `MergePoints`
	/// is `true`. Default is 0.0.
	///
	/// This is simply passed on to the internal vtkLocator used to merge points.
	/// @sa `vtkLocator::SetTolerance`.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkAppendFilter_GetToleranceMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendFilter_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAppendFilter_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendFilter_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAppendFilter_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendFilter_MergePointsOff_16(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note: The filter will only merge points if the ghost cell array doesn't exist
	/// Defaults to Off
	/// </summary>
	public virtual void MergePointsOff()
	{
		vtkAppendFilter_MergePointsOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendFilter_MergePointsOn_17(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note: The filter will only merge points if the ghost cell array doesn't exist
	/// Defaults to Off
	/// </summary>
	public virtual void MergePointsOn()
	{
		vtkAppendFilter_MergePointsOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendFilter_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAppendFilter NewInstance()
	{
		vtkAppendFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendFilter_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendFilter_RemoveInputData_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a dataset from the list of data to append.
	/// </summary>
	public void RemoveInputData(vtkDataSet arg0)
	{
		vtkAppendFilter_RemoveInputData_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendFilter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendFilter SafeDownCast(vtkObjectBase o)
	{
		vtkAppendFilter vtkAppendFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendFilter_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAppendFilter2 = (vtkAppendFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAppendFilter2.Register(null);
			}
		}
		return vtkAppendFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendFilter_SetMergePoints_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set if the filter should merge coincidental points
	/// Note: The filter will only merge points if the ghost cell array doesn't exist
	/// Defaults to Off
	/// </summary>
	public virtual void SetMergePoints(int _arg)
	{
		vtkAppendFilter_SetMergePoints_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendFilter_SetOutputPointsPrecision_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkAppendFilter_SetOutputPointsPrecision_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendFilter_SetTolerance_24(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the tolerance to use to find coincident points when `MergePoints`
	/// is `true`. Default is 0.0.
	///
	/// This is simply passed on to the internal vtkLocator used to merge points.
	/// @sa `vtkLocator::SetTolerance`.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkAppendFilter_SetTolerance_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendFilter_SetToleranceIsAbsolute_25(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
	/// The default is to treat it as an absolute tolerance. When off, the
	/// tolerance is multiplied by the diagonal of the bounding box of the input.
	/// </summary>
	public virtual void SetToleranceIsAbsolute(bool _arg)
	{
		vtkAppendFilter_SetToleranceIsAbsolute_25(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendFilter_ToleranceIsAbsoluteOff_26(HandleRef pThis);

	/// <summary>
	/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
	/// The default is to treat it as an absolute tolerance. When off, the
	/// tolerance is multiplied by the diagonal of the bounding box of the input.
	/// </summary>
	public virtual void ToleranceIsAbsoluteOff()
	{
		vtkAppendFilter_ToleranceIsAbsoluteOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendFilter_ToleranceIsAbsoluteOn_27(HandleRef pThis);

	/// <summary>
	/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
	/// The default is to treat it as an absolute tolerance. When off, the
	/// tolerance is multiplied by the diagonal of the bounding box of the input.
	/// </summary>
	public virtual void ToleranceIsAbsoluteOn()
	{
		vtkAppendFilter_ToleranceIsAbsoluteOn_27(GetCppThis());
	}
}
