using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCapsuleSource
/// </summary>
/// <remarks>
///    Generate a capsule centered at the origin
///
/// vtkCapsuleSource creates a capsule (represented by polygons) of specified
/// radius centered at the origin. The resolution (polygonal discretization) in
/// both the latitude (phi) and longitude (theta) directions can be specified as
/// well as the length of the capsule cylinder (CylinderLength). By default, the
/// surface tessellation of the sphere uses triangles; however you can set
/// LatLongTessellation to produce a tessellation using quadrilaterals (except
/// at the poles of the capsule).
/// </remarks>
public class vtkCapsuleSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCapsuleSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCapsuleSource()
	{
		MRClassNameKey = "class vtkCapsuleSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCapsuleSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCapsuleSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCapsuleSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a capsule with radius 0.5 and resolution 8 in both the Phi and Theta directions and a
	/// cylinder of length 1.0.
	/// </summary>
	public new static vtkCapsuleSource New()
	{
		vtkCapsuleSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCapsuleSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCapsuleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a capsule with radius 0.5 and resolution 8 in both the Phi and Theta directions and a
	/// cylinder of length 1.0.
	/// </summary>
	public vtkCapsuleSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCapsuleSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCapsuleSource_GetCenter_01(HandleRef pThis);

	/// <summary>
	/// Set/get the center of the capsule. The initial value is (0.0, 0.0, 0.0).
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkCapsuleSource_GetCenter_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCapsuleSource_GetCenter_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/get the center of the capsule. The initial value is (0.0, 0.0, 0.0).
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkCapsuleSource_GetCenter_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCapsuleSource_GetCylinderLength_03(HandleRef pThis);

	/// <summary>
	/// Set/get the length of the cylinder. The initial value is 1.0.
	/// </summary>
	public virtual double GetCylinderLength()
	{
		return vtkCapsuleSource_GetCylinderLength_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCapsuleSource_GetCylinderLengthMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set/get the length of the cylinder. The initial value is 1.0.
	/// </summary>
	public virtual double GetCylinderLengthMaxValue()
	{
		return vtkCapsuleSource_GetCylinderLengthMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCapsuleSource_GetCylinderLengthMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set/get the length of the cylinder. The initial value is 1.0.
	/// </summary>
	public virtual double GetCylinderLengthMinValue()
	{
		return vtkCapsuleSource_GetCylinderLengthMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCapsuleSource_GetLatLongTessellation_06(HandleRef pThis);

	/// <summary>
	/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
	/// triangles are generated at non-polar regions, which results in edges that are not parallel to
	/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
	/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
	/// lines.
	/// </summary>
	public virtual int GetLatLongTessellation()
	{
		return vtkCapsuleSource_GetLatLongTessellation_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCapsuleSource_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCapsuleSource_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCapsuleSource_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCapsuleSource_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCapsuleSource_GetOutputPointsPrecision_09(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkCapsuleSource_GetOutputPointsPrecision_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCapsuleSource_GetPhiResolution_10(HandleRef pThis);

	/// <summary>
	/// Set/get the number of points in the latitude direction for the spheres. The initial value is 8.
	/// </summary>
	public virtual int GetPhiResolution()
	{
		return vtkCapsuleSource_GetPhiResolution_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCapsuleSource_GetPhiResolutionMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set/get the number of points in the latitude direction for the spheres. The initial value is 8.
	/// </summary>
	public virtual int GetPhiResolutionMaxValue()
	{
		return vtkCapsuleSource_GetPhiResolutionMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCapsuleSource_GetPhiResolutionMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set/get the number of points in the latitude direction for the spheres. The initial value is 8.
	/// </summary>
	public virtual int GetPhiResolutionMinValue()
	{
		return vtkCapsuleSource_GetPhiResolutionMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCapsuleSource_GetRadius_13(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the capsule. The initial value is 0.5.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkCapsuleSource_GetRadius_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCapsuleSource_GetRadiusMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the capsule. The initial value is 0.5.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkCapsuleSource_GetRadiusMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCapsuleSource_GetRadiusMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the capsule. The initial value is 0.5.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkCapsuleSource_GetRadiusMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCapsuleSource_GetThetaResolution_16(HandleRef pThis);

	/// <summary>
	/// Set/get the number of points in the longitude direction for the spheres. The initial value
	/// is 8.
	/// </summary>
	public virtual int GetThetaResolution()
	{
		return vtkCapsuleSource_GetThetaResolution_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCapsuleSource_GetThetaResolutionMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set/get the number of points in the longitude direction for the spheres. The initial value
	/// is 8.
	/// </summary>
	public virtual int GetThetaResolutionMaxValue()
	{
		return vtkCapsuleSource_GetThetaResolutionMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCapsuleSource_GetThetaResolutionMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set/get the number of points in the longitude direction for the spheres. The initial value
	/// is 8.
	/// </summary>
	public virtual int GetThetaResolutionMinValue()
	{
		return vtkCapsuleSource_GetThetaResolutionMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCapsuleSource_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCapsuleSource_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCapsuleSource_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCapsuleSource_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCapsuleSource_LatLongTessellationOff_21(HandleRef pThis);

	/// <summary>
	/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
	/// triangles are generated at non-polar regions, which results in edges that are not parallel to
	/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
	/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
	/// lines.
	/// </summary>
	public virtual void LatLongTessellationOff()
	{
		vtkCapsuleSource_LatLongTessellationOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCapsuleSource_LatLongTessellationOn_22(HandleRef pThis);

	/// <summary>
	/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
	/// triangles are generated at non-polar regions, which results in edges that are not parallel to
	/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
	/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
	/// lines.
	/// </summary>
	public virtual void LatLongTessellationOn()
	{
		vtkCapsuleSource_LatLongTessellationOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCapsuleSource_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCapsuleSource NewInstance()
	{
		vtkCapsuleSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCapsuleSource_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCapsuleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCapsuleSource_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCapsuleSource SafeDownCast(vtkObjectBase o)
	{
		vtkCapsuleSource vtkCapsuleSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCapsuleSource_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCapsuleSource2 = (vtkCapsuleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCapsuleSource2.Register(null);
			}
		}
		return vtkCapsuleSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCapsuleSource_SetCenter_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/get the center of the capsule. The initial value is (0.0, 0.0, 0.0).
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkCapsuleSource_SetCenter_26(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCapsuleSource_SetCenter_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the center of the capsule. The initial value is (0.0, 0.0, 0.0).
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkCapsuleSource_SetCenter_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCapsuleSource_SetCylinderLength_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the length of the cylinder. The initial value is 1.0.
	/// </summary>
	public virtual void SetCylinderLength(double _arg)
	{
		vtkCapsuleSource_SetCylinderLength_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCapsuleSource_SetLatLongTessellation_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
	/// triangles are generated at non-polar regions, which results in edges that are not parallel to
	/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
	/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
	/// lines.
	/// </summary>
	public virtual void SetLatLongTessellation(int _arg)
	{
		vtkCapsuleSource_SetLatLongTessellation_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCapsuleSource_SetOutputPointsPrecision_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkCapsuleSource_SetOutputPointsPrecision_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCapsuleSource_SetPhiResolution_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the number of points in the latitude direction for the spheres. The initial value is 8.
	/// </summary>
	public virtual void SetPhiResolution(int _arg)
	{
		vtkCapsuleSource_SetPhiResolution_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCapsuleSource_SetRadius_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the radius of the capsule. The initial value is 0.5.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkCapsuleSource_SetRadius_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCapsuleSource_SetThetaResolution_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the number of points in the longitude direction for the spheres. The initial value
	/// is 8.
	/// </summary>
	public virtual void SetThetaResolution(int _arg)
	{
		vtkCapsuleSource_SetThetaResolution_33(GetCppThis(), _arg);
	}
}
