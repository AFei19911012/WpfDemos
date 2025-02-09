using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageIdealHighPass
/// </summary>
/// <remarks>
///    Simple frequency domain band pass.
///
/// This filter only works on an image after it has been converted to
/// frequency domain by a vtkImageFFT filter.  A vtkImageRFFT filter
/// can be used to convert the output back into the spatial domain.
/// vtkImageIdealHighPass just sets a portion of the image to zero.  The sharp
/// cutoff in the frequence domain produces ringing in the spatial domain.
/// Input and Output must be doubles.  Dimensionality is set when the axes are
/// set.  Defaults to 2D on X and Y axes.
///
/// </remarks>
/// <seealso>
///
/// vtkImageButterworthHighPass vtkImageIdealLowPass vtkImageFFT vtkImageRFFT
/// </seealso>
public class vtkImageIdealHighPass : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageIdealHighPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageIdealHighPass()
	{
		MRClassNameKey = "class vtkImageIdealHighPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageIdealHighPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageIdealHighPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageIdealHighPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageIdealHighPass New()
	{
		vtkImageIdealHighPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageIdealHighPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageIdealHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageIdealHighPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageIdealHighPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImageIdealHighPass_GetCutOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual double[] GetCutOff()
	{
		IntPtr intPtr = vtkImageIdealHighPass_GetCutOff_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealHighPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageIdealHighPass_GetCutOff_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealHighPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void GetCutOff(IntPtr _arg)
	{
		vtkImageIdealHighPass_GetCutOff_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageIdealHighPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageIdealHighPass_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageIdealHighPass_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageIdealHighPass_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageIdealHighPass_GetXCutOff_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetXCutOff()
	{
		return vtkImageIdealHighPass_GetXCutOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageIdealHighPass_GetYCutOff_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetYCutOff()
	{
		return vtkImageIdealHighPass_GetYCutOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageIdealHighPass_GetZCutOff_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public double GetZCutOff()
	{
		return vtkImageIdealHighPass_GetZCutOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageIdealHighPass_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageIdealHighPass_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageIdealHighPass_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageIdealHighPass_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageIdealHighPass_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageIdealHighPass NewInstance()
	{
		vtkImageIdealHighPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageIdealHighPass_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageIdealHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageIdealHighPass_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageIdealHighPass SafeDownCast(vtkObjectBase o)
	{
		vtkImageIdealHighPass vtkImageIdealHighPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageIdealHighPass_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageIdealHighPass2 = (vtkImageIdealHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageIdealHighPass2.Register(null);
			}
		}
		return vtkImageIdealHighPass2;
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealHighPass_SetCutOff_14(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
	{
		vtkImageIdealHighPass_SetCutOff_14(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealHighPass_SetCutOff_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public virtual void SetCutOff(IntPtr _arg)
	{
		vtkImageIdealHighPass_SetCutOff_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealHighPass_SetCutOff_16(HandleRef pThis, double v);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetCutOff(double v)
	{
		vtkImageIdealHighPass_SetCutOff_16(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealHighPass_SetXCutOff_17(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetXCutOff(double cutOff)
	{
		vtkImageIdealHighPass_SetXCutOff_17(GetCppThis(), cutOff);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealHighPass_SetYCutOff_18(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetYCutOff(double cutOff)
	{
		vtkImageIdealHighPass_SetYCutOff_18(GetCppThis(), cutOff);
	}

	[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIdealHighPass_SetZCutOff_19(HandleRef pThis, double cutOff);

	/// <summary>
	/// Set/Get the cutoff frequency for each axis.
	/// The values are specified in the order X, Y, Z, Time.
	/// Units: Cycles per world unit (as defined by the data spacing).
	/// </summary>
	public void SetZCutOff(double cutOff)
	{
		vtkImageIdealHighPass_SetZCutOff_19(GetCppThis(), cutOff);
	}
}
