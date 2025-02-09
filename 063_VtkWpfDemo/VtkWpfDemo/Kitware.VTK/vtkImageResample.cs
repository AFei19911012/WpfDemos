using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageResample
/// </summary>
/// <remarks>
///    Resamples an image to be larger or smaller.
///
/// This filter produces an output with different spacing (and extent)
/// than the input.  Linear interpolation can be used to resample the data.
/// The Output spacing can be set explicitly or relative to input spacing
/// with the SetAxisMagnificationFactor method.
/// </remarks>
public class vtkImageResample : vtkImageReslice
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageResample";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageResample()
	{
		MRClassNameKey = "class vtkImageResample";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageResample"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageResample(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResample_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageResample New()
	{
		vtkImageResample result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResample_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageResample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageResample()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageResample_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageResample_GetAxisMagnificationFactor_01(HandleRef pThis, int axis, HandleRef inInfo);

	/// <summary>
	/// Get the computed magnification factor for a specific axis.
	/// The input information is required to compute the value.
	/// </summary>
	public double GetAxisMagnificationFactor(int axis, vtkInformation inInfo)
	{
		return vtkImageResample_GetAxisMagnificationFactor_01(GetCppThis(), axis, inInfo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResample_GetDimensionality_02(HandleRef pThis);

	/// <summary>
	/// Dimensionality is the number of axes which are considered during
	/// execution. To process images dimensionality would be set to 2.
	/// This has the same effect as setting the magnification of the third
	/// axis to 1.0
	/// </summary>
	public virtual int GetDimensionality()
	{
		return vtkImageResample_GetDimensionality_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResample_GetMagnificationFactors_03(HandleRef pThis);

	/// <summary>
	/// Set/Get Magnification factors.
	/// Zero is a reserved value indicating values have not been computed.
	/// </summary>
	public virtual double[] GetMagnificationFactors()
	{
		IntPtr intPtr = vtkImageResample_GetMagnificationFactors_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResample_GetMagnificationFactors_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get Magnification factors.
	/// Zero is a reserved value indicating values have not been computed.
	/// </summary>
	public virtual void GetMagnificationFactors(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageResample_GetMagnificationFactors_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResample_GetMagnificationFactors_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get Magnification factors.
	/// Zero is a reserved value indicating values have not been computed.
	/// </summary>
	public virtual void GetMagnificationFactors(IntPtr _arg)
	{
		vtkImageResample_GetMagnificationFactors_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageResample_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageResample_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageResample_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageResample_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResample_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageResample_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResample_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageResample_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResample_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageResample NewInstance()
	{
		vtkImageResample result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResample_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageResample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResample_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageResample SafeDownCast(vtkObjectBase o)
	{
		vtkImageResample vtkImageResample2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResample_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageResample2 = (vtkImageResample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageResample2.Register(null);
			}
		}
		return vtkImageResample2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResample_SetAxisMagnificationFactor_13(HandleRef pThis, int axis, double factor);

	/// <summary>
	/// Set/Get Magnification factors.
	/// Zero is a reserved value indicating values have not been computed.
	/// </summary>
	public void SetAxisMagnificationFactor(int axis, double factor)
	{
		vtkImageResample_SetAxisMagnificationFactor_13(GetCppThis(), axis, factor);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResample_SetAxisOutputSpacing_14(HandleRef pThis, int axis, double spacing);

	/// <summary>
	/// Set desired spacing.
	/// Zero is a reserved value indicating spacing has not been set.
	/// </summary>
	public void SetAxisOutputSpacing(int axis, double spacing)
	{
		vtkImageResample_SetAxisOutputSpacing_14(GetCppThis(), axis, spacing);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResample_SetDimensionality_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Dimensionality is the number of axes which are considered during
	/// execution. To process images dimensionality would be set to 2.
	/// This has the same effect as setting the magnification of the third
	/// axis to 1.0
	/// </summary>
	public virtual void SetDimensionality(int _arg)
	{
		vtkImageResample_SetDimensionality_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResample_SetMagnificationFactors_16(HandleRef pThis, double fx, double fy, double fz);

	/// <summary>
	/// Set/Get Magnification factors.
	/// Zero is a reserved value indicating values have not been computed.
	/// </summary>
	public void SetMagnificationFactors(double fx, double fy, double fz)
	{
		vtkImageResample_SetMagnificationFactors_16(GetCppThis(), fx, fy, fz);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResample_SetMagnificationFactors_17(HandleRef pThis, IntPtr f);

	/// <summary>
	/// Set/Get Magnification factors.
	/// Zero is a reserved value indicating values have not been computed.
	/// </summary>
	public void SetMagnificationFactors(IntPtr f)
	{
		vtkImageResample_SetMagnificationFactors_17(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResample_SetOutputSpacing_18(HandleRef pThis, double sx, double sy, double sz);

	/// <summary>
	/// Set desired spacing.
	/// Zero is a reserved value indicating spacing has not been set.
	/// </summary>
	public override void SetOutputSpacing(double sx, double sy, double sz)
	{
		vtkImageResample_SetOutputSpacing_18(GetCppThis(), sx, sy, sz);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResample_SetOutputSpacing_19(HandleRef pThis, IntPtr spacing);

	/// <summary>
	/// Set desired spacing.
	/// Zero is a reserved value indicating spacing has not been set.
	/// </summary>
	public override void SetOutputSpacing(IntPtr spacing)
	{
		vtkImageResample_SetOutputSpacing_19(GetCppThis(), spacing);
	}
}
