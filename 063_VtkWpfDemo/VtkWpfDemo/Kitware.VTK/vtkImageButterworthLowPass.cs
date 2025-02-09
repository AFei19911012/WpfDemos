using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageButterworthLowPass
/// </summary>
/// <remarks>
///    Frequency domain Low pass.
///
/// This filter only works on an image after it has been converted to
/// frequency domain by a vtkImageFFT filter.  A vtkImageRFFT filter
/// can be used to convert the output back into the spatial domain.
/// vtkImageButterworthLowPass the high frequency components are
/// attenuated.  Input and output are in doubles, with two components
/// (complex numbers).
/// out(i, j) = (1 + pow(CutOff/Freq(i,j), 2*Order));
///
/// </remarks>
/// <seealso>
///
/// vtkImageButterworthHighPass vtkImageFFT vtkImageRFFT
/// </seealso>
public class vtkImageButterworthLowPass : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageButterworthLowPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageButterworthLowPass()
	{
		MRClassNameKey = "class vtkImageButterworthLowPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageButterworthLowPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageButterworthLowPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageButterworthLowPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageButterworthLowPass New()
	{
		vtkImageButterworthLowPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageButterworthLowPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageButterworthLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageButterworthLowPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageButterworthLowPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImageButterworthLowPass_GetCutOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual double[] GetCutOff()
	{
		IntPtr intPtr = vtkImageButterworthLowPass_GetCutOff_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthLowPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageButterworthLowPass_GetCutOff_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthLowPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void GetCutOff(IntPtr _arg)
	{
		vtkImageButterworthLowPass_GetCutOff_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageButterworthLowPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageButterworthLowPass_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageButterworthLowPass_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageButterworthLowPass_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageButterworthLowPass_GetOrder_06(HandleRef pThis);

	/// <summary>
	/// The order determines sharpness of the cutoff curve.
	/// </summary>
	public virtual int GetOrder()
	{
		return vtkImageButterworthLowPass_GetOrder_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageButterworthLowPass_GetXCutOff_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetXCutOff()
	{
		return vtkImageButterworthLowPass_GetXCutOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageButterworthLowPass_GetYCutOff_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetYCutOff()
	{
		return vtkImageButterworthLowPass_GetYCutOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageButterworthLowPass_GetZCutOff_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetZCutOff()
	{
		return vtkImageButterworthLowPass_GetZCutOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageButterworthLowPass_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageButterworthLowPass_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageButterworthLowPass_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageButterworthLowPass_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageButterworthLowPass_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageButterworthLowPass NewInstance()
	{
		vtkImageButterworthLowPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageButterworthLowPass_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageButterworthLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageButterworthLowPass_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageButterworthLowPass SafeDownCast(vtkObjectBase o)
	{
		vtkImageButterworthLowPass vtkImageButterworthLowPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageButterworthLowPass_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageButterworthLowPass2 = (vtkImageButterworthLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageButterworthLowPass2.Register(null);
			}
		}
		return vtkImageButterworthLowPass2;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthLowPass_SetCutOff_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
	{
		vtkImageButterworthLowPass_SetCutOff_15(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthLowPass_SetCutOff_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void SetCutOff(IntPtr _arg)
	{
		vtkImageButterworthLowPass_SetCutOff_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthLowPass_SetCutOff_17(HandleRef pThis, double v);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetCutOff(double v)
	{
		vtkImageButterworthLowPass_SetCutOff_17(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthLowPass_SetOrder_18(HandleRef pThis, int _arg);

	/// <summary>
	/// The order determines sharpness of the cutoff curve.
	/// </summary>
	public virtual void SetOrder(int _arg)
	{
		vtkImageButterworthLowPass_SetOrder_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthLowPass_SetXCutOff_19(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetXCutOff(double cutOff)
	{
		vtkImageButterworthLowPass_SetXCutOff_19(GetCppThis(), cutOff);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthLowPass_SetYCutOff_20(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetYCutOff(double cutOff)
	{
		vtkImageButterworthLowPass_SetYCutOff_20(GetCppThis(), cutOff);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthLowPass_SetZCutOff_21(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetZCutOff(double cutOff)
	{
		vtkImageButterworthLowPass_SetZCutOff_21(GetCppThis(), cutOff);
	}
}
