using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCutter
/// </summary>
/// <remarks>
///    Cut vtkDataSet with user-specified implicit function
///
/// vtkCutter is a filter to cut through data using any subclass of
/// vtkImplicitFunction. That is, a polygonal surface is created
/// corresponding to the implicit function F(x,y,z) = value(s), where
/// you can specify one or more values used to cut with.
///
/// In VTK, cutting means reducing a cell of dimension N to a cut surface
/// of dimension N-1. For example, a tetrahedron when cut by a plane (i.e.,
/// vtkPlane implicit function) will generate triangles. (In comparison,
/// clipping takes a N dimensional cell and creates N dimension primitives.)
///
/// vtkCutter is generally used to "slice-through" a dataset, generating
/// a surface that can be visualized. It is also possible to use vtkCutter
/// to do a form of volume rendering. vtkCutter does this by generating
/// multiple cut surfaces (usually planes) which are ordered (and rendered)
/// from back-to-front. The surfaces are set translucent to give a
/// volumetric rendering effect.
///
/// Note that data can be cut using either 1) the scalar values associated
/// with the dataset or 2) an implicit function associated with this class.
/// By default, if an implicit function is set it is used to clip the data
/// set, otherwise the dataset scalars are used to perform the clipping.
///
/// Note that this class delegates to vtkPlaneCutter whenever possible since
/// it's specialized for planes and it's faster because it's multithreaded, and in some
/// cases also algorithmically faster.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunction vtkClipPolyData vtkPlaneCutter
/// </seealso>
public class vtkCutter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCutter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCutter()
	{
		MRClassNameKey = "class vtkCutter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCutter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with user-specified implicit function; initial value of 0.0; and
	/// generating cut scalars turned off.
	/// </summary>
	public new static vtkCutter New()
	{
		vtkCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with user-specified implicit function; initial value of 0.0; and
	/// generating cut scalars turned off.
	/// </summary>
	public vtkCutter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCutter_CreateDefaultLocator_01(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified. The
	/// locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkCutter_CreateDefaultLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_GenerateCutScalarsOff_02(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the input scalar
	/// data.
	/// </summary>
	public virtual void GenerateCutScalarsOff()
	{
		vtkCutter_GenerateCutScalarsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_GenerateCutScalarsOn_03(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the input scalar
	/// data.
	/// </summary>
	public virtual void GenerateCutScalarsOn()
	{
		vtkCutter_GenerateCutScalarsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_GenerateTrianglesOff_04(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// WARNING: if the cutting function is not a plane, the output
	/// will be 3D polygons, which might be nice to look at but hard
	/// to compute with downstream.
	/// </summary>
	public virtual void GenerateTrianglesOff()
	{
		vtkCutter_GenerateTrianglesOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_GenerateTrianglesOn_05(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// WARNING: if the cutting function is not a plane, the output
	/// will be 3D polygons, which might be nice to look at but hard
	/// to compute with downstream.
	/// </summary>
	public virtual void GenerateTrianglesOn()
	{
		vtkCutter_GenerateTrianglesOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_GenerateValues_06(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkCutter_GenerateValues_06(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_GenerateValues_07(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkCutter_GenerateValues_07(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_GetCellTypeDimensions_08(IntPtr cellTypeDimensions);

	/// <summary>
	/// Normally I would put this in a different class, but since
	/// This is a temporary fix until we convert this class and contour filter
	/// to generate unstructured grid output instead of poly data, I am leaving it here.
	/// </summary>
	public static void GetCellTypeDimensions(IntPtr cellTypeDimensions)
	{
		vtkCutter_GetCellTypeDimensions_08(cellTypeDimensions);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutter_GetCutFunction_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function to perform the cutting.
	/// </summary>
	public virtual vtkImplicitFunction GetCutFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCutter_GetCutFunction_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCutter_GetGenerateCutScalars_10(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the input scalar
	/// data.
	/// </summary>
	public virtual int GetGenerateCutScalars()
	{
		return vtkCutter_GetGenerateCutScalars_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutter_GetGenerateTriangles_11(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// WARNING: if the cutting function is not a plane, the output
	/// will be 3D polygons, which might be nice to look at but hard
	/// to compute with downstream.
	/// </summary>
	public virtual int GetGenerateTriangles()
	{
		return vtkCutter_GetGenerateTriangles_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutter_GetLocator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCutter_GetLocator_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkCutter_GetMTime_13(HandleRef pThis);

	/// <summary>
	/// Override GetMTime because we delegate to vtkContourValues and refer to
	/// vtkImplicitFunction.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkCutter_GetMTime_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCutter_GetNumberOfContours_14(HandleRef pThis);

	/// <summary>
	/// Get the number of contours in the list of contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkCutter_GetNumberOfContours_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCutter_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCutter_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCutter_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCutter_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutter_GetOutputPointsPrecision_17(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkCutter_GetOutputPointsPrecision_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutter_GetOutputPointsPrecisionMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMaxValue()
	{
		return vtkCutter_GetOutputPointsPrecisionMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutter_GetOutputPointsPrecisionMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMinValue()
	{
		return vtkCutter_GetOutputPointsPrecisionMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutter_GetSortBy_20(HandleRef pThis);

	/// <summary>
	/// Set the sorting order for the generated polydata. There are two
	/// possibilities:
	/// Sort by value = 0 - This is the most efficient sort. For each cell,
	/// all contour values are processed. This is the default.
	/// Sort by cell = 1 - For each contour value, all cells are processed.
	/// This order should be used if the extracted polygons must be rendered
	/// in a back-to-front or front-to-back order. This is very problem
	/// dependent.
	/// For most applications, the default order is fine (and faster).
	///
	/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
	/// Cell data will be scrambled because with
	/// vtkPolyData output, verts and lines have lower cell ids than triangles.
	/// </summary>
	public virtual int GetSortBy()
	{
		return vtkCutter_GetSortBy_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutter_GetSortByAsString_21(HandleRef pThis);

	/// <summary>
	/// Set the sorting order for the generated polydata. There are two
	/// possibilities:
	/// Sort by value = 0 - This is the most efficient sort. For each cell,
	/// all contour values are processed. This is the default.
	/// Sort by cell = 1 - For each contour value, all cells are processed.
	/// This order should be used if the extracted polygons must be rendered
	/// in a back-to-front or front-to-back order. This is very problem
	/// dependent.
	/// For most applications, the default order is fine (and faster).
	///
	/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
	/// Cell data will be scrambled because with
	/// vtkPolyData output, verts and lines have lower cell ids than triangles.
	/// </summary>
	public string GetSortByAsString()
	{
		return Marshal.PtrToStringAnsi(vtkCutter_GetSortByAsString_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutter_GetSortByMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Set the sorting order for the generated polydata. There are two
	/// possibilities:
	/// Sort by value = 0 - This is the most efficient sort. For each cell,
	/// all contour values are processed. This is the default.
	/// Sort by cell = 1 - For each contour value, all cells are processed.
	/// This order should be used if the extracted polygons must be rendered
	/// in a back-to-front or front-to-back order. This is very problem
	/// dependent.
	/// For most applications, the default order is fine (and faster).
	///
	/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
	/// Cell data will be scrambled because with
	/// vtkPolyData output, verts and lines have lower cell ids than triangles.
	/// </summary>
	public virtual int GetSortByMaxValue()
	{
		return vtkCutter_GetSortByMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutter_GetSortByMinValue_23(HandleRef pThis);

	/// <summary>
	/// Set the sorting order for the generated polydata. There are two
	/// possibilities:
	/// Sort by value = 0 - This is the most efficient sort. For each cell,
	/// all contour values are processed. This is the default.
	/// Sort by cell = 1 - For each contour value, all cells are processed.
	/// This order should be used if the extracted polygons must be rendered
	/// in a back-to-front or front-to-back order. This is very problem
	/// dependent.
	/// For most applications, the default order is fine (and faster).
	///
	/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
	/// Cell data will be scrambled because with
	/// vtkPolyData output, verts and lines have lower cell ids than triangles.
	/// </summary>
	public virtual int GetSortByMinValue()
	{
		return vtkCutter_GetSortByMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCutter_GetValue_24(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith contour value.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkCutter_GetValue_24(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutter_GetValues_25(HandleRef pThis);

	/// <summary>
	/// Get a pointer to an array of contour values. There will be
	/// GetNumberOfContours() values in the list.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkCutter_GetValues_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_GetValues_26(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with contour values. There will be
	/// GetNumberOfContours() values in the list. Make sure you allocate
	/// enough memory to hold the list.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkCutter_GetValues_26(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutter_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCutter_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutter_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCutter_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCutter NewInstance()
	{
		vtkCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCutter_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCutter SafeDownCast(vtkObjectBase o)
	{
		vtkCutter vtkCutter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCutter_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCutter2 = (vtkCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCutter2.Register(null);
			}
		}
		return vtkCutter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_SetCutFunction_32(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function to perform the cutting.
	/// </summary>
	public virtual void SetCutFunction(vtkImplicitFunction arg0)
	{
		vtkCutter_SetCutFunction_32(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_SetGenerateCutScalars_33(HandleRef pThis, int _arg);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the input scalar
	/// data.
	/// </summary>
	public virtual void SetGenerateCutScalars(int _arg)
	{
		vtkCutter_SetGenerateCutScalars_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_SetGenerateTriangles_34(HandleRef pThis, int _arg);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// WARNING: if the cutting function is not a plane, the output
	/// will be 3D polygons, which might be nice to look at but hard
	/// to compute with downstream.
	/// </summary>
	public virtual void SetGenerateTriangles(int _arg)
	{
		vtkCutter_SetGenerateTriangles_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_SetLocator_35(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkCutter_SetLocator_35(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_SetNumberOfContours_36(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of contours to place into the list. You only really
	/// need to use this method to reduce list size. The method SetValue()
	/// will automatically increase list size as needed.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkCutter_SetNumberOfContours_36(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_SetOutputPointsPrecision_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkCutter_SetOutputPointsPrecision_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_SetSortBy_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the sorting order for the generated polydata. There are two
	/// possibilities:
	/// Sort by value = 0 - This is the most efficient sort. For each cell,
	/// all contour values are processed. This is the default.
	/// Sort by cell = 1 - For each contour value, all cells are processed.
	/// This order should be used if the extracted polygons must be rendered
	/// in a back-to-front or front-to-back order. This is very problem
	/// dependent.
	/// For most applications, the default order is fine (and faster).
	///
	/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
	/// Cell data will be scrambled because with
	/// vtkPolyData output, verts and lines have lower cell ids than triangles.
	/// </summary>
	public virtual void SetSortBy(int _arg)
	{
		vtkCutter_SetSortBy_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_SetSortByToSortByCell_39(HandleRef pThis);

	/// <summary>
	/// Set the sorting order for the generated polydata. There are two
	/// possibilities:
	/// Sort by value = 0 - This is the most efficient sort. For each cell,
	/// all contour values are processed. This is the default.
	/// Sort by cell = 1 - For each contour value, all cells are processed.
	/// This order should be used if the extracted polygons must be rendered
	/// in a back-to-front or front-to-back order. This is very problem
	/// dependent.
	/// For most applications, the default order is fine (and faster).
	///
	/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
	/// Cell data will be scrambled because with
	/// vtkPolyData output, verts and lines have lower cell ids than triangles.
	/// </summary>
	public void SetSortByToSortByCell()
	{
		vtkCutter_SetSortByToSortByCell_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_SetSortByToSortByValue_40(HandleRef pThis);

	/// <summary>
	/// Set the sorting order for the generated polydata. There are two
	/// possibilities:
	/// Sort by value = 0 - This is the most efficient sort. For each cell,
	/// all contour values are processed. This is the default.
	/// Sort by cell = 1 - For each contour value, all cells are processed.
	/// This order should be used if the extracted polygons must be rendered
	/// in a back-to-front or front-to-back order. This is very problem
	/// dependent.
	/// For most applications, the default order is fine (and faster).
	///
	/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
	/// Cell data will be scrambled because with
	/// vtkPolyData output, verts and lines have lower cell ids than triangles.
	/// </summary>
	public void SetSortByToSortByValue()
	{
		vtkCutter_SetSortByToSortByValue_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutter_SetValue_41(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set a particular contour value at contour number i. The index i ranges
	/// between 0&lt;=i&lt;NumberOfContours.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkCutter_SetValue_41(GetCppThis(), i, value);
	}
}
