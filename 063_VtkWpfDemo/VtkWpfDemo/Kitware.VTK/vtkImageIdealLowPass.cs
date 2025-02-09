using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageIdealLowPass
/// </summary>
/// <remarks>
///    Simple frequency domain band pass.
///
/// This filter only works on an image after it has been converted to
/// frequency domain by a vtkImageFFT filter.  A vtkImageRFFT filter
/// can be used to convert the output back into the spatial domain.
/// vtkImageIdealLowPass just sets a portion of the image to zero.  The result
/// is an image with a lot of ringing.  Input and Output must be doubles.
/// Dimensionality is set when the axes are set.  Defaults to 2D on X and Y
/// axes.
///
/// </remarks>
/// <seealso>
///
/// vtkImageButterworthLowPass vtkImageIdealHighPass vtkImageFFT vtkImageRFFT
/// </seealso>
public class vtkImageIdealLowPass : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageIdealLowPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageIdealLowPass()
	{
		MRClassNameKey = "class vtkImageIdealLowPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageIdealLowPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageIdealLowPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageIdealLowPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageIdealLowPass New()
	{
		vtkImageIdealLowPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageIdealLowPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageIdealLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageIdealLowPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageIdealLowPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageIdealLowPass_GetCutOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual double[] GetCutOff()
	{
		IntPtr intPtr = vtkImageIdealLowPass_GetCutOff_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealLowPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageIdealLowPass_GetCutOff_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealLowPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void GetCutOff(IntPtr _arg)
	{
		vtkImageIdealLowPass_GetCutOff_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageIdealLowPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageIdealLowPass_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageIdealLowPass_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageIdealLowPass_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageIdealLowPass_GetXCutOff_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetXCutOff()
	{
		return vtkImageIdealLowPass_GetXCutOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageIdealLowPass_GetYCutOff_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetYCutOff()
	{
		return vtkImageIdealLowPass_GetYCutOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageIdealLowPass_GetZCutOff_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetZCutOff()
	{
		return vtkImageIdealLowPass_GetZCutOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageIdealLowPass_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageIdealLowPass_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageIdealLowPass_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageIdealLowPass_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageIdealLowPass_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageIdealLowPass NewInstance()
	{
		vtkImageIdealLowPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageIdealLowPass_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageIdealLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageIdealLowPass_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageIdealLowPass SafeDownCast(vtkObjectBase o)
	{
		vtkImageIdealLowPass vtkImageIdealLowPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageIdealLowPass_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageIdealLowPass2 = (vtkImageIdealLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageIdealLowPass2.Register(null);
			}
		}
		return vtkImageIdealLowPass2;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealLowPass_SetCutOff_14(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
	{
		vtkImageIdealLowPass_SetCutOff_14(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealLowPass_SetCutOff_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void SetCutOff(IntPtr _arg)
	{
		vtkImageIdealLowPass_SetCutOff_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealLowPass_SetCutOff_16(HandleRef pThis, double v);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetCutOff(double v)
	{
		vtkImageIdealLowPass_SetCutOff_16(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealLowPass_SetXCutOff_17(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetXCutOff(double cutOff)
	{
		vtkImageIdealLowPass_SetXCutOff_17(GetCppThis(), cutOff);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealLowPass_SetYCutOff_18(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetYCutOff(double cutOff)
	{
		vtkImageIdealLowPass_SetYCutOff_18(GetCppThis(), cutOff);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealLowPass_SetZCutOff_19(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetZCutOff(double cutOff)
	{
		vtkImageIdealLowPass_SetZCutOff_19(GetCppThis(), cutOff);
	}
}
