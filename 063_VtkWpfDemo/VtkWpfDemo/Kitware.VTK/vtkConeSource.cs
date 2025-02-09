using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkConeSource
/// </summary>
/// <remarks>
///    generate polygonal cone
///
/// vtkConeSource creates a cone centered at a specified point and pointing in
/// a specified direction. (By default, the center is the origin and the
/// direction is the x-axis.) Depending upon the resolution of this object,
/// different representations are created. If resolution=0 a line is created;
/// if resolution=1, a single triangle is created; if resolution=2, two
/// crossed triangles are created. For resolution &gt; 2, a 3D cone (with
/// resolution number of sides) is created. It also is possible to control
/// whether the bottom of the cone is capped with a (resolution-sided)
/// polygon, and to specify the height and radius of the cone.
/// </remarks>
public class vtkConeSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkConeSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkConeSource()
	{
		MRClassNameKey = "class vtkConeSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkConeSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkConeSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConeSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with default resolution 6, height 1.0, radius 0.5, and
	/// capping on. The cone is centered at the origin and points down
	/// the x-axis.
	/// </summary>
	public new static vtkConeSource New()
	{
		vtkConeSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConeSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with default resolution 6, height 1.0, radius 0.5, and
	/// capping on. The cone is centered at the origin and points down
	/// the x-axis.
	/// </summary>
	public vtkConeSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkConeSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkConeSource_CappingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to cap the base of the cone with a polygon.
	/// </summary>
	public virtual void CappingOff()
	{
		vtkConeSource_CappingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_CappingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to cap the base of the cone with a polygon.
	/// </summary>
	public virtual void CappingOn()
	{
		vtkConeSource_CappingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConeSource_GetAngle_03(HandleRef pThis);

	/// <summary>
	/// Set the angle of the cone. This is the angle between the axis of the cone
	/// and a generatrix. Warning: this is not the aperture! The aperture is
	/// twice this angle.
	/// As a side effect, the angle plus height sets the base radius of the cone.
	/// Angle is expressed in degrees.
	/// </summary>
	public double GetAngle()
	{
		return vtkConeSource_GetAngle_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConeSource_GetCapping_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to cap the base of the cone with a polygon.
	/// </summary>
	public virtual int GetCapping()
	{
		return vtkConeSource_GetCapping_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConeSource_GetCenter_05(HandleRef pThis);

	/// <summary>
	/// Set the center of the cone. It is located at the middle of the axis of
	/// the cone. Warning: this is not the center of the base of the cone!
	/// The default is 0,0,0.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkConeSource_GetCenter_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_GetCenter_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the center of the cone. It is located at the middle of the axis of
	/// the cone. Warning: this is not the center of the base of the cone!
	/// The default is 0,0,0.
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkConeSource_GetCenter_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConeSource_GetDirection_07(HandleRef pThis);

	/// <summary>
	/// Set the orientation vector of the cone. The vector does not have
	/// to be normalized. The direction goes from the center of the base toward
	/// the apex. The default is (1,0,0).
	/// </summary>
	public virtual double[] GetDirection()
	{
		IntPtr intPtr = vtkConeSource_GetDirection_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_GetDirection_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the orientation vector of the cone. The vector does not have
	/// to be normalized. The direction goes from the center of the base toward
	/// the apex. The default is (1,0,0).
	/// </summary>
	public virtual void GetDirection(IntPtr data)
	{
		vtkConeSource_GetDirection_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConeSource_GetHeight_09(HandleRef pThis);

	/// <summary>
	/// Set the height of the cone. This is the height along the cone in
	/// its specified direction.
	/// </summary>
	public virtual double GetHeight()
	{
		return vtkConeSource_GetHeight_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConeSource_GetHeightMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set the height of the cone. This is the height along the cone in
	/// its specified direction.
	/// </summary>
	public virtual double GetHeightMaxValue()
	{
		return vtkConeSource_GetHeightMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConeSource_GetHeightMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set the height of the cone. This is the height along the cone in
	/// its specified direction.
	/// </summary>
	public virtual double GetHeightMinValue()
	{
		return vtkConeSource_GetHeightMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConeSource_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkConeSource_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConeSource_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkConeSource_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConeSource_GetOutputPointsPrecision_14(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkConeSource_GetOutputPointsPrecision_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConeSource_GetRadius_15(HandleRef pThis);

	/// <summary>
	/// Set the base radius of the cone.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkConeSource_GetRadius_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConeSource_GetRadiusMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set the base radius of the cone.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkConeSource_GetRadiusMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConeSource_GetRadiusMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set the base radius of the cone.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkConeSource_GetRadiusMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConeSource_GetResolution_18(HandleRef pThis);

	/// <summary>
	/// Set the number of facets used to represent the cone.
	/// </summary>
	public virtual int GetResolution()
	{
		return vtkConeSource_GetResolution_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConeSource_GetResolutionMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set the number of facets used to represent the cone.
	/// </summary>
	public virtual int GetResolutionMaxValue()
	{
		return vtkConeSource_GetResolutionMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConeSource_GetResolutionMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set the number of facets used to represent the cone.
	/// </summary>
	public virtual int GetResolutionMinValue()
	{
		return vtkConeSource_GetResolutionMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConeSource_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkConeSource_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConeSource_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkConeSource_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConeSource_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkConeSource NewInstance()
	{
		vtkConeSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConeSource_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConeSource_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConeSource SafeDownCast(vtkObjectBase o)
	{
		vtkConeSource vtkConeSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConeSource_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConeSource2 = (vtkConeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConeSource2.Register(null);
			}
		}
		return vtkConeSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_SetAngle_26(HandleRef pThis, double angle);

	/// <summary>
	/// Set the angle of the cone. This is the angle between the axis of the cone
	/// and a generatrix. Warning: this is not the aperture! The aperture is
	/// twice this angle.
	/// As a side effect, the angle plus height sets the base radius of the cone.
	/// Angle is expressed in degrees.
	/// </summary>
	public void SetAngle(double angle)
	{
		vtkConeSource_SetAngle_26(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_SetCapping_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off whether to cap the base of the cone with a polygon.
	/// </summary>
	public virtual void SetCapping(int _arg)
	{
		vtkConeSource_SetCapping_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_SetCenter_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the center of the cone. It is located at the middle of the axis of
	/// the cone. Warning: this is not the center of the base of the cone!
	/// The default is 0,0,0.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkConeSource_SetCenter_28(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_SetCenter_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the center of the cone. It is located at the middle of the axis of
	/// the cone. Warning: this is not the center of the base of the cone!
	/// The default is 0,0,0.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkConeSource_SetCenter_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_SetDirection_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the orientation vector of the cone. The vector does not have
	/// to be normalized. The direction goes from the center of the base toward
	/// the apex. The default is (1,0,0).
	/// </summary>
	public virtual void SetDirection(double _arg1, double _arg2, double _arg3)
	{
		vtkConeSource_SetDirection_30(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_SetDirection_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientation vector of the cone. The vector does not have
	/// to be normalized. The direction goes from the center of the base toward
	/// the apex. The default is (1,0,0).
	/// </summary>
	public virtual void SetDirection(IntPtr _arg)
	{
		vtkConeSource_SetDirection_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_SetHeight_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the height of the cone. This is the height along the cone in
	/// its specified direction.
	/// </summary>
	public virtual void SetHeight(double _arg)
	{
		vtkConeSource_SetHeight_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_SetOutputPointsPrecision_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkConeSource_SetOutputPointsPrecision_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_SetRadius_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the base radius of the cone.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkConeSource_SetRadius_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeSource_SetResolution_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of facets used to represent the cone.
	/// </summary>
	public virtual void SetResolution(int _arg)
	{
		vtkConeSource_SetResolution_35(GetCppThis(), _arg);
	}
}
