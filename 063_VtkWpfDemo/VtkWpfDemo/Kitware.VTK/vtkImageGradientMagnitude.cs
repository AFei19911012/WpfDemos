using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageGradientMagnitude
/// </summary>
/// <remarks>
///    Computes magnitude of the gradient.
///
///
/// vtkImageGradientMagnitude computes the gradient magnitude of an image.
/// Setting the dimensionality determines whether the gradient is computed on
/// 2D images, or 3D volumes.  The default is two dimensional XY images.
///
/// </remarks>
/// <seealso>
///
/// vtkImageGradient vtkImageMagnitude
/// </seealso>
public class vtkImageGradientMagnitude : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageGradientMagnitude";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageGradientMagnitude()
	{
		MRClassNameKey = "class vtkImageGradientMagnitude";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGradientMagnitude"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageGradientMagnitude(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGradientMagnitude_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageGradientMagnitude New()
	{
		vtkImageGradientMagnitude result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGradientMagnitude_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageGradientMagnitude)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageGradientMagnitude()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageGradientMagnitude_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImageGradientMagnitude_GetDimensionality_01(HandleRef pThis);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices ...)
	/// </summary>
	public virtual int GetDimensionality()
	{
		return vtkImageGradientMagnitude_GetDimensionality_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGradientMagnitude_GetDimensionalityMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices ...)
	/// </summary>
	public virtual int GetDimensionalityMaxValue()
	{
		return vtkImageGradientMagnitude_GetDimensionalityMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGradientMagnitude_GetDimensionalityMinValue_03(HandleRef pThis);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices ...)
	/// </summary>
	public virtual int GetDimensionalityMinValue()
	{
		return vtkImageGradientMagnitude_GetDimensionalityMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGradientMagnitude_GetHandleBoundaries_04(HandleRef pThis);

	/// <summary>
	/// If "HandleBoundariesOn" then boundary pixels are duplicated
	/// So central differences can get values.
	/// </summary>
	public virtual int GetHandleBoundaries()
	{
		return vtkImageGradientMagnitude_GetHandleBoundaries_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageGradientMagnitude_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageGradientMagnitude_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageGradientMagnitude_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageGradientMagnitude_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGradientMagnitude_HandleBoundariesOff_07(HandleRef pThis);

	/// <summary>
	/// If "HandleBoundariesOn" then boundary pixels are duplicated
	/// So central differences can get values.
	/// </summary>
	public virtual void HandleBoundariesOff()
	{
		vtkImageGradientMagnitude_HandleBoundariesOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGradientMagnitude_HandleBoundariesOn_08(HandleRef pThis);

	/// <summary>
	/// If "HandleBoundariesOn" then boundary pixels are duplicated
	/// So central differences can get values.
	/// </summary>
	public virtual void HandleBoundariesOn()
	{
		vtkImageGradientMagnitude_HandleBoundariesOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGradientMagnitude_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageGradientMagnitude_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGradientMagnitude_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageGradientMagnitude_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGradientMagnitude_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageGradientMagnitude NewInstance()
	{
		vtkImageGradientMagnitude result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGradientMagnitude_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageGradientMagnitude)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGradientMagnitude_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageGradientMagnitude SafeDownCast(vtkObjectBase o)
	{
		vtkImageGradientMagnitude vtkImageGradientMagnitude2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGradientMagnitude_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageGradientMagnitude2 = (vtkImageGradientMagnitude)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageGradientMagnitude2.Register(null);
			}
		}
		return vtkImageGradientMagnitude2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGradientMagnitude_SetDimensionality_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices ...)
	/// </summary>
	public virtual void SetDimensionality(int _arg)
	{
		vtkImageGradientMagnitude_SetDimensionality_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGradientMagnitude_SetHandleBoundaries_15(HandleRef pThis, int _arg);

	/// <summary>
	/// If "HandleBoundariesOn" then boundary pixels are duplicated
	/// So central differences can get values.
	/// </summary>
	public virtual void SetHandleBoundaries(int _arg)
	{
		vtkImageGradientMagnitude_SetHandleBoundaries_15(GetCppThis(), _arg);
	}
}
