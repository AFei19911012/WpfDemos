using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParametricConicSpiral
/// </summary>
/// <remarks>
///    Generate conic spiral surfaces that resemble sea-shells.
///
/// vtkParametricConicSpiral generates conic spiral surfaces. These can resemble sea shells, or
/// may look like a torus "eating" its own tail.
///
/// For further information about this surface, please consult the
/// technical description "Parametric surfaces" in http://www.vtk.org/publications
/// in the "VTK Technical Documents" section in the VTk.org web pages.
///
/// @par Thanks:
/// Andrew Maclean andrew.amaclean@gmail.com for creating and contributing the
/// class.
///
/// </remarks>
public class vtkParametricConicSpiral : vtkParametricFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParametricConicSpiral";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParametricConicSpiral()
	{
		MRClassNameKey = "class vtkParametricConicSpiral";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricConicSpiral"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParametricConicSpiral(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricConicSpiral_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a conic spiral surface with the following parameters:
	/// MinimumU = 0, MaximumU = 2Pi,
	/// MinimumV = 0, MaximumV = 2Pi,
	/// JoinU = 0, JoinV = 0,
	/// TwistU = 0, TwistV = 0,
	/// ClockwiseOrdering = 0,
	/// DerivativesAvailable = 1,
	/// A = 0.2, B = 1.0, C = 0.1, N = 2.
	/// </summary>
	public new static vtkParametricConicSpiral New()
	{
		vtkParametricConicSpiral result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricConicSpiral_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricConicSpiral)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a conic spiral surface with the following parameters:
	/// MinimumU = 0, MaximumU = 2Pi,
	/// MinimumV = 0, MaximumV = 2Pi,
	/// JoinU = 0, JoinV = 0,
	/// TwistU = 0, TwistV = 0,
	/// ClockwiseOrdering = 0,
	/// DerivativesAvailable = 1,
	/// A = 0.2, B = 1.0, C = 0.1, N = 2.
	/// </summary>
	public vtkParametricConicSpiral()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParametricConicSpiral_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkParametricConicSpiral_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

	/// <summary>
	/// A conic spiral surface.
	///
	/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
	/// as Pt. It also returns the partial derivatives Du and Dv.
	/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
	/// Then the normal is \f$N = Du X Dv\f$ .
	/// </summary>
	public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
	{
		vtkParametricConicSpiral_Evaluate_01(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricConicSpiral_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

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
		return vtkParametricConicSpiral_EvaluateScalar_02(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricConicSpiral_GetA_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the scale factor.
	/// Default = 0.2
	/// </summary>
	public virtual double GetA()
	{
		return vtkParametricConicSpiral_GetA_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricConicSpiral_GetB_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the A function coefficient.
	/// See the definition in Parametric surfaces referred to above.
	/// Default is 1.
	/// </summary>
	public virtual double GetB()
	{
		return vtkParametricConicSpiral_GetB_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricConicSpiral_GetC_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the B function coefficient.
	/// See the definition in Parametric surfaces referred to above.
	/// Default is 0.1.
	/// </summary>
	public virtual double GetC()
	{
		return vtkParametricConicSpiral_GetC_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricConicSpiral_GetDimension_06(HandleRef pThis);

	/// <summary>
	/// Return the parametric dimension of the class.
	/// </summary>
	public override int GetDimension()
	{
		return vtkParametricConicSpiral_GetDimension_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricConicSpiral_GetN_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the C function coefficient.
	/// See the definition in Parametric surfaces referred to above.
	/// Default is 2.
	/// </summary>
	public virtual double GetN()
	{
		return vtkParametricConicSpiral_GetN_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricConicSpiral_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParametricConicSpiral_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricConicSpiral_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParametricConicSpiral_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricConicSpiral_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParametricConicSpiral_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricConicSpiral_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParametricConicSpiral_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricConicSpiral_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParametricConicSpiral NewInstance()
	{
		vtkParametricConicSpiral result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricConicSpiral_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricConicSpiral)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricConicSpiral_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParametricConicSpiral SafeDownCast(vtkObjectBase o)
	{
		vtkParametricConicSpiral vtkParametricConicSpiral2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricConicSpiral_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParametricConicSpiral2 = (vtkParametricConicSpiral)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParametricConicSpiral2.Register(null);
			}
		}
		return vtkParametricConicSpiral2;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricConicSpiral_SetA_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scale factor.
	/// Default = 0.2
	/// </summary>
	public virtual void SetA(double _arg)
	{
		vtkParametricConicSpiral_SetA_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricConicSpiral_SetB_16(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the A function coefficient.
	/// See the definition in Parametric surfaces referred to above.
	/// Default is 1.
	/// </summary>
	public virtual void SetB(double _arg)
	{
		vtkParametricConicSpiral_SetB_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricConicSpiral_SetC_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the B function coefficient.
	/// See the definition in Parametric surfaces referred to above.
	/// Default is 0.1.
	/// </summary>
	public virtual void SetC(double _arg)
	{
		vtkParametricConicSpiral_SetC_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricConicSpiral_SetN_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the C function coefficient.
	/// See the definition in Parametric surfaces referred to above.
	/// Default is 2.
	/// </summary>
	public virtual void SetN(double _arg)
	{
		vtkParametricConicSpiral_SetN_18(GetCppThis(), _arg);
	}
}
