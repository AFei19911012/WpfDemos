using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParametricSuperToroid
/// </summary>
/// <remarks>
///    Generate a supertoroid.
///
/// vtkParametricSuperToroid generates a supertoroid.  Essentially a
/// supertoroid is a torus with the sine and cosine terms raised to a power.
/// A supertoroid is a versatile primitive that is controlled by four
/// parameters r0, r1, n1 and n2. r0, r1 determine the type of torus whilst
/// the value of n1 determines the shape of the torus ring and n2 determines
/// the shape of the cross section of the ring. It is the different values of
/// these powers which give rise to a family of 3D shapes that are all
/// basically toroidal in shape.
///
/// For further information about this surface, please consult the
/// technical description "Parametric surfaces" in http://www.vtk.org/publications
/// in the "VTK Technical Documents" section in the VTk.org web pages.
///
/// Also see: http://paulbourke.net/geometry/torus/#super.
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
public class vtkParametricSuperToroid : vtkParametricFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParametricSuperToroid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParametricSuperToroid()
	{
		MRClassNameKey = "class vtkParametricSuperToroid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricSuperToroid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParametricSuperToroid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSuperToroid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a supertoroid with the following parameters:
	/// MinimumU = 0, MaximumU = 2*Pi,
	/// MinimumV = 0, MaximumV = 2*Pi,
	/// JoinU = 0, JoinV = 0,
	/// TwistU = 0, TwistV = 0,
	/// ClockwiseOrdering = 1,
	/// DerivativesAvailable = 0,
	/// RingRadius = 1, CrossSectionRadius = 0.5,
	/// N1 = 1, N2 = 1, XRadius = 1,
	/// YRadius = 1, ZRadius = 1, a torus in this case.
	/// </summary>
	public new static vtkParametricSuperToroid New()
	{
		vtkParametricSuperToroid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSuperToroid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricSuperToroid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a supertoroid with the following parameters:
	/// MinimumU = 0, MaximumU = 2*Pi,
	/// MinimumV = 0, MaximumV = 2*Pi,
	/// JoinU = 0, JoinV = 0,
	/// TwistU = 0, TwistV = 0,
	/// ClockwiseOrdering = 1,
	/// DerivativesAvailable = 0,
	/// RingRadius = 1, CrossSectionRadius = 0.5,
	/// N1 = 1, N2 = 1, XRadius = 1,
	/// YRadius = 1, ZRadius = 1, a torus in this case.
	/// </summary>
	public vtkParametricSuperToroid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParametricSuperToroid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkParametricSuperToroid_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

	/// <summary>
	/// A supertoroid.
	///
	/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
	/// as Pt. It also returns the partial derivatives Du and Dv.
	/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
	/// Then the normal is \f$N = Du X Dv\f$ .
	/// </summary>
	public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
	{
		vtkParametricSuperToroid_Evaluate_01(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperToroid_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

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
		return vtkParametricSuperToroid_EvaluateScalar_02(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperToroid_GetCrossSectionRadius_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the radius of the cross section of ring of the supertoroid.
	/// Default = 0.5.
	/// </summary>
	public virtual double GetCrossSectionRadius()
	{
		return vtkParametricSuperToroid_GetCrossSectionRadius_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSuperToroid_GetDimension_04(HandleRef pThis);

	/// <summary>
	/// Return the parametric dimension of the class.
	/// </summary>
	public override int GetDimension()
	{
		return vtkParametricSuperToroid_GetDimension_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperToroid_GetN1_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the shape of the torus ring.  Default is 1.
	/// </summary>
	public virtual double GetN1()
	{
		return vtkParametricSuperToroid_GetN1_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperToroid_GetN2_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the shape of the cross section of the ring. Default is 1.
	/// </summary>
	public virtual double GetN2()
	{
		return vtkParametricSuperToroid_GetN2_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricSuperToroid_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParametricSuperToroid_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricSuperToroid_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParametricSuperToroid_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperToroid_GetRingRadius_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the radius from the center to the middle of the ring of the
	/// supertoroid. Default is 1.
	/// </summary>
	public virtual double GetRingRadius()
	{
		return vtkParametricSuperToroid_GetRingRadius_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperToroid_GetXRadius_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling factor for the x-axis. Default is 1.
	/// </summary>
	public virtual double GetXRadius()
	{
		return vtkParametricSuperToroid_GetXRadius_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperToroid_GetYRadius_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling factor for the y-axis. Default is 1.
	/// </summary>
	public virtual double GetYRadius()
	{
		return vtkParametricSuperToroid_GetYRadius_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSuperToroid_GetZRadius_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling factor for the z-axis. Default is 1.
	/// </summary>
	public virtual double GetZRadius()
	{
		return vtkParametricSuperToroid_GetZRadius_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSuperToroid_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParametricSuperToroid_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSuperToroid_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParametricSuperToroid_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSuperToroid_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParametricSuperToroid NewInstance()
	{
		vtkParametricSuperToroid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSuperToroid_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricSuperToroid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSuperToroid_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParametricSuperToroid SafeDownCast(vtkObjectBase o)
	{
		vtkParametricSuperToroid vtkParametricSuperToroid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSuperToroid_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParametricSuperToroid2 = (vtkParametricSuperToroid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParametricSuperToroid2.Register(null);
			}
		}
		return vtkParametricSuperToroid2;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperToroid_SetCrossSectionRadius_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the radius of the cross section of ring of the supertoroid.
	/// Default = 0.5.
	/// </summary>
	public virtual void SetCrossSectionRadius(double _arg)
	{
		vtkParametricSuperToroid_SetCrossSectionRadius_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperToroid_SetN1_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the shape of the torus ring.  Default is 1.
	/// </summary>
	public virtual void SetN1(double _arg)
	{
		vtkParametricSuperToroid_SetN1_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperToroid_SetN2_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the shape of the cross section of the ring. Default is 1.
	/// </summary>
	public virtual void SetN2(double _arg)
	{
		vtkParametricSuperToroid_SetN2_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperToroid_SetRingRadius_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the radius from the center to the middle of the ring of the
	/// supertoroid. Default is 1.
	/// </summary>
	public virtual void SetRingRadius(double _arg)
	{
		vtkParametricSuperToroid_SetRingRadius_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperToroid_SetXRadius_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling factor for the x-axis. Default is 1.
	/// </summary>
	public virtual void SetXRadius(double _arg)
	{
		vtkParametricSuperToroid_SetXRadius_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperToroid_SetYRadius_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling factor for the y-axis. Default is 1.
	/// </summary>
	public virtual void SetYRadius(double _arg)
	{
		vtkParametricSuperToroid_SetYRadius_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSuperToroid_SetZRadius_24(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling factor for the z-axis. Default is 1.
	/// </summary>
	public virtual void SetZRadius(double _arg)
	{
		vtkParametricSuperToroid_SetZRadius_24(GetCppThis(), _arg);
	}
}
