using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVoxelModeller
/// </summary>
/// <remarks>
///    convert an arbitrary dataset to a voxel representation
///
/// vtkVoxelModeller is a filter that converts an arbitrary data set to a
/// structured point (i.e., voxel) representation. It is very similar to
/// vtkImplicitModeller, except that it doesn't record distance; instead it
/// records occupancy. By default it supports a compact output of 0/1
/// VTK_BIT. Other vtk scalar types can be specified. The Foreground and
/// Background values of the output can also be specified.
/// NOTE: Not all vtk filters/readers/writers support the VTK_BIT
/// scalar type. You may want to use VTK_CHAR as an alternative.
/// </remarks>
/// <seealso>
///
/// vtkImplicitModeller
/// </seealso>
public class vtkVoxelModeller : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVoxelModeller";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVoxelModeller()
	{
		MRClassNameKey = "class vtkVoxelModeller";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoxelModeller"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVoxelModeller(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelModeller_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkVoxelModeller with its sample dimensions
	/// set to (50,50,50), and so that the model bounds are
	/// automatically computed from its input. The maximum distance is set to
	/// examine the whole grid. This could be made much faster, and probably
	/// will be in the future.
	/// </summary>
	public new static vtkVoxelModeller New()
	{
		vtkVoxelModeller result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxelModeller_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoxelModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct an instance of vtkVoxelModeller with its sample dimensions
	/// set to (50,50,50), and so that the model bounds are
	/// automatically computed from its input. The maximum distance is set to
	/// examine the whole grid. This could be made much faster, and probably
	/// will be in the future.
	/// </summary>
	public vtkVoxelModeller()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVoxelModeller_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVoxelModeller_ComputeModelBounds_01(HandleRef pThis, IntPtr origin, IntPtr spacing);

	/// <summary>
	/// Compute the ModelBounds based on the input geometry.
	/// </summary>
	public double ComputeModelBounds(IntPtr origin, IntPtr spacing)
	{
		return vtkVoxelModeller_ComputeModelBounds_01(GetCppThis(), origin, spacing);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVoxelModeller_GetBackgroundValue_02(HandleRef pThis);

	/// <summary>
	/// Set the Foreground/Background values of the output. The
	/// Foreground value is set when a voxel is occupied. The Background
	/// value is set when a voxel is not occupied.
	/// The default ForegroundValue is 1. The default BackgroundValue is
	/// 0.
	/// </summary>
	public virtual double GetBackgroundValue()
	{
		return vtkVoxelModeller_GetBackgroundValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVoxelModeller_GetForegroundValue_03(HandleRef pThis);

	/// <summary>
	/// Set the Foreground/Background values of the output. The
	/// Foreground value is set when a voxel is occupied. The Background
	/// value is set when a voxel is not occupied.
	/// The default ForegroundValue is 1. The default BackgroundValue is
	/// 0.
	/// </summary>
	public virtual double GetForegroundValue()
	{
		return vtkVoxelModeller_GetForegroundValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVoxelModeller_GetMaximumDistance_04(HandleRef pThis);

	/// <summary>
	/// Specify distance away from surface of input geometry to sample. Smaller
	/// values make large increases in performance. Default is 1.0.
	/// </summary>
	public virtual double GetMaximumDistance()
	{
		return vtkVoxelModeller_GetMaximumDistance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVoxelModeller_GetMaximumDistanceMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Specify distance away from surface of input geometry to sample. Smaller
	/// values make large increases in performance. Default is 1.0.
	/// </summary>
	public virtual double GetMaximumDistanceMaxValue()
	{
		return vtkVoxelModeller_GetMaximumDistanceMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVoxelModeller_GetMaximumDistanceMinValue_06(HandleRef pThis);

	/// <summary>
	/// Specify distance away from surface of input geometry to sample. Smaller
	/// values make large increases in performance. Default is 1.0.
	/// </summary>
	public virtual double GetMaximumDistanceMinValue()
	{
		return vtkVoxelModeller_GetMaximumDistanceMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelModeller_GetModelBounds_07(HandleRef pThis);

	/// <summary>
	/// Specify the position in space to perform the voxelization.
	/// Default is (0, 0, 0, 0, 0, 0)
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkVoxelModeller_GetModelBounds_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_GetModelBounds_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the position in space to perform the voxelization.
	/// Default is (0, 0, 0, 0, 0, 0)
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkVoxelModeller_GetModelBounds_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoxelModeller_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVoxelModeller_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoxelModeller_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVoxelModeller_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelModeller_GetSampleDimensions_11(HandleRef pThis);

	/// <summary>
	/// Set the i-j-k dimensions on which to sample the distance function.
	/// Default is (50, 50, 50)
	/// </summary>
	public virtual int[] GetSampleDimensions()
	{
		IntPtr intPtr = vtkVoxelModeller_GetSampleDimensions_11(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_GetSampleDimensions_12(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the i-j-k dimensions on which to sample the distance function.
	/// Default is (50, 50, 50)
	/// </summary>
	public virtual void GetSampleDimensions(IntPtr data)
	{
		vtkVoxelModeller_GetSampleDimensions_12(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxelModeller_GetScalarType_13(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public virtual int GetScalarType()
	{
		return vtkVoxelModeller_GetScalarType_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxelModeller_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVoxelModeller_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxelModeller_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVoxelModeller_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelModeller_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVoxelModeller NewInstance()
	{
		vtkVoxelModeller result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxelModeller_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoxelModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelModeller_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVoxelModeller SafeDownCast(vtkObjectBase o)
	{
		vtkVoxelModeller vtkVoxelModeller2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxelModeller_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVoxelModeller2 = (vtkVoxelModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVoxelModeller2.Register(null);
			}
		}
		return vtkVoxelModeller2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetBackgroundValue_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the Foreground/Background values of the output. The
	/// Foreground value is set when a voxel is occupied. The Background
	/// value is set when a voxel is not occupied.
	/// The default ForegroundValue is 1. The default BackgroundValue is
	/// 0.
	/// </summary>
	public virtual void SetBackgroundValue(double _arg)
	{
		vtkVoxelModeller_SetBackgroundValue_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetForegroundValue_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the Foreground/Background values of the output. The
	/// Foreground value is set when a voxel is occupied. The Background
	/// value is set when a voxel is not occupied.
	/// The default ForegroundValue is 1. The default BackgroundValue is
	/// 0.
	/// </summary>
	public virtual void SetForegroundValue(double _arg)
	{
		vtkVoxelModeller_SetForegroundValue_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetMaximumDistance_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify distance away from surface of input geometry to sample. Smaller
	/// values make large increases in performance. Default is 1.0.
	/// </summary>
	public virtual void SetMaximumDistance(double _arg)
	{
		vtkVoxelModeller_SetMaximumDistance_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetModelBounds_22(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Specify the position in space to perform the voxelization.
	/// Default is (0, 0, 0, 0, 0, 0)
	/// </summary>
	public void SetModelBounds(IntPtr bounds)
	{
		vtkVoxelModeller_SetModelBounds_22(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetModelBounds_23(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Specify the position in space to perform the voxelization.
	/// Default is (0, 0, 0, 0, 0, 0)
	/// </summary>
	public void SetModelBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkVoxelModeller_SetModelBounds_23(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetSampleDimensions_24(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set the i-j-k dimensions on which to sample the distance function.
	/// Default is (50, 50, 50)
	/// </summary>
	public void SetSampleDimensions(int i, int j, int k)
	{
		vtkVoxelModeller_SetSampleDimensions_24(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetSampleDimensions_25(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set the i-j-k dimensions on which to sample the distance function.
	/// Default is (50, 50, 50)
	/// </summary>
	public void SetSampleDimensions(IntPtr dim)
	{
		vtkVoxelModeller_SetSampleDimensions_25(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarType_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public virtual void SetScalarType(int _arg)
	{
		vtkVoxelModeller_SetScalarType_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarTypeToBit_27(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public void SetScalarTypeToBit()
	{
		vtkVoxelModeller_SetScalarTypeToBit_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarTypeToChar_28(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public void SetScalarTypeToChar()
	{
		vtkVoxelModeller_SetScalarTypeToChar_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarTypeToDouble_29(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public void SetScalarTypeToDouble()
	{
		vtkVoxelModeller_SetScalarTypeToDouble_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarTypeToFloat_30(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public void SetScalarTypeToFloat()
	{
		vtkVoxelModeller_SetScalarTypeToFloat_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarTypeToInt_31(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public void SetScalarTypeToInt()
	{
		vtkVoxelModeller_SetScalarTypeToInt_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarTypeToLong_32(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public void SetScalarTypeToLong()
	{
		vtkVoxelModeller_SetScalarTypeToLong_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarTypeToShort_33(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public void SetScalarTypeToShort()
	{
		vtkVoxelModeller_SetScalarTypeToShort_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedChar_34(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public void SetScalarTypeToUnsignedChar()
	{
		vtkVoxelModeller_SetScalarTypeToUnsignedChar_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedInt_35(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public void SetScalarTypeToUnsignedInt()
	{
		vtkVoxelModeller_SetScalarTypeToUnsignedInt_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedLong_36(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public void SetScalarTypeToUnsignedLong()
	{
		vtkVoxelModeller_SetScalarTypeToUnsignedLong_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedShort_37(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output image. The default is
	/// VTK_BIT.
	/// NOTE: Not all filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </summary>
	public void SetScalarTypeToUnsignedShort()
	{
		vtkVoxelModeller_SetScalarTypeToUnsignedShort_37(GetCppThis());
	}
}
