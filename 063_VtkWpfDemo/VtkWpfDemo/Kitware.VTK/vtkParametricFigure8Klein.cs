using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParametricFigure8Klein
/// </summary>
/// <remarks>
///    Generate a figure-8 Klein bottle.
///
/// vtkParametricFigure8Klein generates a figure-8 Klein bottle.  A Klein bottle
/// is a closed surface with no interior and only one surface.  It is
/// unrealisable in 3 dimensions without intersecting surfaces.  It can be
/// realised in 4 dimensions by considering the map \f$F:R^2 \rightarrow R^4\f$  given by:
///
/// - \f$f(u,v) = ((r*cos(v)+a)*cos(u),(r*cos(v)+a)*sin(u),r*sin(v)*cos(u/2),r*sin(v)*sin(u/2))\f$
///
/// This representation of the immersion in \f$R^3\f$ is formed by taking two Mobius
/// strips and joining them along their boundaries, this is the so called
/// "Figure-8 Klein Bottle"
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
public class vtkParametricFigure8Klein : vtkParametricFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParametricFigure8Klein";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParametricFigure8Klein()
	{
		MRClassNameKey = "class vtkParametricFigure8Klein";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricFigure8Klein"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParametricFigure8Klein(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricFigure8Klein_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a figure-8 Klein Bottle with the following parameters:
	/// MinimumU = -Pi, MaximumU = Pi,
	/// MinimumV = -Pi, MaximumV = Pi,
	/// JoinU = 1, JoinV = 1,
	/// TwistU = 0, TwistV = 0,
	/// ClockwiseOrdering = 0,
	/// DerivativesAvailable = 1,
	/// Radius = 1
	/// </summary>
	public new static vtkParametricFigure8Klein New()
	{
		vtkParametricFigure8Klein result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricFigure8Klein_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricFigure8Klein)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a figure-8 Klein Bottle with the following parameters:
	/// MinimumU = -Pi, MaximumU = Pi,
	/// MinimumV = -Pi, MaximumV = Pi,
	/// JoinU = 1, JoinV = 1,
	/// TwistU = 0, TwistV = 0,
	/// ClockwiseOrdering = 0,
	/// DerivativesAvailable = 1,
	/// Radius = 1
	/// </summary>
	public vtkParametricFigure8Klein()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParametricFigure8Klein_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkParametricFigure8Klein_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

	/// <summary>
	/// A Figure-8 Klein bottle.
	///
	/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
	/// as Pt. It also returns the partial derivatives Du and Dv.
	/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
	/// Then the normal is \f$N = Du X Dv\f$ .
	/// </summary>
	public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
	{
		vtkParametricFigure8Klein_Evaluate_01(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricFigure8Klein_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

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
		return vtkParametricFigure8Klein_EvaluateScalar_02(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFigure8Klein_GetDimension_03(HandleRef pThis);

	/// <summary>
	/// Return the parametric dimension of the class.
	/// </summary>
	public override int GetDimension()
	{
		return vtkParametricFigure8Klein_GetDimension_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricFigure8Klein_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParametricFigure8Klein_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricFigure8Klein_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParametricFigure8Klein_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricFigure8Klein_GetRadius_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the radius of the bottle. Default is 1.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkParametricFigure8Klein_GetRadius_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFigure8Klein_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParametricFigure8Klein_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFigure8Klein_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParametricFigure8Klein_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricFigure8Klein_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParametricFigure8Klein NewInstance()
	{
		vtkParametricFigure8Klein result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricFigure8Klein_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricFigure8Klein)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricFigure8Klein_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParametricFigure8Klein SafeDownCast(vtkObjectBase o)
	{
		vtkParametricFigure8Klein vtkParametricFigure8Klein2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricFigure8Klein_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParametricFigure8Klein2 = (vtkParametricFigure8Klein)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParametricFigure8Klein2.Register(null);
			}
		}
		return vtkParametricFigure8Klein2;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFigure8Klein_SetRadius_12(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the radius of the bottle. Default is 1.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkParametricFigure8Klein_SetRadius_12(GetCppThis(), _arg);
	}
}
