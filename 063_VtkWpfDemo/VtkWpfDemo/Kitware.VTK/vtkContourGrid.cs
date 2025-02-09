using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContourGrid
/// </summary>
/// <remarks>
///    generate isosurfaces/isolines from scalar values (specialized for unstructured grids)
///
/// vtkContourGrid is a filter that takes as input datasets of type
/// vtkUnstructuredGrid and generates on output isosurfaces and/or
/// isolines. The exact form of the output depends upon the dimensionality of
/// the input data.  Data consisting of 3D cells will generate isosurfaces,
/// data consisting of 2D cells will generate isolines, and data with 1D or 0D
/// cells will generate isopoints. Combinations of output type are possible if
/// the input dimension is mixed.
///
/// To use this filter you must specify one or more contour values.
/// You can either use the method SetValue() to specify each contour
/// value, or use GenerateValues() to generate a series of evenly
/// spaced contours. It is also possible to accelerate the operation of
/// this filter (at the cost of extra memory) by using a
/// vtkScalarTree. A scalar tree is used to quickly locate cells that
/// contain a contour surface. This is especially effective if multiple
/// contours are being extracted. If you want to use a scalar tree,
/// invoke the method UseScalarTreeOn().
///
/// @warning
/// If the input vtkUnstructuredGrid contains 3D linear cells, the class
/// vtkContour3DLinearGrid is much faster and may be preferred in certain
/// applications.
///
/// @warning
/// For unstructured data or structured grids, normals and gradients
/// are not computed. Use vtkPolyDataNormals to compute the surface
/// normals of the resulting isosurface.
///
/// </remarks>
/// <seealso>
///
/// vtkContour3DLinearGrid vtkContourFilter vtkMarchingContourFilter
/// vtkFlyingEdges3D vtkMarchingCubes vtkSliceCubes vtkDividingCubes
/// vtkMarchingSquares vtkImageMarchingCubes
/// </seealso>
public class vtkContourGrid : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContourGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContourGrid()
	{
		MRClassNameKey = "class vtkContourGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContourGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with initial range (0,1) and single contour value
	/// of 0.0.
	/// </summary>
	public new static vtkContourGrid New()
	{
		vtkContourGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with initial range (0,1) and single contour value
	/// of 0.0.
	/// </summary>
	public vtkContourGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContourGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkContourGrid_ComputeNormalsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkContourGrid_ComputeNormalsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_ComputeNormalsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkContourGrid_ComputeNormalsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_ComputeScalarsOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkContourGrid_ComputeScalarsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_ComputeScalarsOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkContourGrid_ComputeScalarsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_CreateDefaultLocator_05(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is
	/// specified. The locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkContourGrid_CreateDefaultLocator_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_GenerateTrianglesOff_06(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles otherwise,
	/// the output may be represented by one or more polygons. WARNING: if the
	/// resulting isocontour is not planar, and GenerateTriangles is false, the
	/// output may consist of some 3D polygons (i.e., which may be non-planar) -
	/// which might be nice to look at but hard to compute with downstream.
	/// </summary>
	public virtual void GenerateTrianglesOff()
	{
		vtkContourGrid_GenerateTrianglesOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_GenerateTrianglesOn_07(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles otherwise,
	/// the output may be represented by one or more polygons. WARNING: if the
	/// resulting isocontour is not planar, and GenerateTriangles is false, the
	/// output may consist of some 3D polygons (i.e., which may be non-planar) -
	/// which might be nice to look at but hard to compute with downstream.
	/// </summary>
	public virtual void GenerateTrianglesOn()
	{
		vtkContourGrid_GenerateTrianglesOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkContourGrid_GenerateValues_08(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkContourGrid_GenerateValues_09(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourGrid_GetComputeNormals_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkContourGrid_GetComputeNormals_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourGrid_GetComputeScalars_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkContourGrid_GetComputeScalars_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourGrid_GetGenerateTriangles_12(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles otherwise,
	/// the output may be represented by one or more polygons. WARNING: if the
	/// resulting isocontour is not planar, and GenerateTriangles is false, the
	/// output may consist of some 3D polygons (i.e., which may be non-planar) -
	/// which might be nice to look at but hard to compute with downstream.
	/// </summary>
	public virtual int GetGenerateTriangles()
	{
		return vtkContourGrid_GetGenerateTriangles_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourGrid_GetLocator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourGrid_GetLocator_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkContourGrid_GetMTime_14(HandleRef pThis);

	/// <summary>
	/// Modified GetMTime Because we delegate to vtkContourValues
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkContourGrid_GetMTime_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourGrid_GetNumberOfContours_15(HandleRef pThis);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkContourGrid_GetNumberOfContours_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourGrid_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContourGrid_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourGrid_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContourGrid_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourGrid_GetOutputPointsPrecision_18(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public int GetOutputPointsPrecision()
	{
		return vtkContourGrid_GetOutputPointsPrecision_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourGrid_GetScalarTree_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the instance of vtkScalarTree to use. If not specified
	/// and UseScalarTree is enabled, then a vtkSimpleScalarTree will be used.
	/// </summary>
	public virtual vtkScalarTree GetScalarTree()
	{
		vtkScalarTree vtkScalarTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourGrid_GetScalarTree_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarTree2 = (vtkScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarTree2.Register(null);
			}
		}
		return vtkScalarTree2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourGrid_GetUseScalarTree_20(HandleRef pThis);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction.
	/// </summary>
	public virtual int GetUseScalarTree()
	{
		return vtkContourGrid_GetUseScalarTree_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkContourGrid_GetValue_21(HandleRef pThis, int i);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkContourGrid_GetValue_21(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourGrid_GetValues_22(HandleRef pThis);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkContourGrid_GetValues_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_GetValues_23(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkContourGrid_GetValues_23(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourGrid_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContourGrid_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourGrid_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContourGrid_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourGrid_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkContourGrid NewInstance()
	{
		vtkContourGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourGrid_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourGrid_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContourGrid SafeDownCast(vtkObjectBase o)
	{
		vtkContourGrid vtkContourGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourGrid_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourGrid2 = (vtkContourGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourGrid2.Register(null);
			}
		}
		return vtkContourGrid2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_SetComputeNormals_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkContourGrid_SetComputeNormals_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_SetComputeScalars_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkContourGrid_SetComputeScalars_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_SetGenerateTriangles_31(HandleRef pThis, int _arg);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles otherwise,
	/// the output may be represented by one or more polygons. WARNING: if the
	/// resulting isocontour is not planar, and GenerateTriangles is false, the
	/// output may consist of some 3D polygons (i.e., which may be non-planar) -
	/// which might be nice to look at but hard to compute with downstream.
	/// </summary>
	public virtual void SetGenerateTriangles(int _arg)
	{
		vtkContourGrid_SetGenerateTriangles_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_SetLocator_32(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkContourGrid_SetLocator_32(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_SetNumberOfContours_33(HandleRef pThis, int number);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkContourGrid_SetNumberOfContours_33(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_SetOutputPointsPrecision_34(HandleRef pThis, int precision);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public void SetOutputPointsPrecision(int precision)
	{
		vtkContourGrid_SetOutputPointsPrecision_34(GetCppThis(), precision);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_SetScalarTree_35(HandleRef pThis, HandleRef sTree);

	/// <summary>
	/// Specify the instance of vtkScalarTree to use. If not specified
	/// and UseScalarTree is enabled, then a vtkSimpleScalarTree will be used.
	/// </summary>
	public void SetScalarTree(vtkScalarTree sTree)
	{
		vtkContourGrid_SetScalarTree_35(GetCppThis(), sTree?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_SetUseScalarTree_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction.
	/// </summary>
	public virtual void SetUseScalarTree(int _arg)
	{
		vtkContourGrid_SetUseScalarTree_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_SetValue_37(HandleRef pThis, int i, double value);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkContourGrid_SetValue_37(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_UseScalarTreeOff_38(HandleRef pThis);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction.
	/// </summary>
	public virtual void UseScalarTreeOff()
	{
		vtkContourGrid_UseScalarTreeOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourGrid_UseScalarTreeOn_39(HandleRef pThis);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction.
	/// </summary>
	public virtual void UseScalarTreeOn()
	{
		vtkContourGrid_UseScalarTreeOn_39(GetCppThis());
	}
}
