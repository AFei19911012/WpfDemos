using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSectorSource
/// </summary>
/// <remarks>
///    create a sector of a disk
///
/// vtkSectorSource creates a sector of a polygonal disk. The
/// disk has zero height. The user can specify the inner and outer radius
/// of the disk, the z-coordinate, and the radial and
/// circumferential resolution of the polygonal representation.
/// </remarks>
/// <seealso>
///
/// vtkLinearExtrusionFilter
/// </seealso>
public class vtkSectorSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSectorSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSectorSource()
	{
		MRClassNameKey = "class vtkSectorSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSectorSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSectorSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSectorSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSectorSource New()
	{
		vtkSectorSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSectorSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSectorSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSectorSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSectorSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSectorSource_GetCircumferentialResolution_01(HandleRef pThis);

	/// <summary>
	/// Set the number of points in circumferential direction.
	/// </summary>
	public virtual int GetCircumferentialResolution()
	{
		return vtkSectorSource_GetCircumferentialResolution_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSectorSource_GetCircumferentialResolutionMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set the number of points in circumferential direction.
	/// </summary>
	public virtual int GetCircumferentialResolutionMaxValue()
	{
		return vtkSectorSource_GetCircumferentialResolutionMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSectorSource_GetCircumferentialResolutionMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set the number of points in circumferential direction.
	/// </summary>
	public virtual int GetCircumferentialResolutionMinValue()
	{
		return vtkSectorSource_GetCircumferentialResolutionMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetEndAngle_04(HandleRef pThis);

	/// <summary>
	/// Set the end angle of the sector.
	/// </summary>
	public virtual double GetEndAngle()
	{
		return vtkSectorSource_GetEndAngle_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetEndAngleMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set the end angle of the sector.
	/// </summary>
	public virtual double GetEndAngleMaxValue()
	{
		return vtkSectorSource_GetEndAngleMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetEndAngleMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set the end angle of the sector.
	/// </summary>
	public virtual double GetEndAngleMinValue()
	{
		return vtkSectorSource_GetEndAngleMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetInnerRadius_07(HandleRef pThis);

	/// <summary>
	/// Specify inner radius of the sector.
	/// </summary>
	public virtual double GetInnerRadius()
	{
		return vtkSectorSource_GetInnerRadius_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetInnerRadiusMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Specify inner radius of the sector.
	/// </summary>
	public virtual double GetInnerRadiusMaxValue()
	{
		return vtkSectorSource_GetInnerRadiusMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetInnerRadiusMinValue_09(HandleRef pThis);

	/// <summary>
	/// Specify inner radius of the sector.
	/// </summary>
	public virtual double GetInnerRadiusMinValue()
	{
		return vtkSectorSource_GetInnerRadiusMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSectorSource_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSectorSource_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSectorSource_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSectorSource_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetOuterRadius_12(HandleRef pThis);

	/// <summary>
	/// Specify outer radius of the sector.
	/// </summary>
	public virtual double GetOuterRadius()
	{
		return vtkSectorSource_GetOuterRadius_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetOuterRadiusMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Specify outer radius of the sector.
	/// </summary>
	public virtual double GetOuterRadiusMaxValue()
	{
		return vtkSectorSource_GetOuterRadiusMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetOuterRadiusMinValue_14(HandleRef pThis);

	/// <summary>
	/// Specify outer radius of the sector.
	/// </summary>
	public virtual double GetOuterRadiusMinValue()
	{
		return vtkSectorSource_GetOuterRadiusMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSectorSource_GetRadialResolution_15(HandleRef pThis);

	/// <summary>
	/// Set the number of points in radius direction.
	/// </summary>
	public virtual int GetRadialResolution()
	{
		return vtkSectorSource_GetRadialResolution_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSectorSource_GetRadialResolutionMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set the number of points in radius direction.
	/// </summary>
	public virtual int GetRadialResolutionMaxValue()
	{
		return vtkSectorSource_GetRadialResolutionMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSectorSource_GetRadialResolutionMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set the number of points in radius direction.
	/// </summary>
	public virtual int GetRadialResolutionMinValue()
	{
		return vtkSectorSource_GetRadialResolutionMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetStartAngle_18(HandleRef pThis);

	/// <summary>
	/// Set the start angle of the sector.
	/// </summary>
	public virtual double GetStartAngle()
	{
		return vtkSectorSource_GetStartAngle_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetStartAngleMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set the start angle of the sector.
	/// </summary>
	public virtual double GetStartAngleMaxValue()
	{
		return vtkSectorSource_GetStartAngleMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetStartAngleMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set the start angle of the sector.
	/// </summary>
	public virtual double GetStartAngleMinValue()
	{
		return vtkSectorSource_GetStartAngleMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetZCoord_21(HandleRef pThis);

	/// <summary>
	/// Specify the z coordinate of the sector.
	/// </summary>
	public virtual double GetZCoord()
	{
		return vtkSectorSource_GetZCoord_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetZCoordMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Specify the z coordinate of the sector.
	/// </summary>
	public virtual double GetZCoordMaxValue()
	{
		return vtkSectorSource_GetZCoordMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSectorSource_GetZCoordMinValue_23(HandleRef pThis);

	/// <summary>
	/// Specify the z coordinate of the sector.
	/// </summary>
	public virtual double GetZCoordMinValue()
	{
		return vtkSectorSource_GetZCoordMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSectorSource_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSectorSource_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSectorSource_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSectorSource_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSectorSource_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSectorSource NewInstance()
	{
		vtkSectorSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSectorSource_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSectorSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSectorSource_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSectorSource SafeDownCast(vtkObjectBase o)
	{
		vtkSectorSource vtkSectorSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSectorSource_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSectorSource2 = (vtkSectorSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSectorSource2.Register(null);
			}
		}
		return vtkSectorSource2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSectorSource_SetCircumferentialResolution_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of points in circumferential direction.
	/// </summary>
	public virtual void SetCircumferentialResolution(int _arg)
	{
		vtkSectorSource_SetCircumferentialResolution_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSectorSource_SetEndAngle_30(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the end angle of the sector.
	/// </summary>
	public virtual void SetEndAngle(double _arg)
	{
		vtkSectorSource_SetEndAngle_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSectorSource_SetInnerRadius_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify inner radius of the sector.
	/// </summary>
	public virtual void SetInnerRadius(double _arg)
	{
		vtkSectorSource_SetInnerRadius_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSectorSource_SetOuterRadius_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify outer radius of the sector.
	/// </summary>
	public virtual void SetOuterRadius(double _arg)
	{
		vtkSectorSource_SetOuterRadius_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSectorSource_SetRadialResolution_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of points in radius direction.
	/// </summary>
	public virtual void SetRadialResolution(int _arg)
	{
		vtkSectorSource_SetRadialResolution_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSectorSource_SetStartAngle_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the start angle of the sector.
	/// </summary>
	public virtual void SetStartAngle(double _arg)
	{
		vtkSectorSource_SetStartAngle_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSectorSource_SetZCoord_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the z coordinate of the sector.
	/// </summary>
	public virtual void SetZCoord(double _arg)
	{
		vtkSectorSource_SetZCoord_35(GetCppThis(), _arg);
	}
}
