using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointCloudRepresentation
/// </summary>
/// <remarks>
///    represent the vtkPointCloudWidget
///
/// This class provides support for interactively querying and selecting
/// points from a point cloud. It is a representation for the
/// vtkPointCloudWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkPointCloudWidget vtkHardwareSelection vtkPointPicker
/// </seealso>
public class vtkPointCloudRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Flag controls whether highlighting of points occurs as the mouse
	/// moves over them. This can cause extra rendering operations.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		Over = 2,
		/// <summary>enum member</summary>
		OverOutline = 1,
		/// <summary>enum member</summary>
		Selecting = 3
	}

	/// <summary>
	/// Because point clouds can be very large, alternative point picking
	/// approaches can be used to select points: either hardware picking (via
	/// rendering) or software rendering (via CPU ray cast). In summary,
	/// hardware picking (via vtkHardwareSelector) is preferred, with an
	/// optional software picker (via vtkPointPicker) available. Each approach
	/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
	/// is faster but only selects opaque geometry and what is visible on the
	/// screen, does not work with anti-aliasing, cannot handle assemblies, and
	/// may not work on some systems. vtkPointPicker avoids extra renders, and
	/// can handle translucent geometry, can select points "behind" other
	/// objects, will work on all systems, but is scalable to only a few tens of
	/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
	/// further information.) The choice of picker also has implications on the
	/// type of tolerancing used (as described in the following documentation).
	/// (Note also that the pickers may return slightly different results, this
	/// is expected due to the different way tolerancing works.)
	/// </summary>
	public enum PickingModeType
	{
		/// <summary>enum member</summary>
		HARDWARE_PICKING,
		/// <summary>enum member</summary>
		SOFTWARE_PICKING
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointCloudRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointCloudRepresentation()
	{
		MRClassNameKey = "class vtkPointCloudRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointCloudRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointCloudRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointCloudRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkPointCloudRepresentation New()
	{
		vtkPointCloudRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointCloudRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointCloudRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkPointCloudRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointCloudRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointCloudRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Some methods required to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkPointCloudRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Some methods required to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkPointCloudRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_GetActors_03(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp (i.e., support rendering).
	/// </summary>
	public override void GetActors(vtkPropCollection pc)
	{
		vtkPointCloudRepresentation_GetActors_03(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_GetActors2D_04(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp (i.e., support rendering).
	/// </summary>
	public override void GetActors2D(vtkPropCollection pc)
	{
		vtkPointCloudRepresentation_GetActors2D_04(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointCloudRepresentation_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// Some methods required to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkPointCloudRepresentation_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPointCloudRepresentation_GetHardwarePickingTolerance_06(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to a point expressed in pixels.
	/// A tolerance of 0 selects from the pixel precisely under the cursor. A
	/// tolerance of 1 results in a 3x3 pixel square under the cursor (padded
	/// out by 1 in each direction); a tolerance of N results in a (2N+1)**2
	/// selection rectangle. The point in the selection rectangle which is
	/// closest in z-buffer to the pick position is selected. Note that this can
	/// sometimes return points further away from the cursor (which can be
	/// unexpected - use the tolerance carefully).
	/// </summary>
	public virtual uint GetHardwarePickingTolerance()
	{
		return vtkPointCloudRepresentation_GetHardwarePickingTolerance_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointCloudRepresentation_GetHighlighting_07(HandleRef pThis);

	/// <summary>
	/// Flag controls whether highlighting of points occurs as the mouse
	/// moves over them. This can cause extra rendering operations.
	/// </summary>
	public virtual bool GetHighlighting()
	{
		return (vtkPointCloudRepresentation_GetHighlighting_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_GetInteractionStateMaxValue_08(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., PointCloudWidget)
	/// or other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking process
	/// with the widget: First ComputeInteractionState() is invoked that returns
	/// a state based on geometric considerations (i.e., cursor near a widget
	/// feature), then based on events, the widget may modify this further.
	/// </summary>
	public virtual int GetInteractionStateMaxValue()
	{
		return vtkPointCloudRepresentation_GetInteractionStateMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_GetInteractionStateMinValue_09(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., PointCloudWidget)
	/// or other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking process
	/// with the widget: First ComputeInteractionState() is invoked that returns
	/// a state based on geometric considerations (i.e., cursor near a widget
	/// feature), then based on events, the widget may modify this further.
	/// </summary>
	public virtual int GetInteractionStateMinValue()
	{
		return vtkPointCloudRepresentation_GetInteractionStateMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointCloudRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods for obtaining type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointCloudRepresentation_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointCloudRepresentation_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard VTK class methods for obtaining type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointCloudRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_GetPickingMode_12(HandleRef pThis);

	/// <summary>
	/// Because point clouds can be very large, alternative point picking
	/// approaches can be used to select points: either hardware picking (via
	/// rendering) or software rendering (via CPU ray cast). In summary,
	/// hardware picking (via vtkHardwareSelector) is preferred, with an
	/// optional software picker (via vtkPointPicker) available. Each approach
	/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
	/// is faster but only selects opaque geometry and what is visible on the
	/// screen, does not work with anti-aliasing, cannot handle assemblies, and
	/// may not work on some systems. vtkPointPicker avoids extra renders, and
	/// can handle translucent geometry, can select points "behind" other
	/// objects, will work on all systems, but is scalable to only a few tens of
	/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
	/// further information.) The choice of picker also has implications on the
	/// type of tolerancing used (as described in the following documentation).
	/// (Note also that the pickers may return slightly different results, this
	/// is expected due to the different way tolerancing works.)
	/// </summary>
	public virtual int GetPickingMode()
	{
		return vtkPointCloudRepresentation_GetPickingMode_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_GetPickingModeMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Because point clouds can be very large, alternative point picking
	/// approaches can be used to select points: either hardware picking (via
	/// rendering) or software rendering (via CPU ray cast). In summary,
	/// hardware picking (via vtkHardwareSelector) is preferred, with an
	/// optional software picker (via vtkPointPicker) available. Each approach
	/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
	/// is faster but only selects opaque geometry and what is visible on the
	/// screen, does not work with anti-aliasing, cannot handle assemblies, and
	/// may not work on some systems. vtkPointPicker avoids extra renders, and
	/// can handle translucent geometry, can select points "behind" other
	/// objects, will work on all systems, but is scalable to only a few tens of
	/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
	/// further information.) The choice of picker also has implications on the
	/// type of tolerancing used (as described in the following documentation).
	/// (Note also that the pickers may return slightly different results, this
	/// is expected due to the different way tolerancing works.)
	/// </summary>
	public virtual int GetPickingModeMaxValue()
	{
		return vtkPointCloudRepresentation_GetPickingModeMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_GetPickingModeMinValue_14(HandleRef pThis);

	/// <summary>
	/// Because point clouds can be very large, alternative point picking
	/// approaches can be used to select points: either hardware picking (via
	/// rendering) or software rendering (via CPU ray cast). In summary,
	/// hardware picking (via vtkHardwareSelector) is preferred, with an
	/// optional software picker (via vtkPointPicker) available. Each approach
	/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
	/// is faster but only selects opaque geometry and what is visible on the
	/// screen, does not work with anti-aliasing, cannot handle assemblies, and
	/// may not work on some systems. vtkPointPicker avoids extra renders, and
	/// can handle translucent geometry, can select points "behind" other
	/// objects, will work on all systems, but is scalable to only a few tens of
	/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
	/// further information.) The choice of picker also has implications on the
	/// type of tolerancing used (as described in the following documentation).
	/// (Note also that the pickers may return slightly different results, this
	/// is expected due to the different way tolerancing works.)
	/// </summary>
	public virtual int GetPickingModeMinValue()
	{
		return vtkPointCloudRepresentation_GetPickingModeMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointCloudRepresentation_GetPointCloudActor_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the associated actor and mapper used to render the point cloud.
	/// </summary>
	public virtual vtkActor GetPointCloudActor()
	{
		vtkActor vtkActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointCloudRepresentation_GetPointCloudActor_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2 = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2.Register(null);
			}
		}
		return vtkActor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointCloudRepresentation_GetPointCloudMapper_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the associated actor and mapper used to render the point cloud.
	/// </summary>
	public virtual vtkPolyDataMapper GetPointCloudMapper()
	{
		vtkPolyDataMapper vtkPolyDataMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointCloudRepresentation_GetPointCloudMapper_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataMapper2 = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataMapper2.Register(null);
			}
		}
		return vtkPolyDataMapper2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointCloudRepresentation_GetPointCoordinates_17(HandleRef pThis);

	/// <summary>
	/// Retrieve the point coordinates of the selected point. Note that if the
	/// point id is invalid (&lt;0) then the coordinates are undefined.
	/// </summary>
	public IntPtr GetPointCoordinates()
	{
		return vtkPointCloudRepresentation_GetPointCoordinates_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_GetPointCoordinates_18(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Retrieve the point coordinates of the selected point. Note that if the
	/// point id is invalid (&lt;0) then the coordinates are undefined.
	/// </summary>
	public void GetPointCoordinates(IntPtr x)
	{
		vtkPointCloudRepresentation_GetPointCoordinates_18(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointCloudRepresentation_GetPointId_19(HandleRef pThis);

	/// <summary>
	/// Retrieve the point id from the selected point. Note that this can
	/// be invalid (&lt;0) if nothing was picked.
	/// </summary>
	public long GetPointId()
	{
		return vtkPointCloudRepresentation_GetPointId_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointCloudRepresentation_GetSoftwarePickingTolerance_20(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to a point (as a fraction of the
	/// bounding box of the point cloud). This specifies when the cursor is
	/// considered near enough to the point to highlight it. Note that this is
	/// a sensitive parameter - too small and it's hard to pick anything; too
	/// large and points close to the eye can be picked in preference to points
	/// further away which are closer to the pick ray.
	/// </summary>
	public virtual double GetSoftwarePickingTolerance()
	{
		return vtkPointCloudRepresentation_GetSoftwarePickingTolerance_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointCloudRepresentation_GetSoftwarePickingToleranceMaxValue_21(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to a point (as a fraction of the
	/// bounding box of the point cloud). This specifies when the cursor is
	/// considered near enough to the point to highlight it. Note that this is
	/// a sensitive parameter - too small and it's hard to pick anything; too
	/// large and points close to the eye can be picked in preference to points
	/// further away which are closer to the pick ray.
	/// </summary>
	public virtual double GetSoftwarePickingToleranceMaxValue()
	{
		return vtkPointCloudRepresentation_GetSoftwarePickingToleranceMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointCloudRepresentation_GetSoftwarePickingToleranceMinValue_22(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to a point (as a fraction of the
	/// bounding box of the point cloud). This specifies when the cursor is
	/// considered near enough to the point to highlight it. Note that this is
	/// a sensitive parameter - too small and it's hard to pick anything; too
	/// large and points close to the eye can be picked in preference to points
	/// further away which are closer to the pick ray.
	/// </summary>
	public virtual double GetSoftwarePickingToleranceMinValue()
	{
		return vtkPointCloudRepresentation_GetSoftwarePickingToleranceMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_HasTranslucentPolygonalGeometry_23(HandleRef pThis);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp (i.e., support rendering).
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkPointCloudRepresentation_HasTranslucentPolygonalGeometry_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_HighlightingOff_24(HandleRef pThis);

	/// <summary>
	/// Flag controls whether highlighting of points occurs as the mouse
	/// moves over them. This can cause extra rendering operations.
	/// </summary>
	public virtual void HighlightingOff()
	{
		vtkPointCloudRepresentation_HighlightingOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_HighlightingOn_25(HandleRef pThis);

	/// <summary>
	/// Flag controls whether highlighting of points occurs as the mouse
	/// moves over them. This can cause extra rendering operations.
	/// </summary>
	public virtual void HighlightingOn()
	{
		vtkPointCloudRepresentation_HighlightingOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_IsA_26(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods for obtaining type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointCloudRepresentation_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_IsTypeOf_27(string type);

	/// <summary>
	/// Standard VTK class methods for obtaining type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointCloudRepresentation_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointCloudRepresentation_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods for obtaining type information and printing.
	/// </summary>
	public new vtkPointCloudRepresentation NewInstance()
	{
		vtkPointCloudRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointCloudRepresentation_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointCloudRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_PlacePointCloud_30(HandleRef pThis, HandleRef a);

	/// <summary>
	/// Specify and place either an actor (vtkActor) or a point set
	/// (vtkPointSet) that represents the point cloud. If placing with an
	/// actor, then the actor must refer to a mapper which in turn refers to a
	/// vtkPointSet, with the actor being used to render the point cloud. If
	/// placing with a vtkPointSet, then an internal vtkActor (and associated
	/// vtkPointGaussianMapper) is created to render the point cloud.
	/// </summary>
	public void PlacePointCloud(vtkActor a)
	{
		vtkPointCloudRepresentation_PlacePointCloud_30(GetCppThis(), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_PlacePointCloud_31(HandleRef pThis, HandleRef ps);

	/// <summary>
	/// Specify and place either an actor (vtkActor) or a point set
	/// (vtkPointSet) that represents the point cloud. If placing with an
	/// actor, then the actor must refer to a mapper which in turn refers to a
	/// vtkPointSet, with the actor being used to render the point cloud. If
	/// placing with a vtkPointSet, then an internal vtkActor (and associated
	/// vtkPointGaussianMapper) is created to render the point cloud.
	/// </summary>
	public void PlacePointCloud(vtkPointSet ps)
	{
		vtkPointCloudRepresentation_PlacePointCloud_31(GetCppThis(), ps?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_RegisterPickers_32(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to a point (as a fraction of the
	/// bounding box of the point cloud). This specifies when the cursor is
	/// considered near enough to the point to highlight it. Note that this is
	/// a sensitive parameter - too small and it's hard to pick anything; too
	/// large and points close to the eye can be picked in preference to points
	/// further away which are closer to the pick ray.
	/// </summary>
	public override void RegisterPickers()
	{
		vtkPointCloudRepresentation_RegisterPickers_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_ReleaseGraphicsResources_33(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp (i.e., support rendering).
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkPointCloudRepresentation_ReleaseGraphicsResources_33(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_RenderOpaqueGeometry_34(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp (i.e., support rendering).
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkPointCloudRepresentation_RenderOpaqueGeometry_34(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_RenderOverlay_35(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp (i.e., support rendering).
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkPointCloudRepresentation_RenderOverlay_35(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudRepresentation_RenderTranslucentPolygonalGeometry_36(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp (i.e., support rendering).
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkPointCloudRepresentation_RenderTranslucentPolygonalGeometry_36(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointCloudRepresentation_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods for obtaining type information and printing.
	/// </summary>
	public new static vtkPointCloudRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkPointCloudRepresentation vtkPointCloudRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointCloudRepresentation_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointCloudRepresentation2 = (vtkPointCloudRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointCloudRepresentation2.Register(null);
			}
		}
		return vtkPointCloudRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_SetHardwarePickingTolerance_38(HandleRef pThis, uint _arg);

	/// <summary>
	/// The tolerance representing the distance to a point expressed in pixels.
	/// A tolerance of 0 selects from the pixel precisely under the cursor. A
	/// tolerance of 1 results in a 3x3 pixel square under the cursor (padded
	/// out by 1 in each direction); a tolerance of N results in a (2N+1)**2
	/// selection rectangle. The point in the selection rectangle which is
	/// closest in z-buffer to the pick position is selected. Note that this can
	/// sometimes return points further away from the cursor (which can be
	/// unexpected - use the tolerance carefully).
	/// </summary>
	public virtual void SetHardwarePickingTolerance(uint _arg)
	{
		vtkPointCloudRepresentation_SetHardwarePickingTolerance_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_SetHighlighting_39(HandleRef pThis, byte _arg);

	/// <summary>
	/// Flag controls whether highlighting of points occurs as the mouse
	/// moves over them. This can cause extra rendering operations.
	/// </summary>
	public virtual void SetHighlighting(bool _arg)
	{
		vtkPointCloudRepresentation_SetHighlighting_39(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_SetInteractionState_40(HandleRef pThis, int _arg);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., PointCloudWidget)
	/// or other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking process
	/// with the widget: First ComputeInteractionState() is invoked that returns
	/// a state based on geometric considerations (i.e., cursor near a widget
	/// feature), then based on events, the widget may modify this further.
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkPointCloudRepresentation_SetInteractionState_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_SetPickingMode_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Because point clouds can be very large, alternative point picking
	/// approaches can be used to select points: either hardware picking (via
	/// rendering) or software rendering (via CPU ray cast). In summary,
	/// hardware picking (via vtkHardwareSelector) is preferred, with an
	/// optional software picker (via vtkPointPicker) available. Each approach
	/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
	/// is faster but only selects opaque geometry and what is visible on the
	/// screen, does not work with anti-aliasing, cannot handle assemblies, and
	/// may not work on some systems. vtkPointPicker avoids extra renders, and
	/// can handle translucent geometry, can select points "behind" other
	/// objects, will work on all systems, but is scalable to only a few tens of
	/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
	/// further information.) The choice of picker also has implications on the
	/// type of tolerancing used (as described in the following documentation).
	/// (Note also that the pickers may return slightly different results, this
	/// is expected due to the different way tolerancing works.)
	/// </summary>
	public virtual void SetPickingMode(int _arg)
	{
		vtkPointCloudRepresentation_SetPickingMode_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_SetPickingModeToHardware_42(HandleRef pThis);

	/// <summary>
	/// Because point clouds can be very large, alternative point picking
	/// approaches can be used to select points: either hardware picking (via
	/// rendering) or software rendering (via CPU ray cast). In summary,
	/// hardware picking (via vtkHardwareSelector) is preferred, with an
	/// optional software picker (via vtkPointPicker) available. Each approach
	/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
	/// is faster but only selects opaque geometry and what is visible on the
	/// screen, does not work with anti-aliasing, cannot handle assemblies, and
	/// may not work on some systems. vtkPointPicker avoids extra renders, and
	/// can handle translucent geometry, can select points "behind" other
	/// objects, will work on all systems, but is scalable to only a few tens of
	/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
	/// further information.) The choice of picker also has implications on the
	/// type of tolerancing used (as described in the following documentation).
	/// (Note also that the pickers may return slightly different results, this
	/// is expected due to the different way tolerancing works.)
	/// </summary>
	public void SetPickingModeToHardware()
	{
		vtkPointCloudRepresentation_SetPickingModeToHardware_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_SetPickingModeToSoftware_43(HandleRef pThis);

	/// <summary>
	/// Because point clouds can be very large, alternative point picking
	/// approaches can be used to select points: either hardware picking (via
	/// rendering) or software rendering (via CPU ray cast). In summary,
	/// hardware picking (via vtkHardwareSelector) is preferred, with an
	/// optional software picker (via vtkPointPicker) available. Each approach
	/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
	/// is faster but only selects opaque geometry and what is visible on the
	/// screen, does not work with anti-aliasing, cannot handle assemblies, and
	/// may not work on some systems. vtkPointPicker avoids extra renders, and
	/// can handle translucent geometry, can select points "behind" other
	/// objects, will work on all systems, but is scalable to only a few tens of
	/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
	/// further information.) The choice of picker also has implications on the
	/// type of tolerancing used (as described in the following documentation).
	/// (Note also that the pickers may return slightly different results, this
	/// is expected due to the different way tolerancing works.)
	/// </summary>
	public void SetPickingModeToSoftware()
	{
		vtkPointCloudRepresentation_SetPickingModeToSoftware_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudRepresentation_SetSoftwarePickingTolerance_44(HandleRef pThis, double _arg);

	/// <summary>
	/// The tolerance representing the distance to a point (as a fraction of the
	/// bounding box of the point cloud). This specifies when the cursor is
	/// considered near enough to the point to highlight it. Note that this is
	/// a sensitive parameter - too small and it's hard to pick anything; too
	/// large and points close to the eye can be picked in preference to points
	/// further away which are closer to the pick ray.
	/// </summary>
	public virtual void SetSoftwarePickingTolerance(double _arg)
	{
		vtkPointCloudRepresentation_SetSoftwarePickingTolerance_44(GetCppThis(), _arg);
	}
}
