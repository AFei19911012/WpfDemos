using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractSurface
/// </summary>
/// <remarks>
///    generate zero-crossing isosurface from
/// truncated signed distance volume
///
///
/// This filter extracts the zero-crossing isosurface from a truncated signed
/// distance function TSDF. The TSDF is sampled across a volume, and is
/// extracted using a modified version of the Flying Edges (FE) algorithm for
/// increased speed, and to support multithreading. To use the filter, an
/// input volume should be assigned, which may have special values indicating
/// empty and/or unseen portions of the volume. These values are equal to +/-
/// radius value of the signed distance function, and should be consistent
/// with any filters used to generate the input volume (e.g.,
/// vtkSignedDistance).
///
/// The Flying Edges algorithm is modified to deal with the nature of the
/// truncated, signed distance function. Being truncated, the distance
/// function typically is not computed throughout the volume, rather the
/// special data values "unseen" and/or "empty" maybe assigned to distant or
/// bordering voxels. The implications of this are that this implementation
/// may produce non-closed, non-manifold surfaces, which is what is required
/// to extract surfaces.
///
/// More specifically, voxels may exist in one of three states: 1) within the
/// TSDF, which extends +/-Radius from a generating geometry (typically a
/// point cloud); 2) in the empty state, in which it is known that the surface
/// does not exist; and 3) the unseen state, where a surface may exist but not
/// enough information is known to be certain. Such situations arise, for
/// example, when laser scanners generate point clouds, and the propagation of
/// the laser beam "carves" out regions where no geometry exists (thereby
/// defining empty space). Furthermore, areas in which the beam are occluded
/// by geometry are known as "unseen" and the boundary between empty and
/// unseen can be processed to produced a portion of the output isosurface
/// (this is called hole filling).
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// @warning
/// Empty regions are expected to have a data value
/// -(this-&gt;Radius+FLT_EPSILON). Unseen regions are expected to have a data
/// value (this-&gt;Radius+FLT_EPSILON). Near regions have data values d such that:
/// -(this-&gt;Radius+FLT_EPSILON) &lt; d (this-&gt;Radius+FLT_EPSILON).
///
/// @warning
/// &lt;pre&gt;
/// Notes on the implementation:
/// 1. This is a lightly modified version of vtkFlyingEdges3D. Some design goals
///    included minimizing the impact on the FE algorithm, and not adding extra
///    memory requirements.
/// 2. It presumes an isocontour value=0.0 (the zero crossing of a signed
///    distance function).
/// 3. The major modifications are to the edge cases. In Flying Edges, a single
///    byte represents the case of an edge, and within that byte only 2 bits
///    are needed (the extra six bytes are not used). Here, these unused bytes
///    are repurposed to represent the "state" of the edge, whether it is
///    1) near to the TSDF; 2) in an empty state; or 3) unseen state.
/// 4. Since these now-used bits encode extra state information, masking and
///    related methods are modified from FE to tease apart the edge cases from
///    the edge state.
/// 5. Voxels with edges marked "empty" are not processed, i.e., no output
///    triangle primitives are generated. Depending on whether hole filling is
///    enabled, voxels with edges marked "unseen" may not be processed either.
/// 6. As a result of #1 and #5, and the desire to keep the implementation simple,
///    it is possible to produce output points which are not used by any output
///    triangle.
///             &lt;/pre&gt;
///
/// @warning
/// This algorithm loosely follows the most excellent paper by Curless and
/// Levoy: "A Volumetric Method for Building Complex Models from Range
/// Images."
///
/// @warning
/// This algorithm differs from the paper cited above in an important way. The
/// Curless &amp; Levoy algorithm is designed to create watertight surfaces, while this
/// modified algorithm may not do so as the generating surface is not assumed to be
/// closed.
///
/// </remarks>
/// <seealso>
///
/// vtkSignedDistance vtkFlyingEdges3D
/// </seealso>
public class vtkExtractSurface : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSurface";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractSurface()
	{
		MRClassNameKey = "class vtkExtractSurface";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSurface"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractSurface(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSurface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static vtkExtractSurface New()
	{
		vtkExtractSurface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSurface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public vtkExtractSurface()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractSurface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSurface_ComputeGradientsOff_01(HandleRef pThis);

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
		vtkExtractSurface_ComputeGradientsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSurface_ComputeGradientsOn_02(HandleRef pThis);

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
		vtkExtractSurface_ComputeGradientsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSurface_ComputeNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkExtractSurface_ComputeNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSurface_ComputeNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkExtractSurface_ComputeNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSurface_GetComputeGradients_05(HandleRef pThis);

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
		return vtkExtractSurface_GetComputeGradients_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSurface_GetComputeNormals_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkExtractSurface_GetComputeNormals_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractSurface_GetHoleFilling_07(HandleRef pThis);

	/// <summary>
	/// Enable hole filling. This generates separating surfaces between the
	/// empty and unseen portions of the volume.
	/// </summary>
	public virtual bool GetHoleFilling()
	{
		return (vtkExtractSurface_GetHoleFilling_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSurface_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractSurface_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSurface_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractSurface_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExtractSurface_GetRadius_10(HandleRef pThis);

	/// <summary>
	/// Specify the radius of influence of the signed distance function. Data
	/// values (which are distances) that are greater than the radius (i.e., d &gt;
	/// Radius) are considered empty voxels; those voxel data values d &lt; -Radius
	/// are considered unseen voxels.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkExtractSurface_GetRadius_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExtractSurface_GetRadiusMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the radius of influence of the signed distance function. Data
	/// values (which are distances) that are greater than the radius (i.e., d &gt;
	/// Radius) are considered empty voxels; those voxel data values d &lt; -Radius
	/// are considered unseen voxels.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkExtractSurface_GetRadiusMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExtractSurface_GetRadiusMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the radius of influence of the signed distance function. Data
	/// values (which are distances) that are greater than the radius (i.e., d &gt;
	/// Radius) are considered empty voxels; those voxel data values d &lt; -Radius
	/// are considered unseen voxels.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkExtractSurface_GetRadiusMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSurface_HoleFillingOff_13(HandleRef pThis);

	/// <summary>
	/// Enable hole filling. This generates separating surfaces between the
	/// empty and unseen portions of the volume.
	/// </summary>
	public virtual void HoleFillingOff()
	{
		vtkExtractSurface_HoleFillingOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSurface_HoleFillingOn_14(HandleRef pThis);

	/// <summary>
	/// Enable hole filling. This generates separating surfaces between the
	/// empty and unseen portions of the volume.
	/// </summary>
	public virtual void HoleFillingOn()
	{
		vtkExtractSurface_HoleFillingOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSurface_IsA_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractSurface_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSurface_IsTypeOf_16(string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractSurface_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSurface_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new vtkExtractSurface NewInstance()
	{
		vtkExtractSurface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSurface_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSurface_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static vtkExtractSurface SafeDownCast(vtkObjectBase o)
	{
		vtkExtractSurface vtkExtractSurface2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSurface_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractSurface2 = (vtkExtractSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractSurface2.Register(null);
			}
		}
		return vtkExtractSurface2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSurface_SetComputeGradients_20(HandleRef pThis, int _arg);

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
		vtkExtractSurface_SetComputeGradients_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSurface_SetComputeNormals_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be processed
	/// by filters that modify topology or geometry, it may be wise to turn
	/// Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkExtractSurface_SetComputeNormals_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSurface_SetHoleFilling_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable hole filling. This generates separating surfaces between the
	/// empty and unseen portions of the volume.
	/// </summary>
	public virtual void SetHoleFilling(bool _arg)
	{
		vtkExtractSurface_SetHoleFilling_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSurface_SetRadius_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the radius of influence of the signed distance function. Data
	/// values (which are distances) that are greater than the radius (i.e., d &gt;
	/// Radius) are considered empty voxels; those voxel data values d &lt; -Radius
	/// are considered unseen voxels.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkExtractSurface_SetRadius_23(GetCppThis(), _arg);
	}
}
