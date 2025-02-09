using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageGaussianSmooth
/// </summary>
/// <remarks>
///    Performs a gaussian convolution.
///
/// vtkImageGaussianSmooth implements a convolution of the input image
/// with a gaussian. Supports from one to three dimensional convolutions.
/// </remarks>
public class vtkImageGaussianSmooth : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageGaussianSmooth";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageGaussianSmooth()
	{
		MRClassNameKey = "class vtkImageGaussianSmooth";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGaussianSmooth"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageGaussianSmooth(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGaussianSmooth_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates an instance of vtkImageGaussianSmooth with the following
	/// defaults: Dimensionality 3, StandardDeviations( 2, 2, 2),
	/// Radius Factors ( 1.5, 1.5, 1.5)
	/// </summary>
	public new static vtkImageGaussianSmooth New()
	{
		vtkImageGaussianSmooth result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGaussianSmooth_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageGaussianSmooth)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates an instance of vtkImageGaussianSmooth with the following
	/// defaults: Dimensionality 3, StandardDeviations( 2, 2, 2),
	/// Radius Factors ( 1.5, 1.5, 1.5)
	/// </summary>
	public vtkImageGaussianSmooth()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageGaussianSmooth_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGaussianSmooth_GetDimensionality_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the dimensionality of this filter. This determines whether
	/// a one, two, or three dimensional gaussian is performed.
	/// </summary>
	public virtual int GetDimensionality()
	{
		return vtkImageGaussianSmooth_GetDimensionality_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageGaussianSmooth_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageGaussianSmooth_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageGaussianSmooth_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageGaussianSmooth_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGaussianSmooth_GetRadiusFactors_04(HandleRef pThis);

	/// <summary>
	/// Sets/Gets the Radius Factors of the gaussian (no unit).
	/// The radius factors determine how far out the gaussian kernel will
	/// go before being clamped to zero.
	/// </summary>
	public virtual double[] GetRadiusFactors()
	{
		IntPtr intPtr = vtkImageGaussianSmooth_GetRadiusFactors_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_GetRadiusFactors_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Sets/Gets the Radius Factors of the gaussian (no unit).
	/// The radius factors determine how far out the gaussian kernel will
	/// go before being clamped to zero.
	/// </summary>
	public virtual void GetRadiusFactors(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageGaussianSmooth_GetRadiusFactors_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_GetRadiusFactors_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Sets/Gets the Radius Factors of the gaussian (no unit).
	/// The radius factors determine how far out the gaussian kernel will
	/// go before being clamped to zero.
	/// </summary>
	public virtual void GetRadiusFactors(IntPtr _arg)
	{
		vtkImageGaussianSmooth_GetRadiusFactors_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGaussianSmooth_GetStandardDeviations_07(HandleRef pThis);

	/// <summary>
	/// Sets/Gets the Standard deviation of the gaussian in pixel units.
	/// </summary>
	public virtual double[] GetStandardDeviations()
	{
		IntPtr intPtr = vtkImageGaussianSmooth_GetStandardDeviations_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_GetStandardDeviations_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Sets/Gets the Standard deviation of the gaussian in pixel units.
	/// </summary>
	public virtual void GetStandardDeviations(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageGaussianSmooth_GetStandardDeviations_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_GetStandardDeviations_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Sets/Gets the Standard deviation of the gaussian in pixel units.
	/// </summary>
	public virtual void GetStandardDeviations(IntPtr _arg)
	{
		vtkImageGaussianSmooth_GetStandardDeviations_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGaussianSmooth_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageGaussianSmooth_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGaussianSmooth_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageGaussianSmooth_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGaussianSmooth_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageGaussianSmooth NewInstance()
	{
		vtkImageGaussianSmooth result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGaussianSmooth_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageGaussianSmooth)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGaussianSmooth_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageGaussianSmooth SafeDownCast(vtkObjectBase o)
	{
		vtkImageGaussianSmooth vtkImageGaussianSmooth2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGaussianSmooth_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageGaussianSmooth2 = (vtkImageGaussianSmooth)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageGaussianSmooth2.Register(null);
			}
		}
		return vtkImageGaussianSmooth2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_SetDimensionality_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the dimensionality of this filter. This determines whether
	/// a one, two, or three dimensional gaussian is performed.
	/// </summary>
	public virtual void SetDimensionality(int _arg)
	{
		vtkImageGaussianSmooth_SetDimensionality_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_SetRadiusFactor_16(HandleRef pThis, double f);

	/// <summary>
	/// Sets/Gets the Radius Factors of the gaussian (no unit).
	/// The radius factors determine how far out the gaussian kernel will
	/// go before being clamped to zero.
	/// </summary>
	public void SetRadiusFactor(double f)
	{
		vtkImageGaussianSmooth_SetRadiusFactor_16(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_SetRadiusFactors_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Sets/Gets the Radius Factors of the gaussian (no unit).
	/// The radius factors determine how far out the gaussian kernel will
	/// go before being clamped to zero.
	/// </summary>
	public virtual void SetRadiusFactors(double _arg1, double _arg2, double _arg3)
	{
		vtkImageGaussianSmooth_SetRadiusFactors_17(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_SetRadiusFactors_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Sets/Gets the Radius Factors of the gaussian (no unit).
	/// The radius factors determine how far out the gaussian kernel will
	/// go before being clamped to zero.
	/// </summary>
	public virtual void SetRadiusFactors(IntPtr _arg)
	{
		vtkImageGaussianSmooth_SetRadiusFactors_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_SetRadiusFactors_19(HandleRef pThis, double f, double f2);

	/// <summary>
	/// Sets/Gets the Radius Factors of the gaussian (no unit).
	/// The radius factors determine how far out the gaussian kernel will
	/// go before being clamped to zero.
	/// </summary>
	public void SetRadiusFactors(double f, double f2)
	{
		vtkImageGaussianSmooth_SetRadiusFactors_19(GetCppThis(), f, f2);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_SetStandardDeviation_20(HandleRef pThis, double std);

	/// <summary>
	/// Sets/Gets the Standard deviation of the gaussian in pixel units.
	/// </summary>
	public void SetStandardDeviation(double std)
	{
		vtkImageGaussianSmooth_SetStandardDeviation_20(GetCppThis(), std);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_SetStandardDeviation_21(HandleRef pThis, double a, double b);

	/// <summary>
	/// Sets/Gets the Standard deviation of the gaussian in pixel units.
	/// These methods are provided for compatibility with old scripts
	/// </summary>
	public void SetStandardDeviation(double a, double b)
	{
		vtkImageGaussianSmooth_SetStandardDeviation_21(GetCppThis(), a, b);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_SetStandardDeviation_22(HandleRef pThis, double a, double b, double c);

	/// <summary>
	/// Sets/Gets the Standard deviation of the gaussian in pixel units.
	/// These methods are provided for compatibility with old scripts
	/// </summary>
	public void SetStandardDeviation(double a, double b, double c)
	{
		vtkImageGaussianSmooth_SetStandardDeviation_22(GetCppThis(), a, b, c);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_SetStandardDeviations_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Sets/Gets the Standard deviation of the gaussian in pixel units.
	/// </summary>
	public virtual void SetStandardDeviations(double _arg1, double _arg2, double _arg3)
	{
		vtkImageGaussianSmooth_SetStandardDeviations_23(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_SetStandardDeviations_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Sets/Gets the Standard deviation of the gaussian in pixel units.
	/// </summary>
	public virtual void SetStandardDeviations(IntPtr _arg)
	{
		vtkImageGaussianSmooth_SetStandardDeviations_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSmooth_SetStandardDeviations_25(HandleRef pThis, double a, double b);

	/// <summary>
	/// Sets/Gets the Standard deviation of the gaussian in pixel units.
	/// </summary>
	public void SetStandardDeviations(double a, double b)
	{
		vtkImageGaussianSmooth_SetStandardDeviations_25(GetCppThis(), a, b);
	}
}
