using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSuperquadricSource
/// </summary>
/// <remarks>
///    create a polygonal superquadric centered
/// at the origin
///
/// vtkSuperquadricSource creates a superquadric (represented by polygons) of
/// specified size centered at the origin. The alignment of the axis of the
/// superquadric along one of the global axes can be specified. The resolution
/// (polygonal discretization)
/// in both the latitude (phi) and longitude (theta) directions can be
/// specified. Roundness parameters (PhiRoundness and ThetaRoundness) control
/// the shape of the superquadric.  The Toroidal boolean controls whether
/// a toroidal superquadric is produced.  If so, the Thickness parameter
/// controls the thickness of the toroid:  0 is the thinnest allowable
/// toroid, and 1 has a minimum sized hole.  The Scale parameters allow
/// the superquadric to be scaled in x, y, and z (normal vectors are correctly
/// generated in any case).  The Size parameter controls size of the
/// superquadric.
///
/// This code is based on "Rigid physically based superquadrics", A. H. Barr,
/// in "Graphics Gems III", David Kirk, ed., Academic Press, 1992.
///
/// @warning
/// Resolution means the number of latitude or longitude lines for a complete
/// superquadric. The resolution parameters are rounded to the nearest 4
/// in phi and 8 in theta.
///
/// @warning
/// Texture coordinates are not equally distributed around all superquadrics.
///
/// @warning
/// The Size and Thickness parameters control coefficients of superquadric
/// generation, and may do not exactly describe the size of the superquadric.
///
/// </remarks>
public class vtkSuperquadricSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSuperquadricSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSuperquadricSource()
	{
		MRClassNameKey = "class vtkSuperquadricSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSuperquadricSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSuperquadricSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSuperquadricSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a default superquadric with a radius of 0.5, non-toroidal,
	/// spherical, and centered at the origin, with a scaling factor of 1 in each
	/// direction, a theta resolution and a phi resolutions of 16.
	/// </summary>
	public new static vtkSuperquadricSource New()
	{
		vtkSuperquadricSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSuperquadricSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSuperquadricSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a default superquadric with a radius of 0.5, non-toroidal,
	/// spherical, and centered at the origin, with a scaling factor of 1 in each
	/// direction, a theta resolution and a phi resolutions of 16.
	/// </summary>
	public vtkSuperquadricSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSuperquadricSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSuperquadricSource_GetAxisOfSymmetry_01(HandleRef pThis);

	/// <summary>
	/// Set/Get axis of symmetry for superquadric (x axis: 0, y axis: 1, z axis: 2). Initial value
	/// is 1.
	/// </summary>
	public virtual int GetAxisOfSymmetry()
	{
		return vtkSuperquadricSource_GetAxisOfSymmetry_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSuperquadricSource_GetCenter_02(HandleRef pThis);

	/// <summary>
	/// Set the center of the superquadric. Default is 0,0,0.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkSuperquadricSource_GetCenter_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_GetCenter_03(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the center of the superquadric. Default is 0,0,0.
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkSuperquadricSource_GetCenter_03(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSuperquadricSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Create a default superquadric with a radius of 0.5, non-toroidal,
	/// spherical, and centered at the origin, with a scaling factor of 1 in each
	/// direction, a theta resolution and a phi resolutions of 16.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSuperquadricSource_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSuperquadricSource_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Create a default superquadric with a radius of 0.5, non-toroidal,
	/// spherical, and centered at the origin, with a scaling factor of 1 in each
	/// direction, a theta resolution and a phi resolutions of 16.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSuperquadricSource_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSuperquadricSource_GetOutputPointsPrecision_06(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkSuperquadricSource_GetOutputPointsPrecision_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSuperquadricSource_GetPhiResolution_07(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the latitude direction. Initial value is 16.
	/// </summary>
	public virtual int GetPhiResolution()
	{
		return vtkSuperquadricSource_GetPhiResolution_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadricSource_GetPhiRoundness_08(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric north/south roundness.
	/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
	/// Initial value is 1.0.
	/// </summary>
	public virtual double GetPhiRoundness()
	{
		return vtkSuperquadricSource_GetPhiRoundness_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSuperquadricSource_GetScale_09(HandleRef pThis);

	/// <summary>
	/// Set the scale factors of the superquadric. Default is 1,1,1.
	/// </summary>
	public virtual double[] GetScale()
	{
		IntPtr intPtr = vtkSuperquadricSource_GetScale_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_GetScale_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the scale factors of the superquadric. Default is 1,1,1.
	/// </summary>
	public virtual void GetScale(IntPtr data)
	{
		vtkSuperquadricSource_GetScale_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadricSource_GetSize_11(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric isotropic size. Initial value is 0.5;
	/// </summary>
	public virtual double GetSize()
	{
		return vtkSuperquadricSource_GetSize_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSuperquadricSource_GetThetaResolution_12(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the longitude direction. Initial value is 16.
	/// </summary>
	public virtual int GetThetaResolution()
	{
		return vtkSuperquadricSource_GetThetaResolution_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadricSource_GetThetaRoundness_13(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric east/west roundness.
	/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
	/// Initial value is 1.0.
	/// </summary>
	public virtual double GetThetaRoundness()
	{
		return vtkSuperquadricSource_GetThetaRoundness_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadricSource_GetThickness_14(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric ring thickness (toroids only).
	/// Changing thickness maintains the outside diameter of the toroid.
	/// Initial value is 0.3333.
	/// </summary>
	public virtual double GetThickness()
	{
		return vtkSuperquadricSource_GetThickness_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadricSource_GetThicknessMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric ring thickness (toroids only).
	/// Changing thickness maintains the outside diameter of the toroid.
	/// Initial value is 0.3333.
	/// </summary>
	public virtual double GetThicknessMaxValue()
	{
		return vtkSuperquadricSource_GetThicknessMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadricSource_GetThicknessMinValue_16(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric ring thickness (toroids only).
	/// Changing thickness maintains the outside diameter of the toroid.
	/// Initial value is 0.3333.
	/// </summary>
	public virtual double GetThicknessMinValue()
	{
		return vtkSuperquadricSource_GetThicknessMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSuperquadricSource_GetToroidal_17(HandleRef pThis);

	/// <summary>
	/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
	/// Initial value is 0.
	/// </summary>
	public virtual int GetToroidal()
	{
		return vtkSuperquadricSource_GetToroidal_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSuperquadricSource_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Create a default superquadric with a radius of 0.5, non-toroidal,
	/// spherical, and centered at the origin, with a scaling factor of 1 in each
	/// direction, a theta resolution and a phi resolutions of 16.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSuperquadricSource_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSuperquadricSource_IsTypeOf_19(string type);

	/// <summary>
	/// Create a default superquadric with a radius of 0.5, non-toroidal,
	/// spherical, and centered at the origin, with a scaling factor of 1 in each
	/// direction, a theta resolution and a phi resolutions of 16.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSuperquadricSource_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSuperquadricSource_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a default superquadric with a radius of 0.5, non-toroidal,
	/// spherical, and centered at the origin, with a scaling factor of 1 in each
	/// direction, a theta resolution and a phi resolutions of 16.
	/// </summary>
	public new vtkSuperquadricSource NewInstance()
	{
		vtkSuperquadricSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSuperquadricSource_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSuperquadricSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSuperquadricSource_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a default superquadric with a radius of 0.5, non-toroidal,
	/// spherical, and centered at the origin, with a scaling factor of 1 in each
	/// direction, a theta resolution and a phi resolutions of 16.
	/// </summary>
	public new static vtkSuperquadricSource SafeDownCast(vtkObjectBase o)
	{
		vtkSuperquadricSource vtkSuperquadricSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSuperquadricSource_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSuperquadricSource2 = (vtkSuperquadricSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSuperquadricSource2.Register(null);
			}
		}
		return vtkSuperquadricSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetAxisOfSymmetry_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get axis of symmetry for superquadric (x axis: 0, y axis: 1, z axis: 2). Initial value
	/// is 1.
	/// </summary>
	public virtual void SetAxisOfSymmetry(int _arg)
	{
		vtkSuperquadricSource_SetAxisOfSymmetry_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetCenter_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the center of the superquadric. Default is 0,0,0.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkSuperquadricSource_SetCenter_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetCenter_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the center of the superquadric. Default is 0,0,0.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkSuperquadricSource_SetCenter_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetOutputPointsPrecision_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkSuperquadricSource_SetOutputPointsPrecision_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetPhiResolution_27(HandleRef pThis, int i);

	/// <summary>
	/// Set the number of points in the latitude direction. Initial value is 16.
	/// </summary>
	public void SetPhiResolution(int i)
	{
		vtkSuperquadricSource_SetPhiResolution_27(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetPhiRoundness_28(HandleRef pThis, double e);

	/// <summary>
	/// Set/Get Superquadric north/south roundness.
	/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
	/// Initial value is 1.0.
	/// </summary>
	public void SetPhiRoundness(double e)
	{
		vtkSuperquadricSource_SetPhiRoundness_28(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetScale_29(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the scale factors of the superquadric. Default is 1,1,1.
	/// </summary>
	public virtual void SetScale(double _arg1, double _arg2, double _arg3)
	{
		vtkSuperquadricSource_SetScale_29(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetScale_30(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scale factors of the superquadric. Default is 1,1,1.
	/// </summary>
	public virtual void SetScale(IntPtr _arg)
	{
		vtkSuperquadricSource_SetScale_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetSize_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get Superquadric isotropic size. Initial value is 0.5;
	/// </summary>
	public virtual void SetSize(double _arg)
	{
		vtkSuperquadricSource_SetSize_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetThetaResolution_32(HandleRef pThis, int i);

	/// <summary>
	/// Set the number of points in the longitude direction. Initial value is 16.
	/// </summary>
	public void SetThetaResolution(int i)
	{
		vtkSuperquadricSource_SetThetaResolution_32(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetThetaRoundness_33(HandleRef pThis, double e);

	/// <summary>
	/// Set/Get Superquadric east/west roundness.
	/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
	/// Initial value is 1.0.
	/// </summary>
	public void SetThetaRoundness(double e)
	{
		vtkSuperquadricSource_SetThetaRoundness_33(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetThickness_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get Superquadric ring thickness (toroids only).
	/// Changing thickness maintains the outside diameter of the toroid.
	/// Initial value is 0.3333.
	/// </summary>
	public virtual void SetThickness(double _arg)
	{
		vtkSuperquadricSource_SetThickness_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetToroidal_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
	/// Initial value is 0.
	/// </summary>
	public virtual void SetToroidal(int _arg)
	{
		vtkSuperquadricSource_SetToroidal_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetXAxisOfSymmetry_36(HandleRef pThis);

	/// <summary>
	/// Set/Get axis of symmetry for superquadric (x axis: 0, y axis: 1, z axis: 2). Initial value
	/// is 1.
	/// </summary>
	public void SetXAxisOfSymmetry()
	{
		vtkSuperquadricSource_SetXAxisOfSymmetry_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetYAxisOfSymmetry_37(HandleRef pThis);

	/// <summary>
	/// Set/Get axis of symmetry for superquadric (x axis: 0, y axis: 1, z axis: 2). Initial value
	/// is 1.
	/// </summary>
	public void SetYAxisOfSymmetry()
	{
		vtkSuperquadricSource_SetYAxisOfSymmetry_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_SetZAxisOfSymmetry_38(HandleRef pThis);

	/// <summary>
	/// Set/Get axis of symmetry for superquadric (x axis: 0, y axis: 1, z axis: 2). Initial value
	/// is 1.
	/// </summary>
	public void SetZAxisOfSymmetry()
	{
		vtkSuperquadricSource_SetZAxisOfSymmetry_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_ToroidalOff_39(HandleRef pThis);

	/// <summary>
	/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
	/// Initial value is 0.
	/// </summary>
	public virtual void ToroidalOff()
	{
		vtkSuperquadricSource_ToroidalOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadricSource_ToroidalOn_40(HandleRef pThis);

	/// <summary>
	/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
	/// Initial value is 0.
	/// </summary>
	public virtual void ToroidalOn()
	{
		vtkSuperquadricSource_ToroidalOn_40(GetCppThis());
	}
}
