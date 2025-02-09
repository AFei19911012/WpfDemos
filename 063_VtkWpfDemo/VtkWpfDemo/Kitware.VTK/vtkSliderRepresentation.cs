using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSliderRepresentation
/// </summary>
/// <remarks>
///    abstract class defines the representation for a vtkSliderWidget
///
/// This abstract class is used to specify how the vtkSliderWidget should
/// interact with representations of the vtkSliderWidget. This class may be
/// subclassed so that alternative representations can be created. The class
/// defines an API, and a default implementation, that the vtkSliderWidget
/// interacts with to render itself in the scene.
///
/// </remarks>
/// <seealso>
///
/// vtkSliderWidget
/// </seealso>
public abstract class vtkSliderRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Methods to interface with the vtkSliderWidget. Subclasses of this class
	/// actually do something.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		LeftCap = 2,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		RightCap = 3,
		/// <summary>enum member</summary>
		Slider = 4,
		/// <summary>enum member</summary>
		Tube = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSliderRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSliderRepresentation()
	{
		MRClassNameKey = "class vtkSliderRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliderRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSliderRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern double vtkSliderRepresentation_GetCurrentT_01(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. Subclasses of this class
	/// actually do something.
	/// </summary>
	public virtual double GetCurrentT()
	{
		return vtkSliderRepresentation_GetCurrentT_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetEndCapLength_02(HandleRef pThis);

	/// <summary>
	/// Specify the length of each end cap (in normalized coordinates
	/// [0.0,0.25]). By default the length is 0.025. If the end cap length
	/// is set to 0.0, then the end cap will not display at all.
	/// </summary>
	public virtual double GetEndCapLength()
	{
		return vtkSliderRepresentation_GetEndCapLength_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetEndCapLengthMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Specify the length of each end cap (in normalized coordinates
	/// [0.0,0.25]). By default the length is 0.025. If the end cap length
	/// is set to 0.0, then the end cap will not display at all.
	/// </summary>
	public virtual double GetEndCapLengthMaxValue()
	{
		return vtkSliderRepresentation_GetEndCapLengthMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetEndCapLengthMinValue_04(HandleRef pThis);

	/// <summary>
	/// Specify the length of each end cap (in normalized coordinates
	/// [0.0,0.25]). By default the length is 0.025. If the end cap length
	/// is set to 0.0, then the end cap will not display at all.
	/// </summary>
	public virtual double GetEndCapLengthMinValue()
	{
		return vtkSliderRepresentation_GetEndCapLengthMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetEndCapWidth_05(HandleRef pThis);

	/// <summary>
	/// Specify the width of each end cap (in normalized coordinates
	/// [0.0,0.25]). By default the width is twice the tube width.
	/// </summary>
	public virtual double GetEndCapWidth()
	{
		return vtkSliderRepresentation_GetEndCapWidth_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetEndCapWidthMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the width of each end cap (in normalized coordinates
	/// [0.0,0.25]). By default the width is twice the tube width.
	/// </summary>
	public virtual double GetEndCapWidthMaxValue()
	{
		return vtkSliderRepresentation_GetEndCapWidthMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetEndCapWidthMinValue_07(HandleRef pThis);

	/// <summary>
	/// Specify the width of each end cap (in normalized coordinates
	/// [0.0,0.25]). By default the width is twice the tube width.
	/// </summary>
	public virtual double GetEndCapWidthMinValue()
	{
		return vtkSliderRepresentation_GetEndCapWidthMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation_GetLabelFormat_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the format with which to print the slider value.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkSliderRepresentation_GetLabelFormat_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetLabelHeight_09(HandleRef pThis);

	/// <summary>
	/// Specify the relative height of the label as compared to the length of the
	/// slider.
	/// </summary>
	public virtual double GetLabelHeight()
	{
		return vtkSliderRepresentation_GetLabelHeight_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetLabelHeightMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Specify the relative height of the label as compared to the length of the
	/// slider.
	/// </summary>
	public virtual double GetLabelHeightMaxValue()
	{
		return vtkSliderRepresentation_GetLabelHeightMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetLabelHeightMinValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the relative height of the label as compared to the length of the
	/// slider.
	/// </summary>
	public virtual double GetLabelHeightMinValue()
	{
		return vtkSliderRepresentation_GetLabelHeightMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetMaximumValue_12(HandleRef pThis);

	/// <summary>
	/// Set the current maximum value that the slider can take. Setting the
	/// maximum value less than the minimum value will cause the minimum
	/// value to change to (maximum value - 1).
	/// </summary>
	public virtual double GetMaximumValue()
	{
		return vtkSliderRepresentation_GetMaximumValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetMinimumValue_13(HandleRef pThis);

	/// <summary>
	/// Set the current minimum value that the slider can take. Setting the
	/// minimum value greater than the maximum value will cause the maximum
	/// value to grow to (minimum value + 1).
	/// </summary>
	public virtual double GetMinimumValue()
	{
		return vtkSliderRepresentation_GetMinimumValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSliderRepresentation_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSliderRepresentation_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSliderRepresentation_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSliderRepresentation_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetPickedT_16(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. Subclasses of this class
	/// actually do something.
	/// </summary>
	public virtual double GetPickedT()
	{
		return vtkSliderRepresentation_GetPickedT_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation_GetShowSliderLabel_17(HandleRef pThis);

	/// <summary>
	/// Indicate whether the slider text label should be displayed. This is
	/// a number corresponding to the current Value of this widget.
	/// </summary>
	public virtual int GetShowSliderLabel()
	{
		return vtkSliderRepresentation_GetShowSliderLabel_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetSliderLength_18(HandleRef pThis);

	/// <summary>
	/// Specify the length of the slider shape (in normalized display coordinates
	/// [0.01,0.5]). The slider length by default is 0.05.
	/// </summary>
	public virtual double GetSliderLength()
	{
		return vtkSliderRepresentation_GetSliderLength_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetSliderLengthMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Specify the length of the slider shape (in normalized display coordinates
	/// [0.01,0.5]). The slider length by default is 0.05.
	/// </summary>
	public virtual double GetSliderLengthMaxValue()
	{
		return vtkSliderRepresentation_GetSliderLengthMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetSliderLengthMinValue_20(HandleRef pThis);

	/// <summary>
	/// Specify the length of the slider shape (in normalized display coordinates
	/// [0.01,0.5]). The slider length by default is 0.05.
	/// </summary>
	public virtual double GetSliderLengthMinValue()
	{
		return vtkSliderRepresentation_GetSliderLengthMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetSliderWidth_21(HandleRef pThis);

	/// <summary>
	/// Set the width of the slider in the directions orthogonal to the
	/// slider axis. Using this it is possible to create ellipsoidal and hockey
	/// puck sliders (in some subclasses). By default the width is 0.05.
	/// </summary>
	public virtual double GetSliderWidth()
	{
		return vtkSliderRepresentation_GetSliderWidth_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetSliderWidthMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Set the width of the slider in the directions orthogonal to the
	/// slider axis. Using this it is possible to create ellipsoidal and hockey
	/// puck sliders (in some subclasses). By default the width is 0.05.
	/// </summary>
	public virtual double GetSliderWidthMaxValue()
	{
		return vtkSliderRepresentation_GetSliderWidthMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetSliderWidthMinValue_23(HandleRef pThis);

	/// <summary>
	/// Set the width of the slider in the directions orthogonal to the
	/// slider axis. Using this it is possible to create ellipsoidal and hockey
	/// puck sliders (in some subclasses). By default the width is 0.05.
	/// </summary>
	public virtual double GetSliderWidthMinValue()
	{
		return vtkSliderRepresentation_GetSliderWidthMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetTitleHeight_24(HandleRef pThis);

	/// <summary>
	/// Specify the relative height of the title as compared to the length of the
	/// slider.
	/// </summary>
	public virtual double GetTitleHeight()
	{
		return vtkSliderRepresentation_GetTitleHeight_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetTitleHeightMaxValue_25(HandleRef pThis);

	/// <summary>
	/// Specify the relative height of the title as compared to the length of the
	/// slider.
	/// </summary>
	public virtual double GetTitleHeightMaxValue()
	{
		return vtkSliderRepresentation_GetTitleHeightMaxValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetTitleHeightMinValue_26(HandleRef pThis);

	/// <summary>
	/// Specify the relative height of the title as compared to the length of the
	/// slider.
	/// </summary>
	public virtual double GetTitleHeightMinValue()
	{
		return vtkSliderRepresentation_GetTitleHeightMinValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation_GetTitleText_27(HandleRef pThis);

	/// <summary>
	/// Specify the label text for this widget. If the value is not set, or set
	/// to the empty string "", then the label text is not displayed.
	/// </summary>
	public virtual string GetTitleText()
	{
		return Marshal.PtrToStringAnsi(vtkSliderRepresentation_GetTitleText_27(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetTubeWidth_28(HandleRef pThis);

	/// <summary>
	/// Set the width of the tube (in normalized display coordinates) on which
	/// the slider moves. By default the width is 0.05.
	/// </summary>
	public virtual double GetTubeWidth()
	{
		return vtkSliderRepresentation_GetTubeWidth_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetTubeWidthMaxValue_29(HandleRef pThis);

	/// <summary>
	/// Set the width of the tube (in normalized display coordinates) on which
	/// the slider moves. By default the width is 0.05.
	/// </summary>
	public virtual double GetTubeWidthMaxValue()
	{
		return vtkSliderRepresentation_GetTubeWidthMaxValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetTubeWidthMinValue_30(HandleRef pThis);

	/// <summary>
	/// Set the width of the tube (in normalized display coordinates) on which
	/// the slider moves. By default the width is 0.05.
	/// </summary>
	public virtual double GetTubeWidthMinValue()
	{
		return vtkSliderRepresentation_GetTubeWidthMinValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliderRepresentation_GetValue_31(HandleRef pThis);

	/// <summary>
	/// Specify the current value for the widget. The value should lie between
	/// the minimum and maximum values.
	/// </summary>
	public virtual double GetValue()
	{
		return vtkSliderRepresentation_GetValue_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation_IsA_32(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSliderRepresentation_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation_IsTypeOf_33(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSliderRepresentation_IsTypeOf_33(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkSliderRepresentation NewInstance()
	{
		vtkSliderRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation_NewInstance_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSliderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkSliderRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkSliderRepresentation vtkSliderRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSliderRepresentation2 = (vtkSliderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSliderRepresentation2.Register(null);
			}
		}
		return vtkSliderRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetEndCapLength_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the length of each end cap (in normalized coordinates
	/// [0.0,0.25]). By default the length is 0.025. If the end cap length
	/// is set to 0.0, then the end cap will not display at all.
	/// </summary>
	public virtual void SetEndCapLength(double _arg)
	{
		vtkSliderRepresentation_SetEndCapLength_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetEndCapWidth_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the width of each end cap (in normalized coordinates
	/// [0.0,0.25]). By default the width is twice the tube width.
	/// </summary>
	public virtual void SetEndCapWidth(double _arg)
	{
		vtkSliderRepresentation_SetEndCapWidth_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetLabelFormat_38(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the format with which to print the slider value.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkSliderRepresentation_SetLabelFormat_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetLabelHeight_39(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the relative height of the label as compared to the length of the
	/// slider.
	/// </summary>
	public virtual void SetLabelHeight(double _arg)
	{
		vtkSliderRepresentation_SetLabelHeight_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetMaximumValue_40(HandleRef pThis, double value);

	/// <summary>
	/// Set the current maximum value that the slider can take. Setting the
	/// maximum value less than the minimum value will cause the minimum
	/// value to change to (maximum value - 1).
	/// </summary>
	public void SetMaximumValue(double value)
	{
		vtkSliderRepresentation_SetMaximumValue_40(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetMinimumValue_41(HandleRef pThis, double value);

	/// <summary>
	/// Set the current minimum value that the slider can take. Setting the
	/// minimum value greater than the maximum value will cause the maximum
	/// value to grow to (minimum value + 1).
	/// </summary>
	public void SetMinimumValue(double value)
	{
		vtkSliderRepresentation_SetMinimumValue_41(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetShowSliderLabel_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether the slider text label should be displayed. This is
	/// a number corresponding to the current Value of this widget.
	/// </summary>
	public virtual void SetShowSliderLabel(int _arg)
	{
		vtkSliderRepresentation_SetShowSliderLabel_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetSliderLength_43(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the length of the slider shape (in normalized display coordinates
	/// [0.01,0.5]). The slider length by default is 0.05.
	/// </summary>
	public virtual void SetSliderLength(double _arg)
	{
		vtkSliderRepresentation_SetSliderLength_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetSliderWidth_44(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the width of the slider in the directions orthogonal to the
	/// slider axis. Using this it is possible to create ellipsoidal and hockey
	/// puck sliders (in some subclasses). By default the width is 0.05.
	/// </summary>
	public virtual void SetSliderWidth(double _arg)
	{
		vtkSliderRepresentation_SetSliderWidth_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetTitleHeight_45(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the relative height of the title as compared to the length of the
	/// slider.
	/// </summary>
	public virtual void SetTitleHeight(double _arg)
	{
		vtkSliderRepresentation_SetTitleHeight_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetTitleText_46(HandleRef pThis, string arg0);

	/// <summary>
	/// Specify the label text for this widget. If the value is not set, or set
	/// to the empty string "", then the label text is not displayed.
	/// </summary>
	public virtual void SetTitleText(string arg0)
	{
		vtkSliderRepresentation_SetTitleText_46(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetTubeWidth_47(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the width of the tube (in normalized display coordinates) on which
	/// the slider moves. By default the width is 0.05.
	/// </summary>
	public virtual void SetTubeWidth(double _arg)
	{
		vtkSliderRepresentation_SetTubeWidth_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_SetValue_48(HandleRef pThis, double value);

	/// <summary>
	/// Specify the current value for the widget. The value should lie between
	/// the minimum and maximum values.
	/// </summary>
	public void SetValue(double value)
	{
		vtkSliderRepresentation_SetValue_48(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_ShowSliderLabelOff_49(HandleRef pThis);

	/// <summary>
	/// Indicate whether the slider text label should be displayed. This is
	/// a number corresponding to the current Value of this widget.
	/// </summary>
	public virtual void ShowSliderLabelOff()
	{
		vtkSliderRepresentation_ShowSliderLabelOff_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation_ShowSliderLabelOn_50(HandleRef pThis);

	/// <summary>
	/// Indicate whether the slider text label should be displayed. This is
	/// a number corresponding to the current Value of this widget.
	/// </summary>
	public virtual void ShowSliderLabelOn()
	{
		vtkSliderRepresentation_ShowSliderLabelOn_50(GetCppThis());
	}
}
