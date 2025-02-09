using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAngleRepresentation
/// </summary>
/// <remarks>
///    represent the vtkAngleWidget
///
/// The vtkAngleRepresentation is a superclass for classes representing the
/// vtkAngleWidget. This representation consists of two rays and three
/// vtkHandleRepresentations to place and manipulate the three points defining
/// the angle representation. (Note: the three points are referred to as Point1,
/// Center, and Point2, at the two end points (Point1 and Point2) and Center
/// (around which the angle is measured).
///
/// </remarks>
/// <seealso>
///
/// vtkAngleWidget vtkHandleRepresentation vtkAngleRepresentation2D
/// </seealso>
public abstract class vtkAngleRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public enum NearCenter_WrapperEnum
	{
		/// <summary>enum member</summary>
		NearCenter = 2,
		/// <summary>enum member</summary>
		NearP1 = 1,
		/// <summary>enum member</summary>
		NearP2 = 3,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAngleRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAngleRepresentation()
	{
		MRClassNameKey = "class vtkAngleRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAngleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkAngleRepresentation_ArcVisibilityOff_01(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual void ArcVisibilityOff()
	{
		vtkAngleRepresentation_ArcVisibilityOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_ArcVisibilityOn_02(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual void ArcVisibilityOn()
	{
		vtkAngleRepresentation_ArcVisibilityOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_BuildRepresentation_03(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkAngleRepresentation_BuildRepresentation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_CenterWidgetInteraction_04(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public virtual void CenterWidgetInteraction(IntPtr e)
	{
		vtkAngleRepresentation_CenterWidgetInteraction_04(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation_ComputeInteractionState_05(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkAngleRepresentation_ComputeInteractionState_05(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAngleRepresentation_GetAngle_06(HandleRef pThis);

	/// <summary>
	/// This representation and all subclasses must keep an angle (in degrees)
	/// consistent with the state of the widget.
	/// </summary>
	public virtual double GetAngle()
	{
		return vtkAngleRepresentation_GetAngle_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation_GetArcVisibility_07(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual int GetArcVisibility()
	{
		return vtkAngleRepresentation_GetArcVisibility_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_GetCenterDisplayPosition_08(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the three points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetCenterDisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation_GetCenterDisplayPosition_08(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation_GetCenterRepresentation_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle representations used for the vtkAngleRepresentation.
	/// </summary>
	public virtual vtkHandleRepresentation GetCenterRepresentation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation_GetCenterRepresentation_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_GetCenterWorldPosition_10(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the three points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetCenterWorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation_GetCenterWorldPosition_10(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation_GetLabelFormat_11(HandleRef pThis);

	/// <summary>
	/// Specify the format to use for labeling the angle. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the angle value.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkAngleRepresentation_GetLabelFormat_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAngleRepresentation_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAngleRepresentation_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAngleRepresentation_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAngleRepresentation_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_GetPoint1DisplayPosition_14(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the three points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint1DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation_GetPoint1DisplayPosition_14(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation_GetPoint1Representation_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle representations used for the vtkAngleRepresentation.
	/// </summary>
	public virtual vtkHandleRepresentation GetPoint1Representation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation_GetPoint1Representation_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_GetPoint1WorldPosition_16(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the three points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint1WorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation_GetPoint1WorldPosition_16(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_GetPoint2DisplayPosition_17(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the three points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint2DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation_GetPoint2DisplayPosition_17(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation_GetPoint2Representation_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle representations used for the vtkAngleRepresentation.
	/// </summary>
	public virtual vtkHandleRepresentation GetPoint2Representation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation_GetPoint2Representation_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_GetPoint2WorldPosition_19(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the three points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint2WorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation_GetPoint2WorldPosition_19(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation_GetRay1Visibility_20(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual int GetRay1Visibility()
	{
		return vtkAngleRepresentation_GetRay1Visibility_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation_GetRay2Visibility_21(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual int GetRay2Visibility()
	{
		return vtkAngleRepresentation_GetRay2Visibility_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAngleRepresentation_GetScale_22(HandleRef pThis);

	/// <summary>
	/// Set the scale factor from degrees. The label will be defined in terms of the scaled space. For
	/// example, to use radians in the label set the scale factor to pi/180.
	/// </summary>
	public virtual double GetScale()
	{
		return vtkAngleRepresentation_GetScale_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation_GetTolerance_23(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the end points
	/// of the representation to be active.
	/// </summary>
	public virtual int GetTolerance()
	{
		return vtkAngleRepresentation_GetTolerance_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation_GetToleranceMaxValue_24(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the end points
	/// of the representation to be active.
	/// </summary>
	public virtual int GetToleranceMaxValue()
	{
		return vtkAngleRepresentation_GetToleranceMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation_GetToleranceMinValue_25(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the end points
	/// of the representation to be active.
	/// </summary>
	public virtual int GetToleranceMinValue()
	{
		return vtkAngleRepresentation_GetToleranceMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_InstantiateHandleRepresentation_26(HandleRef pThis);

	/// <summary>
	/// This method is used to specify the type of handle representation to use
	/// for the three internal vtkHandleWidgets within vtkAngleRepresentation.
	/// To use this method, create a dummy vtkHandleRepresentation (or
	/// subclass), and then invoke this method with this dummy. Then the
	/// vtkAngleRepresentation uses this dummy to clone three
	/// vtkHandleRepresentations of the same type. Make sure you set the handle
	/// representation before the widget is enabled. (The method
	/// InstantiateHandleRepresentation() is invoked by the vtkAngle widget.)
	/// </summary>
	public void InstantiateHandleRepresentation()
	{
		vtkAngleRepresentation_InstantiateHandleRepresentation_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation_IsA_27(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAngleRepresentation_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation_IsTypeOf_28(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAngleRepresentation_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkAngleRepresentation NewInstance()
	{
		vtkAngleRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAngleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_Ray1VisibilityOff_30(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual void Ray1VisibilityOff()
	{
		vtkAngleRepresentation_Ray1VisibilityOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_Ray1VisibilityOn_31(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual void Ray1VisibilityOn()
	{
		vtkAngleRepresentation_Ray1VisibilityOn_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_Ray2VisibilityOff_32(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual void Ray2VisibilityOff()
	{
		vtkAngleRepresentation_Ray2VisibilityOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_Ray2VisibilityOn_33(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual void Ray2VisibilityOn()
	{
		vtkAngleRepresentation_Ray2VisibilityOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkAngleRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkAngleRepresentation vtkAngleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAngleRepresentation2 = (vtkAngleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAngleRepresentation2.Register(null);
			}
		}
		return vtkAngleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_SetArcVisibility_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual void SetArcVisibility(int _arg)
	{
		vtkAngleRepresentation_SetArcVisibility_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_SetCenterDisplayPosition_36(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the three points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetCenterDisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation_SetCenterDisplayPosition_36(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_SetHandleRepresentation_37(HandleRef pThis, HandleRef handle);

	/// <summary>
	/// This method is used to specify the type of handle representation to use
	/// for the three internal vtkHandleWidgets within vtkAngleRepresentation.
	/// To use this method, create a dummy vtkHandleRepresentation (or
	/// subclass), and then invoke this method with this dummy. Then the
	/// vtkAngleRepresentation uses this dummy to clone three
	/// vtkHandleRepresentations of the same type. Make sure you set the handle
	/// representation before the widget is enabled. (The method
	/// InstantiateHandleRepresentation() is invoked by the vtkAngle widget.)
	/// </summary>
	public void SetHandleRepresentation(vtkHandleRepresentation handle)
	{
		vtkAngleRepresentation_SetHandleRepresentation_37(GetCppThis(), handle?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_SetLabelFormat_38(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the format to use for labeling the angle. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the angle value.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkAngleRepresentation_SetLabelFormat_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_SetPoint1DisplayPosition_39(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the three points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint1DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation_SetPoint1DisplayPosition_39(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_SetPoint2DisplayPosition_40(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the three points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint2DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation_SetPoint2DisplayPosition_40(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_SetRay1Visibility_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual void SetRay1Visibility(int _arg)
	{
		vtkAngleRepresentation_SetRay1Visibility_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_SetRay2Visibility_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Special methods for turning off the rays and arc that define the cone
	/// and arc of the angle.
	/// </summary>
	public virtual void SetRay2Visibility(int _arg)
	{
		vtkAngleRepresentation_SetRay2Visibility_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_SetScale_43(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the scale factor from degrees. The label will be defined in terms of the scaled space. For
	/// example, to use radians in the label set the scale factor to pi/180.
	/// </summary>
	public virtual void SetScale(double _arg)
	{
		vtkAngleRepresentation_SetScale_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_SetTolerance_44(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the end points
	/// of the representation to be active.
	/// </summary>
	public virtual void SetTolerance(int _arg)
	{
		vtkAngleRepresentation_SetTolerance_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_StartWidgetInteraction_45(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr e)
	{
		vtkAngleRepresentation_StartWidgetInteraction_45(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation_WidgetInteraction_46(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkAngleRepresentation_WidgetInteraction_46(GetCppThis(), e);
	}
}
