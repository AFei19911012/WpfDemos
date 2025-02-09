using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProjectPointsToPlane
/// </summary>
/// <remarks>
///    project all input points to a plane
///
/// vtkProjectPointsToPlane is a filter that operates on a vtkPointSet (and
/// its subclasses), projecting all input points to a plane. There are
/// multiple options as to what plane to project to: The user may specify one
/// of the x-y-z planes, the best coordinate plane, a user-defined plane, or
/// the closest fitting plane (using a least-squares method). On output, the
/// points will lie on the specified plane, and any cells connected to the
/// points (if any) will be deformed accordingly. On output, the filter will
/// not modify dataset topology, nor modify point or cell attributes. Only the
/// point coordinates (geometry) will be modified. (Note that the filter will
/// operate on input point sets with or without cells.)
///
/// @warning
/// It is possible that cells connected to the projected points will become
/// invalid after the projection operation.
///
/// </remarks>
/// <seealso>
///
/// vtkPlane
/// </seealso>
public class vtkProjectPointsToPlane : vtkPointSetAlgorithm
{
	/// <summary>
	/// Define the options available for point projection. By default,
	/// the filter projects to the z-plane.
	/// </summary>
	public enum PlaneProjectionType
	{
		/// <summary>enum member</summary>
		BEST_COORDINATE_PLANE = 5,
		/// <summary>enum member</summary>
		BEST_FIT_PLANE = 6,
		/// <summary>enum member</summary>
		SPECIFIED_PLANE = 4,
		/// <summary>enum member</summary>
		X_PLANE = 1,
		/// <summary>enum member</summary>
		Y_PLANE = 2,
		/// <summary>enum member</summary>
		Z_PLANE = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProjectPointsToPlane";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProjectPointsToPlane()
	{
		MRClassNameKey = "class vtkProjectPointsToPlane";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectPointsToPlane"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProjectPointsToPlane(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectPointsToPlane_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public new static vtkProjectPointsToPlane New()
	{
		vtkProjectPointsToPlane result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectPointsToPlane_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProjectPointsToPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public vtkProjectPointsToPlane()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProjectPointsToPlane_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkProjectPointsToPlane_GetNormal_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the plane normal and origin. On input, these methods are used to specify
	/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
	/// on output the methods return the plane on which the points were projected.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkProjectPointsToPlane_GetNormal_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_GetNormal_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the plane normal and origin. On input, these methods are used to specify
	/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
	/// on output the methods return the plane on which the points were projected.
	/// </summary>
	public virtual void GetNormal(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProjectPointsToPlane_GetNormal_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_GetNormal_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the plane normal and origin. On input, these methods are used to specify
	/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
	/// on output the methods return the plane on which the points were projected.
	/// </summary>
	public virtual void GetNormal(IntPtr _arg)
	{
		vtkProjectPointsToPlane_GetNormal_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectPointsToPlane_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProjectPointsToPlane_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectPointsToPlane_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProjectPointsToPlane_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectPointsToPlane_GetOrigin_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the plane normal and origin. On input, these methods are used to specify
	/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
	/// on output the methods return the plane on which the points were projected.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkProjectPointsToPlane_GetOrigin_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_GetOrigin_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the plane normal and origin. On input, these methods are used to specify
	/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
	/// on output the methods return the plane on which the points were projected.
	/// </summary>
	public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProjectPointsToPlane_GetOrigin_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_GetOrigin_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the plane normal and origin. On input, these methods are used to specify
	/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
	/// on output the methods return the plane on which the points were projected.
	/// </summary>
	public virtual void GetOrigin(IntPtr _arg)
	{
		vtkProjectPointsToPlane_GetOrigin_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectPointsToPlane_GetOutputPointsPrecision_09(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points. See the
	/// documentation for the vtkAlgorithm::Precision enum for an explanation of
	/// the available precision settings. By default, the output precision is
	/// DEFAULT_PRECISION (i.e., the input and output types are the same) - this
	/// can cause issues if projecting integral point types.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkProjectPointsToPlane_GetOutputPointsPrecision_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectPointsToPlane_GetProjectionType_10(HandleRef pThis);

	/// <summary>
	/// Specify the type of projection to perform. Points may be projected to
	/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
	/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
	/// best fitting plane. For option #4, the user must also specify a plane
	/// Origin and Normal. For all options, after filter execution, the plane
	/// onto which the points are projected is returned in the Origin and Normal
	/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
	/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
	/// to the fitted plane normal.
	/// </summary>
	public virtual int GetProjectionType()
	{
		return vtkProjectPointsToPlane_GetProjectionType_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectPointsToPlane_GetProjectionTypeMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the type of projection to perform. Points may be projected to
	/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
	/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
	/// best fitting plane. For option #4, the user must also specify a plane
	/// Origin and Normal. For all options, after filter execution, the plane
	/// onto which the points are projected is returned in the Origin and Normal
	/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
	/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
	/// to the fitted plane normal.
	/// </summary>
	public virtual int GetProjectionTypeMaxValue()
	{
		return vtkProjectPointsToPlane_GetProjectionTypeMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectPointsToPlane_GetProjectionTypeMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the type of projection to perform. Points may be projected to
	/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
	/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
	/// best fitting plane. For option #4, the user must also specify a plane
	/// Origin and Normal. For all options, after filter execution, the plane
	/// onto which the points are projected is returned in the Origin and Normal
	/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
	/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
	/// to the fitted plane normal.
	/// </summary>
	public virtual int GetProjectionTypeMinValue()
	{
		return vtkProjectPointsToPlane_GetProjectionTypeMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectPointsToPlane_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProjectPointsToPlane_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectPointsToPlane_IsTypeOf_14(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProjectPointsToPlane_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectPointsToPlane_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public new vtkProjectPointsToPlane NewInstance()
	{
		vtkProjectPointsToPlane result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectPointsToPlane_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProjectPointsToPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectPointsToPlane_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public new static vtkProjectPointsToPlane SafeDownCast(vtkObjectBase o)
	{
		vtkProjectPointsToPlane vtkProjectPointsToPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectPointsToPlane_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProjectPointsToPlane2 = (vtkProjectPointsToPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProjectPointsToPlane2.Register(null);
			}
		}
		return vtkProjectPointsToPlane2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetNormal_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the plane normal and origin. On input, these methods are used to specify
	/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
	/// on output the methods return the plane on which the points were projected.
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkProjectPointsToPlane_SetNormal_18(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetNormal_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the plane normal and origin. On input, these methods are used to specify
	/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
	/// on output the methods return the plane on which the points were projected.
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkProjectPointsToPlane_SetNormal_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetOrigin_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the plane normal and origin. On input, these methods are used to specify
	/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
	/// on output the methods return the plane on which the points were projected.
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkProjectPointsToPlane_SetOrigin_20(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetOrigin_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the plane normal and origin. On input, these methods are used to specify
	/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
	/// on output the methods return the plane on which the points were projected.
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkProjectPointsToPlane_SetOrigin_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetOutputPointsPrecision_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points. See the
	/// documentation for the vtkAlgorithm::Precision enum for an explanation of
	/// the available precision settings. By default, the output precision is
	/// DEFAULT_PRECISION (i.e., the input and output types are the same) - this
	/// can cause issues if projecting integral point types.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkProjectPointsToPlane_SetOutputPointsPrecision_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetProjectionType_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the type of projection to perform. Points may be projected to
	/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
	/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
	/// best fitting plane. For option #4, the user must also specify a plane
	/// Origin and Normal. For all options, after filter execution, the plane
	/// onto which the points are projected is returned in the Origin and Normal
	/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
	/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
	/// to the fitted plane normal.
	/// </summary>
	public virtual void SetProjectionType(int _arg)
	{
		vtkProjectPointsToPlane_SetProjectionType_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToBestCoordinatePlane_24(HandleRef pThis);

	/// <summary>
	/// Specify the type of projection to perform. Points may be projected to
	/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
	/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
	/// best fitting plane. For option #4, the user must also specify a plane
	/// Origin and Normal. For all options, after filter execution, the plane
	/// onto which the points are projected is returned in the Origin and Normal
	/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
	/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
	/// to the fitted plane normal.
	/// </summary>
	public void SetProjectionTypeToBestCoordinatePlane()
	{
		vtkProjectPointsToPlane_SetProjectionTypeToBestCoordinatePlane_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToBestFitPlane_25(HandleRef pThis);

	/// <summary>
	/// Specify the type of projection to perform. Points may be projected to
	/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
	/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
	/// best fitting plane. For option #4, the user must also specify a plane
	/// Origin and Normal. For all options, after filter execution, the plane
	/// onto which the points are projected is returned in the Origin and Normal
	/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
	/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
	/// to the fitted plane normal.
	/// </summary>
	public void SetProjectionTypeToBestFitPlane()
	{
		vtkProjectPointsToPlane_SetProjectionTypeToBestFitPlane_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToSpecifiedPlane_26(HandleRef pThis);

	/// <summary>
	/// Specify the type of projection to perform. Points may be projected to
	/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
	/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
	/// best fitting plane. For option #4, the user must also specify a plane
	/// Origin and Normal. For all options, after filter execution, the plane
	/// onto which the points are projected is returned in the Origin and Normal
	/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
	/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
	/// to the fitted plane normal.
	/// </summary>
	public void SetProjectionTypeToSpecifiedPlane()
	{
		vtkProjectPointsToPlane_SetProjectionTypeToSpecifiedPlane_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToXPlane_27(HandleRef pThis);

	/// <summary>
	/// Specify the type of projection to perform. Points may be projected to
	/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
	/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
	/// best fitting plane. For option #4, the user must also specify a plane
	/// Origin and Normal. For all options, after filter execution, the plane
	/// onto which the points are projected is returned in the Origin and Normal
	/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
	/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
	/// to the fitted plane normal.
	/// </summary>
	public void SetProjectionTypeToXPlane()
	{
		vtkProjectPointsToPlane_SetProjectionTypeToXPlane_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToYPlane_28(HandleRef pThis);

	/// <summary>
	/// Specify the type of projection to perform. Points may be projected to
	/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
	/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
	/// best fitting plane. For option #4, the user must also specify a plane
	/// Origin and Normal. For all options, after filter execution, the plane
	/// onto which the points are projected is returned in the Origin and Normal
	/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
	/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
	/// to the fitted plane normal.
	/// </summary>
	public void SetProjectionTypeToYPlane()
	{
		vtkProjectPointsToPlane_SetProjectionTypeToYPlane_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToZPlane_29(HandleRef pThis);

	/// <summary>
	/// Specify the type of projection to perform. Points may be projected to
	/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
	/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
	/// best fitting plane. For option #4, the user must also specify a plane
	/// Origin and Normal. For all options, after filter execution, the plane
	/// onto which the points are projected is returned in the Origin and Normal
	/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
	/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
	/// to the fitted plane normal.
	/// </summary>
	public void SetProjectionTypeToZPlane()
	{
		vtkProjectPointsToPlane_SetProjectionTypeToZPlane_29(GetCppThis());
	}
}
