using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkClipDataSet
/// </summary>
/// <remarks>
///    clip any dataset with user-specified implicit function or input scalar data
///
/// vtkClipDataSet is a filter that clips any type of dataset using either
/// any subclass of vtkImplicitFunction, or the input scalar
/// data. Clipping means that it actually "cuts" through the cells of
/// the dataset, returning everything inside of the specified implicit
/// function (or greater than the scalar value) including "pieces" of
/// a cell. (Compare this with vtkExtractGeometry, which pulls out
/// entire, uncut cells.) The output of this filter is an unstructured
/// grid.
///
/// To use this filter, you must decide if you will be clipping with an
/// implicit function, or whether you will be using the input scalar
/// data.  If you want to clip with an implicit function, you must:
/// 1) define an implicit function
/// 2) set it with the SetClipFunction method
/// 3) apply the GenerateClipScalarsOn method
/// If a ClipFunction is not specified, or GenerateClipScalars is off
/// (the default), then the input's scalar data will be used to clip
/// the polydata.
///
/// You can also specify a scalar value, which is used to decide what is
/// inside and outside of the implicit function. You can also reverse the
/// sense of what inside/outside is by setting the InsideOut instance
/// variable. (The clipping algorithm proceeds by computing an implicit
/// function value or using the input scalar data for each point in the
/// dataset. This is compared to the scalar value to determine
/// inside/outside.)
///
/// This filter can be configured to compute a second output. The
/// second output is the part of the cell that is clipped away. Set the
/// GenerateClippedData boolean on if you wish to access this output data.
///
/// @warning
/// vtkClipDataSet will triangulate all types of 3D cells (i.e., create
/// tetrahedra). This is true even if the cell is not actually cut. This
/// is necessary to preserve compatibility across face neighbors. 2D cells
/// will only be triangulated if the cutting function passes through them.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunction vtkCutter vtkClipVolume vtkClipPolyData
/// </seealso>
public class vtkClipDataSet : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkClipDataSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkClipDataSet()
	{
		MRClassNameKey = "class vtkClipDataSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipDataSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkClipDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with user-specified implicit function; InsideOut turned off;
	/// value set to 0.0; and generate clip scalars turned off.
	/// </summary>
	public new static vtkClipDataSet New()
	{
		vtkClipDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with user-specified implicit function; InsideOut turned off;
	/// value set to 0.0; and generate clip scalars turned off.
	/// </summary>
	public vtkClipDataSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkClipDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_CreateDefaultLocator_01(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified. The
	/// locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkClipDataSet_CreateDefaultLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_GenerateClipScalarsOff_02(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual void GenerateClipScalarsOff()
	{
		vtkClipDataSet_GenerateClipScalarsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_GenerateClipScalarsOn_03(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual void GenerateClipScalarsOn()
	{
		vtkClipDataSet_GenerateClipScalarsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_GenerateClippedOutputOff_04(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual void GenerateClippedOutputOff()
	{
		vtkClipDataSet_GenerateClippedOutputOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_GenerateClippedOutputOn_05(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual void GenerateClippedOutputOn()
	{
		vtkClipDataSet_GenerateClippedOutputOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipDataSet_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function with which to perform the
	/// clipping. If you do not define an implicit function,
	/// then the selected input scalar data will be used for clipping.
	/// </summary>
	public virtual vtkImplicitFunction GetClipFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipDataSet_GetClipFunction_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunction2 = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunction2.Register(null);
			}
		}
		return vtkImplicitFunction2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipDataSet_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the Clipped output.
	/// </summary>
	public vtkUnstructuredGrid GetClippedOutput()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipDataSet_GetClippedOutput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipDataSet_GetGenerateClipScalars_08(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual int GetGenerateClipScalars()
	{
		return vtkClipDataSet_GetGenerateClipScalars_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipDataSet_GetGenerateClippedOutput_09(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual int GetGenerateClippedOutput()
	{
		return vtkClipDataSet_GetGenerateClippedOutput_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipDataSet_GetInsideOut_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered
	/// inside the implicit function if its value is greater than the
	/// Value ivar. When InsideOutside is turned on, a vertex is
	/// considered inside the implicit function if its implicit function
	/// value is less than or equal to the Value ivar.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual int GetInsideOut()
	{
		return vtkClipDataSet_GetInsideOut_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipDataSet_GetLocator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a spatial locator for merging points. By default, an
	/// instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipDataSet_GetLocator_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkClipDataSet_GetMTime_12(HandleRef pThis);

	/// <summary>
	/// Return the mtime also considering the locator and clip function.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkClipDataSet_GetMTime_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClipDataSet_GetMergeTolerance_13(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate primitives. Note that only 3D cells actually use this
	/// instance variable.
	/// </summary>
	public virtual double GetMergeTolerance()
	{
		return vtkClipDataSet_GetMergeTolerance_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClipDataSet_GetMergeToleranceMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate primitives. Note that only 3D cells actually use this
	/// instance variable.
	/// </summary>
	public virtual double GetMergeToleranceMaxValue()
	{
		return vtkClipDataSet_GetMergeToleranceMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClipDataSet_GetMergeToleranceMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate primitives. Note that only 3D cells actually use this
	/// instance variable.
	/// </summary>
	public virtual double GetMergeToleranceMinValue()
	{
		return vtkClipDataSet_GetMergeToleranceMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClipDataSet_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkClipDataSet_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClipDataSet_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkClipDataSet_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipDataSet_GetOutputPointsPrecision_18(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkClipDataSet_GetOutputPointsPrecision_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipDataSet_GetOutputPointsPrecisionMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMaxValue()
	{
		return vtkClipDataSet_GetOutputPointsPrecisionMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipDataSet_GetOutputPointsPrecisionMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMinValue()
	{
		return vtkClipDataSet_GetOutputPointsPrecisionMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkClipDataSet_GetUseValueAsOffset_21(HandleRef pThis);

	/// <summary>
	/// If UseValueAsOffset is true, Value is used as an offset parameter to
	/// the implicit function. Otherwise, Value is used only when clipping
	/// using a scalar array. Default is true.
	/// </summary>
	public virtual bool GetUseValueAsOffset()
	{
		return (vtkClipDataSet_GetUseValueAsOffset_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClipDataSet_GetValue_22(HandleRef pThis);

	/// <summary>
	/// Set the clipping value of the implicit function (if clipping with
	/// implicit function) or scalar value (if clipping with
	/// scalars). The default value is 0.0. This value is ignored if
	/// UseValueAsOffset is true and a clip function is defined.
	/// </summary>
	public virtual double GetValue()
	{
		return vtkClipDataSet_GetValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_InsideOutOff_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered
	/// inside the implicit function if its value is greater than the
	/// Value ivar. When InsideOutside is turned on, a vertex is
	/// considered inside the implicit function if its implicit function
	/// value is less than or equal to the Value ivar.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual void InsideOutOff()
	{
		vtkClipDataSet_InsideOutOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_InsideOutOn_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered
	/// inside the implicit function if its value is greater than the
	/// Value ivar. When InsideOutside is turned on, a vertex is
	/// considered inside the implicit function if its implicit function
	/// value is less than or equal to the Value ivar.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual void InsideOutOn()
	{
		vtkClipDataSet_InsideOutOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipDataSet_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkClipDataSet_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipDataSet_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkClipDataSet_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipDataSet_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkClipDataSet NewInstance()
	{
		vtkClipDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipDataSet_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipDataSet_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkClipDataSet SafeDownCast(vtkObjectBase o)
	{
		vtkClipDataSet vtkClipDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipDataSet_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkClipDataSet2 = (vtkClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkClipDataSet2.Register(null);
			}
		}
		return vtkClipDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_SetClipFunction_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function with which to perform the
	/// clipping. If you do not define an implicit function,
	/// then the selected input scalar data will be used for clipping.
	/// </summary>
	public virtual void SetClipFunction(vtkImplicitFunction arg0)
	{
		vtkClipDataSet_SetClipFunction_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_SetGenerateClipScalars_31(HandleRef pThis, int _arg);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual void SetGenerateClipScalars(int _arg)
	{
		vtkClipDataSet_SetGenerateClipScalars_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_SetGenerateClippedOutput_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual void SetGenerateClippedOutput(int _arg)
	{
		vtkClipDataSet_SetGenerateClippedOutput_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_SetInsideOut_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered
	/// inside the implicit function if its value is greater than the
	/// Value ivar. When InsideOutside is turned on, a vertex is
	/// considered inside the implicit function if its implicit function
	/// value is less than or equal to the Value ivar.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual void SetInsideOut(int _arg)
	{
		vtkClipDataSet_SetInsideOut_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_SetLocator_34(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a spatial locator for merging points. By default, an
	/// instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkClipDataSet_SetLocator_34(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_SetMergeTolerance_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate primitives. Note that only 3D cells actually use this
	/// instance variable.
	/// </summary>
	public virtual void SetMergeTolerance(double _arg)
	{
		vtkClipDataSet_SetMergeTolerance_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_SetOutputPointsPrecision_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkClipDataSet_SetOutputPointsPrecision_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_SetUseValueAsOffset_37(HandleRef pThis, byte _arg);

	/// <summary>
	/// If UseValueAsOffset is true, Value is used as an offset parameter to
	/// the implicit function. Otherwise, Value is used only when clipping
	/// using a scalar array. Default is true.
	/// </summary>
	public virtual void SetUseValueAsOffset(bool _arg)
	{
		vtkClipDataSet_SetUseValueAsOffset_37(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_SetValue_38(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the clipping value of the implicit function (if clipping with
	/// implicit function) or scalar value (if clipping with
	/// scalars). The default value is 0.0. This value is ignored if
	/// UseValueAsOffset is true and a clip function is defined.
	/// </summary>
	public virtual void SetValue(double _arg)
	{
		vtkClipDataSet_SetValue_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_UseValueAsOffsetOff_39(HandleRef pThis);

	/// <summary>
	/// If UseValueAsOffset is true, Value is used as an offset parameter to
	/// the implicit function. Otherwise, Value is used only when clipping
	/// using a scalar array. Default is true.
	/// </summary>
	public virtual void UseValueAsOffsetOff()
	{
		vtkClipDataSet_UseValueAsOffsetOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipDataSet_UseValueAsOffsetOn_40(HandleRef pThis);

	/// <summary>
	/// If UseValueAsOffset is true, Value is used as an offset parameter to
	/// the implicit function. Otherwise, Value is used only when clipping
	/// using a scalar array. Default is true.
	/// </summary>
	public virtual void UseValueAsOffsetOn()
	{
		vtkClipDataSet_UseValueAsOffsetOn_40(GetCppThis());
	}
}
