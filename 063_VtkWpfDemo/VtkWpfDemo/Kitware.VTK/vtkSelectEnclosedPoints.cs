using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSelectEnclosedPoints
/// </summary>
/// <remarks>
///    mark points as to whether they are inside a closed surface
///
/// vtkSelectEnclosedPoints is a filter that evaluates all the input points to
/// determine whether they are in an enclosed surface. The filter produces a
/// (0,1) mask (in the form of a vtkDataArray) that indicates whether points
/// are outside (mask value=0) or inside (mask value=1) a provided surface.
/// (The name of the output vtkDataArray is "SelectedPoints".)
///
/// After running the filter, it is possible to query it as to whether a point
/// is inside/outside by invoking the IsInside(ptId) method.
///
/// @warning
/// The filter assumes that the surface is closed and manifold. A boolean flag
/// can be set to force the filter to first check whether this is true. If false,
/// all points will be marked outside. Note that if this check is not performed
/// and the surface is not closed, the results are undefined.
///
/// @warning
/// This filter produces and output data array, but does not modify the input
/// dataset. If you wish to extract cells or points, various threshold filters
/// are available (i.e., threshold the output array). Also, see the filter
/// vtkExtractEnclosedPoints which operates on point clouds.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkMaskPoints vtkExtractEnclosedPoints
/// </seealso>
public class vtkSelectEnclosedPoints : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSelectEnclosedPoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSelectEnclosedPoints()
	{
		MRClassNameKey = "class vtkSelectEnclosedPoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectEnclosedPoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSelectEnclosedPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectEnclosedPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkSelectEnclosedPoints New()
	{
		vtkSelectEnclosedPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectEnclosedPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelectEnclosedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkSelectEnclosedPoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSelectEnclosedPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectEnclosedPoints_CheckSurfaceOff_01(HandleRef pThis);

	/// <summary>
	/// Specify whether to check the surface for closure. If on, then the
	/// algorithm first checks to see if the surface is closed and manifold.
	/// </summary>
	public virtual void CheckSurfaceOff()
	{
		vtkSelectEnclosedPoints_CheckSurfaceOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectEnclosedPoints_CheckSurfaceOn_02(HandleRef pThis);

	/// <summary>
	/// Specify whether to check the surface for closure. If on, then the
	/// algorithm first checks to see if the surface is closed and manifold.
	/// </summary>
	public virtual void CheckSurfaceOn()
	{
		vtkSelectEnclosedPoints_CheckSurfaceOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectEnclosedPoints_Complete_03(HandleRef pThis);

	/// <summary>
	/// This is a backdoor that can be used to test many points for containment.
	/// First initialize the instance, then repeated calls to IsInsideSurface()
	/// can be used without rebuilding the search structures. The Complete()
	/// method releases memory.
	/// </summary>
	public void Complete()
	{
		vtkSelectEnclosedPoints_Complete_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectEnclosedPoints_GetCheckSurface_04(HandleRef pThis);

	/// <summary>
	/// Specify whether to check the surface for closure. If on, then the
	/// algorithm first checks to see if the surface is closed and manifold.
	/// </summary>
	public virtual int GetCheckSurface()
	{
		return vtkSelectEnclosedPoints_GetCheckSurface_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectEnclosedPoints_GetInsideOut_05(HandleRef pThis);

	/// <summary>
	/// By default, points inside the surface are marked inside or sent to
	/// the output. If InsideOut is on, then the points outside the surface
	/// are marked inside.
	/// </summary>
	public virtual int GetInsideOut()
	{
		return vtkSelectEnclosedPoints_GetInsideOut_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelectEnclosedPoints_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSelectEnclosedPoints_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelectEnclosedPoints_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSelectEnclosedPoints_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectEnclosedPoints_GetSurface_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a pointer to the enclosing surface.
	/// </summary>
	public vtkPolyData GetSurface()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectEnclosedPoints_GetSurface_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectEnclosedPoints_GetSurface_09(HandleRef pThis, HandleRef sourceInfo, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a pointer to the enclosing surface.
	/// </summary>
	public vtkPolyData GetSurface(vtkInformationVector sourceInfo)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectEnclosedPoints_GetSurface_09(GetCppThis(), sourceInfo?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSelectEnclosedPoints_GetTolerance_10(HandleRef pThis);

	/// <summary>
	/// Specify the tolerance on the intersection. The tolerance is expressed as
	/// a fraction of the diagonal of the bounding box of the enclosing surface.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkSelectEnclosedPoints_GetTolerance_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSelectEnclosedPoints_GetToleranceMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the tolerance on the intersection. The tolerance is expressed as
	/// a fraction of the diagonal of the bounding box of the enclosing surface.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkSelectEnclosedPoints_GetToleranceMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSelectEnclosedPoints_GetToleranceMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the tolerance on the intersection. The tolerance is expressed as
	/// a fraction of the diagonal of the bounding box of the enclosing surface.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkSelectEnclosedPoints_GetToleranceMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectEnclosedPoints_Initialize_13(HandleRef pThis, HandleRef surface);

	/// <summary>
	/// This is a backdoor that can be used to test many points for containment.
	/// First initialize the instance, then repeated calls to IsInsideSurface()
	/// can be used without rebuilding the search structures. The Complete()
	/// method releases memory.
	/// </summary>
	public void Initialize(vtkPolyData surface)
	{
		vtkSelectEnclosedPoints_Initialize_13(GetCppThis(), surface?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectEnclosedPoints_InsideOutOff_14(HandleRef pThis);

	/// <summary>
	/// By default, points inside the surface are marked inside or sent to
	/// the output. If InsideOut is on, then the points outside the surface
	/// are marked inside.
	/// </summary>
	public virtual void InsideOutOff()
	{
		vtkSelectEnclosedPoints_InsideOutOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectEnclosedPoints_InsideOutOn_15(HandleRef pThis);

	/// <summary>
	/// By default, points inside the surface are marked inside or sent to
	/// the output. If InsideOut is on, then the points outside the surface
	/// are marked inside.
	/// </summary>
	public virtual void InsideOutOn()
	{
		vtkSelectEnclosedPoints_InsideOutOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectEnclosedPoints_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSelectEnclosedPoints_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectEnclosedPoints_IsInside_17(HandleRef pThis, long inputPtId);

	/// <summary>
	/// Query an input point id as to whether it is inside or outside. Note that
	/// the result requires that the filter execute first.
	/// </summary>
	public int IsInside(long inputPtId)
	{
		return vtkSelectEnclosedPoints_IsInside_17(GetCppThis(), inputPtId);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectEnclosedPoints_IsInsideSurface_18(HandleRef pThis, IntPtr x);

	/// <summary>
	/// This is a backdoor that can be used to test many points for containment.
	/// First initialize the instance, then repeated calls to IsInsideSurface()
	/// can be used without rebuilding the search structures. The Complete()
	/// method releases memory.
	/// </summary>
	public int IsInsideSurface(IntPtr x)
	{
		return vtkSelectEnclosedPoints_IsInsideSurface_18(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectEnclosedPoints_IsInsideSurface_19(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// This is a backdoor that can be used to test many points for containment.
	/// First initialize the instance, then repeated calls to IsInsideSurface()
	/// can be used without rebuilding the search structures. The Complete()
	/// method releases memory.
	/// </summary>
	public int IsInsideSurface(double x, double y, double z)
	{
		return vtkSelectEnclosedPoints_IsInsideSurface_19(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectEnclosedPoints_IsInsideSurface_20(IntPtr x, HandleRef surface, IntPtr bds, double length, double tol, HandleRef locator, HandleRef cellIds, HandleRef genCell, vtkIntersectionCounter counter, HandleRef poole, long seqIdx);

	/// <summary>
	/// A static method for determining whether a point is inside a
	/// surface. This is the heart of the algorithm and is thread safe. The user
	/// must provide an input point x, the enclosing surface, the bounds of the
	/// enclosing surface, the diagonal length of the enclosing surface, an
	/// intersection tolerance, a cell locator for the surface, and two working
	/// objects (cellIds, genCell) to support computation. Finally, in threaded
	/// execution, generating random numbers is hard, so a precomputed random
	/// sequence can be provided with an index into the sequence.
	/// </summary>
	public static int IsInsideSurface(IntPtr x, vtkPolyData surface, IntPtr bds, double length, double tol, vtkAbstractCellLocator locator, vtkIdList cellIds, vtkGenericCell genCell, vtkIntersectionCounter counter, vtkRandomPool poole, long seqIdx)
	{
		return vtkSelectEnclosedPoints_IsInsideSurface_20(x, surface?.GetCppThis() ?? default(HandleRef), bds, length, tol, locator?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), genCell?.GetCppThis() ?? default(HandleRef), counter, poole?.GetCppThis() ?? default(HandleRef), seqIdx);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectEnclosedPoints_IsSurfaceClosed_21(HandleRef surface);

	/// <summary>
	/// A static method for determining whether a surface is closed. Provide as input
	/// a vtkPolyData. The method returns &gt;0 is the surface is closed and manifold.
	/// </summary>
	public static int IsSurfaceClosed(vtkPolyData surface)
	{
		return vtkSelectEnclosedPoints_IsSurfaceClosed_21(surface?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectEnclosedPoints_IsTypeOf_22(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSelectEnclosedPoints_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectEnclosedPoints_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkSelectEnclosedPoints NewInstance()
	{
		vtkSelectEnclosedPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectEnclosedPoints_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelectEnclosedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectEnclosedPoints_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkSelectEnclosedPoints SafeDownCast(vtkObjectBase o)
	{
		vtkSelectEnclosedPoints vtkSelectEnclosedPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectEnclosedPoints_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelectEnclosedPoints2 = (vtkSelectEnclosedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelectEnclosedPoints2.Register(null);
			}
		}
		return vtkSelectEnclosedPoints2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectEnclosedPoints_SetCheckSurface_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to check the surface for closure. If on, then the
	/// algorithm first checks to see if the surface is closed and manifold.
	/// </summary>
	public virtual void SetCheckSurface(int _arg)
	{
		vtkSelectEnclosedPoints_SetCheckSurface_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectEnclosedPoints_SetInsideOut_27(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, points inside the surface are marked inside or sent to
	/// the output. If InsideOut is on, then the points outside the surface
	/// are marked inside.
	/// </summary>
	public virtual void SetInsideOut(int _arg)
	{
		vtkSelectEnclosedPoints_SetInsideOut_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectEnclosedPoints_SetSurfaceConnection_28(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Set the surface to be used to test for containment. Two methods are
	/// provided: one directly for vtkPolyData, and one for the output of a
	/// filter.
	/// </summary>
	public void SetSurfaceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkSelectEnclosedPoints_SetSurfaceConnection_28(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectEnclosedPoints_SetSurfaceData_29(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Set the surface to be used to test for containment. Two methods are
	/// provided: one directly for vtkPolyData, and one for the output of a
	/// filter.
	/// </summary>
	public void SetSurfaceData(vtkPolyData pd)
	{
		vtkSelectEnclosedPoints_SetSurfaceData_29(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectEnclosedPoints_SetTolerance_30(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the tolerance on the intersection. The tolerance is expressed as
	/// a fraction of the diagonal of the bounding box of the enclosing surface.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkSelectEnclosedPoints_SetTolerance_30(GetCppThis(), _arg);
	}
}
