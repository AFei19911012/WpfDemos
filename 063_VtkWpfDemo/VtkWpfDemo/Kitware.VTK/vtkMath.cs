using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMath
/// </summary>
/// <remarks>
///    performs common math operations
///
/// vtkMath provides methods to perform common math operations. These
/// include providing constants such as Pi; conversion from degrees to
/// radians; vector operations such as dot and cross products and vector
/// norm; matrix determinant for 2x2 and 3x3 matrices; univariate polynomial
/// solvers; and for random number generation (for backward compatibility only).
/// </remarks>
/// <seealso>
///
/// vtkMinimalStandardRandomSequence, vtkBoxMuellerRandomSequence,
/// vtkQuaternion
/// </seealso>
public class vtkMath : vtkObject
{
	/// <summary>
	/// Support the convolution operations.
	/// </summary>
	public enum ConvolutionMode
	{
		/// <summary>enum member</summary>
		FULL,
		/// <summary>enum member</summary>
		SAME,
		/// <summary>enum member</summary>
		VALID
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMath";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMath()
	{
		MRClassNameKey = "class vtkMath";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMath"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMath(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMath New()
	{
		vtkMath result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMath()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_Add_01(IntPtr a, IntPtr b, IntPtr c);

	/// <summary>
	/// Addition of two 3-vectors (float version). Result is stored in c according to c = a + b.
	/// </summary>
	public static void Add(IntPtr a, IntPtr b, IntPtr c)
	{
		vtkMath_Add_01(a, b, c);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_AngleBetweenVectors_02(IntPtr v1, IntPtr v2);

	/// <summary>
	/// Compute angle in radians between two vectors.
	/// </summary>
	public static double AngleBetweenVectors(IntPtr v1, IntPtr v2)
	{
		return vtkMath_AngleBetweenVectors_02(v1, v2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_AreBoundsInitialized_03(IntPtr bounds);

	/// <summary>
	/// Are the bounds initialized?
	/// </summary>
	public static int AreBoundsInitialized(IntPtr bounds)
	{
		return vtkMath_AreBoundsInitialized_03(bounds);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_Assign_04(IntPtr a, IntPtr b);

	/// <summary>
	/// Assign values to a 3-vector (double version). Result is stored in b according to b = a.
	/// </summary>
	public static void Assign(IntPtr a, IntPtr b)
	{
		vtkMath_Assign_04(a, b);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMath_BeginCombination_05(int m, int n);

	/// <summary>
	/// Start iterating over "m choose n" objects.
	/// This function returns an array of n integers, each from 0 to m-1.
	/// These integers represent the n items chosen from the set [0,m[.
	///
	/// You are responsible for calling vtkMath::FreeCombination() once the iterator is no longer
	///             needed.
	///
	/// Warning: this gets large very quickly, especially when n nears m/2!
	/// (Hint: think of Pascal's triangle.)
	/// </summary>
	public static IntPtr BeginCombination(int m, int n)
	{
		return vtkMath_BeginCombination_05(m, n);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMath_Binomial_06(int m, int n);

	/// <summary>
	/// The number of combinations of n objects from a pool of m objects (m&gt;n).
	/// This is commonly known as "m choose n" and sometimes denoted \f$_mC_n\f$
	/// or \f$\left(\begin{array}{c}m \\ n\end{array}\right)\f$.
	/// </summary>
	public static long Binomial(int m, int n)
	{
		return vtkMath_Binomial_06(m, n);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_BoundsIsWithinOtherBounds_07(IntPtr bounds1, IntPtr bounds2, IntPtr delta);

	/// <summary>
	/// Return true if first 3D bounds is within the second 3D bounds
	/// Bounds is x-min, x-max, y-min, y-max, z-min, z-max
	/// Delta is the error margin along each axis (usually a small number)
	/// </summary>
	public static int BoundsIsWithinOtherBounds(IntPtr bounds1, IntPtr bounds2, IntPtr delta)
	{
		return vtkMath_BoundsIsWithinOtherBounds_07(bounds1, bounds2, delta);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_Ceil_08(double x);

	/// <summary>
	/// Rounds a double to the nearest integer not less than itself.
	/// This is faster than ceil() but provides undefined output on
	/// overflow.
	/// </summary>
	public static int Ceil(double x)
	{
		return vtkMath_Ceil_08(x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_CeilLog2_09(ulong x);

	/// <summary>
	/// Gives the exponent of the lowest power of two not less than x.
	/// Or in mathspeak, return the smallest "i" for which 2^i &gt;= x.
	/// If x is zero, then the return value will be zero.
	/// </summary>
	public static int CeilLog2(ulong x)
	{
		return vtkMath_CeilLog2_09(x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_ClampAndNormalizeValue_10(double value, IntPtr range);

	/// <summary>
	/// Clamp a value against a range and then normalize it between 0 and 1.
	/// If range[0]==range[1], the result is 0.
	/// \pre valid_range: range[0]&lt;=range[1]
	/// \post valid_result: result&gt;=0.0 &amp;&amp; result&lt;=1.0
	/// </summary>
	public static double ClampAndNormalizeValue(double value, IntPtr range)
	{
		return vtkMath_ClampAndNormalizeValue_10(value, range);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_ClampValue_11(ref double value, ref double min, ref double max);

	/// <summary>
	/// Compute the convolution of a sampled 1D signal by a given kernel. There are 3 different modes
	/// available:
	///
	/// The "full" mode (default), returning the convolution at each point of overlap between
	/// the sample and the kernel. The output size is equal to sampleSize + kernelSize + 1.
	///
	/// The "same" mode, where the convolution is computed only if the center of the kernel
	/// overlaps with the sample. The output size is equal to the sampleSize.
	///
	/// The "valid" mode, where the convolution is computed only if the kernel overlaps completely
	/// with the sample. The output size is equal to the sampleSize - kernelSize + 1.
	///
	/// @note By convention, here the kernel refers to the smallest input signal of the two, but it
	/// doesn't matter if it's passed as the first or the second parameter (the convolution is
	/// commutative).
	///
	/// @note The function does nothing if iteratorBegin &gt;= iteratorEnd (for each couple of iterators)
	///
	/// @note The output signal is padded with zeros if its size (endOut - beginOut) is bigger than
	/// the number of generated values. If its size is smaller, the result is truncated from the end.
	/// </summary>
	public static double ClampValue(ref double value, ref double min, ref double max)
	{
		return vtkMath_ClampValue_11(ref value, ref min, ref max);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_ClampValue_12(IntPtr value, IntPtr range);

	/// <summary>
	/// Clamp some values against a range
	/// The method without 'clamped_values' will perform in-place clamping.
	/// </summary>
	public static void ClampValue(IntPtr value, IntPtr range)
	{
		vtkMath_ClampValue_12(value, range);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_ClampValue_13(double value, IntPtr range, IntPtr clamped_value);

	/// <summary>
	/// Clamp some values against a range
	/// The method without 'clamped_values' will perform in-place clamping.
	/// </summary>
	public static void ClampValue(double value, IntPtr range, IntPtr clamped_value)
	{
		vtkMath_ClampValue_13(value, range, clamped_value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_ClampValues_14(IntPtr values, int nb_values, IntPtr range);

	/// <summary>
	/// Clamp some values against a range
	/// The method without 'clamped_values' will perform in-place clamping.
	/// </summary>
	public static void ClampValues(IntPtr values, int nb_values, IntPtr range)
	{
		vtkMath_ClampValues_14(values, nb_values, range);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_ClampValues_15(IntPtr values, int nb_values, IntPtr range, IntPtr clamped_values);

	/// <summary>
	/// Clamp some values against a range
	/// The method without 'clamped_values' will perform in-place clamping.
	/// </summary>
	public static void ClampValues(IntPtr values, int nb_values, IntPtr range, IntPtr clamped_values)
	{
		vtkMath_ClampValues_15(values, nb_values, range, clamped_values);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMath_ComputeGCD_16(long m, long n);

	/// <summary>
	/// Compute the greatest common divisor (GCD) of two positive integers m and n. If the
	/// computed GCD==1, then the two integers are coprime to one another. This is a simple,
	/// recursive implementation.
	/// </summary>
	public static long ComputeGCD(long m, long n)
	{
		return vtkMath_ComputeGCD_16(m, n);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_Cross_17(IntPtr a, IntPtr b, IntPtr c);

	/// <summary>
	/// Cross product of two 3-vectors. Result (a x b) is stored in c.
	/// (float version)
	/// </summary>
	public static void Cross(IntPtr a, IntPtr b, IntPtr c)
	{
		vtkMath_Cross_17(a, b, c);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_DegreesFromRadians_18(float radians);

	/// <summary>
	/// Convert radians into degrees
	/// </summary>
	public static float DegreesFromRadians(float radians)
	{
		return vtkMath_DegreesFromRadians_18(radians);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_DegreesFromRadians_19(double radians);

	/// <summary>
	/// Convert radians into degrees
	/// </summary>
	public static double DegreesFromRadians(double radians)
	{
		return vtkMath_DegreesFromRadians_19(radians);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_Determinant2x2_20(IntPtr c1, IntPtr c2);

	/// <summary>
	/// Compute determinant of 2x2 matrix. Two columns of matrix are input.
	/// </summary>
	public static float Determinant2x2(IntPtr c1, IntPtr c2)
	{
		return vtkMath_Determinant2x2_20(c1, c2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_Determinant2x2_21(double a, double b, double c, double d);

	/// <summary>
	/// Calculate the determinant of a 2x2 matrix: | a b | | c d |
	/// </summary>
	public static double Determinant2x2(double a, double b, double c, double d)
	{
		return vtkMath_Determinant2x2_21(a, b, c, d);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_Determinant3x3_22(IntPtr c1, IntPtr c2, IntPtr c3);

	/// <summary>
	/// Compute determinant of 3x3 matrix. Three columns of matrix are input.
	/// </summary>
	public static float Determinant3x3(IntPtr c1, IntPtr c2, IntPtr c3)
	{
		return vtkMath_Determinant3x3_22(c1, c2, c3);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_Determinant3x3_23(double a1, double a2, double a3, double b1, double b2, double b3, double c1, double c2, double c3);

	/// <summary>
	/// Calculate the determinant of a 3x3 matrix in the form:
	/// | a1,  b1,  c1 |
	/// | a2,  b2,  c2 |
	/// | a3,  b3,  c3 |
	/// </summary>
	public static double Determinant3x3(double a1, double a2, double a3, double b1, double b2, double b3, double c1, double c2, double c3)
	{
		return vtkMath_Determinant3x3_23(a1, a2, a3, b1, b2, b3, c1, c2, c3);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_Distance2BetweenPoints_24(IntPtr p1, IntPtr p2);

	/// <summary>
	/// Compute distance squared between two points p1 and p2.
	/// (float version).
	/// </summary>
	public static float Distance2BetweenPoints(IntPtr p1, IntPtr p2)
	{
		return vtkMath_Distance2BetweenPoints_24(p1, p2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_Dot_25(IntPtr a, IntPtr b);

	/// <summary>
	/// Dot product of two 3-vectors (float version).
	/// </summary>
	public static float Dot(IntPtr a, IntPtr b)
	{
		return vtkMath_Dot_25(a, b);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_Dot2D_26(IntPtr x, IntPtr y);

	/// <summary>
	/// Dot product of two 2-vectors. (float version).
	/// </summary>
	public static float Dot2D(IntPtr x, IntPtr y)
	{
		return vtkMath_Dot2D_26(x, y);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_ExtentIsWithinOtherExtent_27(IntPtr extent1, IntPtr extent2);

	/// <summary>
	/// Return true if first 3D extent is within second 3D extent
	/// Extent is x-min, x-max, y-min, y-max, z-min, z-max
	/// </summary>
	public static int ExtentIsWithinOtherExtent(IntPtr extent1, IntPtr extent2)
	{
		return vtkMath_ExtentIsWithinOtherExtent_27(extent1, extent2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMath_Factorial_28(int N);

	/// <summary>
	/// Compute N factorial, N! = N*(N-1) * (N-2)...*3*2*1.
	/// 0! is taken to be 1.
	/// </summary>
	public static long Factorial(int N)
	{
		return vtkMath_Factorial_28(N);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_Floor_29(double x);

	/// <summary>
	/// Rounds a double to the nearest integer not greater than itself.
	/// This is faster than floor() but provides undefined output on
	/// overflow.
	/// </summary>
	public static int Floor(double x)
	{
		return vtkMath_Floor_29(x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_FreeCombination_30(IntPtr combination);

	/// <summary>
	/// Free the "iterator" array created by vtkMath::BeginCombination.
	/// </summary>
	public static void FreeCombination(IntPtr combination)
	{
		vtkMath_FreeCombination_30(combination);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_Gaussian_31();

	/// <summary>
	/// Generate pseudo-random numbers distributed according to the standard
	/// normal distribution.
	///
	/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
	/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
	/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
	/// Instead, for a sequence of random numbers with a uniform distribution
	/// create a vtkMinimalStandardRandomSequence object.
	/// For a sequence of random numbers with a gaussian/normal distribution
	/// create a vtkBoxMuellerRandomSequence object.
	/// </summary>
	public static double Gaussian()
	{
		return vtkMath_Gaussian_31();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_Gaussian_32(double mean, double std);

	/// <summary>
	/// Generate pseudo-random numbers distributed according to the Gaussian
	/// distribution with mean \a mean and standard deviation \a std.
	///
	/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
	/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
	/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
	/// Instead, for a sequence of random numbers with a uniform distribution
	/// create a vtkMinimalStandardRandomSequence object.
	/// For a sequence of random numbers with a gaussian/normal distribution
	/// create a vtkBoxMuellerRandomSequence object.
	/// </summary>
	public static double Gaussian(double mean, double std)
	{
		return vtkMath_Gaussian_32(mean, std);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_GaussianAmplitude_33(double variance, double distanceFromMean);

	/// <summary>
	/// Compute the amplitude of a Gaussian function with mean=0 and specified variance.
	/// That is, 1./(std::sqrt(2 Pi * variance)) * exp(-distanceFromMean^2/(2.*variance)).
	/// </summary>
	public static double GaussianAmplitude(double variance, double distanceFromMean)
	{
		return vtkMath_GaussianAmplitude_33(variance, distanceFromMean);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_GaussianAmplitude_34(double mean, double variance, double position);

	/// <summary>
	/// Compute the amplitude of a Gaussian function with specified mean and variance.
	/// That is, 1./(std::sqrt(2 Pi * variance)) * exp(-(position - mean)^2/(2.*variance)).
	/// </summary>
	public static double GaussianAmplitude(double mean, double variance, double position)
	{
		return vtkMath_GaussianAmplitude_34(mean, variance, position);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_GaussianWeight_35(double variance, double distanceFromMean);

	/// <summary>
	/// Compute the amplitude of an unnormalized Gaussian function with mean=0 and specified variance.
	/// That is, exp(-distanceFromMean^2/(2.*variance)). When distanceFromMean = 0, this function
	/// returns 1.
	/// </summary>
	public static double GaussianWeight(double variance, double distanceFromMean)
	{
		return vtkMath_GaussianWeight_35(variance, distanceFromMean);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_GaussianWeight_36(double mean, double variance, double position);

	/// <summary>
	/// Compute the amplitude of an unnormalized Gaussian function with specified mean and variance.
	/// That is, exp(-(position - mean)^2/(2.*variance)). When the distance from 'position' to 'mean'
	/// is 0, this function returns 1.
	/// </summary>
	public static double GaussianWeight(double mean, double variance, double position)
	{
		return vtkMath_GaussianWeight_36(mean, variance, position);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_GetAdjustedScalarRange_37(HandleRef array, int comp, IntPtr range);

	/// <summary>
	/// Get a vtkDataArray's scalar range for a given component.
	/// If the vtkDataArray's data type is unsigned char (VTK_UNSIGNED_CHAR)
	/// the range is adjusted to the whole data type range [0, 255.0].
	/// Same goes for unsigned short (VTK_UNSIGNED_SHORT) but the upper bound
	/// is also adjusted down to 4095.0 if was between ]255, 4095.0].
	/// Return 1 on success, 0 otherwise.
	/// </summary>
	public static int GetAdjustedScalarRange(vtkDataArray array, int comp, IntPtr range)
	{
		return vtkMath_GetAdjustedScalarRange_37(array?.GetCppThis() ?? default(HandleRef), comp, range);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMath_GetNumberOfGenerationsFromBase_38(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMath_GetNumberOfGenerationsFromBase_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMath_GetNumberOfGenerationsFromBaseType_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMath_GetNumberOfGenerationsFromBaseType_39(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_GetScalarTypeFittingRange_40(double range_min, double range_max, double scale, double shift);

	/// <summary>
	/// Return the scalar type that is most likely to have enough precision
	/// to store a given range of data once it has been scaled and shifted
	/// (i.e. [range_min * scale + shift, range_max * scale + shift].
	/// If any one of the parameters is not an integer number (decimal part != 0),
	/// the search will default to float types only (float or double)
	/// Return -1 on error or no scalar type found.
	/// </summary>
	public static int GetScalarTypeFittingRange(double range_min, double range_max, double scale, double shift)
	{
		return vtkMath_GetScalarTypeFittingRange_40(range_min, range_max, scale, shift);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_GetSeed_41();

	/// <summary>
	/// Return the current seed used by the random number generator.
	///
	/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
	/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
	/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
	/// Instead, for a sequence of random numbers with a uniform distribution
	/// create a vtkMinimalStandardRandomSequence object.
	/// For a sequence of random numbers with a gaussian/normal distribution
	/// create a vtkBoxMuellerRandomSequence object.
	/// </summary>
	public static int GetSeed()
	{
		return vtkMath_GetSeed_41();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_HSVToRGB_42(IntPtr hsv, IntPtr rgb);

	/// <summary>
	/// Convert color in HSV format (Hue, Saturation, Value) to RGB
	/// format (Red, Green, Blue). The input color is not modified.
	/// The input 'hsv' must be float values in the range [0, 1].
	/// The elements of each component of the output 'rgb' are in
	/// the range [0, 1].
	/// </summary>
	public static void HSVToRGB(IntPtr hsv, IntPtr rgb)
	{
		vtkMath_HSVToRGB_42(hsv, rgb);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_HSVToRGB_43(float h, float s, float v, IntPtr r, IntPtr g, IntPtr b);

	/// <summary>
	/// Convert color in HSV format (Hue, Saturation, Value) to RGB
	/// format (Red, Green, Blue). The input color is not modified.
	/// The input 'hsv' must be float values in the range [0, 1].
	/// The elements of each component of the output 'rgb' are in
	/// the range [0, 1].
	/// </summary>
	public static void HSVToRGB(float h, float s, float v, IntPtr r, IntPtr g, IntPtr b)
	{
		vtkMath_HSVToRGB_43(h, s, v, r, g, b);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_HSVToRGB_44(double h, double s, double v, IntPtr r, IntPtr g, IntPtr b);

	/// <summary>
	/// Convert color in HSV format (Hue, Saturation, Value) to RGB
	/// format (Red, Green, Blue). The input color is not modified.
	/// The input 'hsv' must be float values in the range [0, 1].
	/// The elements of each component of the output 'rgb' are in
	/// the range [0, 1].
	/// </summary>
	public static void HSVToRGB(double h, double s, double v, IntPtr r, IntPtr g, IntPtr b)
	{
		vtkMath_HSVToRGB_44(h, s, v, r, g, b);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_Inf_45();

	/// <summary>
	/// Special IEEE-754 number used to represent positive infinity.
	/// </summary>
	public static double Inf()
	{
		return vtkMath_Inf_45();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_IsA_46(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMath_IsA_46(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMath_IsFinite_47(double x);

	/// <summary>
	/// Test if a number has finite value i.e. it is normal, subnormal or zero, but not infinite or
	/// Nan.
	/// </summary>
	public static bool IsFinite(double x)
	{
		return (vtkMath_IsFinite_47(x) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_IsInf_48(double x);

	/// <summary>
	/// Test if a number is equal to the special floating point value infinity.
	/// </summary>
	public static int IsInf(double x)
	{
		return vtkMath_IsInf_48(x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_IsNan_49(double x);

	/// <summary>
	/// Test if a number is equal to the special floating point value Not-A-Number (Nan).
	/// </summary>
	public static int IsNan(double x)
	{
		return vtkMath_IsNan_49(x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMath_IsPowerOfTwo_50(ulong x);

	/// <summary>
	/// Returns true if integer is a power of two.
	/// </summary>
	public static bool IsPowerOfTwo(ulong x)
	{
		return (vtkMath_IsPowerOfTwo_50(x) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_IsTypeOf_51(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMath_IsTypeOf_51(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_LabToRGB_52(IntPtr lab, IntPtr rgb);

	/// <summary>
	/// Convert color from the CIE-L*ab system to RGB.
	/// </summary>
	public static void LabToRGB(IntPtr lab, IntPtr rgb)
	{
		vtkMath_LabToRGB_52(lab, rgb);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_LabToRGB_53(double L, double a, double b, IntPtr red, IntPtr green, IntPtr blue);

	/// <summary>
	/// Convert color from the CIE-L*ab system to RGB.
	/// </summary>
	public static void LabToRGB(double L, double a, double b, IntPtr red, IntPtr green, IntPtr blue)
	{
		vtkMath_LabToRGB_53(L, a, b, red, green, blue);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_LabToXYZ_54(IntPtr lab, IntPtr xyz);

	/// <summary>
	/// Convert color from the CIE-L*ab system to CIE XYZ.
	/// </summary>
	public static void LabToXYZ(IntPtr lab, IntPtr xyz)
	{
		vtkMath_LabToXYZ_54(lab, xyz);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_LabToXYZ_55(double L, double a, double b, IntPtr x, IntPtr y, IntPtr z);

	/// <summary>
	/// Convert color from the CIE-L*ab system to CIE XYZ.
	/// </summary>
	public static void LabToXYZ(double L, double a, double b, IntPtr x, IntPtr y, IntPtr z)
	{
		vtkMath_LabToXYZ_55(L, a, b, x, y, z);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_MultiplyQuaternion_56(IntPtr q1, IntPtr q2, IntPtr q);

	/// <summary>
	/// Multiply two quaternions. This is used to concatenate rotations.
	/// Quaternions are in the form [w, x, y, z].
	/// @sa Matrix3x3ToQuaternion() QuaternionToMatrix3x3()
	/// @sa vtkQuaternion
	/// </summary>
	public static void MultiplyQuaternion(IntPtr q1, IntPtr q2, IntPtr q)
	{
		vtkMath_MultiplyQuaternion_56(q1, q2, q);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_MultiplyScalar_57(IntPtr a, float s);

	/// <summary>
	/// Multiplies a 3-vector by a scalar (float version).
	/// This modifies the input 3-vector.
	/// </summary>
	public static void MultiplyScalar(IntPtr a, float s)
	{
		vtkMath_MultiplyScalar_57(a, s);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_MultiplyScalar_58(IntPtr a, double s);

	/// <summary>
	/// Multiplies a 3-vector by a scalar (double version).
	/// This modifies the input 3-vector.
	/// </summary>
	public static void MultiplyScalar(IntPtr a, double s)
	{
		vtkMath_MultiplyScalar_58(a, s);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_MultiplyScalar2D_59(IntPtr a, float s);

	/// <summary>
	/// Multiplies a 2-vector by a scalar (float version).
	/// This modifies the input 2-vector.
	/// </summary>
	public static void MultiplyScalar2D(IntPtr a, float s)
	{
		vtkMath_MultiplyScalar2D_59(a, s);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_MultiplyScalar2D_60(IntPtr a, double s);

	/// <summary>
	/// Multiplies a 2-vector by a scalar (double version).
	/// This modifies the input 2-vector.
	/// </summary>
	public static void MultiplyScalar2D(IntPtr a, double s)
	{
		vtkMath_MultiplyScalar2D_60(a, s);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_Nan_61();

	/// <summary>
	/// Special IEEE-754 number used to represent Not-A-Number (Nan).
	/// </summary>
	public static double Nan()
	{
		return vtkMath_Nan_61();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_NearestPowerOfTwo_62(int x);

	/// <summary>
	/// Compute the nearest power of two that is not less than x.
	/// The return value is 1 if x is less than or equal to zero,
	/// and is VTK_INT_MIN if result is too large to fit in an int.
	/// </summary>
	public static int NearestPowerOfTwo(int x)
	{
		return vtkMath_NearestPowerOfTwo_62(x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_NegInf_63();

	/// <summary>
	/// Special IEEE-754 number used to represent negative infinity.
	/// </summary>
	public static double NegInf()
	{
		return vtkMath_NegInf_63();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMath_NewInstance_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMath NewInstance()
	{
		vtkMath result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMath_NewInstance_65(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_NextCombination_66(int m, int n, IntPtr combination);

	/// <summary>
	/// Given \a m, \a n, and a valid \a combination of \a n integers in
	/// the range [0,m[, this function alters the integers into the next
	/// combination in a sequence of all combinations of \a n items from
	/// a pool of \a m.
	///
	/// If the \a combination is the last item in the sequence on input,
	/// then \a combination is unaltered and 0 is returned.
	/// Otherwise, 1 is returned and \a combination is updated.
	/// </summary>
	public static int NextCombination(int m, int n, IntPtr combination)
	{
		return vtkMath_NextCombination_66(m, n, combination);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_Norm_67(IntPtr x, int n);

	/// <summary>
	/// Compute the norm of n-vector. x is the vector, n is its length.
	/// </summary>
	public static float Norm(IntPtr x, int n)
	{
		return vtkMath_Norm_67(x, n);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_Norm_68(IntPtr v);

	/// <summary>
	/// Compute the norm of 3-vector (float version).
	/// </summary>
	public static float Norm(IntPtr v)
	{
		return vtkMath_Norm_68(v);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_Norm2D_69(IntPtr x);

	/// <summary>
	/// Compute the norm of a 2-vector.
	/// (float version).
	/// </summary>
	public static float Norm2D(IntPtr x)
	{
		return vtkMath_Norm2D_69(x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_Normalize_70(IntPtr v);

	/// <summary>
	/// Normalize (in place) a 3-vector. Returns norm of vector.
	/// (float version)
	/// </summary>
	public static float Normalize(IntPtr v)
	{
		return vtkMath_Normalize_70(v);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_Normalize2D_71(IntPtr v);

	/// <summary>
	/// Normalize (in place) a 2-vector. Returns norm of vector.
	/// (float version).
	/// </summary>
	public static float Normalize2D(IntPtr v)
	{
		return vtkMath_Normalize2D_71(v);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_Perpendiculars_72(IntPtr v1, IntPtr v2, IntPtr v3, double theta);

	/// <summary>
	/// Given a unit vector v1, find two unit vectors v2 and v3 such that
	/// v1 cross v2 = v3 (i.e. the vectors are perpendicular to each other).
	/// There is an infinite number of such vectors, specify an angle theta
	/// to choose one set.  If you want only one perpendicular vector,
	/// specify nullptr for v3.
	/// </summary>
	public static void Perpendiculars(IntPtr v1, IntPtr v2, IntPtr v3, double theta)
	{
		vtkMath_Perpendiculars_72(v1, v2, v3, theta);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_Pi_73();

	/// <summary>
	/// A mathematical constant. This version is atan(1.0) * 4.0
	/// </summary>
	public static double Pi()
	{
		return vtkMath_Pi_73();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_PlaneIntersectsAABB_74(IntPtr bounds, IntPtr normal, IntPtr point);

	/// <summary>
	/// Implements Plane / Axis-Aligned Bounding-Box intersection as described in
	/// Graphics Gems IV, Ned Greene; pp. 75-76. Variable names are based on the
	/// description in the book. This function returns +1 if the box lies fully in
	/// the positive side of the plane (by convention, the side to which the plane's
	/// normal points to), -1 if the box fully lies in the negative side and 0 if
	/// the plane intersects the box.  -2 is returned if any of the arguments is
	/// invalid.
	/// </summary>
	public static int PlaneIntersectsAABB(IntPtr bounds, IntPtr normal, IntPtr point)
	{
		return vtkMath_PlaneIntersectsAABB_74(bounds, normal, point);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_PointIsWithinBounds_75(IntPtr point, IntPtr bounds, IntPtr delta);

	/// <summary>
	/// Return true if point is within the given 3D bounds
	/// Bounds is x-min, x-max, y-min, y-max, z-min, z-max
	/// Delta is the error margin along each axis (usually a small number)
	/// </summary>
	public static int PointIsWithinBounds(IntPtr point, IntPtr bounds, IntPtr delta)
	{
		return vtkMath_PointIsWithinBounds_75(point, bounds, delta);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMath_ProjectVector_76(IntPtr a, IntPtr b, IntPtr projection);

	/// <summary>
	/// Compute the projection of vector a on vector b and return it in projection[3].
	/// If b is a zero vector, the function returns false and 'projection' is invalid.
	/// Otherwise, it returns true.
	/// </summary>
	public static bool ProjectVector(IntPtr a, IntPtr b, IntPtr projection)
	{
		return (vtkMath_ProjectVector_76(a, b, projection) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMath_ProjectVector2D_77(IntPtr a, IntPtr b, IntPtr projection);

	/// <summary>
	/// Compute the projection of 2D vector a on 2D vector b and returns the result
	/// in projection[2].
	/// If b is a zero vector, the function returns false and 'projection' is invalid.
	/// Otherwise, it returns true.
	/// </summary>
	public static bool ProjectVector2D(IntPtr a, IntPtr b, IntPtr projection)
	{
		return (vtkMath_ProjectVector2D_77(a, b, projection) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_QuadraticRoot_78(double a, double b, double c, double min, double max, IntPtr u);

	/// <summary>
	/// find roots of ax^2+bx+c=0  in the interval min,max.
	/// place the roots in u[2] and return how many roots found
	/// </summary>
	public static int QuadraticRoot(double a, double b, double c, double min, double max, IntPtr u)
	{
		return vtkMath_QuadraticRoot_78(a, b, c, min, max, u);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_RGBToHSV_79(IntPtr rgb, IntPtr hsv);

	/// <summary>
	/// Convert color in RGB format (Red, Green, Blue) to HSV format
	/// (Hue, Saturation, Value). The input color is not modified.
	/// The input RGB must be float values in the range [0, 1].
	/// The output ranges are hue [0, 1], saturation [0, 1], and
	/// value [0, 1].
	/// </summary>
	public static void RGBToHSV(IntPtr rgb, IntPtr hsv)
	{
		vtkMath_RGBToHSV_79(rgb, hsv);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_RGBToHSV_80(float r, float g, float b, IntPtr h, IntPtr s, IntPtr v);

	/// <summary>
	/// Convert color in RGB format (Red, Green, Blue) to HSV format
	/// (Hue, Saturation, Value). The input color is not modified.
	/// The input RGB must be float values in the range [0, 1].
	/// The output ranges are hue [0, 1], saturation [0, 1], and
	/// value [0, 1].
	/// </summary>
	public static void RGBToHSV(float r, float g, float b, IntPtr h, IntPtr s, IntPtr v)
	{
		vtkMath_RGBToHSV_80(r, g, b, h, s, v);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_RGBToHSV_81(double r, double g, double b, IntPtr h, IntPtr s, IntPtr v);

	/// <summary>
	/// Convert color in RGB format (Red, Green, Blue) to HSV format
	/// (Hue, Saturation, Value). The input color is not modified.
	/// The input RGB must be float values in the range [0, 1].
	/// The output ranges are hue [0, 1], saturation [0, 1], and
	/// value [0, 1].
	/// </summary>
	public static void RGBToHSV(double r, double g, double b, IntPtr h, IntPtr s, IntPtr v)
	{
		vtkMath_RGBToHSV_81(r, g, b, h, s, v);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_RGBToLab_82(IntPtr rgb, IntPtr lab);

	/// <summary>
	/// Convert color from the RGB system to CIE-L*ab.
	/// The input RGB must be values in the range [0, 1].
	/// The output ranges of 'L' is [0, 100]. The output
	/// range of 'a' and 'b' are approximately [-110, 110].
	/// </summary>
	public static void RGBToLab(IntPtr rgb, IntPtr lab)
	{
		vtkMath_RGBToLab_82(rgb, lab);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_RGBToLab_83(double red, double green, double blue, IntPtr L, IntPtr a, IntPtr b);

	/// <summary>
	/// Convert color from the RGB system to CIE-L*ab.
	/// The input RGB must be values in the range [0, 1].
	/// The output ranges of 'L' is [0, 100]. The output
	/// range of 'a' and 'b' are approximately [-110, 110].
	/// </summary>
	public static void RGBToLab(double red, double green, double blue, IntPtr L, IntPtr a, IntPtr b)
	{
		vtkMath_RGBToLab_83(red, green, blue, L, a, b);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_RGBToXYZ_84(IntPtr rgb, IntPtr xyz);

	/// <summary>
	/// Convert color from the RGB system to CIE XYZ.
	/// </summary>
	public static void RGBToXYZ(IntPtr rgb, IntPtr xyz)
	{
		vtkMath_RGBToXYZ_84(rgb, xyz);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_RGBToXYZ_85(double r, double g, double b, IntPtr x, IntPtr y, IntPtr z);

	/// <summary>
	/// Convert color from the RGB system to CIE XYZ.
	/// </summary>
	public static void RGBToXYZ(double r, double g, double b, IntPtr x, IntPtr y, IntPtr z)
	{
		vtkMath_RGBToXYZ_85(r, g, b, x, y, z);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMath_RadiansFromDegrees_86(float degrees);

	/// <summary>
	/// Convert degrees into radians
	/// </summary>
	public static float RadiansFromDegrees(float degrees)
	{
		return vtkMath_RadiansFromDegrees_86(degrees);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_RadiansFromDegrees_87(double degrees);

	/// <summary>
	/// Convert degrees into radians
	/// </summary>
	public static double RadiansFromDegrees(double degrees)
	{
		return vtkMath_RadiansFromDegrees_87(degrees);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_Random_88();

	/// <summary>
	/// Generate pseudo-random numbers distributed according to the uniform
	/// distribution between 0.0 and 1.0.
	/// This is used to provide portability across different systems.
	///
	/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
	/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
	/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
	/// Instead, for a sequence of random numbers with a uniform distribution
	/// create a vtkMinimalStandardRandomSequence object.
	/// For a sequence of random numbers with a gaussian/normal distribution
	/// create a vtkBoxMuellerRandomSequence object.
	/// </summary>
	public static double Random()
	{
		return vtkMath_Random_88();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_Random_89(double min, double max);

	/// <summary>
	/// Generate pseudo-random numbers distributed according to the uniform
	/// distribution between \a min and \a max.
	///
	/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
	/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
	/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
	/// Instead, for a sequence of random numbers with a uniform distribution
	/// create a vtkMinimalStandardRandomSequence object.
	/// For a sequence of random numbers with a gaussian/normal distribution
	/// create a vtkBoxMuellerRandomSequence object.
	/// </summary>
	public static double Random(double min, double max)
	{
		return vtkMath_Random_89(min, max);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_RandomSeed_90(int s);

	/// <summary>
	/// Initialize seed value. NOTE: Random() has the bad property that
	/// the first random number returned after RandomSeed() is called
	/// is proportional to the seed value! To help solve this, call
	/// RandomSeed() a few times inside seed. This doesn't ruin the
	/// repeatability of Random().
	///
	/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
	/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
	/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
	/// Instead, for a sequence of random numbers with a uniform distribution
	/// create a vtkMinimalStandardRandomSequence object.
	/// For a sequence of random numbers with a gaussian/normal distribution
	/// create a vtkBoxMuellerRandomSequence object.
	/// </summary>
	public static void RandomSeed(int s)
	{
		vtkMath_RandomSeed_90(s);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_RotateVectorByNormalizedQuaternion_91(IntPtr v, IntPtr q, IntPtr r);

	/// <summary>
	/// rotate a vector by a normalized quaternion
	/// using // https://en.wikipedia.org/wiki/Rodrigues%27_rotation_formula
	/// </summary>
	public static void RotateVectorByNormalizedQuaternion(IntPtr v, IntPtr q, IntPtr r)
	{
		vtkMath_RotateVectorByNormalizedQuaternion_91(v, q, r);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_RotateVectorByWXYZ_92(IntPtr v, IntPtr q, IntPtr r);

	/// <summary>
	/// rotate a vector by WXYZ
	/// using // https://en.wikipedia.org/wiki/Rodrigues%27_rotation_formula
	/// </summary>
	public static void RotateVectorByWXYZ(IntPtr v, IntPtr q, IntPtr r)
	{
		vtkMath_RotateVectorByWXYZ_92(v, q, r);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_Round_93(float f);

	/// <summary>
	/// Rounds a float to the nearest integer.
	/// </summary>
	public static int Round(float f)
	{
		return vtkMath_Round_93(f);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_Round_94(double f);

	/// <summary>
	/// Rounds a float to the nearest integer.
	/// </summary>
	public static int Round(double f)
	{
		return vtkMath_Round_94(f);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMath_SafeDownCast_95(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMath SafeDownCast(vtkObjectBase o)
	{
		vtkMath vtkMath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMath_SafeDownCast_95(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMath2 = (vtkMath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMath2.Register(null);
			}
		}
		return vtkMath2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_SignedAngleBetweenVectors_96(IntPtr v1, IntPtr v2, IntPtr vn);

	/// <summary>
	/// Compute signed angle in radians between two vectors with regard to a third orthogonal vector
	/// </summary>
	public static double SignedAngleBetweenVectors(IntPtr v1, IntPtr v2, IntPtr vn)
	{
		return vtkMath_SignedAngleBetweenVectors_96(v1, v2, vn);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMath_Solve3PointCircle_97(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center);

	/// <summary>
	/// In Euclidean space, there is a unique circle passing through any given
	/// three non-collinear points P1, P2, and P3. Using Cartesian coordinates
	/// to represent these points as spatial vectors, it is possible to use the
	/// dot product and cross product to calculate the radius and center of the
	/// circle. See: http://en.wikipedia.org/wiki/Circumscribed_circle and more
	/// specifically the section Barycentric coordinates from cross- and
	/// dot-products
	/// </summary>
	public static double Solve3PointCircle(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center)
	{
		return vtkMath_Solve3PointCircle_97(p1, p2, p3, center);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMath_SolveLinearSystemGEPP2x2_98(double a00, double a01, double a10, double a11, double b0, double b1, ref double x0, ref double x1);

	/// <summary>
	/// Solve linear equation Ax = b using Gaussian Elimination with Partial Pivoting
	/// for a 2x2 system. If the matrix is found to be singular within a small numerical
	/// tolerance close to machine precision then 0 is returned.
	/// Note: Even if method succeeded the matrix A could be close to singular.
	///       The solution should be checked against relevant tolerance criteria.
	/// </summary>
	public static int SolveLinearSystemGEPP2x2(double a00, double a01, double a10, double a11, double b0, double b1, ref double x0, ref double x1)
	{
		return vtkMath_SolveLinearSystemGEPP2x2_98(a00, a01, a10, a11, b0, b1, ref x0, ref x1);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_Subtract_99(IntPtr a, IntPtr b, IntPtr c);

	/// <summary>
	/// Subtraction of two 3-vectors (float version). Result is stored in c according to c = a - b.
	/// </summary>
	public static void Subtract(IntPtr a, IntPtr b, IntPtr c)
	{
		vtkMath_Subtract_99(a, b, c);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_UninitializeBounds_100(IntPtr bounds);

	/// <summary>
	/// Set the bounds to an uninitialized state
	/// </summary>
	public static void UninitializeBounds(IntPtr bounds)
	{
		vtkMath_UninitializeBounds_100(bounds);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_XYZToLab_101(IntPtr xyz, IntPtr lab);

	/// <summary>
	/// Convert Color from the CIE XYZ system to CIE-L*ab.
	/// </summary>
	public static void XYZToLab(IntPtr xyz, IntPtr lab)
	{
		vtkMath_XYZToLab_101(xyz, lab);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_XYZToLab_102(double x, double y, double z, IntPtr L, IntPtr a, IntPtr b);

	/// <summary>
	/// Convert Color from the CIE XYZ system to CIE-L*ab.
	/// </summary>
	public static void XYZToLab(double x, double y, double z, IntPtr L, IntPtr a, IntPtr b)
	{
		vtkMath_XYZToLab_102(x, y, z, L, a, b);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_XYZToRGB_103(IntPtr xyz, IntPtr rgb);

	/// <summary>
	/// Convert color from the CIE XYZ system to RGB.
	/// </summary>
	public static void XYZToRGB(IntPtr xyz, IntPtr rgb)
	{
		vtkMath_XYZToRGB_103(xyz, rgb);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMath_XYZToRGB_104(double x, double y, double z, IntPtr r, IntPtr g, IntPtr b);

	/// <summary>
	/// Convert color from the CIE XYZ system to RGB.
	/// </summary>
	public static void XYZToRGB(double x, double y, double z, IntPtr r, IntPtr g, IntPtr b)
	{
		vtkMath_XYZToRGB_104(x, y, z, r, g, b);
	}
}
