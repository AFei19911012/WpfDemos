using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCameraOrientationRepresentation
/// </summary>
/// <remarks>
///    A 3D representation for vtkCameraOrientationWidget.
///
/// Hover over the representation and drag with LMB to orbit around the view.
/// Clicking on one of the axis labels will snap to that view.
/// Click again on the same axis to switch to the opposite view of that same axis.
///
/// The representation anchors itself to a corner of the renderer's
/// viewport. See AnchorType.
///
/// </remarks>
/// <seealso>
///
/// vtkCameraOrientationWidget
///
/// </seealso>
public class vtkCameraOrientationRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Get/Set the widget padding in display coordinates.
	/// </summary>
	public enum AnchorType
	{
		/// <summary>enum member</summary>
		LowerLeft = 0,
		/// <summary>enum member</summary>
		LowerRight = 2,
		/// <summary>enum member</summary>
		UpperLeft = 1,
		/// <summary>enum member</summary>
		UpperRight = 3
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		Hovering = 1,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		Rotating = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCameraOrientationRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCameraOrientationRepresentation()
	{
		MRClassNameKey = "class vtkCameraOrientationRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraOrientationRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCameraOrientationRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCameraOrientationRepresentation New()
	{
		vtkCameraOrientationRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraOrientationRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCameraOrientationRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCameraOrientationRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCameraOrientationRepresentation_AnchorToLowerLeft_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the widget anchor type
	/// </summary>
	public void AnchorToLowerLeft()
	{
		vtkCameraOrientationRepresentation_AnchorToLowerLeft_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_AnchorToLowerRight_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the widget anchor type
	/// </summary>
	public void AnchorToLowerRight()
	{
		vtkCameraOrientationRepresentation_AnchorToLowerRight_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_AnchorToUpperLeft_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the widget anchor type
	/// </summary>
	public void AnchorToUpperLeft()
	{
		vtkCameraOrientationRepresentation_AnchorToUpperLeft_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_AnchorToUpperRight_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the widget anchor type
	/// </summary>
	public void AnchorToUpperRight()
	{
		vtkCameraOrientationRepresentation_AnchorToUpperRight_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_ApplyInteractionState_05(HandleRef pThis, ref int state);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., vtkCameraOrientationWidget) or
	/// other object. This call updates the representation to match the interaction state.
	/// </summary>
	public void ApplyInteractionState(ref int state)
	{
		vtkCameraOrientationRepresentation_ApplyInteractionState_05(GetCppThis(), ref state);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_BuildRepresentation_06(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkCameraOrientationRepresentation_BuildRepresentation_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_ComputeInteractionState_07(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkCameraOrientationRepresentation_ComputeInteractionState_07(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_ContainerVisibilityOff_08(HandleRef pThis);

	/// <summary>
	/// Show container to indicate mouse presence.
	/// </summary>
	public virtual void ContainerVisibilityOff()
	{
		vtkCameraOrientationRepresentation_ContainerVisibilityOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_ContainerVisibilityOn_09(HandleRef pThis);

	/// <summary>
	/// Show container to indicate mouse presence.
	/// </summary>
	public virtual void ContainerVisibilityOn()
	{
		vtkCameraOrientationRepresentation_ContainerVisibilityOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_EndWidgetInteraction_10(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void EndWidgetInteraction(IntPtr newEventPos)
	{
		vtkCameraOrientationRepresentation_EndWidgetInteraction_10(GetCppThis(), newEventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_GetActors_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkCameraOrientationRepresentation_GetActors_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern AnchorType vtkCameraOrientationRepresentation_GetAnchorPosition_12(HandleRef pThis);

	/// <summary>
	/// Get/Set the widget anchor type
	/// </summary>
	public AnchorType GetAnchorPosition()
	{
		return vtkCameraOrientationRepresentation_GetAnchorPosition_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCameraOrientationRepresentation_GetAzimuth_13(HandleRef pThis);

	/// <summary>
	/// Orientation properties. (read only)
	/// </summary>
	public virtual double GetAzimuth()
	{
		return vtkCameraOrientationRepresentation_GetAzimuth_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetBack_14(HandleRef pThis);

	/// <summary>
	/// Orientation properties. (read only)
	/// </summary>
	public virtual double[] GetBack()
	{
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetBack_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_GetBack_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Orientation properties. (read only)
	/// </summary>
	public virtual void GetBack(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCameraOrientationRepresentation_GetBack_15(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_GetBack_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Orientation properties. (read only)
	/// </summary>
	public virtual void GetBack(IntPtr _arg)
	{
		vtkCameraOrientationRepresentation_GetBack_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetBounds_17(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetBounds_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetContainerCircumferentialResolution_18(HandleRef pThis);

	/// <summary>
	/// Set container's circumferential resolution.
	/// </summary>
	public virtual int GetContainerCircumferentialResolution()
	{
		return vtkCameraOrientationRepresentation_GetContainerCircumferentialResolution_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetContainerCircumferentialResolutionMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set container's circumferential resolution.
	/// </summary>
	public virtual int GetContainerCircumferentialResolutionMaxValue()
	{
		return vtkCameraOrientationRepresentation_GetContainerCircumferentialResolutionMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetContainerCircumferentialResolutionMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set container's circumferential resolution.
	/// </summary>
	public virtual int GetContainerCircumferentialResolutionMinValue()
	{
		return vtkCameraOrientationRepresentation_GetContainerCircumferentialResolutionMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetContainerProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the container property.
	/// </summary>
	public vtkProperty GetContainerProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetContainerProperty_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCameraOrientationRepresentation_GetContainerRadialResolution_22(HandleRef pThis);

	/// <summary>
	/// Set container's radial resolution.
	/// </summary>
	public virtual int GetContainerRadialResolution()
	{
		return vtkCameraOrientationRepresentation_GetContainerRadialResolution_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetContainerRadialResolutionMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set container's radial resolution.
	/// </summary>
	public virtual int GetContainerRadialResolutionMaxValue()
	{
		return vtkCameraOrientationRepresentation_GetContainerRadialResolutionMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetContainerRadialResolutionMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set container's radial resolution.
	/// </summary>
	public virtual int GetContainerRadialResolutionMinValue()
	{
		return vtkCameraOrientationRepresentation_GetContainerRadialResolutionMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCameraOrientationRepresentation_GetContainerVisibility_25(HandleRef pThis);

	/// <summary>
	/// Show container to indicate mouse presence.
	/// </summary>
	public bool GetContainerVisibility()
	{
		return (vtkCameraOrientationRepresentation_GetContainerVisibility_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCameraOrientationRepresentation_GetElevation_26(HandleRef pThis);

	/// <summary>
	/// Orientation properties. (read only)
	/// </summary>
	public virtual double GetElevation()
	{
		return vtkCameraOrientationRepresentation_GetElevation_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetHandleCircumferentialResolution_27(HandleRef pThis);

	/// <summary>
	/// Set Handle's circumferential resolution.
	/// </summary>
	public virtual int GetHandleCircumferentialResolution()
	{
		return vtkCameraOrientationRepresentation_GetHandleCircumferentialResolution_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetHandleCircumferentialResolutionMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Set Handle's circumferential resolution.
	/// </summary>
	public virtual int GetHandleCircumferentialResolutionMaxValue()
	{
		return vtkCameraOrientationRepresentation_GetHandleCircumferentialResolutionMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetHandleCircumferentialResolutionMinValue_29(HandleRef pThis);

	/// <summary>
	/// Set Handle's circumferential resolution.
	/// </summary>
	public virtual int GetHandleCircumferentialResolutionMinValue()
	{
		return vtkCameraOrientationRepresentation_GetHandleCircumferentialResolutionMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern InteractionStateType vtkCameraOrientationRepresentation_GetInteractionStateAsEnum_30(HandleRef pThis);

	/// <summary>
	/// Convenient method to get InteractionState as enum.
	/// This method clamps the interaction state to possible values.
	/// Hence, it does not raise any exceptions.
	/// </summary>
	public InteractionStateType GetInteractionStateAsEnum()
	{
		return vtkCameraOrientationRepresentation_GetInteractionStateAsEnum_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCameraOrientationRepresentation_GetNormalizedHandleDia_31(HandleRef pThis);

	/// <summary>
	/// Set the normalized (0-1) diameter of the Handle.
	/// Default value: 0.4
	/// </summary>
	public virtual double GetNormalizedHandleDia()
	{
		return vtkCameraOrientationRepresentation_GetNormalizedHandleDia_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraOrientationRepresentation_GetNumberOfGenerationsFromBase_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCameraOrientationRepresentation_GetNumberOfGenerationsFromBase_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraOrientationRepresentation_GetNumberOfGenerationsFromBaseType_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCameraOrientationRepresentation_GetNumberOfGenerationsFromBaseType_33(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetPadding_34(HandleRef pThis);

	/// <summary>
	/// Get/Set the widget padding in display coordinates.
	/// </summary>
	public virtual int[] GetPadding()
	{
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetPadding_34(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_GetPadding_35(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get/Set the widget padding in display coordinates.
	/// </summary>
	public virtual void GetPadding(ref int _arg1, ref int _arg2)
	{
		vtkCameraOrientationRepresentation_GetPadding_35(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_GetPadding_36(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the widget padding in display coordinates.
	/// </summary>
	public virtual void GetPadding(IntPtr _arg)
	{
		vtkCameraOrientationRepresentation_GetPadding_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetPickedAxis_37(HandleRef pThis);

	/// <summary>
	/// Get picked axis, direction
	/// </summary>
	public virtual int GetPickedAxis()
	{
		return vtkCameraOrientationRepresentation_GetPickedAxis_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetPickedDir_38(HandleRef pThis);

	/// <summary>
	/// Get picked axis, direction
	/// </summary>
	public virtual int GetPickedDir()
	{
		return vtkCameraOrientationRepresentation_GetPickedDir_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetShaftResolution_39(HandleRef pThis);

	/// <summary>
	/// Set shaft's resolution.
	/// </summary>
	public virtual int GetShaftResolution()
	{
		return vtkCameraOrientationRepresentation_GetShaftResolution_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetShaftResolutionMaxValue_40(HandleRef pThis);

	/// <summary>
	/// Set shaft's resolution.
	/// </summary>
	public virtual int GetShaftResolutionMaxValue()
	{
		return vtkCameraOrientationRepresentation_GetShaftResolutionMaxValue_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_GetShaftResolutionMinValue_41(HandleRef pThis);

	/// <summary>
	/// Set shaft's resolution.
	/// </summary>
	public virtual int GetShaftResolutionMinValue()
	{
		return vtkCameraOrientationRepresentation_GetShaftResolutionMinValue_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetSize_42(HandleRef pThis);

	/// <summary>
	/// Get/Set the widget size in display coordinates.
	/// </summary>
	public virtual int[] GetSize()
	{
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetSize_42(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_GetSize_43(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get/Set the widget size in display coordinates.
	/// </summary>
	public virtual void GetSize(ref int _arg1, ref int _arg2)
	{
		vtkCameraOrientationRepresentation_GetSize_43(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_GetSize_44(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the widget size in display coordinates.
	/// </summary>
	public virtual void GetSize(IntPtr _arg)
	{
		vtkCameraOrientationRepresentation_GetSize_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCameraOrientationRepresentation_GetTotalLength_45(HandleRef pThis);

	/// <summary>
	/// Set the total length of the axes in 3 dimensions.
	/// This is basis of normalization. Default value: 1.
	/// </summary>
	public virtual double GetTotalLength()
	{
		return vtkCameraOrientationRepresentation_GetTotalLength_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetTransform_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve internal transform of this widget representation.
	/// </summary>
	public vtkTransform GetTransform()
	{
		vtkTransform vtkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetTransform_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2 = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2.Register(null);
			}
		}
		return vtkTransform2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetUp_47(HandleRef pThis);

	/// <summary>
	/// Orientation properties. (read only)
	/// </summary>
	public virtual double[] GetUp()
	{
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetUp_47(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_GetUp_48(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Orientation properties. (read only)
	/// </summary>
	public virtual void GetUp(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCameraOrientationRepresentation_GetUp_48(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_GetUp_49(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Orientation properties. (read only)
	/// </summary>
	public virtual void GetUp(IntPtr _arg)
	{
		vtkCameraOrientationRepresentation_GetUp_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetXMinusLabelProperty_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the '-' axis label properties.
	/// </summary>
	public vtkTextProperty GetXMinusLabelProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetXMinusLabelProperty_50(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetXPlusLabelProperty_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the '+' axis label properties.
	/// </summary>
	public vtkTextProperty GetXPlusLabelProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetXPlusLabelProperty_51(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetYMinusLabelProperty_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the '-' axis label properties.
	/// </summary>
	public vtkTextProperty GetYMinusLabelProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetYMinusLabelProperty_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetYPlusLabelProperty_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the '+' axis label properties.
	/// </summary>
	public vtkTextProperty GetYPlusLabelProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetYPlusLabelProperty_53(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetZMinusLabelProperty_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the '-' axis label properties.
	/// </summary>
	public vtkTextProperty GetZMinusLabelProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetZMinusLabelProperty_54(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_GetZPlusLabelProperty_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the '+' axis label properties.
	/// </summary>
	public vtkTextProperty GetZPlusLabelProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationRepresentation_GetZPlusLabelProperty_55(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_HasTranslucentPolygonalGeometry_56(HandleRef pThis);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkCameraOrientationRepresentation_HasTranslucentPolygonalGeometry_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_IsA_57(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCameraOrientationRepresentation_IsA_57(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCameraOrientationRepresentation_IsAnyHandleSelected_58(HandleRef pThis);

	/// <summary>
	/// Is a grabber button picked.
	/// </summary>
	public bool IsAnyHandleSelected()
	{
		return (vtkCameraOrientationRepresentation_IsAnyHandleSelected_58(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_IsTypeOf_59(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCameraOrientationRepresentation_IsTypeOf_59(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_NewInstance_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCameraOrientationRepresentation NewInstance()
	{
		vtkCameraOrientationRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationRepresentation_NewInstance_61(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraOrientationRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_PlaceWidget_62(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void PlaceWidget(IntPtr arg0)
	{
		vtkCameraOrientationRepresentation_PlaceWidget_62(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_ReleaseGraphicsResources_63(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkCameraOrientationRepresentation_ReleaseGraphicsResources_63(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_RenderOpaqueGeometry_64(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkCameraOrientationRepresentation_RenderOpaqueGeometry_64(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationRepresentation_RenderTranslucentPolygonalGeometry_65(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkCameraOrientationRepresentation_RenderTranslucentPolygonalGeometry_65(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationRepresentation_SafeDownCast_66(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCameraOrientationRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkCameraOrientationRepresentation vtkCameraOrientationRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationRepresentation_SafeDownCast_66(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCameraOrientationRepresentation2 = (vtkCameraOrientationRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCameraOrientationRepresentation2.Register(null);
			}
		}
		return vtkCameraOrientationRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_SetContainerCircumferentialResolution_67(HandleRef pThis, int _arg);

	/// <summary>
	/// Set container's circumferential resolution.
	/// </summary>
	public virtual void SetContainerCircumferentialResolution(int _arg)
	{
		vtkCameraOrientationRepresentation_SetContainerCircumferentialResolution_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_SetContainerRadialResolution_68(HandleRef pThis, int _arg);

	/// <summary>
	/// Set container's radial resolution.
	/// </summary>
	public virtual void SetContainerRadialResolution(int _arg)
	{
		vtkCameraOrientationRepresentation_SetContainerRadialResolution_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_SetContainerVisibility_69(HandleRef pThis, byte state);

	/// <summary>
	/// Show container to indicate mouse presence.
	/// </summary>
	public void SetContainerVisibility(bool state)
	{
		vtkCameraOrientationRepresentation_SetContainerVisibility_69(GetCppThis(), (byte)(state ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_SetHandleCircumferentialResolution_70(HandleRef pThis, int _arg);

	/// <summary>
	/// Set Handle's circumferential resolution.
	/// </summary>
	public virtual void SetHandleCircumferentialResolution(int _arg)
	{
		vtkCameraOrientationRepresentation_SetHandleCircumferentialResolution_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_SetNormalizedHandleDia_71(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the normalized (0-1) diameter of the Handle.
	/// Default value: 0.4
	/// </summary>
	public virtual void SetNormalizedHandleDia(double _arg)
	{
		vtkCameraOrientationRepresentation_SetNormalizedHandleDia_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_SetPadding_72(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Get/Set the widget padding in display coordinates.
	/// </summary>
	public virtual void SetPadding(int _arg1, int _arg2)
	{
		vtkCameraOrientationRepresentation_SetPadding_72(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_SetPadding_73(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the widget padding in display coordinates.
	/// </summary>
	public void SetPadding(IntPtr _arg)
	{
		vtkCameraOrientationRepresentation_SetPadding_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_SetShaftResolution_74(HandleRef pThis, int _arg);

	/// <summary>
	/// Set shaft's resolution.
	/// </summary>
	public virtual void SetShaftResolution(int _arg)
	{
		vtkCameraOrientationRepresentation_SetShaftResolution_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_SetSize_75(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Get/Set the widget size in display coordinates.
	/// </summary>
	public virtual void SetSize(int _arg1, int _arg2)
	{
		vtkCameraOrientationRepresentation_SetSize_75(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_SetSize_76(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the widget size in display coordinates.
	/// </summary>
	public void SetSize(IntPtr _arg)
	{
		vtkCameraOrientationRepresentation_SetSize_76(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_SetTotalLength_77(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the total length of the axes in 3 dimensions.
	/// This is basis of normalization. Default value: 1.
	/// </summary>
	public virtual void SetTotalLength(double _arg)
	{
		vtkCameraOrientationRepresentation_SetTotalLength_77(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_ShallowCopy_78(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of an axes actor. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkCameraOrientationRepresentation_ShallowCopy_78(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_StartWidgetInteraction_79(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkCameraOrientationRepresentation_StartWidgetInteraction_79(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationRepresentation_WidgetInteraction_80(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void WidgetInteraction(IntPtr newEventPos)
	{
		vtkCameraOrientationRepresentation_WidgetInteraction_80(GetCppThis(), newEventPos);
	}
}
