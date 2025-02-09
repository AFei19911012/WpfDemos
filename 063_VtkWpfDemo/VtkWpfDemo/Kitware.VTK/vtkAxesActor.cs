using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAxesActor
/// </summary>
/// <remarks>
///    a 3D axes representation
///
/// vtkAxesActor is a hybrid 2D/3D actor used to represent 3D axes in a scene.
/// The user can define the geometry to use for the shaft or the tip, and the
/// user can set the text for the three axes. The text will appear to follow the
/// camera since it is implemented by means of vtkCaptionActor2D.  All of the
/// functionality of the underlying vtkCaptionActor2D objects are accessible so
/// that, for instance, the font attributes of the axes text can be manipulated
/// through vtkTextProperty. Since this class inherits from vtkProp3D, one can
/// apply a user transform to the underlying geometry and the positioning of the
/// labels. For example, a rotation transform could be used to generate a
/// left-handed axes representation.
///
/// @par Thanks:
/// Thanks to Goodwin Lawlor for posting a tcl script which featured the
/// use of vtkCaptionActor2D to implement the text labels.  This class is
/// based on Paraview's vtkPVAxesActor.
///
/// @warning
/// vtkAxesActor is primarily intended for use with vtkOrientationMarkerWidget.
/// The bounds of this actor are calculated as though the geometry of the axes
/// were symmetric: that is, although only positive axes are visible, bounds
/// are calculated as though negative axes are present too.  This is done
/// intentionally to implement functionality of the camera update mechanism
/// in vtkOrientationMarkerWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkAnnotatedCubeActor vtkOrientationMarkerWidget vtkCaptionActor2D
/// vtkTextProperty
/// </seealso>
public class vtkAxesActor : vtkProp3D
{
	/// <summary>
	/// Enable/disable drawing the axis labels.
	/// </summary>
	public enum CYLINDER_SHAFT_WrapperEnum
	{
		/// <summary>enum member</summary>
		CYLINDER_SHAFT,
		/// <summary>enum member</summary>
		LINE_SHAFT,
		/// <summary>enum member</summary>
		USER_DEFINED_SHAFT
	}

