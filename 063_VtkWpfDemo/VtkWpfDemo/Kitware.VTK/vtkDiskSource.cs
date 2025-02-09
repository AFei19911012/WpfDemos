using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDiskSource
/// </summary>
/// <remarks>
///    create a disk with hole in center
///
/// vtkDiskSource creates a polygonal disk with a hole in the center. The
/// disk has zero height. The user can specify the inner and outer radius
/// of the disk, the radial and circumferential resolution of the
/// polygonal representation, and the center and plane normal of the disk
/// (i.e., the center and disk normal control the position and orientation
/// of the disk).
///
/// </remarks>
/// <seealso>
///
/// vtkLinearExtrusionFilter
/// </seealso>
public class vtkDiskSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDiskSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDiskSource()
	{
		MRClassNameKey = "class vtkDiskSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiskSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDiskSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiskSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to  instantiate the class, obtain type information,
	/// and print the state of the object.
	/// </summary>
	public new static vtkDiskSource New()
	{
		vtkDiskSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiskSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiskSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods to  instantiate the class, obtain type information,
	/// and print the state of the object.
	/// </summary>
	public vtkDiskSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDiskSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiskSource_GetCenter_01(HandleRef pThis);

	/// <summary>
	/// Set the center of the disk. The default is (0, 0, 0).
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkDiskSource_GetCenter_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiskSource_GetCenter_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the center of the disk. The default is (0, 0, 0).
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkDiskSource_GetCenter_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiskSource_GetCircumferentialResolution_03(HandleRef pThis);

	/// <summary>
	/// Set the number of points in circumferential direction.
	/// </summary>
	public virtual int GetCircumferentialResolution()
	{
		return vtkDiskSource_GetCircumferentialResolution_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiskSource_GetCircumferentialResolutionMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set the number of points in circumferential direction.
	/// </summary>
	public virtual int GetCircumferentialResolutionMaxValue()
	{
		return vtkDiskSource_GetCircumferentialResolutionMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiskSource_GetCircumferentialResolutionMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set the number of points in circumferential direction.
	/// </summary>
	public virtual int GetCircumferentialResolutionMinValue()
	{
		return vtkDiskSource_GetCircumferentialResolutionMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiskSource_GetInnerRadius_06(HandleRef pThis);

	/// <summary>
	/// Specify inner radius of hole in disk.
	/// </summary>
	public virtual double GetInnerRadius()
	{
		return vtkDiskSource_GetInnerRadius_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiskSource_GetInnerRadiusMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Specify inner radius of hole in disk.
	/// </summary>
	public virtual double GetInnerRadiusMaxValue()
	{
		return vtkDiskSource_GetInnerRadiusMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiskSource_GetInnerRadiusMinValue_08(HandleRef pThis);

	/// <summary>
	/// Specify inner radius of hole in disk.
	/// </summary>
	public virtual double GetInnerRadiusMinValue()
	{
		return vtkDiskSource_GetInnerRadiusMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiskSource_GetNormal_09(HandleRef pThis);

	/// <summary>
	/// Set/get plane normal. The default is (0, 0, 1).
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkDiskSource_GetNormal_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiskSource_GetNormal_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/get plane normal. The default is (0, 0, 1).
	/// </summary>
	public virtual void GetNormal(IntPtr data)
	{
		vtkDiskSource_GetNormal_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiskSource_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to  instantiate the class, obtain type information,
	/// and print the state of the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDiskSource_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiskSource_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Standard methods to  instantiate the class, obtain type information,
	/// and print the state of the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDiskSource_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiskSource_GetOuterRadius_13(HandleRef pThis);

	/// <summary>
	/// Specify outer radius of disk.
	/// </summary>
	public virtual double GetOuterRadius()
	{
		return vtkDiskSource_GetOuterRadius_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiskSource_GetOuterRadiusMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Specify outer radius of disk.
	/// </summary>
	public virtual double GetOuterRadiusMaxValue()
	{
		return vtkDiskSource_GetOuterRadiusMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiskSource_GetOuterRadiusMinValue_15(HandleRef pThis);

	/// <summary>
	/// Specify outer radius of disk.
	/// </summary>
	public virtual double GetOuterRadiusMinValue()
	{
		return vtkDiskSource_GetOuterRadiusMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiskSource_GetOutputPointsPrecision_16(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkDiskSource_GetOutputPointsPrecision_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiskSource_GetRadialResolution_17(HandleRef pThis);

	/// <summary>
	/// Set the number of points in radius direction.
	/// </summary>
	public virtual int GetRadialResolution()
	{
		return vtkDiskSource_GetRadialResolution_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiskSource_GetRadialResolutionMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set the number of points in radius direction.
	/// </summary>
	public virtual int GetRadialResolutionMaxValue()
	{
		return vtkDiskSource_GetRadialResolutionMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiskSource_GetRadialResolutionMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set the number of points in radius direction.
	/// </summary>
	public virtual int GetRadialResolutionMinValue()
	{
		return vtkDiskSource_GetRadialResolutionMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiskSource_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to  instantiate the class, obtain type information,
	/// and print the state of the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDiskSource_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiskSource_IsTypeOf_21(string type);

	/// <summary>
	/// Standard methods to  instantiate the class, obtain type information,
	/// and print the state of the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDiskSource_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiskSource_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to  instantiate the class, obtain type information,
	/// and print the state of the object.
	/// </summary>
	public new vtkDiskSource NewInstance()
	{
		vtkDiskSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiskSource_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiskSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiskSource_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to  instantiate the class, obtain type information,
	/// and print the state of the object.
	/// </summary>
	public new static vtkDiskSource SafeDownCast(vtkObjectBase o)
	{
		vtkDiskSource vtkDiskSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiskSource_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDiskSource2 = (vtkDiskSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDiskSource2.Register(null);
			}
		}
		return vtkDiskSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiskSource_SetCenter_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the center of the disk. The default is (0, 0, 0).
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkDiskSource_SetCenter_25(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiskSource_SetCenter_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the center of the disk. The default is (0, 0, 0).
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkDiskSource_SetCenter_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiskSource_SetCircumferentialResolution_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of points in circumferential direction.
	/// </summary>
	public virtual void SetCircumferentialResolution(int _arg)
	{
		vtkDiskSource_SetCircumferentialResolution_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiskSource_SetInnerRadius_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify inner radius of hole in disk.
	/// </summary>
	public virtual void SetInnerRadius(double _arg)
	{
		vtkDiskSource_SetInnerRadius_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiskSource_SetNormal_29(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/get plane normal. The default is (0, 0, 1).
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkDiskSource_SetNormal_29(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiskSource_SetNormal_30(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get plane normal. The default is (0, 0, 1).
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkDiskSource_SetNormal_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiskSource_SetOuterRadius_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify outer radius of disk.
	/// </summary>
	public virtual void SetOuterRadius(double _arg)
	{
		vtkDiskSource_SetOuterRadius_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiskSource_SetOutputPointsPrecision_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkDiskSource_SetOutputPointsPrecision_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiskSource_SetRadialResolution_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of points in radius direction.
	/// </summary>
	public virtual void SetRadialResolution(int _arg)
	{
		vtkDiskSource_SetRadialResolution_33(GetCppThis(), _arg);
	}
}
