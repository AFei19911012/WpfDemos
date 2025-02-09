using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAxis
/// </summary>
/// <remarks>
///    takes care of drawing 2D axes
///
///
/// The vtkAxis is drawn in screen coordinates. It is usually one of the last
/// elements of a chart to be drawn. It renders the axis label, tick marks and
/// tick labels.
/// The tick marks and labels span the range of values between
/// \a Minimum and \a Maximum.
/// The \a Minimum and \a Maximum values are not allowed to extend beyond the
/// \a MinimumLimit and \a MaximumLimit values, respectively.
///
/// Note that many other chart elements (e.g., vtkPlotPoints) refer to
/// vtkAxis instances to determine how to scale raw data for presentation.
/// In particular, care must be taken with logarithmic scaling.
/// The axis Minimum, Maximum, and Limit values are stored both unscaled
/// and scaled (with log(x) applied when GetLogScaleActive() returns true).
/// User interfaces will most likely present the unscaled values as they
/// represent the values provided by the user.
/// Other chart elements may need the scaled values in order to draw
/// in the same coordinate system.
///
/// Just because LogScale is set to true does not guarantee that the axis
/// will use logarithmic scaling -- the Minimum and Maximum values for the
/// axis must both lie to the same side of origin (and not include the origin).
/// Also, this switch from linear- to log-scaling may occur during a rendering
/// pass if autoscaling is enabled.
/// Because the log and pow functions are not invertible and the axis itself
/// decides when to switch between them without offering any external class
/// managing the axis a chance to save the old values, it saves
/// old Limit values in NonLogUnscaled{Min,Max}Limit so that behavior is
/// consistent when LogScale is changed from false to true and back again.
/// </remarks>
public class vtkAxis : vtkContextItem
{
	/// <summary>
	/// Enumeration of the axis behaviors.
	/// </summary>
	public enum AUTO_WrapperEnum
	{
		/// <summary>enum member</summary>
		AUTO = 0,
		/// <summary>enum member</summary>
		CUSTOM = 2,
		/// <summary>enum member</summary>
		FIXED = 1
	}

	/// <summary>
	/// Enumeration of the axis locations in a conventional XY chart. Other
	/// layouts are possible.
	/// </summary>
	public enum TICK_SIMPLE_WrapperEnum
	{
		/// <summary>enum member</summary>
		TICK_SIMPLE,
		/// <summary>enum member</summary>
		TICK_WILKINSON_EXTENDED
	}

	/// <summary>
	/// Enumeration of the axis notations available.
	/// </summary>
	public enum FIXED_NOTATION_WrapperEnum
	{
		/// <summary>enum member</summary>
		FIXED_NOTATION = 2,
		/// <summary>enum member</summary>
		PRINTF_NOTATION = 3,
		/// <summary>enum member</summary>
		SCIENTIFIC_NOTATION = 1,
		/// <summary>enum member</summary>
		STANDARD_NOTATION = 0
	}

