using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAxesTransformRepresentation
/// </summary>
/// <remarks>
///    represent the vtkAxesTransformWidget
///
/// The vtkAxesTransformRepresentation is a representation for the
/// vtkAxesTransformWidget. This representation consists of a origin sphere
/// with three tubed axes with cones at the end of the axes. In addition an
/// optional label provides delta values of motion. Note that this particular
/// widget draws its representation in 3D space, so the widget can be
/// occluded.
/// </remarks>
/// <seealso>
///
/// vtkDistanceWidget vtkDistanceRepresentation vtkDistanceRepresentation2D
/// </seealso>
public class vtkAxesTransformRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Enum used to communicate interaction state.
	/// </summary>
	public enum OnOrigin_WrapperEnum
	{
		/// <summary>enum member</summary>
		OnOrigin = 1,
		/// <summary>enum member</summary>
		OnX = 2,
		/// <summary>enum member</summary>
		OnXEnd = 5,
		/// <summary>enum member</summary>
		OnY = 3,
		/// <summary>enum member</summary>
		OnYEnd = 6,
		/// <summary>enum member</summary>
		OnZ = 4,
		/// <summary>enum member</summary>
		OnZEnd = 7,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAxesTransformRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAxesTransformRepresentation()
	{
		MRClassNameKey = "class vtkAxesTransformRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxesTransformRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAxesTransformRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesTransformRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public new static vtkAxesTransformRepresentation New()
	{
		vtkAxesTransformRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesTransformRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxesTransformRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public vtkAxesTransformRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAxesTransformRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAxesTransformRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkAxesTransformRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesTransformRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkAxesTransformRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesTransformRepresentation_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkAxesTransformRepresentation_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesTransformRepresentation_GetInteractionStateMaxValue_04(HandleRef pThis);

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
		return vtkAxesTransformRepresentation_GetInteractionStateMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesTransformRepresentation_GetInteractionStateMinValue_05(HandleRef pThis);

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
		return vtkAxesTransformRepresentation_GetInteractionStateMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesTransformRepresentation_GetLabelFormat_06(HandleRef pThis);

	/// <summary>
	/// Specify the format to use for labelling information during
	/// transformation. Note that an empty string results in no label, or a
	/// format string without a "%" character will not print numeric values.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkAxesTransformRepresentation_GetLabelFormat_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesTransformRepresentation_GetLabelProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the distance annotation property
	/// </summary>
	public virtual vtkProperty GetLabelProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesTransformRepresentation_GetLabelProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAxesTransformRepresentation_GetLabelScale_08(HandleRef pThis);

	/// <summary>
	/// Scale text (font size along each dimension). This helps control
	/// the appearance of the 3D text.
	/// </summary>
	public virtual IntPtr GetLabelScale()
	{
		return vtkAxesTransformRepresentation_GetLabelScale_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxesTransformRepresentation_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAxesTransformRepresentation_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxesTransformRepresentation_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAxesTransformRepresentation_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_GetOriginDisplayPosition_11(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void GetOriginDisplayPosition(IntPtr pos)
	{
		vtkAxesTransformRepresentation_GetOriginDisplayPosition_11(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesTransformRepresentation_GetOriginRepresentation_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the two handle representations used for the
	/// vtkAxesTransformWidget. (Note: properties can be set by grabbing these
	/// representations and setting the properties appropriately.)
	/// </summary>
	public virtual vtkHandleRepresentation GetOriginRepresentation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesTransformRepresentation_GetOriginRepresentation_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAxesTransformRepresentation_GetOriginWorldPosition_13(HandleRef pThis);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public IntPtr GetOriginWorldPosition()
	{
		return vtkAxesTransformRepresentation_GetOriginWorldPosition_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_GetOriginWorldPosition_14(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void GetOriginWorldPosition(IntPtr pos)
	{
		vtkAxesTransformRepresentation_GetOriginWorldPosition_14(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesTransformRepresentation_GetSelectionRepresentation_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the two handle representations used for the
	/// vtkAxesTransformWidget. (Note: properties can be set by grabbing these
	/// representations and setting the properties appropriately.)
	/// </summary>
	public virtual vtkHandleRepresentation GetSelectionRepresentation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesTransformRepresentation_GetSelectionRepresentation_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkAxesTransformRepresentation_GetTolerance_16(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the end points of
	/// the widget to be active.
	/// </summary>
	public virtual int GetTolerance()
	{
		return vtkAxesTransformRepresentation_GetTolerance_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesTransformRepresentation_GetToleranceMaxValue_17(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the end points of
	/// the widget to be active.
	/// </summary>
	public virtual int GetToleranceMaxValue()
	{
		return vtkAxesTransformRepresentation_GetToleranceMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesTransformRepresentation_GetToleranceMinValue_18(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the end points of
	/// the widget to be active.
	/// </summary>
	public virtual int GetToleranceMinValue()
	{
		return vtkAxesTransformRepresentation_GetToleranceMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesTransformRepresentation_IsA_19(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAxesTransformRepresentation_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesTransformRepresentation_IsTypeOf_20(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAxesTransformRepresentation_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesTransformRepresentation_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkAxesTransformRepresentation NewInstance()
	{
		vtkAxesTransformRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesTransformRepresentation_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxesTransformRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_ReleaseGraphicsResources_23(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkAxesTransformRepresentation_ReleaseGraphicsResources_23(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesTransformRepresentation_RenderOpaqueGeometry_24(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkAxesTransformRepresentation_RenderOpaqueGeometry_24(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxesTransformRepresentation_RenderTranslucentPolygonalGeometry_25(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkAxesTransformRepresentation_RenderTranslucentPolygonalGeometry_25(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxesTransformRepresentation_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkAxesTransformRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkAxesTransformRepresentation vtkAxesTransformRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxesTransformRepresentation_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxesTransformRepresentation2 = (vtkAxesTransformRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxesTransformRepresentation2.Register(null);
			}
		}
		return vtkAxesTransformRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_SetInteractionState_27(HandleRef pThis, int _arg);

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
		vtkAxesTransformRepresentation_SetInteractionState_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_SetLabelFormat_28(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the format to use for labelling information during
	/// transformation. Note that an empty string results in no label, or a
	/// format string without a "%" character will not print numeric values.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkAxesTransformRepresentation_SetLabelFormat_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_SetLabelScale_29(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Scale text (font size along each dimension). This helps control
	/// the appearance of the 3D text.
	/// </summary>
	public void SetLabelScale(double x, double y, double z)
	{
		vtkAxesTransformRepresentation_SetLabelScale_29(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_SetLabelScale_30(HandleRef pThis, IntPtr scale);

	/// <summary>
	/// Scale text (font size along each dimension). This helps control
	/// the appearance of the 3D text.
	/// </summary>
	public virtual void SetLabelScale(IntPtr scale)
	{
		vtkAxesTransformRepresentation_SetLabelScale_30(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_SetOriginDisplayPosition_31(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void SetOriginDisplayPosition(IntPtr pos)
	{
		vtkAxesTransformRepresentation_SetOriginDisplayPosition_31(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_SetOriginWorldPosition_32(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public void SetOriginWorldPosition(IntPtr pos)
	{
		vtkAxesTransformRepresentation_SetOriginWorldPosition_32(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_SetTolerance_33(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the end points of
	/// the widget to be active.
	/// </summary>
	public virtual void SetTolerance(int _arg)
	{
		vtkAxesTransformRepresentation_SetTolerance_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_StartWidgetInteraction_34(HandleRef pThis, IntPtr e);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr e)
	{
		vtkAxesTransformRepresentation_StartWidgetInteraction_34(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxesTransformRepresentation_WidgetInteraction_35(HandleRef pThis, IntPtr e);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkAxesTransformRepresentation_WidgetInteraction_35(GetCppThis(), e);
	}
}
