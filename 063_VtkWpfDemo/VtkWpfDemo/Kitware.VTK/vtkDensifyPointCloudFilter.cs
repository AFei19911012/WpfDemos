using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDensifyPointCloudFilter
/// </summary>
/// <remarks>
///    add points to a point cloud to make it denser
///
/// vtkDensifyPointCloudFilter adds new points to an input point cloud. The
/// new points are created in such a way that all points in any local
/// neighborhood are within a target distance of one another. Optionally,
/// attribute data can be interpolated from the input point cloud as well.
///
/// A high-level overview of the algorithm is as follows. For each input
/// point, the distance to all points in its neighborhood is computed. If any
/// of its neighbors is further than the target distance, the edge connecting
/// the point and its neighbor is bisected and a new point is inserted at the
/// bisection point (optionally the attribute data is interpolated as well). A
/// single pass is completed once all the input points are visited. Then the
/// process repeats to the limit of the maximum number of iterations.
///
/// @warning
/// This class can generate a lot of points very quickly. The maximum number
/// of iterations is by default set to =1.0 for this reason. Increase the
/// number of iterations very carefully. Also the MaximumNumberOfPoints
/// data member can be set to limit the explosion of points. It is also
/// recommended that a N closest neighborhood is used.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkVoxelGridFilter vtkEuclideanClusterExtraction vtkBoundedPointSource
/// </seealso>
public class vtkDensifyPointCloudFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// This enum is used to specify how the local point neighborhood is
	/// defined.  A radius-based neighborhood in one where all points inside a
	/// specified radius is part of the neighborhood. A N closest neighborhood is
	/// one in which the N closest points are part of the neighborhood. (Note that
	/// in some cases, if points are precisely the same distance apart, the N closest
	/// may not return all points within an expected radius.)
	/// </summary>
	public enum NeighborhoodType
	{
		/// <summary>enum member</summary>
		N_CLOSEST = 1,
		/// <summary>enum member</summary>
		RADIUS = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDensifyPointCloudFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDensifyPointCloudFilter()
	{
		MRClassNameKey = "class vtkDensifyPointCloudFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDensifyPointCloudFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDensifyPointCloudFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDensifyPointCloudFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkDensifyPointCloudFilter New()
	{
		vtkDensifyPointCloudFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDensifyPointCloudFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDensifyPointCloudFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkDensifyPointCloudFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDensifyPointCloudFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkDensifyPointCloudFilter_GetInterpolateAttributeData_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the interpolation of attribute data from the input point
	/// cloud to new, added points.
	/// </summary>
	public virtual bool GetInterpolateAttributeData()
	{
		return (vtkDensifyPointCloudFilter_GetInterpolateAttributeData_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDensifyPointCloudFilter_GetMaximumNumberOfIterations_02(HandleRef pThis);

	/// <summary>
	/// The maximum number of iterations to run. By default the maximum is
	/// one.
	/// </summary>
	public virtual int GetMaximumNumberOfIterations()
	{
		return vtkDensifyPointCloudFilter_GetMaximumNumberOfIterations_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDensifyPointCloudFilter_GetMaximumNumberOfIterationsMaxValue_03(HandleRef pThis);

	/// <summary>
	/// The maximum number of iterations to run. By default the maximum is
	/// one.
	/// </summary>
	public virtual int GetMaximumNumberOfIterationsMaxValue()
	{
		return vtkDensifyPointCloudFilter_GetMaximumNumberOfIterationsMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDensifyPointCloudFilter_GetMaximumNumberOfIterationsMinValue_04(HandleRef pThis);

	/// <summary>
	/// The maximum number of iterations to run. By default the maximum is
	/// one.
	/// </summary>
	public virtual int GetMaximumNumberOfIterationsMinValue()
	{
		return vtkDensifyPointCloudFilter_GetMaximumNumberOfIterationsMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDensifyPointCloudFilter_GetMaximumNumberOfPoints_05(HandleRef pThis);

	/// <summary>
	/// Set a limit on the maximum number of points that can be created. This
	/// data member serves as a crude barrier to explosive point creation; it does
	/// not guarantee that precisely these many points will be created. Once this
	/// limit is hit, it may result in premature termination of the
	/// algorithm. Consider it a pressure relief valve.
	/// </summary>
	public virtual long GetMaximumNumberOfPoints()
	{
		return vtkDensifyPointCloudFilter_GetMaximumNumberOfPoints_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDensifyPointCloudFilter_GetMaximumNumberOfPointsMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set a limit on the maximum number of points that can be created. This
	/// data member serves as a crude barrier to explosive point creation; it does
	/// not guarantee that precisely these many points will be created. Once this
	/// limit is hit, it may result in premature termination of the
	/// algorithm. Consider it a pressure relief valve.
	/// </summary>
	public virtual long GetMaximumNumberOfPointsMaxValue()
	{
		return vtkDensifyPointCloudFilter_GetMaximumNumberOfPointsMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDensifyPointCloudFilter_GetMaximumNumberOfPointsMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set a limit on the maximum number of points that can be created. This
	/// data member serves as a crude barrier to explosive point creation; it does
	/// not guarantee that precisely these many points will be created. Once this
	/// limit is hit, it may result in premature termination of the
	/// algorithm. Consider it a pressure relief valve.
	/// </summary>
	public virtual long GetMaximumNumberOfPointsMinValue()
	{
		return vtkDensifyPointCloudFilter_GetMaximumNumberOfPointsMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDensifyPointCloudFilter_GetNeighborhoodType_08(HandleRef pThis);

	/// <summary>
	/// Specify how the local point neighborhood is defined. By default an N
	/// closest neighborhood is used. This tends to avoid explosive point
	/// creation.
	/// </summary>
	public virtual int GetNeighborhoodType()
	{
		return vtkDensifyPointCloudFilter_GetNeighborhoodType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDensifyPointCloudFilter_GetNumberOfClosestPoints_09(HandleRef pThis);

	/// <summary>
	/// Define a local neighborhood in terms of the N closest points. By default
	/// the number of the closest points is =6. This data member is relevant
	/// only if the neighborhood type is N_CLOSEST.
	/// </summary>
	public virtual int GetNumberOfClosestPoints()
	{
		return vtkDensifyPointCloudFilter_GetNumberOfClosestPoints_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDensifyPointCloudFilter_GetNumberOfClosestPointsMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Define a local neighborhood in terms of the N closest points. By default
	/// the number of the closest points is =6. This data member is relevant
	/// only if the neighborhood type is N_CLOSEST.
	/// </summary>
	public virtual int GetNumberOfClosestPointsMaxValue()
	{
		return vtkDensifyPointCloudFilter_GetNumberOfClosestPointsMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDensifyPointCloudFilter_GetNumberOfClosestPointsMinValue_11(HandleRef pThis);

	/// <summary>
	/// Define a local neighborhood in terms of the N closest points. By default
	/// the number of the closest points is =6. This data member is relevant
	/// only if the neighborhood type is N_CLOSEST.
	/// </summary>
	public virtual int GetNumberOfClosestPointsMinValue()
	{
		return vtkDensifyPointCloudFilter_GetNumberOfClosestPointsMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDensifyPointCloudFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDensifyPointCloudFilter_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDensifyPointCloudFilter_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDensifyPointCloudFilter_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDensifyPointCloudFilter_GetRadius_14(HandleRef pThis);

	/// <summary>
	/// Define a local neighborhood for each point in terms of a local
	/// radius. By default, the radius is 1.0. This data member is relevant only
	/// if the neighborhood type is RADIUS.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkDensifyPointCloudFilter_GetRadius_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDensifyPointCloudFilter_GetRadiusMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Define a local neighborhood for each point in terms of a local
	/// radius. By default, the radius is 1.0. This data member is relevant only
	/// if the neighborhood type is RADIUS.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkDensifyPointCloudFilter_GetRadiusMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDensifyPointCloudFilter_GetRadiusMinValue_16(HandleRef pThis);

	/// <summary>
	/// Define a local neighborhood for each point in terms of a local
	/// radius. By default, the radius is 1.0. This data member is relevant only
	/// if the neighborhood type is RADIUS.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkDensifyPointCloudFilter_GetRadiusMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDensifyPointCloudFilter_GetTargetDistance_17(HandleRef pThis);

	/// <summary>
	/// Set / get the target point distance. Points will be created in an
	/// iterative fashion until all points in their local neighborhood are the
	/// target distance apart or less. Note that the process may terminate early
	/// due to the limit on the maximum number of iterations. By default the target
	/// distance is set to 0.5. Note that the TargetDistance should be less than
	/// the Radius or nothing will change on output.
	/// </summary>
	public virtual double GetTargetDistance()
	{
		return vtkDensifyPointCloudFilter_GetTargetDistance_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDensifyPointCloudFilter_GetTargetDistanceMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set / get the target point distance. Points will be created in an
	/// iterative fashion until all points in their local neighborhood are the
	/// target distance apart or less. Note that the process may terminate early
	/// due to the limit on the maximum number of iterations. By default the target
	/// distance is set to 0.5. Note that the TargetDistance should be less than
	/// the Radius or nothing will change on output.
	/// </summary>
	public virtual double GetTargetDistanceMaxValue()
	{
		return vtkDensifyPointCloudFilter_GetTargetDistanceMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDensifyPointCloudFilter_GetTargetDistanceMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set / get the target point distance. Points will be created in an
	/// iterative fashion until all points in their local neighborhood are the
	/// target distance apart or less. Note that the process may terminate early
	/// due to the limit on the maximum number of iterations. By default the target
	/// distance is set to 0.5. Note that the TargetDistance should be less than
	/// the Radius or nothing will change on output.
	/// </summary>
	public virtual double GetTargetDistanceMinValue()
	{
		return vtkDensifyPointCloudFilter_GetTargetDistanceMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDensifyPointCloudFilter_InterpolateAttributeDataOff_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off the interpolation of attribute data from the input point
	/// cloud to new, added points.
	/// </summary>
	public virtual void InterpolateAttributeDataOff()
	{
		vtkDensifyPointCloudFilter_InterpolateAttributeDataOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDensifyPointCloudFilter_InterpolateAttributeDataOn_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off the interpolation of attribute data from the input point
	/// cloud to new, added points.
	/// </summary>
	public virtual void InterpolateAttributeDataOn()
	{
		vtkDensifyPointCloudFilter_InterpolateAttributeDataOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDensifyPointCloudFilter_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDensifyPointCloudFilter_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDensifyPointCloudFilter_IsTypeOf_23(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDensifyPointCloudFilter_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDensifyPointCloudFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkDensifyPointCloudFilter NewInstance()
	{
		vtkDensifyPointCloudFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDensifyPointCloudFilter_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDensifyPointCloudFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDensifyPointCloudFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkDensifyPointCloudFilter SafeDownCast(vtkObjectBase o)
	{
		vtkDensifyPointCloudFilter vtkDensifyPointCloudFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDensifyPointCloudFilter_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDensifyPointCloudFilter2 = (vtkDensifyPointCloudFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDensifyPointCloudFilter2.Register(null);
			}
		}
		return vtkDensifyPointCloudFilter2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDensifyPointCloudFilter_SetInterpolateAttributeData_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the interpolation of attribute data from the input point
	/// cloud to new, added points.
	/// </summary>
	public virtual void SetInterpolateAttributeData(bool _arg)
	{
		vtkDensifyPointCloudFilter_SetInterpolateAttributeData_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDensifyPointCloudFilter_SetMaximumNumberOfIterations_28(HandleRef pThis, int _arg);

	/// <summary>
	/// The maximum number of iterations to run. By default the maximum is
	/// one.
	/// </summary>
	public virtual void SetMaximumNumberOfIterations(int _arg)
	{
		vtkDensifyPointCloudFilter_SetMaximumNumberOfIterations_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDensifyPointCloudFilter_SetMaximumNumberOfPoints_29(HandleRef pThis, long _arg);

	/// <summary>
	/// Set a limit on the maximum number of points that can be created. This
	/// data member serves as a crude barrier to explosive point creation; it does
	/// not guarantee that precisely these many points will be created. Once this
	/// limit is hit, it may result in premature termination of the
	/// algorithm. Consider it a pressure relief valve.
	/// </summary>
	public virtual void SetMaximumNumberOfPoints(long _arg)
	{
		vtkDensifyPointCloudFilter_SetMaximumNumberOfPoints_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDensifyPointCloudFilter_SetNeighborhoodType_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify how the local point neighborhood is defined. By default an N
	/// closest neighborhood is used. This tends to avoid explosive point
	/// creation.
	/// </summary>
	public virtual void SetNeighborhoodType(int _arg)
	{
		vtkDensifyPointCloudFilter_SetNeighborhoodType_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDensifyPointCloudFilter_SetNeighborhoodTypeToNClosest_31(HandleRef pThis);

	/// <summary>
	/// Specify how the local point neighborhood is defined. By default an N
	/// closest neighborhood is used. This tends to avoid explosive point
	/// creation.
	/// </summary>
	public void SetNeighborhoodTypeToNClosest()
	{
		vtkDensifyPointCloudFilter_SetNeighborhoodTypeToNClosest_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDensifyPointCloudFilter_SetNeighborhoodTypeToRadius_32(HandleRef pThis);

	/// <summary>
	/// Specify how the local point neighborhood is defined. By default an N
	/// closest neighborhood is used. This tends to avoid explosive point
	/// creation.
	/// </summary>
	public void SetNeighborhoodTypeToRadius()
	{
		vtkDensifyPointCloudFilter_SetNeighborhoodTypeToRadius_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDensifyPointCloudFilter_SetNumberOfClosestPoints_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Define a local neighborhood in terms of the N closest points. By default
	/// the number of the closest points is =6. This data member is relevant
	/// only if the neighborhood type is N_CLOSEST.
	/// </summary>
	public virtual void SetNumberOfClosestPoints(int _arg)
	{
		vtkDensifyPointCloudFilter_SetNumberOfClosestPoints_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDensifyPointCloudFilter_SetRadius_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Define a local neighborhood for each point in terms of a local
	/// radius. By default, the radius is 1.0. This data member is relevant only
	/// if the neighborhood type is RADIUS.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkDensifyPointCloudFilter_SetRadius_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDensifyPointCloudFilter_SetTargetDistance_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the target point distance. Points will be created in an
	/// iterative fashion until all points in their local neighborhood are the
	/// target distance apart or less. Note that the process may terminate early
	/// due to the limit on the maximum number of iterations. By default the target
	/// distance is set to 0.5. Note that the TargetDistance should be less than
	/// the Radius or nothing will change on output.
	/// </summary>
	public virtual void SetTargetDistance(double _arg)
	{
		vtkDensifyPointCloudFilter_SetTargetDistance_35(GetCppThis(), _arg);
	}
}
