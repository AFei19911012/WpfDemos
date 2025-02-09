using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageSlab
/// </summary>
/// <remarks>
///    combine image slices to form a slab image
///
/// vtkImageSlab will combine all of the slices of an image to
/// create a single slice.  The slices can be combined with the
/// following operations: averaging, summation, minimum, maximum.
/// If you require an arbitrary angle of projection, you can use
/// vtkImageReslice.
/// @par Thanks:
/// Thanks to David Gobbi for contributing this class to VTK.
/// </remarks>
public class vtkImageSlab : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageSlab";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageSlab()
	{
		MRClassNameKey = "class vtkImageSlab";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSlab"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageSlab(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlab_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSlab New()
	{
		vtkImageSlab result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSlab_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSlab)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageSlab()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageSlab_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImageSlab_GetMultiSliceOutput_01(HandleRef pThis);

	/// <summary>
	/// Turn on multi-slice output.  Each slice of the output will be
	/// a projection through the specified range of input slices, e.g.
	/// if the SliceRange is [0,3] then slice 'i' of the output will
	/// be a projection through slices 'i' through '3+i' of the input.
	/// This flag is off by default.
	/// </summary>
	public virtual int GetMultiSliceOutput()
	{
		return vtkImageSlab_GetMultiSliceOutput_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSlab_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageSlab_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSlab_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageSlab_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlab_GetOperation_04(HandleRef pThis);

	/// <summary>
	/// Set the operation to use when combining slices.  The choices are
	/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
	/// </summary>
	public virtual int GetOperation()
	{
		return vtkImageSlab_GetOperation_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlab_GetOperationAsString_05(HandleRef pThis);

	/// <summary>
	/// Set the operation to use when combining slices.  The choices are
	/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
	/// </summary>
	public string GetOperationAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageSlab_GetOperationAsString_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlab_GetOperationMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set the operation to use when combining slices.  The choices are
	/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
	/// </summary>
	public virtual int GetOperationMaxValue()
	{
		return vtkImageSlab_GetOperationMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlab_GetOperationMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set the operation to use when combining slices.  The choices are
	/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
	/// </summary>
	public virtual int GetOperationMinValue()
	{
		return vtkImageSlab_GetOperationMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlab_GetOrientation_08(HandleRef pThis);

	/// <summary>
	/// Set the slice direction: zero for x, 1 for y, 2 for z.
	/// The default is the Z direction.
	/// </summary>
	public virtual int GetOrientation()
	{
		return vtkImageSlab_GetOrientation_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlab_GetOrientationMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set the slice direction: zero for x, 1 for y, 2 for z.
	/// The default is the Z direction.
	/// </summary>
	public virtual int GetOrientationMaxValue()
	{
		return vtkImageSlab_GetOrientationMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlab_GetOrientationMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set the slice direction: zero for x, 1 for y, 2 for z.
	/// The default is the Z direction.
	/// </summary>
	public virtual int GetOrientationMinValue()
	{
		return vtkImageSlab_GetOrientationMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlab_GetOutputScalarType_11(HandleRef pThis);

	/// <summary>
	/// Set the output scalar type to float or double, to avoid
	/// potential overflow when doing a summation operation.
	/// The default is to use the scalar type of the input data,
	/// and clamp the output to the range of the input scalar type.
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkImageSlab_GetOutputScalarType_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlab_GetSliceRange_12(HandleRef pThis);

	/// <summary>
	/// Set the range of slices to combine. The default is to project
	/// through all slices.
	/// </summary>
	public virtual int[] GetSliceRange()
	{
		IntPtr intPtr = vtkImageSlab_GetSliceRange_12(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_GetSliceRange_13(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set the range of slices to combine. The default is to project
	/// through all slices.
	/// </summary>
	public virtual void GetSliceRange(ref int _arg1, ref int _arg2)
	{
		vtkImageSlab_GetSliceRange_13(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_GetSliceRange_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range of slices to combine. The default is to project
	/// through all slices.
	/// </summary>
	public virtual void GetSliceRange(IntPtr _arg)
	{
		vtkImageSlab_GetSliceRange_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlab_GetTrapezoidIntegration_15(HandleRef pThis);

	/// <summary>
	/// Use trapezoid integration for slab computation.  This weighs the
	/// first and last slices by half when doing sum and mean, as compared
	/// to the default midpoint integration that weighs all slices equally.
	/// It is off by default.
	/// </summary>
	public virtual int GetTrapezoidIntegration()
	{
		return vtkImageSlab_GetTrapezoidIntegration_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlab_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageSlab_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlab_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageSlab_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_MultiSliceOutputOff_18(HandleRef pThis);

	/// <summary>
	/// Turn on multi-slice output.  Each slice of the output will be
	/// a projection through the specified range of input slices, e.g.
	/// if the SliceRange is [0,3] then slice 'i' of the output will
	/// be a projection through slices 'i' through '3+i' of the input.
	/// This flag is off by default.
	/// </summary>
	public virtual void MultiSliceOutputOff()
	{
		vtkImageSlab_MultiSliceOutputOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_MultiSliceOutputOn_19(HandleRef pThis);

	/// <summary>
	/// Turn on multi-slice output.  Each slice of the output will be
	/// a projection through the specified range of input slices, e.g.
	/// if the SliceRange is [0,3] then slice 'i' of the output will
	/// be a projection through slices 'i' through '3+i' of the input.
	/// This flag is off by default.
	/// </summary>
	public virtual void MultiSliceOutputOn()
	{
		vtkImageSlab_MultiSliceOutputOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlab_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageSlab NewInstance()
	{
		vtkImageSlab result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSlab_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSlab)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlab_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSlab SafeDownCast(vtkObjectBase o)
	{
		vtkImageSlab vtkImageSlab2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSlab_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageSlab2 = (vtkImageSlab)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageSlab2.Register(null);
			}
		}
		return vtkImageSlab2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetMultiSliceOutput_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on multi-slice output.  Each slice of the output will be
	/// a projection through the specified range of input slices, e.g.
	/// if the SliceRange is [0,3] then slice 'i' of the output will
	/// be a projection through slices 'i' through '3+i' of the input.
	/// This flag is off by default.
	/// </summary>
	public virtual void SetMultiSliceOutput(int _arg)
	{
		vtkImageSlab_SetMultiSliceOutput_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOperation_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the operation to use when combining slices.  The choices are
	/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
	/// </summary>
	public virtual void SetOperation(int _arg)
	{
		vtkImageSlab_SetOperation_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOperationToMax_25(HandleRef pThis);

	/// <summary>
	/// Set the operation to use when combining slices.  The choices are
	/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
	/// </summary>
	public void SetOperationToMax()
	{
		vtkImageSlab_SetOperationToMax_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOperationToMean_26(HandleRef pThis);

	/// <summary>
	/// Set the operation to use when combining slices.  The choices are
	/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
	/// </summary>
	public void SetOperationToMean()
	{
		vtkImageSlab_SetOperationToMean_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOperationToMin_27(HandleRef pThis);

	/// <summary>
	/// Set the operation to use when combining slices.  The choices are
	/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
	/// </summary>
	public void SetOperationToMin()
	{
		vtkImageSlab_SetOperationToMin_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOperationToSum_28(HandleRef pThis);

	/// <summary>
	/// Set the operation to use when combining slices.  The choices are
	/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
	/// </summary>
	public void SetOperationToSum()
	{
		vtkImageSlab_SetOperationToSum_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOrientation_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the slice direction: zero for x, 1 for y, 2 for z.
	/// The default is the Z direction.
	/// </summary>
	public virtual void SetOrientation(int _arg)
	{
		vtkImageSlab_SetOrientation_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOrientationToX_30(HandleRef pThis);

	/// <summary>
	/// Set the slice direction: zero for x, 1 for y, 2 for z.
	/// The default is the Z direction.
	/// </summary>
	public void SetOrientationToX()
	{
		vtkImageSlab_SetOrientationToX_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOrientationToY_31(HandleRef pThis);

	/// <summary>
	/// Set the slice direction: zero for x, 1 for y, 2 for z.
	/// The default is the Z direction.
	/// </summary>
	public void SetOrientationToY()
	{
		vtkImageSlab_SetOrientationToY_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOrientationToZ_32(HandleRef pThis);

	/// <summary>
	/// Set the slice direction: zero for x, 1 for y, 2 for z.
	/// The default is the Z direction.
	/// </summary>
	public void SetOrientationToZ()
	{
		vtkImageSlab_SetOrientationToZ_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOutputScalarTypeToDouble_33(HandleRef pThis);

	/// <summary>
	/// Set the output scalar type to float or double, to avoid
	/// potential overflow when doing a summation operation.
	/// The default is to use the scalar type of the input data,
	/// and clamp the output to the range of the input scalar type.
	/// </summary>
	public void SetOutputScalarTypeToDouble()
	{
		vtkImageSlab_SetOutputScalarTypeToDouble_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOutputScalarTypeToFloat_34(HandleRef pThis);

	/// <summary>
	/// Set the output scalar type to float or double, to avoid
	/// potential overflow when doing a summation operation.
	/// The default is to use the scalar type of the input data,
	/// and clamp the output to the range of the input scalar type.
	/// </summary>
	public void SetOutputScalarTypeToFloat()
	{
		vtkImageSlab_SetOutputScalarTypeToFloat_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetOutputScalarTypeToInputScalarType_35(HandleRef pThis);

	/// <summary>
	/// Set the output scalar type to float or double, to avoid
	/// potential overflow when doing a summation operation.
	/// The default is to use the scalar type of the input data,
	/// and clamp the output to the range of the input scalar type.
	/// </summary>
	public void SetOutputScalarTypeToInputScalarType()
	{
		vtkImageSlab_SetOutputScalarTypeToInputScalarType_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetSliceRange_36(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set the range of slices to combine. The default is to project
	/// through all slices.
	/// </summary>
	public virtual void SetSliceRange(int _arg1, int _arg2)
	{
		vtkImageSlab_SetSliceRange_36(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetSliceRange_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range of slices to combine. The default is to project
	/// through all slices.
	/// </summary>
	public void SetSliceRange(IntPtr _arg)
	{
		vtkImageSlab_SetSliceRange_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_SetTrapezoidIntegration_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Use trapezoid integration for slab computation.  This weighs the
	/// first and last slices by half when doing sum and mean, as compared
	/// to the default midpoint integration that weighs all slices equally.
	/// It is off by default.
	/// </summary>
	public virtual void SetTrapezoidIntegration(int _arg)
	{
		vtkImageSlab_SetTrapezoidIntegration_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_TrapezoidIntegrationOff_39(HandleRef pThis);

	/// <summary>
	/// Use trapezoid integration for slab computation.  This weighs the
	/// first and last slices by half when doing sum and mean, as compared
	/// to the default midpoint integration that weighs all slices equally.
	/// It is off by default.
	/// </summary>
	public virtual void TrapezoidIntegrationOff()
	{
		vtkImageSlab_TrapezoidIntegrationOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlab_TrapezoidIntegrationOn_40(HandleRef pThis);

	/// <summary>
	/// Use trapezoid integration for slab computation.  This weighs the
	/// first and last slices by half when doing sum and mean, as compared
	/// to the default midpoint integration that weighs all slices equally.
	/// It is off by default.
	/// </summary>
	public virtual void TrapezoidIntegrationOn()
	{
		vtkImageSlab_TrapezoidIntegrationOn_40(GetCppThis());
	}
}
