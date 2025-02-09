using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSphereSource
/// </summary>
/// <remarks>
///    create a polygonal sphere centered at the origin
///
/// vtkSphereSource creates a sphere (represented by polygons) of specified
/// radius centered at the origin. The resolution (polygonal discretization)
/// in both the latitude (phi) and longitude (theta) directions can be
/// specified. It also is possible to create partial spheres by specifying
/// maximum phi and theta angles. By default, the surface tessellation of
/// the sphere uses triangles; however you can set LatLongTessellation to
/// produce a tessellation using quadrilaterals.
///
/// @warning
/// Resolution means the number of latitude or longitude lines for a complete
/// sphere. If you create partial spheres the number of latitude/longitude
/// lines may be off by one.
/// </remarks>
public class vtkSphereSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSphereSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSphereSource()
	{
		MRClassNameKey = "class vtkSphereSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSphereSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct sphere with radius=0.5 and default resolution 8 in both Phi
	/// and Theta directions. Theta ranges from (0,360) and phi (0,180) degrees.
	/// </summary>
	public new static vtkSphereSource New()
	{
		vtkSphereSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct sphere with radius=0.5 and default resolution 8 in both Phi
	/// and Theta directions. Theta ranges from (0,360) and phi (0,180) degrees.
	/// </summary>
	public vtkSphereSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSphereSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSphereSource_GenerateNormalsOff_01(HandleRef pThis);

	/// <summary>
	/// Specify whether to generate output point normals. By default this is
	/// enabled.
	/// </summary>
	public virtual void GenerateNormalsOff()
	{
		vtkSphereSource_GenerateNormalsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_GenerateNormalsOn_02(HandleRef pThis);

	/// <summary>
	/// Specify whether to generate output point normals. By default this is
	/// enabled.
	/// </summary>
	public virtual void GenerateNormalsOn()
	{
		vtkSphereSource_GenerateNormalsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereSource_GetCenter_03(HandleRef pThis);

	/// <summary>
	/// Set the center of the sphere. Default is (0,0,0).
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkSphereSource_GetCenter_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_GetCenter_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the center of the sphere. Default is (0,0,0).
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkSphereSource_GetCenter_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetEndPhi_05(HandleRef pThis);

	/// <summary>
	/// Set the ending latitude angle. By default EndPhi=180 degrees.
	/// </summary>
	public virtual double GetEndPhi()
	{
		return vtkSphereSource_GetEndPhi_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetEndPhiMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set the ending latitude angle. By default EndPhi=180 degrees.
	/// </summary>
	public virtual double GetEndPhiMaxValue()
	{
		return vtkSphereSource_GetEndPhiMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetEndPhiMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set the ending latitude angle. By default EndPhi=180 degrees.
	/// </summary>
	public virtual double GetEndPhiMinValue()
	{
		return vtkSphereSource_GetEndPhiMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetEndTheta_08(HandleRef pThis);

	/// <summary>
	/// Set the ending longitude angle. By default EndTheta=360 degrees.
	/// </summary>
	public virtual double GetEndTheta()
	{
		return vtkSphereSource_GetEndTheta_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetEndThetaMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set the ending longitude angle. By default EndTheta=360 degrees.
	/// </summary>
	public virtual double GetEndThetaMaxValue()
	{
		return vtkSphereSource_GetEndThetaMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetEndThetaMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set the ending longitude angle. By default EndTheta=360 degrees.
	/// </summary>
	public virtual double GetEndThetaMinValue()
	{
		return vtkSphereSource_GetEndThetaMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereSource_GetGenerateNormals_11(HandleRef pThis);

	/// <summary>
	/// Specify whether to generate output point normals. By default this is
	/// enabled.
	/// </summary>
	public virtual int GetGenerateNormals()
	{
		return vtkSphereSource_GetGenerateNormals_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereSource_GetLatLongTessellation_12(HandleRef pThis);

	/// <summary>
	/// Cause the sphere to be tessellated with edges along the latitude
	/// and longitude lines. If off, triangles are generated at non-polar
	/// regions, which results in edges that are not parallel to latitude and
	/// longitude lines. If on, quadrilaterals are generated everywhere
	/// except at the poles. This can be useful for generating a wireframe
	/// sphere with natural latitude and longitude lines.
	/// </summary>
	public virtual int GetLatLongTessellation()
	{
		return vtkSphereSource_GetLatLongTessellation_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereSource_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSphereSource_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereSource_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSphereSource_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereSource_GetOutputPointsPrecision_15(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkSphereSource_GetOutputPointsPrecision_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereSource_GetPhiResolution_16(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the latitude direction (ranging
	/// from StartPhi to EndPhi).
	/// </summary>
	public virtual int GetPhiResolution()
	{
		return vtkSphereSource_GetPhiResolution_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereSource_GetPhiResolutionMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the latitude direction (ranging
	/// from StartPhi to EndPhi).
	/// </summary>
	public virtual int GetPhiResolutionMaxValue()
	{
		return vtkSphereSource_GetPhiResolutionMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereSource_GetPhiResolutionMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the latitude direction (ranging
	/// from StartPhi to EndPhi).
	/// </summary>
	public virtual int GetPhiResolutionMinValue()
	{
		return vtkSphereSource_GetPhiResolutionMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetRadius_19(HandleRef pThis);

	/// <summary>
	/// Set the radius of sphere. Default is 0.5.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkSphereSource_GetRadius_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetRadiusMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Set the radius of sphere. Default is 0.5.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkSphereSource_GetRadiusMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetRadiusMinValue_21(HandleRef pThis);

	/// <summary>
	/// Set the radius of sphere. Default is 0.5.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkSphereSource_GetRadiusMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetStartPhi_22(HandleRef pThis);

	/// <summary>
	/// Set the starting latitude angle (0 is at north pole). By default
	/// StartPhi=0 degrees.
	/// </summary>
	public virtual double GetStartPhi()
	{
		return vtkSphereSource_GetStartPhi_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetStartPhiMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set the starting latitude angle (0 is at north pole). By default
	/// StartPhi=0 degrees.
	/// </summary>
	public virtual double GetStartPhiMaxValue()
	{
		return vtkSphereSource_GetStartPhiMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetStartPhiMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set the starting latitude angle (0 is at north pole). By default
	/// StartPhi=0 degrees.
	/// </summary>
	public virtual double GetStartPhiMinValue()
	{
		return vtkSphereSource_GetStartPhiMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetStartTheta_25(HandleRef pThis);

	/// <summary>
	/// Set the starting longitude angle. By default StartTheta=0 degrees.
	/// </summary>
	public virtual double GetStartTheta()
	{
		return vtkSphereSource_GetStartTheta_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetStartThetaMaxValue_26(HandleRef pThis);

	/// <summary>
	/// Set the starting longitude angle. By default StartTheta=0 degrees.
	/// </summary>
	public virtual double GetStartThetaMaxValue()
	{
		return vtkSphereSource_GetStartThetaMaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereSource_GetStartThetaMinValue_27(HandleRef pThis);

	/// <summary>
	/// Set the starting longitude angle. By default StartTheta=0 degrees.
	/// </summary>
	public virtual double GetStartThetaMinValue()
	{
		return vtkSphereSource_GetStartThetaMinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereSource_GetThetaResolution_28(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the longitude direction (ranging from
	/// StartTheta to EndTheta).
	/// </summary>
	public virtual int GetThetaResolution()
	{
		return vtkSphereSource_GetThetaResolution_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereSource_GetThetaResolutionMaxValue_29(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the longitude direction (ranging from
	/// StartTheta to EndTheta).
	/// </summary>
	public virtual int GetThetaResolutionMaxValue()
	{
		return vtkSphereSource_GetThetaResolutionMaxValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereSource_GetThetaResolutionMinValue_30(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the longitude direction (ranging from
	/// StartTheta to EndTheta).
	/// </summary>
	public virtual int GetThetaResolutionMinValue()
	{
		return vtkSphereSource_GetThetaResolutionMinValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereSource_IsA_31(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSphereSource_IsA_31(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereSource_IsTypeOf_32(string type);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSphereSource_IsTypeOf_32(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_LatLongTessellationOff_33(HandleRef pThis);

	/// <summary>
	/// Cause the sphere to be tessellated with edges along the latitude
	/// and longitude lines. If off, triangles are generated at non-polar
	/// regions, which results in edges that are not parallel to latitude and
	/// longitude lines. If on, quadrilaterals are generated everywhere
	/// except at the poles. This can be useful for generating a wireframe
	/// sphere with natural latitude and longitude lines.
	/// </summary>
	public virtual void LatLongTessellationOff()
	{
		vtkSphereSource_LatLongTessellationOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_LatLongTessellationOn_34(HandleRef pThis);

	/// <summary>
	/// Cause the sphere to be tessellated with edges along the latitude
	/// and longitude lines. If off, triangles are generated at non-polar
	/// regions, which results in edges that are not parallel to latitude and
	/// longitude lines. If on, quadrilaterals are generated everywhere
	/// except at the poles. This can be useful for generating a wireframe
	/// sphere with natural latitude and longitude lines.
	/// </summary>
	public virtual void LatLongTessellationOn()
	{
		vtkSphereSource_LatLongTessellationOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereSource_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public new vtkSphereSource NewInstance()
	{
		vtkSphereSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereSource_NewInstance_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereSource_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public new static vtkSphereSource SafeDownCast(vtkObjectBase o)
	{
		vtkSphereSource vtkSphereSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereSource_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphereSource2 = (vtkSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphereSource2.Register(null);
			}
		}
		return vtkSphereSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetCenter_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the center of the sphere. Default is (0,0,0).
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkSphereSource_SetCenter_38(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetCenter_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the center of the sphere. Default is (0,0,0).
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkSphereSource_SetCenter_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetEndPhi_40(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the ending latitude angle. By default EndPhi=180 degrees.
	/// </summary>
	public virtual void SetEndPhi(double _arg)
	{
		vtkSphereSource_SetEndPhi_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetEndTheta_41(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the ending longitude angle. By default EndTheta=360 degrees.
	/// </summary>
	public virtual void SetEndTheta(double _arg)
	{
		vtkSphereSource_SetEndTheta_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetGenerateNormals_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to generate output point normals. By default this is
	/// enabled.
	/// </summary>
	public virtual void SetGenerateNormals(int _arg)
	{
		vtkSphereSource_SetGenerateNormals_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetLatLongTessellation_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Cause the sphere to be tessellated with edges along the latitude
	/// and longitude lines. If off, triangles are generated at non-polar
	/// regions, which results in edges that are not parallel to latitude and
	/// longitude lines. If on, quadrilaterals are generated everywhere
	/// except at the poles. This can be useful for generating a wireframe
	/// sphere with natural latitude and longitude lines.
	/// </summary>
	public virtual void SetLatLongTessellation(int _arg)
	{
		vtkSphereSource_SetLatLongTessellation_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetOutputPointsPrecision_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkSphereSource_SetOutputPointsPrecision_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetPhiResolution_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of points in the latitude direction (ranging
	/// from StartPhi to EndPhi).
	/// </summary>
	public virtual void SetPhiResolution(int _arg)
	{
		vtkSphereSource_SetPhiResolution_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetRadius_46(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the radius of sphere. Default is 0.5.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkSphereSource_SetRadius_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetStartPhi_47(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the starting latitude angle (0 is at north pole). By default
	/// StartPhi=0 degrees.
	/// </summary>
	public virtual void SetStartPhi(double _arg)
	{
		vtkSphereSource_SetStartPhi_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetStartTheta_48(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the starting longitude angle. By default StartTheta=0 degrees.
	/// </summary>
	public virtual void SetStartTheta(double _arg)
	{
		vtkSphereSource_SetStartTheta_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereSource_SetThetaResolution_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of points in the longitude direction (ranging from
	/// StartTheta to EndTheta).
	/// </summary>
	public virtual void SetThetaResolution(int _arg)
	{
		vtkSphereSource_SetThetaResolution_49(GetCppThis(), _arg);
	}
}
