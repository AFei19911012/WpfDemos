using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLeaderActor2D
/// </summary>
/// <remarks>
///    create a leader with optional label and arrows
///
/// vtkLeaderActor2D creates a leader with an optional label and arrows. (A
/// leader is typically used to indicate distance between points.)
/// vtkLeaderActor2D is a type of vtkActor2D; that is, it is drawn on the
/// overlay plane and is not occluded by 3D geometry. To use this class, you
/// typically specify two points defining the start and end points of the line
/// (x-y definition using vtkCoordinate class), whether to place arrows on one
/// or both end points, and whether to label the leader. Also, this class has a
/// special feature that allows curved leaders to be created by specifying a
/// radius.
///
/// Use the vtkLeaderActor2D uses its superclass vtkActor2D instance variables
/// Position and Position2 vtkCoordinates to place an instance of
/// vtkLeaderActor2D (i.e., these two data members represent the start and end
/// points of the leader).  Using these vtkCoordinates you can specify the position
/// of the leader in a variety of coordinate systems.
///
/// To control the appearance of the actor, use the superclasses
/// vtkActor2D::vtkProperty2D and the vtkTextProperty objects associated with
/// this actor.
///
/// </remarks>
/// <seealso>
///
/// vtkAxisActor2D vtkActor2D vtkCoordinate vtkTextProperty
/// </seealso>
public class vtkLeaderActor2D : vtkActor2D
{
	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label the leader.
	/// </summary>
	public enum VTK_ARROW_BOTH_WrapperEnum
	{
		/// <summary>enum member</summary>
		VTK_ARROW_BOTH = 3,
		/// <summary>enum member</summary>
		VTK_ARROW_NONE = 0,
		/// <summary>enum member</summary>
		VTK_ARROW_POINT1 = 1,
		/// <summary>enum member</summary>
		VTK_ARROW_POINT2 = 2
	}

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label the leader.
	/// </summary>
	public enum VTK_ARROW_FILLED_WrapperEnum
	{
		/// <summary>enum member</summary>
		VTK_ARROW_FILLED = 0,
		/// <summary>enum member</summary>
		VTK_ARROW_HOLLOW = 2,
		/// <summary>enum member</summary>
		VTK_ARROW_OPEN = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLeaderActor2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLeaderActor2D()
	{
		MRClassNameKey = "class vtkLeaderActor2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLeaderActor2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLeaderActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLeaderActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new static vtkLeaderActor2D New()
	{
		vtkLeaderActor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLeaderActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public vtkLeaderActor2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLeaderActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLeaderActor2D_AutoLabelOff_01(HandleRef pThis);

	/// <summary>
	/// Enable auto-labelling. In this mode, the label is automatically updated
	/// based on distance (in world coordinates) between the two end points; or
	/// if a curved leader is being generated, the angle in degrees between the
	/// two points.
	/// </summary>
	public virtual void AutoLabelOff()
	{
		vtkLeaderActor2D_AutoLabelOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_AutoLabelOn_02(HandleRef pThis);

	/// <summary>
	/// Enable auto-labelling. In this mode, the label is automatically updated
	/// based on distance (in world coordinates) between the two end points; or
	/// if a curved leader is being generated, the angle in degrees between the
	/// two points.
	/// </summary>
	public virtual void AutoLabelOn()
	{
		vtkLeaderActor2D_AutoLabelOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetAngle_03(HandleRef pThis);

	/// <summary>
	/// Obtain the length of the leader if the leader is not curved,
	/// otherwise obtain the angle that the leader circumscribes.
	/// </summary>
	public virtual double GetAngle()
	{
		return vtkLeaderActor2D_GetAngle_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetArrowLength_04(HandleRef pThis);

	/// <summary>
	/// Specify the arrow length and base width (in normalized viewport
	/// coordinates).
	/// </summary>
	public virtual double GetArrowLength()
	{
		return vtkLeaderActor2D_GetArrowLength_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetArrowLengthMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the arrow length and base width (in normalized viewport
	/// coordinates).
	/// </summary>
	public virtual double GetArrowLengthMaxValue()
	{
		return vtkLeaderActor2D_GetArrowLengthMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetArrowLengthMinValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the arrow length and base width (in normalized viewport
	/// coordinates).
	/// </summary>
	public virtual double GetArrowLengthMinValue()
	{
		return vtkLeaderActor2D_GetArrowLengthMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_GetArrowPlacement_07(HandleRef pThis);

	/// <summary>
	/// Control whether arrow heads are drawn on the leader. Arrows may be
	/// drawn on one end, both ends, or not at all.
	/// </summary>
	public virtual int GetArrowPlacement()
	{
		return vtkLeaderActor2D_GetArrowPlacement_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_GetArrowPlacementMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Control whether arrow heads are drawn on the leader. Arrows may be
	/// drawn on one end, both ends, or not at all.
	/// </summary>
	public virtual int GetArrowPlacementMaxValue()
	{
		return vtkLeaderActor2D_GetArrowPlacementMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_GetArrowPlacementMinValue_09(HandleRef pThis);

	/// <summary>
	/// Control whether arrow heads are drawn on the leader. Arrows may be
	/// drawn on one end, both ends, or not at all.
	/// </summary>
	public virtual int GetArrowPlacementMinValue()
	{
		return vtkLeaderActor2D_GetArrowPlacementMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_GetArrowStyle_10(HandleRef pThis);

	/// <summary>
	/// Control the appearance of the arrow heads. A solid arrow head is a filled
	/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
	/// non-filled triangle.
	/// </summary>
	public virtual int GetArrowStyle()
	{
		return vtkLeaderActor2D_GetArrowStyle_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_GetArrowStyleMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Control the appearance of the arrow heads. A solid arrow head is a filled
	/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
	/// non-filled triangle.
	/// </summary>
	public virtual int GetArrowStyleMaxValue()
	{
		return vtkLeaderActor2D_GetArrowStyleMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_GetArrowStyleMinValue_12(HandleRef pThis);

	/// <summary>
	/// Control the appearance of the arrow heads. A solid arrow head is a filled
	/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
	/// non-filled triangle.
	/// </summary>
	public virtual int GetArrowStyleMinValue()
	{
		return vtkLeaderActor2D_GetArrowStyleMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetArrowWidth_13(HandleRef pThis);

	/// <summary>
	/// Specify the arrow length and base width (in normalized viewport
	/// coordinates).
	/// </summary>
	public virtual double GetArrowWidth()
	{
		return vtkLeaderActor2D_GetArrowWidth_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetArrowWidthMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Specify the arrow length and base width (in normalized viewport
	/// coordinates).
	/// </summary>
	public virtual double GetArrowWidthMaxValue()
	{
		return vtkLeaderActor2D_GetArrowWidthMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetArrowWidthMinValue_15(HandleRef pThis);

	/// <summary>
	/// Specify the arrow length and base width (in normalized viewport
	/// coordinates).
	/// </summary>
	public virtual double GetArrowWidthMinValue()
	{
		return vtkLeaderActor2D_GetArrowWidthMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_GetAutoLabel_16(HandleRef pThis);

	/// <summary>
	/// Enable auto-labelling. In this mode, the label is automatically updated
	/// based on distance (in world coordinates) between the two end points; or
	/// if a curved leader is being generated, the angle in degrees between the
	/// two points.
	/// </summary>
	public virtual int GetAutoLabel()
	{
		return vtkLeaderActor2D_GetAutoLabel_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLeaderActor2D_GetLabel_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the label for the leader. If the label is an empty string, then
	/// it will not be drawn.
	/// </summary>
	public virtual string GetLabel()
	{
		return Marshal.PtrToStringAnsi(vtkLeaderActor2D_GetLabel_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetLabelFactor_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label the leader.
	/// </summary>
	public virtual double GetLabelFactor()
	{
		return vtkLeaderActor2D_GetLabelFactor_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetLabelFactorMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label the leader.
	/// </summary>
	public virtual double GetLabelFactorMaxValue()
	{
		return vtkLeaderActor2D_GetLabelFactorMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetLabelFactorMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label the leader.
	/// </summary>
	public virtual double GetLabelFactorMinValue()
	{
		return vtkLeaderActor2D_GetLabelFactorMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLeaderActor2D_GetLabelFormat_21(HandleRef pThis);

	/// <summary>
	/// Specify the format to use for auto-labelling.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkLeaderActor2D_GetLabelFormat_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLeaderActor2D_GetLabelTextProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the text property of the label.
	/// </summary>
	public virtual vtkTextProperty GetLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLeaderActor2D_GetLabelTextProperty_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkLeaderActor2D_GetLength_23(HandleRef pThis);

	/// <summary>
	/// Obtain the length of the leader if the leader is not curved,
	/// otherwise obtain the angle that the leader circumscribes.
	/// </summary>
	public virtual double GetLength()
	{
		return vtkLeaderActor2D_GetLength_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetMaximumArrowSize_24(HandleRef pThis);

	/// <summary>
	/// Limit the minimum and maximum size of the arrows. These values are
	/// expressed in pixels and clamp the minimum/maximum possible size for the
	/// width/length of the arrow head. (When clamped, the ratio between length
	/// and width is preserved.)
	/// </summary>
	public virtual double GetMaximumArrowSize()
	{
		return vtkLeaderActor2D_GetMaximumArrowSize_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetMaximumArrowSizeMaxValue_25(HandleRef pThis);

	/// <summary>
	/// Limit the minimum and maximum size of the arrows. These values are
	/// expressed in pixels and clamp the minimum/maximum possible size for the
	/// width/length of the arrow head. (When clamped, the ratio between length
	/// and width is preserved.)
	/// </summary>
	public virtual double GetMaximumArrowSizeMaxValue()
	{
		return vtkLeaderActor2D_GetMaximumArrowSizeMaxValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetMaximumArrowSizeMinValue_26(HandleRef pThis);

	/// <summary>
	/// Limit the minimum and maximum size of the arrows. These values are
	/// expressed in pixels and clamp the minimum/maximum possible size for the
	/// width/length of the arrow head. (When clamped, the ratio between length
	/// and width is preserved.)
	/// </summary>
	public virtual double GetMaximumArrowSizeMinValue()
	{
		return vtkLeaderActor2D_GetMaximumArrowSizeMinValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetMinimumArrowSize_27(HandleRef pThis);

	/// <summary>
	/// Limit the minimum and maximum size of the arrows. These values are
	/// expressed in pixels and clamp the minimum/maximum possible size for the
	/// width/length of the arrow head. (When clamped, the ratio between length
	/// and width is preserved.)
	/// </summary>
	public virtual double GetMinimumArrowSize()
	{
		return vtkLeaderActor2D_GetMinimumArrowSize_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetMinimumArrowSizeMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Limit the minimum and maximum size of the arrows. These values are
	/// expressed in pixels and clamp the minimum/maximum possible size for the
	/// width/length of the arrow head. (When clamped, the ratio between length
	/// and width is preserved.)
	/// </summary>
	public virtual double GetMinimumArrowSizeMaxValue()
	{
		return vtkLeaderActor2D_GetMinimumArrowSizeMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetMinimumArrowSizeMinValue_29(HandleRef pThis);

	/// <summary>
	/// Limit the minimum and maximum size of the arrows. These values are
	/// expressed in pixels and clamp the minimum/maximum possible size for the
	/// width/length of the arrow head. (When clamped, the ratio between length
	/// and width is preserved.)
	/// </summary>
	public virtual double GetMinimumArrowSizeMinValue()
	{
		return vtkLeaderActor2D_GetMinimumArrowSizeMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLeaderActor2D_GetNumberOfGenerationsFromBase_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLeaderActor2D_GetNumberOfGenerationsFromBase_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLeaderActor2D_GetNumberOfGenerationsFromBaseType_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLeaderActor2D_GetNumberOfGenerationsFromBaseType_31(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLeaderActor2D_GetRadius_32(HandleRef pThis);

	/// <summary>
	/// Set/Get a radius which can be used to curve the leader.  If a radius is
	/// specified whose absolute value is greater than one half the distance
	/// between the two points defined by the superclasses' Position and
	/// Position2 ivars, then the leader will be curved. A positive radius will
	/// produce a curve such that the center is to the right of the line from
	/// Position and Position2; a negative radius will produce a curve in the
	/// opposite sense. By default, the radius is set to zero and thus there
	/// is no curvature. Note that the radius is expresses as a multiple of
	/// the distance between (Position,Position2); this avoids issues relative
	/// to coordinate system transformations.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkLeaderActor2D_GetRadius_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_GetUseFontSizeFromProperty_33(HandleRef pThis);

	/// <summary>
	/// By default the LeaderActor2D controls the font size of the label. If this
	/// option is set to true, it will instead use whatever font size is set in the
	/// vtkTextProperty, allowing external control of the font size.
	/// </summary>
	public virtual int GetUseFontSizeFromProperty()
	{
		return vtkLeaderActor2D_GetUseFontSizeFromProperty_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_HasTranslucentPolygonalGeometry_34(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkLeaderActor2D_HasTranslucentPolygonalGeometry_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_IsA_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLeaderActor2D_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_IsTypeOf_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLeaderActor2D_IsTypeOf_36(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLeaderActor2D_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLeaderActor2D NewInstance()
	{
		vtkLeaderActor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLeaderActor2D_NewInstance_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_ReleaseGraphicsResources_39(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkLeaderActor2D_ReleaseGraphicsResources_39(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_RenderOpaqueGeometry_40(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp and vtkActor2D superclasses.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkLeaderActor2D_RenderOpaqueGeometry_40(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_RenderOverlay_41(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp and vtkActor2D superclasses.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkLeaderActor2D_RenderOverlay_41(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLeaderActor2D_RenderTranslucentPolygonalGeometry_42(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods required by vtkProp and vtkActor2D superclasses.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkLeaderActor2D_RenderTranslucentPolygonalGeometry_42(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLeaderActor2D_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLeaderActor2D SafeDownCast(vtkObjectBase o)
	{
		vtkLeaderActor2D vtkLeaderActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLeaderActor2D_SafeDownCast_43(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLeaderActor2D2 = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLeaderActor2D2.Register(null);
			}
		}
		return vtkLeaderActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetArrowLength_44(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the arrow length and base width (in normalized viewport
	/// coordinates).
	/// </summary>
	public virtual void SetArrowLength(double _arg)
	{
		vtkLeaderActor2D_SetArrowLength_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetArrowPlacement_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether arrow heads are drawn on the leader. Arrows may be
	/// drawn on one end, both ends, or not at all.
	/// </summary>
	public virtual void SetArrowPlacement(int _arg)
	{
		vtkLeaderActor2D_SetArrowPlacement_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetArrowPlacementToBoth_46(HandleRef pThis);

	/// <summary>
	/// Control whether arrow heads are drawn on the leader. Arrows may be
	/// drawn on one end, both ends, or not at all.
	/// </summary>
	public void SetArrowPlacementToBoth()
	{
		vtkLeaderActor2D_SetArrowPlacementToBoth_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetArrowPlacementToNone_47(HandleRef pThis);

	/// <summary>
	/// Control whether arrow heads are drawn on the leader. Arrows may be
	/// drawn on one end, both ends, or not at all.
	/// </summary>
	public void SetArrowPlacementToNone()
	{
		vtkLeaderActor2D_SetArrowPlacementToNone_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetArrowPlacementToPoint1_48(HandleRef pThis);

	/// <summary>
	/// Control whether arrow heads are drawn on the leader. Arrows may be
	/// drawn on one end, both ends, or not at all.
	/// </summary>
	public void SetArrowPlacementToPoint1()
	{
		vtkLeaderActor2D_SetArrowPlacementToPoint1_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetArrowPlacementToPoint2_49(HandleRef pThis);

	/// <summary>
	/// Control whether arrow heads are drawn on the leader. Arrows may be
	/// drawn on one end, both ends, or not at all.
	/// </summary>
	public void SetArrowPlacementToPoint2()
	{
		vtkLeaderActor2D_SetArrowPlacementToPoint2_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetArrowStyle_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the appearance of the arrow heads. A solid arrow head is a filled
	/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
	/// non-filled triangle.
	/// </summary>
	public virtual void SetArrowStyle(int _arg)
	{
		vtkLeaderActor2D_SetArrowStyle_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetArrowStyleToFilled_51(HandleRef pThis);

	/// <summary>
	/// Control the appearance of the arrow heads. A solid arrow head is a filled
	/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
	/// non-filled triangle.
	/// </summary>
	public void SetArrowStyleToFilled()
	{
		vtkLeaderActor2D_SetArrowStyleToFilled_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetArrowStyleToHollow_52(HandleRef pThis);

	/// <summary>
	/// Control the appearance of the arrow heads. A solid arrow head is a filled
	/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
	/// non-filled triangle.
	/// </summary>
	public void SetArrowStyleToHollow()
	{
		vtkLeaderActor2D_SetArrowStyleToHollow_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetArrowStyleToOpen_53(HandleRef pThis);

	/// <summary>
	/// Control the appearance of the arrow heads. A solid arrow head is a filled
	/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
	/// non-filled triangle.
	/// </summary>
	public void SetArrowStyleToOpen()
	{
		vtkLeaderActor2D_SetArrowStyleToOpen_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetArrowWidth_54(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the arrow length and base width (in normalized viewport
	/// coordinates).
	/// </summary>
	public virtual void SetArrowWidth(double _arg)
	{
		vtkLeaderActor2D_SetArrowWidth_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetAutoLabel_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable auto-labelling. In this mode, the label is automatically updated
	/// based on distance (in world coordinates) between the two end points; or
	/// if a curved leader is being generated, the angle in degrees between the
	/// two points.
	/// </summary>
	public virtual void SetAutoLabel(int _arg)
	{
		vtkLeaderActor2D_SetAutoLabel_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetLabel_56(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the label for the leader. If the label is an empty string, then
	/// it will not be drawn.
	/// </summary>
	public virtual void SetLabel(string _arg)
	{
		vtkLeaderActor2D_SetLabel_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetLabelFactor_57(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label the leader.
	/// </summary>
	public virtual void SetLabelFactor(double _arg)
	{
		vtkLeaderActor2D_SetLabelFactor_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetLabelFormat_58(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the format to use for auto-labelling.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkLeaderActor2D_SetLabelFormat_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetLabelTextProperty_59(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the text property of the label.
	/// </summary>
	public virtual void SetLabelTextProperty(vtkTextProperty p)
	{
		vtkLeaderActor2D_SetLabelTextProperty_59(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetMaximumArrowSize_60(HandleRef pThis, double _arg);

	/// <summary>
	/// Limit the minimum and maximum size of the arrows. These values are
	/// expressed in pixels and clamp the minimum/maximum possible size for the
	/// width/length of the arrow head. (When clamped, the ratio between length
	/// and width is preserved.)
	/// </summary>
	public virtual void SetMaximumArrowSize(double _arg)
	{
		vtkLeaderActor2D_SetMaximumArrowSize_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetMinimumArrowSize_61(HandleRef pThis, double _arg);

	/// <summary>
	/// Limit the minimum and maximum size of the arrows. These values are
	/// expressed in pixels and clamp the minimum/maximum possible size for the
	/// width/length of the arrow head. (When clamped, the ratio between length
	/// and width is preserved.)
	/// </summary>
	public virtual void SetMinimumArrowSize(double _arg)
	{
		vtkLeaderActor2D_SetMinimumArrowSize_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetRadius_62(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get a radius which can be used to curve the leader.  If a radius is
	/// specified whose absolute value is greater than one half the distance
	/// between the two points defined by the superclasses' Position and
	/// Position2 ivars, then the leader will be curved. A positive radius will
	/// produce a curve such that the center is to the right of the line from
	/// Position and Position2; a negative radius will produce a curve in the
	/// opposite sense. By default, the radius is set to zero and thus there
	/// is no curvature. Note that the radius is expresses as a multiple of
	/// the distance between (Position,Position2); this avoids issues relative
	/// to coordinate system transformations.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkLeaderActor2D_SetRadius_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_SetUseFontSizeFromProperty_63(HandleRef pThis, int _arg);

	/// <summary>
	/// By default the LeaderActor2D controls the font size of the label. If this
	/// option is set to true, it will instead use whatever font size is set in the
	/// vtkTextProperty, allowing external control of the font size.
	/// </summary>
	public virtual void SetUseFontSizeFromProperty(int _arg)
	{
		vtkLeaderActor2D_SetUseFontSizeFromProperty_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_ShallowCopy_64(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkLeaderActor2D_ShallowCopy_64(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_UseFontSizeFromPropertyOff_65(HandleRef pThis);

	/// <summary>
	/// By default the LeaderActor2D controls the font size of the label. If this
	/// option is set to true, it will instead use whatever font size is set in the
	/// vtkTextProperty, allowing external control of the font size.
	/// </summary>
	public virtual void UseFontSizeFromPropertyOff()
	{
		vtkLeaderActor2D_UseFontSizeFromPropertyOff_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLeaderActor2D_UseFontSizeFromPropertyOn_66(HandleRef pThis);

	/// <summary>
	/// By default the LeaderActor2D controls the font size of the label. If this
	/// option is set to true, it will instead use whatever font size is set in the
	/// vtkTextProperty, allowing external control of the font size.
	/// </summary>
	public virtual void UseFontSizeFromPropertyOn()
	{
		vtkLeaderActor2D_UseFontSizeFromPropertyOn_66(GetCppThis());
	}
}
