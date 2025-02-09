using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageGridSource
/// </summary>
/// <remarks>
///    Create an image of a grid.
///
/// vtkImageGridSource produces an image of a grid.  The
/// default output type is double.
/// </remarks>
public class vtkImageGridSource : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageGridSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageGridSource()
	{
		MRClassNameKey = "class vtkImageGridSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGridSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageGridSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGridSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageGridSource New()
	{
		vtkImageGridSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGridSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageGridSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageGridSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageGridSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImageGridSource_GetDataExtent_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the extent of the whole output image,
	/// Default: (0,255,0,255,0,0)
	/// </summary>
	public virtual int[] GetDataExtent()
	{
		IntPtr intPtr = vtkImageGridSource_GetDataExtent_01(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_GetDataExtent_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set/Get the extent of the whole output image,
	/// Default: (0,255,0,255,0,0)
	/// </summary>
	public virtual void GetDataExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkImageGridSource_GetDataExtent_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_GetDataExtent_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the extent of the whole output image,
	/// Default: (0,255,0,255,0,0)
	/// </summary>
	public virtual void GetDataExtent(IntPtr _arg)
	{
		vtkImageGridSource_GetDataExtent_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGridSource_GetDataOrigin_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the origin of the data.
	/// </summary>
	public virtual double[] GetDataOrigin()
	{
		IntPtr intPtr = vtkImageGridSource_GetDataOrigin_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_GetDataOrigin_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the origin of the data.
	/// </summary>
	public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageGridSource_GetDataOrigin_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_GetDataOrigin_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the origin of the data.
	/// </summary>
	public virtual void GetDataOrigin(IntPtr _arg)
	{
		vtkImageGridSource_GetDataOrigin_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGridSource_GetDataScalarType_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.
	/// As a convenience, the OutputScalarType is set to the same value.
	/// </summary>
	public virtual int GetDataScalarType()
	{
		return vtkImageGridSource_GetDataScalarType_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGridSource_GetDataScalarTypeAsString_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.
	/// As a convenience, the OutputScalarType is set to the same value.
	/// </summary>
	public string GetDataScalarTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageGridSource_GetDataScalarTypeAsString_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGridSource_GetDataSpacing_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the pixel spacing.
	/// </summary>
	public virtual double[] GetDataSpacing()
	{
		IntPtr intPtr = vtkImageGridSource_GetDataSpacing_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_GetDataSpacing_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the pixel spacing.
	/// </summary>
	public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageGridSource_GetDataSpacing_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_GetDataSpacing_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the pixel spacing.
	/// </summary>
	public virtual void GetDataSpacing(IntPtr _arg)
	{
		vtkImageGridSource_GetDataSpacing_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageGridSource_GetFillValue_12(HandleRef pThis);

	/// <summary>
	/// Set the grey level of the fill. Default 0.0.
	/// </summary>
	public virtual double GetFillValue()
	{
		return vtkImageGridSource_GetFillValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGridSource_GetGridOrigin_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the grid origin, in ijk integer values.  Default (0,0,0).
	/// </summary>
	public virtual int[] GetGridOrigin()
	{
		IntPtr intPtr = vtkImageGridSource_GetGridOrigin_13(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_GetGridOrigin_14(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set/Get the grid origin, in ijk integer values.  Default (0,0,0).
	/// </summary>
	public virtual void GetGridOrigin(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageGridSource_GetGridOrigin_14(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_GetGridOrigin_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the grid origin, in ijk integer values.  Default (0,0,0).
	/// </summary>
	public virtual void GetGridOrigin(IntPtr _arg)
	{
		vtkImageGridSource_GetGridOrigin_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGridSource_GetGridSpacing_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the grid spacing in pixel units.  Default (10,10,0).
	/// A value of zero means no grid.
	/// </summary>
	public virtual int[] GetGridSpacing()
	{
		IntPtr intPtr = vtkImageGridSource_GetGridSpacing_16(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_GetGridSpacing_17(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set/Get the grid spacing in pixel units.  Default (10,10,0).
	/// A value of zero means no grid.
	/// </summary>
	public virtual void GetGridSpacing(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageGridSource_GetGridSpacing_17(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_GetGridSpacing_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the grid spacing in pixel units.  Default (10,10,0).
	/// A value of zero means no grid.
	/// </summary>
	public virtual void GetGridSpacing(IntPtr _arg)
	{
		vtkImageGridSource_GetGridSpacing_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageGridSource_GetLineValue_19(HandleRef pThis);

	/// <summary>
	/// Set the grey level of the lines. Default 1.0.
	/// </summary>
	public virtual double GetLineValue()
	{
		return vtkImageGridSource_GetLineValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageGridSource_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageGridSource_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageGridSource_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageGridSource_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGridSource_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageGridSource_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGridSource_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageGridSource_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGridSource_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageGridSource NewInstance()
	{
		vtkImageGridSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGridSource_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageGridSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGridSource_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageGridSource SafeDownCast(vtkObjectBase o)
	{
		vtkImageGridSource vtkImageGridSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGridSource_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageGridSource2 = (vtkImageGridSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageGridSource2.Register(null);
			}
		}
		return vtkImageGridSource2;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataExtent_27(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Set/Get the extent of the whole output image,
	/// Default: (0,255,0,255,0,0)
	/// </summary>
	public virtual void SetDataExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkImageGridSource_SetDataExtent_27(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataExtent_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the extent of the whole output image,
	/// Default: (0,255,0,255,0,0)
	/// </summary>
	public virtual void SetDataExtent(IntPtr _arg)
	{
		vtkImageGridSource_SetDataExtent_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataOrigin_29(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the origin of the data.
	/// </summary>
	public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkImageGridSource_SetDataOrigin_29(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataOrigin_30(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the origin of the data.
	/// </summary>
	public virtual void SetDataOrigin(IntPtr _arg)
	{
		vtkImageGridSource_SetDataOrigin_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataScalarType_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.
	/// As a convenience, the OutputScalarType is set to the same value.
	/// </summary>
	public virtual void SetDataScalarType(int _arg)
	{
		vtkImageGridSource_SetDataScalarType_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataScalarTypeToDouble_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.
	/// As a convenience, the OutputScalarType is set to the same value.
	/// </summary>
	public void SetDataScalarTypeToDouble()
	{
		vtkImageGridSource_SetDataScalarTypeToDouble_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataScalarTypeToInt_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.
	/// As a convenience, the OutputScalarType is set to the same value.
	/// </summary>
	public void SetDataScalarTypeToInt()
	{
		vtkImageGridSource_SetDataScalarTypeToInt_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataScalarTypeToShort_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.
	/// As a convenience, the OutputScalarType is set to the same value.
	/// </summary>
	public void SetDataScalarTypeToShort()
	{
		vtkImageGridSource_SetDataScalarTypeToShort_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataScalarTypeToUnsignedChar_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.
	/// As a convenience, the OutputScalarType is set to the same value.
	/// </summary>
	public void SetDataScalarTypeToUnsignedChar()
	{
		vtkImageGridSource_SetDataScalarTypeToUnsignedChar_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataScalarTypeToUnsignedShort_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.
	/// As a convenience, the OutputScalarType is set to the same value.
	/// </summary>
	public void SetDataScalarTypeToUnsignedShort()
	{
		vtkImageGridSource_SetDataScalarTypeToUnsignedShort_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataSpacing_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the pixel spacing.
	/// </summary>
	public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkImageGridSource_SetDataSpacing_37(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetDataSpacing_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the pixel spacing.
	/// </summary>
	public virtual void SetDataSpacing(IntPtr _arg)
	{
		vtkImageGridSource_SetDataSpacing_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetFillValue_39(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the grey level of the fill. Default 0.0.
	/// </summary>
	public virtual void SetFillValue(double _arg)
	{
		vtkImageGridSource_SetFillValue_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetGridOrigin_40(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set/Get the grid origin, in ijk integer values.  Default (0,0,0).
	/// </summary>
	public virtual void SetGridOrigin(int _arg1, int _arg2, int _arg3)
	{
		vtkImageGridSource_SetGridOrigin_40(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetGridOrigin_41(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the grid origin, in ijk integer values.  Default (0,0,0).
	/// </summary>
	public virtual void SetGridOrigin(IntPtr _arg)
	{
		vtkImageGridSource_SetGridOrigin_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetGridSpacing_42(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set/Get the grid spacing in pixel units.  Default (10,10,0).
	/// A value of zero means no grid.
	/// </summary>
	public virtual void SetGridSpacing(int _arg1, int _arg2, int _arg3)
	{
		vtkImageGridSource_SetGridSpacing_42(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetGridSpacing_43(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the grid spacing in pixel units.  Default (10,10,0).
	/// A value of zero means no grid.
	/// </summary>
	public virtual void SetGridSpacing(IntPtr _arg)
	{
		vtkImageGridSource_SetGridSpacing_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGridSource_SetLineValue_44(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the grey level of the lines. Default 1.0.
	/// </summary>
	public virtual void SetLineValue(double _arg)
	{
		vtkImageGridSource_SetLineValue_44(GetCppThis(), _arg);
	}
}
