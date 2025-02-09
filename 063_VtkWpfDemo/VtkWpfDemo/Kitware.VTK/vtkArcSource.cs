using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkArcSource
/// </summary>
/// <remarks>
///    create a circular arc
///
///
/// vtkArcSource is a source object that creates an arc defined by two
/// endpoints and a center. The number of segments composing the polyline
/// is controlled by setting the object resolution.
/// Alternatively, one can use a better API (that does not allow for
/// inconsistent nor ambiguous inputs), using a starting point (polar vector,
/// measured from the arc's center), a normal to the plane of the arc,
/// and an angle defining the arc length.
/// Since the default API remains the original one, in order to use
/// the improved API, one must switch the UseNormalAndAngle flag to TRUE.
///
/// The development of an improved, consistent API (based on point, normal,
/// and angle) was supported by CEA/DIF - Commissariat a l'Energie Atomique,
/// Centre DAM Ile-De-France, BP12, F-91297 Arpajon, France, and implemented
/// by Philippe Pebay, Kitware SAS 2012.
///
/// </remarks>
/// <seealso>
///
/// vtkEllipseArcSource
/// </seealso>
public class vtkArcSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkArcSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkArcSource()
	{
		MRClassNameKey = "class vtkArcSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkArcSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkArcSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkArcSource New()
	{
		vtkArcSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArcSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArcSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkArcSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkArcSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkArcSource_GetAngle_01(HandleRef pThis);

	/// <summary>
	/// Arc length (in degrees), beginning at the polar vector.
	/// The direction is counterclockwise by default;
	/// a negative value draws the arc in the clockwise direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual double GetAngle()
	{
		return vtkArcSource_GetAngle_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArcSource_GetAngleMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Arc length (in degrees), beginning at the polar vector.
	/// The direction is counterclockwise by default;
	/// a negative value draws the arc in the clockwise direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual double GetAngleMaxValue()
	{
		return vtkArcSource_GetAngleMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArcSource_GetAngleMinValue_03(HandleRef pThis);

	/// <summary>
	/// Arc length (in degrees), beginning at the polar vector.
	/// The direction is counterclockwise by default;
	/// a negative value draws the arc in the clockwise direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual double GetAngleMinValue()
	{
		return vtkArcSource_GetAngleMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcSource_GetCenter_04(HandleRef pThis);

	/// <summary>
	/// Set position of the center of the circle that defines the arc.
	/// Note: you can use the function vtkMath::Solve3PointCircle to
	/// find the center from 3 points located on a circle.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkArcSource_GetCenter_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_GetCenter_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set position of the center of the circle that defines the arc.
	/// Note: you can use the function vtkMath::Solve3PointCircle to
	/// find the center from 3 points located on a circle.
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkArcSource_GetCenter_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArcSource_GetNegative_06(HandleRef pThis);

	/// <summary>
	/// By default the arc spans the shortest angular sector point1 and point2.
	/// By setting this to true, the longest angular sector is used instead
	/// (i.e. the negative coterminal angle to the shortest one).
	/// Note: This is only used when UseNormalAndAngle is OFF. False by default.
	/// </summary>
	public virtual bool GetNegative()
	{
		return (vtkArcSource_GetNegative_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcSource_GetNormal_07(HandleRef pThis);

	/// <summary>
	/// Set the normal vector to the plane of the arc.
	/// By default it points in the positive Z direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkArcSource_GetNormal_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_GetNormal_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the normal vector to the plane of the arc.
	/// By default it points in the positive Z direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual void GetNormal(IntPtr data)
	{
		vtkArcSource_GetNormal_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArcSource_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkArcSource_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArcSource_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkArcSource_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcSource_GetOutputPointsPrecision_11(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkArcSource_GetOutputPointsPrecision_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcSource_GetPoint1_12(HandleRef pThis);

	/// <summary>
	/// Set position of the first end point.
	/// </summary>
	public virtual double[] GetPoint1()
	{
		IntPtr intPtr = vtkArcSource_GetPoint1_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_GetPoint1_13(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set position of the first end point.
	/// </summary>
	public virtual void GetPoint1(IntPtr data)
	{
		vtkArcSource_GetPoint1_13(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcSource_GetPoint2_14(HandleRef pThis);

	/// <summary>
	/// Set position of the other end point.
	/// </summary>
	public virtual double[] GetPoint2()
	{
		IntPtr intPtr = vtkArcSource_GetPoint2_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_GetPoint2_15(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set position of the other end point.
	/// </summary>
	public virtual void GetPoint2(IntPtr data)
	{
		vtkArcSource_GetPoint2_15(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcSource_GetPolarVector_16(HandleRef pThis);

	/// <summary>
	/// Set polar vector (starting point of the arc).
	/// By default it is the unit vector in the positive X direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual double[] GetPolarVector()
	{
		IntPtr intPtr = vtkArcSource_GetPolarVector_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_GetPolarVector_17(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set polar vector (starting point of the arc).
	/// By default it is the unit vector in the positive X direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual void GetPolarVector(IntPtr data)
	{
		vtkArcSource_GetPolarVector_17(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcSource_GetResolution_18(HandleRef pThis);

	/// <summary>
	/// Define the number of segments of the polyline that draws the arc.
	/// Note: if the resolution is set to 1 (the default value),
	/// the arc is drawn as a straight line.
	/// </summary>
	public virtual int GetResolution()
	{
		return vtkArcSource_GetResolution_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcSource_GetResolutionMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Define the number of segments of the polyline that draws the arc.
	/// Note: if the resolution is set to 1 (the default value),
	/// the arc is drawn as a straight line.
	/// </summary>
	public virtual int GetResolutionMaxValue()
	{
		return vtkArcSource_GetResolutionMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcSource_GetResolutionMinValue_20(HandleRef pThis);

	/// <summary>
	/// Define the number of segments of the polyline that draws the arc.
	/// Note: if the resolution is set to 1 (the default value),
	/// the arc is drawn as a straight line.
	/// </summary>
	public virtual int GetResolutionMinValue()
	{
		return vtkArcSource_GetResolutionMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArcSource_GetUseNormalAndAngle_21(HandleRef pThis);

	/// <summary>
	/// Activate the API based on a normal vector, a starting point
	/// (polar vector) and an angle defining the arc length.
	/// The previous API (which remains the default) allows for inputs that are
	/// inconsistent (when Point1 and Point2 are not equidistant from Center)
	/// or ambiguous (when Point1, Point2, and Center are aligned).
	/// Note: false by default.
	/// </summary>
	public virtual bool GetUseNormalAndAngle()
	{
		return (vtkArcSource_GetUseNormalAndAngle_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcSource_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkArcSource_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcSource_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkArcSource_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_NegativeOff_24(HandleRef pThis);

	/// <summary>
	/// By default the arc spans the shortest angular sector point1 and point2.
	/// By setting this to true, the longest angular sector is used instead
	/// (i.e. the negative coterminal angle to the shortest one).
	/// Note: This is only used when UseNormalAndAngle is OFF. False by default.
	/// </summary>
	public virtual void NegativeOff()
	{
		vtkArcSource_NegativeOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_NegativeOn_25(HandleRef pThis);

	/// <summary>
	/// By default the arc spans the shortest angular sector point1 and point2.
	/// By setting this to true, the longest angular sector is used instead
	/// (i.e. the negative coterminal angle to the shortest one).
	/// Note: This is only used when UseNormalAndAngle is OFF. False by default.
	/// </summary>
	public virtual void NegativeOn()
	{
		vtkArcSource_NegativeOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcSource_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkArcSource NewInstance()
	{
		vtkArcSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArcSource_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArcSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcSource_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkArcSource SafeDownCast(vtkObjectBase o)
	{
		vtkArcSource vtkArcSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArcSource_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArcSource2 = (vtkArcSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArcSource2.Register(null);
			}
		}
		return vtkArcSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetAngle_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Arc length (in degrees), beginning at the polar vector.
	/// The direction is counterclockwise by default;
	/// a negative value draws the arc in the clockwise direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual void SetAngle(double _arg)
	{
		vtkArcSource_SetAngle_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetCenter_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set position of the center of the circle that defines the arc.
	/// Note: you can use the function vtkMath::Solve3PointCircle to
	/// find the center from 3 points located on a circle.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkArcSource_SetCenter_30(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetCenter_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set position of the center of the circle that defines the arc.
	/// Note: you can use the function vtkMath::Solve3PointCircle to
	/// find the center from 3 points located on a circle.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkArcSource_SetCenter_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetNegative_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// By default the arc spans the shortest angular sector point1 and point2.
	/// By setting this to true, the longest angular sector is used instead
	/// (i.e. the negative coterminal angle to the shortest one).
	/// Note: This is only used when UseNormalAndAngle is OFF. False by default.
	/// </summary>
	public virtual void SetNegative(bool _arg)
	{
		vtkArcSource_SetNegative_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetNormal_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the normal vector to the plane of the arc.
	/// By default it points in the positive Z direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkArcSource_SetNormal_33(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetNormal_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the normal vector to the plane of the arc.
	/// By default it points in the positive Z direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkArcSource_SetNormal_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetOutputPointsPrecision_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkArcSource_SetOutputPointsPrecision_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetPoint1_36(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set position of the first end point.
	/// </summary>
	public virtual void SetPoint1(double _arg1, double _arg2, double _arg3)
	{
		vtkArcSource_SetPoint1_36(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetPoint1_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set position of the first end point.
	/// </summary>
	public virtual void SetPoint1(IntPtr _arg)
	{
		vtkArcSource_SetPoint1_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetPoint2_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set position of the other end point.
	/// </summary>
	public virtual void SetPoint2(double _arg1, double _arg2, double _arg3)
	{
		vtkArcSource_SetPoint2_38(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetPoint2_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set position of the other end point.
	/// </summary>
	public virtual void SetPoint2(IntPtr _arg)
	{
		vtkArcSource_SetPoint2_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetPolarVector_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set polar vector (starting point of the arc).
	/// By default it is the unit vector in the positive X direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual void SetPolarVector(double _arg1, double _arg2, double _arg3)
	{
		vtkArcSource_SetPolarVector_40(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetPolarVector_41(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set polar vector (starting point of the arc).
	/// By default it is the unit vector in the positive X direction.
	/// Note: This is only used when UseNormalAndAngle is ON.
	/// </summary>
	public virtual void SetPolarVector(IntPtr _arg)
	{
		vtkArcSource_SetPolarVector_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetResolution_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Define the number of segments of the polyline that draws the arc.
	/// Note: if the resolution is set to 1 (the default value),
	/// the arc is drawn as a straight line.
	/// </summary>
	public virtual void SetResolution(int _arg)
	{
		vtkArcSource_SetResolution_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_SetUseNormalAndAngle_43(HandleRef pThis, byte _arg);

	/// <summary>
	/// Activate the API based on a normal vector, a starting point
	/// (polar vector) and an angle defining the arc length.
	/// The previous API (which remains the default) allows for inputs that are
	/// inconsistent (when Point1 and Point2 are not equidistant from Center)
	/// or ambiguous (when Point1, Point2, and Center are aligned).
	/// Note: false by default.
	/// </summary>
	public virtual void SetUseNormalAndAngle(bool _arg)
	{
		vtkArcSource_SetUseNormalAndAngle_43(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_UseNormalAndAngleOff_44(HandleRef pThis);

	/// <summary>
	/// Activate the API based on a normal vector, a starting point
	/// (polar vector) and an angle defining the arc length.
	/// The previous API (which remains the default) allows for inputs that are
	/// inconsistent (when Point1 and Point2 are not equidistant from Center)
	/// or ambiguous (when Point1, Point2, and Center are aligned).
	/// Note: false by default.
	/// </summary>
	public virtual void UseNormalAndAngleOff()
	{
		vtkArcSource_UseNormalAndAngleOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcSource_UseNormalAndAngleOn_45(HandleRef pThis);

	/// <summary>
	/// Activate the API based on a normal vector, a starting point
	/// (polar vector) and an angle defining the arc length.
	/// The previous API (which remains the default) allows for inputs that are
	/// inconsistent (when Point1 and Point2 are not equidistant from Center)
	/// or ambiguous (when Point1, Point2, and Center are aligned).
	/// Note: false by default.
	/// </summary>
	public virtual void UseNormalAndAngleOn()
	{
		vtkArcSource_UseNormalAndAngleOn_45(GetCppThis());
	}
}
