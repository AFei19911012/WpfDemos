using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLightRepresentation
/// </summary>
/// <remarks>
///    represent a vtkLight
///
/// The vtkLightRepresentation is a representation for the vtkLight.
/// This representation consists of a LightPosition sphere with an automatically resized
/// radius so it is always visible, a line between the LightPosition and the FocalPoint and
/// a cone of angle ConeAngle when using Positional.
///
/// </remarks>
/// <seealso>
///
/// vtkLightWidget vtkSphereWidget vtkSphereRepresentation
/// </seealso>
public class vtkLightRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Enum used to communicate interaction state.
	/// </summary>
	public enum MovingFocalPoint_WrapperEnum
	{
		/// <summary>enum member</summary>
		MovingFocalPoint = 2,
		/// <summary>enum member</summary>
		MovingLight = 1,
		/// <summary>enum member</summary>
		MovingPositionalFocalPoint = 3,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		ScalingConeAngle = 4
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLightRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLightRepresentation()
	{
		MRClassNameKey = "class vtkLightRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLightRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLightRepresentation New()
	{
		vtkLightRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLightRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLightRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLightRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLightRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkLightRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLightRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkLightRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightRepresentation_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkLightRepresentation_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightRepresentation_GetConeAngle_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the cone angle, in degrees, for the light.
	/// Used only when positional.
	/// </summary>
	public virtual double GetConeAngle()
	{
		return vtkLightRepresentation_GetConeAngle_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightRepresentation_GetFocalPoint_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the coordinates of the focal point of the light representation.
	/// </summary>
	public virtual double[] GetFocalPoint()
	{
		IntPtr intPtr = vtkLightRepresentation_GetFocalPoint_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_GetFocalPoint_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the coordinates of the focal point of the light representation.
	/// </summary>
	public virtual void GetFocalPoint(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkLightRepresentation_GetFocalPoint_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_GetFocalPoint_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the coordinates of the focal point of the light representation.
	/// </summary>
	public virtual void GetFocalPoint(IntPtr _arg)
	{
		vtkLightRepresentation_GetFocalPoint_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLightRepresentation_GetInteractionStateMaxValue_08(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., vtkLightWidget) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// process with the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public virtual int GetInteractionStateMaxValue()
	{
		return vtkLightRepresentation_GetInteractionStateMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLightRepresentation_GetInteractionStateMinValue_09(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., vtkLightWidget) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// process with the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public virtual int GetInteractionStateMinValue()
	{
		return vtkLightRepresentation_GetInteractionStateMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightRepresentation_GetLightColor_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the light color.
	/// </summary>
	public IntPtr GetLightColor()
	{
		return vtkLightRepresentation_GetLightColor_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightRepresentation_GetLightPosition_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the coordinates of the position of the light representation.
	/// </summary>
	public virtual double[] GetLightPosition()
	{
		IntPtr intPtr = vtkLightRepresentation_GetLightPosition_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_GetLightPosition_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the coordinates of the position of the light representation.
	/// </summary>
	public virtual void GetLightPosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkLightRepresentation_GetLightPosition_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_GetLightPosition_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the coordinates of the position of the light representation.
	/// </summary>
	public virtual void GetLightPosition(IntPtr _arg)
	{
		vtkLightRepresentation_GetLightPosition_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLightRepresentation_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLightRepresentation_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLightRepresentation_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLightRepresentation_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLightRepresentation_GetPositional_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the positional flag. When set to on, a cone will be visible.
	/// </summary>
	public virtual bool GetPositional()
	{
		return (vtkLightRepresentation_GetPositional_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightRepresentation_GetProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property used for all the actors
	/// </summary>
	public virtual vtkProperty GetProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightRepresentation_GetProperty_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkLightRepresentation_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLightRepresentation_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLightRepresentation_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLightRepresentation_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightRepresentation_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLightRepresentation NewInstance()
	{
		vtkLightRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightRepresentation_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLightRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_PositionalOff_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the positional flag. When set to on, a cone will be visible.
	/// </summary>
	public virtual void PositionalOff()
	{
		vtkLightRepresentation_PositionalOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_PositionalOn_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the positional flag. When set to on, a cone will be visible.
	/// </summary>
	public virtual void PositionalOn()
	{
		vtkLightRepresentation_PositionalOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkLightRepresentation_ReleaseGraphicsResources_24(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLightRepresentation_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkLightRepresentation_RenderOpaqueGeometry_25(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLightRepresentation_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkLightRepresentation_RenderTranslucentPolygonalGeometry_26(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightRepresentation_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLightRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkLightRepresentation vtkLightRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightRepresentation_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLightRepresentation2 = (vtkLightRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLightRepresentation2.Register(null);
			}
		}
		return vtkLightRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_SetConeAngle_28(HandleRef pThis, double angle);

	/// <summary>
	/// Set/Get the cone angle, in degrees, for the light.
	/// Used only when positional.
	/// </summary>
	public void SetConeAngle(double angle)
	{
		vtkLightRepresentation_SetConeAngle_28(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_SetFocalPoint_29(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Set/Get the coordinates of the focal point of the light representation.
	/// </summary>
	public void SetFocalPoint(IntPtr pos)
	{
		vtkLightRepresentation_SetFocalPoint_29(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_SetInteractionState_30(HandleRef pThis, int _arg);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., vtkLightWidget) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// process with the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkLightRepresentation_SetInteractionState_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_SetLightColor_31(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Set/Get the light color.
	/// </summary>
	public void SetLightColor(IntPtr color)
	{
		vtkLightRepresentation_SetLightColor_31(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_SetLightPosition_32(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Set/Get the coordinates of the position of the light representation.
	/// </summary>
	public void SetLightPosition(IntPtr pos)
	{
		vtkLightRepresentation_SetLightPosition_32(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_SetPositional_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the positional flag. When set to on, a cone will be visible.
	/// </summary>
	public virtual void SetPositional(bool _arg)
	{
		vtkLightRepresentation_SetPositional_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_StartWidgetInteraction_34(HandleRef pThis, IntPtr eventPosition);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPosition)
	{
		vtkLightRepresentation_StartWidgetInteraction_34(GetCppThis(), eventPosition);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightRepresentation_WidgetInteraction_35(HandleRef pThis, IntPtr eventPosition);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPosition)
	{
		vtkLightRepresentation_WidgetInteraction_35(GetCppThis(), eventPosition);
	}
}
