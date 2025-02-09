using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDiscreteFlyingEdges3D
/// </summary>
/// <remarks>
///    generate isosurface from 3D image data (volume)
///
/// vtkDiscreteFlyingEdges3D creates output representations of label maps
/// (e.g., segmented volumes) using a variation of the flying edges
/// algorithm. The input is a 3D image (volume( where each point is labeled
/// (integer labels are preferred to real values), and the output data is
/// polygonal data representing labeled regions. (Note that on output each
/// region [corresponding to a different contour value] is represented
/// independently; i.e., points are not shared between regions even if they
/// are coincident.)
///
/// This filter is similar to but produces different results than the filter
/// vtkDiscreteMarchingCubes. This filter can produce output normals, and each
/// labeled region is completely disconnected from neighboring regions
/// (coincident points are not merged). Both algorithms interpolate edges at
/// the halfway point between vertices with different segmentation labels.
///
/// See the paper "Flying Edges: A High-Performance Scalable Isocontouring
/// Algorithm" by Schroeder, Maynard, Geveci. Proc. of LDAV 2015. Chicago, IL.
///
/// @warning
/// This filter is specialized to 3D volumes. This implementation can produce
/// degenerate triangles (i.e., zero-area triangles).
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkDiscreteMarchingCubes vtkDiscreteFlyingEdges2D vtkDiscreteFlyingEdges3D
/// </seealso>
public class vtkDiscreteFlyingEdges3D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDiscreteFlyingEdges3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDiscreteFlyingEdges3D()
	{
		MRClassNameKey = "class vtkDiscreteFlyingEdges3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscreteFlyingEdges3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDiscreteFlyingEdges3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdges3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDiscreteFlyingEdges3D New()
	{
		vtkDiscreteFlyingEdges3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteFlyingEdges3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiscreteFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDiscreteFlyingEdges3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDiscreteFlyingEdges3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDiscreteFlyingEdges3D_ComputeGradientsOff_01(HandleRef pThis);

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
		vtkDiscreteFlyingEdges3D_ComputeGradientsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_ComputeGradientsOn_02(HandleRef pThis);

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
		vtkDiscreteFlyingEdges3D_ComputeGradientsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_ComputeNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkDiscreteFlyingEdges3D_ComputeNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_ComputeNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkDiscreteFlyingEdges3D_ComputeNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_ComputeScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkDiscreteFlyingEdges3D_ComputeScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_ComputeScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkDiscreteFlyingEdges3D_ComputeScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_GenerateValues_07(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkDiscreteFlyingEdges3D_GenerateValues_07(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_GenerateValues_08(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkDiscreteFlyingEdges3D_GenerateValues_08(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdges3D_GetArrayComponent_09(HandleRef pThis);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual int GetArrayComponent()
	{
		return vtkDiscreteFlyingEdges3D_GetArrayComponent_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdges3D_GetComputeGradients_10(HandleRef pThis);

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
		return vtkDiscreteFlyingEdges3D_GetComputeGradients_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdges3D_GetComputeNormals_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkDiscreteFlyingEdges3D_GetComputeNormals_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdges3D_GetComputeScalars_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkDiscreteFlyingEdges3D_GetComputeScalars_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdges3D_GetInterpolateAttributes_13(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate other attribute data. That is, as the
	/// isosurface is generated, interpolate all point attribute data across
	/// the edge. This is independent of scalar interpolation, which is
	/// controlled by the ComputeScalars flag.
	/// </summary>
	public virtual int GetInterpolateAttributes()
	{
		return vtkDiscreteFlyingEdges3D_GetInterpolateAttributes_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDiscreteFlyingEdges3D_GetMTime_14(HandleRef pThis);

	/// <summary>
	/// Because we delegate to vtkContourValues.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkDiscreteFlyingEdges3D_GetMTime_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscreteFlyingEdges3D_GetNumberOfContours_15(HandleRef pThis);

	/// <summary>
	/// Get the number of contours in the list of contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkDiscreteFlyingEdges3D_GetNumberOfContours_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscreteFlyingEdges3D_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDiscreteFlyingEdges3D_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscreteFlyingEdges3D_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDiscreteFlyingEdges3D_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiscreteFlyingEdges3D_GetValue_18(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith contour value.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkDiscreteFlyingEdges3D_GetValue_18(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdges3D_GetValues_19(HandleRef pThis);

	/// <summary>
	/// Get a pointer to an array of contour values. There will be
	/// GetNumberOfContours() values in the list.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkDiscreteFlyingEdges3D_GetValues_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_GetValues_20(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with contour values. There will be
	/// GetNumberOfContours() values in the list. Make sure you allocate
	/// enough memory to hold the list.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkDiscreteFlyingEdges3D_GetValues_20(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_InterpolateAttributesOff_21(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate other attribute data. That is, as the
	/// isosurface is generated, interpolate all point attribute data across
	/// the edge. This is independent of scalar interpolation, which is
	/// controlled by the ComputeScalars flag.
	/// </summary>
	public virtual void InterpolateAttributesOff()
	{
		vtkDiscreteFlyingEdges3D_InterpolateAttributesOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_InterpolateAttributesOn_22(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate other attribute data. That is, as the
	/// isosurface is generated, interpolate all point attribute data across
	/// the edge. This is independent of scalar interpolation, which is
	/// controlled by the ComputeScalars flag.
	/// </summary>
	public virtual void InterpolateAttributesOn()
	{
		vtkDiscreteFlyingEdges3D_InterpolateAttributesOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdges3D_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDiscreteFlyingEdges3D_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdges3D_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDiscreteFlyingEdges3D_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdges3D_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDiscreteFlyingEdges3D NewInstance()
	{
		vtkDiscreteFlyingEdges3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteFlyingEdges3D_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiscreteFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdges3D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDiscreteFlyingEdges3D SafeDownCast(vtkObjectBase o)
	{
		vtkDiscreteFlyingEdges3D vtkDiscreteFlyingEdges3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteFlyingEdges3D_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDiscreteFlyingEdges3D2 = (vtkDiscreteFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDiscreteFlyingEdges3D2.Register(null);
			}
		}
		return vtkDiscreteFlyingEdges3D2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_SetArrayComponent_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual void SetArrayComponent(int _arg)
	{
		vtkDiscreteFlyingEdges3D_SetArrayComponent_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_SetComputeGradients_29(HandleRef pThis, int _arg);

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
		vtkDiscreteFlyingEdges3D_SetComputeGradients_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_SetComputeNormals_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkDiscreteFlyingEdges3D_SetComputeNormals_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_SetComputeScalars_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkDiscreteFlyingEdges3D_SetComputeScalars_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_SetInterpolateAttributes_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to interpolate other attribute data. That is, as the
	/// isosurface is generated, interpolate all point attribute data across
	/// the edge. This is independent of scalar interpolation, which is
	/// controlled by the ComputeScalars flag.
	/// </summary>
	public virtual void SetInterpolateAttributes(int _arg)
	{
		vtkDiscreteFlyingEdges3D_SetInterpolateAttributes_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_SetNumberOfContours_33(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of contours to place into the list. You only really
	/// need to use this method to reduce list size. The method SetValue()
	/// will automatically increase list size as needed.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkDiscreteFlyingEdges3D_SetNumberOfContours_33(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges3D_SetValue_34(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set a particular contour value at contour number i. The index i ranges
	/// between 0&lt;=i&lt;NumberOfContours.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkDiscreteFlyingEdges3D_SetValue_34(GetCppThis(), i, value);
	}
}
