using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageButterworthHighPass
/// </summary>
/// <remarks>
///    Frequency domain high pass.
///
/// This filter only works on an image after it has been converted to
/// frequency domain by a vtkImageFFT filter.  A vtkImageRFFT filter
/// can be used to convert the output back into the spatial domain.
/// vtkImageButterworthHighPass the frequency components around 0 are
/// attenuated.  Input and output are in doubles, with two components
/// (complex numbers).
/// out(i, j) = 1 / (1 + pow(CutOff/Freq(i,j), 2*Order));
///
/// </remarks>
/// <seealso>
///
/// vtkImageButterworthLowPass
/// </seealso>
public class vtkImageButterworthHighPass : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageButterworthHighPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageButterworthHighPass()
	{
		MRClassNameKey = "class vtkImageButterworthHighPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageButterworthHighPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageButterworthHighPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageButterworthHighPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageButterworthHighPass New()
	{
		vtkImageButterworthHighPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageButterworthHighPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageButterworthHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageButterworthHighPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageButterworthHighPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImageButterworthHighPass_GetCutOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual double[] GetCutOff()
	{
		IntPtr intPtr = vtkImageButterworthHighPass_GetCutOff_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthHighPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageButterworthHighPass_GetCutOff_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthHighPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void GetCutOff(IntPtr _arg)
	{
		vtkImageButterworthHighPass_GetCutOff_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageButterworthHighPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageButterworthHighPass_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageButterworthHighPass_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageButterworthHighPass_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageButterworthHighPass_GetOrder_06(HandleRef pThis);

	/// <summary>
	/// The order determines sharpness of the cutoff curve.
	/// </summary>
	public virtual int GetOrder()
	{
		return vtkImageButterworthHighPass_GetOrder_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageButterworthHighPass_GetXCutOff_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetXCutOff()
	{
		return vtkImageButterworthHighPass_GetXCutOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageButterworthHighPass_GetYCutOff_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetYCutOff()
	{
		return vtkImageButterworthHighPass_GetYCutOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageButterworthHighPass_GetZCutOff_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetZCutOff()
	{
		return vtkImageButterworthHighPass_GetZCutOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageButterworthHighPass_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageButterworthHighPass_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageButterworthHighPass_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageButterworthHighPass_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageButterworthHighPass_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageButterworthHighPass NewInstance()
	{
		vtkImageButterworthHighPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageButterworthHighPass_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageButterworthHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageButterworthHighPass_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageButterworthHighPass SafeDownCast(vtkObjectBase o)
	{
		vtkImageButterworthHighPass vtkImageButterworthHighPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageButterworthHighPass_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageButterworthHighPass2 = (vtkImageButterworthHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageButterworthHighPass2.Register(null);
			}
		}
		return vtkImageButterworthHighPass2;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthHighPass_SetCutOff_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
	{
		vtkImageButterworthHighPass_SetCutOff_15(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthHighPass_SetCutOff_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void SetCutOff(IntPtr _arg)
	{
		vtkImageButterworthHighPass_SetCutOff_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthHighPass_SetCutOff_17(HandleRef pThis, double v);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetCutOff(double v)
	{
		vtkImageButterworthHighPass_SetCutOff_17(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthHighPass_SetOrder_18(HandleRef pThis, int _arg);

	/// <summary>
	/// The order determines sharpness of the cutoff curve.
	/// </summary>
	public virtual void SetOrder(int _arg)
	{
		vtkImageButterworthHighPass_SetOrder_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthHighPass_SetXCutOff_19(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetXCutOff(double cutOff)
	{
		vtkImageButterworthHighPass_SetXCutOff_19(GetCppThis(), cutOff);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthHighPass_SetYCutOff_20(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetYCutOff(double cutOff)
	{
		vtkImageButterworthHighPass_SetYCutOff_20(GetCppThis(), cutOff);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageButterworthHighPass_SetZCutOff_21(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetZCutOff(double cutOff)
	{
		vtkImageButterworthHighPass_SetZCutOff_21(GetCppThis(), cutOff);
	}
}
