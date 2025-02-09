using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlane
/// </summary>
/// <remarks>
///    perform various plane computations
///
/// vtkPlane provides methods for various plane computations. These include
/// projecting points onto a plane, evaluating the plane equation, and
/// returning plane normal. vtkPlane is a concrete implementation of the
/// abstract class vtkImplicitFunction.
/// </remarks>
public class vtkPlane : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlane";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlane()
	{
		MRClassNameKey = "class vtkPlane";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlane"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlane(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlane_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct plane passing through origin and normal to z-axis.
	/// </summary>
	public new static vtkPlane New()
	{
		vtkPlane result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlane_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct plane passing through origin and normal to z-axis.
	/// </summary>
	public vtkPlane()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlane_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlane_ComputeBestFittingPlane_01(HandleRef pts, IntPtr origin, IntPtr normal);

	/// <summary>
	/// Given a set of points calculate the best-fitting origin and normal for the plane.
	/// The origin will be the centroid of the points. The normal is determined
	/// by using the covariance matrix of the points relative to the centroid.
	/// Returns true if successful. If not successful the origin will still contain
	/// the centroid and the normal will point into z-direction.
	/// </summary>
	public static bool ComputeBestFittingPlane(vtkPoints pts, IntPtr origin, IntPtr normal)
	{
		return (vtkPlane_ComputeBestFittingPlane_01(pts?.GetCppThis() ?? default(HandleRef), origin, normal) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPlane_DistanceToPlane_02(IntPtr x, IntPtr n, IntPtr p0);

	/// <summary>
	/// Return the distance of a point x to a plane defined by n(x-p0) = 0. The
	/// normal n[3] must be magnitude=1.
	/// </summary>
	public static double DistanceToPlane(IntPtr x, IntPtr n, IntPtr p0)
	{
		return vtkPlane_DistanceToPlane_02(x, n, p0);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPlane_DistanceToPlane_03(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Return the distance of a point x to a plane defined by n(x-p0) = 0. The
	/// normal n[3] must be magnitude=1.
	/// </summary>
	public double DistanceToPlane(IntPtr x)
	{
		return vtkPlane_DistanceToPlane_03(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPlane_Evaluate_04(IntPtr normal, IntPtr origin, IntPtr x);

	/// <summary>
	/// Quick evaluation of plane equation n(x-origin)=0.
	/// </summary>
	public static double Evaluate(IntPtr normal, IntPtr origin, IntPtr x)
	{
		return vtkPlane_Evaluate_04(normal, origin, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_EvaluateFunction_05(HandleRef pThis, HandleRef input, HandleRef output);

	/// <summary>
	/// Evaluate plane equation for point x[3].
	/// </summary>
	public override void EvaluateFunction(vtkDataArray input, vtkDataArray output)
	{
		vtkPlane_EvaluateFunction_05(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPlane_EvaluateFunction_06(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate plane equation for point x[3].
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkPlane_EvaluateFunction_06(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_EvaluateGradient_07(HandleRef pThis, IntPtr x, IntPtr g);

	/// <summary>
	/// Evaluate function gradient at point x[3].
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr g)
	{
		vtkPlane_EvaluateGradient_07(GetCppThis(), x, g);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_GeneralizedProjectPoint_08(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj);

	/// <summary>
	/// Project a point x onto plane defined by origin and normal. The
	/// projected point is returned in xproj. NOTE : normal does NOT have to
	/// have magnitude 1.
	/// </summary>
	public static void GeneralizedProjectPoint(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj)
	{
		vtkPlane_GeneralizedProjectPoint_08(x, origin, normal, xproj);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_GeneralizedProjectPoint_09(HandleRef pThis, IntPtr x, IntPtr xproj);

	/// <summary>
	/// Project a point x onto plane defined by origin and normal. The
	/// projected point is returned in xproj. NOTE : normal does NOT have to
	/// have magnitude 1.
	/// </summary>
	public void GeneralizedProjectPoint(IntPtr x, IntPtr xproj)
	{
		vtkPlane_GeneralizedProjectPoint_09(GetCppThis(), x, xproj);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlane_GetNormal_10(HandleRef pThis);

	/// <summary>
	/// Set/get plane normal. Plane is defined by point and normal.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkPlane_GetNormal_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_GetNormal_11(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/get plane normal. Plane is defined by point and normal.
	/// </summary>
	public virtual void GetNormal(IntPtr data)
	{
		vtkPlane_GetNormal_11(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlane_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Construct plane passing through origin and normal to z-axis.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlane_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlane_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Construct plane passing through origin and normal to z-axis.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlane_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlane_GetOrigin_14(HandleRef pThis);

	/// <summary>
	/// Set/get point through which plane passes. Plane is defined by point
	/// and normal.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkPlane_GetOrigin_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_GetOrigin_15(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/get point through which plane passes. Plane is defined by point
	/// and normal.
	/// </summary>
	public virtual void GetOrigin(IntPtr data)
	{
		vtkPlane_GetOrigin_15(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlane_IntersectWithFinitePlane_16(IntPtr n, IntPtr o, IntPtr pOrigin, IntPtr px, IntPtr py, IntPtr x0, IntPtr x1);

	/// <summary>
	/// Given two planes, one infinite and one finite, defined by the normal n
	/// and point o (infinite plane), and the second finite plane1 defined by
	/// the three points (pOrigin,px,py), compute a line of intersection (if
	/// any). The line of intersection is defined by the return values
	/// (x0,x1). If there is no intersection, then zero is returned; otherwise
	/// non-zero. There are two variants of this method. The static function
	/// operates on the supplied function parameters; the non-static operates on
	/// this instance of vtkPlane (and its associated origin and normal).
	/// </summary>
	public static int IntersectWithFinitePlane(IntPtr n, IntPtr o, IntPtr pOrigin, IntPtr px, IntPtr py, IntPtr x0, IntPtr x1)
	{
		return vtkPlane_IntersectWithFinitePlane_16(n, o, pOrigin, px, py, x0, x1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlane_IntersectWithFinitePlane_17(HandleRef pThis, IntPtr pOrigin, IntPtr px, IntPtr py, IntPtr x0, IntPtr x1);

	/// <summary>
	/// Given two planes, one infinite and one finite, defined by the normal n
	/// and point o (infinite plane), and the second finite plane1 defined by
	/// the three points (pOrigin,px,py), compute a line of intersection (if
	/// any). The line of intersection is defined by the return values
	/// (x0,x1). If there is no intersection, then zero is returned; otherwise
	/// non-zero. There are two variants of this method. The static function
	/// operates on the supplied function parameters; the non-static operates on
	/// this instance of vtkPlane (and its associated origin and normal).
	/// </summary>
	public int IntersectWithFinitePlane(IntPtr pOrigin, IntPtr px, IntPtr py, IntPtr x0, IntPtr x1)
	{
		return vtkPlane_IntersectWithFinitePlane_17(GetCppThis(), pOrigin, px, py, x0, x1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlane_IntersectWithLine_18(IntPtr p1, IntPtr p2, IntPtr n, IntPtr p0, ref double t, IntPtr x);

	/// <summary>
	/// Given a line defined by the two points p1,p2; and a plane defined by the
	/// normal n and point p0, compute an intersection. The parametric
	/// coordinate along the line is returned in t, and the coordinates of
	/// intersection are returned in x. A zero is returned if the plane and line
	/// do not intersect between (0&lt;=t&lt;=1). If the plane and line are parallel,
	/// zero is returned and t is set to VTK_LARGE_DOUBLE.
	/// </summary>
	public static int IntersectWithLine(IntPtr p1, IntPtr p2, IntPtr n, IntPtr p0, ref double t, IntPtr x)
	{
		return vtkPlane_IntersectWithLine_18(p1, p2, n, p0, ref t, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlane_IntersectWithLine_19(HandleRef pThis, IntPtr p1, IntPtr p2, ref double t, IntPtr x);

	/// <summary>
	/// Given a line defined by the two points p1,p2; and a plane defined by the
	/// normal n and point p0, compute an intersection. The parametric
	/// coordinate along the line is returned in t, and the coordinates of
	/// intersection are returned in x. A zero is returned if the plane and line
	/// do not intersect between (0&lt;=t&lt;=1). If the plane and line are parallel,
	/// zero is returned and t is set to VTK_LARGE_DOUBLE.
	/// </summary>
	public int IntersectWithLine(IntPtr p1, IntPtr p2, ref double t, IntPtr x)
	{
		return vtkPlane_IntersectWithLine_19(GetCppThis(), p1, p2, ref t, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlane_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Construct plane passing through origin and normal to z-axis.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlane_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlane_IsTypeOf_21(string type);

	/// <summary>
	/// Construct plane passing through origin and normal to z-axis.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlane_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlane_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct plane passing through origin and normal to z-axis.
	/// </summary>
	public new vtkPlane NewInstance()
	{
		vtkPlane result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlane_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_ProjectPoint_24(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj);

	/// <summary>
	/// Project a point x onto plane defined by origin and normal. The
	/// projected point is returned in xproj. NOTE : normal assumed to
	/// have magnitude 1.
	/// </summary>
	public static void ProjectPoint(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj)
	{
		vtkPlane_ProjectPoint_24(x, origin, normal, xproj);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_ProjectPoint_25(HandleRef pThis, IntPtr x, IntPtr xproj);

	/// <summary>
	/// Project a point x onto plane defined by origin and normal. The
	/// projected point is returned in xproj. NOTE : normal assumed to
	/// have magnitude 1.
	/// </summary>
	public void ProjectPoint(IntPtr x, IntPtr xproj)
	{
		vtkPlane_ProjectPoint_25(GetCppThis(), x, xproj);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_ProjectVector_26(IntPtr v, IntPtr origin, IntPtr normal, IntPtr vproj);

	/// <summary>
	/// Project a vector v onto plane defined by origin and normal. The
	/// projected vector is returned in vproj.
	/// </summary>
	public static void ProjectVector(IntPtr v, IntPtr origin, IntPtr normal, IntPtr vproj)
	{
		vtkPlane_ProjectVector_26(v, origin, normal, vproj);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_ProjectVector_27(HandleRef pThis, IntPtr v, IntPtr vproj);

	/// <summary>
	/// Project a vector v onto plane defined by origin and normal. The
	/// projected vector is returned in vproj.
	/// </summary>
	public void ProjectVector(IntPtr v, IntPtr vproj)
	{
		vtkPlane_ProjectVector_27(GetCppThis(), v, vproj);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_Push_28(HandleRef pThis, double distance);

	/// <summary>
	/// Translate the plane in the direction of the normal by the
	/// distance specified.  Negative values move the plane in the
	/// opposite direction.
	/// </summary>
	public void Push(double distance)
	{
		vtkPlane_Push_28(GetCppThis(), distance);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlane_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct plane passing through origin and normal to z-axis.
	/// </summary>
	public new static vtkPlane SafeDownCast(vtkObjectBase o)
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlane_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_SetNormal_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/get plane normal. Plane is defined by point and normal.
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkPlane_SetNormal_30(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_SetNormal_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get plane normal. Plane is defined by point and normal.
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkPlane_SetNormal_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_SetOrigin_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/get point through which plane passes. Plane is defined by point
	/// and normal.
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkPlane_SetOrigin_32(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlane_SetOrigin_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get point through which plane passes. Plane is defined by point
	/// and normal.
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkPlane_SetOrigin_33(GetCppThis(), _arg);
	}
}
