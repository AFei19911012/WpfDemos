using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParametricSuperEllipsoid
/// </summary>
/// <remarks>
///    Generate a superellipsoid.
///
/// vtkParametricSuperEllipsoid generates a superellipsoid.  A superellipsoid
/// is a versatile primitive that is controlled by two parameters n1 and
/// n2. As special cases it can represent a sphere, square box, and closed
/// cylindrical can.
///
/// For further information about this surface, please consult the
/// technical description "Parametric surfaces" in http://www.vtk.org/publications
/// in the "VTK Technical Documents" section in the VTk.org web pages.
///
/// Also see: http://paulbourke.net/geometry/superellipse/
///
/// @warning
/// Care needs to be taken specifying the bounds correctly. You may need to
/// carefully adjust MinimumU, MinimumV, MaximumU, MaximumV.
///
/// @par Thanks:
/// Andrew Maclean andrew.amaclean@gmail.com for creating and contributing the
/// class.
///
/// </remarks>
public class vtkParametricSuperEllipsoid : vtkParametricFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParametricSuperEllipsoid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParametricSuperEllipsoid()
	{
		MRClassNameKey = "class vtkParametricSuperEllipsoid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricSuperEllipsoid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParametricSuperEllipsoid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSuperEllipsoid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a superellipsoid with the following parameters:
	/// MinimumU = -Pi, MaximumU = Pi,
	/// MinimumV = -Pi/2, MaximumV = Pi/2,
	/// JoinU = 0, JoinV = 0,
	/// TwistU = 0, TwistV = 0,
	/// ClockwiseOrdering = 0,
	/// DerivativesAvailable = 0,
	/// N1 = 1, N2 = 1, XRadius = 1, YRadius = 1,
	/// ZRadius = 1, a sphere in this case.
	/// </summary>
	public new static vtkParametricSuperEllipsoid New()
	{
		vtkParametricSuperEllipsoid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSuperEllipsoid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricSuperEllipsoid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a superellipsoid with the following parameters:
	/// MinimumU = -Pi, MaximumU = Pi,
	/// MinimumV = -Pi/2, MaximumV = Pi/2,
	/// JoinU = 0, JoinV = 0,
	/// TwistU = 0, TwistV = 0,
	/// ClockwiseOrdering = 0,
	/// DerivativesAvailable = 0,
	/// N1 = 1, N2 = 1, XRadius = 1, YRadius = 1,
	/// ZRadius = 1, a sphere in this case.
	/// </summary>
	public vtkParametricSuperEllipsoid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParametricSuperEllipsoid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperEllipsoid_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

	/// <summary>
	/// A superellipsoid.
	///
	/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
	/// as Pt. It also returns the partial derivatives Du and Dv.
	/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
	/// Then the normal is \f$N = Du X Dv\f$ .
	/// </summary>
	public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
	{
		vtkParametricSuperEllipsoid_Evaluate_01(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperEllipsoid_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

	/// <summary>
	/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
	///
	/// uvw are the parameters with Pt being the cartesian point,
	/// Duvw are the derivatives of this point with respect to u, v and w.
	/// Pt, Duvw are obtained from Evaluate().
	///
	/// This function is only called if the ScalarMode has the value
	/// vtkParametricFunctionSource::SCALAR_FUNCTION_DEFINED
	///
	/// If the user does not need to calculate a scalar, then the
	/// instantiated function should return zero.
	/// </summary>
	public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
	{
		return vtkParametricSuperEllipsoid_EvaluateScalar_02(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSuperEllipsoid_GetDimension_03(HandleRef pThis);

	/// <summary>
	/// Return the parametric dimension of the class.
	/// </summary>
	public override int GetDimension()
	{
		return vtkParametricSuperEllipsoid_GetDimension_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperEllipsoid_GetN1_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the "squareness" parameter in the z axis.  Default is 1.
	/// </summary>
	public virtual double GetN1()
	{
		return vtkParametricSuperEllipsoid_GetN1_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperEllipsoid_GetN2_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the "squareness" parameter in the x-y plane. Default is 1.
	/// </summary>
	public virtual double GetN2()
	{
		return vtkParametricSuperEllipsoid_GetN2_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricSuperEllipsoid_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParametricSuperEllipsoid_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricSuperEllipsoid_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParametricSuperEllipsoid_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperEllipsoid_GetXRadius_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling factor for the x-axis. Default is 1.
	/// </summary>
	public virtual double GetXRadius()
	{
		return vtkParametricSuperEllipsoid_GetXRadius_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperEllipsoid_GetYRadius_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling factor for the y-axis. Default is 1.
	/// </summary>
	public virtual double GetYRadius()
	{
		return vtkParametricSuperEllipsoid_GetYRadius_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperEllipsoid_GetZRadius_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling factor for the z-axis. Default is 1.
	/// </summary>
	public virtual double GetZRadius()
	{
		return vtkParametricSuperEllipsoid_GetZRadius_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSuperEllipsoid_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParametricSuperEllipsoid_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSuperEllipsoid_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParametricSuperEllipsoid_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSuperEllipsoid_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParametricSuperEllipsoid NewInstance()
	{
		vtkParametricSuperEllipsoid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSuperEllipsoid_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricSuperEllipsoid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSuperEllipsoid_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParametricSuperEllipsoid SafeDownCast(vtkObjectBase o)
	{
		vtkParametricSuperEllipsoid vtkParametricSuperEllipsoid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSuperEllipsoid_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParametricSuperEllipsoid2 = (vtkParametricSuperEllipsoid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParametricSuperEllipsoid2.Register(null);
			}
		}
		return vtkParametricSuperEllipsoid2;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperEllipsoid_SetN1_16(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the "squareness" parameter in the z axis.  Default is 1.
	/// </summary>
	public virtual void SetN1(double _arg)
	{
		vtkParametricSuperEllipsoid_SetN1_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperEllipsoid_SetN2_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the "squareness" parameter in the x-y plane. Default is 1.
	/// </summary>
	public virtual void SetN2(double _arg)
	{
		vtkParametricSuperEllipsoid_SetN2_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperEllipsoid_SetXRadius_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling factor for the x-axis. Default is 1.
	/// </summary>
	public virtual void SetXRadius(double _arg)
	{
		vtkParametricSuperEllipsoid_SetXRadius_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperEllipsoid_SetYRadius_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling factor for the y-axis. Default is 1.
	/// </summary>
	public virtual void SetYRadius(double _arg)
	{
		vtkParametricSuperEllipsoid_SetYRadius_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperEllipsoid_SetZRadius_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling factor for the z-axis. Default is 1.
	/// </summary>
	public virtual void SetZRadius(double _arg)
	{
		vtkParametricSuperEllipsoid_SetZRadius_20(GetCppThis(), _arg);
	}
}
