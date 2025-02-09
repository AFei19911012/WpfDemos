using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLineRepresentation
/// </summary>
/// <remarks>
///    a class defining the representation for a vtkLineWidget2
///
/// This class is a concrete representation for the vtkLineWidget2. It
/// represents a straight line with three handles: one at the beginning and
/// ending of the line, and one used to translate the line. Through
/// interaction with the widget, the line representation can be arbitrarily
/// placed in the 3D space.
///
/// To use this representation, you normally specify the position of the two
/// end points (either in world or display coordinates). The PlaceWidget()
/// method is also used to initially position the representation.
///
/// @warning
/// This class, and vtkLineWidget2, are next generation VTK
/// widgets. An earlier version of this functionality was defined in the
/// class vtkLineWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkLineWidget2 vtkLineWidget
/// </seealso>
public class vtkLineRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public enum OnLine_WrapperEnum
	{
		/// <summary>enum member</summary>
		OnLine = 5,
		/// <summary>enum member</summary>
		OnP1 = 1,
		/// <summary>enum member</summary>
		OnP2 = 2,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		Scaling = 6,
		/// <summary>enum member</summary>
		TranslatingP1 = 3,
		/// <summary>enum member</summary>
		TranslatingP2 = 4
	}

	/// <summary>
	/// Get the text actor
	/// </summary>
	public enum RestrictNone_WrapperEnum
	{
		/// <summary>enum member</summary>
		RestrictNone,
		/// <summary>enum member</summary>
		RestrictToX,
		/// <summary>enum member</summary>
		RestrictToY,
		/// <summary>enum member</summary>
		RestrictToZ
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLineRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLineRepresentation()
	{
		MRClassNameKey = "class vtkLineRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLineRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkLineRepresentation New()
	{
		vtkLineRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkLineRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLineRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLineRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkLineRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkLineRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_DirectionalLineOff_03(HandleRef pThis);

	/// <summary>
	/// Sets the representation to be a directional line with point 1 represented
	/// as a cone.
	/// </summary>
	public virtual void DirectionalLineOff()
	{
		vtkLineRepresentation_DirectionalLineOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_DirectionalLineOn_04(HandleRef pThis);

	/// <summary>
	/// Sets the representation to be a directional line with point 1 represented
	/// as a cone.
	/// </summary>
	public virtual void DirectionalLineOn()
	{
		vtkLineRepresentation_DirectionalLineOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_DistanceAnnotationVisibilityOff_05(HandleRef pThis);

	/// <summary>
	/// Show the distance between the points.
	/// </summary>
	public virtual void DistanceAnnotationVisibilityOff()
	{
		vtkLineRepresentation_DistanceAnnotationVisibilityOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_DistanceAnnotationVisibilityOn_06(HandleRef pThis);

	/// <summary>
	/// Show the distance between the points.
	/// </summary>
	public virtual void DistanceAnnotationVisibilityOn()
	{
		vtkLineRepresentation_DistanceAnnotationVisibilityOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_GetActors_07(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void GetActors(vtkPropCollection pc)
	{
		vtkLineRepresentation_GetActors_07(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetBounds_08(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkLineRepresentation_GetBounds_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLineRepresentation_GetDirectionalLine_09(HandleRef pThis);

	/// <summary>
	/// Sets the representation to be a directional line with point 1 represented
	/// as a cone.
	/// </summary>
	public virtual bool GetDirectionalLine()
	{
		return (vtkLineRepresentation_GetDirectionalLine_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLineRepresentation_GetDistance_10(HandleRef pThis);

	/// <summary>
	/// Get the distance between the points.
	/// </summary>
	public double GetDistance()
	{
		return vtkLineRepresentation_GetDistance_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetDistanceAnnotationFormat_11(HandleRef pThis);

	/// <summary>
	/// Specify the format to use for labelling the line. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the angle value.
	/// </summary>
	public virtual string GetDistanceAnnotationFormat()
	{
		return Marshal.PtrToStringAnsi(vtkLineRepresentation_GetDistanceAnnotationFormat_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetDistanceAnnotationProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the distance annotation property
	/// </summary>
	public virtual vtkProperty GetDistanceAnnotationProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_GetDistanceAnnotationProperty_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLineRepresentation_GetDistanceAnnotationScale_13(HandleRef pThis);

	/// <summary>
	/// Scale text (font size along each dimension).
	/// </summary>
	public virtual IntPtr GetDistanceAnnotationScale()
	{
		return vtkLineRepresentation_GetDistanceAnnotationScale_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_GetDistanceAnnotationVisibility_14(HandleRef pThis);

	/// <summary>
	/// Show the distance between the points.
	/// </summary>
	public virtual int GetDistanceAnnotationVisibility()
	{
		return vtkLineRepresentation_GetDistanceAnnotationVisibility_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetEndPoint2Property_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the end-point (sphere) properties. The properties of the end-points
	/// when selected and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetEndPoint2Property()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_GetEndPoint2Property_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLineRepresentation_GetEndPointProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the end-point (sphere) properties. The properties of the end-points
	/// when selected and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetEndPointProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_GetEndPointProperty_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkLineRepresentation_GetInteractionStateMaxValue_17(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., vtkLineWidget2) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// process with the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public virtual int GetInteractionStateMaxValue()
	{
		return vtkLineRepresentation_GetInteractionStateMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_GetInteractionStateMinValue_18(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., vtkLineWidget2) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// process with the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public virtual int GetInteractionStateMinValue()
	{
		return vtkLineRepresentation_GetInteractionStateMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetLineHandleRepresentation_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the three handle representations used for the vtkLineWidget2.
	/// </summary>
	public virtual vtkPointHandleRepresentation3D GetLineHandleRepresentation()
	{
		vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_GetLineHandleRepresentation_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointHandleRepresentation3D2 = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointHandleRepresentation3D2.Register(null);
			}
		}
		return vtkPointHandleRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetLineProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_GetLineProperty_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkLineRepresentation_GetMTime_21(HandleRef pThis);

	/// <summary>
	/// Overload the superclasses' GetMTime() because internal classes
	/// are used to keep the state of the representation.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkLineRepresentation_GetMTime_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLineRepresentation_GetNumberOfGenerationsFromBase_22(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLineRepresentation_GetNumberOfGenerationsFromBase_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLineRepresentation_GetNumberOfGenerationsFromBaseType_23(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLineRepresentation_GetNumberOfGenerationsFromBaseType_23(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_GetPoint1DisplayPosition_24(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void GetPoint1DisplayPosition(IntPtr pos)
	{
		vtkLineRepresentation_GetPoint1DisplayPosition_24(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetPoint1DisplayPosition_25(HandleRef pThis);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public double[] GetPoint1DisplayPosition()
	{
		IntPtr intPtr = vtkLineRepresentation_GetPoint1DisplayPosition_25(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetPoint1Representation_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the three handle representations used for the vtkLineWidget2.
	/// </summary>
	public virtual vtkPointHandleRepresentation3D GetPoint1Representation()
	{
		vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_GetPoint1Representation_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointHandleRepresentation3D2 = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointHandleRepresentation3D2.Register(null);
			}
		}
		return vtkPointHandleRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_GetPoint1WorldPosition_27(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void GetPoint1WorldPosition(IntPtr pos)
	{
		vtkLineRepresentation_GetPoint1WorldPosition_27(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetPoint1WorldPosition_28(HandleRef pThis);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public double[] GetPoint1WorldPosition()
	{
		IntPtr intPtr = vtkLineRepresentation_GetPoint1WorldPosition_28(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_GetPoint2DisplayPosition_29(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void GetPoint2DisplayPosition(IntPtr pos)
	{
		vtkLineRepresentation_GetPoint2DisplayPosition_29(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetPoint2DisplayPosition_30(HandleRef pThis);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public double[] GetPoint2DisplayPosition()
	{
		IntPtr intPtr = vtkLineRepresentation_GetPoint2DisplayPosition_30(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetPoint2Representation_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the three handle representations used for the vtkLineWidget2.
	/// </summary>
	public virtual vtkPointHandleRepresentation3D GetPoint2Representation()
	{
		vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_GetPoint2Representation_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointHandleRepresentation3D2 = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointHandleRepresentation3D2.Register(null);
			}
		}
		return vtkPointHandleRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_GetPoint2WorldPosition_32(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void GetPoint2WorldPosition(IntPtr pos)
	{
		vtkLineRepresentation_GetPoint2WorldPosition_32(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetPoint2WorldPosition_33(HandleRef pThis);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public double[] GetPoint2WorldPosition()
	{
		IntPtr intPtr = vtkLineRepresentation_GetPoint2WorldPosition_33(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_GetPolyData_34(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Retrieve the polydata (including points) that defines the line.  The
	/// polydata consists of n+1 points, where n is the resolution of the
	/// line. These point values are guaranteed to be up-to-date whenever any
	/// one of the three handles are moved. To use this method, the user
	/// provides the vtkPolyData as an input argument, and the points and
	/// polyline are copied into it.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkLineRepresentation_GetPolyData_34(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_GetRepresentationState_35(HandleRef pThis);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual int GetRepresentationState()
	{
		return vtkLineRepresentation_GetRepresentationState_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_GetResolution_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution (number of subdivisions) of the line. A line with
	/// resolution greater than one is useful when points along the line are
	/// desired; e.g., generating a rake of streamlines.
	/// </summary>
	public int GetResolution()
	{
		return vtkLineRepresentation_GetResolution_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_GetSelectedEndPoint2Property_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the end-point (sphere) properties. The properties of the end-points
	/// when selected and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedEndPoint2Property()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_GetSelectedEndPoint2Property_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLineRepresentation_GetSelectedEndPointProperty_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the end-point (sphere) properties. The properties of the end-points
	/// when selected and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedEndPointProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_GetSelectedEndPointProperty_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLineRepresentation_GetSelectedLineProperty_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_GetSelectedLineProperty_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLineRepresentation_GetTextActor_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the text actor
	/// </summary>
	public virtual vtkFollower GetTextActor()
	{
		vtkFollower vtkFollower2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_GetTextActor_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFollower2 = (vtkFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFollower2.Register(null);
			}
		}
		return vtkFollower2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_GetTolerance_41(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the line or end point
	/// to be active.
	/// </summary>
	public virtual int GetTolerance()
	{
		return vtkLineRepresentation_GetTolerance_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_GetToleranceMaxValue_42(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the line or end point
	/// to be active.
	/// </summary>
	public virtual int GetToleranceMaxValue()
	{
		return vtkLineRepresentation_GetToleranceMaxValue_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_GetToleranceMinValue_43(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the line or end point
	/// to be active.
	/// </summary>
	public virtual int GetToleranceMinValue()
	{
		return vtkLineRepresentation_GetToleranceMinValue_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_HasTranslucentPolygonalGeometry_44(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkLineRepresentation_HasTranslucentPolygonalGeometry_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_InstantiateHandleRepresentation_45(HandleRef pThis);

	/// <summary>
	/// This method is used to specify the type of handle representation to
	/// use for the three internal vtkHandleWidgets within vtkLineWidget2.
	/// To use this method, create a dummy vtkHandleWidget (or subclass),
	/// and then invoke this method with this dummy. Then the
	/// vtkLineRepresentation uses this dummy to clone three vtkHandleWidgets
	/// of the same type. Make sure you set the handle representation before
	/// the widget is enabled. (The method InstantiateHandleRepresentation()
	/// is invoked by the vtkLineWidget2.)
	/// </summary>
	public void InstantiateHandleRepresentation()
	{
		vtkLineRepresentation_InstantiateHandleRepresentation_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_IsA_46(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLineRepresentation_IsA_46(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_IsTypeOf_47(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLineRepresentation_IsTypeOf_47(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkLineRepresentation NewInstance()
	{
		vtkLineRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_NewInstance_49(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_PlaceWidget_50(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkLineRepresentation_PlaceWidget_50(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_ReleaseGraphicsResources_51(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkLineRepresentation_ReleaseGraphicsResources_51(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_RenderOpaqueGeometry_52(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkLineRepresentation_RenderOpaqueGeometry_52(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineRepresentation_RenderTranslucentPolygonalGeometry_53(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkLineRepresentation_RenderTranslucentPolygonalGeometry_53(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineRepresentation_SafeDownCast_54(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkLineRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkLineRepresentation vtkLineRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineRepresentation_SafeDownCast_54(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLineRepresentation2 = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLineRepresentation2.Register(null);
			}
		}
		return vtkLineRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetDirectionalLine_55(HandleRef pThis, byte val);

	/// <summary>
	/// Sets the representation to be a directional line with point 1 represented
	/// as a cone.
	/// </summary>
	public void SetDirectionalLine(bool val)
	{
		vtkLineRepresentation_SetDirectionalLine_55(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetDistanceAnnotationFormat_56(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the format to use for labelling the line. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the angle value.
	/// </summary>
	public virtual void SetDistanceAnnotationFormat(string _arg)
	{
		vtkLineRepresentation_SetDistanceAnnotationFormat_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetDistanceAnnotationScale_57(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Scale text (font size along each dimension).
	/// </summary>
	public void SetDistanceAnnotationScale(double x, double y, double z)
	{
		vtkLineRepresentation_SetDistanceAnnotationScale_57(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetDistanceAnnotationScale_58(HandleRef pThis, IntPtr scale);

	/// <summary>
	/// Scale text (font size along each dimension).
	/// </summary>
	public virtual void SetDistanceAnnotationScale(IntPtr scale)
	{
		vtkLineRepresentation_SetDistanceAnnotationScale_58(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetDistanceAnnotationVisibility_59(HandleRef pThis, int _arg);

	/// <summary>
	/// Show the distance between the points.
	/// </summary>
	public virtual void SetDistanceAnnotationVisibility(int _arg)
	{
		vtkLineRepresentation_SetDistanceAnnotationVisibility_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetHandleRepresentation_60(HandleRef pThis, HandleRef handle);

	/// <summary>
	/// This method is used to specify the type of handle representation to
	/// use for the three internal vtkHandleWidgets within vtkLineWidget2.
	/// To use this method, create a dummy vtkHandleWidget (or subclass),
	/// and then invoke this method with this dummy. Then the
	/// vtkLineRepresentation uses this dummy to clone three vtkHandleWidgets
	/// of the same type. Make sure you set the handle representation before
	/// the widget is enabled. (The method InstantiateHandleRepresentation()
	/// is invoked by the vtkLineWidget2.)
	/// </summary>
	public void SetHandleRepresentation(vtkPointHandleRepresentation3D handle)
	{
		vtkLineRepresentation_SetHandleRepresentation_60(GetCppThis(), handle?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetInteractionState_61(HandleRef pThis, int _arg);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., vtkLineWidget2) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// process with the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkLineRepresentation_SetInteractionState_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetLineColor_62(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Convenience method to set the line color.
	/// Ideally one should use GetLineProperty()-&gt;SetColor().
	/// </summary>
	public void SetLineColor(double r, double g, double b)
	{
		vtkLineRepresentation_SetLineColor_62(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetPoint1DisplayPosition_63(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void SetPoint1DisplayPosition(IntPtr pos)
	{
		vtkLineRepresentation_SetPoint1DisplayPosition_63(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetPoint1WorldPosition_64(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void SetPoint1WorldPosition(IntPtr pos)
	{
		vtkLineRepresentation_SetPoint1WorldPosition_64(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetPoint2DisplayPosition_65(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void SetPoint2DisplayPosition(IntPtr pos)
	{
		vtkLineRepresentation_SetPoint2DisplayPosition_65(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetPoint2WorldPosition_66(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void SetPoint2WorldPosition(IntPtr pos)
	{
		vtkLineRepresentation_SetPoint2WorldPosition_66(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetRenderer_67(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Overridden to set the rendererer on the internal representations.
	/// </summary>
	public override void SetRenderer(vtkRenderer ren)
	{
		vtkLineRepresentation_SetRenderer_67(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetRepresentationState_68(HandleRef pThis, int arg0);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual void SetRepresentationState(int arg0)
	{
		vtkLineRepresentation_SetRepresentationState_68(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetResolution_69(HandleRef pThis, int res);

	/// <summary>
	/// Set/Get the resolution (number of subdivisions) of the line. A line with
	/// resolution greater than one is useful when points along the line are
	/// desired; e.g., generating a rake of streamlines.
	/// </summary>
	public void SetResolution(int res)
	{
		vtkLineRepresentation_SetResolution_69(GetCppThis(), res);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_SetTolerance_70(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the line or end point
	/// to be active.
	/// </summary>
	public virtual void SetTolerance(int _arg)
	{
		vtkLineRepresentation_SetTolerance_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_StartWidgetInteraction_71(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr e)
	{
		vtkLineRepresentation_StartWidgetInteraction_71(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineRepresentation_WidgetInteraction_72(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkLineRepresentation_WidgetInteraction_72(GetCppThis(), e);
	}
}
