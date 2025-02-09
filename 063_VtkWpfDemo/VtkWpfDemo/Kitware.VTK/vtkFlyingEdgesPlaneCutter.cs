using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFlyingEdgesPlaneCutter
/// </summary>
/// <remarks>
///    cut a volume with a plane and generate a
/// polygonal cut surface
///
/// vtkFlyingEdgesPlaneCutter is a specialization of the FlyingEdges algorithm
/// to cut a volume with a single plane. It is designed for performance and
/// an exploratory, fast workflow. The filter handles oriented volumes.
///
/// This algorithm is not only fast because it uses flying edges, but also
/// because it plays some "tricks" during processing. For example, rather
/// than evaluate the cut (plane) function on all volume points like vtkCutter
/// and its ilk do, this algorithm intersects the volume x-edges against the
/// plane to (potentially) generate the single intersection point. It then
/// quickly classifies the voxel edges as above, below, or straddling the cut
/// plane. Thus the number of plane evaluations is greatly reduced.
///
/// For more information see vtkFlyingEdges3D and/or the paper "Flying Edges:
/// A High-Performance Scalable Isocontouring Algorithm" by Schroeder,
/// Maynard, Geveci. Proc. of LDAV 2015. Chicago, IL.
///
/// The filter interpolates the input scalar field across the vtkPlane provided.
/// If additional point and cell attribute data is to be interpolated, enable
/// InterpolateAttributes.
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
/// vtkFlyingEdges2D vtkFlyingEdges3D
/// </seealso>
public class vtkFlyingEdgesPlaneCutter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFlyingEdgesPlaneCutter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFlyingEdgesPlaneCutter()
	{
		MRClassNameKey = "class vtkFlyingEdgesPlaneCutter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFlyingEdgesPlaneCutter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFlyingEdgesPlaneCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdgesPlaneCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static vtkFlyingEdgesPlaneCutter New()
	{
		vtkFlyingEdgesPlaneCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlyingEdgesPlaneCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFlyingEdgesPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public vtkFlyingEdgesPlaneCutter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFlyingEdgesPlaneCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFlyingEdgesPlaneCutter_ComputeNormalsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. By default this is disabled.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkFlyingEdgesPlaneCutter_ComputeNormalsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdgesPlaneCutter_ComputeNormalsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. By default this is disabled.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkFlyingEdgesPlaneCutter_ComputeNormalsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdgesPlaneCutter_GetArrayComponent_03(HandleRef pThis);

	/// <summary>
	/// Set/get which component of the point data scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual int GetArrayComponent()
	{
		return vtkFlyingEdgesPlaneCutter_GetArrayComponent_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdgesPlaneCutter_GetComputeNormals_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. By default this is disabled.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkFlyingEdgesPlaneCutter_GetComputeNormals_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdgesPlaneCutter_GetInterpolateAttributes_05(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate additional point data (beyond the point
	/// scalars which are always interpolated) and cell attribute data. By
	/// default this is disabled (for reasons of performance).
	/// </summary>
	public virtual int GetInterpolateAttributes()
	{
		return vtkFlyingEdgesPlaneCutter_GetInterpolateAttributes_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkFlyingEdgesPlaneCutter_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// The modified time depends on the delegated cut plane.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkFlyingEdgesPlaneCutter_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFlyingEdgesPlaneCutter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFlyingEdgesPlaneCutter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFlyingEdgesPlaneCutter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFlyingEdgesPlaneCutter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdgesPlaneCutter_GetPlane_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the plane (an implicit function) to perform the cutting. The
	/// definition of the plane (its origin and normal) is controlled via this
	/// instance of vtkPlane.
	/// </summary>
	public virtual vtkPlane GetPlane()
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlyingEdgesPlaneCutter_GetPlane_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlane2 = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlane2.Register(null);
			}
		}
		return vtkPlane2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdgesPlaneCutter_InterpolateAttributesOff_10(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate additional point data (beyond the point
	/// scalars which are always interpolated) and cell attribute data. By
	/// default this is disabled (for reasons of performance).
	/// </summary>
	public virtual void InterpolateAttributesOff()
	{
		vtkFlyingEdgesPlaneCutter_InterpolateAttributesOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdgesPlaneCutter_InterpolateAttributesOn_11(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate additional point data (beyond the point
	/// scalars which are always interpolated) and cell attribute data. By
	/// default this is disabled (for reasons of performance).
	/// </summary>
	public virtual void InterpolateAttributesOn()
	{
		vtkFlyingEdgesPlaneCutter_InterpolateAttributesOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdgesPlaneCutter_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFlyingEdgesPlaneCutter_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdgesPlaneCutter_IsTypeOf_13(string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFlyingEdgesPlaneCutter_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdgesPlaneCutter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new vtkFlyingEdgesPlaneCutter NewInstance()
	{
		vtkFlyingEdgesPlaneCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlyingEdgesPlaneCutter_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFlyingEdgesPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdgesPlaneCutter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static vtkFlyingEdgesPlaneCutter SafeDownCast(vtkObjectBase o)
	{
		vtkFlyingEdgesPlaneCutter vtkFlyingEdgesPlaneCutter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlyingEdgesPlaneCutter_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFlyingEdgesPlaneCutter2 = (vtkFlyingEdgesPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFlyingEdgesPlaneCutter2.Register(null);
			}
		}
		return vtkFlyingEdgesPlaneCutter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdgesPlaneCutter_SetArrayComponent_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get which component of the point data scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual void SetArrayComponent(int _arg)
	{
		vtkFlyingEdgesPlaneCutter_SetArrayComponent_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdgesPlaneCutter_SetComputeNormals_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. By default this is disabled.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkFlyingEdgesPlaneCutter_SetComputeNormals_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdgesPlaneCutter_SetInterpolateAttributes_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to interpolate additional point data (beyond the point
	/// scalars which are always interpolated) and cell attribute data. By
	/// default this is disabled (for reasons of performance).
	/// </summary>
	public virtual void SetInterpolateAttributes(int _arg)
	{
		vtkFlyingEdgesPlaneCutter_SetInterpolateAttributes_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdgesPlaneCutter_SetPlane_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the plane (an implicit function) to perform the cutting. The
	/// definition of the plane (its origin and normal) is controlled via this
	/// instance of vtkPlane.
	/// </summary>
	public virtual void SetPlane(vtkPlane arg0)
	{
		vtkFlyingEdgesPlaneCutter_SetPlane_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
