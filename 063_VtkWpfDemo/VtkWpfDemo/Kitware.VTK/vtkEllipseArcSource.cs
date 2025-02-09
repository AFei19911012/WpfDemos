using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEllipseArcSource
/// </summary>
/// <remarks>
///    create an elliptical arc
///
///
/// vtkEllipseArcSource is a source object that creates an elliptical arc
/// defined by a normal, a center and the major radius vector.
/// You can define an angle to draw only a section of the ellipse. The number of
/// segments composing the polyline is controlled by setting the object
/// resolution.
///
/// </remarks>
/// <seealso>
///
/// vtkArcSource
/// </seealso>
public class vtkEllipseArcSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEllipseArcSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEllipseArcSource()
	{
		MRClassNameKey = "class vtkEllipseArcSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEllipseArcSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEllipseArcSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipseArcSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEllipseArcSource New()
	{
		vtkEllipseArcSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipseArcSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEllipseArcSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkEllipseArcSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEllipseArcSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkEllipseArcSource_CloseOff_01(HandleRef pThis);

	/// <summary>
	/// Set/get whether to close the arc with a final line segment connecting the first
	/// and last points in the arc. Off by default
	/// </summary>
	public virtual void CloseOff()
	{
		vtkEllipseArcSource_CloseOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_CloseOn_02(HandleRef pThis);

	/// <summary>
	/// Set/get whether to close the arc with a final line segment connecting the first
	/// and last points in the arc. Off by default
	/// </summary>
	public virtual void CloseOn()
	{
		vtkEllipseArcSource_CloseOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipseArcSource_GetCenter_03(HandleRef pThis);

	/// <summary>
	/// Set position of the center of the ellipse that define the arc.
	/// Default is 0, 0, 0.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkEllipseArcSource_GetCenter_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_GetCenter_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set position of the center of the ellipse that define the arc.
	/// Default is 0, 0, 0.
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkEllipseArcSource_GetCenter_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkEllipseArcSource_GetClose_05(HandleRef pThis);

	/// <summary>
	/// Set/get whether to close the arc with a final line segment connecting the first
	/// and last points in the arc. Off by default
	/// </summary>
	public virtual bool GetClose()
	{
		return (vtkEllipseArcSource_GetClose_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipseArcSource_GetMajorRadiusVector_06(HandleRef pThis);

	/// <summary>
	/// Set Major Radius Vector. It defines the origin of polar angle and the major
	/// radius size.
	/// Default is 1, 0, 0.
	/// </summary>
	public virtual double[] GetMajorRadiusVector()
	{
		IntPtr intPtr = vtkEllipseArcSource_GetMajorRadiusVector_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_GetMajorRadiusVector_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set Major Radius Vector. It defines the origin of polar angle and the major
	/// radius size.
	/// Default is 1, 0, 0.
	/// </summary>
	public virtual void GetMajorRadiusVector(IntPtr data)
	{
		vtkEllipseArcSource_GetMajorRadiusVector_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipseArcSource_GetNormal_08(HandleRef pThis);

	/// <summary>
	/// Set normal vector. Represents the plane in which the ellipse will be drawn.
	/// Default 0, 0, 1.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkEllipseArcSource_GetNormal_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_GetNormal_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set normal vector. Represents the plane in which the ellipse will be drawn.
	/// Default 0, 0, 1.
	/// </summary>
	public virtual void GetNormal(IntPtr data)
	{
		vtkEllipseArcSource_GetNormal_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEllipseArcSource_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEllipseArcSource_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEllipseArcSource_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEllipseArcSource_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipseArcSource_GetOutputPointsPrecision_12(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point,
	/// This is the default.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkEllipseArcSource_GetOutputPointsPrecision_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipseArcSource_GetRatio_13(HandleRef pThis);

	/// <summary>
	/// Set the ratio of the ellipse, i.e. the ratio b/a _ b: minor radius;
	/// a: major radius
	/// default is 1.
	/// </summary>
	public virtual double GetRatio()
	{
		return vtkEllipseArcSource_GetRatio_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipseArcSource_GetRatioMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set the ratio of the ellipse, i.e. the ratio b/a _ b: minor radius;
	/// a: major radius
	/// default is 1.
	/// </summary>
	public virtual double GetRatioMaxValue()
	{
		return vtkEllipseArcSource_GetRatioMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipseArcSource_GetRatioMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set the ratio of the ellipse, i.e. the ratio b/a _ b: minor radius;
	/// a: major radius
	/// default is 1.
	/// </summary>
	public virtual double GetRatioMinValue()
	{
		return vtkEllipseArcSource_GetRatioMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipseArcSource_GetResolution_16(HandleRef pThis);

	/// <summary>
	/// Divide line into resolution number of pieces.
	/// Note: if Resolution is set to 1 the arc is a
	/// straight line. Default is 100.
	/// </summary>
	public virtual int GetResolution()
	{
		return vtkEllipseArcSource_GetResolution_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipseArcSource_GetResolutionMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Divide line into resolution number of pieces.
	/// Note: if Resolution is set to 1 the arc is a
	/// straight line. Default is 100.
	/// </summary>
	public virtual int GetResolutionMaxValue()
	{
		return vtkEllipseArcSource_GetResolutionMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipseArcSource_GetResolutionMinValue_18(HandleRef pThis);

	/// <summary>
	/// Divide line into resolution number of pieces.
	/// Note: if Resolution is set to 1 the arc is a
	/// straight line. Default is 100.
	/// </summary>
	public virtual int GetResolutionMinValue()
	{
		return vtkEllipseArcSource_GetResolutionMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipseArcSource_GetSegmentAngle_19(HandleRef pThis);

	/// <summary>
	/// Angular sector occupied by the arc, beginning at Start Angle
	/// Default is 90.
	/// </summary>
	public virtual double GetSegmentAngle()
	{
		return vtkEllipseArcSource_GetSegmentAngle_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipseArcSource_GetSegmentAngleMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Angular sector occupied by the arc, beginning at Start Angle
	/// Default is 90.
	/// </summary>
	public virtual double GetSegmentAngleMaxValue()
	{
		return vtkEllipseArcSource_GetSegmentAngleMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipseArcSource_GetSegmentAngleMinValue_21(HandleRef pThis);

	/// <summary>
	/// Angular sector occupied by the arc, beginning at Start Angle
	/// Default is 90.
	/// </summary>
	public virtual double GetSegmentAngleMinValue()
	{
		return vtkEllipseArcSource_GetSegmentAngleMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipseArcSource_GetStartAngle_22(HandleRef pThis);

	/// <summary>
	/// Set the start angle. The angle where the plot begins.
	/// Default is 0.
	/// </summary>
	public virtual double GetStartAngle()
	{
		return vtkEllipseArcSource_GetStartAngle_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipseArcSource_GetStartAngleMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set the start angle. The angle where the plot begins.
	/// Default is 0.
	/// </summary>
	public virtual double GetStartAngleMaxValue()
	{
		return vtkEllipseArcSource_GetStartAngleMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipseArcSource_GetStartAngleMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set the start angle. The angle where the plot begins.
	/// Default is 0.
	/// </summary>
	public virtual double GetStartAngleMinValue()
	{
		return vtkEllipseArcSource_GetStartAngleMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipseArcSource_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEllipseArcSource_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipseArcSource_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEllipseArcSource_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipseArcSource_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEllipseArcSource NewInstance()
	{
		vtkEllipseArcSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipseArcSource_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEllipseArcSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipseArcSource_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEllipseArcSource SafeDownCast(vtkObjectBase o)
	{
		vtkEllipseArcSource vtkEllipseArcSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipseArcSource_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEllipseArcSource2 = (vtkEllipseArcSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEllipseArcSource2.Register(null);
			}
		}
		return vtkEllipseArcSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetCenter_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set position of the center of the ellipse that define the arc.
	/// Default is 0, 0, 0.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkEllipseArcSource_SetCenter_30(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetCenter_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set position of the center of the ellipse that define the arc.
	/// Default is 0, 0, 0.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkEllipseArcSource_SetCenter_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetClose_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get whether to close the arc with a final line segment connecting the first
	/// and last points in the arc. Off by default
	/// </summary>
	public virtual void SetClose(bool _arg)
	{
		vtkEllipseArcSource_SetClose_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetMajorRadiusVector_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set Major Radius Vector. It defines the origin of polar angle and the major
	/// radius size.
	/// Default is 1, 0, 0.
	/// </summary>
	public virtual void SetMajorRadiusVector(double _arg1, double _arg2, double _arg3)
	{
		vtkEllipseArcSource_SetMajorRadiusVector_33(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetMajorRadiusVector_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set Major Radius Vector. It defines the origin of polar angle and the major
	/// radius size.
	/// Default is 1, 0, 0.
	/// </summary>
	public virtual void SetMajorRadiusVector(IntPtr _arg)
	{
		vtkEllipseArcSource_SetMajorRadiusVector_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetNormal_35(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set normal vector. Represents the plane in which the ellipse will be drawn.
	/// Default 0, 0, 1.
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkEllipseArcSource_SetNormal_35(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetNormal_36(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set normal vector. Represents the plane in which the ellipse will be drawn.
	/// Default 0, 0, 1.
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkEllipseArcSource_SetNormal_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetOutputPointsPrecision_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point,
	/// This is the default.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkEllipseArcSource_SetOutputPointsPrecision_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetRatio_38(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the ratio of the ellipse, i.e. the ratio b/a _ b: minor radius;
	/// a: major radius
	/// default is 1.
	/// </summary>
	public virtual void SetRatio(double _arg)
	{
		vtkEllipseArcSource_SetRatio_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetResolution_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Divide line into resolution number of pieces.
	/// Note: if Resolution is set to 1 the arc is a
	/// straight line. Default is 100.
	/// </summary>
	public virtual void SetResolution(int _arg)
	{
		vtkEllipseArcSource_SetResolution_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetSegmentAngle_40(HandleRef pThis, double _arg);

	/// <summary>
	/// Angular sector occupied by the arc, beginning at Start Angle
	/// Default is 90.
	/// </summary>
	public virtual void SetSegmentAngle(double _arg)
	{
		vtkEllipseArcSource_SetSegmentAngle_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipseArcSource_SetStartAngle_41(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the start angle. The angle where the plot begins.
	/// Default is 0.
	/// </summary>
	public virtual void SetStartAngle(double _arg)
	{
		vtkEllipseArcSource_SetStartAngle_41(GetCppThis(), _arg);
	}
}
