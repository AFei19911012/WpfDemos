using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageGradient
/// </summary>
/// <remarks>
///    Computes the gradient vector.
///
/// vtkImageGradient computes the gradient vector of an image.  The
/// vector results are stored as scalar components. The Dimensionality
/// determines whether to perform a 2d or 3d gradient. The default is
/// two dimensional XY gradient.  OutputScalarType is always
/// double. Gradient is computed using central differences.
/// </remarks>
public class vtkImageGradient : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageGradient";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageGradient()
	{
		MRClassNameKey = "class vtkImageGradient";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGradient"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageGradient(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGradient_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageGradient New()
	{
		vtkImageGradient result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGradient_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageGradient)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageGradient()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageGradient_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImageGradient_GetDimensionality_01(HandleRef pThis);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices ...)
	/// </summary>
	public virtual int GetDimensionality()
	{
		return vtkImageGradient_GetDimensionality_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGradient_GetDimensionalityMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices ...)
	/// </summary>
	public virtual int GetDimensionalityMaxValue()
	{
		return vtkImageGradient_GetDimensionalityMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGradient_GetDimensionalityMinValue_03(HandleRef pThis);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices ...)
	/// </summary>
	public virtual int GetDimensionalityMinValue()
	{
		return vtkImageGradient_GetDimensionalityMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGradient_GetHandleBoundaries_04(HandleRef pThis);

	/// <summary>
	/// Get/Set whether to handle boundaries.  If enabled, boundary
	/// pixels are treated as duplicated so that central differencing
	/// works for the boundary pixels.  If disabled, the output whole
	/// extent of the image is reduced by one pixel.
	/// </summary>
	public virtual int GetHandleBoundaries()
	{
		return vtkImageGradient_GetHandleBoundaries_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageGradient_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageGradient_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageGradient_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageGradient_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGradient_HandleBoundariesOff_07(HandleRef pThis);

	/// <summary>
	/// Get/Set whether to handle boundaries.  If enabled, boundary
	/// pixels are treated as duplicated so that central differencing
	/// works for the boundary pixels.  If disabled, the output whole
	/// extent of the image is reduced by one pixel.
	/// </summary>
	public virtual void HandleBoundariesOff()
	{
		vtkImageGradient_HandleBoundariesOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGradient_HandleBoundariesOn_08(HandleRef pThis);

	/// <summary>
	/// Get/Set whether to handle boundaries.  If enabled, boundary
	/// pixels are treated as duplicated so that central differencing
	/// works for the boundary pixels.  If disabled, the output whole
	/// extent of the image is reduced by one pixel.
	/// </summary>
	public virtual void HandleBoundariesOn()
	{
		vtkImageGradient_HandleBoundariesOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGradient_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageGradient_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGradient_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageGradient_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGradient_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageGradient NewInstance()
	{
		vtkImageGradient result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGradient_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageGradient)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGradient_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageGradient SafeDownCast(vtkObjectBase o)
	{
		vtkImageGradient vtkImageGradient2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGradient_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageGradient2 = (vtkImageGradient)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageGradient2.Register(null);
			}
		}
		return vtkImageGradient2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGradient_SetDimensionality_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices ...)
	/// </summary>
	public virtual void SetDimensionality(int _arg)
	{
		vtkImageGradient_SetDimensionality_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGradient_SetHandleBoundaries_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set whether to handle boundaries.  If enabled, boundary
	/// pixels are treated as duplicated so that central differencing
	/// works for the boundary pixels.  If disabled, the output whole
	/// extent of the image is reduced by one pixel.
	/// </summary>
	public virtual void SetHandleBoundaries(int _arg)
	{
		vtkImageGradient_SetHandleBoundaries_15(GetCppThis(), _arg);
	}
}
