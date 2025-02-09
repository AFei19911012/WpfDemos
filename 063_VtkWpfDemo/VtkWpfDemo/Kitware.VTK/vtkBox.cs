using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBox
/// </summary>
/// <remarks>
///    implicit function for a bounding box
///
/// vtkBox computes the implicit function and/or gradient for a axis-aligned
/// bounding box. (The superclasses transform can be used to modify this
/// orientation.) Each side of the box is orthogonal to all other sides
/// meeting along shared edges and all faces are orthogonal to the x-y-z
/// coordinate axes.  (If you wish to orient this box differently, recall that
/// the superclass vtkImplicitFunction supports a transformation matrix.)
/// vtkBox is a concrete implementation of vtkImplicitFunction.
///
/// </remarks>
/// <seealso>
///
/// vtkCubeSource vtkImplicitFunction vtkBoundingBox
/// </seealso>
public class vtkBox : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBox";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBox()
	{
		MRClassNameKey = "class vtkBox";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBox"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBox(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBox_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct box with center at (0,0,0) and each side of length 1.0.
	/// </summary>
	public new static vtkBox New()
	{
		vtkBox result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBox_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct box with center at (0,0,0) and each side of length 1.0.
	/// </summary>
	public vtkBox()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBox_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBox_AddBounds_01(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// A special method that allows union set operation on bounding boxes.
	/// Start with a SetBounds(). Subsequent AddBounds() methods are union set
	/// operations on the original bounds. Retrieve the final bounds with a
	/// GetBounds() method.
	/// </summary>
	public void AddBounds(IntPtr bounds)
	{
		vtkBox_AddBounds_01(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBox_EvaluateFunction_02(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate box defined by the two points (pMin,pMax).
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkBox_EvaluateFunction_02(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr n);

	/// <summary>
	/// Evaluate the gradient of the box.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr n)
	{
		vtkBox_EvaluateGradient_03(GetCppThis(), x, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_GetBounds_04(HandleRef pThis, ref double xMin, ref double xMax, ref double yMin, ref double yMax, ref double zMin, ref double zMax);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void GetBounds(ref double xMin, ref double xMax, ref double yMin, ref double yMax, ref double zMin, ref double zMax)
	{
		vtkBox_GetBounds_04(GetCppThis(), ref xMin, ref xMax, ref yMin, ref yMax, ref zMin, ref zMax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_GetBounds_05(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkBox_GetBounds_05(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBox_GetBounds_06(HandleRef pThis);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public double[] GetBounds()
	{
		IntPtr intPtr = vtkBox_GetBounds_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBox_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBox_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBox_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBox_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_GetXMax_09(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void GetXMax(IntPtr p)
	{
		vtkBox_GetXMax_09(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_GetXMax_10(HandleRef pThis, ref double x, ref double y, ref double z);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void GetXMax(ref double x, ref double y, ref double z)
	{
		vtkBox_GetXMax_10(GetCppThis(), ref x, ref y, ref z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_GetXMin_11(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void GetXMin(IntPtr p)
	{
		vtkBox_GetXMin_11(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_GetXMin_12(HandleRef pThis, ref double x, ref double y, ref double z);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void GetXMin(ref double x, ref double y, ref double z)
	{
		vtkBox_GetXMin_12(GetCppThis(), ref x, ref y, ref z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkBox_IntersectBox_13(IntPtr bounds, IntPtr origin, IntPtr dir, IntPtr coord, ref double t, double tolerance);

	/// <summary>
	/// Bounding box intersection with line modified from Graphics Gems Vol
	/// I. The method returns a non-zero value if the bounding box is
	/// hit. Origin[3] starts the ray, dir[3] is the vector components of the
	/// ray in the x-y-z directions, coord[3] is the location of hit, and t is
	/// the parametric coordinate along line. (Notes: the intersection ray
	/// dir[3] is NOT normalized.  Valid intersections will only occur between
	/// 0&lt;=t&lt;=1.)
	/// </summary>
	public static sbyte IntersectBox(IntPtr bounds, IntPtr origin, IntPtr dir, IntPtr coord, ref double t, double tolerance)
	{
		return vtkBox_IntersectBox_13(bounds, origin, dir, coord, ref t, tolerance);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBox_IntersectWithInfiniteLine_14(IntPtr bounds, IntPtr p1, IntPtr p2, ref double t1, ref double t2, IntPtr x1, IntPtr x2, ref int plane1, ref int plane2);

	/// <summary>
	/// Same method as vtkBox::IntersectWithLine, except that t1 and t2 can be outside of [0,1].
	/// t1 is the distance of x1 to p1 in parametric coordinates, and t2 is the distance of x2 to p1
	/// in parametric coordinates as well.
	/// In vtkBox::IntersectWithInLine, it is assumed that [p1,p2] is a segment, here, it is
	/// assumed that it is a line with no ends.
	/// t1 &lt;= t2, which means that x1 is always "before" x2 on the line parameterized by [p1,p2].
	/// x1 and x2 can be set to nullptr without crash.
	/// </summary>
	public static bool IntersectWithInfiniteLine(IntPtr bounds, IntPtr p1, IntPtr p2, ref double t1, ref double t2, IntPtr x1, IntPtr x2, ref int plane1, ref int plane2)
	{
		return (vtkBox_IntersectWithInfiniteLine_14(bounds, p1, p2, ref t1, ref t2, x1, x2, ref plane1, ref plane2) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBox_IntersectWithLine_15(IntPtr bounds, IntPtr p1, IntPtr p2, ref double t1, ref double t2, IntPtr x1, IntPtr x2, ref int plane1, ref int plane2);

	/// <summary>
	/// Intersect a line with the box.  Give the endpoints of the line in
	/// p1 and p2.  The parameteric distances from p1 to the entry and exit
	/// points are returned in t1 and t2, where t1 and t2 are clamped to the
	/// range [0,1].  The entry and exit planes are returned in plane1 and
	/// plane2 where integers (0, 1, 2, 3, 4, 5) stand for the
	/// (xmin, xmax, ymin, ymax, zmin, zmax) planes respectively, and a value
	/// of -1 means that no intersection occurred.  The actual intersection
	/// coordinates are stored in x1 and x2, which can be set to nullptr of you
	/// do not need them to be returned.  The function return value will be
	/// zero if the line is wholly outside of the box.
	/// </summary>
	public static int IntersectWithLine(IntPtr bounds, IntPtr p1, IntPtr p2, ref double t1, ref double t2, IntPtr x1, IntPtr x2, ref int plane1, ref int plane2)
	{
		return vtkBox_IntersectWithLine_15(bounds, p1, p2, ref t1, ref t2, x1, x2, ref plane1, ref plane2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBox_IntersectWithPlane_16(IntPtr bounds, IntPtr origin, IntPtr normal);

	/// <summary>
	/// Plane intersection with the box. The plane is infinite in extent and
	/// defined by an origin and normal. The function indicates whether the
	/// plane intersects, not the particulars of intersection points and such.
	/// The function returns non-zero if the plane and box intersect; zero
	/// otherwise.
	/// </summary>
	public static int IntersectWithPlane(IntPtr bounds, IntPtr origin, IntPtr normal)
	{
		return vtkBox_IntersectWithPlane_16(bounds, origin, normal);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBox_IntersectWithPlane_17(IntPtr bounds, IntPtr origin, IntPtr normal, IntPtr xout);

	/// <summary>
	/// Plane intersection with the box. The plane is infinite in extent and
	/// defined by an origin and normal. The function returns the number of
	/// intersection points, and if does, up to six ordered intersection points
	/// are provided (i.e., the points are ordered and form a valid polygon).
	/// Thus the function returns non-zero if the plane and box intersect; zero
	/// otherwise. Note that if there is an intersection, the number of
	/// intersections ranges from [3,6]. xout memory layout is consistent with
	/// vtkPoints array layout and is organized as (xyz, xyz, xyz, xyz, xyz,
	/// xyz).
	/// </summary>
	public static int IntersectWithPlane(IntPtr bounds, IntPtr origin, IntPtr normal, IntPtr xout)
	{
		return vtkBox_IntersectWithPlane_17(bounds, origin, normal, xout);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBox_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBox_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBox_IsBoxInFrustum_19(IntPtr planes, IntPtr bounds);

	/// <summary>
	/// Is a box in a frustum. Returns true if the box is in the frustum
	/// even partially. The frustum is defined as 6 planes. This method
	/// is not exact may and return true for cases where there is no
	/// intersection. It should never return false when there is an
	/// intersection though.
	/// </summary>
	public static int IsBoxInFrustum(IntPtr planes, IntPtr bounds)
	{
		return vtkBox_IsBoxInFrustum_19(planes, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBox_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBox_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBox_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBox NewInstance()
	{
		vtkBox result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBox_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBox_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBox SafeDownCast(vtkObjectBase o)
	{
		vtkBox vtkBox2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBox_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBox2 = (vtkBox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBox2.Register(null);
			}
		}
		return vtkBox2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_SetBounds_24(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void SetBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
	{
		vtkBox_SetBounds_24(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_SetBounds_25(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void SetBounds(IntPtr bounds)
	{
		vtkBox_SetBounds_25(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_SetXMax_26(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void SetXMax(IntPtr p)
	{
		vtkBox_SetXMax_26(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_SetXMax_27(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void SetXMax(double x, double y, double z)
	{
		vtkBox_SetXMax_27(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_SetXMin_28(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void SetXMin(IntPtr p)
	{
		vtkBox_SetXMin_28(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBox_SetXMin_29(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set / get the bounding box using various methods.
	/// </summary>
	public void SetXMin(double x, double y, double z)
	{
		vtkBox_SetXMin_29(GetCppThis(), x, y, z);
	}
}
