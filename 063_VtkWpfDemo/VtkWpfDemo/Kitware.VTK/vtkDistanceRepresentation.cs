using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDistanceRepresentation
/// </summary>
/// <remarks>
///    represent the vtkDistanceWidget
///
/// The vtkDistanceRepresentation is a superclass for various types of
/// representations for the vtkDistanceWidget. Logically subclasses consist of
/// an axis and two handles for placing/manipulating the end points.
///
/// </remarks>
/// <seealso>
///
/// vtkDistanceWidget vtkHandleRepresentation vtkDistanceRepresentation2D vtkDistanceRepresentation
/// </seealso>
public abstract class vtkDistanceRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Specify the number of major ruler ticks. This overrides any subclasses
	/// (e.g., vtkDistanceRepresentation2D) that have alternative methods to
	/// specify the number of major ticks. Note: the number of ticks is the
	/// number between the two handle endpoints. This ivar only has effect
	/// when the RulerMode is off.
	/// </summary>
	public enum NearP1_WrapperEnum
	{
		/// <summary>enum member</summary>
		NearP1 = 1,
		/// <summary>enum member</summary>
		NearP2 = 2,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDistanceRepresentation()
	{
		MRClassNameKey = "class vtkDistanceRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDistanceRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkDistanceRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkDistanceRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_ComplexInteraction_02(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkDistanceRepresentation_ComplexInteraction_02(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation_ComputeComplexInteractionState_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
	{
		return vtkDistanceRepresentation_ComputeComplexInteractionState_03(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkDistanceRepresentation_ComputeInteractionState_04(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDistanceRepresentation_GetDistance_05(HandleRef pThis);

	/// <summary>
	/// This representation and all subclasses must keep a distance
	/// consistent with the state of the widget.
	/// </summary>
	public virtual double GetDistance()
	{
		return vtkDistanceRepresentation_GetDistance_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation_GetLabelFormat_06(HandleRef pThis);

	/// <summary>
	/// Specify the format to use for labelling the distance. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the distance value.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkDistanceRepresentation_GetLabelFormat_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistanceRepresentation_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDistanceRepresentation_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistanceRepresentation_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDistanceRepresentation_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation_GetNumberOfRulerTicks_09(HandleRef pThis);

	/// <summary>
	/// Specify the number of major ruler ticks. This overrides any subclasses
	/// (e.g., vtkDistanceRepresentation2D) that have alternative methods to
	/// specify the number of major ticks. Note: the number of ticks is the
	/// number between the two handle endpoints. This ivar only has effect
	/// when the RulerMode is off.
	/// </summary>
	public virtual int GetNumberOfRulerTicks()
	{
		return vtkDistanceRepresentation_GetNumberOfRulerTicks_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation_GetNumberOfRulerTicksMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Specify the number of major ruler ticks. This overrides any subclasses
	/// (e.g., vtkDistanceRepresentation2D) that have alternative methods to
	/// specify the number of major ticks. Note: the number of ticks is the
	/// number between the two handle endpoints. This ivar only has effect
	/// when the RulerMode is off.
	/// </summary>
	public virtual int GetNumberOfRulerTicksMaxValue()
	{
		return vtkDistanceRepresentation_GetNumberOfRulerTicksMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation_GetNumberOfRulerTicksMinValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the number of major ruler ticks. This overrides any subclasses
	/// (e.g., vtkDistanceRepresentation2D) that have alternative methods to
	/// specify the number of major ticks. Note: the number of ticks is the
	/// number between the two handle endpoints. This ivar only has effect
	/// when the RulerMode is off.
	/// </summary>
	public virtual int GetNumberOfRulerTicksMinValue()
	{
		return vtkDistanceRepresentation_GetNumberOfRulerTicksMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_GetPoint1DisplayPosition_12(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint1DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation_GetPoint1DisplayPosition_12(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation_GetPoint1Representation_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the two handle representations used for the vtkDistanceWidget. (Note:
	/// properties can be set by grabbing these representations and setting the
	/// properties appropriately.)
	/// </summary>
	public virtual vtkHandleRepresentation GetPoint1Representation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation_GetPoint1Representation_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDistanceRepresentation_GetPoint1WorldPosition_14(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint1WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation_GetPoint1WorldPosition_14(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation_GetPoint1WorldPosition_15(HandleRef pThis);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual double[] GetPoint1WorldPosition()
	{
		IntPtr intPtr = vtkDistanceRepresentation_GetPoint1WorldPosition_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_GetPoint2DisplayPosition_16(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint2DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation_GetPoint2DisplayPosition_16(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation_GetPoint2Representation_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the two handle representations used for the vtkDistanceWidget. (Note:
	/// properties can be set by grabbing these representations and setting the
	/// properties appropriately.)
	/// </summary>
	public virtual vtkHandleRepresentation GetPoint2Representation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation_GetPoint2Representation_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDistanceRepresentation_GetPoint2WorldPosition_18(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint2WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation_GetPoint2WorldPosition_18(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation_GetPoint2WorldPosition_19(HandleRef pThis);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual double[] GetPoint2WorldPosition()
	{
		IntPtr intPtr = vtkDistanceRepresentation_GetPoint2WorldPosition_19(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDistanceRepresentation_GetRulerDistance_20(HandleRef pThis);

	/// <summary>
	/// Specify the RulerDistance which indicates the spacing of the major ticks.
	/// This ivar only has effect when the RulerMode is on.
	/// </summary>
	public virtual double GetRulerDistance()
	{
		return vtkDistanceRepresentation_GetRulerDistance_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDistanceRepresentation_GetRulerDistanceMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Specify the RulerDistance which indicates the spacing of the major ticks.
	/// This ivar only has effect when the RulerMode is on.
	/// </summary>
	public virtual double GetRulerDistanceMaxValue()
	{
		return vtkDistanceRepresentation_GetRulerDistanceMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDistanceRepresentation_GetRulerDistanceMinValue_22(HandleRef pThis);

	/// <summary>
	/// Specify the RulerDistance which indicates the spacing of the major ticks.
	/// This ivar only has effect when the RulerMode is on.
	/// </summary>
	public virtual double GetRulerDistanceMinValue()
	{
		return vtkDistanceRepresentation_GetRulerDistanceMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation_GetRulerMode_23(HandleRef pThis);

	/// <summary>
	/// Enable or disable ruler mode. When enabled, the ticks on the distance widget
	/// are separated by the amount specified by RulerDistance. Otherwise, the ivar
	/// NumberOfRulerTicks is used to draw the tick marks.
	/// </summary>
	public virtual int GetRulerMode()
	{
		return vtkDistanceRepresentation_GetRulerMode_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDistanceRepresentation_GetScale_24(HandleRef pThis);

	/// <summary>
	/// Set the scale factor from VTK world coordinates. The ruler marks and label
	/// will be defined in terms of the scaled space. For example, if the VTK world
	/// coordinates are assumed to be in inches, but the desired distance units
	/// should be defined in terms of centimeters, the scale factor should be set
	/// to 2.54. The ruler marks will then be spaced in terms of centimeters, and
	/// the label will show the measurement in centimeters.
	/// </summary>
	public virtual double GetScale()
	{
		return vtkDistanceRepresentation_GetScale_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation_GetTolerance_25(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the end points of
	/// the widget to be active.
	/// </summary>
	public virtual int GetTolerance()
	{
		return vtkDistanceRepresentation_GetTolerance_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation_GetToleranceMaxValue_26(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the end points of
	/// the widget to be active.
	/// </summary>
	public virtual int GetToleranceMaxValue()
	{
		return vtkDistanceRepresentation_GetToleranceMaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation_GetToleranceMinValue_27(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the end points of
	/// the widget to be active.
	/// </summary>
	public virtual int GetToleranceMinValue()
	{
		return vtkDistanceRepresentation_GetToleranceMinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_InstantiateHandleRepresentation_28(HandleRef pThis);

	/// <summary>
	/// This method is used to specify the type of handle representation to
	/// use for the two internal vtkHandleWidgets within vtkDistanceWidget.
	/// To use this method, create a dummy vtkHandleWidget (or subclass),
	/// and then invoke this method with this dummy. Then the
	/// vtkDistanceRepresentation uses this dummy to clone two vtkHandleWidgets
	/// of the same type. Make sure you set the handle representation before
	/// the widget is enabled. (The method InstantiateHandleRepresentation()
	/// is invoked by the vtkDistance widget.)
	/// </summary>
	public void InstantiateHandleRepresentation()
	{
		vtkDistanceRepresentation_InstantiateHandleRepresentation_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation_IsA_29(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDistanceRepresentation_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation_IsTypeOf_30(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDistanceRepresentation_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkDistanceRepresentation NewInstance()
	{
		vtkDistanceRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistanceRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_RulerModeOff_32(HandleRef pThis);

	/// <summary>
	/// Enable or disable ruler mode. When enabled, the ticks on the distance widget
	/// are separated by the amount specified by RulerDistance. Otherwise, the ivar
	/// NumberOfRulerTicks is used to draw the tick marks.
	/// </summary>
	public virtual void RulerModeOff()
	{
		vtkDistanceRepresentation_RulerModeOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_RulerModeOn_33(HandleRef pThis);

	/// <summary>
	/// Enable or disable ruler mode. When enabled, the ticks on the distance widget
	/// are separated by the amount specified by RulerDistance. Otherwise, the ivar
	/// NumberOfRulerTicks is used to draw the tick marks.
	/// </summary>
	public virtual void RulerModeOn()
	{
		vtkDistanceRepresentation_RulerModeOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkDistanceRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkDistanceRepresentation vtkDistanceRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDistanceRepresentation2 = (vtkDistanceRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDistanceRepresentation2.Register(null);
			}
		}
		return vtkDistanceRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_SetHandleRepresentation_35(HandleRef pThis, HandleRef handle);

	/// <summary>
	/// This method is used to specify the type of handle representation to
	/// use for the two internal vtkHandleWidgets within vtkDistanceWidget.
	/// To use this method, create a dummy vtkHandleWidget (or subclass),
	/// and then invoke this method with this dummy. Then the
	/// vtkDistanceRepresentation uses this dummy to clone two vtkHandleWidgets
	/// of the same type. Make sure you set the handle representation before
	/// the widget is enabled. (The method InstantiateHandleRepresentation()
	/// is invoked by the vtkDistance widget.)
	/// </summary>
	public void SetHandleRepresentation(vtkHandleRepresentation handle)
	{
		vtkDistanceRepresentation_SetHandleRepresentation_35(GetCppThis(), handle?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_SetLabelFormat_36(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the format to use for labelling the distance. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the distance value.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkDistanceRepresentation_SetLabelFormat_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_SetNumberOfRulerTicks_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of major ruler ticks. This overrides any subclasses
	/// (e.g., vtkDistanceRepresentation2D) that have alternative methods to
	/// specify the number of major ticks. Note: the number of ticks is the
	/// number between the two handle endpoints. This ivar only has effect
	/// when the RulerMode is off.
	/// </summary>
	public virtual void SetNumberOfRulerTicks(int _arg)
	{
		vtkDistanceRepresentation_SetNumberOfRulerTicks_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_SetPoint1DisplayPosition_38(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint1DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation_SetPoint1DisplayPosition_38(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_SetPoint1WorldPosition_39(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint1WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation_SetPoint1WorldPosition_39(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_SetPoint2DisplayPosition_40(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint2DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation_SetPoint2DisplayPosition_40(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_SetPoint2WorldPosition_41(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint2WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation_SetPoint2WorldPosition_41(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_SetRulerDistance_42(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the RulerDistance which indicates the spacing of the major ticks.
	/// This ivar only has effect when the RulerMode is on.
	/// </summary>
	public virtual void SetRulerDistance(double _arg)
	{
		vtkDistanceRepresentation_SetRulerDistance_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_SetRulerMode_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable or disable ruler mode. When enabled, the ticks on the distance widget
	/// are separated by the amount specified by RulerDistance. Otherwise, the ivar
	/// NumberOfRulerTicks is used to draw the tick marks.
	/// </summary>
	public virtual void SetRulerMode(int _arg)
	{
		vtkDistanceRepresentation_SetRulerMode_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_SetScale_44(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the scale factor from VTK world coordinates. The ruler marks and label
	/// will be defined in terms of the scaled space. For example, if the VTK world
	/// coordinates are assumed to be in inches, but the desired distance units
	/// should be defined in terms of centimeters, the scale factor should be set
	/// to 2.54. The ruler marks will then be spaced in terms of centimeters, and
	/// the label will show the measurement in centimeters.
	/// </summary>
	public virtual void SetScale(double _arg)
	{
		vtkDistanceRepresentation_SetScale_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_SetTolerance_45(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the end points of
	/// the widget to be active.
	/// </summary>
	public virtual void SetTolerance(int _arg)
	{
		vtkDistanceRepresentation_SetTolerance_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_StartComplexInteraction_46(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkDistanceRepresentation_StartComplexInteraction_46(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_StartWidgetInteraction_47(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr e)
	{
		vtkDistanceRepresentation_StartWidgetInteraction_47(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation_WidgetInteraction_48(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkDistanceRepresentation_WidgetInteraction_48(GetCppThis(), e);
	}
}