	/// <summary>
	/// Enumeration of the axis locations in a conventional XY chart. Other
	/// layouts are possible.
	/// </summary>
	public enum Location
	{
		/// <summary>enum member</summary>
		BOTTOM = 1,
		/// <summary>enum member</summary>
		LEFT = 0,
		/// <summary>enum member</summary>
		PARALLEL = 4,
		/// <summary>enum member</summary>
		RIGHT = 2,
		/// <summary>enum member</summary>
		TOP = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAxis";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAxis()
	{
		MRClassNameKey = "class vtkAxis";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxis"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAxis(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a 2D Chart object.
	/// </summary>
	public new static vtkAxis New()
	{
		vtkAxis result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxis)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a 2D Chart object.
	/// </summary>
	public vtkAxis()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAxis_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_AutoScale_01(HandleRef pThis);

	/// <summary>
	/// Use this function to autoscale the axes after setting the minimum and
	/// maximum values. This will cause the axes to select the nicest numbers
	/// that enclose the minimum and maximum values, and to select an appropriate
	/// number of tick marks.
	/// </summary>
	public virtual void AutoScale()
	{
		vtkAxis_AutoScale_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkAxis_GenerateSimpleLabel_02(HandleRef pThis, double val);

	/// <summary>
	/// Generate a single label using the current settings when TickLabelAlgorithm
	/// is TICK_SIMPLE.
	/// </summary>
	public virtual string GenerateSimpleLabel(double val)
	{
		return vtkAxis_GenerateSimpleLabel_02(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxis_GetAxisVisible_03(HandleRef pThis);

	/// <summary>
	/// Get/set whether the axis line should be visible.
	/// </summary>
	public virtual bool GetAxisVisible()
	{
		return (vtkAxis_GetAxisVisible_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxis_GetBehavior_04(HandleRef pThis);

	/// <summary>
	/// Get/set the behavior of the axis (auto or fixed). The default is 0 (auto).
	/// </summary>
	public virtual int GetBehavior()
	{
		return vtkAxis_GetBehavior_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetBoundingRect_05(HandleRef pThis, HandleRef painter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Request the space the axes require to be drawn. This is returned as a
	/// vtkRectf, with the corner being the offset from Point1, and the width/
	/// height being the total width/height required by the axis. In order to
	/// ensure the numbers are correct, Update() should be called on the axis.
	/// </summary>
	public vtkRectf GetBoundingRect(vtkContext2D painter)
	{
		vtkRectf result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_GetBoundingRect_05(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetGridPen_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the vtkPen object that controls the way this axis is drawn.
	/// </summary>
	public virtual vtkPen GetGridPen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_GetGridPen_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPen2 = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPen2.Register(null);
			}
		}
		return vtkPen2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxis_GetGridVisible_07(HandleRef pThis);

	/// <summary>
	/// Get/set whether the axis grid lines should be drawn, default is true.
	/// </summary>
	public virtual bool GetGridVisible()
	{
		return (vtkAxis_GetGridVisible_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkAxis_GetLabelFormat_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the printf-style format string used when TickLabelAlgorithm is
	/// TICK_SIMPLE and Notation is PRINTF_NOTATION. The default is "%g".
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return vtkAxis_GetLabelFormat_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkAxis_GetLabelOffset_09(HandleRef pThis);

	/// <summary>
	/// Get/set the offset (in pixels) of the label text position from the axis
	/// </summary>
	public virtual float GetLabelOffset()
	{
		return vtkAxis_GetLabelOffset_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetLabelProperties_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkTextProperty that governs how the axis labels are displayed.
	/// Note that the alignment properties are not used.
	/// </summary>
	public virtual vtkTextProperty GetLabelProperties()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_GetLabelProperties_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxis_GetLabelsVisible_11(HandleRef pThis);

	/// <summary>
	/// Get/set whether the axis labels should be visible.
	/// </summary>
	public virtual bool GetLabelsVisible()
	{
		return (vtkAxis_GetLabelsVisible_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxis_GetLogScale_12(HandleRef pThis);

	/// <summary>
	/// Get/set whether the axis should &lt;b&gt;attempt&lt;/b&gt; to use a log scale.
	///
	/// The default is false.
	/// \sa{LogScaleActive}.
	/// </summary>
	public virtual bool GetLogScale()
	{
		return (vtkAxis_GetLogScale_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxis_GetLogScaleActive_13(HandleRef pThis);

	/// <summary>
	/// Get whether the axis is using a log scale.
	/// This will always be false when LogScale is false.
	/// It is only true when LogScale is true &lt;b&gt;and&lt;/b&gt; the \a UnscaledRange
	/// does not cross or include the origin (zero).
	///
	/// The limits (\a MinimumLimit, \a MaximumLimit, and their
	/// unscaled counterparts) do not prevent LogScaleActive from becoming
	/// true; they are adjusted if they cross or include the origin
	/// and the original limits are preserved for when LogScaleActive
	/// becomes false again.
	/// </summary>
	public virtual bool GetLogScaleActive()
	{
		return (vtkAxis_GetLogScaleActive_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetMargins_14(HandleRef pThis);

	/// <summary>
	/// Get the margins of the axis, in pixels.
	/// </summary>
	public virtual int[] GetMargins()
	{
		IntPtr intPtr = vtkAxis_GetMargins_14(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_GetMargins_15(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get the margins of the axis, in pixels.
	/// </summary>
	public virtual void GetMargins(ref int _arg1, ref int _arg2)
	{
		vtkAxis_GetMargins_15(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_GetMargins_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the margins of the axis, in pixels.
	/// </summary>
	public virtual void GetMargins(IntPtr _arg)
	{
		vtkAxis_GetMargins_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_GetMaximum_17(HandleRef pThis);

	/// <summary>
	/// Get the logical maximum value of the axis, in plot coordinates.
	/// If LogScaleActive is true (not just LogScale), then this
	/// returns the maximum base-10 &lt;b&gt;exponent&lt;/b&gt;.
	/// </summary>
	public virtual double GetMaximum()
	{
		return vtkAxis_GetMaximum_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_GetMaximumLimit_18(HandleRef pThis);

	/// <summary>
	/// Get the logical highest possible value for \a Maximum, in plot coordinates.
	/// </summary>
	public virtual double GetMaximumLimit()
	{
		return vtkAxis_GetMaximumLimit_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_GetMinimum_19(HandleRef pThis);

	/// <summary>
	/// Get the logical minimum value of the axis, in plot coordinates.
	/// If LogScaleActive is true (not just LogScale), then this
	/// returns the minimum base-10 &lt;b&gt;exponent&lt;/b&gt;.
	/// </summary>
	public virtual double GetMinimum()
	{
		return vtkAxis_GetMinimum_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_GetMinimumLimit_20(HandleRef pThis);

	/// <summary>
	/// Get the logical lowest possible value for \a Minimum, in plot coordinates.
	/// </summary>
	public virtual double GetMinimumLimit()
	{
		return vtkAxis_GetMinimumLimit_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxis_GetNotation_21(HandleRef pThis);

	/// <summary>
	/// Get/set the numerical notation, standard, scientific, fixed, or a
	/// printf-style format string.
	/// \sa SetPrecision SetLabelFormat
	/// </summary>
	public virtual int GetNotation()
	{
		return vtkAxis_GetNotation_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxis_GetNumberOfGenerationsFromBase_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAxis_GetNumberOfGenerationsFromBase_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxis_GetNumberOfGenerationsFromBaseType_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAxis_GetNumberOfGenerationsFromBaseType_23(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxis_GetNumberOfTicks_24(HandleRef pThis);

	/// <summary>
	/// Get the number of tick marks for this axis.
	/// </summary>
	public virtual int GetNumberOfTicks()
	{
		return vtkAxis_GetNumberOfTicks_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetPen_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the vtkPen object that controls the way this axis is drawn.
	/// </summary>
	public virtual vtkPen GetPen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_GetPen_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPen2 = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPen2.Register(null);
			}
		}
		return vtkPen2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetPoint1_26(HandleRef pThis);

	/// <summary>
	/// Get point 1 of the axis (in pixels), this is usually the origin.
	/// </summary>
	public virtual float[] GetPoint1()
	{
		IntPtr intPtr = vtkAxis_GetPoint1_26(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_GetPoint1_27(HandleRef pThis, ref float _arg1, ref float _arg2);

	/// <summary>
	/// Get point 1 of the axis (in pixels), this is usually the origin.
	/// </summary>
	public virtual void GetPoint1(ref float _arg1, ref float _arg2)
	{
		vtkAxis_GetPoint1_27(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_GetPoint1_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get point 1 of the axis (in pixels), this is usually the origin.
	/// </summary>
	public virtual void GetPoint1(IntPtr _arg)
	{
		vtkAxis_GetPoint1_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetPoint2_29(HandleRef pThis);

	/// <summary>
	/// Get point 2 of the axis (in pixels), this is usually the terminus.
	/// </summary>
	public virtual float[] GetPoint2()
	{
		IntPtr intPtr = vtkAxis_GetPoint2_29(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_GetPoint2_30(HandleRef pThis, ref float _arg1, ref float _arg2);

	/// <summary>
	/// Get point 2 of the axis (in pixels), this is usually the terminus.
	/// </summary>
	public virtual void GetPoint2(ref float _arg1, ref float _arg2)
	{
		vtkAxis_GetPoint2_30(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_GetPoint2_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get point 2 of the axis (in pixels), this is usually the terminus.
	/// </summary>
	public virtual void GetPoint2(IntPtr _arg)
	{
		vtkAxis_GetPoint2_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxis_GetPosition_32(HandleRef pThis);

	/// <summary>
	/// Get/set the position of the axis (LEFT, BOTTOM, RIGHT, TOP, PARALLEL).
	/// </summary>
	public virtual int GetPosition()
	{
		return vtkAxis_GetPosition_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetPosition1_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get point 1 of the axis (in pixels), this is usually the origin.
	/// </summary>
	public vtkVector2f GetPosition1()
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_GetPosition1_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetPosition2_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get point 2 of the axis (in pixels), this is usually the terminus.
	/// </summary>
	public vtkVector2f GetPosition2()
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_GetPosition2_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxis_GetPrecision_35(HandleRef pThis);

	/// <summary>
	/// Get/set the numerical precision to use, default is 2. This is ignored
	/// when Notation is STANDARD_NOTATION or PRINTF_NOTATION.
	/// </summary>
	public virtual int GetPrecision()
	{
		return vtkAxis_GetPrecision_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_GetRange_36(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Get the logical range of the axis, in plot coordinates.
	///
	/// The unscaled range will always be in the same coordinate system of
	/// the data being plotted, regardless of whether LogScale is true or false.
	/// Calling GetRange() when LogScale is true will return the log10({min, max}).
	/// </summary>
	public virtual void GetRange(IntPtr range)
	{
		vtkAxis_GetRange_36(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkAxis_GetRangeLabelFormat_37(HandleRef pThis);

	/// <summary>
	/// Get/Set the printf-style format string used for range labels.
	/// This format is always used regardless of TickLabelAlgorithm and
	/// Notation. Default is "%g".
	/// </summary>
	public virtual string GetRangeLabelFormat()
	{
		return vtkAxis_GetRangeLabelFormat_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxis_GetRangeLabelsVisible_38(HandleRef pThis);

	/// <summary>
	/// Get/set whether the labels for the range should be visible.
	/// </summary>
	public virtual bool GetRangeLabelsVisible()
	{
		return (vtkAxis_GetRangeLabelsVisible_38(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_GetScalingFactor_39(HandleRef pThis);

	/// <summary>
	/// Get/set the scaling factor used for the axis, this defaults to 1.0 (no
	/// scaling), and is used to coordinate scaling with the plots, charts, etc.
	/// </summary>
	public virtual double GetScalingFactor()
	{
		return vtkAxis_GetScalingFactor_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_GetShift_40(HandleRef pThis);

	/// <summary>
	/// Get/set the scaling factor used for the axis, this defaults to 1.0 (no
	/// scaling), and is used to coordinate scaling with the plots, charts, etc.
	/// </summary>
	public virtual double GetShift()
	{
		return vtkAxis_GetShift_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxis_GetTickLabelAlgorithm_41(HandleRef pThis);

	/// <summary>
	/// Get/set the tick label algorithm that is used to calculate the min, max
	/// and tick spacing. There are currently two algorithms, vtkAxis::TICK_SIMPLE
	/// is the default and uses a simple algorithm. The second option is
	/// vtkAxis::TICK_WILKINSON which uses an extended Wilkinson algorithm to find
	/// the optimal range, spacing and font parameters.
	/// </summary>
	public virtual int GetTickLabelAlgorithm()
	{
		return vtkAxis_GetTickLabelAlgorithm_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetTickLabels_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A string array containing the tick labels for the axis.
	/// </summary>
	public virtual vtkStringArray GetTickLabels()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_GetTickLabels_42(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkAxis_GetTickLength_43(HandleRef pThis);

	/// <summary>
	/// Get/set the length of tick marks (in pixels).
	/// </summary>
	public virtual float GetTickLength()
	{
		return vtkAxis_GetTickLength_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetTickPositions_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// An array with the positions of the tick marks along the axis line.
	/// The positions are specified in the plot coordinates of the axis.
	/// </summary>
	public virtual vtkDoubleArray GetTickPositions()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_GetTickPositions_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetTickScenePositions_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// An array with the positions of the tick marks along the axis line.
	/// The positions are specified in scene coordinates.
	/// </summary>
	public virtual vtkFloatArray GetTickScenePositions()
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_GetTickScenePositions_45(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxis_GetTicksVisible_46(HandleRef pThis);

	/// <summary>
	/// Get/set whether the tick marks should be visible.
	/// </summary>
	public virtual bool GetTicksVisible()
	{
		return (vtkAxis_GetTicksVisible_46(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkAxis_GetTitle_47(HandleRef pThis);

	/// <summary>
	/// Get/set the title text of the axis.
	/// </summary>
	public virtual string GetTitle()
	{
		return vtkAxis_GetTitle_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_GetTitleProperties_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkTextProperty that governs how the axis title is displayed.
	/// </summary>
	public virtual vtkTextProperty GetTitleProperties()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_GetTitleProperties_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxis_GetTitleVisible_49(HandleRef pThis);

	/// <summary>
	/// Get/set whether the axis title should be visible.
	/// </summary>
	public virtual bool GetTitleVisible()
	{
		return (vtkAxis_GetTitleVisible_49(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_GetUnscaledMaximum_50(HandleRef pThis);

	/// <summary>
	/// Get the logical maximum value of the axis, in plot coordinates.
	/// </summary>
	public virtual double GetUnscaledMaximum()
	{
		return vtkAxis_GetUnscaledMaximum_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_GetUnscaledMaximumLimit_51(HandleRef pThis);

	/// <summary>
	/// Get the logical highest possible value for \a Maximum, in plot coordinates.
	/// </summary>
	public virtual double GetUnscaledMaximumLimit()
	{
		return vtkAxis_GetUnscaledMaximumLimit_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_GetUnscaledMinimum_52(HandleRef pThis);

	/// <summary>
	/// Get the logical minimum value of the axis, in plot coordinates.
	/// </summary>
	public virtual double GetUnscaledMinimum()
	{
		return vtkAxis_GetUnscaledMinimum_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_GetUnscaledMinimumLimit_53(HandleRef pThis);

	/// <summary>
	/// Get the logical lowest possible value for \a Minimum, in plot coordinates.
	/// </summary>
	public virtual double GetUnscaledMinimumLimit()
	{
		return vtkAxis_GetUnscaledMinimumLimit_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_GetUnscaledRange_54(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Get the logical range of the axis, in plot coordinates.
	///
	/// The unscaled range will always be in the same coordinate system of
	/// the data being plotted, regardless of whether LogScale is true or false.
	/// Calling GetRange() when LogScale is true will return the log10({min, max}).
	/// </summary>
	public virtual void GetUnscaledRange(IntPtr range)
	{
		vtkAxis_GetUnscaledRange_54(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxis_IsA_55(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAxis_IsA_55(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxis_IsTypeOf_56(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAxis_IsTypeOf_56(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_LogScaleOff_57(HandleRef pThis);

	/// <summary>
	/// Get/set whether the axis should &lt;b&gt;attempt&lt;/b&gt; to use a log scale.
	///
	/// The default is false.
	/// \sa{LogScaleActive}.
	/// </summary>
	public virtual void LogScaleOff()
	{
		vtkAxis_LogScaleOff_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_LogScaleOn_58(HandleRef pThis);

	/// <summary>
	/// Get/set whether the axis should &lt;b&gt;attempt&lt;/b&gt; to use a log scale.
	///
	/// The default is false.
	/// \sa{LogScaleActive}.
	/// </summary>
	public virtual void LogScaleOn()
	{
		vtkAxis_LogScaleOn_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_NewInstance_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAxis NewInstance()
	{
		vtkAxis result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_NewInstance_60(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxis)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_NiceMinMax_61(ref double min, ref double max, float pixelRange, float tickPixelSpacing);

	/// <summary>
	/// Static function to calculate "nice" minimum, maximum, and tick spacing
	/// values.
	/// </summary>
	public static double NiceMinMax(ref double min, ref double max, float pixelRange, float tickPixelSpacing)
	{
		return vtkAxis_NiceMinMax_61(ref min, ref max, pixelRange, tickPixelSpacing);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxis_NiceNumber_62(double number, byte roundUp);

	/// <summary>
	/// Return a "nice number", often defined as 1, 2 or 5. If roundUp is true then
	/// the nice number will be rounded up, false it is rounded down. The supplied
	/// number should be between 0.0 and 9.9.
	/// </summary>
	public static double NiceNumber(double number, bool roundUp)
	{
		return vtkAxis_NiceNumber_62(number, (byte)(roundUp ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxis_Paint_63(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the axis, called whenever the axis needs to be drawn.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkAxis_Paint_63(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_RecalculateTickSpacing_64(HandleRef pThis);

	/// <summary>
	/// Recalculate the spacing of the tick marks - typically useful to do after
	/// scaling the axis.
	/// </summary>
	public virtual void RecalculateTickSpacing()
	{
		vtkAxis_RecalculateTickSpacing_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxis_SafeDownCast_65(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAxis SafeDownCast(vtkObjectBase o)
	{
		vtkAxis vtkAxis2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxis_SafeDownCast_65(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxis2 = (vtkAxis)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxis2.Register(null);
			}
		}
		return vtkAxis2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetAxisVisible_66(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set whether the axis line should be visible.
	/// </summary>
	public virtual void SetAxisVisible(bool _arg)
	{
		vtkAxis_SetAxisVisible_66(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetBehavior_67(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/set the behavior of the axis (auto or fixed). The default is 0 (auto).
	/// </summary>
	public virtual void SetBehavior(int _arg)
	{
		vtkAxis_SetBehavior_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxis_SetCustomTickPositions_68(HandleRef pThis, HandleRef positions, HandleRef labels);

	/// <summary>
	/// Set the tick positions, and optionally custom tick labels. If the labels
	/// and positions are null then automatic tick labels will be assigned. If
	/// only positions are supplied then appropriate labels will be generated
	/// according to the axis settings. If positions and labels are supplied they
	/// must be of the same length. Returns true on success, false on failure.
	/// </summary>
	public virtual bool SetCustomTickPositions(vtkDoubleArray positions, vtkStringArray labels)
	{
		return (vtkAxis_SetCustomTickPositions_68(GetCppThis(), positions?.GetCppThis() ?? default(HandleRef), labels?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetGridPen_69(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Set/get the vtkPen object that controls the way this axis is drawn.
	/// </summary>
	public virtual void SetGridPen(vtkPen _arg)
	{
		vtkAxis_SetGridPen_69(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetGridVisible_70(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set whether the axis grid lines should be drawn, default is true.
	/// </summary>
	public virtual void SetGridVisible(bool _arg)
	{
		vtkAxis_SetGridVisible_70(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetLabelFormat_71(HandleRef pThis, string fmt);

	/// <summary>
	/// Get/Set the printf-style format string used when TickLabelAlgorithm is
	/// TICK_SIMPLE and Notation is PRINTF_NOTATION. The default is "%g".
	/// </summary>
	public virtual void SetLabelFormat(string fmt)
	{
		vtkAxis_SetLabelFormat_71(GetCppThis(), fmt);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetLabelOffset_72(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/set the offset (in pixels) of the label text position from the axis
	/// </summary>
	public virtual void SetLabelOffset(float _arg)
	{
		vtkAxis_SetLabelOffset_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetLabelsVisible_73(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set whether the axis labels should be visible.
	/// </summary>
	public virtual void SetLabelsVisible(bool _arg)
	{
		vtkAxis_SetLabelsVisible_73(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetLogScale_74(HandleRef pThis, byte logScale);

	/// <summary>
	/// Get/set whether the axis should &lt;b&gt;attempt&lt;/b&gt; to use a log scale.
	///
	/// The default is false.
	/// \sa{LogScaleActive}.
	/// </summary>
	public virtual void SetLogScale(bool logScale)
	{
		vtkAxis_SetLogScale_74(GetCppThis(), (byte)(logScale ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetMargins_75(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set the margins of the axis, in pixels.
	/// </summary>
	public virtual void SetMargins(int _arg1, int _arg2)
	{
		vtkAxis_SetMargins_75(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetMargins_76(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the margins of the axis, in pixels.
	/// </summary>
	public void SetMargins(IntPtr _arg)
	{
		vtkAxis_SetMargins_76(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetMaximum_77(HandleRef pThis, double maximum);

	/// <summary>
	/// Set the logical maximum value of the axis, in plot coordinates.
	/// If LogScaleActive is true (not just LogScale), then this
	/// sets the maximum base-10 &lt;b&gt;exponent&lt;/b&gt;.
	/// </summary>
	public virtual void SetMaximum(double maximum)
	{
		vtkAxis_SetMaximum_77(GetCppThis(), maximum);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetMaximumLimit_78(HandleRef pThis, double highest);

	/// <summary>
	/// Set the logical highest possible value for \a Maximum, in plot coordinates.
	/// </summary>
	public virtual void SetMaximumLimit(double highest)
	{
		vtkAxis_SetMaximumLimit_78(GetCppThis(), highest);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetMinimum_79(HandleRef pThis, double minimum);

	/// <summary>
	/// Set the logical minimum value of the axis, in plot coordinates.
	/// If LogScaleActive is true (not just LogScale), then this
	/// sets the minimum base-10 &lt;b&gt;exponent&lt;/b&gt;.
	/// </summary>
	public virtual void SetMinimum(double minimum)
	{
		vtkAxis_SetMinimum_79(GetCppThis(), minimum);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetMinimumLimit_80(HandleRef pThis, double lowest);

	/// <summary>
	/// Set the logical lowest possible value for \a Minimum, in plot coordinates.
	/// </summary>
	public virtual void SetMinimumLimit(double lowest)
	{
		vtkAxis_SetMinimumLimit_80(GetCppThis(), lowest);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetNotation_81(HandleRef pThis, int notation);

	/// <summary>
	/// Get/set the numerical notation, standard, scientific, fixed, or a
	/// printf-style format string.
	/// \sa SetPrecision SetLabelFormat
	/// </summary>
	public virtual void SetNotation(int notation)
	{
		vtkAxis_SetNotation_81(GetCppThis(), notation);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetNumberOfTicks_82(HandleRef pThis, int numberOfTicks);

	/// <summary>
	/// Set the number of tick marks for this axis. Default is -1, which leads to
	/// automatic calculation of nicely spaced tick marks.
	/// </summary>
	public virtual void SetNumberOfTicks(int numberOfTicks)
	{
		vtkAxis_SetNumberOfTicks_82(GetCppThis(), numberOfTicks);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetPen_83(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Set/get the vtkPen object that controls the way this axis is drawn.
	/// </summary>
	public virtual void SetPen(vtkPen _arg)
	{
		vtkAxis_SetPen_83(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetPoint1_84(HandleRef pThis, HandleRef pos);

	/// <summary>
	/// Set point 1 of the axis (in pixels), this is usually the origin.
	/// </summary>
	public void SetPoint1(vtkVector2f pos)
	{
		vtkAxis_SetPoint1_84(GetCppThis(), pos?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetPoint1_85(HandleRef pThis, float x, float y);

	/// <summary>
	/// Set point 1 of the axis (in pixels), this is usually the origin.
	/// </summary>
	public void SetPoint1(float x, float y)
	{
		vtkAxis_SetPoint1_85(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetPoint2_86(HandleRef pThis, HandleRef pos);

	/// <summary>
	/// Set point 2 of the axis (in pixels), this is usually the terminus.
	/// </summary>
	public void SetPoint2(vtkVector2f pos)
	{
		vtkAxis_SetPoint2_86(GetCppThis(), pos?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetPoint2_87(HandleRef pThis, float x, float y);

	/// <summary>
	/// Set point 2 of the axis (in pixels), this is usually the terminus.
	/// </summary>
	public void SetPoint2(float x, float y)
	{
		vtkAxis_SetPoint2_87(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetPosition_88(HandleRef pThis, int position);

	/// <summary>
	/// Get/set the position of the axis (LEFT, BOTTOM, RIGHT, TOP, PARALLEL).
	/// </summary>
	public virtual void SetPosition(int position)
	{
		vtkAxis_SetPosition_88(GetCppThis(), position);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetPrecision_89(HandleRef pThis, int precision);

	/// <summary>
	/// Get/set the numerical precision to use, default is 2. This is ignored
	/// when Notation is STANDARD_NOTATION or PRINTF_NOTATION.
	/// </summary>
	public virtual void SetPrecision(int precision)
	{
		vtkAxis_SetPrecision_89(GetCppThis(), precision);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetRange_90(HandleRef pThis, double minimum, double maximum);

	/// <summary>
	/// Set the logical range of the axis, in plot coordinates.
	///
	/// The unscaled range will always be in the same coordinate system of
	/// the data being plotted, regardless of whether LogScale is true or false.
	/// When calling SetRange() and LogScale is true, the range must be specified
	/// in logarithmic coordinates.
	/// Using SetUnscaledRange(), you may ignore the value of LogScale.
	/// </summary>
	public virtual void SetRange(double minimum, double maximum)
	{
		vtkAxis_SetRange_90(GetCppThis(), minimum, maximum);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetRange_91(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Set the logical range of the axis, in plot coordinates.
	///
	/// The unscaled range will always be in the same coordinate system of
	/// the data being plotted, regardless of whether LogScale is true or false.
	/// When calling SetRange() and LogScale is true, the range must be specified
	/// in logarithmic coordinates.
	/// Using SetUnscaledRange(), you may ignore the value of LogScale.
	/// </summary>
	public virtual void SetRange(IntPtr range)
	{
		vtkAxis_SetRange_91(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetRangeLabelFormat_92(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the printf-style format string used for range labels.
	/// This format is always used regardless of TickLabelAlgorithm and
	/// Notation. Default is "%g".
	/// </summary>
	public virtual void SetRangeLabelFormat(string _arg)
	{
		vtkAxis_SetRangeLabelFormat_92(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetRangeLabelsVisible_93(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set whether the labels for the range should be visible.
	/// </summary>
	public virtual void SetRangeLabelsVisible(bool _arg)
	{
		vtkAxis_SetRangeLabelsVisible_93(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetScalingFactor_94(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/set the scaling factor used for the axis, this defaults to 1.0 (no
	/// scaling), and is used to coordinate scaling with the plots, charts, etc.
	/// </summary>
	public virtual void SetScalingFactor(double _arg)
	{
		vtkAxis_SetScalingFactor_94(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetShift_95(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/set the scaling factor used for the axis, this defaults to 1.0 (no
	/// scaling), and is used to coordinate scaling with the plots, charts, etc.
	/// </summary>
	public virtual void SetShift(double _arg)
	{
		vtkAxis_SetShift_95(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetTickLabelAlgorithm_96(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/set the tick label algorithm that is used to calculate the min, max
	/// and tick spacing. There are currently two algorithms, vtkAxis::TICK_SIMPLE
	/// is the default and uses a simple algorithm. The second option is
	/// vtkAxis::TICK_WILKINSON which uses an extended Wilkinson algorithm to find
	/// the optimal range, spacing and font parameters.
	/// </summary>
	public virtual void SetTickLabelAlgorithm(int _arg)
	{
		vtkAxis_SetTickLabelAlgorithm_96(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetTickLength_97(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/set the length of tick marks (in pixels).
	/// </summary>
	public virtual void SetTickLength(float _arg)
	{
		vtkAxis_SetTickLength_97(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetTicksVisible_98(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set whether the tick marks should be visible.
	/// </summary>
	public virtual void SetTicksVisible(bool _arg)
	{
		vtkAxis_SetTicksVisible_98(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetTitle_99(HandleRef pThis, string title);

	/// <summary>
	/// Get/set the title text of the axis.
	/// </summary>
	public virtual void SetTitle(string title)
	{
		vtkAxis_SetTitle_99(GetCppThis(), title);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetTitleVisible_100(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set whether the axis title should be visible.
	/// </summary>
	public virtual void SetTitleVisible(bool _arg)
	{
		vtkAxis_SetTitleVisible_100(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetUnscaledMaximum_101(HandleRef pThis, double maximum);

	/// <summary>
	/// Set the logical maximum value of the axis, in plot coordinates.
	/// </summary>
	public virtual void SetUnscaledMaximum(double maximum)
	{
		vtkAxis_SetUnscaledMaximum_101(GetCppThis(), maximum);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetUnscaledMaximumLimit_102(HandleRef pThis, double highest);

	/// <summary>
	/// Set the logical highest possible value for \a Maximum, in plot coordinates.
	/// </summary>
	public virtual void SetUnscaledMaximumLimit(double highest)
	{
		vtkAxis_SetUnscaledMaximumLimit_102(GetCppThis(), highest);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetUnscaledMinimum_103(HandleRef pThis, double minimum);

	/// <summary>
	/// Set the logical, unscaled minimum value of the axis, in plot coordinates.
	/// Use this instead of SetMinimum() if you wish to provide the actual minimum
	/// instead of log10(the minimum) as part of the axis scale.
	/// </summary>
	public virtual void SetUnscaledMinimum(double minimum)
	{
		vtkAxis_SetUnscaledMinimum_103(GetCppThis(), minimum);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetUnscaledMinimumLimit_104(HandleRef pThis, double lowest);

	/// <summary>
	/// Set the logical lowest possible value for \a Minimum, in plot coordinates.
	/// </summary>
	public virtual void SetUnscaledMinimumLimit(double lowest)
	{
		vtkAxis_SetUnscaledMinimumLimit_104(GetCppThis(), lowest);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetUnscaledRange_105(HandleRef pThis, double minimum, double maximum);

	/// <summary>
	/// Set the logical range of the axis, in plot coordinates.
	///
	/// The unscaled range will always be in the same coordinate system of
	/// the data being plotted, regardless of whether LogScale is true or false.
	/// When calling SetRange() and LogScale is true, the range must be specified
	/// in logarithmic coordinates.
	/// Using SetUnscaledRange(), you may ignore the value of LogScale.
	/// </summary>
	public virtual void SetUnscaledRange(double minimum, double maximum)
	{
		vtkAxis_SetUnscaledRange_105(GetCppThis(), minimum, maximum);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_SetUnscaledRange_106(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Set the logical range of the axis, in plot coordinates.
	///
	/// The unscaled range will always be in the same coordinate system of
	/// the data being plotted, regardless of whether LogScale is true or false.
	/// When calling SetRange() and LogScale is true, the range must be specified
	/// in logarithmic coordinates.
	/// Using SetUnscaledRange(), you may ignore the value of LogScale.
	/// </summary>
	public virtual void SetUnscaledRange(IntPtr range)
	{
		vtkAxis_SetUnscaledRange_106(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxis_Update_107(HandleRef pThis);

	/// <summary>
	/// Update the geometry of the axis. Takes care of setting up the tick mark
	/// locations etc. Should be called by the scene before rendering.
	/// </summary>
	public override void Update()
	{
		vtkAxis_Update_107(GetCppThis());
	}
}
