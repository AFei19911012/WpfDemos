using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageNonMaximumSuppression
/// </summary>
/// <remarks>
///    Performs non-maximum suppression
///
/// vtkImageNonMaximumSuppression Sets to zero any pixel that is not a peak.
/// If a pixel has a neighbor along the vector that has larger magnitude, the
/// smaller pixel is set to zero.  The filter takes two inputs: a magnitude
/// and a vector.  Output is magnitude information and is always in doubles.
/// Typically this filter is used with vtkImageGradient and
/// vtkImageGradientMagnitude as inputs.
/// </remarks>
public class vtkImageNonMaximumSuppression : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageNonMaximumSuppression";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageNonMaximumSuppression()
	{
		MRClassNameKey = "class vtkImageNonMaximumSuppression";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageNonMaximumSuppression"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageNonMaximumSuppression(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageNonMaximumSuppression_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageNonMaximumSuppression New()
	{
		vtkImageNonMaximumSuppression result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageNonMaximumSuppression_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageNonMaximumSuppression)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageNonMaximumSuppression()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageNonMaximumSuppression_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageNonMaximumSuppression_GetDimensionality_01(HandleRef pThis);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices or a 3D volume)
	/// </summary>
	public virtual int GetDimensionality()
	{
		return vtkImageNonMaximumSuppression_GetDimensionality_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageNonMaximumSuppression_GetDimensionalityMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices or a 3D volume)
	/// </summary>
	public virtual int GetDimensionalityMaxValue()
	{
		return vtkImageNonMaximumSuppression_GetDimensionalityMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageNonMaximumSuppression_GetDimensionalityMinValue_03(HandleRef pThis);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices or a 3D volume)
	/// </summary>
	public virtual int GetDimensionalityMinValue()
	{
		return vtkImageNonMaximumSuppression_GetDimensionalityMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageNonMaximumSuppression_GetHandleBoundaries_04(HandleRef pThis);

	/// <summary>
	/// If "HandleBoundariesOn" then boundary pixels are duplicated
	/// So central differences can get values.
	/// </summary>
	public virtual int GetHandleBoundaries()
	{
		return vtkImageNonMaximumSuppression_GetHandleBoundaries_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageNonMaximumSuppression_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageNonMaximumSuppression_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageNonMaximumSuppression_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageNonMaximumSuppression_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageNonMaximumSuppression_HandleBoundariesOff_07(HandleRef pThis);

	/// <summary>
	/// If "HandleBoundariesOn" then boundary pixels are duplicated
	/// So central differences can get values.
	/// </summary>
	public virtual void HandleBoundariesOff()
	{
		vtkImageNonMaximumSuppression_HandleBoundariesOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageNonMaximumSuppression_HandleBoundariesOn_08(HandleRef pThis);

	/// <summary>
	/// If "HandleBoundariesOn" then boundary pixels are duplicated
	/// So central differences can get values.
	/// </summary>
	public virtual void HandleBoundariesOn()
	{
		vtkImageNonMaximumSuppression_HandleBoundariesOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageNonMaximumSuppression_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageNonMaximumSuppression_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageNonMaximumSuppression_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageNonMaximumSuppression_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageNonMaximumSuppression_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageNonMaximumSuppression NewInstance()
	{
		vtkImageNonMaximumSuppression result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageNonMaximumSuppression_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageNonMaximumSuppression)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageNonMaximumSuppression_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageNonMaximumSuppression SafeDownCast(vtkObjectBase o)
	{
		vtkImageNonMaximumSuppression vtkImageNonMaximumSuppression2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageNonMaximumSuppression_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageNonMaximumSuppression2 = (vtkImageNonMaximumSuppression)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageNonMaximumSuppression2.Register(null);
			}
		}
		return vtkImageNonMaximumSuppression2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageNonMaximumSuppression_SetDimensionality_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Determines how the input is interpreted (set of 2d slices or a 3D volume)
	/// </summary>
	public virtual void SetDimensionality(int _arg)
	{
		vtkImageNonMaximumSuppression_SetDimensionality_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageNonMaximumSuppression_SetHandleBoundaries_15(HandleRef pThis, int _arg);

	/// <summary>
	/// If "HandleBoundariesOn" then boundary pixels are duplicated
	/// So central differences can get values.
	/// </summary>
	public virtual void SetHandleBoundaries(int _arg)
	{
		vtkImageNonMaximumSuppression_SetHandleBoundaries_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageNonMaximumSuppression_SetMagnitudeInputData_16(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the magnitude and vector inputs.
	/// </summary>
	public void SetMagnitudeInputData(vtkImageData input)
	{
		vtkImageNonMaximumSuppression_SetMagnitudeInputData_16(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageNonMaximumSuppression_SetVectorInputData_17(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the magnitude and vector inputs.
	/// </summary>
	public void SetVectorInputData(vtkImageData input)
	{
		vtkImageNonMaximumSuppression_SetVectorInputData_17(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}
}
