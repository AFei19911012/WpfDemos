using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractEnclosedPoints
/// </summary>
/// <remarks>
///    extract points inside of a closed polygonal surface
///
/// vtkExtractEnclosedPoints is a filter that evaluates all the input points
/// to determine whether they are contained within an enclosing surface. Those
/// within the surface are sent to the output. The enclosing surface is
/// specified through a second input to the filter.
///
/// Note: as a derived class of vtkPointCloudFilter, additional methods are
/// available for generating an in/out mask, and also extracting points
/// outside of the enclosing surface.
///
/// @warning
/// The filter assumes that the surface is closed and manifold. A boolean flag
/// can be set to force the filter to first check whether this is true. If false,
/// all points will be marked outside. Note that if this check is not performed
/// and the surface is not closed, the results are undefined.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// @warning
/// The filter vtkSelectEnclosedPoints marks points as to in/out of the
/// enclosing surface, and operates on any dataset type, producing an output
/// dataset of the same type as the input. Then, thresholding and masking
/// filters can be used to extract parts of the dataset. This filter
/// (vtkExtractEnclosedPoints) is meant to operate on point clouds represented
/// by vtkPolyData, and produces vtkPolyData on output, so it is more
/// efficient for point processing. Note that this filter delegates many of
/// its methods to vtkSelectEnclosedPoints.
///
/// </remarks>
/// <seealso>
///
/// vtkSelectEnclosedPoints vtkExtractPoints
/// </seealso>
public class vtkExtractEnclosedPoints : vtkPointCloudFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractEnclosedPoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractEnclosedPoints()
	{
		MRClassNameKey = "class vtkExtractEnclosedPoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractEnclosedPoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractEnclosedPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractEnclosedPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkExtractEnclosedPoints New()
	{
		vtkExtractEnclosedPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractEnclosedPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractEnclosedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkExtractEnclosedPoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractEnclosedPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExtractEnclosedPoints_CheckSurfaceOff_01(HandleRef pThis);

	/// <summary>
	/// Specify whether to check the surface for closure. If on, then the
	/// algorithm first checks to see if the surface is closed and manifold.
	/// </summary>
	public virtual void CheckSurfaceOff()
	{
		vtkExtractEnclosedPoints_CheckSurfaceOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractEnclosedPoints_CheckSurfaceOn_02(HandleRef pThis);

	/// <summary>
	/// Specify whether to check the surface for closure. If on, then the
	/// algorithm first checks to see if the surface is closed and manifold.
	/// </summary>
	public virtual void CheckSurfaceOn()
	{
		vtkExtractEnclosedPoints_CheckSurfaceOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractEnclosedPoints_GetCheckSurface_03(HandleRef pThis);

	/// <summary>
	/// Specify whether to check the surface for closure. If on, then the
	/// algorithm first checks to see if the surface is closed and manifold.
	/// </summary>
	public virtual int GetCheckSurface()
	{
		return vtkExtractEnclosedPoints_GetCheckSurface_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractEnclosedPoints_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractEnclosedPoints_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractEnclosedPoints_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractEnclosedPoints_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractEnclosedPoints_GetSurface_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a pointer to the enclosing surface.
	/// </summary>
	public vtkPolyData GetSurface()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractEnclosedPoints_GetSurface_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractEnclosedPoints_GetSurface_07(HandleRef pThis, HandleRef sourceInfo, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a pointer to the enclosing surface.
	/// </summary>
	public vtkPolyData GetSurface(vtkInformationVector sourceInfo)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractEnclosedPoints_GetSurface_07(GetCppThis(), sourceInfo?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExtractEnclosedPoints_GetTolerance_08(HandleRef pThis);

	/// <summary>
	/// Specify the tolerance on the intersection. The tolerance is expressed as
	/// a fraction of the diagonal of the bounding box of the enclosing surface.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkExtractEnclosedPoints_GetTolerance_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExtractEnclosedPoints_GetToleranceMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the tolerance on the intersection. The tolerance is expressed as
	/// a fraction of the diagonal of the bounding box of the enclosing surface.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkExtractEnclosedPoints_GetToleranceMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExtractEnclosedPoints_GetToleranceMinValue_10(HandleRef pThis);

	/// <summary>
	/// Specify the tolerance on the intersection. The tolerance is expressed as
	/// a fraction of the diagonal of the bounding box of the enclosing surface.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkExtractEnclosedPoints_GetToleranceMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractEnclosedPoints_IsA_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractEnclosedPoints_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractEnclosedPoints_IsTypeOf_12(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractEnclosedPoints_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractEnclosedPoints_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkExtractEnclosedPoints NewInstance()
	{
		vtkExtractEnclosedPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractEnclosedPoints_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractEnclosedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractEnclosedPoints_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkExtractEnclosedPoints SafeDownCast(vtkObjectBase o)
	{
		vtkExtractEnclosedPoints vtkExtractEnclosedPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractEnclosedPoints_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractEnclosedPoints2 = (vtkExtractEnclosedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractEnclosedPoints2.Register(null);
			}
		}
		return vtkExtractEnclosedPoints2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractEnclosedPoints_SetCheckSurface_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to check the surface for closure. If on, then the
	/// algorithm first checks to see if the surface is closed and manifold.
	/// </summary>
	public virtual void SetCheckSurface(int _arg)
	{
		vtkExtractEnclosedPoints_SetCheckSurface_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractEnclosedPoints_SetSurfaceConnection_17(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Set the surface to be used to test for containment. Two methods are
	/// provided: one directly for vtkPolyData, and one for the output of a
	/// filter.
	/// </summary>
	public void SetSurfaceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkExtractEnclosedPoints_SetSurfaceConnection_17(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractEnclosedPoints_SetSurfaceData_18(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Set the surface to be used to test for containment. Two methods are
	/// provided: one directly for vtkPolyData, and one for the output of a
	/// filter.
	/// </summary>
	public void SetSurfaceData(vtkPolyData pd)
	{
		vtkExtractEnclosedPoints_SetSurfaceData_18(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractEnclosedPoints_SetTolerance_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the tolerance on the intersection. The tolerance is expressed as
	/// a fraction of the diagonal of the bounding box of the enclosing surface.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkExtractEnclosedPoints_SetTolerance_19(GetCppThis(), _arg);
	}
}
