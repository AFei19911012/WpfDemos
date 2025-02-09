using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTexturedSphereSource
/// </summary>
/// <remarks>
///    create a sphere centered at the origin
///
/// vtkTexturedSphereSource creates a polygonal sphere of specified radius
/// centered at the origin. The resolution (polygonal discretization) in both
/// the latitude (phi) and longitude (theta) directions can be specified.
/// It also is possible to create partial sphere by specifying maximum phi and
/// theta angles.
/// </remarks>
public class vtkTexturedSphereSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTexturedSphereSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTexturedSphereSource()
	{
		MRClassNameKey = "class vtkTexturedSphereSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexturedSphereSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTexturedSphereSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedSphereSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct sphere with radius=0.5 and default resolution 8 in both Phi
	/// and Theta directions.
	/// </summary>
	public new static vtkTexturedSphereSource New()
	{
		vtkTexturedSphereSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedSphereSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTexturedSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct sphere with radius=0.5 and default resolution 8 in both Phi
	/// and Theta directions.
	/// </summary>
	public vtkTexturedSphereSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTexturedSphereSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkTexturedSphereSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTexturedSphereSource_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTexturedSphereSource_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTexturedSphereSource_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedSphereSource_GetOutputPointsPrecision_03(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkTexturedSphereSource_GetOutputPointsPrecision_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTexturedSphereSource_GetPhi_04(HandleRef pThis);

	/// <summary>
	/// Set the maximum latitude angle (0 is at north pole).
	/// </summary>
	public virtual double GetPhi()
	{
		return vtkTexturedSphereSource_GetPhi_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTexturedSphereSource_GetPhiMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set the maximum latitude angle (0 is at north pole).
	/// </summary>
	public virtual double GetPhiMaxValue()
	{
		return vtkTexturedSphereSource_GetPhiMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTexturedSphereSource_GetPhiMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set the maximum latitude angle (0 is at north pole).
	/// </summary>
	public virtual double GetPhiMinValue()
	{
		return vtkTexturedSphereSource_GetPhiMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedSphereSource_GetPhiResolution_07(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the latitude direction.
	/// </summary>
	public virtual int GetPhiResolution()
	{
		return vtkTexturedSphereSource_GetPhiResolution_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedSphereSource_GetPhiResolutionMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the latitude direction.
	/// </summary>
	public virtual int GetPhiResolutionMaxValue()
	{
		return vtkTexturedSphereSource_GetPhiResolutionMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedSphereSource_GetPhiResolutionMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the latitude direction.
	/// </summary>
	public virtual int GetPhiResolutionMinValue()
	{
		return vtkTexturedSphereSource_GetPhiResolutionMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTexturedSphereSource_GetRadius_10(HandleRef pThis);

	/// <summary>
	/// Set radius of sphere.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkTexturedSphereSource_GetRadius_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTexturedSphereSource_GetRadiusMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set radius of sphere.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkTexturedSphereSource_GetRadiusMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTexturedSphereSource_GetRadiusMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set radius of sphere.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkTexturedSphereSource_GetRadiusMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTexturedSphereSource_GetTheta_13(HandleRef pThis);

	/// <summary>
	/// Set the maximum longitude angle.
	/// </summary>
	public virtual double GetTheta()
	{
		return vtkTexturedSphereSource_GetTheta_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTexturedSphereSource_GetThetaMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set the maximum longitude angle.
	/// </summary>
	public virtual double GetThetaMaxValue()
	{
		return vtkTexturedSphereSource_GetThetaMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTexturedSphereSource_GetThetaMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set the maximum longitude angle.
	/// </summary>
	public virtual double GetThetaMinValue()
	{
		return vtkTexturedSphereSource_GetThetaMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedSphereSource_GetThetaResolution_16(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the longitude direction.
	/// </summary>
	public virtual int GetThetaResolution()
	{
		return vtkTexturedSphereSource_GetThetaResolution_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedSphereSource_GetThetaResolutionMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the longitude direction.
	/// </summary>
	public virtual int GetThetaResolutionMaxValue()
	{
		return vtkTexturedSphereSource_GetThetaResolutionMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedSphereSource_GetThetaResolutionMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set the number of points in the longitude direction.
	/// </summary>
	public virtual int GetThetaResolutionMinValue()
	{
		return vtkTexturedSphereSource_GetThetaResolutionMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedSphereSource_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTexturedSphereSource_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedSphereSource_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTexturedSphereSource_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedSphereSource_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTexturedSphereSource NewInstance()
	{
		vtkTexturedSphereSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedSphereSource_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTexturedSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedSphereSource_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTexturedSphereSource SafeDownCast(vtkObjectBase o)
	{
		vtkTexturedSphereSource vtkTexturedSphereSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedSphereSource_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexturedSphereSource2 = (vtkTexturedSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexturedSphereSource2.Register(null);
			}
		}
		return vtkTexturedSphereSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedSphereSource_SetOutputPointsPrecision_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkTexturedSphereSource_SetOutputPointsPrecision_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedSphereSource_SetPhi_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the maximum latitude angle (0 is at north pole).
	/// </summary>
	public virtual void SetPhi(double _arg)
	{
		vtkTexturedSphereSource_SetPhi_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedSphereSource_SetPhiResolution_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of points in the latitude direction.
	/// </summary>
	public virtual void SetPhiResolution(int _arg)
	{
		vtkTexturedSphereSource_SetPhiResolution_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedSphereSource_SetRadius_27(HandleRef pThis, double _arg);

	/// <summary>
	/// Set radius of sphere.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkTexturedSphereSource_SetRadius_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedSphereSource_SetTheta_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the maximum longitude angle.
	/// </summary>
	public virtual void SetTheta(double _arg)
	{
		vtkTexturedSphereSource_SetTheta_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedSphereSource_SetThetaResolution_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of points in the longitude direction.
	/// </summary>
	public virtual void SetThetaResolution(int _arg)
	{
		vtkTexturedSphereSource_SetThetaResolution_29(GetCppThis(), _arg);
	}
}
