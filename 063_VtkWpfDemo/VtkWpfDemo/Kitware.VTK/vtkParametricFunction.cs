using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParametricFunction
/// </summary>
/// <remarks>
///    abstract interface for parametric functions
///
/// vtkParametricFunction is an abstract interface for functions
/// defined by parametric mapping i.e. f(u,v,w)-&gt;(x,y,z) where
/// u_min &lt;= u &lt; u_max, v_min &lt;= v &lt; v_max, w_min &lt;= w &lt; w_max. (For
/// notational convenience, we will write f(u)-&gt;x and assume that
/// u means (u,v,w) and x means (x,y,z).)
///
/// The interface contains the pure virtual function, Evaluate(), that
/// generates a point and the derivatives at that point which are then used to
/// construct the surface. A second pure virtual function, EvaluateScalar(),
/// can be used to generate a scalar for the surface. Finally, the
/// GetDimension() virtual function is used to differentiate 1D, 2D, and 3D
/// parametric functions. Since this abstract class defines a pure virtual
/// API, its subclasses must implement the pure virtual functions
/// GetDimension(), Evaluate() and EvaluateScalar().
///
/// This class has also methods for defining a range of parametric values (u,v,w).
///
/// @par Thanks:
/// Andrew Maclean andrew.amaclean@gmail.com for creating and contributing the
/// class.
///
/// </remarks>
/// <seealso>
///
/// vtkParametricFunctionSource - tessellates a parametric function
///
///
/// Implementations of derived classes implementing non-orentable surfaces:
/// vtkParametricBoy vtkParametricCrossCap vtkParametricFigure8Klein
/// vtkParametricKlein vtkParametricMobius vtkParametricRoman
///
///
/// Implementations of derived classes implementing orientable surfaces:
/// vtkParametricConicSpiral vtkParametricDini vtkParametricEllipsoid
/// vtkParametricEnneper vtkParametricRandomHills vtkParametricSuperEllipsoid
/// vtkParametricSuperToroid vtkParametricTorus
///
/// </seealso>
public abstract class vtkParametricFunction : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParametricFunction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParametricFunction()
	{
		MRClassNameKey = "class vtkParametricFunction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricFunction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParametricFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkParametricFunction_ClockwiseOrderingOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which determines the ordering of the
	/// vertices forming the triangle strips. The ordering of the
	/// points being inserted into the triangle strip is important
	/// because it determines the direction of the normals for the
	/// lighting. If set, the ordering is clockwise, otherwise the
	/// ordering is anti-clockwise. Default is true (i.e. clockwise
	/// ordering).
	/// </summary>
	public virtual void ClockwiseOrderingOff()
	{
		vtkParametricFunction_ClockwiseOrderingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_ClockwiseOrderingOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which determines the ordering of the
	/// vertices forming the triangle strips. The ordering of the
	/// points being inserted into the triangle strip is important
	/// because it determines the direction of the normals for the
	/// lighting. If set, the ordering is clockwise, otherwise the
	/// ordering is anti-clockwise. Default is true (i.e. clockwise
	/// ordering).
	/// </summary>
	public virtual void ClockwiseOrderingOn()
	{
		vtkParametricFunction_ClockwiseOrderingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_DerivativesAvailableOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which determines whether derivatives are available
	/// from the parametric function (i.e., whether the Evaluate() method
	/// returns valid derivatives).
	/// </summary>
	public virtual void DerivativesAvailableOff()
	{
		vtkParametricFunction_DerivativesAvailableOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_DerivativesAvailableOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which determines whether derivatives are available
	/// from the parametric function (i.e., whether the Evaluate() method
	/// returns valid derivatives).
	/// </summary>
	public virtual void DerivativesAvailableOn()
	{
		vtkParametricFunction_DerivativesAvailableOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_Evaluate_05(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

	/// <summary>
	/// Performs the mapping \$f(uvw)-&gt;(Pt,Duvw)\$f.
	/// This is a pure virtual function that must be instantiated in
	/// a derived class.
	///
	/// uvw are the parameters, with u corresponding to uvw[0],
	/// v to uvw[1] and w to uvw[2] respectively. Pt is the returned Cartesian point,
	/// Duvw are the derivatives of this point with respect to u, v and w.
	/// Note that the first three values in Duvw are Du, the next three are Dv,
	/// and the final three are Dw. Du Dv Dw are the partial derivatives of the
	/// function at the point Pt with respect to u, v and w respectively.
	/// </summary>
	public virtual void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
	{
		vtkParametricFunction_Evaluate_05(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricFunction_EvaluateScalar_06(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

	/// <summary>
	/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
	/// This is a pure virtual function that must be instantiated in
	/// a derived class.
	///
	/// uvw are the parameters with Pt being the cartesian point,
	/// Duvw are the derivatives of this point with respect to u, v, and w.
	/// Pt, Duvw are obtained from Evaluate().
	/// </summary>
	public virtual double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
	{
		return vtkParametricFunction_EvaluateScalar_06(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetClockwiseOrdering_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which determines the ordering of the
	/// vertices forming the triangle strips. The ordering of the
	/// points being inserted into the triangle strip is important
	/// because it determines the direction of the normals for the
	/// lighting. If set, the ordering is clockwise, otherwise the
	/// ordering is anti-clockwise. Default is true (i.e. clockwise
	/// ordering).
	/// </summary>
	public virtual int GetClockwiseOrdering()
	{
		return vtkParametricFunction_GetClockwiseOrdering_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetClockwiseOrderingMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which determines the ordering of the
	/// vertices forming the triangle strips. The ordering of the
	/// points being inserted into the triangle strip is important
	/// because it determines the direction of the normals for the
	/// lighting. If set, the ordering is clockwise, otherwise the
	/// ordering is anti-clockwise. Default is true (i.e. clockwise
	/// ordering).
	/// </summary>
	public virtual int GetClockwiseOrderingMaxValue()
	{
		return vtkParametricFunction_GetClockwiseOrderingMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetClockwiseOrderingMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which determines the ordering of the
	/// vertices forming the triangle strips. The ordering of the
	/// points being inserted into the triangle strip is important
	/// because it determines the direction of the normals for the
	/// lighting. If set, the ordering is clockwise, otherwise the
	/// ordering is anti-clockwise. Default is true (i.e. clockwise
	/// ordering).
	/// </summary>
	public virtual int GetClockwiseOrderingMinValue()
	{
		return vtkParametricFunction_GetClockwiseOrderingMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetDerivativesAvailable_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which determines whether derivatives are available
	/// from the parametric function (i.e., whether the Evaluate() method
	/// returns valid derivatives).
	/// </summary>
	public virtual int GetDerivativesAvailable()
	{
		return vtkParametricFunction_GetDerivativesAvailable_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetDerivativesAvailableMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which determines whether derivatives are available
	/// from the parametric function (i.e., whether the Evaluate() method
	/// returns valid derivatives).
	/// </summary>
	public virtual int GetDerivativesAvailableMaxValue()
	{
		return vtkParametricFunction_GetDerivativesAvailableMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetDerivativesAvailableMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which determines whether derivatives are available
	/// from the parametric function (i.e., whether the Evaluate() method
	/// returns valid derivatives).
	/// </summary>
	public virtual int GetDerivativesAvailableMinValue()
	{
		return vtkParametricFunction_GetDerivativesAvailableMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetDimension_13(HandleRef pThis);

	/// <summary>
	/// Return the dimension of parametric space. Depending on the dimension,
	/// then the (u,v,w) parameters and associated information (e.g., derivates)
	/// have meaning. For example, if the dimension of the function is one, then
	/// u[0] and Duvw[0...2] have meaning.
	/// This is a pure virtual function that must be instantiated in
	/// a derived class.
	/// </summary>
	public virtual int GetDimension()
	{
		return vtkParametricFunction_GetDimension_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetJoinU_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to the last one.
	/// </summary>
	public virtual int GetJoinU()
	{
		return vtkParametricFunction_GetJoinU_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetJoinUMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to the last one.
	/// </summary>
	public virtual int GetJoinUMaxValue()
	{
		return vtkParametricFunction_GetJoinUMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetJoinUMinValue_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to the last one.
	/// </summary>
	public virtual int GetJoinUMinValue()
	{
		return vtkParametricFunction_GetJoinUMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetJoinV_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual int GetJoinV()
	{
		return vtkParametricFunction_GetJoinV_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetJoinVMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual int GetJoinVMaxValue()
	{
		return vtkParametricFunction_GetJoinVMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetJoinVMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual int GetJoinVMinValue()
	{
		return vtkParametricFunction_GetJoinVMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetJoinW_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual int GetJoinW()
	{
		return vtkParametricFunction_GetJoinW_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetJoinWMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual int GetJoinWMaxValue()
	{
		return vtkParametricFunction_GetJoinWMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetJoinWMinValue_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual int GetJoinWMinValue()
	{
		return vtkParametricFunction_GetJoinWMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricFunction_GetMaximumU_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum u-value.
	/// </summary>
	public virtual double GetMaximumU()
	{
		return vtkParametricFunction_GetMaximumU_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricFunction_GetMaximumV_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum v-value.
	/// </summary>
	public virtual double GetMaximumV()
	{
		return vtkParametricFunction_GetMaximumV_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricFunction_GetMaximumW_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum w-value.
	/// </summary>
	public virtual double GetMaximumW()
	{
		return vtkParametricFunction_GetMaximumW_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricFunction_GetMinimumU_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum u-value.
	/// </summary>
	public virtual double GetMinimumU()
	{
		return vtkParametricFunction_GetMinimumU_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricFunction_GetMinimumV_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum v-value.
	/// </summary>
	public virtual double GetMinimumV()
	{
		return vtkParametricFunction_GetMinimumV_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricFunction_GetMinimumW_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum w-value.
	/// </summary>
	public virtual double GetMinimumW()
	{
		return vtkParametricFunction_GetMinimumW_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricFunction_GetNumberOfGenerationsFromBase_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParametricFunction_GetNumberOfGenerationsFromBase_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricFunction_GetNumberOfGenerationsFromBaseType_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParametricFunction_GetNumberOfGenerationsFromBaseType_30(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetTwistU_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to
	/// the last one with a twist.
	/// JoinU must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual int GetTwistU()
	{
		return vtkParametricFunction_GetTwistU_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetTwistUMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to
	/// the last one with a twist.
	/// JoinU must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual int GetTwistUMaxValue()
	{
		return vtkParametricFunction_GetTwistUMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetTwistUMinValue_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to
	/// the last one with a twist.
	/// JoinU must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual int GetTwistUMinValue()
	{
		return vtkParametricFunction_GetTwistUMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetTwistV_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinV must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual int GetTwistV()
	{
		return vtkParametricFunction_GetTwistV_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetTwistVMaxValue_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinV must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual int GetTwistVMaxValue()
	{
		return vtkParametricFunction_GetTwistVMaxValue_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetTwistVMinValue_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinV must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual int GetTwistVMinValue()
	{
		return vtkParametricFunction_GetTwistVMinValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetTwistW_37(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinW must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual int GetTwistW()
	{
		return vtkParametricFunction_GetTwistW_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetTwistWMaxValue_38(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinW must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual int GetTwistWMaxValue()
	{
		return vtkParametricFunction_GetTwistWMaxValue_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_GetTwistWMinValue_39(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinW must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual int GetTwistWMinValue()
	{
		return vtkParametricFunction_GetTwistWMinValue_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_IsA_40(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParametricFunction_IsA_40(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunction_IsTypeOf_41(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParametricFunction_IsTypeOf_41(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_JoinUOff_42(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to the last one.
	/// </summary>
	public virtual void JoinUOff()
	{
		vtkParametricFunction_JoinUOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_JoinUOn_43(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to the last one.
	/// </summary>
	public virtual void JoinUOn()
	{
		vtkParametricFunction_JoinUOn_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_JoinVOff_44(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual void JoinVOff()
	{
		vtkParametricFunction_JoinVOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_JoinVOn_45(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual void JoinVOn()
	{
		vtkParametricFunction_JoinVOn_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_JoinWOff_46(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual void JoinWOff()
	{
		vtkParametricFunction_JoinWOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_JoinWOn_47(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual void JoinWOn()
	{
		vtkParametricFunction_JoinWOn_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricFunction_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParametricFunction NewInstance()
	{
		vtkParametricFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricFunction_NewInstance_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricFunction_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParametricFunction SafeDownCast(vtkObjectBase o)
	{
		vtkParametricFunction vtkParametricFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricFunction_SafeDownCast_49(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParametricFunction2 = (vtkParametricFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParametricFunction2.Register(null);
			}
		}
		return vtkParametricFunction2;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetClockwiseOrdering_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which determines the ordering of the
	/// vertices forming the triangle strips. The ordering of the
	/// points being inserted into the triangle strip is important
	/// because it determines the direction of the normals for the
	/// lighting. If set, the ordering is clockwise, otherwise the
	/// ordering is anti-clockwise. Default is true (i.e. clockwise
	/// ordering).
	/// </summary>
	public virtual void SetClockwiseOrdering(int _arg)
	{
		vtkParametricFunction_SetClockwiseOrdering_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetDerivativesAvailable_51(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which determines whether derivatives are available
	/// from the parametric function (i.e., whether the Evaluate() method
	/// returns valid derivatives).
	/// </summary>
	public virtual void SetDerivativesAvailable(int _arg)
	{
		vtkParametricFunction_SetDerivativesAvailable_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetJoinU_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to the last one.
	/// </summary>
	public virtual void SetJoinU(int _arg)
	{
		vtkParametricFunction_SetJoinU_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetJoinV_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual void SetJoinV(int _arg)
	{
		vtkParametricFunction_SetJoinV_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetJoinW_54(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which joins the ends of the triangle strips.
	/// </summary>
	public virtual void SetJoinW(int _arg)
	{
		vtkParametricFunction_SetJoinW_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetMaximumU_55(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the maximum u-value.
	/// </summary>
	public virtual void SetMaximumU(double _arg)
	{
		vtkParametricFunction_SetMaximumU_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetMaximumV_56(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the maximum v-value.
	/// </summary>
	public virtual void SetMaximumV(double _arg)
	{
		vtkParametricFunction_SetMaximumV_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetMaximumW_57(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the maximum w-value.
	/// </summary>
	public virtual void SetMaximumW(double _arg)
	{
		vtkParametricFunction_SetMaximumW_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetMinimumU_58(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the minimum u-value.
	/// </summary>
	public virtual void SetMinimumU(double _arg)
	{
		vtkParametricFunction_SetMinimumU_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetMinimumV_59(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the minimum v-value.
	/// </summary>
	public virtual void SetMinimumV(double _arg)
	{
		vtkParametricFunction_SetMinimumV_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetMinimumW_60(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the minimum w-value.
	/// </summary>
	public virtual void SetMinimumW(double _arg)
	{
		vtkParametricFunction_SetMinimumW_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetTwistU_61(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to
	/// the last one with a twist.
	/// JoinU must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual void SetTwistU(int _arg)
	{
		vtkParametricFunction_SetTwistU_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetTwistV_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinV must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual void SetTwistV(int _arg)
	{
		vtkParametricFunction_SetTwistV_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_SetTwistW_63(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinW must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual void SetTwistW(int _arg)
	{
		vtkParametricFunction_SetTwistW_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_TwistUOff_64(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to
	/// the last one with a twist.
	/// JoinU must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual void TwistUOff()
	{
		vtkParametricFunction_TwistUOff_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_TwistUOn_65(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the first triangle strip to
	/// the last one with a twist.
	/// JoinU must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual void TwistUOn()
	{
		vtkParametricFunction_TwistUOn_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_TwistVOff_66(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinV must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual void TwistVOff()
	{
		vtkParametricFunction_TwistVOff_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_TwistVOn_67(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinV must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual void TwistVOn()
	{
		vtkParametricFunction_TwistVOn_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_TwistWOff_68(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinW must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual void TwistWOff()
	{
		vtkParametricFunction_TwistWOff_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunction_TwistWOn_69(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which joins the ends of the
	/// triangle strips with a twist.
	/// JoinW must also be set if this is set.
	/// Used when building some non-orientable surfaces.
	/// </summary>
	public virtual void TwistWOn()
	{
		vtkParametricFunction_TwistWOn_69(GetCppThis());
	}
}
