using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCoordinateFrameRepresentation
/// </summary>
/// <remarks>
///    a class defining the representation for a vtkCoordinateFrameWidget
///
/// This class is a concrete representation for the
/// vtkCoordinateFrameWidget. It represents a coordinate frame with an origin, 3 axis and
/// 3 axis lockers. Through interaction with the widget, the coordinate frame can be manipulated
/// by adjusting the axis normals, locking them, or moving/picking the origin point.
///
/// The PlaceWidget() method is also used to initially position the
/// representation.
///
/// @warning
/// This class, and vtkCoordinateFrameWidget, are next generation VTK
/// widgets.
/// </remarks>
public class vtkCoordinateFrameRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		ModifyingLockerXVector = 6,
		/// <summary>enum member</summary>
		ModifyingLockerYVector = 7,
		/// <summary>enum member</summary>
		ModifyingLockerZVector = 8,
		/// <summary>enum member</summary>
		Moving = 1,
		/// <summary>enum member</summary>
		MovingOrigin = 2,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		RotatingXVector = 3,
		/// <summary>enum member</summary>
		RotatingYVector = 4,
		/// <summary>enum member</summary>
		RotatingZVector = 5
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCoordinateFrameRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCoordinateFrameRepresentation()
	{
		MRClassNameKey = "class vtkCoordinateFrameRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCoordinateFrameRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCoordinateFrameRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkCoordinateFrameRepresentation New()
	{
		vtkCoordinateFrameRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCoordinateFrameRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkCoordinateFrameRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCoordinateFrameRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCoordinateFrameRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkCoordinateFrameWidget.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkCoordinateFrameRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Methods to interface with the vtkCoordinateFrameWidget.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkCoordinateFrameRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_EndWidgetInteraction_03(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// Methods to interface with the vtkCoordinateFrameWidget.
	/// </summary>
	public override void EndWidgetInteraction(IntPtr newEventPos)
	{
		vtkCoordinateFrameRepresentation_EndWidgetInteraction_03(GetCppThis(), newEventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_GetActors_04(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void GetActors(vtkPropCollection pc)
	{
		vtkCoordinateFrameRepresentation_GetActors_04(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameRepresentation_GetInteractionStateMaxValue_06(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkCoordinateFrameWidget) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual int GetInteractionStateMaxValue()
	{
		return vtkCoordinateFrameRepresentation_GetInteractionStateMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameRepresentation_GetInteractionStateMinValue_07(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkCoordinateFrameWidget) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual int GetInteractionStateMinValue()
	{
		return vtkCoordinateFrameRepresentation_GetInteractionStateMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCoordinateFrameRepresentation_GetLengthFactor_08(HandleRef pThis);

	/// <summary>
	/// Set/get the length of the axis glyphs relative to screen size.
	/// The default is 0.04.
	/// </summary>
	public virtual double GetLengthFactor()
	{
		return vtkCoordinateFrameRepresentation_GetLengthFactor_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCoordinateFrameRepresentation_GetLengthFactorMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set/get the length of the axis glyphs relative to screen size.
	/// The default is 0.04.
	/// </summary>
	public virtual double GetLengthFactorMaxValue()
	{
		return vtkCoordinateFrameRepresentation_GetLengthFactorMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCoordinateFrameRepresentation_GetLengthFactorMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set/get the length of the axis glyphs relative to screen size.
	/// The default is 0.04.
	/// </summary>
	public virtual double GetLengthFactorMinValue()
	{
		return vtkCoordinateFrameRepresentation_GetLengthFactorMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameRepresentation_GetLockNormalToCamera_11(HandleRef pThis);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual int GetLockNormalToCamera()
	{
		return vtkCoordinateFrameRepresentation_GetLockNormalToCamera_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameRepresentation_GetLockedAxis_12(HandleRef pThis);

	/// <summary>
	/// Get/set which axis (if any) is locked.
	///
	/// At most, a single axis can be locked at a time.
	///
	/// The axis must be one of the following values: { -1, 0, 1, 2 }.
	/// -1 indicates that no axis is locked; 0 corresponds to the X axis; 1 to Y; and 2 to Z.
	///
	/// In terms of mouse interactions, locking an axis prevents its direction from being
	/// modified by rotation (so only rotations about that axis are possible) and
	/// prevents the origin from translating along it (so all translations must be in the
	/// plane using it as a normal).
	///
	/// In terms of picking interactions, locking an axis selects it as the target axis
	/// to be modified (i.e., the locked axis will be overwritten with a normal vector
	/// or direction vector).
	/// </summary>
	public int GetLockedAxis()
	{
		return vtkCoordinateFrameRepresentation_GetLockedAxis_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetLockedXVectorProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the LockedXVector. The properties of the LockedXVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetLockedXVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetLockedXVectorProperty_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetLockedYVectorProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the LockedYVector. The properties of the LockedYVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetLockedYVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetLockedYVectorProperty_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetLockedZVectorProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the LockedZVector. The properties of the LockedZVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetLockedZVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetLockedZVectorProperty_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCoordinateFrameRepresentation_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCoordinateFrameRepresentation_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCoordinateFrameRepresentation_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCoordinateFrameRepresentation_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetOrigin_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the origin of the coordinate frame.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetOrigin_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_GetOrigin_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the origin of the coordinate frame.
	/// </summary>
	public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCoordinateFrameRepresentation_GetOrigin_19(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_GetOrigin_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the origin of the coordinate frame.
	/// </summary>
	public virtual void GetOrigin(IntPtr _arg)
	{
		vtkCoordinateFrameRepresentation_GetOrigin_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetOriginProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties of the origin. The properties of the origin when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetOriginProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetOriginProperty_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCoordinateFrameRepresentation_GetPickCameraFocalInfo_22(HandleRef pThis);

	/// <summary>
	/// Enable/Disable picking camera focal info if no result is available for PickOrigin, PickNormal
	/// and PickDirectionPoint. The default is disabled.
	/// </summary>
	public virtual bool GetPickCameraFocalInfo()
	{
		return (vtkCoordinateFrameRepresentation_GetPickCameraFocalInfo_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameRepresentation_GetRepresentationState_23(HandleRef pThis);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual int GetRepresentationState()
	{
		return vtkCoordinateFrameRepresentation_GetRepresentationState_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedLockedXVectorProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the LockedXVector. The properties of the LockedXVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedLockedXVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetSelectedLockedXVectorProperty_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedLockedYVectorProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the LockedYVector. The properties of the LockedYVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedLockedYVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetSelectedLockedYVectorProperty_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedLockedZVectorProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the LockedZVector. The properties of the LockedZVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedLockedZVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetSelectedLockedZVectorProperty_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedOriginProperty_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties of the origin. The properties of the origin when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedOriginProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetSelectedOriginProperty_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedUnlockedXVectorProperty_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the UnlockedXVector. The properties of the UnlockedXVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedUnlockedXVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetSelectedUnlockedXVectorProperty_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedUnlockedYVectorProperty_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the UnlockedYVector. The properties of the UnlockedYVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedUnlockedYVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetSelectedUnlockedYVectorProperty_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedUnlockedZVectorProperty_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the UnlockedZVector. The properties of the UnlockedZVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedUnlockedZVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetSelectedUnlockedZVectorProperty_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedXVectorProperty_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the XVector. The properties of the XVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedXVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetSelectedXVectorProperty_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedYVectorProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the YVector. The properties of the YVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedYVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetSelectedYVectorProperty_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedZVectorProperty_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the ZVector. The properties of the ZVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedZVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetSelectedZVectorProperty_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetUnlockedXVectorProperty_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the UnlockedXVector. The properties of the UnlockedXVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetUnlockedXVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetUnlockedXVectorProperty_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetUnlockedYVectorProperty_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the UnlockedYVector. The properties of the UnlockedYVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetUnlockedYVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetUnlockedYVectorProperty_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetUnlockedZVectorProperty_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the UnlockedZVector. The properties of the UnlockedZVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetUnlockedZVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetUnlockedZVectorProperty_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetXVectorNormal_37(HandleRef pThis);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public virtual double[] GetXVectorNormal()
	{
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetXVectorNormal_37(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_GetXVectorNormal_38(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public virtual void GetXVectorNormal(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCoordinateFrameRepresentation_GetXVectorNormal_38(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_GetXVectorNormal_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public virtual void GetXVectorNormal(IntPtr _arg)
	{
		vtkCoordinateFrameRepresentation_GetXVectorNormal_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetXVectorProperty_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the XVector. The properties of the XVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetXVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetXVectorProperty_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetYVectorNormal_41(HandleRef pThis);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public virtual double[] GetYVectorNormal()
	{
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetYVectorNormal_41(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_GetYVectorNormal_42(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public virtual void GetYVectorNormal(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCoordinateFrameRepresentation_GetYVectorNormal_42(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_GetYVectorNormal_43(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public virtual void GetYVectorNormal(IntPtr _arg)
	{
		vtkCoordinateFrameRepresentation_GetYVectorNormal_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetYVectorProperty_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the YVector. The properties of the YVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetYVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetYVectorProperty_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetZVectorNormal_45(HandleRef pThis);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public virtual double[] GetZVectorNormal()
	{
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetZVectorNormal_45(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_GetZVectorNormal_46(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public virtual void GetZVectorNormal(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCoordinateFrameRepresentation_GetZVectorNormal_46(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_GetZVectorNormal_47(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public virtual void GetZVectorNormal(IntPtr _arg)
	{
		vtkCoordinateFrameRepresentation_GetZVectorNormal_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_GetZVectorProperty_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the ZVector. The properties of the ZVector when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetZVectorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_GetZVectorProperty_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameRepresentation_HasTranslucentPolygonalGeometry_49(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkCoordinateFrameRepresentation_HasTranslucentPolygonalGeometry_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameRepresentation_IsA_50(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCoordinateFrameRepresentation_IsA_50(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCoordinateFrameRepresentation_IsTranslationConstrained_51(HandleRef pThis);

	/// <summary>
	/// Returns true if ConstrainedAxis
	/// </summary>
	public bool IsTranslationConstrained()
	{
		return (vtkCoordinateFrameRepresentation_IsTranslationConstrained_51(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameRepresentation_IsTypeOf_52(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCoordinateFrameRepresentation_IsTypeOf_52(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_LockNormalToCameraOff_53(HandleRef pThis);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual void LockNormalToCameraOff()
	{
		vtkCoordinateFrameRepresentation_LockNormalToCameraOff_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_LockNormalToCameraOn_54(HandleRef pThis);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual void LockNormalToCameraOn()
	{
		vtkCoordinateFrameRepresentation_LockNormalToCameraOn_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_NewInstance_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkCoordinateFrameRepresentation NewInstance()
	{
		vtkCoordinateFrameRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_NewInstance_56(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCoordinateFrameRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_PickCameraFocalInfoOff_57(HandleRef pThis);

	/// <summary>
	/// Enable/Disable picking camera focal info if no result is available for PickOrigin, PickNormal
	/// and PickDirectionPoint. The default is disabled.
	/// </summary>
	public virtual void PickCameraFocalInfoOff()
	{
		vtkCoordinateFrameRepresentation_PickCameraFocalInfoOff_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_PickCameraFocalInfoOn_58(HandleRef pThis);

	/// <summary>
	/// Enable/Disable picking camera focal info if no result is available for PickOrigin, PickNormal
	/// and PickDirectionPoint. The default is disabled.
	/// </summary>
	public virtual void PickCameraFocalInfoOn()
	{
		vtkCoordinateFrameRepresentation_PickCameraFocalInfoOn_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCoordinateFrameRepresentation_PickDirectionPoint_59(HandleRef pThis, int X, int Y, byte snapToMeshPoint);

	/// <summary>
	/// Given the X, Y display coordinates, pick a point and using the origin define normal for the
	/// coordinate frame from a point that is on the objects rendered by the renderer.
	///
	/// Note: if a point from a rendered object is not picked, the camera focal point can optionally be
	/// set.
	/// </summary>
	public bool PickDirectionPoint(int X, int Y, bool snapToMeshPoint)
	{
		return (vtkCoordinateFrameRepresentation_PickDirectionPoint_59(GetCppThis(), X, Y, (byte)(snapToMeshPoint ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCoordinateFrameRepresentation_PickNormal_60(HandleRef pThis, int X, int Y, byte snapToMeshPoint);

	/// <summary>
	/// Given the X, Y display coordinates, pick a new normal for the coordinate frame
	/// from a point that is on the objects rendered by the renderer.
	///
	/// Note: if a normal from a rendered object is not picked, the camera plane normal can optionally
	/// be set.
	/// </summary>
	public bool PickNormal(int X, int Y, bool snapToMeshPoint)
	{
		return (vtkCoordinateFrameRepresentation_PickNormal_60(GetCppThis(), X, Y, (byte)(snapToMeshPoint ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCoordinateFrameRepresentation_PickOrigin_61(HandleRef pThis, int X, int Y, byte snapToMeshPoint);

	/// <summary>
	/// Given the X, Y display coordinates, pick a new origin for the coordinate frame
	/// from a point that is on the objects rendered by the renderer.
	///
	/// Note: if a point from a rendered object is not picked, the camera focal point can optionally be
	/// set.
	/// </summary>
	public bool PickOrigin(int X, int Y, bool snapToMeshPoint)
	{
		return (vtkCoordinateFrameRepresentation_PickOrigin_61(GetCppThis(), X, Y, (byte)(snapToMeshPoint ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_PlaceWidget_62(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to interface with the vtkCoordinateFrameWidget.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkCoordinateFrameRepresentation_PlaceWidget_62(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_ReleaseGraphicsResources_63(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkCoordinateFrameRepresentation_ReleaseGraphicsResources_63(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameRepresentation_RenderOpaqueGeometry_64(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkCoordinateFrameRepresentation_RenderOpaqueGeometry_64(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameRepresentation_RenderTranslucentPolygonalGeometry_65(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkCoordinateFrameRepresentation_RenderTranslucentPolygonalGeometry_65(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_Reset_66(HandleRef pThis);

	/// <summary>
	/// Reset the origin (by calling update placement) and the axes (to be aligned
	/// with the world coordinate X, Y, and Z axes).
	/// </summary>
	public void Reset()
	{
		vtkCoordinateFrameRepresentation_Reset_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_ResetAxes_67(HandleRef pThis);

	/// <summary>
	/// Reset only the axis orientations (not the origin).
	/// </summary>
	public void ResetAxes()
	{
		vtkCoordinateFrameRepresentation_ResetAxes_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameRepresentation_SafeDownCast_68(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkCoordinateFrameRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkCoordinateFrameRepresentation vtkCoordinateFrameRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameRepresentation_SafeDownCast_68(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinateFrameRepresentation2 = (vtkCoordinateFrameRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinateFrameRepresentation2.Register(null);
			}
		}
		return vtkCoordinateFrameRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetDirection_69(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set the direction of the locked (or absent a locked axis, the nearest
	/// axis) to point from the frame's origin toward the given (x,y,z) location.
	/// </summary>
	public void SetDirection(double x, double y, double z)
	{
		vtkCoordinateFrameRepresentation_SetDirection_69(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetDirection_70(HandleRef pThis, IntPtr d);

	/// <summary>
	/// Set the direction of the locked (or absent a locked axis, the nearest
	/// axis) to point from the frame's origin toward the given (x,y,z) location.
	/// </summary>
	public void SetDirection(IntPtr d)
	{
		vtkCoordinateFrameRepresentation_SetDirection_70(GetCppThis(), d);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetInteractionState_71(HandleRef pThis, int _arg);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkCoordinateFrameWidget) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkCoordinateFrameRepresentation_SetInteractionState_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetLengthFactor_72(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the length of the axis glyphs relative to screen size.
	/// The default is 0.04.
	/// </summary>
	public virtual void SetLengthFactor(double _arg)
	{
		vtkCoordinateFrameRepresentation_SetLengthFactor_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetLockNormalToCamera_73(HandleRef pThis, int arg0);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual void SetLockNormalToCamera(int arg0)
	{
		vtkCoordinateFrameRepresentation_SetLockNormalToCamera_73(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetLockedAxis_74(HandleRef pThis, int axis);

	/// <summary>
	/// Get/set which axis (if any) is locked.
	///
	/// At most, a single axis can be locked at a time.
	///
	/// The axis must be one of the following values: { -1, 0, 1, 2 }.
	/// -1 indicates that no axis is locked; 0 corresponds to the X axis; 1 to Y; and 2 to Z.
	///
	/// In terms of mouse interactions, locking an axis prevents its direction from being
	/// modified by rotation (so only rotations about that axis are possible) and
	/// prevents the origin from translating along it (so all translations must be in the
	/// plane using it as a normal).
	///
	/// In terms of picking interactions, locking an axis selects it as the target axis
	/// to be modified (i.e., the locked axis will be overwritten with a normal vector
	/// or direction vector).
	/// </summary>
	public void SetLockedAxis(int axis)
	{
		vtkCoordinateFrameRepresentation_SetLockedAxis_74(GetCppThis(), axis);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetNormal_75(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public void SetNormal(double x, double y, double z)
	{
		vtkCoordinateFrameRepresentation_SetNormal_75(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetNormal_76(HandleRef pThis, IntPtr n);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public void SetNormal(IntPtr n)
	{
		vtkCoordinateFrameRepresentation_SetNormal_76(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetNormalToCamera_77(HandleRef pThis);

	/// <summary>
	/// Set/Get the normal of one of the axes of the coordinate frame.
	///
	/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
	/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
	/// reset to the picked normal.
	///
	/// In both cases, the remaining normals are re-orthogonalized using the
	/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
	/// Gram-Schmidt procedure&lt;/a&gt;.
	/// </summary>
	public void SetNormalToCamera()
	{
		vtkCoordinateFrameRepresentation_SetNormalToCamera_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetOrigin_78(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the origin of the coordinate frame.
	/// </summary>
	public void SetOrigin(double x, double y, double z)
	{
		vtkCoordinateFrameRepresentation_SetOrigin_78(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetOrigin_79(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the origin of the coordinate frame.
	/// </summary>
	public void SetOrigin(IntPtr x)
	{
		vtkCoordinateFrameRepresentation_SetOrigin_79(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetPickCameraFocalInfo_80(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/Disable picking camera focal info if no result is available for PickOrigin, PickNormal
	/// and PickDirectionPoint. The default is disabled.
	/// </summary>
	public virtual void SetPickCameraFocalInfo(bool _arg)
	{
		vtkCoordinateFrameRepresentation_SetPickCameraFocalInfo_80(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetRepresentationState_81(HandleRef pThis, int arg0);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual void SetRepresentationState(int arg0)
	{
		vtkCoordinateFrameRepresentation_SetRepresentationState_81(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetTranslationAxisOff_82(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetTranslationAxisOff()
	{
		vtkCoordinateFrameRepresentation_SetTranslationAxisOff_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetXAxisVector_83(HandleRef pThis, IntPtr v);

	/// <summary>
	/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
	///
	/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
	/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
	/// </summary>
	public void SetXAxisVector(IntPtr v)
	{
		vtkCoordinateFrameRepresentation_SetXAxisVector_83(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetXAxisVector_84(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
	///
	/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
	/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
	/// </summary>
	public void SetXAxisVector(double x, double y, double z)
	{
		vtkCoordinateFrameRepresentation_SetXAxisVector_84(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetXTranslationAxisOn_85(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetXTranslationAxisOn()
	{
		vtkCoordinateFrameRepresentation_SetXTranslationAxisOn_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetYAxisVector_86(HandleRef pThis, IntPtr v);

	/// <summary>
	/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
	///
	/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
	/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
	/// </summary>
	public void SetYAxisVector(IntPtr v)
	{
		vtkCoordinateFrameRepresentation_SetYAxisVector_86(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetYAxisVector_87(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
	///
	/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
	/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
	/// </summary>
	public void SetYAxisVector(double x, double y, double z)
	{
		vtkCoordinateFrameRepresentation_SetYAxisVector_87(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetYTranslationAxisOn_88(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetYTranslationAxisOn()
	{
		vtkCoordinateFrameRepresentation_SetYTranslationAxisOn_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetZAxisVector_89(HandleRef pThis, IntPtr v);

	/// <summary>
	/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
	///
	/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
	/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
	/// </summary>
	public void SetZAxisVector(IntPtr v)
	{
		vtkCoordinateFrameRepresentation_SetZAxisVector_89(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetZAxisVector_90(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
	///
	/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
	/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
	/// </summary>
	public void SetZAxisVector(double x, double y, double z)
	{
		vtkCoordinateFrameRepresentation_SetZAxisVector_90(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_SetZTranslationAxisOn_91(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetZTranslationAxisOn()
	{
		vtkCoordinateFrameRepresentation_SetZTranslationAxisOn_91(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_StartWidgetInteraction_92(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkCoordinateFrameWidget.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkCoordinateFrameRepresentation_StartWidgetInteraction_92(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_UpdatePlacement_93(HandleRef pThis);

	/// <summary>
	/// Satisfies the superclass API.  This will change the state of the widget
	/// to match changes that have been made to the underlying PolyDataSource
	/// </summary>
	public void UpdatePlacement()
	{
		vtkCoordinateFrameRepresentation_UpdatePlacement_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameRepresentation_WidgetInteraction_94(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// Methods to interface with the vtkCoordinateFrameWidget.
	/// </summary>
	public override void WidgetInteraction(IntPtr newEventPos)
	{
		vtkCoordinateFrameRepresentation_WidgetInteraction_94(GetCppThis(), newEventPos);
	}
}
