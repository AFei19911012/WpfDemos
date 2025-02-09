using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageToImageStencil
/// </summary>
/// <remarks>
///    clip an image with a mask image
///
/// vtkImageToImageStencil will convert a vtkImageData into an stencil
/// that can be used with vtkImageStecil or other vtk classes that apply
/// a stencil to an image.
/// </remarks>
/// <seealso>
///
/// vtkImageStencil vtkImplicitFunctionToImageStencil vtkPolyDataToImageStencil
/// </seealso>
public class vtkImageToImageStencil : vtkImageStencilAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageToImageStencil";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageToImageStencil()
	{
		MRClassNameKey = "class vtkImageToImageStencil";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToImageStencil"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageToImageStencil(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageToImageStencil_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageToImageStencil New()
	{
		vtkImageToImageStencil result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageToImageStencil_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageToImageStencil()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageToImageStencil_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageToImageStencil_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the image data to convert into a stencil.
	/// </summary>
	public vtkImageData GetInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageToImageStencil_GetInput_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageToImageStencil_GetLowerThreshold_02(HandleRef pThis);

	/// <summary>
	/// Get the Upper and Lower thresholds.
	/// </summary>
	public virtual double GetLowerThreshold()
	{
		return vtkImageToImageStencil_GetLowerThreshold_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageToImageStencil_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageToImageStencil_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageToImageStencil_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageToImageStencil_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageToImageStencil_GetUpperThreshold_05(HandleRef pThis);

	/// <summary>
	/// Get the Upper and Lower thresholds.
	/// </summary>
	public virtual double GetUpperThreshold()
	{
		return vtkImageToImageStencil_GetUpperThreshold_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToImageStencil_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageToImageStencil_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToImageStencil_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageToImageStencil_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageToImageStencil_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageToImageStencil NewInstance()
	{
		vtkImageToImageStencil result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageToImageStencil_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageToImageStencil_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageToImageStencil SafeDownCast(vtkObjectBase o)
	{
		vtkImageToImageStencil vtkImageToImageStencil2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageToImageStencil_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageToImageStencil2 = (vtkImageToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageToImageStencil2.Register(null);
			}
		}
		return vtkImageToImageStencil2;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToImageStencil_SetInputData_11(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Specify the image data to convert into a stencil.
	/// </summary>
	public void SetInputData(vtkImageData input)
	{
		vtkImageToImageStencil_SetInputData_11(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToImageStencil_SetLowerThreshold_12(HandleRef pThis, double _arg);

	/// <summary>
	/// Get the Upper and Lower thresholds.
	/// </summary>
	public virtual void SetLowerThreshold(double _arg)
	{
		vtkImageToImageStencil_SetLowerThreshold_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToImageStencil_SetUpperThreshold_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Get the Upper and Lower thresholds.
	/// </summary>
	public virtual void SetUpperThreshold(double _arg)
	{
		vtkImageToImageStencil_SetUpperThreshold_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToImageStencil_ThresholdBetween_14(HandleRef pThis, double lower, double upper);

	/// <summary>
	/// The values in a range (inclusive) match
	/// </summary>
	public void ThresholdBetween(double lower, double upper)
	{
		vtkImageToImageStencil_ThresholdBetween_14(GetCppThis(), lower, upper);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToImageStencil_ThresholdByLower_15(HandleRef pThis, double thresh);

	/// <summary>
	/// The values less than or equal to the value match.
	/// </summary>
	public void ThresholdByLower(double thresh)
	{
		vtkImageToImageStencil_ThresholdByLower_15(GetCppThis(), thresh);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToImageStencil_ThresholdByUpper_16(HandleRef pThis, double thresh);

	/// <summary>
	/// The values greater than or equal to the value match.
	/// </summary>
	public void ThresholdByUpper(double thresh)
	{
		vtkImageToImageStencil_ThresholdByUpper_16(GetCppThis(), thresh);
	}
}
