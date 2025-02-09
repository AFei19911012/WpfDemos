using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolynomialSolversUnivariate
/// </summary>
/// <remarks>
///    polynomial solvers
///
/// vtkPolynomialSolversUnivariate provides solvers for
/// univariate polynomial equations with real coefficients.
/// The Tartaglia-Cardan and Ferrari solvers work on polynomials of fixed
/// degree 3 and 4, respectively.
/// The Lin-Bairstow and Sturm solvers work on polynomials of arbitrary
/// degree. The Sturm solver is the most robust solver but only reports
/// roots within an interval and does not report multiplicities.
/// The Lin-Bairstow solver reports multiplicities.
///
/// For difficult polynomials, you may wish to use FilterRoots to
/// eliminate some of the roots reported by the Sturm solver.
/// FilterRoots evaluates the derivatives near each root to
/// eliminate cases where a local minimum or maximum is close
/// to zero.
///
/// @par Thanks:
/// Thanks to Philippe Pebay, Korben Rusek, David Thompson, and Maurice Rojas
/// for implementing these solvers.
/// </remarks>
public class vtkPolynomialSolversUnivariate : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolynomialSolversUnivariate";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolynomialSolversUnivariate()
	{
		MRClassNameKey = "class vtkPolynomialSolversUnivariate";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolynomialSolversUnivariate"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolynomialSolversUnivariate(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolynomialSolversUnivariate_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolynomialSolversUnivariate New()
	{
		vtkPolynomialSolversUnivariate result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolynomialSolversUnivariate_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolynomialSolversUnivariate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPolynomialSolversUnivariate()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolynomialSolversUnivariate_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_FerrariSolve_01(IntPtr c, IntPtr r, IntPtr m, double tol);

	/// <summary>
	/// Algebraically extracts REAL roots of the quartic polynomial with
	/// REAL coefficients X^4 + c[0] X^3 + c[1] X^2 + c[2] X + c[3]
	/// and stores them (when they exist) and their respective multiplicities
	/// in the \a r and \a m arrays, based on Ferrari's method.
	/// Some numerical noise can be filtered by the use of a tolerance \a tol
	/// instead of equality with 0 (one can use, e.g., VTK_DBL_EPSILON).
	/// Returns the number of roots.
	/// Warning: it is the user's responsibility to pass a non-negative \a tol.
	/// </summary>
	public static int FerrariSolve(IntPtr c, IntPtr r, IntPtr m, double tol)
	{
		return vtkPolynomialSolversUnivariate_FerrariSolve_01(c, r, m, tol);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_FilterRoots_02(IntPtr P, int d, IntPtr upperBnds, int rootcount, double diameter);

	/// <summary>
	/// This uses the derivative sequence to filter possible roots of a polynomial.
	/// First it sorts the roots and removes any duplicates.
	/// If the number of sign changes of the derivative sequence at a root at
	/// upperBnds[i] == that at upperBnds[i]  - diameter then the i^th value is
	/// removed from upperBnds. It returns the new number of roots.
	/// </summary>
	public static int FilterRoots(IntPtr P, int d, IntPtr upperBnds, int rootcount, double diameter)
	{
		return vtkPolynomialSolversUnivariate_FilterRoots_02(P, d, upperBnds, rootcount, diameter);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolynomialSolversUnivariate_GetDivisionTolerance_03();

	/// <summary>
	/// Set/get the tolerance used when performing polynomial Euclidean division
	/// to find polynomial roots. This tolerance is used to decide whether the
	/// coefficient(s) of a polynomial remainder are close enough to
	/// zero to be neglected.
	/// </summary>
	public static double GetDivisionTolerance()
	{
		return vtkPolynomialSolversUnivariate_GetDivisionTolerance_03();
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolynomialSolversUnivariate_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolynomialSolversUnivariate_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolynomialSolversUnivariate_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolynomialSolversUnivariate_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_HabichtBisectionSolve_06(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol);

	/// <summary>
	/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
	/// \f[
	/// P[0] X^d + ... + P[d-1] X + P[d]
	/// \f]
	/// in ]\a a[0] ; \a a[1]] using the Habicht sequence (polynomial
	/// coefficients are REAL) and returns the count \a nr. All roots are bracketed
	/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
	/// Returns -1 if anything went wrong (such as: polynomial does not have
	/// degree \a d, the interval provided by the other is absurd, etc.).
	///
	/// \a intervalType specifies the search interval as follows:
	/// 0 = 00 = ]a,b[
	/// 1 = 10 = [a,b[
	/// 2 = 01 = ]a,b]
	/// 3 = 11 = [a,b]
	/// This defaults to 0.
	///
	/// The last non-zero item in the Habicht sequence is the gcd of P and P'. The
	/// parameter divideGCD specifies whether the program should attempt to divide
	/// by the gcd and run again. It works better with polynomials known to have
	/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
	/// GCD, if applicable. This defaults to 0.
	///
	/// Compared to the Sturm solver the Habicht solver is slower,
	/// although both are O(d^2). The Habicht solver has the added benefit
	/// that it has a built in mechanism to keep the leading coefficients of the
	/// result from polynomial division bounded above and below in absolute value.
	/// This will tend to keep the coefficients of the polynomials in the sequence
	/// from zeroing out prematurely or becoming infinite.
	///
	/// Constructing the Habicht sequence is O(d^2) in both time and space.
	///
	/// Warning: it is the user's responsibility to make sure the \a upperBnds
	/// array is large enough to contain the maximal number of expected roots.
	/// Note that \a nr is smaller or equal to the actual number of roots in
	/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
	/// array is large enough to contain the maximal number of expected upper bounds.
	/// </summary>
	public static int HabichtBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol)
	{
		return vtkPolynomialSolversUnivariate_HabichtBisectionSolve_06(P, d, a, upperBnds, tol);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_HabichtBisectionSolve_07(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType);

	/// <summary>
	/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
	/// \f[
	/// P[0] X^d + ... + P[d-1] X + P[d]
	/// \f]
	/// in ]\a a[0] ; \a a[1]] using the Habicht sequence (polynomial
	/// coefficients are REAL) and returns the count \a nr. All roots are bracketed
	/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
	/// Returns -1 if anything went wrong (such as: polynomial does not have
	/// degree \a d, the interval provided by the other is absurd, etc.).
	///
	/// \a intervalType specifies the search interval as follows:
	/// 0 = 00 = ]a,b[
	/// 1 = 10 = [a,b[
	/// 2 = 01 = ]a,b]
	/// 3 = 11 = [a,b]
	/// This defaults to 0.
	///
	/// The last non-zero item in the Habicht sequence is the gcd of P and P'. The
	/// parameter divideGCD specifies whether the program should attempt to divide
	/// by the gcd and run again. It works better with polynomials known to have
	/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
	/// GCD, if applicable. This defaults to 0.
	///
	/// Compared to the Sturm solver the Habicht solver is slower,
	/// although both are O(d^2). The Habicht solver has the added benefit
	/// that it has a built in mechanism to keep the leading coefficients of the
	/// result from polynomial division bounded above and below in absolute value.
	/// This will tend to keep the coefficients of the polynomials in the sequence
	/// from zeroing out prematurely or becoming infinite.
	///
	/// Constructing the Habicht sequence is O(d^2) in both time and space.
	///
	/// Warning: it is the user's responsibility to make sure the \a upperBnds
	/// array is large enough to contain the maximal number of expected roots.
	/// Note that \a nr is smaller or equal to the actual number of roots in
	/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
	/// array is large enough to contain the maximal number of expected upper bounds.
	/// </summary>
	public static int HabichtBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType)
	{
		return vtkPolynomialSolversUnivariate_HabichtBisectionSolve_07(P, d, a, upperBnds, tol, intervalType);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_HabichtBisectionSolve_08(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, byte divideGCD);

	/// <summary>
	/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
	/// \f[
	/// P[0] X^d + ... + P[d-1] X + P[d]
	/// \f]
	/// in ]\a a[0] ; \a a[1]] using the Habicht sequence (polynomial
	/// coefficients are REAL) and returns the count \a nr. All roots are bracketed
	/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
	/// Returns -1 if anything went wrong (such as: polynomial does not have
	/// degree \a d, the interval provided by the other is absurd, etc.).
	///
	/// \a intervalType specifies the search interval as follows:
	/// 0 = 00 = ]a,b[
	/// 1 = 10 = [a,b[
	/// 2 = 01 = ]a,b]
	/// 3 = 11 = [a,b]
	/// This defaults to 0.
	///
	/// The last non-zero item in the Habicht sequence is the gcd of P and P'. The
	/// parameter divideGCD specifies whether the program should attempt to divide
	/// by the gcd and run again. It works better with polynomials known to have
	/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
	/// GCD, if applicable. This defaults to 0.
	///
	/// Compared to the Sturm solver the Habicht solver is slower,
	/// although both are O(d^2). The Habicht solver has the added benefit
	/// that it has a built in mechanism to keep the leading coefficients of the
	/// result from polynomial division bounded above and below in absolute value.
	/// This will tend to keep the coefficients of the polynomials in the sequence
	/// from zeroing out prematurely or becoming infinite.
	///
	/// Constructing the Habicht sequence is O(d^2) in both time and space.
	///
	/// Warning: it is the user's responsibility to make sure the \a upperBnds
	/// array is large enough to contain the maximal number of expected roots.
	/// Note that \a nr is smaller or equal to the actual number of roots in
	/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
	/// array is large enough to contain the maximal number of expected upper bounds.
	/// </summary>
	public static int HabichtBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, bool divideGCD)
	{
		return vtkPolynomialSolversUnivariate_HabichtBisectionSolve_08(P, d, a, upperBnds, tol, intervalType, (byte)(divideGCD ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolynomialSolversUnivariate_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolynomialSolversUnivariate_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_LinBairstowSolve_11(IntPtr c, int d, IntPtr r, ref double tolerance);

	/// <summary>
	/// Seeks all REAL roots of the \a d -th degree polynomial
	/// c[0] X^d + ... + c[d-1] X + c[d] = 0
	/// equation Lin-Bairstow's method ( polynomial coefficients are REAL ) and
	/// stores the \a nr roots found ( multiple roots are multiply stored ) in \a r.
	/// \a tolerance is the user-defined solver tolerance; this variable may be
	/// relaxed by the iterative solver if needed.
	/// Returns \a nr.
	/// Warning: it is the user's responsibility to make sure the \a r
	/// array is large enough to contain the maximal number of expected roots.
	/// </summary>
	public static int LinBairstowSolve(IntPtr c, int d, IntPtr r, ref double tolerance)
	{
		return vtkPolynomialSolversUnivariate_LinBairstowSolve_11(c, d, r, ref tolerance);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolynomialSolversUnivariate_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPolynomialSolversUnivariate NewInstance()
	{
		vtkPolynomialSolversUnivariate result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolynomialSolversUnivariate_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolynomialSolversUnivariate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolynomialSolversUnivariate_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolynomialSolversUnivariate SafeDownCast(vtkObjectBase o)
	{
		vtkPolynomialSolversUnivariate vtkPolynomialSolversUnivariate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolynomialSolversUnivariate_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolynomialSolversUnivariate2 = (vtkPolynomialSolversUnivariate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolynomialSolversUnivariate2.Register(null);
			}
		}
		return vtkPolynomialSolversUnivariate2;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolynomialSolversUnivariate_SetDivisionTolerance_15(double tol);

	/// <summary>
	/// Set/get the tolerance used when performing polynomial Euclidean division
	/// to find polynomial roots. This tolerance is used to decide whether the
	/// coefficient(s) of a polynomial remainder are close enough to
	/// zero to be neglected.
	/// </summary>
	public static void SetDivisionTolerance(double tol)
	{
		vtkPolynomialSolversUnivariate_SetDivisionTolerance_15(tol);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolynomialSolversUnivariate_SolveCubic_16(double c0, double c1, double c2, double c3);

	/// <summary>
	/// Solves a cubic equation c0*t^3 + c1*t^2 + c2*t + c3 = 0 when c0, c1, c2,
	/// and c3 are REAL.  Solution is motivated by Numerical Recipes In C 2nd
	/// Ed.  Return array contains number of (real) roots (counting multiple
	/// roots as one) followed by roots themselves. The value in roots[4] is a
	/// integer giving further information about the roots (see return codes for
	/// int SolveCubic() ).
	/// </summary>
	public static IntPtr SolveCubic(double c0, double c1, double c2, double c3)
	{
		return vtkPolynomialSolversUnivariate_SolveCubic_16(c0, c1, c2, c3);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_SolveCubic_17(double c0, double c1, double c2, double c3, IntPtr r1, IntPtr r2, IntPtr r3, IntPtr num_roots);

	/// <summary>
	/// Solves a cubic equation when c0, c1, c2, And c3 Are REAL.  Solution
	/// is motivated by Numerical Recipes In C 2nd Ed.  Roots and number of
	/// real roots are stored in user provided variables r1, r2, r3, and
	/// num_roots. Note that the function can return the following integer
	/// values describing the roots: (0)-no solution; (-1)-infinite number
	/// of solutions; (1)-one distinct real root of multiplicity 3 (stored
	/// in r1); (2)-two distinct real roots, one of multiplicity 2 (stored
	/// in r1 &amp; r2); (3)-three distinct real roots; (-2)-quadratic equation
	/// with complex conjugate solution (real part of root returned in r1,
	/// imaginary in r2); (-3)-one real root and a complex conjugate pair
	/// (real root in r1 and real part of pair in r2 and imaginary in r3).
	/// </summary>
	public static int SolveCubic(double c0, double c1, double c2, double c3, IntPtr r1, IntPtr r2, IntPtr r3, IntPtr num_roots)
	{
		return vtkPolynomialSolversUnivariate_SolveCubic_17(c0, c1, c2, c3, r1, r2, r3, num_roots);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolynomialSolversUnivariate_SolveLinear_18(double c0, double c1);

	/// <summary>
	/// Solves a linear equation c0*t  + c1 = 0 when c0 and c1 are REAL.
	/// Solution is motivated by Numerical Recipes In C 2nd Ed.
	/// Return array contains number of roots followed by roots themselves.
	/// </summary>
	public static IntPtr SolveLinear(double c0, double c1)
	{
		return vtkPolynomialSolversUnivariate_SolveLinear_18(c0, c1);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_SolveLinear_19(double c0, double c1, IntPtr r1, IntPtr num_roots);

	/// <summary>
	/// Solves a linear equation c0*t + c1 = 0 when c0 and c1 are REAL.
	/// Solution is motivated by Numerical Recipes In C 2nd Ed.
	/// Root and number of (real) roots are stored in user provided variables
	/// r1 and num_roots.
	/// </summary>
	public static int SolveLinear(double c0, double c1, IntPtr r1, IntPtr num_roots)
	{
		return vtkPolynomialSolversUnivariate_SolveLinear_19(c0, c1, r1, num_roots);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolynomialSolversUnivariate_SolveQuadratic_20(double c0, double c1, double c2);

	/// <summary>
	/// Solves a quadratic equation c0*t^2 + c1*t + c2 = 0 when c0, c1, and c2
	/// are REAL.  Solution is motivated by Numerical Recipes In C 2nd Ed.
	/// Return array contains number of (real) roots (counting multiple roots as
	/// one) followed by roots themselves. Note that roots[3] contains a return
	/// code further describing solution - see documentation for SolveCubic()
	/// for meaning of return codes.
	/// </summary>
	public static IntPtr SolveQuadratic(double c0, double c1, double c2)
	{
		return vtkPolynomialSolversUnivariate_SolveQuadratic_20(c0, c1, c2);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_SolveQuadratic_21(double c0, double c1, double c2, IntPtr r1, IntPtr r2, IntPtr num_roots);

	/// <summary>
	/// Solves a quadratic equation c0*t^2  + c1*t  + c2 = 0 when
	/// c0, c1, and c2 are REAL.
	/// Solution is motivated by Numerical Recipes In C 2nd Ed.
	/// Roots and number of roots are stored in user provided variables
	/// r1, r2, num_roots
	/// </summary>
	public static int SolveQuadratic(double c0, double c1, double c2, IntPtr r1, IntPtr r2, IntPtr num_roots)
	{
		return vtkPolynomialSolversUnivariate_SolveQuadratic_21(c0, c1, c2, r1, r2, num_roots);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_SolveQuadratic_22(IntPtr c, IntPtr r, IntPtr m);

	/// <summary>
	/// Algebraically extracts REAL roots of the quadratic polynomial with
	/// REAL coefficients c[0] X^2 + c[1] X + c[2]
	/// and stores them (when they exist) and their respective multiplicities
	/// in the \a r and \a m arrays.
	/// Returns either the number of roots, or -1 if ininite number of roots.
	/// </summary>
	public static int SolveQuadratic(IntPtr c, IntPtr r, IntPtr m)
	{
		return vtkPolynomialSolversUnivariate_SolveQuadratic_22(c, r, m);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_SturmBisectionSolve_23(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol);

	/// <summary>
	/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
	/// P[0] X^d + ... + P[d-1] X + P[d]
	/// in ]\a a[0] ; \a a[1]] using Sturm's theorem ( polynomial
	/// coefficients are REAL ) and returns the count \a nr. All roots are bracketed
	/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
	/// Returns -1 if anything went wrong (such as: polynomial does not have
	/// degree \a d, the interval provided by the other is absurd, etc.).
	///
	/// intervalType specifies the search interval as follows:
	/// 0 = 00 = ]a,b[
	/// 1 = 10 = [a,b[
	/// 2 = 01 = ]a,b]
	/// 3 = 11 = [a,b]
	/// This defaults to 0.
	///
	/// The last non-zero item in the Sturm sequence is the gcd of P and P'. The
	/// parameter divideGCD specifies whether the program should attempt to divide
	/// by the gcd and run again. It works better with polynomials known to have
	/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
	/// GCD, if applicable. This defaults to 0.
	///
	/// Constructing the Sturm sequence is O(d^2) in both time and space.
	///
	/// Warning: it is the user's responsibility to make sure the \a upperBnds
	/// array is large enough to contain the maximal number of expected roots.
	/// Note that \a nr is smaller or equal to the actual number of roots in
	/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
	/// array is large enough to contain the maximal number of expected upper bounds.
	/// </summary>
	public static int SturmBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol)
	{
		return vtkPolynomialSolversUnivariate_SturmBisectionSolve_23(P, d, a, upperBnds, tol);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_SturmBisectionSolve_24(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType);

	/// <summary>
	/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
	/// P[0] X^d + ... + P[d-1] X + P[d]
	/// in ]\a a[0] ; \a a[1]] using Sturm's theorem ( polynomial
	/// coefficients are REAL ) and returns the count \a nr. All roots are bracketed
	/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
	/// Returns -1 if anything went wrong (such as: polynomial does not have
	/// degree \a d, the interval provided by the other is absurd, etc.).
	///
	/// intervalType specifies the search interval as follows:
	/// 0 = 00 = ]a,b[
	/// 1 = 10 = [a,b[
	/// 2 = 01 = ]a,b]
	/// 3 = 11 = [a,b]
	/// This defaults to 0.
	///
	/// The last non-zero item in the Sturm sequence is the gcd of P and P'. The
	/// parameter divideGCD specifies whether the program should attempt to divide
	/// by the gcd and run again. It works better with polynomials known to have
	/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
	/// GCD, if applicable. This defaults to 0.
	///
	/// Constructing the Sturm sequence is O(d^2) in both time and space.
	///
	/// Warning: it is the user's responsibility to make sure the \a upperBnds
	/// array is large enough to contain the maximal number of expected roots.
	/// Note that \a nr is smaller or equal to the actual number of roots in
	/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
	/// array is large enough to contain the maximal number of expected upper bounds.
	/// </summary>
	public static int SturmBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType)
	{
		return vtkPolynomialSolversUnivariate_SturmBisectionSolve_24(P, d, a, upperBnds, tol, intervalType);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_SturmBisectionSolve_25(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, byte divideGCD);

	/// <summary>
	/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
	/// P[0] X^d + ... + P[d-1] X + P[d]
	/// in ]\a a[0] ; \a a[1]] using Sturm's theorem ( polynomial
	/// coefficients are REAL ) and returns the count \a nr. All roots are bracketed
	/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
	/// Returns -1 if anything went wrong (such as: polynomial does not have
	/// degree \a d, the interval provided by the other is absurd, etc.).
	///
	/// intervalType specifies the search interval as follows:
	/// 0 = 00 = ]a,b[
	/// 1 = 10 = [a,b[
	/// 2 = 01 = ]a,b]
	/// 3 = 11 = [a,b]
	/// This defaults to 0.
	///
	/// The last non-zero item in the Sturm sequence is the gcd of P and P'. The
	/// parameter divideGCD specifies whether the program should attempt to divide
	/// by the gcd and run again. It works better with polynomials known to have
	/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
	/// GCD, if applicable. This defaults to 0.
	///
	/// Constructing the Sturm sequence is O(d^2) in both time and space.
	///
	/// Warning: it is the user's responsibility to make sure the \a upperBnds
	/// array is large enough to contain the maximal number of expected roots.
	/// Note that \a nr is smaller or equal to the actual number of roots in
	/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
	/// array is large enough to contain the maximal number of expected upper bounds.
	/// </summary>
	public static int SturmBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, bool divideGCD)
	{
		return vtkPolynomialSolversUnivariate_SturmBisectionSolve_25(P, d, a, upperBnds, tol, intervalType, (byte)(divideGCD ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolynomialSolversUnivariate_TartagliaCardanSolve_26(IntPtr c, IntPtr r, IntPtr m, double tol);

	/// <summary>
	/// Algebraically extracts REAL roots of the cubic polynomial with
	/// REAL coefficients X^3 + c[0] X^2 + c[1] X + c[2]
	/// and stores them (when they exist) and their respective multiplicities
	/// in the \a r and \a m arrays.
	/// Some numerical noise can be filtered by the use of a tolerance \a tol
	/// instead of equality with 0 (one can use, e.g., VTK_DBL_EPSILON).
	/// The main differences with SolveCubic are that (1) the polynomial must have
	/// unit leading coefficient, (2) complex roots are discarded upfront,
	/// (3) non-simple roots are stored only once, along with their respective
	/// multiplicities, and (4) some numerical noise is filtered by the use of
	/// relative tolerance instead of equality with 0.
	/// Returns the number of roots.
	/// &lt;i&gt; In memoriam &lt;/i&gt; Niccolo Tartaglia (1500 - 1559), unfairly forgotten.
	/// </summary>
	public static int TartagliaCardanSolve(IntPtr c, IntPtr r, IntPtr m, double tol)
	{
		return vtkPolynomialSolversUnivariate_TartagliaCardanSolve_26(c, r, m, tol);
	}
}
