using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAxisActor
/// </summary>
/// <remarks>
///    Create an axis with tick marks and labels
///
/// vtkAxisActor creates an axis with tick marks, labels, and/or a title,
/// depending on the particular instance variable settings. It is assumed that
/// the axes is part of a bounding box and is orthogonal to one of the
/// coordinate axes.  To use this class, you typically specify two points
/// defining the start and end points of the line (xyz definition using
/// vtkCoordinate class), the axis type (X, Y or Z), the axis location in
/// relation to the bounding box, the bounding box, the number of labels, and
/// the data range (min,max). You can also control what parts of the axis are
/// visible including the line, the tick marks, the labels, and the title. It
/// is also possible to control gridlines, and specify on which 'side' the
/// tickmarks are drawn (again with respect to the underlying assumed
/// bounding box). You can also specify the label format (a printf style format).
///
/// This class decides how to locate the labels, and how to create reasonable
/// tick marks and labels.
///
/// Labels follow the camera so as to be legible from any viewpoint.
///
/// The instance variables Point1 and Point2 are instances of vtkCoordinate.
/// All calculations and references are in World Coordinates.
///
/// @par Thanks:
/// This class was written by:
/// Hank Childs, Kathleen Bonnell, Amy Squillacote, Brad Whitlock,
/// Eric Brugger, Claire Guilbaud, Nicolas Dolegieviez, Will Schroeder,
/// Karthik Krishnan, Aashish Chaudhary, Philippe Pebay, David Gobbi,
/// David Partyka, Utkarsh Ayachit David Cole, Francois Bertel, and Mark Olesen
/// Part of this work was supported by CEA/DIF - Commissariat a l'Energie Atomique,
/// Centre DAM Ile-De-France, BP12, F-91297 Arpajon, France.
///
/// </remarks>
/// <seealso>
///
/// vtkActor vtkVectorText vtkPolyDataMapper vtkAxisActor2D vtkCoordinate
/// </seealso>
public class vtkAxisActor : vtkActor
{
	/// <summary>
	/// Set/Get visibility of the axis detached exponent.
	/// </summary>
	public enum AlignLocation
	{
		/// <summary>enum member</summary>
		VTK_ALIGN_BOTTOM = 1,
		/// <summary>enum member</summary>
		VTK_ALIGN_POINT1 = 2,
		/// <summary>enum member</summary>
		VTK_ALIGN_POINT2 = 3,
		/// <summary>enum member</summary>
		VTK_ALIGN_TOP = 0
	}

	/// <summary>
	/// Set/Get the type of this axis.
	/// </summary>
	public enum AxisPosition
	{
		/// <summary>enum member</summary>
		VTK_AXIS_POS_MAXMAX = 2,
		/// <summary>enum member</summary>
		VTK_AXIS_POS_MAXMIN = 3,
		/// <summary>enum member</summary>
		VTK_AXIS_POS_MINMAX = 1,
		/// <summary>enum member</summary>
		VTK_AXIS_POS_MINMIN = 0
	}

	/// <summary>
	/// Set/Get whether gridpolys should be drawn.
	/// </summary>
	public enum AxisType
	{
		/// <summary>enum member</summary>
		VTK_AXIS_TYPE_X,
		/// <summary>enum member</summary>
		VTK_AXIS_TYPE_Y,
		/// <summary>enum member</summary>
		VTK_AXIS_TYPE_Z
	}

