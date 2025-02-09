using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolarAxesActor
/// </summary>
/// <remarks>
///    create an actor of a polar axes -
///
///
/// vtkPolarAxesActor is a composite actor that draws polar axes in a
/// specified plane for a give pole.
/// Currently the plane has to be the xy plane.
///
/// @par Thanks:
/// This class was written by Philippe Pebay, Kitware SAS 2011.
/// This work was supported by CEA/DIF - Commissariat a l'Energie Atomique,
/// Centre DAM Ile-De-France, BP12, F-91297 Arpajon, France.
///
/// </remarks>
/// <seealso>
///
/// vtkActor vtkAxisActor vtkPolarAxesActor
/// </seealso>
public class vtkPolarAxesActor : vtkActor
{
	/// <summary>
	/// Set/Get the format with which to print the polar axis labels.
	/// </summary>
	public enum ExponentLocation
	{
		/// <summary>enum member</summary>
		VTK_EXPONENT_BOTTOM,
		/// <summary>enum member</summary>
		VTK_EXPONENT_EXTERN,
		/// <summary>enum member</summary>
		VTK_EXPONENT_LABELS
	}

	/// <summary>
	/// Turn on and off the visibility of titles for polar axis.
	/// </summary>
	public enum TitleLocation
	{
		/// <summary>enum member</summary>
		VTK_TITLE_BOTTOM,
		/// <summary>enum member</summary>
		VTK_TITLE_EXTERN
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolarAxesActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolarAxesActor()
	{
		MRClassNameKey = "class vtkPolarAxesActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolarAxesActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolarAxesActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with label format "6.3g" and the number of labels
	/// per axis set to 3.
	/// </summary>
	public new static vtkPolarAxesActor New()
	{
		vtkPolarAxesActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolarAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with label format "6.3g" and the number of labels
	/// per axis set to 3.
	/// </summary>
	public vtkPolarAxesActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolarAxesActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_ArcMinorTickVisibilityOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks on the last arc.
	/// </summary>
	public virtual void ArcMinorTickVisibilityOff()
	{
		vtkPolarAxesActor_ArcMinorTickVisibilityOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_ArcMinorTickVisibilityOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks on the last arc.
	/// </summary>
	public virtual void ArcMinorTickVisibilityOn()
	{
		vtkPolarAxesActor_ArcMinorTickVisibilityOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_ArcTickVisibilityOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of major ticks on the last arc.
	/// </summary>
	public virtual void ArcTickVisibilityOff()
	{
		vtkPolarAxesActor_ArcTickVisibilityOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_ArcTickVisibilityOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of major ticks on the last arc.
	/// </summary>
	public virtual void ArcTickVisibilityOn()
	{
		vtkPolarAxesActor_ArcTickVisibilityOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_ArcTicksOriginToPolarAxisOff_05(HandleRef pThis);

	/// <summary>
	/// If On, the ticks are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
	/// and continue counterclockwise with the step DeltaAngle Major/Minor. if Off, the start angle is
	/// 0.0, i.e.
	/// the angle on the major radius of the ellipse.
	/// </summary>
	public virtual void ArcTicksOriginToPolarAxisOff()
	{
		vtkPolarAxesActor_ArcTicksOriginToPolarAxisOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_ArcTicksOriginToPolarAxisOn_06(HandleRef pThis);

	/// <summary>
	/// If On, the ticks are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
	/// and continue counterclockwise with the step DeltaAngle Major/Minor. if Off, the start angle is
	/// 0.0, i.e.
	/// the angle on the major radius of the ellipse.
	/// </summary>
	public virtual void ArcTicksOriginToPolarAxisOn()
	{
		vtkPolarAxesActor_ArcTicksOriginToPolarAxisOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_AutoSubdividePolarAxisOff_07(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the number of polar axis ticks and arcs should be automatically calculated
	/// Default: true
	/// </summary>
	public virtual void AutoSubdividePolarAxisOff()
	{
		vtkPolarAxesActor_AutoSubdividePolarAxisOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_AutoSubdividePolarAxisOn_08(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the number of polar axis ticks and arcs should be automatically calculated
	/// Default: true
	/// </summary>
	public virtual void AutoSubdividePolarAxisOn()
	{
		vtkPolarAxesActor_AutoSubdividePolarAxisOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_AxisMinorTickVisibilityOff_09(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks on polar axis and last radial axis.
	/// </summary>
	public virtual void AxisMinorTickVisibilityOff()
	{
		vtkPolarAxesActor_AxisMinorTickVisibilityOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_AxisMinorTickVisibilityOn_10(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks on polar axis and last radial axis.
	/// </summary>
	public virtual void AxisMinorTickVisibilityOn()
	{
		vtkPolarAxesActor_AxisMinorTickVisibilityOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_AxisTickVisibilityOff_11(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of major ticks on polar axis and last radial axis.
	/// </summary>
	public virtual void AxisTickVisibilityOff()
	{
		vtkPolarAxesActor_AxisTickVisibilityOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_AxisTickVisibilityOn_12(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of major ticks on polar axis and last radial axis.
	/// </summary>
	public virtual void AxisTickVisibilityOn()
	{
		vtkPolarAxesActor_AxisTickVisibilityOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_DrawPolarArcsGridlinesOff_13(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of inner polar arcs grid lines
	/// </summary>
	public virtual void DrawPolarArcsGridlinesOff()
	{
		vtkPolarAxesActor_DrawPolarArcsGridlinesOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_DrawPolarArcsGridlinesOn_14(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of inner polar arcs grid lines
	/// </summary>
	public virtual void DrawPolarArcsGridlinesOn()
	{
		vtkPolarAxesActor_DrawPolarArcsGridlinesOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_DrawRadialGridlinesOff_15(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of inner radial grid lines
	/// </summary>
	public virtual void DrawRadialGridlinesOff()
	{
		vtkPolarAxesActor_DrawRadialGridlinesOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_DrawRadialGridlinesOn_16(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of inner radial grid lines
	/// </summary>
	public virtual void DrawRadialGridlinesOn()
	{
		vtkPolarAxesActor_DrawRadialGridlinesOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetArcMajorTickSize_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the major ticks on the last arc.
	/// </summary>
	public virtual double GetArcMajorTickSize()
	{
		return vtkPolarAxesActor_GetArcMajorTickSize_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetArcMajorTickThickness_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the thickness of the last arc ticks
	/// </summary>
	public virtual double GetArcMajorTickThickness()
	{
		return vtkPolarAxesActor_GetArcMajorTickThickness_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetArcMinorTickVisibility_19(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks on the last arc.
	/// </summary>
	public virtual int GetArcMinorTickVisibility()
	{
		return vtkPolarAxesActor_GetArcMinorTickVisibility_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetArcTickRatioSize_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio between major and minor Arc ticks size
	/// </summary>
	public virtual double GetArcTickRatioSize()
	{
		return vtkPolarAxesActor_GetArcTickRatioSize_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetArcTickRatioThickness_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio between major and minor Arc ticks thickness
	/// </summary>
	public virtual double GetArcTickRatioThickness()
	{
		return vtkPolarAxesActor_GetArcTickRatioThickness_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetArcTickVisibility_22(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of major ticks on the last arc.
	/// </summary>
	public virtual int GetArcTickVisibility()
	{
		return vtkPolarAxesActor_GetArcTickVisibility_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetArcTicksOriginToPolarAxis_23(HandleRef pThis);

	/// <summary>
	/// If On, the ticks are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
	/// and continue counterclockwise with the step DeltaAngle Major/Minor. if Off, the start angle is
	/// 0.0, i.e.
	/// the angle on the major radius of the ellipse.
	/// </summary>
	public virtual int GetArcTicksOriginToPolarAxis()
	{
		return vtkPolarAxesActor_GetArcTicksOriginToPolarAxis_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolarAxesActor_GetAutoSubdividePolarAxis_24(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the number of polar axis ticks and arcs should be automatically calculated
	/// Default: true
	/// </summary>
	public virtual bool GetAutoSubdividePolarAxis()
	{
		return (vtkPolarAxesActor_GetAutoSubdividePolarAxis_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetAxisMinorTickVisibility_25(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks on polar axis and last radial axis.
	/// </summary>
	public virtual int GetAxisMinorTickVisibility()
	{
		return vtkPolarAxesActor_GetAxisMinorTickVisibility_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetAxisTickVisibility_26(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of major ticks on polar axis and last radial axis.
	/// </summary>
	public virtual int GetAxisTickVisibility()
	{
		return vtkPolarAxesActor_GetAxisTickVisibility_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetBounds_27(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds are used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkPolarAxesActor_GetBounds_27(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_GetBounds_28(HandleRef pThis, ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds are used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public void GetBounds(ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax)
	{
		vtkPolarAxesActor_GetBounds_28(GetCppThis(), ref xmin, ref xmax, ref ymin, ref ymax, ref zmin, ref zmax);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_GetBounds_29(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds are used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public new void GetBounds(IntPtr bounds)
	{
		vtkPolarAxesActor_GetBounds_29(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetCamera_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the camera to perform scaling and translation of the
	/// vtkPolarAxesActor.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_GetCamera_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCamera2 = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCamera2.Register(null);
			}
		}
		return vtkCamera2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetDeltaAngleMajor_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the angle between 2 major ticks on the last arc.
	/// </summary>
	public virtual double GetDeltaAngleMajor()
	{
		return vtkPolarAxesActor_GetDeltaAngleMajor_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetDeltaAngleMinor_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the angle between 2 minor ticks on the last arc.
	/// </summary>
	public virtual double GetDeltaAngleMinor()
	{
		return vtkPolarAxesActor_GetDeltaAngleMinor_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetDeltaAngleRadialAxes_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the angle between 2 radial axes.
	/// </summary>
	public virtual double GetDeltaAngleRadialAxes()
	{
		return vtkPolarAxesActor_GetDeltaAngleRadialAxes_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetDeltaRangeMajor_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the step between 2 major ticks, in range value (values displayed on the axis).
	/// </summary>
	public virtual double GetDeltaRangeMajor()
	{
		return vtkPolarAxesActor_GetDeltaRangeMajor_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetDeltaRangeMinor_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the step between 2 minor ticks, in range value (values displayed on the axis).
	/// </summary>
	public virtual double GetDeltaRangeMinor()
	{
		return vtkPolarAxesActor_GetDeltaRangeMinor_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetDistanceLODThreshold_36(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetDistanceLODThreshold()
	{
		return vtkPolarAxesActor_GetDistanceLODThreshold_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetDistanceLODThresholdMaxValue_37(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetDistanceLODThresholdMaxValue()
	{
		return vtkPolarAxesActor_GetDistanceLODThresholdMaxValue_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetDistanceLODThresholdMinValue_38(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetDistanceLODThresholdMinValue()
	{
		return vtkPolarAxesActor_GetDistanceLODThresholdMinValue_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetDrawPolarArcsGridlines_39(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of inner polar arcs grid lines
	/// </summary>
	public virtual int GetDrawPolarArcsGridlines()
	{
		return vtkPolarAxesActor_GetDrawPolarArcsGridlines_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetDrawRadialGridlines_40(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of inner radial grid lines
	/// </summary>
	public virtual int GetDrawRadialGridlines()
	{
		return vtkPolarAxesActor_GetDrawRadialGridlines_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetEnableDistanceLOD_41(HandleRef pThis);

	/// <summary>
	/// Enable and disable the use of distance based LOD for titles and labels.
	/// </summary>
	public virtual int GetEnableDistanceLOD()
	{
		return vtkPolarAxesActor_GetEnableDistanceLOD_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetEnableViewAngleLOD_42(HandleRef pThis);

	/// <summary>
	/// Enable and disable the use of view angle based LOD for titles and labels.
	/// </summary>
	public virtual int GetEnableViewAngleLOD()
	{
		return vtkPolarAxesActor_GetEnableViewAngleLOD_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetExponentLocation_43(HandleRef pThis);

	/// <summary>
	/// Get/Set the location of the exponent (if any) of the polar axis values.
	/// Possible location: VTK_EXPONENT_BOTTOM, VTK_EXPONENT_EXTERN,
	/// VTK_EXPONENT_LABELS
	/// </summary>
	public virtual int GetExponentLocation()
	{
		return vtkPolarAxesActor_GetExponentLocation_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetExponentLocationMaxValue_44(HandleRef pThis);

	/// <summary>
	/// Get/Set the location of the exponent (if any) of the polar axis values.
	/// Possible location: VTK_EXPONENT_BOTTOM, VTK_EXPONENT_EXTERN,
	/// VTK_EXPONENT_LABELS
	/// </summary>
	public virtual int GetExponentLocationMaxValue()
	{
		return vtkPolarAxesActor_GetExponentLocationMaxValue_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetExponentLocationMinValue_45(HandleRef pThis);

	/// <summary>
	/// Get/Set the location of the exponent (if any) of the polar axis values.
	/// Possible location: VTK_EXPONENT_BOTTOM, VTK_EXPONENT_EXTERN,
	/// VTK_EXPONENT_LABELS
	/// </summary>
	public virtual int GetExponentLocationMinValue()
	{
		return vtkPolarAxesActor_GetExponentLocationMinValue_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetLastAxisTickRatioSize_46(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio between major and minor Last Radial axis ticks size
	/// </summary>
	public virtual double GetLastAxisTickRatioSize()
	{
		return vtkPolarAxesActor_GetLastAxisTickRatioSize_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetLastAxisTickRatioThickness_47(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio between major and minor Last Radial axis ticks thickness
	/// </summary>
	public virtual double GetLastAxisTickRatioThickness()
	{
		return vtkPolarAxesActor_GetLastAxisTickRatioThickness_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetLastRadialAxisMajorTickSize_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the major ticks on the last radial axis.
	/// </summary>
	public virtual double GetLastRadialAxisMajorTickSize()
	{
		return vtkPolarAxesActor_GetLastRadialAxisMajorTickSize_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetLastRadialAxisMajorTickThickness_49(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the thickness of last radial axis ticks
	/// </summary>
	public virtual double GetLastRadialAxisMajorTickThickness()
	{
		return vtkPolarAxesActor_GetLastRadialAxisMajorTickThickness_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetLastRadialAxisProperty_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set last radial axis actor properties.
	/// </summary>
	public virtual vtkProperty GetLastRadialAxisProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_GetLastRadialAxisProperty_50(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetLastRadialAxisTextProperty_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the last radial axis text property.
	/// </summary>
	public virtual vtkTextProperty GetLastRadialAxisTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_GetLastRadialAxisTextProperty_51(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolarAxesActor_GetLog_52(HandleRef pThis);

	/// <summary>
	/// Enable/Disable log scale
	/// Default: false
	/// </summary>
	public virtual bool GetLog()
	{
		return (vtkPolarAxesActor_GetLog_52(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetMaximumAngle_53(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum radius of the polar coordinates (in degrees).
	/// </summary>
	public virtual double GetMaximumAngle()
	{
		return vtkPolarAxesActor_GetMaximumAngle_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetMaximumRadius_54(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum radius of the polar coordinates.
	/// </summary>
	public virtual double GetMaximumRadius()
	{
		return vtkPolarAxesActor_GetMaximumRadius_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetMinimumAngle_55(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum radius of the polar coordinates (in degrees).
	/// </summary>
	public virtual double GetMinimumAngle()
	{
		return vtkPolarAxesActor_GetMinimumAngle_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetMinimumRadius_56(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimal radius of the polar coordinates.
	/// </summary>
	public virtual double GetMinimumRadius()
	{
		return vtkPolarAxesActor_GetMinimumRadius_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolarAxesActor_GetNumberOfGenerationsFromBase_57(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolarAxesActor_GetNumberOfGenerationsFromBase_57(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolarAxesActor_GetNumberOfGenerationsFromBaseType_58(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolarAxesActor_GetNumberOfGenerationsFromBaseType_58(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetNumberOfPolarAxisTicks_59(HandleRef pThis);

	/// <summary>
	/// Set/Get a number of ticks that one would like to display along polar axis
	/// NB: it modifies DeltaRangeMajor to correspond to this number
	/// </summary>
	public int GetNumberOfPolarAxisTicks()
	{
		return vtkPolarAxesActor_GetNumberOfPolarAxisTicks_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetPolarArcsProperty_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set principal polar arc actor property.
	/// </summary>
	public vtkProperty GetPolarArcsProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_GetPolarArcsProperty_60(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetPolarArcsVisibility_61(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of arcs for polar axis.
	/// </summary>
	public virtual int GetPolarArcsVisibility()
	{
		return vtkPolarAxesActor_GetPolarArcsVisibility_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetPolarAxisLabelTextProperty_62(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the polar axis labels text property.
	/// </summary>
	public virtual vtkTextProperty GetPolarAxisLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_GetPolarAxisLabelTextProperty_62(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetPolarAxisMajorTickSize_63(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the major ticks on the polar axis.
	/// </summary>
	public virtual double GetPolarAxisMajorTickSize()
	{
		return vtkPolarAxesActor_GetPolarAxisMajorTickSize_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetPolarAxisMajorTickThickness_64(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the thickness of polar axis ticks
	/// </summary>
	public virtual double GetPolarAxisMajorTickThickness()
	{
		return vtkPolarAxesActor_GetPolarAxisMajorTickThickness_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetPolarAxisProperty_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set polar axis actor properties.
	/// </summary>
	public virtual vtkProperty GetPolarAxisProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_GetPolarAxisProperty_65(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetPolarAxisTickRatioSize_66(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio between major and minor Polar Axis ticks size
	/// </summary>
	public virtual double GetPolarAxisTickRatioSize()
	{
		return vtkPolarAxesActor_GetPolarAxisTickRatioSize_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetPolarAxisTickRatioThickness_67(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio between major and minor Polar Axis ticks thickness
	/// </summary>
	public virtual double GetPolarAxisTickRatioThickness()
	{
		return vtkPolarAxesActor_GetPolarAxisTickRatioThickness_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetPolarAxisTitle_68(HandleRef pThis);

	/// <summary>
	/// Set/Get the labels for the polar axis.
	/// Default: "Radial Distance".
	/// </summary>
	public virtual string GetPolarAxisTitle()
	{
		return Marshal.PtrToStringAnsi(vtkPolarAxesActor_GetPolarAxisTitle_68(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetPolarAxisTitleLocation_69(HandleRef pThis);

	/// <summary>
	/// Get/Set the alignment of the polar axes title related to the axis.
	/// Possible Alignment: VTKTITLE_BOTTOM, VTK_TITLE_EXTERN
	/// </summary>
	public virtual int GetPolarAxisTitleLocation()
	{
		return vtkPolarAxesActor_GetPolarAxisTitleLocation_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetPolarAxisTitleLocationMaxValue_70(HandleRef pThis);

	/// <summary>
	/// Get/Set the alignment of the polar axes title related to the axis.
	/// Possible Alignment: VTKTITLE_BOTTOM, VTK_TITLE_EXTERN
	/// </summary>
	public virtual int GetPolarAxisTitleLocationMaxValue()
	{
		return vtkPolarAxesActor_GetPolarAxisTitleLocationMaxValue_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetPolarAxisTitleLocationMinValue_71(HandleRef pThis);

	/// <summary>
	/// Get/Set the alignment of the polar axes title related to the axis.
	/// Possible Alignment: VTKTITLE_BOTTOM, VTK_TITLE_EXTERN
	/// </summary>
	public virtual int GetPolarAxisTitleLocationMinValue()
	{
		return vtkPolarAxesActor_GetPolarAxisTitleLocationMinValue_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetPolarAxisTitleTextProperty_72(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the polar axis title text property.
	/// </summary>
	public virtual vtkTextProperty GetPolarAxisTitleTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_GetPolarAxisTitleTextProperty_72(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetPolarAxisVisibility_73(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of the polar axis.
	/// </summary>
	public virtual int GetPolarAxisVisibility()
	{
		return vtkPolarAxesActor_GetPolarAxisVisibility_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetPolarLabelFormat_74(HandleRef pThis);

	/// <summary>
	/// Set/Get the format with which to print the polar axis labels.
	/// </summary>
	public virtual string GetPolarLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkPolarAxesActor_GetPolarLabelFormat_74(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetPolarLabelVisibility_75(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for polar axis.
	/// </summary>
	public virtual int GetPolarLabelVisibility()
	{
		return vtkPolarAxesActor_GetPolarLabelVisibility_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetPolarTickVisibility_76(HandleRef pThis);

	/// <summary>
	/// Turn on and off the overall visibility of ticks.
	/// </summary>
	public virtual int GetPolarTickVisibility()
	{
		return vtkPolarAxesActor_GetPolarTickVisibility_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetPolarTitleVisibility_77(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of titles for polar axis.
	/// </summary>
	public virtual int GetPolarTitleVisibility()
	{
		return vtkPolarAxesActor_GetPolarTitleVisibility_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetPole_78(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the coordinate of the pole.
	/// </summary>
	public virtual double[] GetPole()
	{
		IntPtr intPtr = vtkPolarAxesActor_GetPole_78(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_GetPole_79(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Explicitly specify the coordinate of the pole.
	/// </summary>
	public virtual void GetPole(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkPolarAxesActor_GetPole_79(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_GetPole_80(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Explicitly specify the coordinate of the pole.
	/// </summary>
	public virtual void GetPole(IntPtr _arg)
	{
		vtkPolarAxesActor_GetPole_80(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetRadialAngleFormat_81(HandleRef pThis);

	/// <summary>
	/// String to format angle values displayed on the radial axes.
	/// </summary>
	public virtual string GetRadialAngleFormat()
	{
		return Marshal.PtrToStringAnsi(vtkPolarAxesActor_GetRadialAngleFormat_81(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetRadialAxesOriginToPolarAxis_82(HandleRef pThis);

	/// <summary>
	/// If On, the radial axes are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
	/// and continue counterclockwise with the step DeltaAngleRadialAxes. if Off, the start angle is
	/// 0.0, i.e.
	/// the angle on the major radius of the ellipse.
	/// </summary>
	public virtual int GetRadialAxesOriginToPolarAxis()
	{
		return vtkPolarAxesActor_GetRadialAxesOriginToPolarAxis_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetRadialAxesVisibility_83(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of non-polar radial axes.
	/// </summary>
	public virtual int GetRadialAxesVisibility()
	{
		return vtkPolarAxesActor_GetRadialAxesVisibility_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetRadialAxisTitleLocation_84(HandleRef pThis);

	/// <summary>
	/// Get/Set the alignment of the radial axes title related to the axis.
	/// Possible Alignment: VTK_TITLE_BOTTOM, VTK_TITLE_EXTERN
	/// </summary>
	public virtual int GetRadialAxisTitleLocation()
	{
		return vtkPolarAxesActor_GetRadialAxisTitleLocation_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetRadialAxisTitleLocationMaxValue_85(HandleRef pThis);

	/// <summary>
	/// Get/Set the alignment of the radial axes title related to the axis.
	/// Possible Alignment: VTK_TITLE_BOTTOM, VTK_TITLE_EXTERN
	/// </summary>
	public virtual int GetRadialAxisTitleLocationMaxValue()
	{
		return vtkPolarAxesActor_GetRadialAxisTitleLocationMaxValue_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetRadialAxisTitleLocationMinValue_86(HandleRef pThis);

	/// <summary>
	/// Get/Set the alignment of the radial axes title related to the axis.
	/// Possible Alignment: VTK_TITLE_BOTTOM, VTK_TITLE_EXTERN
	/// </summary>
	public virtual int GetRadialAxisTitleLocationMinValue()
	{
		return vtkPolarAxesActor_GetRadialAxisTitleLocationMinValue_86(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetRadialTitleVisibility_87(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of titles for non-polar radial axes.
	/// </summary>
	public virtual int GetRadialTitleVisibility()
	{
		return vtkPolarAxesActor_GetRadialTitleVisibility_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolarAxesActor_GetRadialUnits_88(HandleRef pThis);

	/// <summary>
	/// Default: true
	/// </summary>
	public virtual bool GetRadialUnits()
	{
		return (vtkPolarAxesActor_GetRadialUnits_88(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetRange_89(HandleRef pThis);

	/// <summary>
	/// Define the range values displayed on the polar Axis.
	/// </summary>
	public virtual double[] GetRange()
	{
		IntPtr intPtr = vtkPolarAxesActor_GetRange_89(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_GetRange_90(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Define the range values displayed on the polar Axis.
	/// </summary>
	public virtual void GetRange(IntPtr data)
	{
		vtkPolarAxesActor_GetRange_90(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetRatio_91(HandleRef pThis);

	/// <summary>
	/// Ratio
	/// </summary>
	public virtual double GetRatio()
	{
		return vtkPolarAxesActor_GetRatio_91(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetRatioMaxValue_92(HandleRef pThis);

	/// <summary>
	/// Ratio
	/// </summary>
	public virtual double GetRatioMaxValue()
	{
		return vtkPolarAxesActor_GetRatioMaxValue_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetRatioMinValue_93(HandleRef pThis);

	/// <summary>
	/// Ratio
	/// </summary>
	public virtual double GetRatioMinValue()
	{
		return vtkPolarAxesActor_GetRatioMinValue_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolarAxesActor_GetRequestedNumberOfRadialAxes_94(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the number of radial axes
	/// </summary>
	public virtual long GetRequestedNumberOfRadialAxes()
	{
		return vtkPolarAxesActor_GetRequestedNumberOfRadialAxes_94(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolarAxesActor_GetRequestedNumberOfRadialAxesMaxValue_95(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the number of radial axes
	/// </summary>
	public virtual long GetRequestedNumberOfRadialAxesMaxValue()
	{
		return vtkPolarAxesActor_GetRequestedNumberOfRadialAxesMaxValue_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolarAxesActor_GetRequestedNumberOfRadialAxesMinValue_96(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the number of radial axes
	/// </summary>
	public virtual long GetRequestedNumberOfRadialAxesMinValue()
	{
		return vtkPolarAxesActor_GetRequestedNumberOfRadialAxesMinValue_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetScreenSize_97(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the screen size of title and label text.
	/// ScreenSize determines the size of the text in terms of screen
	/// pixels.
	/// Default: 10.0.
	/// </summary>
	public virtual double GetScreenSize()
	{
		return vtkPolarAxesActor_GetScreenSize_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetSecondaryPolarArcsProperty_98(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set secondary polar arcs actors property.
	/// </summary>
	public vtkProperty GetSecondaryPolarArcsProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_GetSecondaryPolarArcsProperty_98(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetSecondaryRadialAxesProperty_99(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set secondary radial axes actors properties.
	/// </summary>
	public virtual vtkProperty GetSecondaryRadialAxesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_GetSecondaryRadialAxesProperty_99(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_GetSecondaryRadialAxesTextProperty_100(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the secondary radial axes text property.
	/// </summary>
	public virtual vtkTextProperty GetSecondaryRadialAxesTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_GetSecondaryRadialAxesTextProperty_100(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetSmallestVisiblePolarAngle_101(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum radial angle distinguishable from polar axis
	/// NB: This is used only when polar axis is visible
	/// Default: 0.5
	/// </summary>
	public virtual double GetSmallestVisiblePolarAngle()
	{
		return vtkPolarAxesActor_GetSmallestVisiblePolarAngle_101(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetSmallestVisiblePolarAngleMaxValue_102(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum radial angle distinguishable from polar axis
	/// NB: This is used only when polar axis is visible
	/// Default: 0.5
	/// </summary>
	public virtual double GetSmallestVisiblePolarAngleMaxValue()
	{
		return vtkPolarAxesActor_GetSmallestVisiblePolarAngleMaxValue_102(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetSmallestVisiblePolarAngleMinValue_103(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum radial angle distinguishable from polar axis
	/// NB: This is used only when polar axis is visible
	/// Default: 0.5
	/// </summary>
	public virtual double GetSmallestVisiblePolarAngleMinValue()
	{
		return vtkPolarAxesActor_GetSmallestVisiblePolarAngleMinValue_103(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetTickLocation_104(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the ticks.
	/// Inside: tick end toward positive direction of perpendicular axes.
	/// Outside: tick end toward negative direction of perpendicular axes.
	/// </summary>
	public virtual int GetTickLocation()
	{
		return vtkPolarAxesActor_GetTickLocation_104(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetTickLocationMaxValue_105(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the ticks.
	/// Inside: tick end toward positive direction of perpendicular axes.
	/// Outside: tick end toward negative direction of perpendicular axes.
	/// </summary>
	public virtual int GetTickLocationMaxValue()
	{
		return vtkPolarAxesActor_GetTickLocationMaxValue_105(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetTickLocationMinValue_106(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the ticks.
	/// Inside: tick end toward positive direction of perpendicular axes.
	/// Outside: tick end toward negative direction of perpendicular axes.
	/// </summary>
	public virtual int GetTickLocationMinValue()
	{
		return vtkPolarAxesActor_GetTickLocationMinValue_106(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_GetUse2DMode_107(HandleRef pThis);

	/// <summary>
	/// Enable/Disable labels 2D mode (always facing the camera).
	/// </summary>
	public int GetUse2DMode()
	{
		return vtkPolarAxesActor_GetUse2DMode_107(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetViewAngleLODThreshold_108(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetViewAngleLODThreshold()
	{
		return vtkPolarAxesActor_GetViewAngleLODThreshold_108(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetViewAngleLODThresholdMaxValue_109(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetViewAngleLODThresholdMaxValue()
	{
		return vtkPolarAxesActor_GetViewAngleLODThresholdMaxValue_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolarAxesActor_GetViewAngleLODThresholdMinValue_110(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetViewAngleLODThresholdMinValue()
	{
		return vtkPolarAxesActor_GetViewAngleLODThresholdMinValue_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_IsA_111(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolarAxesActor_IsA_111(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_IsTypeOf_112(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolarAxesActor_IsTypeOf_112(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_LogOff_113(HandleRef pThis);

	/// <summary>
	/// Enable/Disable log scale
	/// Default: false
	/// </summary>
	public virtual void LogOff()
	{
		vtkPolarAxesActor_LogOff_113(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_LogOn_114(HandleRef pThis);

	/// <summary>
	/// Enable/Disable log scale
	/// Default: false
	/// </summary>
	public virtual void LogOn()
	{
		vtkPolarAxesActor_LogOn_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_NewInstance_116(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPolarAxesActor NewInstance()
	{
		vtkPolarAxesActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_NewInstance_116(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolarAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_PolarArcsVisibilityOff_117(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of arcs for polar axis.
	/// </summary>
	public virtual void PolarArcsVisibilityOff()
	{
		vtkPolarAxesActor_PolarArcsVisibilityOff_117(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_PolarArcsVisibilityOn_118(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of arcs for polar axis.
	/// </summary>
	public virtual void PolarArcsVisibilityOn()
	{
		vtkPolarAxesActor_PolarArcsVisibilityOn_118(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_PolarAxisVisibilityOff_119(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of the polar axis.
	/// </summary>
	public virtual void PolarAxisVisibilityOff()
	{
		vtkPolarAxesActor_PolarAxisVisibilityOff_119(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_PolarAxisVisibilityOn_120(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of the polar axis.
	/// </summary>
	public virtual void PolarAxisVisibilityOn()
	{
		vtkPolarAxesActor_PolarAxisVisibilityOn_120(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_PolarLabelVisibilityOff_121(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for polar axis.
	/// </summary>
	public virtual void PolarLabelVisibilityOff()
	{
		vtkPolarAxesActor_PolarLabelVisibilityOff_121(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_PolarLabelVisibilityOn_122(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for polar axis.
	/// </summary>
	public virtual void PolarLabelVisibilityOn()
	{
		vtkPolarAxesActor_PolarLabelVisibilityOn_122(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_PolarTickVisibilityOff_123(HandleRef pThis);

	/// <summary>
	/// Turn on and off the overall visibility of ticks.
	/// </summary>
	public virtual void PolarTickVisibilityOff()
	{
		vtkPolarAxesActor_PolarTickVisibilityOff_123(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_PolarTickVisibilityOn_124(HandleRef pThis);

	/// <summary>
	/// Turn on and off the overall visibility of ticks.
	/// </summary>
	public virtual void PolarTickVisibilityOn()
	{
		vtkPolarAxesActor_PolarTickVisibilityOn_124(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_PolarTitleVisibilityOff_125(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of titles for polar axis.
	/// </summary>
	public virtual void PolarTitleVisibilityOff()
	{
		vtkPolarAxesActor_PolarTitleVisibilityOff_125(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_PolarTitleVisibilityOn_126(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of titles for polar axis.
	/// </summary>
	public virtual void PolarTitleVisibilityOn()
	{
		vtkPolarAxesActor_PolarTitleVisibilityOn_126(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_RadialAxesOriginToPolarAxisOff_127(HandleRef pThis);

	/// <summary>
	/// If On, the radial axes are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
	/// and continue counterclockwise with the step DeltaAngleRadialAxes. if Off, the start angle is
	/// 0.0, i.e.
	/// the angle on the major radius of the ellipse.
	/// </summary>
	public virtual void RadialAxesOriginToPolarAxisOff()
	{
		vtkPolarAxesActor_RadialAxesOriginToPolarAxisOff_127(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_RadialAxesOriginToPolarAxisOn_128(HandleRef pThis);

	/// <summary>
	/// If On, the radial axes are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
	/// and continue counterclockwise with the step DeltaAngleRadialAxes. if Off, the start angle is
	/// 0.0, i.e.
	/// the angle on the major radius of the ellipse.
	/// </summary>
	public virtual void RadialAxesOriginToPolarAxisOn()
	{
		vtkPolarAxesActor_RadialAxesOriginToPolarAxisOn_128(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_RadialAxesVisibilityOff_129(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of non-polar radial axes.
	/// </summary>
	public virtual void RadialAxesVisibilityOff()
	{
		vtkPolarAxesActor_RadialAxesVisibilityOff_129(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_RadialAxesVisibilityOn_130(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of non-polar radial axes.
	/// </summary>
	public virtual void RadialAxesVisibilityOn()
	{
		vtkPolarAxesActor_RadialAxesVisibilityOn_130(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_RadialTitleVisibilityOff_131(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of titles for non-polar radial axes.
	/// </summary>
	public virtual void RadialTitleVisibilityOff()
	{
		vtkPolarAxesActor_RadialTitleVisibilityOff_131(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_RadialTitleVisibilityOn_132(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of titles for non-polar radial axes.
	/// </summary>
	public virtual void RadialTitleVisibilityOn()
	{
		vtkPolarAxesActor_RadialTitleVisibilityOn_132(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_ReleaseGraphicsResources_133(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkPolarAxesActor_ReleaseGraphicsResources_133(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_RenderOpaqueGeometry_134(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the polar axes
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkPolarAxesActor_RenderOpaqueGeometry_134(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_RenderOverlay_135(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the polar axes
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkPolarAxesActor_RenderOverlay_135(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolarAxesActor_RenderTranslucentPolygonalGeometry_136(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the polar axes
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkPolarAxesActor_RenderTranslucentPolygonalGeometry_136(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolarAxesActor_SafeDownCast_137(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolarAxesActor SafeDownCast(vtkObjectBase o)
	{
		vtkPolarAxesActor vtkPolarAxesActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolarAxesActor_SafeDownCast_137(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolarAxesActor2 = (vtkPolarAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolarAxesActor2.Register(null);
			}
		}
		return vtkPolarAxesActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetArcMajorTickSize_138(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the size of the major ticks on the last arc.
	/// </summary>
	public virtual void SetArcMajorTickSize(double _arg)
	{
		vtkPolarAxesActor_SetArcMajorTickSize_138(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetArcMajorTickThickness_139(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the size of the thickness of the last arc ticks
	/// </summary>
	public virtual void SetArcMajorTickThickness(double _arg)
	{
		vtkPolarAxesActor_SetArcMajorTickThickness_139(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetArcMinorTickVisibility_140(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks on the last arc.
	/// </summary>
	public virtual void SetArcMinorTickVisibility(int _arg)
	{
		vtkPolarAxesActor_SetArcMinorTickVisibility_140(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetArcTickRatioSize_141(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ratio between major and minor Arc ticks size
	/// </summary>
	public virtual void SetArcTickRatioSize(double _arg)
	{
		vtkPolarAxesActor_SetArcTickRatioSize_141(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetArcTickRatioThickness_142(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ratio between major and minor Arc ticks thickness
	/// </summary>
	public virtual void SetArcTickRatioThickness(double _arg)
	{
		vtkPolarAxesActor_SetArcTickRatioThickness_142(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetArcTickVisibility_143(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of major ticks on the last arc.
	/// </summary>
	public virtual void SetArcTickVisibility(int _arg)
	{
		vtkPolarAxesActor_SetArcTickVisibility_143(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetArcTicksOriginToPolarAxis_144(HandleRef pThis, int _arg);

	/// <summary>
	/// If On, the ticks are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
	/// and continue counterclockwise with the step DeltaAngle Major/Minor. if Off, the start angle is
	/// 0.0, i.e.
	/// the angle on the major radius of the ellipse.
	/// </summary>
	public virtual void SetArcTicksOriginToPolarAxis(int _arg)
	{
		vtkPolarAxesActor_SetArcTicksOriginToPolarAxis_144(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetAutoSubdividePolarAxis_145(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether the number of polar axis ticks and arcs should be automatically calculated
	/// Default: true
	/// </summary>
	public virtual void SetAutoSubdividePolarAxis(bool _arg)
	{
		vtkPolarAxesActor_SetAutoSubdividePolarAxis_145(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetAxisMinorTickVisibility_146(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks on polar axis and last radial axis.
	/// </summary>
	public virtual void SetAxisMinorTickVisibility(int _arg)
	{
		vtkPolarAxesActor_SetAxisMinorTickVisibility_146(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetAxisTickVisibility_147(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of major ticks on polar axis and last radial axis.
	/// </summary>
	public virtual void SetAxisTickVisibility(int _arg)
	{
		vtkPolarAxesActor_SetAxisTickVisibility_147(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetBounds_148(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds are used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkPolarAxesActor_SetBounds_148(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetBounds_149(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds are used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkPolarAxesActor_SetBounds_149(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetCamera_150(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the camera to perform scaling and translation of the
	/// vtkPolarAxesActor.
	/// </summary>
	public virtual void SetCamera(vtkCamera arg0)
	{
		vtkPolarAxesActor_SetCamera_150(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetDeltaAngleMajor_151(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the angle between 2 major ticks on the last arc.
	/// </summary>
	public virtual void SetDeltaAngleMajor(double _arg)
	{
		vtkPolarAxesActor_SetDeltaAngleMajor_151(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetDeltaAngleMinor_152(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the angle between 2 minor ticks on the last arc.
	/// </summary>
	public virtual void SetDeltaAngleMinor(double _arg)
	{
		vtkPolarAxesActor_SetDeltaAngleMinor_152(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetDeltaAngleRadialAxes_153(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the angle between 2 radial axes.
	/// </summary>
	public virtual void SetDeltaAngleRadialAxes(double _arg)
	{
		vtkPolarAxesActor_SetDeltaAngleRadialAxes_153(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetDeltaRangeMajor_154(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the step between 2 major ticks, in range value (values displayed on the axis).
	/// </summary>
	public virtual void SetDeltaRangeMajor(double _arg)
	{
		vtkPolarAxesActor_SetDeltaRangeMajor_154(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetDeltaRangeMinor_155(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the step between 2 minor ticks, in range value (values displayed on the axis).
	/// </summary>
	public virtual void SetDeltaRangeMinor(double _arg)
	{
		vtkPolarAxesActor_SetDeltaRangeMinor_155(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetDistanceLODThreshold_156(HandleRef pThis, double _arg);

	/// <summary>
	/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual void SetDistanceLODThreshold(double _arg)
	{
		vtkPolarAxesActor_SetDistanceLODThreshold_156(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetDrawPolarArcsGridlines_157(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of inner polar arcs grid lines
	/// </summary>
	public virtual void SetDrawPolarArcsGridlines(int _arg)
	{
		vtkPolarAxesActor_SetDrawPolarArcsGridlines_157(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetDrawRadialGridlines_158(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of inner radial grid lines
	/// </summary>
	public virtual void SetDrawRadialGridlines(int _arg)
	{
		vtkPolarAxesActor_SetDrawRadialGridlines_158(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetEnableDistanceLOD_159(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable and disable the use of distance based LOD for titles and labels.
	/// </summary>
	public virtual void SetEnableDistanceLOD(int _arg)
	{
		vtkPolarAxesActor_SetEnableDistanceLOD_159(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetEnableViewAngleLOD_160(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable and disable the use of view angle based LOD for titles and labels.
	/// </summary>
	public virtual void SetEnableViewAngleLOD(int _arg)
	{
		vtkPolarAxesActor_SetEnableViewAngleLOD_160(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetExponentLocation_161(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the location of the exponent (if any) of the polar axis values.
	/// Possible location: VTK_EXPONENT_BOTTOM, VTK_EXPONENT_EXTERN,
	/// VTK_EXPONENT_LABELS
	/// </summary>
	public virtual void SetExponentLocation(int _arg)
	{
		vtkPolarAxesActor_SetExponentLocation_161(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetLastAxisTickRatioSize_162(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ratio between major and minor Last Radial axis ticks size
	/// </summary>
	public virtual void SetLastAxisTickRatioSize(double _arg)
	{
		vtkPolarAxesActor_SetLastAxisTickRatioSize_162(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetLastAxisTickRatioThickness_163(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ratio between major and minor Last Radial axis ticks thickness
	/// </summary>
	public virtual void SetLastAxisTickRatioThickness(double _arg)
	{
		vtkPolarAxesActor_SetLastAxisTickRatioThickness_163(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetLastRadialAxisMajorTickSize_164(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the size of the major ticks on the last radial axis.
	/// </summary>
	public virtual void SetLastRadialAxisMajorTickSize(double _arg)
	{
		vtkPolarAxesActor_SetLastRadialAxisMajorTickSize_164(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetLastRadialAxisMajorTickThickness_165(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the size of the thickness of last radial axis ticks
	/// </summary>
	public virtual void SetLastRadialAxisMajorTickThickness(double _arg)
	{
		vtkPolarAxesActor_SetLastRadialAxisMajorTickThickness_165(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetLastRadialAxisProperty_166(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Get/Set last radial axis actor properties.
	/// </summary>
	public virtual void SetLastRadialAxisProperty(vtkProperty p)
	{
		vtkPolarAxesActor_SetLastRadialAxisProperty_166(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetLastRadialAxisTextProperty_167(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the last radial axis text property.
	/// </summary>
	public virtual void SetLastRadialAxisTextProperty(vtkTextProperty p)
	{
		vtkPolarAxesActor_SetLastRadialAxisTextProperty_167(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetLog_168(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/Disable log scale
	/// Default: false
	/// </summary>
	public virtual void SetLog(bool _arg)
	{
		vtkPolarAxesActor_SetLog_168(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetMaximumAngle_169(HandleRef pThis, double arg0);

	/// <summary>
	/// Set/Get the maximum radius of the polar coordinates (in degrees).
	/// </summary>
	public virtual void SetMaximumAngle(double arg0)
	{
		vtkPolarAxesActor_SetMaximumAngle_169(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetMaximumRadius_170(HandleRef pThis, double arg0);

	/// <summary>
	/// Set/Get the maximum radius of the polar coordinates.
	/// </summary>
	public virtual void SetMaximumRadius(double arg0)
	{
		vtkPolarAxesActor_SetMaximumRadius_170(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetMinimumAngle_171(HandleRef pThis, double arg0);

	/// <summary>
	/// Set/Get the minimum radius of the polar coordinates (in degrees).
	/// </summary>
	public virtual void SetMinimumAngle(double arg0)
	{
		vtkPolarAxesActor_SetMinimumAngle_171(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetMinimumRadius_172(HandleRef pThis, double arg0);

	/// <summary>
	/// Set/Get the minimal radius of the polar coordinates.
	/// </summary>
	public virtual void SetMinimumRadius(double arg0)
	{
		vtkPolarAxesActor_SetMinimumRadius_172(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetNumberOfPolarAxisTicks_173(HandleRef pThis, int arg0);

	/// <summary>
	/// Set/Get a number of ticks that one would like to display along polar axis
	/// NB: it modifies DeltaRangeMajor to correspond to this number
	/// </summary>
	public virtual void SetNumberOfPolarAxisTicks(int arg0)
	{
		vtkPolarAxesActor_SetNumberOfPolarAxisTicks_173(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarArcsProperty_174(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Get/Set principal polar arc actor property.
	/// </summary>
	public virtual void SetPolarArcsProperty(vtkProperty p)
	{
		vtkPolarAxesActor_SetPolarArcsProperty_174(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarArcsVisibility_175(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of arcs for polar axis.
	/// </summary>
	public virtual void SetPolarArcsVisibility(int _arg)
	{
		vtkPolarAxesActor_SetPolarArcsVisibility_175(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarAxisLabelTextProperty_176(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the polar axis labels text property.
	/// </summary>
	public virtual void SetPolarAxisLabelTextProperty(vtkTextProperty p)
	{
		vtkPolarAxesActor_SetPolarAxisLabelTextProperty_176(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarAxisMajorTickSize_177(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the size of the major ticks on the polar axis.
	/// </summary>
	public virtual void SetPolarAxisMajorTickSize(double _arg)
	{
		vtkPolarAxesActor_SetPolarAxisMajorTickSize_177(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarAxisMajorTickThickness_178(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the size of the thickness of polar axis ticks
	/// </summary>
	public virtual void SetPolarAxisMajorTickThickness(double _arg)
	{
		vtkPolarAxesActor_SetPolarAxisMajorTickThickness_178(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarAxisProperty_179(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set polar axis actor properties.
	/// </summary>
	public virtual void SetPolarAxisProperty(vtkProperty arg0)
	{
		vtkPolarAxesActor_SetPolarAxisProperty_179(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarAxisTickRatioSize_180(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ratio between major and minor Polar Axis ticks size
	/// </summary>
	public virtual void SetPolarAxisTickRatioSize(double _arg)
	{
		vtkPolarAxesActor_SetPolarAxisTickRatioSize_180(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarAxisTickRatioThickness_181(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ratio between major and minor Polar Axis ticks thickness
	/// </summary>
	public virtual void SetPolarAxisTickRatioThickness(double _arg)
	{
		vtkPolarAxesActor_SetPolarAxisTickRatioThickness_181(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarAxisTitle_182(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the labels for the polar axis.
	/// Default: "Radial Distance".
	/// </summary>
	public virtual void SetPolarAxisTitle(string _arg)
	{
		vtkPolarAxesActor_SetPolarAxisTitle_182(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarAxisTitleLocation_183(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the alignment of the polar axes title related to the axis.
	/// Possible Alignment: VTKTITLE_BOTTOM, VTK_TITLE_EXTERN
	/// </summary>
	public virtual void SetPolarAxisTitleLocation(int _arg)
	{
		vtkPolarAxesActor_SetPolarAxisTitleLocation_183(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarAxisTitleTextProperty_184(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the polar axis title text property.
	/// </summary>
	public virtual void SetPolarAxisTitleTextProperty(vtkTextProperty p)
	{
		vtkPolarAxesActor_SetPolarAxisTitleTextProperty_184(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarAxisVisibility_185(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of the polar axis.
	/// </summary>
	public virtual void SetPolarAxisVisibility(int _arg)
	{
		vtkPolarAxesActor_SetPolarAxisVisibility_185(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarLabelFormat_186(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the format with which to print the polar axis labels.
	/// </summary>
	public virtual void SetPolarLabelFormat(string _arg)
	{
		vtkPolarAxesActor_SetPolarLabelFormat_186(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarLabelVisibility_187(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of labels for polar axis.
	/// </summary>
	public virtual void SetPolarLabelVisibility(int _arg)
	{
		vtkPolarAxesActor_SetPolarLabelVisibility_187(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarTickVisibility_188(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the overall visibility of ticks.
	/// </summary>
	public virtual void SetPolarTickVisibility(int _arg)
	{
		vtkPolarAxesActor_SetPolarTickVisibility_188(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPolarTitleVisibility_189(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of titles for polar axis.
	/// </summary>
	public virtual void SetPolarTitleVisibility(int _arg)
	{
		vtkPolarAxesActor_SetPolarTitleVisibility_189(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPole_190(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Explicitly specify the coordinate of the pole.
	/// </summary>
	public virtual void SetPole(IntPtr arg0)
	{
		vtkPolarAxesActor_SetPole_190(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetPole_191(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Explicitly specify the coordinate of the pole.
	/// </summary>
	public virtual void SetPole(double arg0, double arg1, double arg2)
	{
		vtkPolarAxesActor_SetPole_191(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetRadialAngleFormat_192(HandleRef pThis, string _arg);

	/// <summary>
	/// String to format angle values displayed on the radial axes.
	/// </summary>
	public virtual void SetRadialAngleFormat(string _arg)
	{
		vtkPolarAxesActor_SetRadialAngleFormat_192(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetRadialAxesOriginToPolarAxis_193(HandleRef pThis, int _arg);

	/// <summary>
	/// If On, the radial axes are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
	/// and continue counterclockwise with the step DeltaAngleRadialAxes. if Off, the start angle is
	/// 0.0, i.e.
	/// the angle on the major radius of the ellipse.
	/// </summary>
	public virtual void SetRadialAxesOriginToPolarAxis(int _arg)
	{
		vtkPolarAxesActor_SetRadialAxesOriginToPolarAxis_193(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetRadialAxesVisibility_194(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of non-polar radial axes.
	/// </summary>
	public virtual void SetRadialAxesVisibility(int _arg)
	{
		vtkPolarAxesActor_SetRadialAxesVisibility_194(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetRadialAxisTitleLocation_195(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the alignment of the radial axes title related to the axis.
	/// Possible Alignment: VTK_TITLE_BOTTOM, VTK_TITLE_EXTERN
	/// </summary>
	public virtual void SetRadialAxisTitleLocation(int _arg)
	{
		vtkPolarAxesActor_SetRadialAxisTitleLocation_195(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetRadialTitleVisibility_196(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of titles for non-polar radial axes.
	/// </summary>
	public virtual void SetRadialTitleVisibility(int _arg)
	{
		vtkPolarAxesActor_SetRadialTitleVisibility_196(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetRadialUnits_197(HandleRef pThis, byte _arg);

	/// <summary>
	/// Default: true
	/// </summary>
	public virtual void SetRadialUnits(bool _arg)
	{
		vtkPolarAxesActor_SetRadialUnits_197(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetRange_198(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Define the range values displayed on the polar Axis.
	/// </summary>
	public virtual void SetRange(double _arg1, double _arg2)
	{
		vtkPolarAxesActor_SetRange_198(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetRange_199(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Define the range values displayed on the polar Axis.
	/// </summary>
	public void SetRange(IntPtr _arg)
	{
		vtkPolarAxesActor_SetRange_199(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetRatio_200(HandleRef pThis, double _arg);

	/// <summary>
	/// Ratio
	/// </summary>
	public virtual void SetRatio(double _arg)
	{
		vtkPolarAxesActor_SetRatio_200(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetRequestedNumberOfRadialAxes_201(HandleRef pThis, long _arg);

	/// <summary>
	/// Gets/Sets the number of radial axes
	/// </summary>
	public virtual void SetRequestedNumberOfRadialAxes(long _arg)
	{
		vtkPolarAxesActor_SetRequestedNumberOfRadialAxes_201(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetScreenSize_202(HandleRef pThis, double _arg);

	/// <summary>
	/// Explicitly specify the screen size of title and label text.
	/// ScreenSize determines the size of the text in terms of screen
	/// pixels.
	/// Default: 10.0.
	/// </summary>
	public virtual void SetScreenSize(double _arg)
	{
		vtkPolarAxesActor_SetScreenSize_202(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetSecondaryPolarArcsProperty_203(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Get/Set secondary polar arcs actors property.
	/// </summary>
	public virtual void SetSecondaryPolarArcsProperty(vtkProperty p)
	{
		vtkPolarAxesActor_SetSecondaryPolarArcsProperty_203(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetSecondaryRadialAxesProperty_204(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Get/Set secondary radial axes actors properties.
	/// </summary>
	public virtual void SetSecondaryRadialAxesProperty(vtkProperty p)
	{
		vtkPolarAxesActor_SetSecondaryRadialAxesProperty_204(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetSecondaryRadialAxesTextProperty_205(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the secondary radial axes text property.
	/// </summary>
	public virtual void SetSecondaryRadialAxesTextProperty(vtkTextProperty p)
	{
		vtkPolarAxesActor_SetSecondaryRadialAxesTextProperty_205(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetSmallestVisiblePolarAngle_206(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the minimum radial angle distinguishable from polar axis
	/// NB: This is used only when polar axis is visible
	/// Default: 0.5
	/// </summary>
	public virtual void SetSmallestVisiblePolarAngle(double _arg)
	{
		vtkPolarAxesActor_SetSmallestVisiblePolarAngle_206(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetTickLocation_207(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the location of the ticks.
	/// Inside: tick end toward positive direction of perpendicular axes.
	/// Outside: tick end toward negative direction of perpendicular axes.
	/// </summary>
	public virtual void SetTickLocation(int _arg)
	{
		vtkPolarAxesActor_SetTickLocation_207(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetUse2DMode_208(HandleRef pThis, int val);

	/// <summary>
	/// Enable/Disable labels 2D mode (always facing the camera).
	/// </summary>
	public void SetUse2DMode(int val)
	{
		vtkPolarAxesActor_SetUse2DMode_208(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolarAxesActor_SetViewAngleLODThreshold_209(HandleRef pThis, double _arg);

	/// <summary>
	/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual void SetViewAngleLODThreshold(double _arg)
	{
		vtkPolarAxesActor_SetViewAngleLODThreshold_209(GetCppThis(), _arg);
	}
}
