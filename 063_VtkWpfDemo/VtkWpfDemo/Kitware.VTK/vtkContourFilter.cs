using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContourFilter
/// </summary>
/// <remarks>
///    generate isosurfaces/isolines from scalar values
///
/// vtkContourFilter is a filter that takes as input any dataset and
/// generates on output isosurfaces and/or isolines. The exact form
/// of the output depends upon the dimensionality of the input data.
/// Data consisting of 3D cells will generate isosurfaces, data
/// consisting of 2D cells will generate isolines, and data with 1D
/// or 0D cells will generate isopoints. Combinations of output type
/// are possible if the input dimension is mixed.
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
/// For unstructured data or structured grids, normals and gradients
/// are not computed. Use vtkPolyDataNormals to compute the surface
/// normals.
///
/// </remarks>
/// <seealso>
///
/// Much faster implementations for isocontouring are available. In
/// particular, vtkFlyingEdges3D and vtkFlyingEdges2D are much faster
/// and if built with the right options, multithreaded, and scale well
/// with additional processors.
///
///
/// vtkFlyingEdges3D vtkFlyingEdges2D vtkDiscreteFlyingEdges3D
/// vtkDiscreteFlyingEdges2D vtkMarchingContourFilter vtkMarchingCubes
/// vtkSliceCubes vtkMarchingSquares vtkImageMarchingCubes
/// </seealso>
public class vtkContourFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContourFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContourFilter()
	{
		MRClassNameKey = "class vtkContourFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with initial range (0,1) and single contour value
	/// of 0.0.
	/// </summary>
	public new static vtkContourFilter New()
	{
		vtkContourFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with initial range (0,1) and single contour value
	/// of 0.0.
	/// </summary>
	public vtkContourFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkContourFilter_ComputeGradientsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is
	/// fairly expensive in both time and storage. Note that if
	/// ComputeNormals is on, gradients will have to be calculated, but
	/// will not be stored in the output dataset.  If the output data
	/// will be processed by filters that modify topology or geometry, it
	/// may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeGradientsOff()
	{
		vtkContourFilter_ComputeGradientsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_ComputeGradientsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is
	/// fairly expensive in both time and storage. Note that if
	/// ComputeNormals is on, gradients will have to be calculated, but
	/// will not be stored in the output dataset.  If the output data
	/// will be processed by filters that modify topology or geometry, it
	/// may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeGradientsOn()
	{
		vtkContourFilter_ComputeGradientsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_ComputeNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// This setting defaults to On for vtkImageData, vtkRectilinearGrid,
	/// vtkStructuredGrid, and vtkUnstructuredGrid inputs, and Off for all others.
	/// This default behavior is to preserve the behavior of an older version of
	/// this filter, which would ignore this setting for certain inputs.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkContourFilter_ComputeNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_ComputeNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// This setting defaults to On for vtkImageData, vtkRectilinearGrid,
	/// vtkStructuredGrid, and vtkUnstructuredGrid inputs, and Off for all others.
	/// This default behavior is to preserve the behavior of an older version of
	/// this filter, which would ignore this setting for certain inputs.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkContourFilter_ComputeNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_ComputeScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkContourFilter_ComputeScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_ComputeScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkContourFilter_ComputeScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_CreateDefaultLocator_07(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is
	/// specified. The locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkContourFilter_CreateDefaultLocator_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_GenerateTrianglesOff_08(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygon
	/// WARNING: if the contour surface is not planar, the output
	/// polygon will not be planar, which might be nice to look at but hard
	/// to compute with downstream.
	/// </summary>
	public virtual void GenerateTrianglesOff()
	{
		vtkContourFilter_GenerateTrianglesOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_GenerateTrianglesOn_09(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygon
	/// WARNING: if the contour surface is not planar, the output
	/// polygon will not be planar, which might be nice to look at but hard
	/// to compute with downstream.
	/// </summary>
	public virtual void GenerateTrianglesOn()
	{
		vtkContourFilter_GenerateTrianglesOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_GenerateValues_10(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkContourFilter_GenerateValues_10(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_GenerateValues_11(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkContourFilter_GenerateValues_11(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourFilter_GetArrayComponent_12(HandleRef pThis);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// Currently this feature only works if the input is a vtkImageData.
	/// </summary>
	public int GetArrayComponent()
	{
		return vtkContourFilter_GetArrayComponent_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourFilter_GetComputeGradients_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is
	/// fairly expensive in both time and storage. Note that if
	/// ComputeNormals is on, gradients will have to be calculated, but
	/// will not be stored in the output dataset.  If the output data
	/// will be processed by filters that modify topology or geometry, it
	/// may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeGradients()
	{
		return vtkContourFilter_GetComputeGradients_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourFilter_GetComputeNormals_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// This setting defaults to On for vtkImageData, vtkRectilinearGrid,
	/// vtkStructuredGrid, and vtkUnstructuredGrid inputs, and Off for all others.
	/// This default behavior is to preserve the behavior of an older version of
	/// this filter, which would ignore this setting for certain inputs.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkContourFilter_GetComputeNormals_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourFilter_GetComputeScalars_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkContourFilter_GetComputeScalars_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourFilter_GetGenerateTriangles_16(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygon
	/// WARNING: if the contour surface is not planar, the output
	/// polygon will not be planar, which might be nice to look at but hard
	/// to compute with downstream.
	/// </summary>
	public virtual int GetGenerateTriangles()
	{
		return vtkContourFilter_GetGenerateTriangles_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourFilter_GetLocator_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkContourFilter_GetLocator_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkContourFilter_GetMTime_18(HandleRef pThis);

	/// <summary>
	/// Modified GetMTime Because we delegate to vtkContourValues
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkContourFilter_GetMTime_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourFilter_GetNumberOfContours_19(HandleRef pThis);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkContourFilter_GetNumberOfContours_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourFilter_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContourFilter_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourFilter_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContourFilter_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourFilter_GetOutputPointsPrecision_22(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public int GetOutputPointsPrecision()
	{
		return vtkContourFilter_GetOutputPointsPrecision_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourFilter_GetScalarTree_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction.
	/// </summary>
	public virtual vtkScalarTree GetScalarTree()
	{
		vtkScalarTree vtkScalarTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourFilter_GetScalarTree_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkContourFilter_GetUseScalarTree_24(HandleRef pThis);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction. By
	/// default, an instance of vtkSpanSpace is created when needed.
	/// </summary>
	public virtual int GetUseScalarTree()
	{
		return vtkContourFilter_GetUseScalarTree_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkContourFilter_GetValue_25(HandleRef pThis, int i);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkContourFilter_GetValue_25(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourFilter_GetValues_26(HandleRef pThis);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkContourFilter_GetValues_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_GetValues_27(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkContourFilter_GetValues_27(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourFilter_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContourFilter_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourFilter_IsTypeOf_29(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContourFilter_IsTypeOf_29(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourFilter_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkContourFilter NewInstance()
	{
		vtkContourFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourFilter_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourFilter_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContourFilter SafeDownCast(vtkObjectBase o)
	{
		vtkContourFilter vtkContourFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourFilter_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourFilter2 = (vtkContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourFilter2.Register(null);
			}
		}
		return vtkContourFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_SetArrayComponent_33(HandleRef pThis, int arg0);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// Currently this feature only works if the input is a vtkImageData.
	/// </summary>
	public void SetArrayComponent(int arg0)
	{
		vtkContourFilter_SetArrayComponent_33(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_SetComputeGradients_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is
	/// fairly expensive in both time and storage. Note that if
	/// ComputeNormals is on, gradients will have to be calculated, but
	/// will not be stored in the output dataset.  If the output data
	/// will be processed by filters that modify topology or geometry, it
	/// may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeGradients(int _arg)
	{
		vtkContourFilter_SetComputeGradients_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_SetComputeNormals_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// This setting defaults to On for vtkImageData, vtkRectilinearGrid,
	/// vtkStructuredGrid, and vtkUnstructuredGrid inputs, and Off for all others.
	/// This default behavior is to preserve the behavior of an older version of
	/// this filter, which would ignore this setting for certain inputs.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkContourFilter_SetComputeNormals_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_SetComputeScalars_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkContourFilter_SetComputeScalars_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_SetGenerateTriangles_37(HandleRef pThis, int _arg);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygon
	/// WARNING: if the contour surface is not planar, the output
	/// polygon will not be planar, which might be nice to look at but hard
	/// to compute with downstream.
	/// </summary>
	public virtual void SetGenerateTriangles(int _arg)
	{
		vtkContourFilter_SetGenerateTriangles_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_SetLocator_38(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkContourFilter_SetLocator_38(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_SetNumberOfContours_39(HandleRef pThis, int number);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkContourFilter_SetNumberOfContours_39(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_SetOutputPointsPrecision_40(HandleRef pThis, int precision);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public void SetOutputPointsPrecision(int precision)
	{
		vtkContourFilter_SetOutputPointsPrecision_40(GetCppThis(), precision);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_SetScalarTree_41(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction.
	/// </summary>
	public virtual void SetScalarTree(vtkScalarTree arg0)
	{
		vtkContourFilter_SetScalarTree_41(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_SetUseScalarTree_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction. By
	/// default, an instance of vtkSpanSpace is created when needed.
	/// </summary>
	public virtual void SetUseScalarTree(int _arg)
	{
		vtkContourFilter_SetUseScalarTree_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_SetValue_43(HandleRef pThis, int i, double value);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkContourFilter_SetValue_43(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_UseScalarTreeOff_44(HandleRef pThis);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction. By
	/// default, an instance of vtkSpanSpace is created when needed.
	/// </summary>
	public virtual void UseScalarTreeOff()
	{
		vtkContourFilter_UseScalarTreeOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourFilter_UseScalarTreeOn_45(HandleRef pThis);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction. By
	/// default, an instance of vtkSpanSpace is created when needed.
	/// </summary>
	public virtual void UseScalarTreeOn()
	{
		vtkContourFilter_UseScalarTreeOn_45(GetCppThis());
	}
}
