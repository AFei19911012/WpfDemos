using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCylinderSource
/// </summary>
/// <remarks>
///    generate a polygonal cylinder centered at the origin
///
/// vtkCylinderSource creates a polygonal cylinder centered at Center;
/// The axis of the cylinder is aligned along the global y-axis.
/// The height and radius of the cylinder can be specified, as well as the
/// number of sides. It is also possible to control whether the cylinder is
/// open-ended or capped. If you have the end points of the cylinder, you
/// should use a vtkLineSource followed by a vtkTubeFilter instead of the
/// vtkCylinderSource.
///
/// </remarks>
/// <seealso>
///
/// vtkCylinder
/// </seealso>
public class vtkCylinderSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCylinderSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCylinderSource()
	{
		MRClassNameKey = "class vtkCylinderSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCylinderSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCylinderSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCylinderSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCylinderSource New()
	{
		vtkCylinderSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCylinderSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCylinderSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCylinderSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCylinderSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCylinderSource_CappingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to cap cylinder with polygons. Initial value is true.
	/// </summary>
	public virtual void CappingOff()
	{
		vtkCylinderSource_CappingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinderSource_CappingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to cap cylinder with polygons. Initial value is true.
	/// </summary>
	public virtual void CappingOn()
	{
		vtkCylinderSource_CappingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCylinderSource_GetCapping_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to cap cylinder with polygons. Initial value is true.
	/// </summary>
	public virtual int GetCapping()
	{
		return vtkCylinderSource_GetCapping_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCylinderSource_GetCenter_04(HandleRef pThis);

	/// <summary>
	/// Set/Get cylinder center. Initial value is (0.0,0.0,0.0)
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkCylinderSource_GetCenter_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinderSource_GetCenter_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get cylinder center. Initial value is (0.0,0.0,0.0)
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkCylinderSource_GetCenter_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCylinderSource_GetHeight_06(HandleRef pThis);

	/// <summary>
	/// Set the height of the cylinder. Initial value is 1.
	/// </summary>
	public virtual double GetHeight()
	{
		return vtkCylinderSource_GetHeight_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCylinderSource_GetHeightMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set the height of the cylinder. Initial value is 1.
	/// </summary>
	public virtual double GetHeightMaxValue()
	{
		return vtkCylinderSource_GetHeightMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCylinderSource_GetHeightMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set the height of the cylinder. Initial value is 1.
	/// </summary>
	public virtual double GetHeightMinValue()
	{
		return vtkCylinderSource_GetHeightMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCylinderSource_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCylinderSource_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCylinderSource_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCylinderSource_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCylinderSource_GetOutputPointsPrecision_11(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkCylinderSource_GetOutputPointsPrecision_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCylinderSource_GetRadius_12(HandleRef pThis);

	/// <summary>
	/// Set the radius of the cylinder. Initial value is 0.5
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkCylinderSource_GetRadius_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCylinderSource_GetRadiusMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set the radius of the cylinder. Initial value is 0.5
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkCylinderSource_GetRadiusMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCylinderSource_GetRadiusMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set the radius of the cylinder. Initial value is 0.5
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkCylinderSource_GetRadiusMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCylinderSource_GetResolution_15(HandleRef pThis);

	/// <summary>
	/// Set the number of facets used to define cylinder. Initial value is 6.
	/// </summary>
	public virtual int GetResolution()
	{
		return vtkCylinderSource_GetResolution_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCylinderSource_GetResolutionMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set the number of facets used to define cylinder. Initial value is 6.
	/// </summary>
	public virtual int GetResolutionMaxValue()
	{
		return vtkCylinderSource_GetResolutionMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCylinderSource_GetResolutionMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set the number of facets used to define cylinder. Initial value is 6.
	/// </summary>
	public virtual int GetResolutionMinValue()
	{
		return vtkCylinderSource_GetResolutionMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCylinderSource_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCylinderSource_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCylinderSource_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCylinderSource_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCylinderSource_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCylinderSource NewInstance()
	{
		vtkCylinderSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCylinderSource_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCylinderSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCylinderSource_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCylinderSource SafeDownCast(vtkObjectBase o)
	{
		vtkCylinderSource vtkCylinderSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCylinderSource_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCylinderSource2 = (vtkCylinderSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCylinderSource2.Register(null);
			}
		}
		return vtkCylinderSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinderSource_SetCapping_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off whether to cap cylinder with polygons. Initial value is true.
	/// </summary>
	public virtual void SetCapping(int _arg)
	{
		vtkCylinderSource_SetCapping_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinderSource_SetCenter_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get cylinder center. Initial value is (0.0,0.0,0.0)
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkCylinderSource_SetCenter_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinderSource_SetCenter_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get cylinder center. Initial value is (0.0,0.0,0.0)
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkCylinderSource_SetCenter_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinderSource_SetHeight_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the height of the cylinder. Initial value is 1.
	/// </summary>
	public virtual void SetHeight(double _arg)
	{
		vtkCylinderSource_SetHeight_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinderSource_SetOutputPointsPrecision_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkCylinderSource_SetOutputPointsPrecision_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinderSource_SetRadius_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the radius of the cylinder. Initial value is 0.5
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkCylinderSource_SetRadius_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinderSource_SetResolution_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of facets used to define cylinder. Initial value is 6.
	/// </summary>
	public virtual void SetResolution(int _arg)
	{
		vtkCylinderSource_SetResolution_29(GetCppThis(), _arg);
	}
}
