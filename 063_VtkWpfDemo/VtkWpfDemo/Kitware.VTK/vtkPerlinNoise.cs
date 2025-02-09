using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPerlinNoise
/// </summary>
/// <remarks>
///    an implicit function that implements Perlin noise
///
/// vtkPerlinNoise computes a Perlin noise field as an implicit function.
/// vtkPerlinNoise is a concrete implementation of vtkImplicitFunction.
/// Perlin noise, originally described by Ken Perlin, is a non-periodic and
/// continuous noise function useful for modeling real-world objects.
///
/// The amplitude and frequency of the noise pattern are adjustable.  This
/// implementation of Perlin noise is derived closely from Greg Ward's version
/// in Graphics Gems II.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunction
/// </seealso>
public class vtkPerlinNoise : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPerlinNoise";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPerlinNoise()
	{
		MRClassNameKey = "class vtkPerlinNoise";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPerlinNoise"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPerlinNoise(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerlinNoise_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkPerlinNoise New()
	{
		vtkPerlinNoise result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerlinNoise_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPerlinNoise)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkPerlinNoise()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPerlinNoise_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPerlinNoise_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate PerlinNoise function.
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkPerlinNoise_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerlinNoise_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

	/// <summary>
	/// Evaluate PerlinNoise gradient.  Currently, the method returns a 0
	/// gradient.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr n)
	{
		vtkPerlinNoise_EvaluateGradient_02(GetCppThis(), x, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPerlinNoise_GetAmplitude_03(HandleRef pThis);

	/// <summary>
	/// Set/get the amplitude of the noise function. Amplitude can be negative.
	/// The noise function varies randomly between -|Amplitude| and |Amplitude|.
	/// Therefore the range of values is 2*|Amplitude| large.
	/// The initial amplitude is 1.
	/// </summary>
	public virtual double GetAmplitude()
	{
		return vtkPerlinNoise_GetAmplitude_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerlinNoise_GetFrequency_04(HandleRef pThis);

	/// <summary>
	/// Set/get the frequency, or physical scale,  of the noise function
	/// (higher is finer scale).  The frequency can be adjusted per axis, or
	/// the same for all axes.
	/// </summary>
	public virtual double[] GetFrequency()
	{
		IntPtr intPtr = vtkPerlinNoise_GetFrequency_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerlinNoise_GetFrequency_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/get the frequency, or physical scale,  of the noise function
	/// (higher is finer scale).  The frequency can be adjusted per axis, or
	/// the same for all axes.
	/// </summary>
	public virtual void GetFrequency(IntPtr data)
	{
		vtkPerlinNoise_GetFrequency_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPerlinNoise_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPerlinNoise_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPerlinNoise_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPerlinNoise_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerlinNoise_GetPhase_08(HandleRef pThis);

	/// <summary>
	/// Set/get the phase of the noise function.  This parameter can be used to
	/// shift the noise function within space (perhaps to avoid a beat with a
	/// noise pattern at another scale).  Phase tends to repeat about every
	/// unit, so a phase of 0.5 is a half-cycle shift.
	/// </summary>
	public virtual double[] GetPhase()
	{
		IntPtr intPtr = vtkPerlinNoise_GetPhase_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerlinNoise_GetPhase_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/get the phase of the noise function.  This parameter can be used to
	/// shift the noise function within space (perhaps to avoid a beat with a
	/// noise pattern at another scale).  Phase tends to repeat about every
	/// unit, so a phase of 0.5 is a half-cycle shift.
	/// </summary>
	public virtual void GetPhase(IntPtr data)
	{
		vtkPerlinNoise_GetPhase_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPerlinNoise_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPerlinNoise_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPerlinNoise_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPerlinNoise_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerlinNoise_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPerlinNoise NewInstance()
	{
		vtkPerlinNoise result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerlinNoise_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPerlinNoise)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerlinNoise_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPerlinNoise SafeDownCast(vtkObjectBase o)
	{
		vtkPerlinNoise vtkPerlinNoise2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerlinNoise_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPerlinNoise2 = (vtkPerlinNoise)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPerlinNoise2.Register(null);
			}
		}
		return vtkPerlinNoise2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerlinNoise_SetAmplitude_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the amplitude of the noise function. Amplitude can be negative.
	/// The noise function varies randomly between -|Amplitude| and |Amplitude|.
	/// Therefore the range of values is 2*|Amplitude| large.
	/// The initial amplitude is 1.
	/// </summary>
	public virtual void SetAmplitude(double _arg)
	{
		vtkPerlinNoise_SetAmplitude_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerlinNoise_SetFrequency_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/get the frequency, or physical scale,  of the noise function
	/// (higher is finer scale).  The frequency can be adjusted per axis, or
	/// the same for all axes.
	/// </summary>
	public virtual void SetFrequency(double _arg1, double _arg2, double _arg3)
	{
		vtkPerlinNoise_SetFrequency_16(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerlinNoise_SetFrequency_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the frequency, or physical scale,  of the noise function
	/// (higher is finer scale).  The frequency can be adjusted per axis, or
	/// the same for all axes.
	/// </summary>
	public virtual void SetFrequency(IntPtr _arg)
	{
		vtkPerlinNoise_SetFrequency_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerlinNoise_SetPhase_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/get the phase of the noise function.  This parameter can be used to
	/// shift the noise function within space (perhaps to avoid a beat with a
	/// noise pattern at another scale).  Phase tends to repeat about every
	/// unit, so a phase of 0.5 is a half-cycle shift.
	/// </summary>
	public virtual void SetPhase(double _arg1, double _arg2, double _arg3)
	{
		vtkPerlinNoise_SetPhase_18(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerlinNoise_SetPhase_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the phase of the noise function.  This parameter can be used to
	/// shift the noise function within space (perhaps to avoid a beat with a
	/// noise pattern at another scale).  Phase tends to repeat about every
	/// unit, so a phase of 0.5 is a half-cycle shift.
	/// </summary>
	public virtual void SetPhase(IntPtr _arg)
	{
		vtkPerlinNoise_SetPhase_19(GetCppThis(), _arg);
	}
}
