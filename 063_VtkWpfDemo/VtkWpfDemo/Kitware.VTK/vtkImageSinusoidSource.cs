using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageSinusoidSource
/// </summary>
/// <remarks>
///    Create an image with sinusoidal pixel values.
///
/// vtkImageSinusoidSource just produces images with pixel values determined
/// by a sinusoid.
/// </remarks>
public class vtkImageSinusoidSource : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageSinusoidSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageSinusoidSource()
	{
		MRClassNameKey = "class vtkImageSinusoidSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSinusoidSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageSinusoidSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSinusoidSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSinusoidSource New()
	{
		vtkImageSinusoidSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSinusoidSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSinusoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageSinusoidSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageSinusoidSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSinusoidSource_GetAmplitude_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the magnitude of the sinusoid.
	/// </summary>
	public virtual double GetAmplitude()
	{
		return vtkImageSinusoidSource_GetAmplitude_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSinusoidSource_GetDirection_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the direction vector which determines the sinusoidal
	/// orientation. The magnitude is ignored.
	/// </summary>
	public virtual double[] GetDirection()
	{
		IntPtr intPtr = vtkImageSinusoidSource_GetDirection_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSinusoidSource_GetDirection_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the direction vector which determines the sinusoidal
	/// orientation. The magnitude is ignored.
	/// </summary>
	public virtual void GetDirection(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageSinusoidSource_GetDirection_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSinusoidSource_GetDirection_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the direction vector which determines the sinusoidal
	/// orientation. The magnitude is ignored.
	/// </summary>
	public virtual void GetDirection(IntPtr _arg)
	{
		vtkImageSinusoidSource_GetDirection_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSinusoidSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageSinusoidSource_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSinusoidSource_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageSinusoidSource_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSinusoidSource_GetPeriod_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the period of the sinusoid in pixels.
	/// </summary>
	public virtual double GetPeriod()
	{
		return vtkImageSinusoidSource_GetPeriod_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSinusoidSource_GetPhase_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the phase: 0-&gt;2Pi.  0 =&gt; Cosine, pi/2 =&gt; Sine.
	/// </summary>
	public virtual double GetPhase()
	{
		return vtkImageSinusoidSource_GetPhase_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSinusoidSource_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageSinusoidSource_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSinusoidSource_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageSinusoidSource_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSinusoidSource_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageSinusoidSource NewInstance()
	{
		vtkImageSinusoidSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSinusoidSource_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSinusoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSinusoidSource_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSinusoidSource SafeDownCast(vtkObjectBase o)
	{
		vtkImageSinusoidSource vtkImageSinusoidSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSinusoidSource_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageSinusoidSource2 = (vtkImageSinusoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageSinusoidSource2.Register(null);
			}
		}
		return vtkImageSinusoidSource2;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSinusoidSource_SetAmplitude_14(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the magnitude of the sinusoid.
	/// </summary>
	public virtual void SetAmplitude(double _arg)
	{
		vtkImageSinusoidSource_SetAmplitude_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSinusoidSource_SetDirection_15(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set/Get the direction vector which determines the sinusoidal
	/// orientation. The magnitude is ignored.
	/// </summary>
	public void SetDirection(double arg0, double arg1, double arg2)
	{
		vtkImageSinusoidSource_SetDirection_15(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSinusoidSource_SetDirection_16(HandleRef pThis, IntPtr dir);

	/// <summary>
	/// Set/Get the direction vector which determines the sinusoidal
	/// orientation. The magnitude is ignored.
	/// </summary>
	public void SetDirection(IntPtr dir)
	{
		vtkImageSinusoidSource_SetDirection_16(GetCppThis(), dir);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSinusoidSource_SetPeriod_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the period of the sinusoid in pixels.
	/// </summary>
	public virtual void SetPeriod(double _arg)
	{
		vtkImageSinusoidSource_SetPeriod_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSinusoidSource_SetPhase_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the phase: 0-&gt;2Pi.  0 =&gt; Cosine, pi/2 =&gt; Sine.
	/// </summary>
	public virtual void SetPhase(double _arg)
	{
		vtkImageSinusoidSource_SetPhase_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSinusoidSource_SetWholeExtent_19(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

	/// <summary>
	/// Set/Get the extent of the whole output image.
	/// </summary>
	public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
	{
		vtkImageSinusoidSource_SetWholeExtent_19(GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
	}
}
