using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkClipVolume
/// </summary>
/// <remarks>
///    clip volume data with user-specified implicit function or input scalar data
///
/// vtkClipVolume is a filter that clips volume data (i.e., vtkImageData)
/// using either: any subclass of vtkImplicitFunction or the input scalar
/// data. The clipping operation cuts through the cells of the
/// dataset--converting 3D image data into a 3D unstructured grid--returning
/// everything inside of the specified implicit function (or greater than the
/// scalar value). During the clipping the filter will produce pieces of a
/// cell. (Compare this with vtkExtractGeometry or vtkGeometryFilter, which
/// produces entire, uncut cells.) The output of this filter is a 3D
/// unstructured grid (e.g., tetrahedra or other 3D cell types).
///
/// To use this filter, you must decide if you will be clipping with an
/// implicit function, or whether you will be using the input scalar data.  If
/// you want to clip with an implicit function, you must first define and then
/// set the implicit function with the SetClipFunction() method. Otherwise,
/// you must make sure input scalar data is available. You can also specify a
/// scalar value, which is used to decide what is inside and outside of the
/// implicit function. You can also reverse the sense of what inside/outside
/// is by setting the InsideOut instance variable. (The cutting algorithm
/// proceeds by computing an implicit function value or using the input scalar
/// data for each point in the dataset. This is compared to the scalar value
/// to determine inside/outside.)
///
/// This filter can be configured to compute a second output. The
/// second output is the portion of the volume that is clipped away. Set the
/// GenerateClippedData boolean on if you wish to access this output data.
///
/// The filter will produce an unstructured grid of entirely tetrahedra or a
/// mixed grid of tetrahedra and other 3D cell types (e.g., wedges). Control
/// this behavior by setting the Mixed3DCellGeneration. By default the
/// Mixed3DCellGeneration is on and a combination of cell types will be
/// produced. Note that producing mixed cell types is a faster than producing
/// only tetrahedra.
///
/// @warning
/// This filter is designed to function with 3D structured points. Clipping
/// 2D images should be done by converting the image to polygonal data
/// and using vtkClipPolyData,
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunction vtkClipPolyData vtkGeometryFilter vtkExtractGeometry
/// </seealso>
public class vtkClipVolume : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkClipVolume";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkClipVolume()
	{
		MRClassNameKey = "class vtkClipVolume";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipVolume"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkClipVolume(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipVolume_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with user-specified implicit function; InsideOut turned off;
	/// value set to 0.0; and generate clip scalars turned off.
	/// </summary>
	public new static vtkClipVolume New()
	{
		vtkClipVolume result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipVolume_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClipVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with user-specified implicit function; InsideOut turned off;
	/// value set to 0.0; and generate clip scalars turned off.
	/// </summary>
	public vtkClipVolume()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkClipVolume_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkClipVolume_CreateDefaultLocator_01(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified. The
	/// locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkClipVolume_CreateDefaultLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_GenerateClipScalarsOff_02(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual void GenerateClipScalarsOff()
	{
		vtkClipVolume_GenerateClipScalarsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_GenerateClipScalarsOn_03(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual void GenerateClipScalarsOn()
	{
		vtkClipVolume_GenerateClipScalarsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_GenerateClippedOutputOff_04(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the unstructured grid that's been clipped away.
	/// </summary>
	public virtual void GenerateClippedOutputOff()
	{
		vtkClipVolume_GenerateClippedOutputOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_GenerateClippedOutputOn_05(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the unstructured grid that's been clipped away.
	/// </summary>
	public virtual void GenerateClippedOutputOn()
	{
		vtkClipVolume_GenerateClippedOutputOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipVolume_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function with which to perform the clipping. If you
	/// do not define an implicit function, then the input scalar data will be
	/// used for clipping.
	/// </summary>
	public virtual vtkImplicitFunction GetClipFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipVolume_GetClipFunction_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkClipVolume_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the clipped output.
	/// </summary>
	public vtkUnstructuredGrid GetClippedOutput()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipVolume_GetClippedOutput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkClipVolume_GetGenerateClipScalars_08(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual int GetGenerateClipScalars()
	{
		return vtkClipVolume_GetGenerateClipScalars_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipVolume_GetGenerateClippedOutput_09(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the unstructured grid that's been clipped away.
	/// </summary>
	public virtual int GetGenerateClippedOutput()
	{
		return vtkClipVolume_GetGenerateClippedOutput_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipVolume_GetInsideOut_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered inside the
	/// implicit function if its value is greater than the Value ivar. When
	/// InsideOutside is turned on, a vertex is considered inside the implicit
	/// function if its implicit function value is less than or equal to the
	/// Value ivar.  InsideOut is off by default.
	/// </summary>
	public virtual int GetInsideOut()
	{
		return vtkClipVolume_GetInsideOut_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipVolume_GetLocator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / Get a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipVolume_GetLocator_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkClipVolume_GetMTime_12(HandleRef pThis);

	/// <summary>
	/// Return the mtime also considering the locator and clip function.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkClipVolume_GetMTime_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClipVolume_GetMergeTolerance_13(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the corners of voxels. This tolerance is used to prevent the generation
	/// of degenerate tetrahedra.
	/// </summary>
	public virtual double GetMergeTolerance()
	{
		return vtkClipVolume_GetMergeTolerance_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClipVolume_GetMergeToleranceMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the corners of voxels. This tolerance is used to prevent the generation
	/// of degenerate tetrahedra.
	/// </summary>
	public virtual double GetMergeToleranceMaxValue()
	{
		return vtkClipVolume_GetMergeToleranceMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClipVolume_GetMergeToleranceMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the corners of voxels. This tolerance is used to prevent the generation
	/// of degenerate tetrahedra.
	/// </summary>
	public virtual double GetMergeToleranceMinValue()
	{
		return vtkClipVolume_GetMergeToleranceMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipVolume_GetMixed3DCellGeneration_16(HandleRef pThis);

	/// <summary>
	/// Control whether the filter produces a mix of 3D cell types on output, or
	/// whether the output cells are all tetrahedra. By default, a mixed set of
	/// cells (e.g., tetrahedra and wedges) is produced. (Note: mixed type
	/// generation is faster and less overall data is generated.)
	/// </summary>
	public virtual int GetMixed3DCellGeneration()
	{
		return vtkClipVolume_GetMixed3DCellGeneration_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClipVolume_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkClipVolume_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClipVolume_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkClipVolume_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClipVolume_GetValue_19(HandleRef pThis);

	/// <summary>
	/// Set the clipping value of the implicit function (if clipping with
	/// implicit function) or scalar value (if clipping with scalars). The
	/// default value is 0.0.
	/// </summary>
	public virtual double GetValue()
	{
		return vtkClipVolume_GetValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_InsideOutOff_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered inside the
	/// implicit function if its value is greater than the Value ivar. When
	/// InsideOutside is turned on, a vertex is considered inside the implicit
	/// function if its implicit function value is less than or equal to the
	/// Value ivar.  InsideOut is off by default.
	/// </summary>
	public virtual void InsideOutOff()
	{
		vtkClipVolume_InsideOutOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_InsideOutOn_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered inside the
	/// implicit function if its value is greater than the Value ivar. When
	/// InsideOutside is turned on, a vertex is considered inside the implicit
	/// function if its implicit function value is less than or equal to the
	/// Value ivar.  InsideOut is off by default.
	/// </summary>
	public virtual void InsideOutOn()
	{
		vtkClipVolume_InsideOutOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipVolume_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkClipVolume_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipVolume_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkClipVolume_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_Mixed3DCellGenerationOff_24(HandleRef pThis);

	/// <summary>
	/// Control whether the filter produces a mix of 3D cell types on output, or
	/// whether the output cells are all tetrahedra. By default, a mixed set of
	/// cells (e.g., tetrahedra and wedges) is produced. (Note: mixed type
	/// generation is faster and less overall data is generated.)
	/// </summary>
	public virtual void Mixed3DCellGenerationOff()
	{
		vtkClipVolume_Mixed3DCellGenerationOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_Mixed3DCellGenerationOn_25(HandleRef pThis);

	/// <summary>
	/// Control whether the filter produces a mix of 3D cell types on output, or
	/// whether the output cells are all tetrahedra. By default, a mixed set of
	/// cells (e.g., tetrahedra and wedges) is produced. (Note: mixed type
	/// generation is faster and less overall data is generated.)
	/// </summary>
	public virtual void Mixed3DCellGenerationOn()
	{
		vtkClipVolume_Mixed3DCellGenerationOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipVolume_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkClipVolume NewInstance()
	{
		vtkClipVolume result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipVolume_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClipVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipVolume_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkClipVolume SafeDownCast(vtkObjectBase o)
	{
		vtkClipVolume vtkClipVolume2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipVolume_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkClipVolume2 = (vtkClipVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkClipVolume2.Register(null);
			}
		}
		return vtkClipVolume2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_SetClipFunction_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function with which to perform the clipping. If you
	/// do not define an implicit function, then the input scalar data will be
	/// used for clipping.
	/// </summary>
	public virtual void SetClipFunction(vtkImplicitFunction arg0)
	{
		vtkClipVolume_SetClipFunction_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_SetGenerateClipScalars_30(HandleRef pThis, int _arg);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual void SetGenerateClipScalars(int _arg)
	{
		vtkClipVolume_SetGenerateClipScalars_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_SetGenerateClippedOutput_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the unstructured grid that's been clipped away.
	/// </summary>
	public virtual void SetGenerateClippedOutput(int _arg)
	{
		vtkClipVolume_SetGenerateClippedOutput_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_SetInsideOut_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered inside the
	/// implicit function if its value is greater than the Value ivar. When
	/// InsideOutside is turned on, a vertex is considered inside the implicit
	/// function if its implicit function value is less than or equal to the
	/// Value ivar.  InsideOut is off by default.
	/// </summary>
	public virtual void SetInsideOut(int _arg)
	{
		vtkClipVolume_SetInsideOut_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_SetLocator_33(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / Get a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkClipVolume_SetLocator_33(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_SetMergeTolerance_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the corners of voxels. This tolerance is used to prevent the generation
	/// of degenerate tetrahedra.
	/// </summary>
	public virtual void SetMergeTolerance(double _arg)
	{
		vtkClipVolume_SetMergeTolerance_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_SetMixed3DCellGeneration_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether the filter produces a mix of 3D cell types on output, or
	/// whether the output cells are all tetrahedra. By default, a mixed set of
	/// cells (e.g., tetrahedra and wedges) is produced. (Note: mixed type
	/// generation is faster and less overall data is generated.)
	/// </summary>
	public virtual void SetMixed3DCellGeneration(int _arg)
	{
		vtkClipVolume_SetMixed3DCellGeneration_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipVolume_SetValue_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the clipping value of the implicit function (if clipping with
	/// implicit function) or scalar value (if clipping with scalars). The
	/// default value is 0.0.
	/// </summary>
	public virtual void SetValue(double _arg)
	{
		vtkClipVolume_SetValue_36(GetCppThis(), _arg);
	}
}
