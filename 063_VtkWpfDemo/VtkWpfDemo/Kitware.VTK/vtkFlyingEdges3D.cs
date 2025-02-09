using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFlyingEdges3D
/// </summary>
/// <remarks>
///    generate isosurface from 3D image data (volume)
///
/// vtkFlyingEdges3D is a reference implementation of the 3D version of the
/// flying edges algorithm. It is designed to be highly scalable (i.e.,
/// parallelizable) for large data. It implements certain performance
/// optimizations including computational trimming to rapidly eliminate
/// processing of data regions, packed bit representation of case table
/// values, single edge intersection, elimination of point merging, and
/// elimination of any reallocs (due to dynamic data insertion). Note that
/// computational trimming is a method to reduce total computational cost in
/// which partial computational results can be used to eliminate future
/// computations.
///
/// This is a four-pass algorithm. The first pass processes all x-edges and
/// builds x-edge case values (which, when the four x-edges defining a voxel
/// are combined, are equivalent to vertex-based case table except edge-based
/// approaches are separable in support of parallel computing). Next x-voxel
/// rows are processed to gather information from yz-edges (basically to count
/// the number of y-z edge intersections and triangles generated). In the third
/// pass a prefix sum is used to count and allocate memory for the output
/// primitives. Finally in the fourth pass output primitives are generated into
/// pre-allocated arrays. This implementation uses voxel cell axes (a x-y-z
/// triad located at the voxel origin) to ensure that each edge is intersected
/// at most one time. Note that this implementation also reuses the VTK
/// Marching Cubes case table, although the vertex-based MC table is
/// transformed into an edge-based table on object instantiation.
///
/// See the paper "Flying Edges: A High-Performance Scalable Isocontouring
/// Algorithm" by Schroeder, Maynard, Geveci. Proc. of LDAV 2015. Chicago, IL.
///
/// @warning
/// This filter is specialized to 3D volumes. This implementation can produce
/// degenerate triangles (i.e., zero-area triangles).
///
/// @warning
/// If you are interested in extracting segmented regions from a label mask,
/// consider using vtkDiscreteFlyingEdges3D.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkContourFilter vtkFlyingEdges2D vtkSynchronizedTemplates3D
/// vtkMarchingCubes vtkDiscreteFlyingEdges3D vtkContour3DLinearGrid
/// vtkFlyingEdgesPlaneCutter
/// </seealso>
public class vtkFlyingEdges3D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFlyingEdges3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFlyingEdges3D()
	{
		MRClassNameKey = "class vtkFlyingEdges3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFlyingEdges3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFlyingEdges3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdges3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFlyingEdges3D New()
	{
		vtkFlyingEdges3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlyingEdges3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFlyingEdges3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFlyingEdges3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFlyingEdges3D_ComputeGradientsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is fairly
	/// expensive in both time and storage. Note that if ComputeNormals is on,
	/// gradients will have to be calculated, but will not be stored in the
	/// output dataset. If the output data will be processed by filters that
	/// modify topology or geometry, it may be wise to turn Normals and
	/// Gradients off.
	/// </summary>
	public virtual void ComputeGradientsOff()
	{
		vtkFlyingEdges3D_ComputeGradientsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_ComputeGradientsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is fairly
	/// expensive in both time and storage. Note that if ComputeNormals is on,
	/// gradients will have to be calculated, but will not be stored in the
	/// output dataset. If the output data will be processed by filters that
	/// modify topology or geometry, it may be wise to turn Normals and
	/// Gradients off.
	/// </summary>
	public virtual void ComputeGradientsOn()
	{
		vtkFlyingEdges3D_ComputeGradientsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_ComputeNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkFlyingEdges3D_ComputeNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_ComputeNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkFlyingEdges3D_ComputeNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_ComputeScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkFlyingEdges3D_ComputeScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_ComputeScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkFlyingEdges3D_ComputeScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_GenerateValues_07(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkFlyingEdges3D_GenerateValues_07(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_GenerateValues_08(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkFlyingEdges3D_GenerateValues_08(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdges3D_GetArrayComponent_09(HandleRef pThis);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual int GetArrayComponent()
	{
		return vtkFlyingEdges3D_GetArrayComponent_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdges3D_GetComputeGradients_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is fairly
	/// expensive in both time and storage. Note that if ComputeNormals is on,
	/// gradients will have to be calculated, but will not be stored in the
	/// output dataset. If the output data will be processed by filters that
	/// modify topology or geometry, it may be wise to turn Normals and
	/// Gradients off.
	/// </summary>
	public virtual int GetComputeGradients()
	{
		return vtkFlyingEdges3D_GetComputeGradients_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdges3D_GetComputeNormals_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkFlyingEdges3D_GetComputeNormals_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdges3D_GetComputeScalars_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkFlyingEdges3D_GetComputeScalars_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdges3D_GetInterpolateAttributes_13(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate other attribute data. That is, as the
	/// isosurface is generated, interpolate all point attribute data across
	/// the edge. This is independent of scalar interpolation, which is
	/// controlled by the ComputeScalars flag.
	/// </summary>
	public virtual int GetInterpolateAttributes()
	{
		return vtkFlyingEdges3D_GetInterpolateAttributes_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkFlyingEdges3D_GetMTime_14(HandleRef pThis);

	/// <summary>
	/// Because we delegate to vtkContourValues.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkFlyingEdges3D_GetMTime_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFlyingEdges3D_GetNumberOfContours_15(HandleRef pThis);

	/// <summary>
	/// Get the number of contours in the list of contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkFlyingEdges3D_GetNumberOfContours_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFlyingEdges3D_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFlyingEdges3D_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFlyingEdges3D_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFlyingEdges3D_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFlyingEdges3D_GetValue_18(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith contour value.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkFlyingEdges3D_GetValue_18(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdges3D_GetValues_19(HandleRef pThis);

	/// <summary>
	/// Get a pointer to an array of contour values. There will be
	/// GetNumberOfContours() values in the list.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkFlyingEdges3D_GetValues_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_GetValues_20(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with contour values. There will be
	/// GetNumberOfContours() values in the list. Make sure you allocate
	/// enough memory to hold the list.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkFlyingEdges3D_GetValues_20(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_InterpolateAttributesOff_21(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate other attribute data. That is, as the
	/// isosurface is generated, interpolate all point attribute data across
	/// the edge. This is independent of scalar interpolation, which is
	/// controlled by the ComputeScalars flag.
	/// </summary>
	public virtual void InterpolateAttributesOff()
	{
		vtkFlyingEdges3D_InterpolateAttributesOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_InterpolateAttributesOn_22(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate other attribute data. That is, as the
	/// isosurface is generated, interpolate all point attribute data across
	/// the edge. This is independent of scalar interpolation, which is
	/// controlled by the ComputeScalars flag.
	/// </summary>
	public virtual void InterpolateAttributesOn()
	{
		vtkFlyingEdges3D_InterpolateAttributesOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdges3D_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFlyingEdges3D_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdges3D_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFlyingEdges3D_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdges3D_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFlyingEdges3D NewInstance()
	{
		vtkFlyingEdges3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlyingEdges3D_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdges3D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFlyingEdges3D SafeDownCast(vtkObjectBase o)
	{
		vtkFlyingEdges3D vtkFlyingEdges3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlyingEdges3D_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFlyingEdges3D2 = (vtkFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFlyingEdges3D2.Register(null);
			}
		}
		return vtkFlyingEdges3D2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_SetArrayComponent_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual void SetArrayComponent(int _arg)
	{
		vtkFlyingEdges3D_SetArrayComponent_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_SetComputeGradients_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is fairly
	/// expensive in both time and storage. Note that if ComputeNormals is on,
	/// gradients will have to be calculated, but will not be stored in the
	/// output dataset. If the output data will be processed by filters that
	/// modify topology or geometry, it may be wise to turn Normals and
	/// Gradients off.
	/// </summary>
	public virtual void SetComputeGradients(int _arg)
	{
		vtkFlyingEdges3D_SetComputeGradients_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_SetComputeNormals_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkFlyingEdges3D_SetComputeNormals_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_SetComputeScalars_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkFlyingEdges3D_SetComputeScalars_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_SetInterpolateAttributes_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to interpolate other attribute data. That is, as the
	/// isosurface is generated, interpolate all point attribute data across
	/// the edge. This is independent of scalar interpolation, which is
	/// controlled by the ComputeScalars flag.
	/// </summary>
	public virtual void SetInterpolateAttributes(int _arg)
	{
		vtkFlyingEdges3D_SetInterpolateAttributes_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_SetNumberOfContours_33(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of contours to place into the list. You only really
	/// need to use this method to reduce list size. The method SetValue()
	/// will automatically increase list size as needed.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkFlyingEdges3D_SetNumberOfContours_33(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges3D_SetValue_34(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set a particular contour value at contour number i. The index i ranges
	/// between 0&lt;=i&lt;NumberOfContours.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkFlyingEdges3D_SetValue_34(GetCppThis(), i, value);
	}
}
