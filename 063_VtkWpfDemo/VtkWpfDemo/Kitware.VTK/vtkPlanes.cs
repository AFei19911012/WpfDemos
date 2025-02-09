using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlanes
/// </summary>
/// <remarks>
///    implicit function for convex set of planes
///
/// vtkPlanes computes the implicit function and function gradient for a set
/// of planes. The planes must define a convex space.
///
/// The function value is the intersection (i.e., maximum value) obtained by
/// evaluating the each of the supplied planes. Hence the value is the maximum
/// distance of a point to the convex region defined by the planes. The
/// function gradient is the plane normal at the function value.  Note that
/// the normals must point outside of the convex region. Thus, a negative
/// function value means that a point is inside the convex region.
///
/// There are several methods to define the set of planes. The most general is
/// to supply an instance of vtkPoints and an instance of vtkDataArray. (The
/// points define a point on the plane, and the normals corresponding plane
/// normals.) Two other specialized ways are to 1) supply six planes defining
/// the view frustrum of a camera, and 2) provide a bounding box.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitBoolean vtkSpheres vtkFrustrumSource vtkCamera
/// </seealso>
public class vtkPlanes : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlanes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlanes()
	{
		MRClassNameKey = "class vtkPlanes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlanes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlanes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlanes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkPlanes New()
	{
		vtkPlanes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlanes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkPlanes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlanes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkPlanes_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate plane equations. Return largest value (i.e., an intersection
	/// operation between all planes).
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkPlanes_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlanes_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

	/// <summary>
	/// Evaluate planes gradient.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr n)
	{
		vtkPlanes_EvaluateGradient_02(GetCppThis(), x, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlanes_GetNormals_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a list of normal vectors for the planes. There is a one-to-one
	/// correspondence between plane points and plane normals.
	/// </summary>
	public virtual vtkDataArray GetNormals()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlanes_GetNormals_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlanes_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlanes_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlanes_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlanes_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlanes_GetNumberOfPlanes_06(HandleRef pThis);

	/// <summary>
	/// Return the number of planes in the set of planes.
	/// </summary>
	public int GetNumberOfPlanes()
	{
		return vtkPlanes_GetNumberOfPlanes_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlanes_GetPlane_07(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create and return a pointer to a vtkPlane object at the ith
	/// position. Asking for a plane outside the allowable range returns nullptr.
	/// This method always returns the same object.
	/// Use GetPlane(int i, vtkPlane *plane) instead.
	/// </summary>
	public vtkPlane GetPlane(int i)
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlanes_GetPlane_07(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlanes_GetPlane_08(HandleRef pThis, int i, HandleRef plane);

	/// <summary>
	/// If i is within the allowable range, mutates the given plane's
	/// Normal and Origin to match the vtkPlane object at the ith
	/// position. Does nothing if i is outside the allowable range.
	/// </summary>
	public void GetPlane(int i, vtkPlane plane)
	{
		vtkPlanes_GetPlane_08(GetCppThis(), i, plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlanes_GetPoints_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a list of points defining points through which the planes pass.
	/// </summary>
	public virtual vtkPoints GetPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlanes_GetPoints_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlanes_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlanes_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlanes_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlanes_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlanes_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkPlanes NewInstance()
	{
		vtkPlanes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlanes_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlanes_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkPlanes SafeDownCast(vtkObjectBase o)
	{
		vtkPlanes vtkPlanes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlanes_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlanes2 = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlanes2.Register(null);
			}
		}
		return vtkPlanes2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlanes_SetBounds_15(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// An alternative method to specify six planes defined by a bounding box.
	/// The bounding box is a six-vector defined as (xmin,xmax,ymin,ymax,zmin,zmax).
	/// It defines six planes orthogonal to the x-y-z coordinate axes.
	/// </summary>
	public void SetBounds(IntPtr bounds)
	{
		vtkPlanes_SetBounds_15(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlanes_SetBounds_16(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// An alternative method to specify six planes defined by a bounding box.
	/// The bounding box is a six-vector defined as (xmin,xmax,ymin,ymax,zmin,zmax).
	/// It defines six planes orthogonal to the x-y-z coordinate axes.
	/// </summary>
	public void SetBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkPlanes_SetBounds_16(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlanes_SetFrustumPlanes_17(HandleRef pThis, IntPtr planes);

	/// <summary>
	/// An alternative method to specify six planes defined by the camera view
	/// frustrum. See vtkCamera::GetFrustumPlanes() documentation.
	/// </summary>
	public void SetFrustumPlanes(IntPtr planes)
	{
		vtkPlanes_SetFrustumPlanes_17(GetCppThis(), planes);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlanes_SetNormals_18(HandleRef pThis, HandleRef normals);

	/// <summary>
	/// Specify a list of normal vectors for the planes. There is a one-to-one
	/// correspondence between plane points and plane normals.
	/// </summary>
	public void SetNormals(vtkDataArray normals)
	{
		vtkPlanes_SetNormals_18(GetCppThis(), normals?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlanes_SetPoints_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify a list of points defining points through which the planes pass.
	/// </summary>
	public virtual void SetPoints(vtkPoints arg0)
	{
		vtkPlanes_SetPoints_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
