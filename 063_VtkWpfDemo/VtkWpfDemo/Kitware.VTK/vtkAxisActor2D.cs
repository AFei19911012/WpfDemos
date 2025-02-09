using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAxisActor2D
/// </summary>
/// <remarks>
///    Create an axis with tick marks and labels
///
/// vtkAxisActor2D creates an axis with tick marks, labels, and/or a title,
/// depending on the particular instance variable settings. vtkAxisActor2D is
/// a 2D actor; that is, it is drawn on the overlay plane and is not
/// occluded by 3D geometry. To use this class, you typically specify two
/// points defining the start and end points of the line (x-y definition using
/// vtkCoordinate class), the number of labels, and the data range
/// (min,max). You can also control what parts of the axis are visible
/// including the line, the tick marks, the labels, and the title.  You can
/// also specify the label format (a printf style format).
///
/// This class decides what font size to use and how to locate the labels. It
/// also decides how to create reasonable tick marks and labels. The number
/// of labels and the range of values may not match the number specified, but
/// should be close.
///
/// Labels are drawn on the "right" side of the axis. The "right" side is
/// the side of the axis on the right as you move from Position to Position2.
/// The way the labels and title line up with the axis and tick marks depends on
/// whether the line is considered horizontal or vertical.
///
/// The vtkActor2D instance variables Position and Position2 are instances of
/// vtkCoordinate. Note that the Position2 is an absolute position in that
/// class (it was by default relative to Position in vtkActor2D).
///
/// What this means is that you can specify the axis in a variety of coordinate
/// systems. Also, the axis does not have to be either horizontal or vertical.
/// The tick marks are created so that they are perpendicular to the axis.
///
/// Set the text property/attributes of the title and the labels through the
/// vtkTextProperty objects associated to this actor.
///
/// </remarks>
/// <seealso>
///
/// vtkCubeAxesActor2D can be used to create axes in world coordinate space.
///
///
/// vtkActor2D vtkTextMapper vtkPolyDataMapper2D vtkScalarBarActor
/// vtkCoordinate vtkTextProperty
/// </seealso>
public class vtkAxisActor2D : vtkActor2D
{
	/// <summary>
	/// Specify the RulerDistance which indicates the spacing of the major ticks.
	/// This ivar only has effect when the RulerMode is on.
	/// </summary>
	public enum LabelMax
	{
		/// <summary>enum member</summary>
		VTK_MAX_LABELS = 25
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAxisActor2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAxisActor2D()
	{
		MRClassNameKey = "class vtkAxisActor2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxisActor2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAxisActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new static vtkAxisActor2D New()
	{
		vtkAxisActor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public vtkAxisActor2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAxisActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_AdjustLabelsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether the labels and ticks are
	/// adjusted for "nice" numerical values to make it easier to read
	/// the labels. The adjustment is based in the Range instance variable.
	/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
	/// range and number of labels. Note that if RulerMode is on, then the
	/// number of labels is a function of the range and ruler distance.
	/// </summary>
	public virtual void AdjustLabelsOff()
	{
		vtkAxisActor2D_AdjustLabelsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_AdjustLabelsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether the labels and ticks are
	/// adjusted for "nice" numerical values to make it easier to read
	/// the labels. The adjustment is based in the Range instance variable.
	/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
	/// range and number of labels. Note that if RulerMode is on, then the
	/// number of labels is a function of the range and ruler distance.
	/// </summary>
	public virtual void AdjustLabelsOn()
	{
		vtkAxisActor2D_AdjustLabelsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_AxisVisibilityOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis line.
	/// </summary>
	public virtual void AxisVisibilityOff()
	{
		vtkAxisActor2D_AxisVisibilityOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_AxisVisibilityOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis line.
	/// </summary>
	public virtual void AxisVisibilityOn()
	{
		vtkAxisActor2D_AxisVisibilityOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_ComputeRange_05(IntPtr inRange, IntPtr outRange, int inNumTicks, ref int outNumTicks, ref double interval);

	/// <summary>
	/// This method computes the range of the axis given an input range.
	/// It also computes the number of tick marks given a suggested number.
	/// (The number of tick marks includes end ticks as well.)
	/// The number of tick marks computed (in conjunction with the output
	/// range) will yield "nice" tick values. For example, if the input range
	/// is (0.25,96.7) and the number of ticks requested is 10, the output range
	/// will be (0,100) with the number of computed ticks to 11 to yield tick
	/// values of (0,10,20,...,100).
	/// </summary>
	public static void ComputeRange(IntPtr inRange, IntPtr outRange, int inNumTicks, ref int outNumTicks, ref double interval)
	{
		vtkAxisActor2D_ComputeRange_05(inRange, outRange, inNumTicks, ref outNumTicks, ref interval);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetAdjustLabels_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether the labels and ticks are
	/// adjusted for "nice" numerical values to make it easier to read
	/// the labels. The adjustment is based in the Range instance variable.
	/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
	/// range and number of labels. Note that if RulerMode is on, then the
	/// number of labels is a function of the range and ruler distance.
	/// </summary>
	public virtual int GetAdjustLabels()
	{
		return vtkAxisActor2D_GetAdjustLabels_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetAdjustedNumberOfLabels_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether the labels and ticks are
	/// adjusted for "nice" numerical values to make it easier to read
	/// the labels. The adjustment is based in the Range instance variable.
	/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
	/// range and number of labels. Note that if RulerMode is on, then the
	/// number of labels is a function of the range and ruler distance.
	/// </summary>
	public virtual int GetAdjustedNumberOfLabels()
	{
		return vtkAxisActor2D_GetAdjustedNumberOfLabels_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_GetAdjustedRange_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether the labels and ticks are
	/// adjusted for "nice" numerical values to make it easier to read
	/// the labels. The adjustment is based in the Range instance variable.
	/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
	/// range and number of labels. Note that if RulerMode is on, then the
	/// number of labels is a function of the range and ruler distance.
	/// </summary>
	public virtual IntPtr GetAdjustedRange()
	{
		return vtkAxisActor2D_GetAdjustedRange_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_GetAdjustedRange_09(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/Get the flag that controls whether the labels and ticks are
	/// adjusted for "nice" numerical values to make it easier to read
	/// the labels. The adjustment is based in the Range instance variable.
	/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
	/// range and number of labels. Note that if RulerMode is on, then the
	/// number of labels is a function of the range and ruler distance.
	/// </summary>
	public virtual void GetAdjustedRange(ref double _arg1, ref double _arg2)
	{
		vtkAxisActor2D_GetAdjustedRange_09(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_GetAdjustedRange_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the flag that controls whether the labels and ticks are
	/// adjusted for "nice" numerical values to make it easier to read
	/// the labels. The adjustment is based in the Range instance variable.
	/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
	/// range and number of labels. Note that if RulerMode is on, then the
	/// number of labels is a function of the range and ruler distance.
	/// </summary>
	public virtual void GetAdjustedRange(IntPtr _arg)
	{
		vtkAxisActor2D_GetAdjustedRange_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetAxisVisibility_11(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis line.
	/// </summary>
	public virtual int GetAxisVisibility()
	{
		return vtkAxisActor2D_GetAxisVisibility_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor2D_GetFontFactor_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label and title the axes. This ivar used in conjunction with
	/// the LabelFactor can be used to control font sizes.
	/// </summary>
	public virtual double GetFontFactor()
	{
		return vtkAxisActor2D_GetFontFactor_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor2D_GetFontFactorMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label and title the axes. This ivar used in conjunction with
	/// the LabelFactor can be used to control font sizes.
	/// </summary>
	public virtual double GetFontFactorMaxValue()
	{
		return vtkAxisActor2D_GetFontFactorMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor2D_GetFontFactorMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label and title the axes. This ivar used in conjunction with
	/// the LabelFactor can be used to control font sizes.
	/// </summary>
	public virtual double GetFontFactorMinValue()
	{
		return vtkAxisActor2D_GetFontFactorMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor2D_GetLabelFactor_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the axis labels
	/// to the axis title.
	/// </summary>
	public virtual double GetLabelFactor()
	{
		return vtkAxisActor2D_GetLabelFactor_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor2D_GetLabelFactorMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the axis labels
	/// to the axis title.
	/// </summary>
	public virtual double GetLabelFactorMaxValue()
	{
		return vtkAxisActor2D_GetLabelFactorMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor2D_GetLabelFactorMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the axis labels
	/// to the axis title.
	/// </summary>
	public virtual double GetLabelFactorMinValue()
	{
		return vtkAxisActor2D_GetLabelFactorMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_GetLabelFormat_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the format with which to print the labels on the scalar
	/// bar.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkAxisActor2D_GetLabelFormat_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_GetLabelTextProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the labels text property.
	/// </summary>
	public virtual vtkTextProperty GetLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor2D_GetLabelTextProperty_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetLabelVisibility_20(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis labels.
	/// </summary>
	public virtual int GetLabelVisibility()
	{
		return vtkAxisActor2D_GetLabelVisibility_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetMinorTickLength_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the length of the minor tick marks (expressed in pixels or
	/// display coordinates).
	/// </summary>
	public virtual int GetMinorTickLength()
	{
		return vtkAxisActor2D_GetMinorTickLength_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetMinorTickLengthMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the length of the minor tick marks (expressed in pixels or
	/// display coordinates).
	/// </summary>
	public virtual int GetMinorTickLengthMaxValue()
	{
		return vtkAxisActor2D_GetMinorTickLengthMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetMinorTickLengthMinValue_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the length of the minor tick marks (expressed in pixels or
	/// display coordinates).
	/// </summary>
	public virtual int GetMinorTickLengthMinValue()
	{
		return vtkAxisActor2D_GetMinorTickLengthMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxisActor2D_GetNumberOfGenerationsFromBase_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAxisActor2D_GetNumberOfGenerationsFromBase_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxisActor2D_GetNumberOfGenerationsFromBaseType_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAxisActor2D_GetNumberOfGenerationsFromBaseType_25(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetNumberOfLabels_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of annotation labels to show. This also controls the
	/// number of major ticks shown. Note that this ivar only holds meaning if
	/// the RulerMode is off.
	/// </summary>
	public virtual int GetNumberOfLabels()
	{
		return vtkAxisActor2D_GetNumberOfLabels_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetNumberOfLabelsMaxValue_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of annotation labels to show. This also controls the
	/// number of major ticks shown. Note that this ivar only holds meaning if
	/// the RulerMode is off.
	/// </summary>
	public virtual int GetNumberOfLabelsMaxValue()
	{
		return vtkAxisActor2D_GetNumberOfLabelsMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetNumberOfLabelsMinValue_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of annotation labels to show. This also controls the
	/// number of major ticks shown. Note that this ivar only holds meaning if
	/// the RulerMode is off.
	/// </summary>
	public virtual int GetNumberOfLabelsMinValue()
	{
		return vtkAxisActor2D_GetNumberOfLabelsMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetNumberOfMinorTicks_29(HandleRef pThis);

	/// <summary>
	/// Number of minor ticks to be displayed between each tick. Default
	/// is 0.
	/// </summary>
	public virtual int GetNumberOfMinorTicks()
	{
		return vtkAxisActor2D_GetNumberOfMinorTicks_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetNumberOfMinorTicksMaxValue_30(HandleRef pThis);

	/// <summary>
	/// Number of minor ticks to be displayed between each tick. Default
	/// is 0.
	/// </summary>
	public virtual int GetNumberOfMinorTicksMaxValue()
	{
		return vtkAxisActor2D_GetNumberOfMinorTicksMaxValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetNumberOfMinorTicksMinValue_31(HandleRef pThis);

	/// <summary>
	/// Number of minor ticks to be displayed between each tick. Default
	/// is 0.
	/// </summary>
	public virtual int GetNumberOfMinorTicksMinValue()
	{
		return vtkAxisActor2D_GetNumberOfMinorTicksMinValue_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_GetPoint1_32(HandleRef pThis);

	/// <summary>
	/// Specify the position of the first point defining the axis.
	/// Note: backward compatibility only, use vtkActor2D's Position instead.
	/// </summary>
	public virtual IntPtr GetPoint1()
	{
		return vtkAxisActor2D_GetPoint1_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_GetPoint1Coordinate_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the position of the first point defining the axis.
	/// Note: backward compatibility only, use vtkActor2D's Position instead.
	/// </summary>
	public virtual vtkCoordinate GetPoint1Coordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor2D_GetPoint1Coordinate_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_GetPoint2_34(HandleRef pThis);

	/// <summary>
	/// Specify the position of the second point defining the axis. Note that
	/// the order from Point1 to Point2 controls which side the tick marks
	/// are drawn on (ticks are drawn on the right, if visible).
	/// Note: backward compatibility only, use vtkActor2D's Position2 instead.
	/// </summary>
	public virtual IntPtr GetPoint2()
	{
		return vtkAxisActor2D_GetPoint2_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_GetPoint2Coordinate_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the position of the second point defining the axis. Note that
	/// the order from Point1 to Point2 controls which side the tick marks
	/// are drawn on (ticks are drawn on the right, if visible).
	/// Note: backward compatibility only, use vtkActor2D's Position2 instead.
	/// </summary>
	public virtual vtkCoordinate GetPoint2Coordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor2D_GetPoint2Coordinate_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_GetRange_36(HandleRef pThis);

	/// <summary>
	/// Specify the (min,max) axis range. This will be used in the generation
	/// of labels, if labels are visible.
	/// </summary>
	public virtual double[] GetRange()
	{
		IntPtr intPtr = vtkAxisActor2D_GetRange_36(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_GetRange_37(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the (min,max) axis range. This will be used in the generation
	/// of labels, if labels are visible.
	/// </summary>
	public virtual void GetRange(IntPtr data)
	{
		vtkAxisActor2D_GetRange_37(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor2D_GetRulerDistance_38(HandleRef pThis);

	/// <summary>
	/// Specify the RulerDistance which indicates the spacing of the major ticks.
	/// This ivar only has effect when the RulerMode is on.
	/// </summary>
	public virtual double GetRulerDistance()
	{
		return vtkAxisActor2D_GetRulerDistance_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor2D_GetRulerDistanceMaxValue_39(HandleRef pThis);

	/// <summary>
	/// Specify the RulerDistance which indicates the spacing of the major ticks.
	/// This ivar only has effect when the RulerMode is on.
	/// </summary>
	public virtual double GetRulerDistanceMaxValue()
	{
		return vtkAxisActor2D_GetRulerDistanceMaxValue_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor2D_GetRulerDistanceMinValue_40(HandleRef pThis);

	/// <summary>
	/// Specify the RulerDistance which indicates the spacing of the major ticks.
	/// This ivar only has effect when the RulerMode is on.
	/// </summary>
	public virtual double GetRulerDistanceMinValue()
	{
		return vtkAxisActor2D_GetRulerDistanceMinValue_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetRulerMode_41(HandleRef pThis);

	/// <summary>
	/// Specify whether this axis should act like a measuring tape (or ruler) with
	/// specified major tick spacing. If enabled, the distance between major ticks
	/// is controlled by the RulerDistance ivar.
	/// </summary>
	public virtual int GetRulerMode()
	{
		return vtkAxisActor2D_GetRulerMode_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetSizeFontRelativeToAxis_42(HandleRef pThis);

	/// <summary>
	/// Specify whether to size the fonts relative to the viewport or relative to
	/// length of the axis. By default, fonts are resized relative to the viewport.
	/// </summary>
	public virtual int GetSizeFontRelativeToAxis()
	{
		return vtkAxisActor2D_GetSizeFontRelativeToAxis_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetTickLength_43(HandleRef pThis);

	/// <summary>
	/// Set/Get the length of the tick marks (expressed in pixels or display
	/// coordinates).
	/// </summary>
	public virtual int GetTickLength()
	{
		return vtkAxisActor2D_GetTickLength_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetTickLengthMaxValue_44(HandleRef pThis);

	/// <summary>
	/// Set/Get the length of the tick marks (expressed in pixels or display
	/// coordinates).
	/// </summary>
	public virtual int GetTickLengthMaxValue()
	{
		return vtkAxisActor2D_GetTickLengthMaxValue_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetTickLengthMinValue_45(HandleRef pThis);

	/// <summary>
	/// Set/Get the length of the tick marks (expressed in pixels or display
	/// coordinates).
	/// </summary>
	public virtual int GetTickLengthMinValue()
	{
		return vtkAxisActor2D_GetTickLengthMinValue_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetTickOffset_46(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the labels (expressed in pixels or display
	/// coordinates). The offset is the distance of labels from tick marks
	/// or other objects.
	/// </summary>
	public virtual int GetTickOffset()
	{
		return vtkAxisActor2D_GetTickOffset_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetTickOffsetMaxValue_47(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the labels (expressed in pixels or display
	/// coordinates). The offset is the distance of labels from tick marks
	/// or other objects.
	/// </summary>
	public virtual int GetTickOffsetMaxValue()
	{
		return vtkAxisActor2D_GetTickOffsetMaxValue_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetTickOffsetMinValue_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the labels (expressed in pixels or display
	/// coordinates). The offset is the distance of labels from tick marks
	/// or other objects.
	/// </summary>
	public virtual int GetTickOffsetMinValue()
	{
		return vtkAxisActor2D_GetTickOffsetMinValue_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetTickVisibility_49(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis tick marks.
	/// </summary>
	public virtual int GetTickVisibility()
	{
		return vtkAxisActor2D_GetTickVisibility_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_GetTitle_50(HandleRef pThis);

	/// <summary>
	/// Set/Get the title of the scalar bar actor,
	/// </summary>
	public virtual string GetTitle()
	{
		return Marshal.PtrToStringAnsi(vtkAxisActor2D_GetTitle_50(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor2D_GetTitlePosition_51(HandleRef pThis);

	/// <summary>
	/// Set/Get position of the axis title. 0 is at the start of the
	/// axis whereas 1 is at the end.
	/// </summary>
	public virtual double GetTitlePosition()
	{
		return vtkAxisActor2D_GetTitlePosition_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_GetTitleTextProperty_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual vtkTextProperty GetTitleTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor2D_GetTitleTextProperty_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetTitleVisibility_53(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis title.
	/// </summary>
	public virtual int GetTitleVisibility()
	{
		return vtkAxisActor2D_GetTitleVisibility_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_GetUseFontSizeFromProperty_54(HandleRef pThis);

	/// <summary>
	/// By default the AxisActor controls the font size of the axis label.  If this
	/// option is set to true, it will instead use whatever font size is set in the
	/// vtkTextProperty, allowing external control of the axis size.
	/// </summary>
	public virtual int GetUseFontSizeFromProperty()
	{
		return vtkAxisActor2D_GetUseFontSizeFromProperty_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_HasTranslucentPolygonalGeometry_55(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkAxisActor2D_HasTranslucentPolygonalGeometry_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_IsA_56(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAxisActor2D_IsA_56(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_IsTypeOf_57(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAxisActor2D_IsTypeOf_57(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_LabelVisibilityOff_58(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis labels.
	/// </summary>
	public virtual void LabelVisibilityOff()
	{
		vtkAxisActor2D_LabelVisibilityOff_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_LabelVisibilityOn_59(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis labels.
	/// </summary>
	public virtual void LabelVisibilityOn()
	{
		vtkAxisActor2D_LabelVisibilityOn_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_NewInstance_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAxisActor2D NewInstance()
	{
		vtkAxisActor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor2D_NewInstance_61(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_ReleaseGraphicsResources_62(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkAxisActor2D_ReleaseGraphicsResources_62(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_RenderOpaqueGeometry_63(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Draw the axis.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkAxisActor2D_RenderOpaqueGeometry_63(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_RenderOverlay_64(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Draw the axis.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkAxisActor2D_RenderOverlay_64(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor2D_RenderTranslucentPolygonalGeometry_65(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the axis.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkAxisActor2D_RenderTranslucentPolygonalGeometry_65(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_RulerModeOff_66(HandleRef pThis);

	/// <summary>
	/// Specify whether this axis should act like a measuring tape (or ruler) with
	/// specified major tick spacing. If enabled, the distance between major ticks
	/// is controlled by the RulerDistance ivar.
	/// </summary>
	public virtual void RulerModeOff()
	{
		vtkAxisActor2D_RulerModeOff_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_RulerModeOn_67(HandleRef pThis);

	/// <summary>
	/// Specify whether this axis should act like a measuring tape (or ruler) with
	/// specified major tick spacing. If enabled, the distance between major ticks
	/// is controlled by the RulerDistance ivar.
	/// </summary>
	public virtual void RulerModeOn()
	{
		vtkAxisActor2D_RulerModeOn_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor2D_SafeDownCast_68(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAxisActor2D SafeDownCast(vtkObjectBase o)
	{
		vtkAxisActor2D vtkAxisActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor2D_SafeDownCast_68(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisActor2D2 = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisActor2D2.Register(null);
			}
		}
		return vtkAxisActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetAdjustLabels_69(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag that controls whether the labels and ticks are
	/// adjusted for "nice" numerical values to make it easier to read
	/// the labels. The adjustment is based in the Range instance variable.
	/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
	/// range and number of labels. Note that if RulerMode is on, then the
	/// number of labels is a function of the range and ruler distance.
	/// </summary>
	public virtual void SetAdjustLabels(int _arg)
	{
		vtkAxisActor2D_SetAdjustLabels_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetAxisVisibility_70(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get visibility of the axis line.
	/// </summary>
	public virtual void SetAxisVisibility(int _arg)
	{
		vtkAxisActor2D_SetAxisVisibility_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetFontFactor_71(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label and title the axes. This ivar used in conjunction with
	/// the LabelFactor can be used to control font sizes.
	/// </summary>
	public virtual void SetFontFactor(double _arg)
	{
		vtkAxisActor2D_SetFontFactor_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetLabelFactor_72(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the axis labels
	/// to the axis title.
	/// </summary>
	public virtual void SetLabelFactor(double _arg)
	{
		vtkAxisActor2D_SetLabelFactor_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetLabelFormat_73(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the format with which to print the labels on the scalar
	/// bar.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkAxisActor2D_SetLabelFormat_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetLabelTextProperty_74(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the labels text property.
	/// </summary>
	public virtual void SetLabelTextProperty(vtkTextProperty p)
	{
		vtkAxisActor2D_SetLabelTextProperty_74(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetLabelVisibility_75(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get visibility of the axis labels.
	/// </summary>
	public virtual void SetLabelVisibility(int _arg)
	{
		vtkAxisActor2D_SetLabelVisibility_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetMinorTickLength_76(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the length of the minor tick marks (expressed in pixels or
	/// display coordinates).
	/// </summary>
	public virtual void SetMinorTickLength(int _arg)
	{
		vtkAxisActor2D_SetMinorTickLength_76(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetNumberOfLabels_77(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of annotation labels to show. This also controls the
	/// number of major ticks shown. Note that this ivar only holds meaning if
	/// the RulerMode is off.
	/// </summary>
	public virtual void SetNumberOfLabels(int _arg)
	{
		vtkAxisActor2D_SetNumberOfLabels_77(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetNumberOfMinorTicks_78(HandleRef pThis, int _arg);

	/// <summary>
	/// Number of minor ticks to be displayed between each tick. Default
	/// is 0.
	/// </summary>
	public virtual void SetNumberOfMinorTicks(int _arg)
	{
		vtkAxisActor2D_SetNumberOfMinorTicks_78(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetPoint1_79(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Specify the position of the first point defining the axis.
	/// Note: backward compatibility only, use vtkActor2D's Position instead.
	/// </summary>
	public virtual void SetPoint1(IntPtr x)
	{
		vtkAxisActor2D_SetPoint1_79(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetPoint1_80(HandleRef pThis, double x, double y);

	/// <summary>
	/// Specify the position of the first point defining the axis.
	/// Note: backward compatibility only, use vtkActor2D's Position instead.
	/// </summary>
	public virtual void SetPoint1(double x, double y)
	{
		vtkAxisActor2D_SetPoint1_80(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetPoint2_81(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Specify the position of the second point defining the axis. Note that
	/// the order from Point1 to Point2 controls which side the tick marks
	/// are drawn on (ticks are drawn on the right, if visible).
	/// Note: backward compatibility only, use vtkActor2D's Position2 instead.
	/// </summary>
	public virtual void SetPoint2(IntPtr x)
	{
		vtkAxisActor2D_SetPoint2_81(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetPoint2_82(HandleRef pThis, double x, double y);

	/// <summary>
	/// Specify the position of the second point defining the axis. Note that
	/// the order from Point1 to Point2 controls which side the tick marks
	/// are drawn on (ticks are drawn on the right, if visible).
	/// Note: backward compatibility only, use vtkActor2D's Position2 instead.
	/// </summary>
	public virtual void SetPoint2(double x, double y)
	{
		vtkAxisActor2D_SetPoint2_82(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetRange_83(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify the (min,max) axis range. This will be used in the generation
	/// of labels, if labels are visible.
	/// </summary>
	public virtual void SetRange(double _arg1, double _arg2)
	{
		vtkAxisActor2D_SetRange_83(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetRange_84(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the (min,max) axis range. This will be used in the generation
	/// of labels, if labels are visible.
	/// </summary>
	public void SetRange(IntPtr _arg)
	{
		vtkAxisActor2D_SetRange_84(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetRulerDistance_85(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the RulerDistance which indicates the spacing of the major ticks.
	/// This ivar only has effect when the RulerMode is on.
	/// </summary>
	public virtual void SetRulerDistance(double _arg)
	{
		vtkAxisActor2D_SetRulerDistance_85(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetRulerMode_86(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether this axis should act like a measuring tape (or ruler) with
	/// specified major tick spacing. If enabled, the distance between major ticks
	/// is controlled by the RulerDistance ivar.
	/// </summary>
	public virtual void SetRulerMode(int _arg)
	{
		vtkAxisActor2D_SetRulerMode_86(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetSizeFontRelativeToAxis_87(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to size the fonts relative to the viewport or relative to
	/// length of the axis. By default, fonts are resized relative to the viewport.
	/// </summary>
	public virtual void SetSizeFontRelativeToAxis(int _arg)
	{
		vtkAxisActor2D_SetSizeFontRelativeToAxis_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetTickLength_88(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the length of the tick marks (expressed in pixels or display
	/// coordinates).
	/// </summary>
	public virtual void SetTickLength(int _arg)
	{
		vtkAxisActor2D_SetTickLength_88(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetTickOffset_89(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the offset of the labels (expressed in pixels or display
	/// coordinates). The offset is the distance of labels from tick marks
	/// or other objects.
	/// </summary>
	public virtual void SetTickOffset(int _arg)
	{
		vtkAxisActor2D_SetTickOffset_89(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetTickVisibility_90(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get visibility of the axis tick marks.
	/// </summary>
	public virtual void SetTickVisibility(int _arg)
	{
		vtkAxisActor2D_SetTickVisibility_90(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetTitle_91(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the title of the scalar bar actor,
	/// </summary>
	public virtual void SetTitle(string _arg)
	{
		vtkAxisActor2D_SetTitle_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetTitlePosition_92(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get position of the axis title. 0 is at the start of the
	/// axis whereas 1 is at the end.
	/// </summary>
	public virtual void SetTitlePosition(double _arg)
	{
		vtkAxisActor2D_SetTitlePosition_92(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetTitleTextProperty_93(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual void SetTitleTextProperty(vtkTextProperty p)
	{
		vtkAxisActor2D_SetTitleTextProperty_93(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetTitleVisibility_94(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get visibility of the axis title.
	/// </summary>
	public virtual void SetTitleVisibility(int _arg)
	{
		vtkAxisActor2D_SetTitleVisibility_94(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SetUseFontSizeFromProperty_95(HandleRef pThis, int _arg);

	/// <summary>
	/// By default the AxisActor controls the font size of the axis label.  If this
	/// option is set to true, it will instead use whatever font size is set in the
	/// vtkTextProperty, allowing external control of the axis size.
	/// </summary>
	public virtual void SetUseFontSizeFromProperty(int _arg)
	{
		vtkAxisActor2D_SetUseFontSizeFromProperty_95(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_ShallowCopy_96(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of an axis actor. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkAxisActor2D_ShallowCopy_96(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SizeFontRelativeToAxisOff_97(HandleRef pThis);

	/// <summary>
	/// Specify whether to size the fonts relative to the viewport or relative to
	/// length of the axis. By default, fonts are resized relative to the viewport.
	/// </summary>
	public virtual void SizeFontRelativeToAxisOff()
	{
		vtkAxisActor2D_SizeFontRelativeToAxisOff_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_SizeFontRelativeToAxisOn_98(HandleRef pThis);

	/// <summary>
	/// Specify whether to size the fonts relative to the viewport or relative to
	/// length of the axis. By default, fonts are resized relative to the viewport.
	/// </summary>
	public virtual void SizeFontRelativeToAxisOn()
	{
		vtkAxisActor2D_SizeFontRelativeToAxisOn_98(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_TickVisibilityOff_99(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis tick marks.
	/// </summary>
	public virtual void TickVisibilityOff()
	{
		vtkAxisActor2D_TickVisibilityOff_99(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_TickVisibilityOn_100(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis tick marks.
	/// </summary>
	public virtual void TickVisibilityOn()
	{
		vtkAxisActor2D_TickVisibilityOn_100(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_TitleVisibilityOff_101(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis title.
	/// </summary>
	public virtual void TitleVisibilityOff()
	{
		vtkAxisActor2D_TitleVisibilityOff_101(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_TitleVisibilityOn_102(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis title.
	/// </summary>
	public virtual void TitleVisibilityOn()
	{
		vtkAxisActor2D_TitleVisibilityOn_102(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_UseFontSizeFromPropertyOff_103(HandleRef pThis);

	/// <summary>
	/// By default the AxisActor controls the font size of the axis label.  If this
	/// option is set to true, it will instead use whatever font size is set in the
	/// vtkTextProperty, allowing external control of the axis size.
	/// </summary>
	public virtual void UseFontSizeFromPropertyOff()
	{
		vtkAxisActor2D_UseFontSizeFromPropertyOff_103(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor2D_UseFontSizeFromPropertyOn_104(HandleRef pThis);

	/// <summary>
	/// By default the AxisActor controls the font size of the axis label.  If this
	/// option is set to true, it will instead use whatever font size is set in the
	/// vtkTextProperty, allowing external control of the axis size.
	/// </summary>
	public virtual void UseFontSizeFromPropertyOn()
	{
		vtkAxisActor2D_UseFontSizeFromPropertyOn_104(GetCppThis());
	}
}
