using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBorderRepresentation
/// </summary>
/// <remarks>
///    represent a vtkBorderWidget
///
/// This class is used to represent and render a vtBorderWidget. To
/// use this class, you need to specify the two corners of a rectangular
/// region.
///
/// The class is typically subclassed so that specialized representations can
/// be created.  The class defines an API and a default implementation that
/// the vtkBorderRepresentation interacts with to render itself in the scene.
///
/// @warning
/// The separation of the widget event handling (e.g., vtkBorderWidget) from
/// the representation (vtkBorderRepresentation) enables users and developers
/// to create new appearances for the widget. It also facilitates parallel
/// processing, where the client application handles events, and remote
/// representations of the widget are slaves to the client (and do not handle
/// events).
///
/// </remarks>
/// <seealso>
///
/// vtkBorderWidget vtkTextWidget
/// </seealso>
public class vtkBorderRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Specify opposite corners of the box defining the boundary of the
	/// widget. By default, these coordinates are in the normalized viewport
	/// coordinate system, with Position the lower left of the outline, and
	/// Position2 relative to Position. Note that using these methods are
	/// affected by the ProportionalResize flag. That is, if the aspect ratio of
	/// the representation is to be preserved (e.g., ProportionalResize is on),
	/// then the rectangle (Position,Position2) is a bounding rectangle.
	/// </summary>
	public enum BORDER_ACTIVE_WrapperEnum
	{
		/// <summary>enum member</summary>
		BORDER_ACTIVE = 2,
		/// <summary>enum member</summary>
		BORDER_OFF = 0,
		/// <summary>enum member</summary>
		BORDER_ON = 1
	}

	/// <summary>
	/// This is a modifier of the interaction state. When set, widget interaction
	/// allows the border (and stuff inside of it) to be translated with mouse
	/// motion.
	/// </summary>
	public enum AnyLocation_WrapperEnum
	{
		/// <summary>enum member</summary>
		AnyLocation = 0,
		/// <summary>enum member</summary>
		LowerCenter = 3,
		/// <summary>enum member</summary>
		LowerLeftCorner = 1,
		/// <summary>enum member</summary>
		LowerRightCorner = 2,
		/// <summary>enum member</summary>
		UpperCenter = 6,
		/// <summary>enum member</summary>
		UpperLeftCorner = 4,
		/// <summary>enum member</summary>
		UpperRightCorner = 5
	}

	/// <summary>
	/// Define the various states that the representation can be in.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		AdjustingE0 = 6,
		/// <summary>enum member</summary>
		AdjustingE1 = 7,
		/// <summary>enum member</summary>
		AdjustingE2 = 8,
		/// <summary>enum member</summary>
		AdjustingE3 = 9,
		/// <summary>enum member</summary>
		AdjustingP0 = 2,
		/// <summary>enum member</summary>
		AdjustingP1 = 3,
		/// <summary>enum member</summary>
		AdjustingP2 = 4,
		/// <summary>enum member</summary>
		AdjustingP3 = 5,
		/// <summary>enum member</summary>
		Inside = 1,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBorderRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBorderRepresentation()
	{
		MRClassNameKey = "class vtkBorderRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBorderRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBorderRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkBorderRepresentation New()
	{
		vtkBorderRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBorderRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkBorderRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBorderRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Subclasses should implement these methods. See the superclasses'
	/// documentation for more information.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkBorderRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Subclasses should implement these methods. See the superclasses'
	/// documentation for more information.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkBorderRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_EnforceNormalizedViewportBoundsOff_03(HandleRef pThis);

	/// <summary>
	/// Whether to enforce the minimum normalized viewport size and limit
	/// the normalized viewport coordinates to [0.0 -&gt; 1.0]. This keeps
	/// widgets from being moved offscreen or being scaled down past their
	/// minimum viewport size.
	///
	/// Off by Default.
	///
	/// Note: ProportionalResize must be off for this function to take effect.
	/// </summary>
	public virtual void EnforceNormalizedViewportBoundsOff()
	{
		vtkBorderRepresentation_EnforceNormalizedViewportBoundsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_EnforceNormalizedViewportBoundsOn_04(HandleRef pThis);

	/// <summary>
	/// Whether to enforce the minimum normalized viewport size and limit
	/// the normalized viewport coordinates to [0.0 -&gt; 1.0]. This keeps
	/// widgets from being moved offscreen or being scaled down past their
	/// minimum viewport size.
	///
	/// Off by Default.
	///
	/// Note: ProportionalResize must be off for this function to take effect.
	/// </summary>
	public virtual void EnforceNormalizedViewportBoundsOn()
	{
		vtkBorderRepresentation_EnforceNormalizedViewportBoundsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetActors2D_05(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void GetActors2D(vtkPropCollection arg0)
	{
		vtkBorderRepresentation_GetActors2D_05(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_GetBorderColor_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the RGB color of the border.
	/// Default is white (1.0, 1.0, 1.0).
	/// </summary>
	public virtual double[] GetBorderColor()
	{
		IntPtr intPtr = vtkBorderRepresentation_GetBorderColor_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetBorderColor_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the RGB color of the border.
	/// Default is white (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void GetBorderColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkBorderRepresentation_GetBorderColor_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetBorderColor_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the RGB color of the border.
	/// Default is white (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void GetBorderColor(IntPtr _arg)
	{
		vtkBorderRepresentation_GetBorderColor_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_GetBorderProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the properties of the border.
	/// </summary>
	public virtual vtkProperty2D GetBorderProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBorderRepresentation_GetBorderProperty_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkBorderRepresentation_GetBorderThickness_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the thickness of the border in screen units.
	/// Default is 1.0.
	/// </summary>
	public virtual float GetBorderThickness()
	{
		return vtkBorderRepresentation_GetBorderThickness_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkBorderRepresentation_GetBorderThicknessMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the thickness of the border in screen units.
	/// Default is 1.0.
	/// </summary>
	public virtual float GetBorderThicknessMaxValue()
	{
		return vtkBorderRepresentation_GetBorderThicknessMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkBorderRepresentation_GetBorderThicknessMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the thickness of the border in screen units.
	/// Default is 1.0.
	/// </summary>
	public virtual float GetBorderThicknessMinValue()
	{
		return vtkBorderRepresentation_GetBorderThicknessMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBorderRepresentation_GetCornerRadiusStrength_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio between no radius and maximum radius.
	/// In order to compute round corners, we create 2 points
	/// in each side of the corner. The maximum radius is then
	/// the minimum length of the two sides of each corners.
	/// This maximum radius is scaled by the CornerRadiusStrength.
	/// Default is 0.0 (no radius).
	/// </summary>
	public virtual double GetCornerRadiusStrength()
	{
		return vtkBorderRepresentation_GetCornerRadiusStrength_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBorderRepresentation_GetCornerRadiusStrengthMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio between no radius and maximum radius.
	/// In order to compute round corners, we create 2 points
	/// in each side of the corner. The maximum radius is then
	/// the minimum length of the two sides of each corners.
	/// This maximum radius is scaled by the CornerRadiusStrength.
	/// Default is 0.0 (no radius).
	/// </summary>
	public virtual double GetCornerRadiusStrengthMaxValue()
	{
		return vtkBorderRepresentation_GetCornerRadiusStrengthMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBorderRepresentation_GetCornerRadiusStrengthMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio between no radius and maximum radius.
	/// In order to compute round corners, we create 2 points
	/// in each side of the corner. The maximum radius is then
	/// the minimum length of the two sides of each corners.
	/// This maximum radius is scaled by the CornerRadiusStrength.
	/// Default is 0.0 (no radius).
	/// </summary>
	public virtual double GetCornerRadiusStrengthMinValue()
	{
		return vtkBorderRepresentation_GetCornerRadiusStrengthMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetCornerResolution_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of points that define each round corners.
	/// A high value increase the resolution of the corners.
	/// Default is 20.
	/// </summary>
	public virtual int GetCornerResolution()
	{
		return vtkBorderRepresentation_GetCornerResolution_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetCornerResolutionMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of points that define each round corners.
	/// A high value increase the resolution of the corners.
	/// Default is 20.
	/// </summary>
	public virtual int GetCornerResolutionMaxValue()
	{
		return vtkBorderRepresentation_GetCornerResolutionMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetCornerResolutionMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of points that define each round corners.
	/// A high value increase the resolution of the corners.
	/// Default is 20.
	/// </summary>
	public virtual int GetCornerResolutionMinValue()
	{
		return vtkBorderRepresentation_GetCornerResolutionMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetEnforceNormalizedViewportBounds_19(HandleRef pThis);

	/// <summary>
	/// Whether to enforce the minimum normalized viewport size and limit
	/// the normalized viewport coordinates to [0.0 -&gt; 1.0]. This keeps
	/// widgets from being moved offscreen or being scaled down past their
	/// minimum viewport size.
	///
	/// Off by Default.
	///
	/// Note: ProportionalResize must be off for this function to take effect.
	/// </summary>
	public virtual int GetEnforceNormalizedViewportBounds()
	{
		return vtkBorderRepresentation_GetEnforceNormalizedViewportBounds_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetInteractionStateMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Define the various states that the representation can be in.
	/// </summary>
	public virtual int GetInteractionStateMaxValue()
	{
		return vtkBorderRepresentation_GetInteractionStateMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetInteractionStateMinValue_21(HandleRef pThis);

	/// <summary>
	/// Define the various states that the representation can be in.
	/// </summary>
	public virtual int GetInteractionStateMinValue()
	{
		return vtkBorderRepresentation_GetInteractionStateMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkBorderRepresentation_GetMTime_22(HandleRef pThis);

	/// <summary>
	/// Return the MTime of this object. It takes into account MTimes
	/// of position coordinates and border's property.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkBorderRepresentation_GetMTime_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_GetMaximumSize_23(HandleRef pThis);

	/// <summary>
	/// Specify a minimum and/or maximum size (in pixels) that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 1, 1 }.
	/// </summary>
	public virtual int[] GetMaximumSize()
	{
		IntPtr intPtr = vtkBorderRepresentation_GetMaximumSize_23(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetMaximumSize_24(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Specify a minimum and/or maximum size (in pixels) that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 1, 1 }.
	/// </summary>
	public virtual void GetMaximumSize(ref int _arg1, ref int _arg2)
	{
		vtkBorderRepresentation_GetMaximumSize_24(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetMaximumSize_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a minimum and/or maximum size (in pixels) that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 1, 1 }.
	/// </summary>
	public virtual void GetMaximumSize(IntPtr _arg)
	{
		vtkBorderRepresentation_GetMaximumSize_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_GetMinimumNormalizedViewportSize_26(HandleRef pThis);

	/// <summary>
	/// Specify a minimum and/or maximum size [0.0 -&gt; 1.0] that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 0.0, 0.0 }.
	/// </summary>
	public virtual double[] GetMinimumNormalizedViewportSize()
	{
		IntPtr intPtr = vtkBorderRepresentation_GetMinimumNormalizedViewportSize_26(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetMinimumNormalizedViewportSize_27(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Specify a minimum and/or maximum size [0.0 -&gt; 1.0] that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 0.0, 0.0 }.
	/// </summary>
	public virtual void GetMinimumNormalizedViewportSize(ref double _arg1, ref double _arg2)
	{
		vtkBorderRepresentation_GetMinimumNormalizedViewportSize_27(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetMinimumNormalizedViewportSize_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a minimum and/or maximum size [0.0 -&gt; 1.0] that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 0.0, 0.0 }.
	/// </summary>
	public virtual void GetMinimumNormalizedViewportSize(IntPtr _arg)
	{
		vtkBorderRepresentation_GetMinimumNormalizedViewportSize_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_GetMinimumSize_29(HandleRef pThis);

	/// <summary>
	/// Specify a minimum and/or maximum size (in pixels) that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 1, 1 }.
	/// </summary>
	public virtual int[] GetMinimumSize()
	{
		IntPtr intPtr = vtkBorderRepresentation_GetMinimumSize_29(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetMinimumSize_30(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Specify a minimum and/or maximum size (in pixels) that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 1, 1 }.
	/// </summary>
	public virtual void GetMinimumSize(ref int _arg1, ref int _arg2)
	{
		vtkBorderRepresentation_GetMinimumSize_30(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetMinimumSize_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a minimum and/or maximum size (in pixels) that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 1, 1 }.
	/// </summary>
	public virtual void GetMinimumSize(IntPtr _arg)
	{
		vtkBorderRepresentation_GetMinimumSize_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetMoving_32(HandleRef pThis);

	/// <summary>
	/// This is a modifier of the interaction state. When set, widget interaction
	/// allows the border (and stuff inside of it) to be translated with mouse
	/// motion.
	/// </summary>
	public virtual int GetMoving()
	{
		return vtkBorderRepresentation_GetMoving_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBorderRepresentation_GetNumberOfGenerationsFromBase_33(HandleRef pThis, string type);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBorderRepresentation_GetNumberOfGenerationsFromBase_33(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBorderRepresentation_GetNumberOfGenerationsFromBaseType_34(string type);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBorderRepresentation_GetNumberOfGenerationsFromBaseType_34(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_GetPolygonColor_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the RGB color of the background polygon.
	/// Default is white (1.0, 1.0, 1.0).
	/// </summary>
	public virtual double[] GetPolygonColor()
	{
		IntPtr intPtr = vtkBorderRepresentation_GetPolygonColor_35(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetPolygonColor_36(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the RGB color of the background polygon.
	/// Default is white (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void GetPolygonColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkBorderRepresentation_GetPolygonColor_36(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetPolygonColor_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the RGB color of the background polygon.
	/// Default is white (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void GetPolygonColor(IntPtr _arg)
	{
		vtkBorderRepresentation_GetPolygonColor_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBorderRepresentation_GetPolygonOpacity_38(HandleRef pThis);

	/// <summary>
	/// Set/Get the opacity of the background color.
	/// Default is 0.0.
	/// </summary>
	public virtual double GetPolygonOpacity()
	{
		return vtkBorderRepresentation_GetPolygonOpacity_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBorderRepresentation_GetPolygonOpacityMaxValue_39(HandleRef pThis);

	/// <summary>
	/// Set/Get the opacity of the background color.
	/// Default is 0.0.
	/// </summary>
	public virtual double GetPolygonOpacityMaxValue()
	{
		return vtkBorderRepresentation_GetPolygonOpacityMaxValue_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBorderRepresentation_GetPolygonOpacityMinValue_40(HandleRef pThis);

	/// <summary>
	/// Set/Get the opacity of the background color.
	/// Default is 0.0.
	/// </summary>
	public virtual double GetPolygonOpacityMinValue()
	{
		return vtkBorderRepresentation_GetPolygonOpacityMinValue_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetPolygonRGBA_41(HandleRef pThis, IntPtr rgba);

	/// <summary>
	/// Convenience method to get the background color and the opacity at once
	/// </summary>
	public void GetPolygonRGBA(IntPtr rgba)
	{
		vtkBorderRepresentation_GetPolygonRGBA_41(GetCppThis(), rgba);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetPolygonRGBA_42(HandleRef pThis, ref double r, ref double g, ref double b, ref double a);

	/// <summary>
	/// Convenience method to get the background color and the opacity at once
	/// </summary>
	public void GetPolygonRGBA(ref double r, ref double g, ref double b, ref double a)
	{
		vtkBorderRepresentation_GetPolygonRGBA_42(GetCppThis(), ref r, ref g, ref b, ref a);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_GetPosition_43(HandleRef pThis);

	/// <summary>
	/// Specify opposite corners of the box defining the boundary of the
	/// widget. By default, these coordinates are in the normalized viewport
	/// coordinate system, with Position the lower left of the outline, and
	/// Position2 relative to Position. Note that using these methods are
	/// affected by the ProportionalResize flag. That is, if the aspect ratio of
	/// the representation is to be preserved (e.g., ProportionalResize is on),
	/// then the rectangle (Position,Position2) is a bounding rectangle.
	/// </summary>
	public virtual double[] GetPosition()
	{
		IntPtr intPtr = vtkBorderRepresentation_GetPosition_43(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_GetPosition2_44(HandleRef pThis);

	/// <summary>
	/// Specify opposite corners of the box defining the boundary of the
	/// widget. By default, these coordinates are in the normalized viewport
	/// coordinate system, with Position the lower left of the outline, and
	/// Position2 relative to Position. Note that using these methods are
	/// affected by the ProportionalResize flag. That is, if the aspect ratio of
	/// the representation is to be preserved (e.g., ProportionalResize is on),
	/// then the rectangle (Position,Position2) is a bounding rectangle.
	/// </summary>
	public virtual double[] GetPosition2()
	{
		IntPtr intPtr = vtkBorderRepresentation_GetPosition2_44(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_GetPosition2Coordinate_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify opposite corners of the box defining the boundary of the
	/// widget. By default, these coordinates are in the normalized viewport
	/// coordinate system, with Position the lower left of the outline, and
	/// Position2 relative to Position. Note that using these methods are
	/// affected by the ProportionalResize flag. That is, if the aspect ratio of
	/// the representation is to be preserved (e.g., ProportionalResize is on),
	/// then the rectangle (Position,Position2) is a bounding rectangle.
	/// </summary>
	public virtual vtkCoordinate GetPosition2Coordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBorderRepresentation_GetPosition2Coordinate_45(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_GetPositionCoordinate_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify opposite corners of the box defining the boundary of the
	/// widget. By default, these coordinates are in the normalized viewport
	/// coordinate system, with Position the lower left of the outline, and
	/// Position2 relative to Position. Note that using these methods are
	/// affected by the ProportionalResize flag. That is, if the aspect ratio of
	/// the representation is to be preserved (e.g., ProportionalResize is on),
	/// then the rectangle (Position,Position2) is a bounding rectangle.
	/// </summary>
	public virtual vtkCoordinate GetPositionCoordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBorderRepresentation_GetPositionCoordinate_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetProportionalResize_47(HandleRef pThis);

	/// <summary>
	/// Indicate whether resizing operations should keep the x-y directions
	/// proportional to one another. Also, if ProportionalResize is on, then
	/// the rectangle (Position,Position2) is a bounding rectangle, and the
	/// representation will be placed in the rectangle in such a way as to
	/// preserve the aspect ratio of the representation.
	///
	/// Off by Default.
	/// </summary>
	public virtual int GetProportionalResize()
	{
		return vtkBorderRepresentation_GetProportionalResize_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_GetSelectionPoint_48(HandleRef pThis);

	/// <summary>
	/// After a selection event within the region interior to the border; the
	/// normalized selection coordinates may be obtained.
	/// </summary>
	public virtual double[] GetSelectionPoint()
	{
		IntPtr intPtr = vtkBorderRepresentation_GetSelectionPoint_48(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetSelectionPoint_49(HandleRef pThis, IntPtr data);

	/// <summary>
	/// After a selection event within the region interior to the border; the
	/// normalized selection coordinates may be obtained.
	/// </summary>
	public virtual void GetSelectionPoint(IntPtr data)
	{
		vtkBorderRepresentation_GetSelectionPoint_49(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowBorder_50(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border should appear. If ShowBorder is "on",
	/// then the border will always appear. If ShowBorder is "off" then the
	/// border will never appear.  If ShowBorder is "active" then the border
	/// will appear when the mouse pointer enters the region bounded by the
	/// border widget.
	/// This method is provided as conveniency to set both horizontal and
	/// vertical borders, and the polygon background.
	/// BORDER_ON by default.
	/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
	/// </summary>
	public virtual int GetShowBorder()
	{
		return vtkBorderRepresentation_GetShowBorder_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowBorderMaxValue_51(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border should appear. If ShowBorder is "on",
	/// then the border will always appear. If ShowBorder is "off" then the
	/// border will never appear.  If ShowBorder is "active" then the border
	/// will appear when the mouse pointer enters the region bounded by the
	/// border widget.
	/// This method is provided as conveniency to set both horizontal and
	/// vertical borders, and the polygon background.
	/// BORDER_ON by default.
	/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
	/// </summary>
	public virtual int GetShowBorderMaxValue()
	{
		return vtkBorderRepresentation_GetShowBorderMaxValue_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowBorderMinValue_52(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border should appear. If ShowBorder is "on",
	/// then the border will always appear. If ShowBorder is "off" then the
	/// border will never appear.  If ShowBorder is "active" then the border
	/// will appear when the mouse pointer enters the region bounded by the
	/// border widget.
	/// This method is provided as conveniency to set both horizontal and
	/// vertical borders, and the polygon background.
	/// BORDER_ON by default.
	/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
	/// </summary>
	public virtual int GetShowBorderMinValue()
	{
		return vtkBorderRepresentation_GetShowBorderMinValue_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowHorizontalBorder_53(HandleRef pThis);

	/// <summary>
	/// Specify when and if the horizontal border should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowVerticalBorder()
	/// </summary>
	public virtual int GetShowHorizontalBorder()
	{
		return vtkBorderRepresentation_GetShowHorizontalBorder_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowHorizontalBorderMaxValue_54(HandleRef pThis);

	/// <summary>
	/// Specify when and if the horizontal border should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowVerticalBorder()
	/// </summary>
	public virtual int GetShowHorizontalBorderMaxValue()
	{
		return vtkBorderRepresentation_GetShowHorizontalBorderMaxValue_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowHorizontalBorderMinValue_55(HandleRef pThis);

	/// <summary>
	/// Specify when and if the horizontal border should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowVerticalBorder()
	/// </summary>
	public virtual int GetShowHorizontalBorderMinValue()
	{
		return vtkBorderRepresentation_GetShowHorizontalBorderMinValue_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowPolygon_56(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border's polygon background should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder()
	/// </summary>
	public virtual int GetShowPolygon()
	{
		return vtkBorderRepresentation_GetShowPolygon_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowPolygonBackground_57(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border polygon background should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowPolygon()
	/// </summary>
	public virtual int GetShowPolygonBackground()
	{
		return vtkBorderRepresentation_GetShowPolygonBackground_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowPolygonBackgroundMaxValue_58(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border polygon background should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowPolygon()
	/// </summary>
	public virtual int GetShowPolygonBackgroundMaxValue()
	{
		return vtkBorderRepresentation_GetShowPolygonBackgroundMaxValue_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowPolygonBackgroundMinValue_59(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border polygon background should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowPolygon()
	/// </summary>
	public virtual int GetShowPolygonBackgroundMinValue()
	{
		return vtkBorderRepresentation_GetShowPolygonBackgroundMinValue_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowVerticalBorder_60(HandleRef pThis);

	/// <summary>
	/// Specify when and if the vertical border should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowHorizontalBorder()
	/// </summary>
	public virtual int GetShowVerticalBorder()
	{
		return vtkBorderRepresentation_GetShowVerticalBorder_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowVerticalBorderMaxValue_61(HandleRef pThis);

	/// <summary>
	/// Specify when and if the vertical border should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowHorizontalBorder()
	/// </summary>
	public virtual int GetShowVerticalBorderMaxValue()
	{
		return vtkBorderRepresentation_GetShowVerticalBorderMaxValue_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetShowVerticalBorderMinValue_62(HandleRef pThis);

	/// <summary>
	/// Specify when and if the vertical border should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowHorizontalBorder()
	/// </summary>
	public virtual int GetShowVerticalBorderMinValue()
	{
		return vtkBorderRepresentation_GetShowVerticalBorderMinValue_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_GetSize_63(HandleRef pThis, IntPtr size);

	/// <summary>
	/// Subclasses should implement these methods. See the superclasses'
	/// documentation for more information.
	/// </summary>
	public virtual void GetSize(IntPtr size)
	{
		vtkBorderRepresentation_GetSize_63(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetTolerance_64(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered to be on the widget, or on a
	/// widget feature (e.g., a corner point or edge).
	///
	/// Default is 3.
	/// </summary>
	public virtual int GetTolerance()
	{
		return vtkBorderRepresentation_GetTolerance_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetToleranceMaxValue_65(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered to be on the widget, or on a
	/// widget feature (e.g., a corner point or edge).
	///
	/// Default is 3.
	/// </summary>
	public virtual int GetToleranceMaxValue()
	{
		return vtkBorderRepresentation_GetToleranceMaxValue_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetToleranceMinValue_66(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered to be on the widget, or on a
	/// widget feature (e.g., a corner point or edge).
	///
	/// Default is 3.
	/// </summary>
	public virtual int GetToleranceMinValue()
	{
		return vtkBorderRepresentation_GetToleranceMinValue_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_GetWindowLocation_67(HandleRef pThis);

	/// <summary>
	/// Set the representation position, by enumeration (
	/// AnyLocation = 0,
	/// LowerLeftCorner,
	/// LowerRightCorner,
	/// LowerCenter,
	/// UpperLeftCorner,
	/// UpperRightCorner,
	/// UpperCenter)
	/// related to the render window
	/// </summary>
	public virtual int GetWindowLocation()
	{
		return vtkBorderRepresentation_GetWindowLocation_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_HasTranslucentPolygonalGeometry_68(HandleRef pThis);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkBorderRepresentation_HasTranslucentPolygonalGeometry_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_IsA_69(HandleRef pThis, string type);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBorderRepresentation_IsA_69(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_IsTypeOf_70(string type);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBorderRepresentation_IsTypeOf_70(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_MovingOff_71(HandleRef pThis);

	/// <summary>
	/// This is a modifier of the interaction state. When set, widget interaction
	/// allows the border (and stuff inside of it) to be translated with mouse
	/// motion.
	/// </summary>
	public virtual void MovingOff()
	{
		vtkBorderRepresentation_MovingOff_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_MovingOn_72(HandleRef pThis);

	/// <summary>
	/// This is a modifier of the interaction state. When set, widget interaction
	/// allows the border (and stuff inside of it) to be translated with mouse
	/// motion.
	/// </summary>
	public virtual void MovingOn()
	{
		vtkBorderRepresentation_MovingOn_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_NewInstance_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public new vtkBorderRepresentation NewInstance()
	{
		vtkBorderRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBorderRepresentation_NewInstance_74(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_ProportionalResizeOff_75(HandleRef pThis);

	/// <summary>
	/// Indicate whether resizing operations should keep the x-y directions
	/// proportional to one another. Also, if ProportionalResize is on, then
	/// the rectangle (Position,Position2) is a bounding rectangle, and the
	/// representation will be placed in the rectangle in such a way as to
	/// preserve the aspect ratio of the representation.
	///
	/// Off by Default.
	/// </summary>
	public virtual void ProportionalResizeOff()
	{
		vtkBorderRepresentation_ProportionalResizeOff_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_ProportionalResizeOn_76(HandleRef pThis);

	/// <summary>
	/// Indicate whether resizing operations should keep the x-y directions
	/// proportional to one another. Also, if ProportionalResize is on, then
	/// the rectangle (Position,Position2) is a bounding rectangle, and the
	/// representation will be placed in the rectangle in such a way as to
	/// preserve the aspect ratio of the representation.
	///
	/// Off by Default.
	/// </summary>
	public virtual void ProportionalResizeOn()
	{
		vtkBorderRepresentation_ProportionalResizeOn_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_ReleaseGraphicsResources_77(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkBorderRepresentation_ReleaseGraphicsResources_77(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_RenderOpaqueGeometry_78(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkBorderRepresentation_RenderOpaqueGeometry_78(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_RenderOverlay_79(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkBorderRepresentation_RenderOverlay_79(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderRepresentation_RenderTranslucentPolygonalGeometry_80(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkBorderRepresentation_RenderTranslucentPolygonalGeometry_80(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderRepresentation_SafeDownCast_81(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public new static vtkBorderRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkBorderRepresentation vtkBorderRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBorderRepresentation_SafeDownCast_81(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBorderRepresentation2 = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBorderRepresentation2.Register(null);
			}
		}
		return vtkBorderRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetBWActorDisplayOverlayEdges_82(HandleRef pThis, byte arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public void SetBWActorDisplayOverlayEdges(bool arg0)
	{
		vtkBorderRepresentation_SetBWActorDisplayOverlayEdges_82(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetBWActorDisplayOverlayPolygon_83(HandleRef pThis, byte arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public void SetBWActorDisplayOverlayPolygon(bool arg0)
	{
		vtkBorderRepresentation_SetBWActorDisplayOverlayPolygon_83(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetBorderColor_84(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the RGB color of the border.
	/// Default is white (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void SetBorderColor(double _arg1, double _arg2, double _arg3)
	{
		vtkBorderRepresentation_SetBorderColor_84(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetBorderColor_85(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the RGB color of the border.
	/// Default is white (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void SetBorderColor(IntPtr _arg)
	{
		vtkBorderRepresentation_SetBorderColor_85(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetBorderThickness_86(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the thickness of the border in screen units.
	/// Default is 1.0.
	/// </summary>
	public virtual void SetBorderThickness(float _arg)
	{
		vtkBorderRepresentation_SetBorderThickness_86(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetCornerRadiusStrength_87(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ratio between no radius and maximum radius.
	/// In order to compute round corners, we create 2 points
	/// in each side of the corner. The maximum radius is then
	/// the minimum length of the two sides of each corners.
	/// This maximum radius is scaled by the CornerRadiusStrength.
	/// Default is 0.0 (no radius).
	/// </summary>
	public virtual void SetCornerRadiusStrength(double _arg)
	{
		vtkBorderRepresentation_SetCornerRadiusStrength_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetCornerResolution_88(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of points that define each round corners.
	/// A high value increase the resolution of the corners.
	/// Default is 20.
	/// </summary>
	public virtual void SetCornerResolution(int _arg)
	{
		vtkBorderRepresentation_SetCornerResolution_88(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetEnforceNormalizedViewportBounds_89(HandleRef pThis, int _arg);

	/// <summary>
	/// Whether to enforce the minimum normalized viewport size and limit
	/// the normalized viewport coordinates to [0.0 -&gt; 1.0]. This keeps
	/// widgets from being moved offscreen or being scaled down past their
	/// minimum viewport size.
	///
	/// Off by Default.
	///
	/// Note: ProportionalResize must be off for this function to take effect.
	/// </summary>
	public virtual void SetEnforceNormalizedViewportBounds(int _arg)
	{
		vtkBorderRepresentation_SetEnforceNormalizedViewportBounds_89(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetInteractionState_90(HandleRef pThis, int _arg);

	/// <summary>
	/// Define the various states that the representation can be in.
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkBorderRepresentation_SetInteractionState_90(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetMaximumSize_91(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify a minimum and/or maximum size (in pixels) that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 1, 1 }.
	/// </summary>
	public virtual void SetMaximumSize(int _arg1, int _arg2)
	{
		vtkBorderRepresentation_SetMaximumSize_91(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetMaximumSize_92(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a minimum and/or maximum size (in pixels) that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 1, 1 }.
	/// </summary>
	public void SetMaximumSize(IntPtr _arg)
	{
		vtkBorderRepresentation_SetMaximumSize_92(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetMinimumNormalizedViewportSize_93(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify a minimum and/or maximum size [0.0 -&gt; 1.0] that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 0.0, 0.0 }.
	/// </summary>
	public virtual void SetMinimumNormalizedViewportSize(double _arg1, double _arg2)
	{
		vtkBorderRepresentation_SetMinimumNormalizedViewportSize_93(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetMinimumNormalizedViewportSize_94(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a minimum and/or maximum size [0.0 -&gt; 1.0] that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 0.0, 0.0 }.
	/// </summary>
	public void SetMinimumNormalizedViewportSize(IntPtr _arg)
	{
		vtkBorderRepresentation_SetMinimumNormalizedViewportSize_94(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetMinimumSize_95(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify a minimum and/or maximum size (in pixels) that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 1, 1 }.
	/// </summary>
	public virtual void SetMinimumSize(int _arg1, int _arg2)
	{
		vtkBorderRepresentation_SetMinimumSize_95(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetMinimumSize_96(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a minimum and/or maximum size (in pixels) that this representation
	/// can take. These methods require two values: size values in the x and y
	/// directions, respectively.
	///
	/// Default is { 1, 1 }.
	/// </summary>
	public void SetMinimumSize(IntPtr _arg)
	{
		vtkBorderRepresentation_SetMinimumSize_96(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetMoving_97(HandleRef pThis, int _arg);

	/// <summary>
	/// This is a modifier of the interaction state. When set, widget interaction
	/// allows the border (and stuff inside of it) to be translated with mouse
	/// motion.
	/// </summary>
	public virtual void SetMoving(int _arg)
	{
		vtkBorderRepresentation_SetMoving_97(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetPolygonColor_98(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the RGB color of the background polygon.
	/// Default is white (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void SetPolygonColor(double _arg1, double _arg2, double _arg3)
	{
		vtkBorderRepresentation_SetPolygonColor_98(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetPolygonColor_99(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the RGB color of the background polygon.
	/// Default is white (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void SetPolygonColor(IntPtr _arg)
	{
		vtkBorderRepresentation_SetPolygonColor_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetPolygonOpacity_100(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the opacity of the background color.
	/// Default is 0.0.
	/// </summary>
	public virtual void SetPolygonOpacity(double _arg)
	{
		vtkBorderRepresentation_SetPolygonOpacity_100(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetPolygonRGBA_101(HandleRef pThis, IntPtr rgba);

	/// <summary>
	/// Convenience method to set the background color and the opacity at once
	/// </summary>
	public void SetPolygonRGBA(IntPtr rgba)
	{
		vtkBorderRepresentation_SetPolygonRGBA_101(GetCppThis(), rgba);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetPolygonRGBA_102(HandleRef pThis, double r, double g, double b, double a);

	/// <summary>
	/// Convenience method to set the background color and the opacity at once
	/// </summary>
	public void SetPolygonRGBA(double r, double g, double b, double a)
	{
		vtkBorderRepresentation_SetPolygonRGBA_102(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetPosition_103(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Specify opposite corners of the box defining the boundary of the
	/// widget. By default, these coordinates are in the normalized viewport
	/// coordinate system, with Position the lower left of the outline, and
	/// Position2 relative to Position. Note that using these methods are
	/// affected by the ProportionalResize flag. That is, if the aspect ratio of
	/// the representation is to be preserved (e.g., ProportionalResize is on),
	/// then the rectangle (Position,Position2) is a bounding rectangle.
	/// </summary>
	public virtual void SetPosition(IntPtr x)
	{
		vtkBorderRepresentation_SetPosition_103(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetPosition_104(HandleRef pThis, double x, double y);

	/// <summary>
	/// Specify opposite corners of the box defining the boundary of the
	/// widget. By default, these coordinates are in the normalized viewport
	/// coordinate system, with Position the lower left of the outline, and
	/// Position2 relative to Position. Note that using these methods are
	/// affected by the ProportionalResize flag. That is, if the aspect ratio of
	/// the representation is to be preserved (e.g., ProportionalResize is on),
	/// then the rectangle (Position,Position2) is a bounding rectangle.
	/// </summary>
	public virtual void SetPosition(double x, double y)
	{
		vtkBorderRepresentation_SetPosition_104(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetPosition2_105(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Specify opposite corners of the box defining the boundary of the
	/// widget. By default, these coordinates are in the normalized viewport
	/// coordinate system, with Position the lower left of the outline, and
	/// Position2 relative to Position. Note that using these methods are
	/// affected by the ProportionalResize flag. That is, if the aspect ratio of
	/// the representation is to be preserved (e.g., ProportionalResize is on),
	/// then the rectangle (Position,Position2) is a bounding rectangle.
	/// </summary>
	public virtual void SetPosition2(IntPtr x)
	{
		vtkBorderRepresentation_SetPosition2_105(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetPosition2_106(HandleRef pThis, double x, double y);

	/// <summary>
	/// Specify opposite corners of the box defining the boundary of the
	/// widget. By default, these coordinates are in the normalized viewport
	/// coordinate system, with Position the lower left of the outline, and
	/// Position2 relative to Position. Note that using these methods are
	/// affected by the ProportionalResize flag. That is, if the aspect ratio of
	/// the representation is to be preserved (e.g., ProportionalResize is on),
	/// then the rectangle (Position,Position2) is a bounding rectangle.
	/// </summary>
	public virtual void SetPosition2(double x, double y)
	{
		vtkBorderRepresentation_SetPosition2_106(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetProportionalResize_107(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether resizing operations should keep the x-y directions
	/// proportional to one another. Also, if ProportionalResize is on, then
	/// the rectangle (Position,Position2) is a bounding rectangle, and the
	/// representation will be placed in the rectangle in such a way as to
	/// preserve the aspect ratio of the representation.
	///
	/// Off by Default.
	/// </summary>
	public virtual void SetProportionalResize(int _arg)
	{
		vtkBorderRepresentation_SetProportionalResize_107(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetShowBorder_108(HandleRef pThis, int border);

	/// <summary>
	/// Specify when and if the border should appear. If ShowBorder is "on",
	/// then the border will always appear. If ShowBorder is "off" then the
	/// border will never appear.  If ShowBorder is "active" then the border
	/// will appear when the mouse pointer enters the region bounded by the
	/// border widget.
	/// This method is provided as conveniency to set both horizontal and
	/// vertical borders, and the polygon background.
	/// BORDER_ON by default.
	/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
	/// </summary>
	public virtual void SetShowBorder(int border)
	{
		vtkBorderRepresentation_SetShowBorder_108(GetCppThis(), border);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetShowBorderToActive_109(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border should appear. If ShowBorder is "on",
	/// then the border will always appear. If ShowBorder is "off" then the
	/// border will never appear.  If ShowBorder is "active" then the border
	/// will appear when the mouse pointer enters the region bounded by the
	/// border widget.
	/// This method is provided as conveniency to set both horizontal and
	/// vertical borders, and the polygon background.
	/// BORDER_ON by default.
	/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
	/// </summary>
	public void SetShowBorderToActive()
	{
		vtkBorderRepresentation_SetShowBorderToActive_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetShowBorderToOff_110(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border should appear. If ShowBorder is "on",
	/// then the border will always appear. If ShowBorder is "off" then the
	/// border will never appear.  If ShowBorder is "active" then the border
	/// will appear when the mouse pointer enters the region bounded by the
	/// border widget.
	/// This method is provided as conveniency to set both horizontal and
	/// vertical borders, and the polygon background.
	/// BORDER_ON by default.
	/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
	/// </summary>
	public void SetShowBorderToOff()
	{
		vtkBorderRepresentation_SetShowBorderToOff_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetShowBorderToOn_111(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border should appear. If ShowBorder is "on",
	/// then the border will always appear. If ShowBorder is "off" then the
	/// border will never appear.  If ShowBorder is "active" then the border
	/// will appear when the mouse pointer enters the region bounded by the
	/// border widget.
	/// This method is provided as conveniency to set both horizontal and
	/// vertical borders, and the polygon background.
	/// BORDER_ON by default.
	/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
	/// </summary>
	public void SetShowBorderToOn()
	{
		vtkBorderRepresentation_SetShowBorderToOn_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetShowHorizontalBorder_112(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify when and if the horizontal border should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowVerticalBorder()
	/// </summary>
	public virtual void SetShowHorizontalBorder(int _arg)
	{
		vtkBorderRepresentation_SetShowHorizontalBorder_112(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetShowPolygon_113(HandleRef pThis, int border);

	/// <summary>
	/// Specify when and if the border's polygon background should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder()
	/// </summary>
	public virtual void SetShowPolygon(int border)
	{
		vtkBorderRepresentation_SetShowPolygon_113(GetCppThis(), border);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetShowPolygonBackground_114(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify when and if the border polygon background should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowPolygon()
	/// </summary>
	public virtual void SetShowPolygonBackground(int _arg)
	{
		vtkBorderRepresentation_SetShowPolygonBackground_114(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetShowPolygonToActive_115(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border's polygon background should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder()
	/// </summary>
	public void SetShowPolygonToActive()
	{
		vtkBorderRepresentation_SetShowPolygonToActive_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetShowPolygonToOff_116(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border's polygon background should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder()
	/// </summary>
	public void SetShowPolygonToOff()
	{
		vtkBorderRepresentation_SetShowPolygonToOff_116(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetShowPolygonToOn_117(HandleRef pThis);

	/// <summary>
	/// Specify when and if the border's polygon background should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder()
	/// </summary>
	public void SetShowPolygonToOn()
	{
		vtkBorderRepresentation_SetShowPolygonToOn_117(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetShowVerticalBorder_118(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify when and if the vertical border should appear.
	/// BORDER_ON by default.
	/// See Also: SetShowBorder(), SetShowHorizontalBorder()
	/// </summary>
	public virtual void SetShowVerticalBorder(int _arg)
	{
		vtkBorderRepresentation_SetShowVerticalBorder_118(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetTolerance_119(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered to be on the widget, or on a
	/// widget feature (e.g., a corner point or edge).
	///
	/// Default is 3.
	/// </summary>
	public virtual void SetTolerance(int _arg)
	{
		vtkBorderRepresentation_SetTolerance_119(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_SetWindowLocation_120(HandleRef pThis, int enumLocation);

	/// <summary>
	/// Set the representation position, by enumeration (
	/// AnyLocation = 0,
	/// LowerLeftCorner,
	/// LowerRightCorner,
	/// LowerCenter,
	/// UpperLeftCorner,
	/// UpperRightCorner,
	/// UpperCenter)
	/// related to the render window
	/// </summary>
	public virtual void SetWindowLocation(int enumLocation)
	{
		vtkBorderRepresentation_SetWindowLocation_120(GetCppThis(), enumLocation);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_StartWidgetInteraction_121(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Subclasses should implement these methods. See the superclasses'
	/// documentation for more information.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkBorderRepresentation_StartWidgetInteraction_121(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderRepresentation_WidgetInteraction_122(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Subclasses should implement these methods. See the superclasses'
	/// documentation for more information.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkBorderRepresentation_WidgetInteraction_122(GetCppThis(), eventPos);
	}
}