	/// <summary>
	/// Enable/disable drawing the axis labels.
	/// </summary>
	public enum CONE_TIP_WrapperEnum
	{
		/// <summary>enum member</summary>
		CONE_TIP,
		/// <summary>enum member</summary>
		SPHERE_TIP,
		/// <summary>enum member</summary>
		USER_DEFINED_TIP
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAxesActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAxesActor()
	{
		MRClassNameKey = "class vtkAxesActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxesActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAxesActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAxesActor New()
	{
		vtkAxesActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAxesActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAxesActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAxesActor_AxisLabelsOff_01(HandleRef pThis);

	/// <summary>
	/// Enable/disable drawing the axis labels.
	/// </summary>
	public virtual void AxisLabelsOff()
	{
		vtkAxesActor_AxisLabelsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_AxisLabelsOn_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable drawing the axis labels.
	/// </summary>
	public virtual void AxisLabelsOn()
	{
		vtkAxesActor_AxisLabelsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_GetActors_03(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkAxesActor_GetActors_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetAxisLabels_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable drawing the axis labels.
	/// </summary>
	public virtual int GetAxisLabels()
	{
		return vtkAxesActor_GetAxisLabels_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_GetBounds_05(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax). (The
	/// method GetBounds(double bounds[6]) is available from the superclass.)
	/// </summary>
	public new void GetBounds(IntPtr bounds)
	{
		vtkAxesActor_GetBounds_05(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetBounds_06(HandleRef pThis);

	/// <summary>
	/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax). (The
	/// method GetBounds(double bounds[6]) is available from the superclass.)
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkAxesActor_GetBounds_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxesActor_GetConeRadius_07(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual double GetConeRadius()
	{
		return vtkAxesActor_GetConeRadius_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxesActor_GetConeRadiusMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual double GetConeRadiusMaxValue()
	{
		return vtkAxesActor_GetConeRadiusMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxesActor_GetConeRadiusMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual double GetConeRadiusMinValue()
	{
		return vtkAxesActor_GetConeRadiusMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetConeResolution_10(HandleRef pThis);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual int GetConeResolution()
	{
		return vtkAxesActor_GetConeResolution_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetConeResolutionMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual int GetConeResolutionMaxValue()
	{
		return vtkAxesActor_GetConeResolutionMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetConeResolutionMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual int GetConeResolutionMinValue()
	{
		return vtkAxesActor_GetConeResolutionMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxesActor_GetCylinderRadius_13(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual double GetCylinderRadius()
	{
		return vtkAxesActor_GetCylinderRadius_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxesActor_GetCylinderRadiusMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual double GetCylinderRadiusMaxValue()
	{
		return vtkAxesActor_GetCylinderRadiusMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxesActor_GetCylinderRadiusMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual double GetCylinderRadiusMinValue()
	{
		return vtkAxesActor_GetCylinderRadiusMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetCylinderResolution_16(HandleRef pThis);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual int GetCylinderResolution()
	{
		return vtkAxesActor_GetCylinderResolution_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetCylinderResolutionMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual int GetCylinderResolutionMaxValue()
	{
		return vtkAxesActor_GetCylinderResolutionMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetCylinderResolutionMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual int GetCylinderResolutionMinValue()
	{
		return vtkAxesActor_GetCylinderResolutionMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkAxesActor_GetMTime_19(HandleRef pThis);

	/// <summary>
	/// Get the actors mtime plus consider its properties and texture if set.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkAxesActor_GetMTime_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetNormalizedLabelPosition_20(HandleRef pThis);

	/// <summary>
	/// Set the normalized (0-1) position of the label along the length of
	/// the shaft.  A value &gt; 1 is permissible.
	/// </summary>
	public virtual double[] GetNormalizedLabelPosition()
	{
		IntPtr intPtr = vtkAxesActor_GetNormalizedLabelPosition_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_GetNormalizedLabelPosition_21(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the normalized (0-1) position of the label along the length of
	/// the shaft.  A value &gt; 1 is permissible.
	/// </summary>
	public virtual void GetNormalizedLabelPosition(IntPtr data)
	{
		vtkAxesActor_GetNormalizedLabelPosition_21(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetNormalizedShaftLength_22(HandleRef pThis);

	/// <summary>
	/// Set the normalized (0-1) length of the shaft.
	/// </summary>
	public virtual double[] GetNormalizedShaftLength()
	{
		IntPtr intPtr = vtkAxesActor_GetNormalizedShaftLength_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_GetNormalizedShaftLength_23(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the normalized (0-1) length of the shaft.
	/// </summary>
	public virtual void GetNormalizedShaftLength(IntPtr data)
	{
		vtkAxesActor_GetNormalizedShaftLength_23(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetNormalizedTipLength_24(HandleRef pThis);

	/// <summary>
	/// Set the normalized (0-1) length of the tip.  Normally, this would be
	/// 1 - the normalized length of the shaft.
	/// </summary>
	public virtual double[] GetNormalizedTipLength()
	{
		IntPtr intPtr = vtkAxesActor_GetNormalizedTipLength_24(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_GetNormalizedTipLength_25(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the normalized (0-1) length of the tip.  Normally, this would be
	/// 1 - the normalized length of the shaft.
	/// </summary>
	public virtual void GetNormalizedTipLength(IntPtr data)
	{
		vtkAxesActor_GetNormalizedTipLength_25(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxesActor_GetNumberOfGenerationsFromBase_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAxesActor_GetNumberOfGenerationsFromBase_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxesActor_GetNumberOfGenerationsFromBaseType_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAxesActor_GetNumberOfGenerationsFromBaseType_27(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkAxesActor_GetRedrawMTime_28(HandleRef pThis);

	/// <summary>
	/// Return the mtime of anything that would cause the rendered image to
	/// appear differently. Usually this involves checking the mtime of the
	/// prop plus anything else it depends on such as properties, textures
	/// etc.
	/// </summary>
	public override ulong GetRedrawMTime()
	{
		return vtkAxesActor_GetRedrawMTime_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetShaftType_29(HandleRef pThis);

	/// <summary>
	/// Set the type of the shaft to a cylinder, line, or user defined geometry.
	/// </summary>
	public virtual int GetShaftType()
	{
		return vtkAxesActor_GetShaftType_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxesActor_GetSphereRadius_30(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual double GetSphereRadius()
	{
		return vtkAxesActor_GetSphereRadius_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxesActor_GetSphereRadiusMaxValue_31(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual double GetSphereRadiusMaxValue()
	{
		return vtkAxesActor_GetSphereRadiusMaxValue_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxesActor_GetSphereRadiusMinValue_32(HandleRef pThis);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual double GetSphereRadiusMinValue()
	{
		return vtkAxesActor_GetSphereRadiusMinValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetSphereResolution_33(HandleRef pThis);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual int GetSphereResolution()
	{
		return vtkAxesActor_GetSphereResolution_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetSphereResolutionMaxValue_34(HandleRef pThis);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual int GetSphereResolutionMaxValue()
	{
		return vtkAxesActor_GetSphereResolutionMaxValue_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetSphereResolutionMinValue_35(HandleRef pThis);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual int GetSphereResolutionMinValue()
	{
		return vtkAxesActor_GetSphereResolutionMinValue_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_GetTipType_36(HandleRef pThis);

	/// <summary>
	/// Set the type of the tip to a cone, sphere, or user defined geometry.
	/// </summary>
	public virtual int GetTipType()
	{
		return vtkAxesActor_GetTipType_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetTotalLength_37(HandleRef pThis);

	/// <summary>
	/// Set the total length of the axes in 3 dimensions.
	/// </summary>
	public virtual double[] GetTotalLength()
	{
		IntPtr intPtr = vtkAxesActor_GetTotalLength_37(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_GetTotalLength_38(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the total length of the axes in 3 dimensions.
	/// </summary>
	public virtual void GetTotalLength(IntPtr data)
	{
		vtkAxesActor_GetTotalLength_38(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetUserDefinedShaft_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the user defined shaft polydata.
	/// </summary>
	public virtual vtkPolyData GetUserDefinedShaft()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_GetUserDefinedShaft_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetUserDefinedTip_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the user defined tip polydata.
	/// </summary>
	public virtual vtkPolyData GetUserDefinedTip()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_GetUserDefinedTip_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetXAxisCaptionActor2D_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve handles to the X, Y and Z axis (so that you can set their text
	/// properties for example)
	/// </summary>
	public vtkCaptionActor2D GetXAxisCaptionActor2D()
	{
		vtkCaptionActor2D vtkCaptionActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_GetXAxisCaptionActor2D_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCaptionActor2D2 = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCaptionActor2D2.Register(null);
			}
		}
		return vtkCaptionActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetXAxisLabelText_42(HandleRef pThis);

	/// <summary>
	/// Set/get the label text.
	/// </summary>
	public virtual string GetXAxisLabelText()
	{
		return Marshal.PtrToStringAnsi(vtkAxesActor_GetXAxisLabelText_42(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetXAxisShaftProperty_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the shaft properties.
	/// </summary>
	public vtkProperty GetXAxisShaftProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_GetXAxisShaftProperty_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAxesActor_GetXAxisTipProperty_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the tip properties.
	/// </summary>
	public vtkProperty GetXAxisTipProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_GetXAxisTipProperty_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAxesActor_GetYAxisCaptionActor2D_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve handles to the X, Y and Z axis (so that you can set their text
	/// properties for example)
	/// </summary>
	public vtkCaptionActor2D GetYAxisCaptionActor2D()
	{
		vtkCaptionActor2D vtkCaptionActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_GetYAxisCaptionActor2D_45(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCaptionActor2D2 = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCaptionActor2D2.Register(null);
			}
		}
		return vtkCaptionActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetYAxisLabelText_46(HandleRef pThis);

	/// <summary>
	/// Set/get the label text.
	/// </summary>
	public virtual string GetYAxisLabelText()
	{
		return Marshal.PtrToStringAnsi(vtkAxesActor_GetYAxisLabelText_46(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetYAxisShaftProperty_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the shaft properties.
	/// </summary>
	public vtkProperty GetYAxisShaftProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_GetYAxisShaftProperty_47(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAxesActor_GetYAxisTipProperty_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the tip properties.
	/// </summary>
	public vtkProperty GetYAxisTipProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_GetYAxisTipProperty_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAxesActor_GetZAxisCaptionActor2D_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve handles to the X, Y and Z axis (so that you can set their text
	/// properties for example)
	/// </summary>
	public vtkCaptionActor2D GetZAxisCaptionActor2D()
	{
		vtkCaptionActor2D vtkCaptionActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_GetZAxisCaptionActor2D_49(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCaptionActor2D2 = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCaptionActor2D2.Register(null);
			}
		}
		return vtkCaptionActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetZAxisLabelText_50(HandleRef pThis);

	/// <summary>
	/// Set/get the label text.
	/// </summary>
	public virtual string GetZAxisLabelText()
	{
		return Marshal.PtrToStringAnsi(vtkAxesActor_GetZAxisLabelText_50(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_GetZAxisShaftProperty_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the shaft properties.
	/// </summary>
	public vtkProperty GetZAxisShaftProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_GetZAxisShaftProperty_51(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAxesActor_GetZAxisTipProperty_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the tip properties.
	/// </summary>
	public vtkProperty GetZAxisTipProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_GetZAxisTipProperty_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkAxesActor_HasTranslucentPolygonalGeometry_53(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkAxesActor_HasTranslucentPolygonalGeometry_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_IsA_54(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAxesActor_IsA_54(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_IsTypeOf_55(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAxesActor_IsTypeOf_55(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_NewInstance_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAxesActor NewInstance()
	{
		vtkAxesActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_NewInstance_57(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_ReleaseGraphicsResources_58(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkAxesActor_ReleaseGraphicsResources_58(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_RenderOpaqueGeometry_59(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkAxesActor_RenderOpaqueGeometry_59(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_RenderOverlay_60(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkAxesActor_RenderOverlay_60(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesActor_RenderTranslucentPolygonalGeometry_61(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkAxesActor_RenderTranslucentPolygonalGeometry_61(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesActor_SafeDownCast_62(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAxesActor SafeDownCast(vtkObjectBase o)
	{
		vtkAxesActor vtkAxesActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesActor_SafeDownCast_62(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxesActor2 = (vtkAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxesActor2.Register(null);
			}
		}
		return vtkAxesActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetAxisLabels_63(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable drawing the axis labels.
	/// </summary>
	public virtual void SetAxisLabels(int _arg)
	{
		vtkAxesActor_SetAxisLabels_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetConeRadius_64(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual void SetConeRadius(double _arg)
	{
		vtkAxesActor_SetConeRadius_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetConeResolution_65(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual void SetConeResolution(int _arg)
	{
		vtkAxesActor_SetConeResolution_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetCylinderRadius_66(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual void SetCylinderRadius(double _arg)
	{
		vtkAxesActor_SetCylinderRadius_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetCylinderResolution_67(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual void SetCylinderResolution(int _arg)
	{
		vtkAxesActor_SetCylinderResolution_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetNormalizedLabelPosition_68(HandleRef pThis, IntPtr v);

	/// <summary>
	/// Set the normalized (0-1) position of the label along the length of
	/// the shaft.  A value &gt; 1 is permissible.
	/// </summary>
	public void SetNormalizedLabelPosition(IntPtr v)
	{
		vtkAxesActor_SetNormalizedLabelPosition_68(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetNormalizedLabelPosition_69(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set the normalized (0-1) position of the label along the length of
	/// the shaft.  A value &gt; 1 is permissible.
	/// </summary>
	public void SetNormalizedLabelPosition(double x, double y, double z)
	{
		vtkAxesActor_SetNormalizedLabelPosition_69(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetNormalizedShaftLength_70(HandleRef pThis, IntPtr v);

	/// <summary>
	/// Set the normalized (0-1) length of the shaft.
	/// </summary>
	public void SetNormalizedShaftLength(IntPtr v)
	{
		vtkAxesActor_SetNormalizedShaftLength_70(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetNormalizedShaftLength_71(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set the normalized (0-1) length of the shaft.
	/// </summary>
	public void SetNormalizedShaftLength(double x, double y, double z)
	{
		vtkAxesActor_SetNormalizedShaftLength_71(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetNormalizedTipLength_72(HandleRef pThis, IntPtr v);

	/// <summary>
	/// Set the normalized (0-1) length of the tip.  Normally, this would be
	/// 1 - the normalized length of the shaft.
	/// </summary>
	public void SetNormalizedTipLength(IntPtr v)
	{
		vtkAxesActor_SetNormalizedTipLength_72(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetNormalizedTipLength_73(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set the normalized (0-1) length of the tip.  Normally, this would be
	/// 1 - the normalized length of the shaft.
	/// </summary>
	public void SetNormalizedTipLength(double x, double y, double z)
	{
		vtkAxesActor_SetNormalizedTipLength_73(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetShaftType_74(HandleRef pThis, int type);

	/// <summary>
	/// Set the type of the shaft to a cylinder, line, or user defined geometry.
	/// </summary>
	public void SetShaftType(int type)
	{
		vtkAxesActor_SetShaftType_74(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetShaftTypeToCylinder_75(HandleRef pThis);

	/// <summary>
	/// Set the type of the shaft to a cylinder, line, or user defined geometry.
	/// </summary>
	public void SetShaftTypeToCylinder()
	{
		vtkAxesActor_SetShaftTypeToCylinder_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetShaftTypeToLine_76(HandleRef pThis);

	/// <summary>
	/// Set the type of the shaft to a cylinder, line, or user defined geometry.
	/// </summary>
	public void SetShaftTypeToLine()
	{
		vtkAxesActor_SetShaftTypeToLine_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetShaftTypeToUserDefined_77(HandleRef pThis);

	/// <summary>
	/// Set the type of the shaft to a cylinder, line, or user defined geometry.
	/// </summary>
	public void SetShaftTypeToUserDefined()
	{
		vtkAxesActor_SetShaftTypeToUserDefined_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetSphereRadius_78(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the radius of the pieces of the axes actor.
	/// </summary>
	public virtual void SetSphereRadius(double _arg)
	{
		vtkAxesActor_SetSphereRadius_78(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetSphereResolution_79(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the resolution of the pieces of the axes actor.
	/// </summary>
	public virtual void SetSphereResolution(int _arg)
	{
		vtkAxesActor_SetSphereResolution_79(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetTipType_80(HandleRef pThis, int type);

	/// <summary>
	/// Set the type of the tip to a cone, sphere, or user defined geometry.
	/// </summary>
	public void SetTipType(int type)
	{
		vtkAxesActor_SetTipType_80(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetTipTypeToCone_81(HandleRef pThis);

	/// <summary>
	/// Set the type of the tip to a cone, sphere, or user defined geometry.
	/// </summary>
	public void SetTipTypeToCone()
	{
		vtkAxesActor_SetTipTypeToCone_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetTipTypeToSphere_82(HandleRef pThis);

	/// <summary>
	/// Set the type of the tip to a cone, sphere, or user defined geometry.
	/// </summary>
	public void SetTipTypeToSphere()
	{
		vtkAxesActor_SetTipTypeToSphere_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetTipTypeToUserDefined_83(HandleRef pThis);

	/// <summary>
	/// Set the type of the tip to a cone, sphere, or user defined geometry.
	/// </summary>
	public void SetTipTypeToUserDefined()
	{
		vtkAxesActor_SetTipTypeToUserDefined_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetTotalLength_84(HandleRef pThis, IntPtr v);

	/// <summary>
	/// Set the total length of the axes in 3 dimensions.
	/// </summary>
	public void SetTotalLength(IntPtr v)
	{
		vtkAxesActor_SetTotalLength_84(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetTotalLength_85(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set the total length of the axes in 3 dimensions.
	/// </summary>
	public void SetTotalLength(double x, double y, double z)
	{
		vtkAxesActor_SetTotalLength_85(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetUserDefinedShaft_86(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the user defined shaft polydata.
	/// </summary>
	public void SetUserDefinedShaft(vtkPolyData arg0)
	{
		vtkAxesActor_SetUserDefinedShaft_86(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetUserDefinedTip_87(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the user defined tip polydata.
	/// </summary>
	public void SetUserDefinedTip(vtkPolyData arg0)
	{
		vtkAxesActor_SetUserDefinedTip_87(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetXAxisLabelText_88(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the label text.
	/// </summary>
	public virtual void SetXAxisLabelText(string _arg)
	{
		vtkAxesActor_SetXAxisLabelText_88(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetYAxisLabelText_89(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the label text.
	/// </summary>
	public virtual void SetYAxisLabelText(string _arg)
	{
		vtkAxesActor_SetYAxisLabelText_89(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_SetZAxisLabelText_90(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the label text.
	/// </summary>
	public virtual void SetZAxisLabelText(string _arg)
	{
		vtkAxesActor_SetZAxisLabelText_90(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesActor_ShallowCopy_91(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of an axes actor. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkAxesActor_ShallowCopy_91(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