	/// <summary>
	/// Set/Get the size of the major tick marks
	/// </summary>
	public enum TickLocation
	{
		/// <summary>enum member</summary>
		VTK_TICKS_BOTH = 2,
		/// <summary>enum member</summary>
		VTK_TICKS_INSIDE = 0,
		/// <summary>enum member</summary>
		VTK_TICKS_OUTSIDE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAxisActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAxisActor()
	{
		MRClassNameKey = "class vtkAxisActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxisActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAxisActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new static vtkAxisActor New()
	{
		vtkAxisActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxisActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public vtkAxisActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAxisActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAxisActor_AxisVisibilityOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis line.
	/// </summary>
	public virtual void AxisVisibilityOff()
	{
		vtkAxisActor_AxisVisibilityOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_AxisVisibilityOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis line.
	/// </summary>
	public virtual void AxisVisibilityOn()
	{
		vtkAxisActor_AxisVisibilityOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_BuildAxis_03(HandleRef pThis, HandleRef viewport, byte arg1);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points on
	/// the range and the delta values that determine their spacing. The
	/// range and the position need not be identical. ie the displayed
	/// values need not match the actual positions in 3D space.
	/// </summary>
	public void BuildAxis(vtkViewport viewport, bool arg1)
	{
		vtkAxisActor_BuildAxis_03(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), (byte)(arg1 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_CalculateLabelOffsetOff_04(HandleRef pThis);

	/// <summary>
	/// Set/Get flag whether to calculate label offset.
	/// Default is true.
	/// </summary>
	public virtual void CalculateLabelOffsetOff()
	{
		vtkAxisActor_CalculateLabelOffsetOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_CalculateLabelOffsetOn_05(HandleRef pThis);

	/// <summary>
	/// Set/Get flag whether to calculate label offset.
	/// Default is true.
	/// </summary>
	public virtual void CalculateLabelOffsetOn()
	{
		vtkAxisActor_CalculateLabelOffsetOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_CalculateTitleOffsetOff_06(HandleRef pThis);

	/// <summary>
	/// Set/Get flag whether to calculate title offset.
	/// Default is true.
	/// </summary>
	public virtual void CalculateTitleOffsetOff()
	{
		vtkAxisActor_CalculateTitleOffsetOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_CalculateTitleOffsetOn_07(HandleRef pThis);

	/// <summary>
	/// Set/Get flag whether to calculate title offset.
	/// Default is true.
	/// </summary>
	public virtual void CalculateTitleOffsetOn()
	{
		vtkAxisActor_CalculateTitleOffsetOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_ComputeMaxLabelLength_08(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public double ComputeMaxLabelLength(IntPtr arg0)
	{
		return vtkAxisActor_ComputeMaxLabelLength_08(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_ComputeTitleLength_09(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public double ComputeTitleLength(IntPtr arg0)
	{
		return vtkAxisActor_ComputeTitleLength_09(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_DrawGridlinesOff_10(HandleRef pThis);

	/// <summary>
	/// Set/Get whether gridlines should be drawn.
	/// </summary>
	public virtual void DrawGridlinesOff()
	{
		vtkAxisActor_DrawGridlinesOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_DrawGridlinesOn_11(HandleRef pThis);

	/// <summary>
	/// Set/Get whether gridlines should be drawn.
	/// </summary>
	public virtual void DrawGridlinesOn()
	{
		vtkAxisActor_DrawGridlinesOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_DrawGridlinesOnlyOff_12(HandleRef pThis);

	/// <summary>
	/// Set/Get whether ONLY the gridlines should be drawn.
	/// This will only draw GridLines and will skip any other part of the rendering
	/// such as Axis/Tick/Title/...
	/// </summary>
	public virtual void DrawGridlinesOnlyOff()
	{
		vtkAxisActor_DrawGridlinesOnlyOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_DrawGridlinesOnlyOn_13(HandleRef pThis);

	/// <summary>
	/// Set/Get whether ONLY the gridlines should be drawn.
	/// This will only draw GridLines and will skip any other part of the rendering
	/// such as Axis/Tick/Title/...
	/// </summary>
	public virtual void DrawGridlinesOnlyOn()
	{
		vtkAxisActor_DrawGridlinesOnlyOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_DrawGridpolysOff_14(HandleRef pThis);

	/// <summary>
	/// Set/Get whether gridpolys should be drawn.
	/// </summary>
	public virtual void DrawGridpolysOff()
	{
		vtkAxisActor_DrawGridpolysOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_DrawGridpolysOn_15(HandleRef pThis);

	/// <summary>
	/// Set/Get whether gridpolys should be drawn.
	/// </summary>
	public virtual void DrawGridpolysOn()
	{
		vtkAxisActor_DrawGridpolysOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_DrawInnerGridlinesOff_16(HandleRef pThis);

	/// <summary>
	/// Set/Get whether inner gridlines should be drawn.
	/// </summary>
	public virtual void DrawInnerGridlinesOff()
	{
		vtkAxisActor_DrawInnerGridlinesOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_DrawInnerGridlinesOn_17(HandleRef pThis);

	/// <summary>
	/// Set/Get whether inner gridlines should be drawn.
	/// </summary>
	public virtual void DrawInnerGridlinesOn()
	{
		vtkAxisActor_DrawInnerGridlinesOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_ExponentVisibilityOff_18(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis detached exponent.
	/// </summary>
	public virtual void ExponentVisibilityOff()
	{
		vtkAxisActor_ExponentVisibilityOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_ExponentVisibilityOn_19(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis detached exponent.
	/// </summary>
	public virtual void ExponentVisibilityOn()
	{
		vtkAxisActor_ExponentVisibilityOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetAxisBaseForX_20(HandleRef pThis);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual double[] GetAxisBaseForX()
	{
		IntPtr intPtr = vtkAxisActor_GetAxisBaseForX_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_GetAxisBaseForX_21(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void GetAxisBaseForX(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAxisActor_GetAxisBaseForX_21(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_GetAxisBaseForX_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void GetAxisBaseForX(IntPtr _arg)
	{
		vtkAxisActor_GetAxisBaseForX_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetAxisBaseForY_23(HandleRef pThis);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual double[] GetAxisBaseForY()
	{
		IntPtr intPtr = vtkAxisActor_GetAxisBaseForY_23(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_GetAxisBaseForY_24(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void GetAxisBaseForY(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAxisActor_GetAxisBaseForY_24(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_GetAxisBaseForY_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void GetAxisBaseForY(IntPtr _arg)
	{
		vtkAxisActor_GetAxisBaseForY_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetAxisBaseForZ_26(HandleRef pThis);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual double[] GetAxisBaseForZ()
	{
		IntPtr intPtr = vtkAxisActor_GetAxisBaseForZ_26(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_GetAxisBaseForZ_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void GetAxisBaseForZ(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAxisActor_GetAxisBaseForZ_27(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_GetAxisBaseForZ_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void GetAxisBaseForZ(IntPtr _arg)
	{
		vtkAxisActor_GetAxisBaseForZ_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetAxisLinesProperty_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axis actor property (axis and its ticks) (kept for compatibility)
	/// </summary>
	public vtkProperty GetAxisLinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetAxisLinesProperty_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetAxisMainLineProperty_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set main line axis actor property
	/// </summary>
	public vtkProperty GetAxisMainLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetAxisMainLineProperty_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetAxisMajorTicksProperty_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axis actor property (axis and its ticks)
	/// </summary>
	public vtkProperty GetAxisMajorTicksProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetAxisMajorTicksProperty_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetAxisMinorTicksProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axis actor property (axis and its ticks)
	/// </summary>
	public vtkProperty GetAxisMinorTicksProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetAxisMinorTicksProperty_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetAxisOnOrigin_33(HandleRef pThis);

	/// <summary>
	/// Notify the axes that is not part of a cube anymore
	/// </summary>
	public virtual int GetAxisOnOrigin()
	{
		return vtkAxisActor_GetAxisOnOrigin_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetAxisPosition_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of this axis (in relation to an an
	/// assumed bounding box).  For an x-type axis, MINMIN corresponds
	/// to the x-edge in the bounding box where Y values are minimum and
	/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
	/// y-edge where X values are maximum and Z values are minimum.
	/// </summary>
	public virtual int GetAxisPosition()
	{
		return vtkAxisActor_GetAxisPosition_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetAxisPositionMaxValue_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of this axis (in relation to an an
	/// assumed bounding box).  For an x-type axis, MINMIN corresponds
	/// to the x-edge in the bounding box where Y values are minimum and
	/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
	/// y-edge where X values are maximum and Z values are minimum.
	/// </summary>
	public virtual int GetAxisPositionMaxValue()
	{
		return vtkAxisActor_GetAxisPositionMaxValue_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetAxisPositionMinValue_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of this axis (in relation to an an
	/// assumed bounding box).  For an x-type axis, MINMIN corresponds
	/// to the x-edge in the bounding box where Y values are minimum and
	/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
	/// y-edge where X values are maximum and Z values are minimum.
	/// </summary>
	public virtual int GetAxisPositionMinValue()
	{
		return vtkAxisActor_GetAxisPositionMinValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetAxisType_37(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of this axis.
	/// </summary>
	public virtual int GetAxisType()
	{
		return vtkAxisActor_GetAxisType_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetAxisTypeMaxValue_38(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of this axis.
	/// </summary>
	public virtual int GetAxisTypeMaxValue()
	{
		return vtkAxisActor_GetAxisTypeMaxValue_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetAxisTypeMinValue_39(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of this axis.
	/// </summary>
	public virtual int GetAxisTypeMinValue()
	{
		return vtkAxisActor_GetAxisTypeMinValue_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetAxisVisibility_40(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis line.
	/// </summary>
	public virtual int GetAxisVisibility()
	{
		return vtkAxisActor_GetAxisVisibility_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetBounds_41(HandleRef pThis);

	/// <summary>
	/// Set or get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkAxisActor_GetBounds_41(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_GetBounds_42(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Set or get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public new void GetBounds(IntPtr bounds)
	{
		vtkAxisActor_GetBounds_42(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetCalculateLabelOffset_43(HandleRef pThis);

	/// <summary>
	/// Set/Get flag whether to calculate label offset.
	/// Default is true.
	/// </summary>
	public virtual int GetCalculateLabelOffset()
	{
		return vtkAxisActor_GetCalculateLabelOffset_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetCalculateTitleOffset_44(HandleRef pThis);

	/// <summary>
	/// Set/Get flag whether to calculate title offset.
	/// Default is true.
	/// </summary>
	public virtual int GetCalculateTitleOffset()
	{
		return vtkAxisActor_GetCalculateTitleOffset_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetCamera_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the camera for this axis.  The camera is used by the
	/// labels to 'follow' the camera and be legible from any viewpoint.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetCamera_45(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCamera2 = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCamera2.Register(null);
			}
		}
		return vtkCamera2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetDeltaMajor_46(HandleRef pThis, int axis);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points,
	/// and the delta values that determine their spacing.
	/// </summary>
	public double GetDeltaMajor(int axis)
	{
		return vtkAxisActor_GetDeltaMajor_46(GetCppThis(), axis);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetDeltaMinor_47(HandleRef pThis);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points,
	/// and the delta values that determine their spacing.
	/// </summary>
	public virtual double GetDeltaMinor()
	{
		return vtkAxisActor_GetDeltaMinor_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetDeltaRangeMajor_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points on
	/// the range and the delta values that determine their spacing. The
	/// range and the position need not be identical. ie the displayed
	/// values need not match the actual positions in 3D space.
	/// </summary>
	public virtual double GetDeltaRangeMajor()
	{
		return vtkAxisActor_GetDeltaRangeMajor_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetDeltaRangeMinor_49(HandleRef pThis);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points on
	/// the range and the delta values that determine their spacing. The
	/// range and the position need not be identical. ie the displayed
	/// values need not match the actual positions in 3D space.
	/// </summary>
	public virtual double GetDeltaRangeMinor()
	{
		return vtkAxisActor_GetDeltaRangeMinor_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetDrawGridlines_50(HandleRef pThis);

	/// <summary>
	/// Set/Get whether gridlines should be drawn.
	/// </summary>
	public virtual int GetDrawGridlines()
	{
		return vtkAxisActor_GetDrawGridlines_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetDrawGridlinesLocation_51(HandleRef pThis);

	/// <summary>
	/// Set/Get whether ONLY the gridlines should be drawn.
	/// This will only draw GridLines and will skip any other part of the rendering
	/// such as Axis/Tick/Title/...
	/// </summary>
	public virtual int GetDrawGridlinesLocation()
	{
		return vtkAxisActor_GetDrawGridlinesLocation_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetDrawGridlinesOnly_52(HandleRef pThis);

	/// <summary>
	/// Set/Get whether ONLY the gridlines should be drawn.
	/// This will only draw GridLines and will skip any other part of the rendering
	/// such as Axis/Tick/Title/...
	/// </summary>
	public virtual int GetDrawGridlinesOnly()
	{
		return vtkAxisActor_GetDrawGridlinesOnly_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetDrawGridpolys_53(HandleRef pThis);

	/// <summary>
	/// Set/Get whether gridpolys should be drawn.
	/// </summary>
	public virtual int GetDrawGridpolys()
	{
		return vtkAxisActor_GetDrawGridpolys_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetDrawInnerGridlines_54(HandleRef pThis);

	/// <summary>
	/// Set/Get whether inner gridlines should be drawn.
	/// </summary>
	public virtual int GetDrawInnerGridlines()
	{
		return vtkAxisActor_GetDrawInnerGridlines_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetExponent_55(HandleRef pThis);

	/// <summary>
	/// Set/Get the common exponent of the labels values
	/// </summary>
	public virtual string GetExponent()
	{
		return Marshal.PtrToStringAnsi(vtkAxisActor_GetExponent_55(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetExponentActor_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get exponent follower actor
	/// </summary>
	public virtual vtkAxisFollower GetExponentActor()
	{
		vtkAxisFollower vtkAxisFollower2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetExponentActor_56(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisFollower2 = (vtkAxisFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisFollower2.Register(null);
			}
		}
		return vtkAxisFollower2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetExponentLocation_57(HandleRef pThis);

	/// <summary>
	/// Get/Set the location of the Detached Exponent related to the axis.
	/// Possible Location: VTK_ALIGN_TOP, VTK_ALIGN_BOTTOM, VTK_ALIGN_POINT1, VTK_ALIGN_POINT2
	/// </summary>
	public virtual int GetExponentLocation()
	{
		return vtkAxisActor_GetExponentLocation_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetExponentOffset_58(HandleRef pThis);

	/// <summary>
	/// Set/Get the offsets used to position texts.
	/// </summary>
	public virtual double GetExponentOffset()
	{
		return vtkAxisActor_GetExponentOffset_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetExponentProp3D_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get title actor and it is responsible for drawing
	/// title text.
	/// </summary>
	public virtual vtkProp3DAxisFollower GetExponentProp3D()
	{
		vtkProp3DAxisFollower vtkProp3DAxisFollower2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetExponentProp3D_59(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3DAxisFollower2 = (vtkProp3DAxisFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3DAxisFollower2.Register(null);
			}
		}
		return vtkProp3DAxisFollower2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxisActor_GetExponentVisibility_60(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis detached exponent.
	/// </summary>
	public virtual bool GetExponentVisibility()
	{
		return (vtkAxisActor_GetExponentVisibility_60(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetGridlineXLength_61(HandleRef pThis);

	/// <summary>
	/// Set/Get the length to use when drawing gridlines.
	/// </summary>
	public virtual double GetGridlineXLength()
	{
		return vtkAxisActor_GetGridlineXLength_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetGridlineYLength_62(HandleRef pThis);

	/// <summary>
	/// Set/Get the length to use when drawing gridlines.
	/// </summary>
	public virtual double GetGridlineYLength()
	{
		return vtkAxisActor_GetGridlineYLength_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetGridlineZLength_63(HandleRef pThis);

	/// <summary>
	/// Set/Get the length to use when drawing gridlines.
	/// </summary>
	public virtual double GetGridlineZLength()
	{
		return vtkAxisActor_GetGridlineZLength_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetGridlinesProperty_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set gridlines actor property (outer grid lines)
	/// </summary>
	public vtkProperty GetGridlinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetGridlinesProperty_64(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetGridpolysProperty_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set gridPolys actor property (grid quads)
	/// </summary>
	public vtkProperty GetGridpolysProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetGridpolysProperty_65(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetHorizontalOffsetYTitle2D_66(HandleRef pThis);

	/// <summary>
	/// Set/Get the 2D mode the horizontal offset for Y title in 2D mode
	/// </summary>
	public virtual double GetHorizontalOffsetYTitle2D()
	{
		return vtkAxisActor_GetHorizontalOffsetYTitle2D_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetInnerGridlinesProperty_67(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set inner gridlines actor property
	/// </summary>
	public vtkProperty GetInnerGridlinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetInnerGridlinesProperty_67(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetLabelFormat_68(HandleRef pThis);

	/// <summary>
	/// Set/Get the format with which to print the labels on the axis.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkAxisActor_GetLabelFormat_68(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetLabelOffset_69(HandleRef pThis);

	/// <summary>
	/// Set/Get the offsets used to position texts.
	/// </summary>
	public virtual double GetLabelOffset()
	{
		return vtkAxisActor_GetLabelOffset_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetLabelTextProperty_70(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the axis labels text property.
	/// </summary>
	public virtual vtkTextProperty GetLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetLabelTextProperty_70(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkAxisActor_GetLabelVisibility_71(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis labels.
	/// </summary>
	public virtual int GetLabelVisibility()
	{
		return vtkAxisActor_GetLabelVisibility_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxisActor_GetLastMajorTickPointCorrection_72(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis detached exponent.
	/// </summary>
	public virtual bool GetLastMajorTickPointCorrection()
	{
		return (vtkAxisActor_GetLastMajorTickPointCorrection_72(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxisActor_GetLog_73(HandleRef pThis);

	/// <summary>
	/// Set/Get The type of scale, enable logarithmic scale or linear by default
	/// </summary>
	public virtual bool GetLog()
	{
		return (vtkAxisActor_GetLog_73(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetMajorRangeStart_74(HandleRef pThis);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points on
	/// the range and the delta values that determine their spacing. The
	/// range and the position need not be identical. ie the displayed
	/// values need not match the actual positions in 3D space.
	/// </summary>
	public virtual double GetMajorRangeStart()
	{
		return vtkAxisActor_GetMajorRangeStart_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetMajorStart_75(HandleRef pThis, int axis);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points,
	/// and the delta values that determine their spacing.
	/// </summary>
	public double GetMajorStart(int axis)
	{
		return vtkAxisActor_GetMajorStart_75(GetCppThis(), axis);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetMajorTickSize_76(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the major tick marks
	/// </summary>
	public virtual double GetMajorTickSize()
	{
		return vtkAxisActor_GetMajorTickSize_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetMinorRangeStart_77(HandleRef pThis);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points on
	/// the range and the delta values that determine their spacing. The
	/// range and the position need not be identical. ie the displayed
	/// values need not match the actual positions in 3D space.
	/// </summary>
	public virtual double GetMinorRangeStart()
	{
		return vtkAxisActor_GetMinorRangeStart_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetMinorStart_78(HandleRef pThis);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points,
	/// and the delta values that determine their spacing.
	/// </summary>
	public virtual double GetMinorStart()
	{
		return vtkAxisActor_GetMinorStart_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetMinorTickSize_79(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the major tick marks
	/// </summary>
	public virtual double GetMinorTickSize()
	{
		return vtkAxisActor_GetMinorTickSize_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetMinorTicksVisible_80(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether the minor ticks are visible.
	/// </summary>
	public virtual int GetMinorTicksVisible()
	{
		return vtkAxisActor_GetMinorTicksVisible_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxisActor_GetNumberOfGenerationsFromBase_81(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAxisActor_GetNumberOfGenerationsFromBase_81(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxisActor_GetNumberOfGenerationsFromBaseType_82(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAxisActor_GetNumberOfGenerationsFromBaseType_82(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetNumberOfLabelsBuilt_83(HandleRef pThis);

	/// <summary>
	/// Get total number of labels built. Once built
	/// this count does not change.
	/// </summary>
	public virtual int GetNumberOfLabelsBuilt()
	{
		return vtkAxisActor_GetNumberOfLabelsBuilt_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetPoint1_84(HandleRef pThis);

	/// <summary>
	/// Specify the position of the first point defining the axis.
	/// </summary>
	public virtual IntPtr GetPoint1()
	{
		return vtkAxisActor_GetPoint1_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetPoint1Coordinate_85(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the position of the first point defining the axis.
	/// </summary>
	public virtual vtkCoordinate GetPoint1Coordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetPoint1Coordinate_85(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAxisActor_GetPoint2_86(HandleRef pThis);

	/// <summary>
	/// Specify the position of the second point defining the axis.
	/// </summary>
	public virtual IntPtr GetPoint2()
	{
		return vtkAxisActor_GetPoint2_86(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetPoint2Coordinate_87(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the position of the second point defining the axis.
	/// </summary>
	public virtual vtkCoordinate GetPoint2Coordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetPoint2Coordinate_87(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAxisActor_GetRange_88(HandleRef pThis);

	/// <summary>
	/// Specify the (min,max) axis range. This will be used in the generation
	/// of labels, if labels are visible.
	/// </summary>
	public virtual double[] GetRange()
	{
		IntPtr intPtr = vtkAxisActor_GetRange_88(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_GetRange_89(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the (min,max) axis range. This will be used in the generation
	/// of labels, if labels are visible.
	/// </summary>
	public virtual void GetRange(IntPtr data)
	{
		vtkAxisActor_GetRange_89(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetSaveTitlePosition_90(HandleRef pThis);

	/// <summary>
	/// Set/Get whether title position must be saved in 2D mode
	/// </summary>
	public virtual int GetSaveTitlePosition()
	{
		return vtkAxisActor_GetSaveTitlePosition_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetScreenSize_91(HandleRef pThis);

	/// <summary>
	/// Set/Get the offsets used to position texts.
	/// </summary>
	public virtual double GetScreenSize()
	{
		return vtkAxisActor_GetScreenSize_91(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetTickLocation_92(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the ticks.
	/// Inside: tick end toward positive direction of perpendicular axes.
	/// Outside: tick end toward negative direction of perpendicular axes.
	/// </summary>
	public virtual int GetTickLocation()
	{
		return vtkAxisActor_GetTickLocation_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetTickLocationMaxValue_93(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the ticks.
	/// Inside: tick end toward positive direction of perpendicular axes.
	/// Outside: tick end toward negative direction of perpendicular axes.
	/// </summary>
	public virtual int GetTickLocationMaxValue()
	{
		return vtkAxisActor_GetTickLocationMaxValue_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetTickLocationMinValue_94(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the ticks.
	/// Inside: tick end toward positive direction of perpendicular axes.
	/// Outside: tick end toward negative direction of perpendicular axes.
	/// </summary>
	public virtual int GetTickLocationMinValue()
	{
		return vtkAxisActor_GetTickLocationMinValue_94(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetTickVisibility_95(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis major tick marks.
	/// </summary>
	public virtual int GetTickVisibility()
	{
		return vtkAxisActor_GetTickVisibility_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetTitle_96(HandleRef pThis);

	/// <summary>
	/// Set/Get the title of the axis actor,
	/// </summary>
	public virtual string GetTitle()
	{
		return Marshal.PtrToStringAnsi(vtkAxisActor_GetTitle_96(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetTitleActor_97(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get title actor and it is responsible for drawing
	/// title text.
	/// </summary>
	public virtual vtkAxisFollower GetTitleActor()
	{
		vtkAxisFollower vtkAxisFollower2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetTitleActor_97(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisFollower2 = (vtkAxisFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisFollower2.Register(null);
			}
		}
		return vtkAxisFollower2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetTitleAlignLocation_98(HandleRef pThis);

	/// <summary>
	/// Get/Set the alignment of the title related to the axis.
	/// Possible Alignment: VTK_ALIGN_TOP, VTK_ALIGN_BOTTOM, VTK_ALIGN_POINT1, VTK_ALIGN_POINT2
	/// </summary>
	public virtual int GetTitleAlignLocation()
	{
		return vtkAxisActor_GetTitleAlignLocation_98(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetTitleOffset_99(HandleRef pThis);

	/// <summary>
	/// Set/Get the offsets used to position texts.
	/// </summary>
	public virtual double GetTitleOffset()
	{
		return vtkAxisActor_GetTitleOffset_99(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetTitleProp3D_100(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get title actor and it is responsible for drawing
	/// title text.
	/// </summary>
	public virtual vtkProp3DAxisFollower GetTitleProp3D()
	{
		vtkProp3DAxisFollower vtkProp3DAxisFollower2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetTitleProp3D_100(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3DAxisFollower2 = (vtkProp3DAxisFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3DAxisFollower2.Register(null);
			}
		}
		return vtkProp3DAxisFollower2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_GetTitleTextProperty_101(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the axis title text property.
	/// </summary>
	public virtual vtkTextProperty GetTitleTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_GetTitleTextProperty_101(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkAxisActor_GetTitleVisibility_102(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis title.
	/// </summary>
	public virtual int GetTitleVisibility()
	{
		return vtkAxisActor_GetTitleVisibility_102(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetUse2DMode_103(HandleRef pThis);

	/// <summary>
	/// Set/Get the 2D mode
	/// </summary>
	public virtual int GetUse2DMode()
	{
		return vtkAxisActor_GetUse2DMode_103(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_GetUseTextActor3D_104(HandleRef pThis);

	/// <summary>
	/// Render text as polygons (vtkVectorText) or as sprites (vtkTextActor3D).
	/// In 2D mode, the value is ignored and text is rendered as vtkTextActor.
	/// False(0) by default.
	/// See Also:
	/// GetUse2DMode(), SetUse2DMode
	/// </summary>
	public virtual int GetUseTextActor3D()
	{
		return vtkAxisActor_GetUseTextActor3D_104(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisActor_GetVerticalOffsetXTitle2D_105(HandleRef pThis);

	/// <summary>
	/// Set/Get the 2D mode the vertical offset for X title in 2D mode
	/// </summary>
	public virtual double GetVerticalOffsetXTitle2D()
	{
		return vtkAxisActor_GetVerticalOffsetXTitle2D_105(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_HasTranslucentPolygonalGeometry_106(HandleRef pThis);

	/// <summary>
	/// Draw the axis.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkAxisActor_HasTranslucentPolygonalGeometry_106(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_IsA_107(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAxisActor_IsA_107(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_IsTypeOf_108(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAxisActor_IsTypeOf_108(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_LabelVisibilityOff_109(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis labels.
	/// </summary>
	public virtual void LabelVisibilityOff()
	{
		vtkAxisActor_LabelVisibilityOff_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_LabelVisibilityOn_110(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis labels.
	/// </summary>
	public virtual void LabelVisibilityOn()
	{
		vtkAxisActor_LabelVisibilityOn_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_LastMajorTickPointCorrectionOff_111(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis detached exponent.
	/// </summary>
	public virtual void LastMajorTickPointCorrectionOff()
	{
		vtkAxisActor_LastMajorTickPointCorrectionOff_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_LastMajorTickPointCorrectionOn_112(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis detached exponent.
	/// </summary>
	public virtual void LastMajorTickPointCorrectionOn()
	{
		vtkAxisActor_LastMajorTickPointCorrectionOn_112(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_LogOff_113(HandleRef pThis);

	/// <summary>
	/// Set/Get The type of scale, enable logarithmic scale or linear by default
	/// </summary>
	public virtual void LogOff()
	{
		vtkAxisActor_LogOff_113(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_LogOn_114(HandleRef pThis);

	/// <summary>
	/// Set/Get The type of scale, enable logarithmic scale or linear by default
	/// </summary>
	public virtual void LogOn()
	{
		vtkAxisActor_LogOn_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_MinorTicksVisibleOff_115(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether the minor ticks are visible.
	/// </summary>
	public virtual void MinorTicksVisibleOff()
	{
		vtkAxisActor_MinorTicksVisibleOff_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_MinorTicksVisibleOn_116(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether the minor ticks are visible.
	/// </summary>
	public virtual void MinorTicksVisibleOn()
	{
		vtkAxisActor_MinorTicksVisibleOn_116(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_NewInstance_118(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAxisActor NewInstance()
	{
		vtkAxisActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_NewInstance_118(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxisActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_ReleaseGraphicsResources_119(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkAxisActor_ReleaseGraphicsResources_119(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_RenderOpaqueGeometry_120(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Draw the axis.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkAxisActor_RenderOpaqueGeometry_120(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_RenderOverlay_121(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Draw the axis.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkAxisActor_RenderOverlay_121(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_RenderTranslucentGeometry_122(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Draw the axis.
	/// </summary>
	public virtual int RenderTranslucentGeometry(vtkViewport viewport)
	{
		return vtkAxisActor_RenderTranslucentGeometry_122(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisActor_RenderTranslucentPolygonalGeometry_123(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Draw the axis.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkAxisActor_RenderTranslucentPolygonalGeometry_123(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisActor_SafeDownCast_124(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAxisActor SafeDownCast(vtkObjectBase o)
	{
		vtkAxisActor vtkAxisActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisActor_SafeDownCast_124(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisActor2 = (vtkAxisActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisActor2.Register(null);
			}
		}
		return vtkAxisActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisBaseForX_125(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void SetAxisBaseForX(double _arg1, double _arg2, double _arg3)
	{
		vtkAxisActor_SetAxisBaseForX_125(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisBaseForX_126(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void SetAxisBaseForX(IntPtr _arg)
	{
		vtkAxisActor_SetAxisBaseForX_126(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisBaseForY_127(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void SetAxisBaseForY(double _arg1, double _arg2, double _arg3)
	{
		vtkAxisActor_SetAxisBaseForY_127(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisBaseForY_128(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void SetAxisBaseForY(IntPtr _arg)
	{
		vtkAxisActor_SetAxisBaseForY_128(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisBaseForZ_129(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void SetAxisBaseForZ(double _arg1, double _arg2, double _arg3)
	{
		vtkAxisActor_SetAxisBaseForZ_129(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisBaseForZ_130(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Provide real vector for non aligned axis
	/// </summary>
	public virtual void SetAxisBaseForZ(IntPtr _arg)
	{
		vtkAxisActor_SetAxisBaseForZ_130(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisLinesProperty_131(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axis actor property (axis and its ticks) (kept for compatibility)
	/// </summary>
	public void SetAxisLinesProperty(vtkProperty arg0)
	{
		vtkAxisActor_SetAxisLinesProperty_131(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisMainLineProperty_132(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set main line axis actor property
	/// </summary>
	public void SetAxisMainLineProperty(vtkProperty arg0)
	{
		vtkAxisActor_SetAxisMainLineProperty_132(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisMajorTicksProperty_133(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axis actor property (axis and its ticks)
	/// </summary>
	public void SetAxisMajorTicksProperty(vtkProperty arg0)
	{
		vtkAxisActor_SetAxisMajorTicksProperty_133(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisMinorTicksProperty_134(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axis actor property (axis and its ticks)
	/// </summary>
	public void SetAxisMinorTicksProperty(vtkProperty arg0)
	{
		vtkAxisActor_SetAxisMinorTicksProperty_134(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisOnOrigin_135(HandleRef pThis, int _arg);

	/// <summary>
	/// Notify the axes that is not part of a cube anymore
	/// </summary>
	public virtual void SetAxisOnOrigin(int _arg)
	{
		vtkAxisActor_SetAxisOnOrigin_135(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisPosition_136(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the position of this axis (in relation to an an
	/// assumed bounding box).  For an x-type axis, MINMIN corresponds
	/// to the x-edge in the bounding box where Y values are minimum and
	/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
	/// y-edge where X values are maximum and Z values are minimum.
	/// </summary>
	public virtual void SetAxisPosition(int _arg)
	{
		vtkAxisActor_SetAxisPosition_136(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisPositionToMaxMax_137(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of this axis (in relation to an an
	/// assumed bounding box).  For an x-type axis, MINMIN corresponds
	/// to the x-edge in the bounding box where Y values are minimum and
	/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
	/// y-edge where X values are maximum and Z values are minimum.
	/// </summary>
	public void SetAxisPositionToMaxMax()
	{
		vtkAxisActor_SetAxisPositionToMaxMax_137(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisPositionToMaxMin_138(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of this axis (in relation to an an
	/// assumed bounding box).  For an x-type axis, MINMIN corresponds
	/// to the x-edge in the bounding box where Y values are minimum and
	/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
	/// y-edge where X values are maximum and Z values are minimum.
	/// </summary>
	public void SetAxisPositionToMaxMin()
	{
		vtkAxisActor_SetAxisPositionToMaxMin_138(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisPositionToMinMax_139(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of this axis (in relation to an an
	/// assumed bounding box).  For an x-type axis, MINMIN corresponds
	/// to the x-edge in the bounding box where Y values are minimum and
	/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
	/// y-edge where X values are maximum and Z values are minimum.
	/// </summary>
	public void SetAxisPositionToMinMax()
	{
		vtkAxisActor_SetAxisPositionToMinMax_139(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisPositionToMinMin_140(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of this axis (in relation to an an
	/// assumed bounding box).  For an x-type axis, MINMIN corresponds
	/// to the x-edge in the bounding box where Y values are minimum and
	/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
	/// y-edge where X values are maximum and Z values are minimum.
	/// </summary>
	public void SetAxisPositionToMinMin()
	{
		vtkAxisActor_SetAxisPositionToMinMin_140(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisType_141(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the type of this axis.
	/// </summary>
	public virtual void SetAxisType(int _arg)
	{
		vtkAxisActor_SetAxisType_141(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisTypeToX_142(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of this axis.
	/// </summary>
	public void SetAxisTypeToX()
	{
		vtkAxisActor_SetAxisTypeToX_142(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisTypeToY_143(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of this axis.
	/// </summary>
	public void SetAxisTypeToY()
	{
		vtkAxisActor_SetAxisTypeToY_143(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisTypeToZ_144(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of this axis.
	/// </summary>
	public void SetAxisTypeToZ()
	{
		vtkAxisActor_SetAxisTypeToZ_144(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetAxisVisibility_145(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get visibility of the axis line.
	/// </summary>
	public virtual void SetAxisVisibility(int _arg)
	{
		vtkAxisActor_SetAxisVisibility_145(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetBounds_146(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Set or get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public void SetBounds(IntPtr bounds)
	{
		vtkAxisActor_SetBounds_146(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetBounds_147(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Set or get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public void SetBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkAxisActor_SetBounds_147(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetCalculateLabelOffset_148(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get flag whether to calculate label offset.
	/// Default is true.
	/// </summary>
	public virtual void SetCalculateLabelOffset(int _arg)
	{
		vtkAxisActor_SetCalculateLabelOffset_148(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetCalculateTitleOffset_149(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get flag whether to calculate title offset.
	/// Default is true.
	/// </summary>
	public virtual void SetCalculateTitleOffset(int _arg)
	{
		vtkAxisActor_SetCalculateTitleOffset_149(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetCamera_150(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the camera for this axis.  The camera is used by the
	/// labels to 'follow' the camera and be legible from any viewpoint.
	/// </summary>
	public virtual void SetCamera(vtkCamera arg0)
	{
		vtkAxisActor_SetCamera_150(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetDeltaMajor_151(HandleRef pThis, int axis, double value);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points,
	/// and the delta values that determine their spacing.
	/// </summary>
	public void SetDeltaMajor(int axis, double value)
	{
		vtkAxisActor_SetDeltaMajor_151(GetCppThis(), axis, value);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetDeltaMinor_152(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points,
	/// and the delta values that determine their spacing.
	/// </summary>
	public virtual void SetDeltaMinor(double _arg)
	{
		vtkAxisActor_SetDeltaMinor_152(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetDeltaRangeMajor_153(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points on
	/// the range and the delta values that determine their spacing. The
	/// range and the position need not be identical. ie the displayed
	/// values need not match the actual positions in 3D space.
	/// </summary>
	public virtual void SetDeltaRangeMajor(double _arg)
	{
		vtkAxisActor_SetDeltaRangeMajor_153(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetDeltaRangeMinor_154(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points on
	/// the range and the delta values that determine their spacing. The
	/// range and the position need not be identical. ie the displayed
	/// values need not match the actual positions in 3D space.
	/// </summary>
	public virtual void SetDeltaRangeMinor(double _arg)
	{
		vtkAxisActor_SetDeltaRangeMinor_154(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetDrawGridlines_155(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether gridlines should be drawn.
	/// </summary>
	public virtual void SetDrawGridlines(int _arg)
	{
		vtkAxisActor_SetDrawGridlines_155(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetDrawGridlinesLocation_156(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether ONLY the gridlines should be drawn.
	/// This will only draw GridLines and will skip any other part of the rendering
	/// such as Axis/Tick/Title/...
	/// </summary>
	public virtual void SetDrawGridlinesLocation(int _arg)
	{
		vtkAxisActor_SetDrawGridlinesLocation_156(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetDrawGridlinesOnly_157(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether ONLY the gridlines should be drawn.
	/// This will only draw GridLines and will skip any other part of the rendering
	/// such as Axis/Tick/Title/...
	/// </summary>
	public virtual void SetDrawGridlinesOnly(int _arg)
	{
		vtkAxisActor_SetDrawGridlinesOnly_157(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetDrawGridpolys_158(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether gridpolys should be drawn.
	/// </summary>
	public virtual void SetDrawGridpolys(int _arg)
	{
		vtkAxisActor_SetDrawGridpolys_158(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetDrawInnerGridlines_159(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether inner gridlines should be drawn.
	/// </summary>
	public virtual void SetDrawInnerGridlines(int _arg)
	{
		vtkAxisActor_SetDrawInnerGridlines_159(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetExponent_160(HandleRef pThis, string t);

	/// <summary>
	/// Set/Get the common exponent of the labels values
	/// </summary>
	public void SetExponent(string t)
	{
		vtkAxisActor_SetExponent_160(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetExponentLocation_161(HandleRef pThis, int location);

	/// <summary>
	/// Get/Set the location of the Detached Exponent related to the axis.
	/// Possible Location: VTK_ALIGN_TOP, VTK_ALIGN_BOTTOM, VTK_ALIGN_POINT1, VTK_ALIGN_POINT2
	/// </summary>
	public virtual void SetExponentLocation(int location)
	{
		vtkAxisActor_SetExponentLocation_161(GetCppThis(), location);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetExponentOffset_162(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the offsets used to position texts.
	/// </summary>
	public virtual void SetExponentOffset(double _arg)
	{
		vtkAxisActor_SetExponentOffset_162(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetExponentVisibility_163(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get visibility of the axis detached exponent.
	/// </summary>
	public virtual void SetExponentVisibility(bool _arg)
	{
		vtkAxisActor_SetExponentVisibility_163(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetGridlineXLength_164(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the length to use when drawing gridlines.
	/// </summary>
	public virtual void SetGridlineXLength(double _arg)
	{
		vtkAxisActor_SetGridlineXLength_164(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetGridlineYLength_165(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the length to use when drawing gridlines.
	/// </summary>
	public virtual void SetGridlineYLength(double _arg)
	{
		vtkAxisActor_SetGridlineYLength_165(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetGridlineZLength_166(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the length to use when drawing gridlines.
	/// </summary>
	public virtual void SetGridlineZLength(double _arg)
	{
		vtkAxisActor_SetGridlineZLength_166(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetGridlinesProperty_167(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set gridlines actor property (outer grid lines)
	/// </summary>
	public void SetGridlinesProperty(vtkProperty arg0)
	{
		vtkAxisActor_SetGridlinesProperty_167(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetGridpolysProperty_168(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set gridPolys actor property (grid quads)
	/// </summary>
	public void SetGridpolysProperty(vtkProperty arg0)
	{
		vtkAxisActor_SetGridpolysProperty_168(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetHorizontalOffsetYTitle2D_169(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the 2D mode the horizontal offset for Y title in 2D mode
	/// </summary>
	public virtual void SetHorizontalOffsetYTitle2D(double _arg)
	{
		vtkAxisActor_SetHorizontalOffsetYTitle2D_169(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetInnerGridlinesProperty_170(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set inner gridlines actor property
	/// </summary>
	public void SetInnerGridlinesProperty(vtkProperty arg0)
	{
		vtkAxisActor_SetInnerGridlinesProperty_170(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetLabelFormat_171(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the format with which to print the labels on the axis.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkAxisActor_SetLabelFormat_171(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetLabelOffset_172(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the offsets used to position texts.
	/// </summary>
	public virtual void SetLabelOffset(double _arg)
	{
		vtkAxisActor_SetLabelOffset_172(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetLabelScale_173(HandleRef pThis, double scale);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public void SetLabelScale(double scale)
	{
		vtkAxisActor_SetLabelScale_173(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetLabelScale_174(HandleRef pThis, int labelIndex, double scale);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public void SetLabelScale(int labelIndex, double scale)
	{
		vtkAxisActor_SetLabelScale_174(GetCppThis(), labelIndex, scale);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetLabelTextProperty_175(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the axis labels text property.
	/// </summary>
	public virtual void SetLabelTextProperty(vtkTextProperty p)
	{
		vtkAxisActor_SetLabelTextProperty_175(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetLabelVisibility_176(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get visibility of the axis labels.
	/// </summary>
	public virtual void SetLabelVisibility(int _arg)
	{
		vtkAxisActor_SetLabelVisibility_176(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetLabels_177(HandleRef pThis, HandleRef labels);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points on
	/// the range and the delta values that determine their spacing. The
	/// range and the position need not be identical. ie the displayed
	/// values need not match the actual positions in 3D space.
	/// </summary>
	public void SetLabels(vtkStringArray labels)
	{
		vtkAxisActor_SetLabels_177(GetCppThis(), labels?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetLastMajorTickPointCorrection_178(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get visibility of the axis detached exponent.
	/// </summary>
	public virtual void SetLastMajorTickPointCorrection(bool _arg)
	{
		vtkAxisActor_SetLastMajorTickPointCorrection_178(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetLog_179(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get The type of scale, enable logarithmic scale or linear by default
	/// </summary>
	public virtual void SetLog(bool _arg)
	{
		vtkAxisActor_SetLog_179(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetMajorRangeStart_180(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points on
	/// the range and the delta values that determine their spacing. The
	/// range and the position need not be identical. ie the displayed
	/// values need not match the actual positions in 3D space.
	/// </summary>
	public virtual void SetMajorRangeStart(double _arg)
	{
		vtkAxisActor_SetMajorRangeStart_180(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetMajorStart_181(HandleRef pThis, int axis, double value);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points,
	/// and the delta values that determine their spacing.
	/// </summary>
	public void SetMajorStart(int axis, double value)
	{
		vtkAxisActor_SetMajorStart_181(GetCppThis(), axis, value);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetMajorTickSize_182(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the size of the major tick marks
	/// </summary>
	public virtual void SetMajorTickSize(double _arg)
	{
		vtkAxisActor_SetMajorTickSize_182(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetMinorRangeStart_183(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points on
	/// the range and the delta values that determine their spacing. The
	/// range and the position need not be identical. ie the displayed
	/// values need not match the actual positions in 3D space.
	/// </summary>
	public virtual void SetMinorRangeStart(double _arg)
	{
		vtkAxisActor_SetMinorRangeStart_183(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetMinorStart_184(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the starting position for minor and major tick points,
	/// and the delta values that determine their spacing.
	/// </summary>
	public virtual void SetMinorStart(double _arg)
	{
		vtkAxisActor_SetMinorStart_184(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetMinorTickSize_185(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the size of the major tick marks
	/// </summary>
	public virtual void SetMinorTickSize(double _arg)
	{
		vtkAxisActor_SetMinorTickSize_185(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetMinorTicksVisible_186(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag that controls whether the minor ticks are visible.
	/// </summary>
	public virtual void SetMinorTicksVisible(int _arg)
	{
		vtkAxisActor_SetMinorTicksVisible_186(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetPoint1_187(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Specify the position of the first point defining the axis.
	/// </summary>
	public virtual void SetPoint1(IntPtr x)
	{
		vtkAxisActor_SetPoint1_187(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetPoint1_188(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Specify the position of the first point defining the axis.
	/// </summary>
	public virtual void SetPoint1(double x, double y, double z)
	{
		vtkAxisActor_SetPoint1_188(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetPoint2_189(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Specify the position of the second point defining the axis.
	/// </summary>
	public virtual void SetPoint2(IntPtr x)
	{
		vtkAxisActor_SetPoint2_189(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetPoint2_190(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Specify the position of the second point defining the axis.
	/// </summary>
	public virtual void SetPoint2(double x, double y, double z)
	{
		vtkAxisActor_SetPoint2_190(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetRange_191(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify the (min,max) axis range. This will be used in the generation
	/// of labels, if labels are visible.
	/// </summary>
	public virtual void SetRange(double _arg1, double _arg2)
	{
		vtkAxisActor_SetRange_191(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetRange_192(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the (min,max) axis range. This will be used in the generation
	/// of labels, if labels are visible.
	/// </summary>
	public void SetRange(IntPtr _arg)
	{
		vtkAxisActor_SetRange_192(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetSaveTitlePosition_193(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether title position must be saved in 2D mode
	/// </summary>
	public virtual void SetSaveTitlePosition(int _arg)
	{
		vtkAxisActor_SetSaveTitlePosition_193(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetScreenSize_194(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the offsets used to position texts.
	/// </summary>
	public virtual void SetScreenSize(double _arg)
	{
		vtkAxisActor_SetScreenSize_194(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetTickLocation_195(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the location of the ticks.
	/// Inside: tick end toward positive direction of perpendicular axes.
	/// Outside: tick end toward negative direction of perpendicular axes.
	/// </summary>
	public virtual void SetTickLocation(int _arg)
	{
		vtkAxisActor_SetTickLocation_195(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetTickLocationToBoth_196(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the ticks.
	/// Inside: tick end toward positive direction of perpendicular axes.
	/// Outside: tick end toward negative direction of perpendicular axes.
	/// </summary>
	public void SetTickLocationToBoth()
	{
		vtkAxisActor_SetTickLocationToBoth_196(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetTickLocationToInside_197(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the ticks.
	/// Inside: tick end toward positive direction of perpendicular axes.
	/// Outside: tick end toward negative direction of perpendicular axes.
	/// </summary>
	public void SetTickLocationToInside()
	{
		vtkAxisActor_SetTickLocationToInside_197(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetTickLocationToOutside_198(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the ticks.
	/// Inside: tick end toward positive direction of perpendicular axes.
	/// Outside: tick end toward negative direction of perpendicular axes.
	/// </summary>
	public void SetTickLocationToOutside()
	{
		vtkAxisActor_SetTickLocationToOutside_198(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetTickVisibility_199(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get visibility of the axis major tick marks.
	/// </summary>
	public virtual void SetTickVisibility(int _arg)
	{
		vtkAxisActor_SetTickVisibility_199(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetTitle_200(HandleRef pThis, string t);

	/// <summary>
	/// Set/Get the title of the axis actor,
	/// </summary>
	public void SetTitle(string t)
	{
		vtkAxisActor_SetTitle_200(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetTitleAlignLocation_201(HandleRef pThis, int location);

	/// <summary>
	/// Get/Set the alignment of the title related to the axis.
	/// Possible Alignment: VTK_ALIGN_TOP, VTK_ALIGN_BOTTOM, VTK_ALIGN_POINT1, VTK_ALIGN_POINT2
	/// </summary>
	public virtual void SetTitleAlignLocation(int location)
	{
		vtkAxisActor_SetTitleAlignLocation_201(GetCppThis(), location);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetTitleOffset_202(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the offsets used to position texts.
	/// </summary>
	public virtual void SetTitleOffset(double _arg)
	{
		vtkAxisActor_SetTitleOffset_202(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetTitleScale_203(HandleRef pThis, double scale);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public void SetTitleScale(double scale)
	{
		vtkAxisActor_SetTitleScale_203(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetTitleTextProperty_204(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the axis title text property.
	/// </summary>
	public virtual void SetTitleTextProperty(vtkTextProperty p)
	{
		vtkAxisActor_SetTitleTextProperty_204(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetTitleVisibility_205(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get visibility of the axis title.
	/// </summary>
	public virtual void SetTitleVisibility(int _arg)
	{
		vtkAxisActor_SetTitleVisibility_205(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetUse2DMode_206(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the 2D mode
	/// </summary>
	public virtual void SetUse2DMode(int _arg)
	{
		vtkAxisActor_SetUse2DMode_206(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetUseTextActor3D_207(HandleRef pThis, int _arg);

	/// <summary>
	/// Render text as polygons (vtkVectorText) or as sprites (vtkTextActor3D).
	/// In 2D mode, the value is ignored and text is rendered as vtkTextActor.
	/// False(0) by default.
	/// See Also:
	/// GetUse2DMode(), SetUse2DMode
	/// </summary>
	public virtual void SetUseTextActor3D(int _arg)
	{
		vtkAxisActor_SetUseTextActor3D_207(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_SetVerticalOffsetXTitle2D_208(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the 2D mode the vertical offset for X title in 2D mode
	/// </summary>
	public virtual void SetVerticalOffsetXTitle2D(double _arg)
	{
		vtkAxisActor_SetVerticalOffsetXTitle2D_208(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_TickVisibilityOff_209(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis major tick marks.
	/// </summary>
	public virtual void TickVisibilityOff()
	{
		vtkAxisActor_TickVisibilityOff_209(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_TickVisibilityOn_210(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis major tick marks.
	/// </summary>
	public virtual void TickVisibilityOn()
	{
		vtkAxisActor_TickVisibilityOn_210(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_TitleVisibilityOff_211(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis title.
	/// </summary>
	public virtual void TitleVisibilityOff()
	{
		vtkAxisActor_TitleVisibilityOff_211(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisActor_TitleVisibilityOn_212(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of the axis title.
	/// </summary>
	public virtual void TitleVisibilityOn()
	{
		vtkAxisActor_TitleVisibilityOn_212(GetCppThis());
	}
}
