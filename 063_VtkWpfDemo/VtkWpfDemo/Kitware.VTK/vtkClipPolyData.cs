using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkClipPolyData
/// </summary>
/// <remarks>
///    clip polygonal data with user-specified implicit function or input scalar data
///
/// vtkClipPolyData is a filter that clips polygonal data using either
/// any subclass of vtkImplicitFunction, or the input scalar
/// data. Clipping means that it actually "cuts" through the cells of
/// the dataset, returning everything inside of the specified implicit
/// function (or greater than the scalar value) including "pieces" of
/// a cell. (Compare this with vtkExtractGeometry, which pulls out
/// entire, uncut cells.) The output of this filter is polygonal data.
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
/// You can also specify a scalar value, which is used to
/// decide what is inside and outside of the implicit function. You can
/// also reverse the sense of what inside/outside is by setting the
/// InsideOut instance variable. (The cutting algorithm proceeds by
/// computing an implicit function value or using the input scalar data
/// for each point in the dataset. This is compared to the scalar value
/// to determine inside/outside.)
///
/// This filter can be configured to compute a second output. The
/// second output is the polygonal data that is clipped away. Set the
/// GenerateClippedData boolean on if you wish to access this output data.
///
/// @warning
/// In order to cut all types of cells in polygonal data, vtkClipPolyData
/// triangulates some cells, and then cuts the resulting simplices
/// (i.e., points, lines, and triangles). This means that the resulting
/// output may consist of different cell types than the input data.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunction vtkCutter vtkClipVolume vtkExtractGeometry
/// </seealso>
public class vtkClipPolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkClipPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkClipPolyData()
	{
		MRClassNameKey = "class vtkClipPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkClipPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with user-specified implicit function; InsideOut turned off;
	/// value set to 0.0; GenerateClipScalars turned off; GenerateClippedOutput
	/// turned off.
	/// </summary>
	public new static vtkClipPolyData New()
	{
		vtkClipPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClipPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with user-specified implicit function; InsideOut turned off;
	/// value set to 0.0; GenerateClipScalars turned off; GenerateClippedOutput
	/// turned off.
	/// </summary>
	public vtkClipPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkClipPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkClipPolyData_CreateDefaultLocator_01(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified. The
	/// locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkClipPolyData_CreateDefaultLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_GenerateClipScalarsOff_02(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// GenerateClipScalars is off by default.
	/// </summary>
	public virtual void GenerateClipScalarsOff()
	{
		vtkClipPolyData_GenerateClipScalarsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_GenerateClipScalarsOn_03(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// GenerateClipScalars is off by default.
	/// </summary>
	public virtual void GenerateClipScalarsOn()
	{
		vtkClipPolyData_GenerateClipScalarsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_GenerateClippedOutputOff_04(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// GenerateClippedOutput is off by default.
	/// </summary>
	public virtual void GenerateClippedOutputOff()
	{
		vtkClipPolyData_GenerateClippedOutputOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_GenerateClippedOutputOn_05(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// GenerateClippedOutput is off by default.
	/// </summary>
	public virtual void GenerateClippedOutputOn()
	{
		vtkClipPolyData_GenerateClippedOutputOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipPolyData_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function with which to perform the
	/// clipping. If you do not define an implicit function, then the input
	/// scalar data will be used for clipping.
	/// </summary>
	public virtual vtkImplicitFunction GetClipFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipPolyData_GetClipFunction_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipPolyData_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the Clipped output.
	/// </summary>
	public vtkPolyData GetClippedOutput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipPolyData_GetClippedOutput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipPolyData_GetClippedOutputPort_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the output port (a vtkAlgorithmOutput) of the clipped output.
	/// </summary>
	public vtkAlgorithmOutput GetClippedOutputPort()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipPolyData_GetClippedOutputPort_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipPolyData_GetGenerateClipScalars_09(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// GenerateClipScalars is off by default.
	/// </summary>
	public virtual int GetGenerateClipScalars()
	{
		return vtkClipPolyData_GetGenerateClipScalars_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipPolyData_GetGenerateClippedOutput_10(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// GenerateClippedOutput is off by default.
	/// </summary>
	public virtual int GetGenerateClippedOutput()
	{
		return vtkClipPolyData_GetGenerateClippedOutput_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipPolyData_GetInsideOut_11(HandleRef pThis);

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
		return vtkClipPolyData_GetInsideOut_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipPolyData_GetLocator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkClipPolyData_GetLocator_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkClipPolyData_GetMTime_13(HandleRef pThis);

	/// <summary>
	/// Return the mtime also considering the locator and clip function.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkClipPolyData_GetMTime_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClipPolyData_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkClipPolyData_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClipPolyData_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkClipPolyData_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipPolyData_GetOutputPointsPrecision_16(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings. OutputPointsPrecision is DEFAULT_PRECISION
	/// by default.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkClipPolyData_GetOutputPointsPrecision_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClipPolyData_GetValue_17(HandleRef pThis);

	/// <summary>
	/// Set the clipping value of the implicit function (if clipping with
	/// implicit function) or scalar value (if clipping with
	/// scalars). The default value is 0.0.
	/// </summary>
	public virtual double GetValue()
	{
		return vtkClipPolyData_GetValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_InsideOutOff_18(HandleRef pThis);

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
		vtkClipPolyData_InsideOutOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_InsideOutOn_19(HandleRef pThis);

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
		vtkClipPolyData_InsideOutOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipPolyData_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkClipPolyData_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipPolyData_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkClipPolyData_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipPolyData_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkClipPolyData NewInstance()
	{
		vtkClipPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipPolyData_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClipPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipPolyData_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkClipPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkClipPolyData vtkClipPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipPolyData_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkClipPolyData2 = (vtkClipPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkClipPolyData2.Register(null);
			}
		}
		return vtkClipPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_SetClipFunction_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function with which to perform the
	/// clipping. If you do not define an implicit function, then the input
	/// scalar data will be used for clipping.
	/// </summary>
	public virtual void SetClipFunction(vtkImplicitFunction arg0)
	{
		vtkClipPolyData_SetClipFunction_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_SetGenerateClipScalars_26(HandleRef pThis, int _arg);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// GenerateClipScalars is off by default.
	/// </summary>
	public virtual void SetGenerateClipScalars(int _arg)
	{
		vtkClipPolyData_SetGenerateClipScalars_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_SetGenerateClippedOutput_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// GenerateClippedOutput is off by default.
	/// </summary>
	public virtual void SetGenerateClippedOutput(int _arg)
	{
		vtkClipPolyData_SetGenerateClippedOutput_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_SetInsideOut_28(HandleRef pThis, int _arg);

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
		vtkClipPolyData_SetInsideOut_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_SetLocator_29(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a spatial locator for merging points. By default, an
	/// instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkClipPolyData_SetLocator_29(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_SetOutputPointsPrecision_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings. OutputPointsPrecision is DEFAULT_PRECISION
	/// by default.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkClipPolyData_SetOutputPointsPrecision_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipPolyData_SetValue_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the clipping value of the implicit function (if clipping with
	/// implicit function) or scalar value (if clipping with
	/// scalars). The default value is 0.0.
	/// </summary>
	public virtual void SetValue(double _arg)
	{
		vtkClipPolyData_SetValue_31(GetCppThis(), _arg);
	}
}
