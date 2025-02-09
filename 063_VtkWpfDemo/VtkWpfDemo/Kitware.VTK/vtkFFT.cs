using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkFFT
/// </summary>
/// <remarks>
///  perform Discrete Fourier Transforms
///
/// vtkFFT provides methods to perform Discrete Fourier Transforms (DFT).
/// These include providing forward and reverse Fourier transforms.
/// The current implementation uses the third-party library kissfft.
///
/// The terminology tries to follow the Numpy terminology, that is :
///  - Fft means the Fast Fourier Transform algorithm
///  - Prefix `R` stands for Real (meaning optimized function for real inputs)
///  - Prefix `I` stands for Inverse
///
/// Some functions provides pointer-based version of themself in order to
/// prevent copying memory when possible.
/// </remarks>
public class vtkFFT : vtkObject
{
	/// <summary>
	/// Scaling modes for Spectrogram and Csd functions.
	/// </summary>
	public enum Scaling
	{
		/// <summary>enum member</summary>
		Density,
		/// <summary>enum member</summary>
		Spectrum
	}

	/// <summary>
	/// Spectral modes for Spectrogram and Csd functions.
	/// </summary>
	public enum SpectralMode
	{
		/// <summary>enum member</summary>
		PSD = 1,
		/// <summary>enum member</summary>
		STFT = 0
	}

	/// <summary>
	/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
	/// because kernels are symmetric by definitions. This point is very important for some
	/// kernels like Bartlett for example.
	///
	/// @warning Most generators need size &gt; 1 !
	///
	/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
	/// </summary>
	public delegate double WindowGenerator(ulong arg0, ulong arg1);

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFFT";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFFT()
	{
		MRClassNameKey = "class vtkFFT";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFFT"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFFT(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFFT_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a window generator function, create a symmetric 2D kernel.
	/// @c kernel is the pointer to the raw 2D data array.
	/// </summary>
	public new static vtkFFT New()
	{
		vtkFFT result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFFT_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Given a window generator function, create a symmetric 2D kernel.
	/// @c kernel is the pointer to the raw 2D data array.
	/// </summary>
	public vtkFFT()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFFT_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkFFT_BartlettGenerator_01(ulong x, ulong size);

	/// <summary>
	/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
	/// because kernels are symmetric by definitions. This point is very important for some
	/// kernels like Bartlett for example.
	///
	/// @warning Most generators need size &gt; 1 !
	///
	/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
	/// </summary>
	public static double BartlettGenerator(ulong x, ulong size)
	{
		return vtkFFT_BartlettGenerator_01(x, size);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFFT_BlackmanGenerator_02(ulong x, ulong size);

	/// <summary>
	/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
	/// because kernels are symmetric by definitions. This point is very important for some
	/// kernels like Bartlett for example.
	///
	/// @warning Most generators need size &gt; 1 !
	///
	/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
	/// </summary>
	public static double BlackmanGenerator(ulong x, ulong size)
	{
		return vtkFFT_BlackmanGenerator_02(x, size);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFFT_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Given a window generator function, create a symmetric 2D kernel.
	/// @c kernel is the pointer to the raw 2D data array.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFFT_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFFT_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Given a window generator function, create a symmetric 2D kernel.
	/// @c kernel is the pointer to the raw 2D data array.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFFT_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFFT_HanningGenerator_05(ulong x, ulong size);

	/// <summary>
	/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
	/// because kernels are symmetric by definitions. This point is very important for some
	/// kernels like Bartlett for example.
	///
	/// @warning Most generators need size &gt; 1 !
	///
	/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
	/// </summary>
	public static double HanningGenerator(ulong x, ulong size)
	{
		return vtkFFT_HanningGenerator_05(x, size);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFFT_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Given a window generator function, create a symmetric 2D kernel.
	/// @c kernel is the pointer to the raw 2D data array.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFFT_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFFT_IsTypeOf_07(string type);

	/// <summary>
	/// Given a window generator function, create a symmetric 2D kernel.
	/// @c kernel is the pointer to the raw 2D data array.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFFT_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFFT_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a window generator function, create a symmetric 2D kernel.
	/// @c kernel is the pointer to the raw 2D data array.
	/// </summary>
	public new vtkFFT NewInstance()
	{
		vtkFFT result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFFT_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFFT_RectangularGenerator_10(ulong x, ulong size);

	/// <summary>
	/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
	/// because kernels are symmetric by definitions. This point is very important for some
	/// kernels like Bartlett for example.
	///
	/// @warning Most generators need size &gt; 1 !
	///
	/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
	/// </summary>
	public static double RectangularGenerator(ulong x, ulong size)
	{
		return vtkFFT_RectangularGenerator_10(x, size);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFFT_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a window generator function, create a symmetric 2D kernel.
	/// @c kernel is the pointer to the raw 2D data array.
	/// </summary>
	public new static vtkFFT SafeDownCast(vtkObjectBase o)
	{
		vtkFFT vtkFFT2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFFT_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFFT2 = (vtkFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFFT2.Register(null);
			}
		}
		return vtkFFT2;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFFT_SineGenerator_12(ulong x, ulong size);

	/// <summary>
	/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
	/// because kernels are symmetric by definitions. This point is very important for some
	/// kernels like Bartlett for example.
	///
	/// @warning Most generators need size &gt; 1 !
	///
	/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
	/// </summary>
	public static double SineGenerator(ulong x, ulong size)
	{
		return vtkFFT_SineGenerator_12(x, size);
	}
}
