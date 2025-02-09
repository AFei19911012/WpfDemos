using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProbeFilter
/// </summary>
/// <remarks>
///    sample data values at specified point locations
///
/// vtkProbeFilter is a filter that computes point attributes (e.g., scalars,
/// vectors, etc.) at specified point positions. The filter has two inputs:
/// the Input and Source. The Input geometric structure is passed through the
/// filter. The point attributes are computed at the Input point positions
/// by interpolating into the source data. For example, we can compute data
/// values on a plane (plane specified as Input) from a volume (Source).
/// The cell data of the source data is copied to the output based on in
/// which source cell each input point is. If an array of the same name exists
/// both in source's point and cell data, only the one from the point data is
/// probed.
///
/// This filter can be used to resample data, or convert one dataset form into
/// another. For example, an unstructured grid (vtkUnstructuredGrid) can be
/// probed with a volume (three-dimensional vtkImageData), and then volume
/// rendering techniques can be used to visualize the results. Another example:
/// a line or curve can be used to probe data to produce x-y plots along
/// that line or curve.
///
/// @warning
/// A critical algorithmic component of vtkProbeFilter is the manner in which
/// it finds the cell containing a probe point. By default, the
/// vtkDataSet::FindCell() method is used, which in turn uses a
/// vtkPointLocator to perform an accelerated search. However, using a
/// vtkPointLocator may fail to identify an enclosing cell in some cases. A
/// more robust but slower approach is to use a vtkCellLocator to perform the
/// the FindCell() operation (via specification of the
/// CellLocatorPrototype). Finally, more advanced searches can be configured
/// by specifying an instance of vtkFindCellStrategy. (Note: image data
/// probing never uses a locator since finding a containing cell is a simple,
/// fast operation. This specifying a vtkFindCellStrategy or cell locator
/// prototype has no effect.)
///
/// @warning
/// The vtkProbeFilter, once it finds the cell containing a query point, uses
/// the cell's interpolation functions to perform the interpolate / compute
/// the point attributes. Note that other interpolation processes with
/// different kernels are available: vtkPointInterpolator and
/// vtkSPHInterpolator. vtkPointInterpolator supports a variety of generalized
/// kernels, while vtkSPHInterpolator supports a variety of SPH interpolation
/// kernels.
///
/// </remarks>
/// <seealso>
///
/// vtkFindCellStrategy vtkPointLocator vtkCellLocator vtkStaticPointLocator
/// vtkStaticCellLocator vtkPointInterpolator vtkSPHInterpolator
/// </seealso>
public class vtkProbeFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProbeFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProbeFilter()
	{
		MRClassNameKey = "class vtkProbeFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProbeFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProbeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProbeFilter New()
	{
		vtkProbeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProbeFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProbeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkProbeFilter_CategoricalDataOff_01(HandleRef pThis);

	/// <summary>
	/// Control whether the source point data is to be treated as categorical. If
	/// the data is categorical, then the resultant data will be determined by
	/// a nearest neighbor interpolation scheme.
	/// </summary>
	public virtual void CategoricalDataOff()
	{
		vtkProbeFilter_CategoricalDataOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_CategoricalDataOn_02(HandleRef pThis);

	/// <summary>
	/// Control whether the source point data is to be treated as categorical. If
	/// the data is categorical, then the resultant data will be determined by
	/// a nearest neighbor interpolation scheme.
	/// </summary>
	public virtual void CategoricalDataOn()
	{
		vtkProbeFilter_CategoricalDataOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_ComputeToleranceOff_03(HandleRef pThis);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field
	/// value is ignored. On by default.
	/// </summary>
	public virtual void ComputeToleranceOff()
	{
		vtkProbeFilter_ComputeToleranceOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_ComputeToleranceOn_04(HandleRef pThis);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field
	/// value is ignored. On by default.
	/// </summary>
	public virtual void ComputeToleranceOn()
	{
		vtkProbeFilter_ComputeToleranceOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbeFilter_GetCategoricalData_05(HandleRef pThis);

	/// <summary>
	/// Control whether the source point data is to be treated as categorical. If
	/// the data is categorical, then the resultant data will be determined by
	/// a nearest neighbor interpolation scheme.
	/// </summary>
	public virtual int GetCategoricalData()
	{
		return vtkProbeFilter_GetCategoricalData_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbeFilter_GetCellLocatorPrototype_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the prototype cell locator to perform the FindCell() operation.
	/// (A prototype is used as an object factory to instantiate an instance of
	/// the prototype to perform the FindCell() operation). If a prototype, and
	/// a vtkFindCellStrategy are not defined, the vtkDataSet::FindCell() is
	/// used. If a vtkFindCellStrategy is not defined, then the prototype is
	/// used.
	/// </summary>
	public virtual vtkAbstractCellLocator GetCellLocatorPrototype()
	{
		vtkAbstractCellLocator vtkAbstractCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbeFilter_GetCellLocatorPrototype_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractCellLocator2 = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractCellLocator2.Register(null);
			}
		}
		return vtkAbstractCellLocator2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProbeFilter_GetComputeTolerance_07(HandleRef pThis);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field
	/// value is ignored. On by default.
	/// </summary>
	public virtual bool GetComputeTolerance()
	{
		return (vtkProbeFilter_GetComputeTolerance_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbeFilter_GetFindCellStrategy_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get the strategy used to perform the FindCell() operation. When
	/// specified, the strategy is used in preference to a cell locator
	/// prototype. When neither a strategy or cell locator prototype is defined,
	/// then the vtkDataSet::FindCell() method is used.
	/// </summary>
	public virtual vtkFindCellStrategy GetFindCellStrategy()
	{
		vtkFindCellStrategy vtkFindCellStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbeFilter_GetFindCellStrategy_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFindCellStrategy2 = (vtkFindCellStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFindCellStrategy2.Register(null);
			}
		}
		return vtkFindCellStrategy2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProbeFilter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProbeFilter_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProbeFilter_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProbeFilter_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbeFilter_GetPassCellArrays_11(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public virtual int GetPassCellArrays()
	{
		return vtkProbeFilter_GetPassCellArrays_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbeFilter_GetPassFieldArrays_12(HandleRef pThis);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public virtual int GetPassFieldArrays()
	{
		return vtkProbeFilter_GetPassFieldArrays_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbeFilter_GetPassPointArrays_13(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public virtual int GetPassPointArrays()
	{
		return vtkProbeFilter_GetPassPointArrays_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProbeFilter_GetSnapToCellWithClosestPoint_14(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
	/// FindCell is executed.
	///
	/// Default is off.
	///
	/// Note: This is useful only when the source is a vtkPointSet.
	/// </summary>
	public virtual bool GetSnapToCellWithClosestPoint()
	{
		return (vtkProbeFilter_GetSnapToCellWithClosestPoint_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbeFilter_GetSource_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the data set that will be probed at the input points.
	/// The Input gives the geometry (the points and cells) for the output,
	/// while the Source is probed (interpolated) to generate the scalars,
	/// vectors, etc. for the output points based on the point locations.
	/// </summary>
	public vtkDataObject GetSource()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbeFilter_GetSource_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbeFilter_GetSpatialMatch_16(HandleRef pThis);

	/// <summary>
	/// This flag is used only when a piece is requested to update.  By default
	/// the flag is off.  Because no spatial correspondence between input pieces
	/// and source pieces is known, all of the source has to be requested no
	/// matter what piece of the output is requested.  When there is a spatial
	/// correspondence, the user/application can set this flag.  This hint allows
	/// the breakup of the probe operation to be much more efficient.  When piece
	/// m of n is requested for update by the user, then only n of m needs to
	/// be requested of the source.
	/// </summary>
	public virtual int GetSpatialMatch()
	{
		return vtkProbeFilter_GetSpatialMatch_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProbeFilter_GetTolerance_17(HandleRef pThis);

	/// <summary>
	/// Set the tolerance used to compute whether a point in the
	/// source is in a cell of the input.  This value is only used
	/// if ComputeTolerance is off.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkProbeFilter_GetTolerance_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbeFilter_GetValidPointMaskArrayName_18(HandleRef pThis);

	/// <summary>
	/// Returns the name of the char array added to the output with values 1 for
	/// valid points and 0 for invalid points.
	/// Set to "vtkValidPointMask" by default.
	/// </summary>
	public virtual string GetValidPointMaskArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkProbeFilter_GetValidPointMaskArrayName_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbeFilter_GetValidPoints_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the list of point ids in the output that contain attribute data
	/// interpolated from the source.
	/// </summary>
	public vtkIdTypeArray GetValidPoints()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbeFilter_GetValidPoints_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbeFilter_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProbeFilter_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbeFilter_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProbeFilter_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbeFilter_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProbeFilter NewInstance()
	{
		vtkProbeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbeFilter_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_PassCellArraysOff_24(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public virtual void PassCellArraysOff()
	{
		vtkProbeFilter_PassCellArraysOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_PassCellArraysOn_25(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public virtual void PassCellArraysOn()
	{
		vtkProbeFilter_PassCellArraysOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_PassFieldArraysOff_26(HandleRef pThis);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public virtual void PassFieldArraysOff()
	{
		vtkProbeFilter_PassFieldArraysOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_PassFieldArraysOn_27(HandleRef pThis);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public virtual void PassFieldArraysOn()
	{
		vtkProbeFilter_PassFieldArraysOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_PassPointArraysOff_28(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public virtual void PassPointArraysOff()
	{
		vtkProbeFilter_PassPointArraysOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_PassPointArraysOn_29(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public virtual void PassPointArraysOn()
	{
		vtkProbeFilter_PassPointArraysOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbeFilter_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProbeFilter SafeDownCast(vtkObjectBase o)
	{
		vtkProbeFilter vtkProbeFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbeFilter_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProbeFilter2 = (vtkProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProbeFilter2.Register(null);
			}
		}
		return vtkProbeFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetCategoricalData_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether the source point data is to be treated as categorical. If
	/// the data is categorical, then the resultant data will be determined by
	/// a nearest neighbor interpolation scheme.
	/// </summary>
	public virtual void SetCategoricalData(int _arg)
	{
		vtkProbeFilter_SetCategoricalData_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetCellLocatorPrototype_32(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the prototype cell locator to perform the FindCell() operation.
	/// (A prototype is used as an object factory to instantiate an instance of
	/// the prototype to perform the FindCell() operation). If a prototype, and
	/// a vtkFindCellStrategy are not defined, the vtkDataSet::FindCell() is
	/// used. If a vtkFindCellStrategy is not defined, then the prototype is
	/// used.
	/// </summary>
	public virtual void SetCellLocatorPrototype(vtkAbstractCellLocator arg0)
	{
		vtkProbeFilter_SetCellLocatorPrototype_32(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetComputeTolerance_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field
	/// value is ignored. On by default.
	/// </summary>
	public virtual void SetComputeTolerance(bool _arg)
	{
		vtkProbeFilter_SetComputeTolerance_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetFindCellStrategy_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / get the strategy used to perform the FindCell() operation. When
	/// specified, the strategy is used in preference to a cell locator
	/// prototype. When neither a strategy or cell locator prototype is defined,
	/// then the vtkDataSet::FindCell() method is used.
	/// </summary>
	public virtual void SetFindCellStrategy(vtkFindCellStrategy arg0)
	{
		vtkProbeFilter_SetFindCellStrategy_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetPassCellArrays_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public virtual void SetPassCellArrays(int _arg)
	{
		vtkProbeFilter_SetPassCellArrays_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetPassFieldArrays_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public virtual void SetPassFieldArrays(int _arg)
	{
		vtkProbeFilter_SetPassFieldArrays_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetPassPointArrays_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public virtual void SetPassPointArrays(int _arg)
	{
		vtkProbeFilter_SetPassPointArrays_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetSnapToCellWithClosestPoint_38(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
	/// FindCell is executed.
	///
	/// Default is off.
	///
	/// Note: This is useful only when the source is a vtkPointSet.
	/// </summary>
	public virtual void SetSnapToCellWithClosestPoint(bool _arg)
	{
		vtkProbeFilter_SetSnapToCellWithClosestPoint_38(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetSourceConnection_39(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the data set that will be probed at the input points.
	/// The Input gives the geometry (the points and cells) for the output,
	/// while the Source is probed (interpolated) to generate the scalars,
	/// vectors, etc. for the output points based on the point locations.
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkProbeFilter_SetSourceConnection_39(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetSourceData_40(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the data set that will be probed at the input points.
	/// The Input gives the geometry (the points and cells) for the output,
	/// while the Source is probed (interpolated) to generate the scalars,
	/// vectors, etc. for the output points based on the point locations.
	/// </summary>
	public void SetSourceData(vtkDataObject source)
	{
		vtkProbeFilter_SetSourceData_40(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetSpatialMatch_41(HandleRef pThis, int _arg);

	/// <summary>
	/// This flag is used only when a piece is requested to update.  By default
	/// the flag is off.  Because no spatial correspondence between input pieces
	/// and source pieces is known, all of the source has to be requested no
	/// matter what piece of the output is requested.  When there is a spatial
	/// correspondence, the user/application can set this flag.  This hint allows
	/// the breakup of the probe operation to be much more efficient.  When piece
	/// m of n is requested for update by the user, then only n of m needs to
	/// be requested of the source.
	/// </summary>
	public virtual void SetSpatialMatch(int _arg)
	{
		vtkProbeFilter_SetSpatialMatch_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetTolerance_42(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the tolerance used to compute whether a point in the
	/// source is in a cell of the input.  This value is only used
	/// if ComputeTolerance is off.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkProbeFilter_SetTolerance_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SetValidPointMaskArrayName_43(HandleRef pThis, string _arg);

	/// <summary>
	/// Returns the name of the char array added to the output with values 1 for
	/// valid points and 0 for invalid points.
	/// Set to "vtkValidPointMask" by default.
	/// </summary>
	public virtual void SetValidPointMaskArrayName(string _arg)
	{
		vtkProbeFilter_SetValidPointMaskArrayName_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SnapToCellWithClosestPointOff_44(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
	/// FindCell is executed.
	///
	/// Default is off.
	///
	/// Note: This is useful only when the source is a vtkPointSet.
	/// </summary>
	public virtual void SnapToCellWithClosestPointOff()
	{
		vtkProbeFilter_SnapToCellWithClosestPointOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SnapToCellWithClosestPointOn_45(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
	/// FindCell is executed.
	///
	/// Default is off.
	///
	/// Note: This is useful only when the source is a vtkPointSet.
	/// </summary>
	public virtual void SnapToCellWithClosestPointOn()
	{
		vtkProbeFilter_SnapToCellWithClosestPointOn_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SpatialMatchOff_46(HandleRef pThis);

	/// <summary>
	/// This flag is used only when a piece is requested to update.  By default
	/// the flag is off.  Because no spatial correspondence between input pieces
	/// and source pieces is known, all of the source has to be requested no
	/// matter what piece of the output is requested.  When there is a spatial
	/// correspondence, the user/application can set this flag.  This hint allows
	/// the breakup of the probe operation to be much more efficient.  When piece
	/// m of n is requested for update by the user, then only n of m needs to
	/// be requested of the source.
	/// </summary>
	public virtual void SpatialMatchOff()
	{
		vtkProbeFilter_SpatialMatchOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbeFilter_SpatialMatchOn_47(HandleRef pThis);

	/// <summary>
	/// This flag is used only when a piece is requested to update.  By default
	/// the flag is off.  Because no spatial correspondence between input pieces
	/// and source pieces is known, all of the source has to be requested no
	/// matter what piece of the output is requested.  When there is a spatial
	/// correspondence, the user/application can set this flag.  This hint allows
	/// the breakup of the probe operation to be much more efficient.  When piece
	/// m of n is requested for update by the user, then only n of m needs to
	/// be requested of the source.
	/// </summary>
	public virtual void SpatialMatchOn()
	{
		vtkProbeFilter_SpatialMatchOn_47(GetCppThis());
	}
}
