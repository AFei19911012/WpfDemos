using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCubeAxesActor2D
/// </summary>
/// <remarks>
///    create a 2D plot of a bounding box edges - used for navigation
///
/// vtkCubeAxesActor2D is a composite actor that draws three axes of the
/// bounding box of an input dataset. The axes include labels and titles
/// for the x-y-z axes. The algorithm selects the axes that are on the
/// "exterior" of the bounding box, exterior as determined from examining
/// outer edges of the bounding box in projection (display) space. Alternatively,
/// the edges closest to the viewer (i.e., camera position) can be drawn.
///
/// To use this object you must define a bounding box and the camera used
/// to render the vtkCubeAxesActor2D. The camera is used to control the
/// scaling and position of the vtkCubeAxesActor2D so that it fits in the
/// viewport and always remains visible.)
///
/// The font property of the axes titles and labels can be modified through the
/// AxisTitleTextProperty and AxisLabelTextProperty attributes. You may also
/// use the GetXAxisActor2D, GetYAxisActor2D or GetZAxisActor2D methods
/// to access each individual axis actor to modify their font properties.
///
/// The bounding box to use is defined in one of three ways. First, if the Input
/// ivar is defined, then the input dataset's bounds is used. If the Input is
/// not defined, and the Prop (superclass of all actors) is defined, then the
/// Prop's bounds is used. If neither the Input or Prop is defined, then the
/// Bounds instance variable (an array of six doubles) is used.
///
/// </remarks>
/// <seealso>
///
/// vtkActor2D vtkAxisActor2D vtkXYPlotActor vtkTextProperty
/// </seealso>
public class vtkCubeAxesActor2D : vtkActor2D
{
	/// <summary>
	/// Set/Get the camera to perform scaling and translation of the
	/// vtkCubeAxesActor2D.
	/// </summary>
	public enum FlyMode
	{
		/// <summary>enum member</summary>
		VTK_FLY_CLOSEST_TRIAD = 1,
		/// <summary>enum member</summary>
		VTK_FLY_NONE = 2,
		/// <summary>enum member</summary>
		VTK_FLY_OUTER_EDGES = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCubeAxesActor2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCubeAxesActor2D()
	{
		MRClassNameKey = "class vtkCubeAxesActor2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCubeAxesActor2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCubeAxesActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with bold, italic, and shadow enabled; font family
	/// set to Arial; and label format "6.3g". The number of labels per axis
	/// is set to 3.
	/// </summary>
	public new static vtkCubeAxesActor2D New()
	{
		vtkCubeAxesActor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCubeAxesActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with bold, italic, and shadow enabled; font family
	/// set to Arial; and label format "6.3g". The number of labels per axis
	/// is set to 3.
	/// </summary>
	public vtkCubeAxesActor2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCubeAxesActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor2D_GetAxisLabelTextProperty_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the labels text property of all axes. Note that each axis can
	/// be controlled individually through the GetX/Y/ZAxisActor2D() methods.
	/// </summary>
	public virtual vtkTextProperty GetAxisLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor2D_GetAxisLabelTextProperty_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor2D_GetAxisTitleTextProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the title text property of all axes. Note that each axis can
	/// be controlled individually through the GetX/Y/ZAxisActor2D() methods.
	/// </summary>
	public virtual vtkTextProperty GetAxisTitleTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor2D_GetAxisTitleTextProperty_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor2D_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds is used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkCubeAxesActor2D_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_GetBounds_04(HandleRef pThis, ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds is used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public void GetBounds(ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax)
	{
		vtkCubeAxesActor2D_GetBounds_04(GetCppThis(), ref xmin, ref xmax, ref ymin, ref ymax, ref zmin, ref zmax);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_GetBounds_05(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds is used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkCubeAxesActor2D_GetBounds_05(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_GetCamera_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the camera to perform scaling and translation of the
	/// vtkCubeAxesActor2D.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor2D_GetCamera_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkCubeAxesActor2D_GetCornerOffset_07(HandleRef pThis);

	/// <summary>
	/// Specify an offset value to "pull back" the axes from the corner at
	/// which they are joined to avoid overlap of axes labels. The
	/// "CornerOffset" is the fraction of the axis length to pull back.
	/// </summary>
	public virtual double GetCornerOffset()
	{
		return vtkCubeAxesActor2D_GetCornerOffset_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetFlyMode_08(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either outer edges
	/// or closest triad to the camera position, or you may also disable flying
	/// of the axes.
	/// </summary>
	public virtual int GetFlyMode()
	{
		return vtkCubeAxesActor2D_GetFlyMode_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetFlyModeMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either outer edges
	/// or closest triad to the camera position, or you may also disable flying
	/// of the axes.
	/// </summary>
	public virtual int GetFlyModeMaxValue()
	{
		return vtkCubeAxesActor2D_GetFlyModeMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetFlyModeMinValue_10(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either outer edges
	/// or closest triad to the camera position, or you may also disable flying
	/// of the axes.
	/// </summary>
	public virtual int GetFlyModeMinValue()
	{
		return vtkCubeAxesActor2D_GetFlyModeMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor2D_GetFontFactor_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label and title the axes.
	/// </summary>
	public virtual double GetFontFactor()
	{
		return vtkCubeAxesActor2D_GetFontFactor_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor2D_GetFontFactorMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label and title the axes.
	/// </summary>
	public virtual double GetFontFactorMaxValue()
	{
		return vtkCubeAxesActor2D_GetFontFactorMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor2D_GetFontFactorMinValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label and title the axes.
	/// </summary>
	public virtual double GetFontFactorMinValue()
	{
		return vtkCubeAxesActor2D_GetFontFactorMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetInertia_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the inertial factor that controls how often (i.e, how
	/// many renders) the axes can switch position (jump from one axes
	/// to another).
	/// </summary>
	public virtual int GetInertia()
	{
		return vtkCubeAxesActor2D_GetInertia_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetInertiaMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the inertial factor that controls how often (i.e, how
	/// many renders) the axes can switch position (jump from one axes
	/// to another).
	/// </summary>
	public virtual int GetInertiaMaxValue()
	{
		return vtkCubeAxesActor2D_GetInertiaMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetInertiaMinValue_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the inertial factor that controls how often (i.e, how
	/// many renders) the axes can switch position (jump from one axes
	/// to another).
	/// </summary>
	public virtual int GetInertiaMinValue()
	{
		return vtkCubeAxesActor2D_GetInertiaMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_GetInput_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Use the bounding box of this input dataset to draw the cube axes. If this
	/// is not specified, then the class will attempt to determine the bounds from
	/// the defined Prop or Bounds.
	/// </summary>
	public virtual vtkDataSet GetInput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor2D_GetInput_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_GetLabelFormat_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the format with which to print the labels on each of the
	/// x-y-z axes.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor2D_GetLabelFormat_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCubeAxesActor2D_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCubeAxesActor2D_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCubeAxesActor2D_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCubeAxesActor2D_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetNumberOfLabels_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of annotation labels to show along the x, y, and
	/// z axes. This values is a suggestion: the number of labels may vary
	/// depending on the particulars of the data.
	/// </summary>
	public virtual int GetNumberOfLabels()
	{
		return vtkCubeAxesActor2D_GetNumberOfLabels_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetNumberOfLabelsMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of annotation labels to show along the x, y, and
	/// z axes. This values is a suggestion: the number of labels may vary
	/// depending on the particulars of the data.
	/// </summary>
	public virtual int GetNumberOfLabelsMaxValue()
	{
		return vtkCubeAxesActor2D_GetNumberOfLabelsMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetNumberOfLabelsMinValue_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of annotation labels to show along the x, y, and
	/// z axes. This values is a suggestion: the number of labels may vary
	/// depending on the particulars of the data.
	/// </summary>
	public virtual int GetNumberOfLabelsMinValue()
	{
		return vtkCubeAxesActor2D_GetNumberOfLabelsMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_GetRanges_24(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the range of values used on the bounds.
	/// The ranges are specified according to (xmin,xmax, ymin,ymax, zmin,zmax),
	/// making sure that the min's are less than the max's.
	/// </summary>
	public double[] GetRanges()
	{
		IntPtr intPtr = vtkCubeAxesActor2D_GetRanges_24(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_GetRanges_25(HandleRef pThis, ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax);

	/// <summary>
	/// Explicitly specify the range of values used on the bounds.
	/// The ranges are specified according to (xmin,xmax, ymin,ymax, zmin,zmax),
	/// making sure that the min's are less than the max's.
	/// </summary>
	public void GetRanges(ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax)
	{
		vtkCubeAxesActor2D_GetRanges_25(GetCppThis(), ref xmin, ref xmax, ref ymin, ref ymax, ref zmin, ref zmax);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_GetRanges_26(HandleRef pThis, IntPtr ranges);

	/// <summary>
	/// Explicitly specify the range of values used on the bounds.
	/// The ranges are specified according to (xmin,xmax, ymin,ymax, zmin,zmax),
	/// making sure that the min's are less than the max's.
	/// </summary>
	public void GetRanges(IntPtr ranges)
	{
		vtkCubeAxesActor2D_GetRanges_26(GetCppThis(), ranges);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetScaling_27(HandleRef pThis);

	/// <summary>
	/// Set/Get a flag that controls whether the axes are scaled to fit in
	/// the viewport. If off, the axes size remains constant (i.e., stay the
	/// size of the bounding box). By default scaling is on so the axes are
	/// scaled to fit inside the viewport.
	/// </summary>
	public virtual int GetScaling()
	{
		return vtkCubeAxesActor2D_GetScaling_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetShowActualBounds_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the variable that controls whether the actual
	/// bounds of the dataset are always shown. Setting this variable
	/// to 1 means that clipping is disabled and that the actual
	/// value of the bounds is displayed even with corner offsets
	/// Setting this variable to 0 means these axis will clip
	/// themselves and show variable bounds (legacy mode)
	/// </summary>
	public virtual int GetShowActualBounds()
	{
		return vtkCubeAxesActor2D_GetShowActualBounds_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetShowActualBoundsMaxValue_29(HandleRef pThis);

	/// <summary>
	/// Set/Get the variable that controls whether the actual
	/// bounds of the dataset are always shown. Setting this variable
	/// to 1 means that clipping is disabled and that the actual
	/// value of the bounds is displayed even with corner offsets
	/// Setting this variable to 0 means these axis will clip
	/// themselves and show variable bounds (legacy mode)
	/// </summary>
	public virtual int GetShowActualBoundsMaxValue()
	{
		return vtkCubeAxesActor2D_GetShowActualBoundsMaxValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetShowActualBoundsMinValue_30(HandleRef pThis);

	/// <summary>
	/// Set/Get the variable that controls whether the actual
	/// bounds of the dataset are always shown. Setting this variable
	/// to 1 means that clipping is disabled and that the actual
	/// value of the bounds is displayed even with corner offsets
	/// Setting this variable to 0 means these axis will clip
	/// themselves and show variable bounds (legacy mode)
	/// </summary>
	public virtual int GetShowActualBoundsMinValue()
	{
		return vtkCubeAxesActor2D_GetShowActualBoundsMinValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_GetUseRanges_31(HandleRef pThis);

	/// <summary>
	/// Set/Get a flag that controls whether the axes use the data ranges
	/// or the ranges set by SetRanges. By default the axes use the data
	/// ranges.
	/// </summary>
	public virtual int GetUseRanges()
	{
		return vtkCubeAxesActor2D_GetUseRanges_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_GetViewProp_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Use the bounding box of this prop to draw the cube axes. The
	/// ViewProp is used to determine the bounds only if the Input is not
	/// defined.
	/// </summary>
	public virtual vtkProp GetViewProp()
	{
		vtkProp vtkProp2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor2D_GetViewProp_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp2 = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp2.Register(null);
			}
		}
		return vtkProp2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_GetXAxisActor2D_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve handles to the X, Y and Z axis (so that you can set their text
	/// properties for example)
	/// </summary>
	public vtkAxisActor2D GetXAxisActor2D()
	{
		vtkAxisActor2D vtkAxisActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor2D_GetXAxisActor2D_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCubeAxesActor2D_GetXAxisVisibility_34(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual int GetXAxisVisibility()
	{
		return vtkCubeAxesActor2D_GetXAxisVisibility_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_GetXLabel_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X", "Y" and "Z".
	/// </summary>
	public virtual string GetXLabel()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor2D_GetXLabel_35(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_GetYAxisActor2D_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve handles to the X, Y and Z axis (so that you can set their text
	/// properties for example)
	/// </summary>
	public vtkAxisActor2D GetYAxisActor2D()
	{
		vtkAxisActor2D vtkAxisActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor2D_GetYAxisActor2D_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCubeAxesActor2D_GetYAxisVisibility_37(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual int GetYAxisVisibility()
	{
		return vtkCubeAxesActor2D_GetYAxisVisibility_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_GetYLabel_38(HandleRef pThis);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X", "Y" and "Z".
	/// </summary>
	public virtual string GetYLabel()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor2D_GetYLabel_38(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_GetZAxisActor2D_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve handles to the X, Y and Z axis (so that you can set their text
	/// properties for example)
	/// </summary>
	public vtkAxisActor2D GetZAxisActor2D()
	{
		vtkAxisActor2D vtkAxisActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor2D_GetZAxisActor2D_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCubeAxesActor2D_GetZAxisVisibility_40(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual int GetZAxisVisibility()
	{
		return vtkCubeAxesActor2D_GetZAxisVisibility_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_GetZLabel_41(HandleRef pThis);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X", "Y" and "Z".
	/// </summary>
	public virtual string GetZLabel()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor2D_GetZLabel_41(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_HasTranslucentPolygonalGeometry_42(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkCubeAxesActor2D_HasTranslucentPolygonalGeometry_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_IsA_43(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCubeAxesActor2D_IsA_43(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_IsTypeOf_44(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCubeAxesActor2D_IsTypeOf_44(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_NewInstance_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCubeAxesActor2D NewInstance()
	{
		vtkCubeAxesActor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor2D_NewInstance_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCubeAxesActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_ReleaseGraphicsResources_47(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkCubeAxesActor2D_ReleaseGraphicsResources_47(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_RenderOpaqueGeometry_48(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the axes as per the vtkProp superclass' API.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkCubeAxesActor2D_RenderOpaqueGeometry_48(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_RenderOverlay_49(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the axes as per the vtkProp superclass' API.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkCubeAxesActor2D_RenderOverlay_49(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor2D_RenderTranslucentPolygonalGeometry_50(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the axes as per the vtkProp superclass' API.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkCubeAxesActor2D_RenderTranslucentPolygonalGeometry_50(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor2D_SafeDownCast_51(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCubeAxesActor2D SafeDownCast(vtkObjectBase o)
	{
		vtkCubeAxesActor2D vtkCubeAxesActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor2D_SafeDownCast_51(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCubeAxesActor2D2 = (vtkCubeAxesActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCubeAxesActor2D2.Register(null);
			}
		}
		return vtkCubeAxesActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_ScalingOff_52(HandleRef pThis);

	/// <summary>
	/// Set/Get a flag that controls whether the axes are scaled to fit in
	/// the viewport. If off, the axes size remains constant (i.e., stay the
	/// size of the bounding box). By default scaling is on so the axes are
	/// scaled to fit inside the viewport.
	/// </summary>
	public virtual void ScalingOff()
	{
		vtkCubeAxesActor2D_ScalingOff_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_ScalingOn_53(HandleRef pThis);

	/// <summary>
	/// Set/Get a flag that controls whether the axes are scaled to fit in
	/// the viewport. If off, the axes size remains constant (i.e., stay the
	/// size of the bounding box). By default scaling is on so the axes are
	/// scaled to fit inside the viewport.
	/// </summary>
	public virtual void ScalingOn()
	{
		vtkCubeAxesActor2D_ScalingOn_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetAxisLabelTextProperty_54(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the labels text property of all axes. Note that each axis can
	/// be controlled individually through the GetX/Y/ZAxisActor2D() methods.
	/// </summary>
	public virtual void SetAxisLabelTextProperty(vtkTextProperty p)
	{
		vtkCubeAxesActor2D_SetAxisLabelTextProperty_54(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetAxisTitleTextProperty_55(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the title text property of all axes. Note that each axis can
	/// be controlled individually through the GetX/Y/ZAxisActor2D() methods.
	/// </summary>
	public virtual void SetAxisTitleTextProperty(vtkTextProperty p)
	{
		vtkCubeAxesActor2D_SetAxisTitleTextProperty_55(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetBounds_56(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds is used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkCubeAxesActor2D_SetBounds_56(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetBounds_57(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds is used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkCubeAxesActor2D_SetBounds_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetCamera_58(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the camera to perform scaling and translation of the
	/// vtkCubeAxesActor2D.
	/// </summary>
	public virtual void SetCamera(vtkCamera arg0)
	{
		vtkCubeAxesActor2D_SetCamera_58(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetCornerOffset_59(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify an offset value to "pull back" the axes from the corner at
	/// which they are joined to avoid overlap of axes labels. The
	/// "CornerOffset" is the fraction of the axis length to pull back.
	/// </summary>
	public virtual void SetCornerOffset(double _arg)
	{
		vtkCubeAxesActor2D_SetCornerOffset_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetFlyMode_60(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either outer edges
	/// or closest triad to the camera position, or you may also disable flying
	/// of the axes.
	/// </summary>
	public virtual void SetFlyMode(int _arg)
	{
		vtkCubeAxesActor2D_SetFlyMode_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetFlyModeToClosestTriad_61(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either outer edges
	/// or closest triad to the camera position, or you may also disable flying
	/// of the axes.
	/// </summary>
	public void SetFlyModeToClosestTriad()
	{
		vtkCubeAxesActor2D_SetFlyModeToClosestTriad_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetFlyModeToNone_62(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either outer edges
	/// or closest triad to the camera position, or you may also disable flying
	/// of the axes.
	/// </summary>
	public void SetFlyModeToNone()
	{
		vtkCubeAxesActor2D_SetFlyModeToNone_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetFlyModeToOuterEdges_63(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either outer edges
	/// or closest triad to the camera position, or you may also disable flying
	/// of the axes.
	/// </summary>
	public void SetFlyModeToOuterEdges()
	{
		vtkCubeAxesActor2D_SetFlyModeToOuterEdges_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetFontFactor_64(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts used
	/// to label and title the axes.
	/// </summary>
	public virtual void SetFontFactor(double _arg)
	{
		vtkCubeAxesActor2D_SetFontFactor_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetInertia_65(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the inertial factor that controls how often (i.e, how
	/// many renders) the axes can switch position (jump from one axes
	/// to another).
	/// </summary>
	public virtual void SetInertia(int _arg)
	{
		vtkCubeAxesActor2D_SetInertia_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetInputConnection_66(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Use the bounding box of this input dataset to draw the cube axes. If this
	/// is not specified, then the class will attempt to determine the bounds from
	/// the defined Prop or Bounds.
	/// </summary>
	public virtual void SetInputConnection(vtkAlgorithmOutput arg0)
	{
		vtkCubeAxesActor2D_SetInputConnection_66(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetInputData_67(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Use the bounding box of this input dataset to draw the cube axes. If this
	/// is not specified, then the class will attempt to determine the bounds from
	/// the defined Prop or Bounds.
	/// </summary>
	public virtual void SetInputData(vtkDataSet arg0)
	{
		vtkCubeAxesActor2D_SetInputData_67(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetLabelFormat_68(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the format with which to print the labels on each of the
	/// x-y-z axes.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkCubeAxesActor2D_SetLabelFormat_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetNumberOfLabels_69(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of annotation labels to show along the x, y, and
	/// z axes. This values is a suggestion: the number of labels may vary
	/// depending on the particulars of the data.
	/// </summary>
	public virtual void SetNumberOfLabels(int _arg)
	{
		vtkCubeAxesActor2D_SetNumberOfLabels_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetRanges_70(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Explicitly specify the range of values used on the bounds.
	/// The ranges are specified according to (xmin,xmax, ymin,ymax, zmin,zmax),
	/// making sure that the min's are less than the max's.
	/// </summary>
	public virtual void SetRanges(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkCubeAxesActor2D_SetRanges_70(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetRanges_71(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Explicitly specify the range of values used on the bounds.
	/// The ranges are specified according to (xmin,xmax, ymin,ymax, zmin,zmax),
	/// making sure that the min's are less than the max's.
	/// </summary>
	public virtual void SetRanges(IntPtr _arg)
	{
		vtkCubeAxesActor2D_SetRanges_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetScaling_72(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get a flag that controls whether the axes are scaled to fit in
	/// the viewport. If off, the axes size remains constant (i.e., stay the
	/// size of the bounding box). By default scaling is on so the axes are
	/// scaled to fit inside the viewport.
	/// </summary>
	public virtual void SetScaling(int _arg)
	{
		vtkCubeAxesActor2D_SetScaling_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetShowActualBounds_73(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the variable that controls whether the actual
	/// bounds of the dataset are always shown. Setting this variable
	/// to 1 means that clipping is disabled and that the actual
	/// value of the bounds is displayed even with corner offsets
	/// Setting this variable to 0 means these axis will clip
	/// themselves and show variable bounds (legacy mode)
	/// </summary>
	public virtual void SetShowActualBounds(int _arg)
	{
		vtkCubeAxesActor2D_SetShowActualBounds_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetUseRanges_74(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get a flag that controls whether the axes use the data ranges
	/// or the ranges set by SetRanges. By default the axes use the data
	/// ranges.
	/// </summary>
	public virtual void SetUseRanges(int _arg)
	{
		vtkCubeAxesActor2D_SetUseRanges_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetViewProp_75(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Use the bounding box of this prop to draw the cube axes. The
	/// ViewProp is used to determine the bounds only if the Input is not
	/// defined.
	/// </summary>
	public void SetViewProp(vtkProp prop)
	{
		vtkCubeAxesActor2D_SetViewProp_75(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetXAxisVisibility_76(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void SetXAxisVisibility(int _arg)
	{
		vtkCubeAxesActor2D_SetXAxisVisibility_76(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetXLabel_77(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X", "Y" and "Z".
	/// </summary>
	public virtual void SetXLabel(string _arg)
	{
		vtkCubeAxesActor2D_SetXLabel_77(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetXOrigin_78(HandleRef pThis, double _arg);

	/// <summary>
	/// Explicitly specify an origin for the axes. These usually intersect at one of the
	/// corners of the bounding box, however users have the option to override this if
	/// necessary
	/// </summary>
	public virtual void SetXOrigin(double _arg)
	{
		vtkCubeAxesActor2D_SetXOrigin_78(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetYAxisVisibility_79(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void SetYAxisVisibility(int _arg)
	{
		vtkCubeAxesActor2D_SetYAxisVisibility_79(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetYLabel_80(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X", "Y" and "Z".
	/// </summary>
	public virtual void SetYLabel(string _arg)
	{
		vtkCubeAxesActor2D_SetYLabel_80(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetYOrigin_81(HandleRef pThis, double _arg);

	/// <summary>
	/// Explicitly specify an origin for the axes. These usually intersect at one of the
	/// corners of the bounding box, however users have the option to override this if
	/// necessary
	/// </summary>
	public virtual void SetYOrigin(double _arg)
	{
		vtkCubeAxesActor2D_SetYOrigin_81(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetZAxisVisibility_82(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void SetZAxisVisibility(int _arg)
	{
		vtkCubeAxesActor2D_SetZAxisVisibility_82(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetZLabel_83(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X", "Y" and "Z".
	/// </summary>
	public virtual void SetZLabel(string _arg)
	{
		vtkCubeAxesActor2D_SetZLabel_83(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_SetZOrigin_84(HandleRef pThis, double _arg);

	/// <summary>
	/// Explicitly specify an origin for the axes. These usually intersect at one of the
	/// corners of the bounding box, however users have the option to override this if
	/// necessary
	/// </summary>
	public virtual void SetZOrigin(double _arg)
	{
		vtkCubeAxesActor2D_SetZOrigin_84(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_ShallowCopy_85(HandleRef pThis, HandleRef actor);

	/// <summary>
	/// Shallow copy of a CubeAxesActor2D.
	/// </summary>
	public void ShallowCopy(vtkCubeAxesActor2D actor)
	{
		vtkCubeAxesActor2D_ShallowCopy_85(GetCppThis(), actor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_UseRangesOff_86(HandleRef pThis);

	/// <summary>
	/// Set/Get a flag that controls whether the axes use the data ranges
	/// or the ranges set by SetRanges. By default the axes use the data
	/// ranges.
	/// </summary>
	public virtual void UseRangesOff()
	{
		vtkCubeAxesActor2D_UseRangesOff_86(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_UseRangesOn_87(HandleRef pThis);

	/// <summary>
	/// Set/Get a flag that controls whether the axes use the data ranges
	/// or the ranges set by SetRanges. By default the axes use the data
	/// ranges.
	/// </summary>
	public virtual void UseRangesOn()
	{
		vtkCubeAxesActor2D_UseRangesOn_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_XAxisVisibilityOff_88(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void XAxisVisibilityOff()
	{
		vtkCubeAxesActor2D_XAxisVisibilityOff_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_XAxisVisibilityOn_89(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void XAxisVisibilityOn()
	{
		vtkCubeAxesActor2D_XAxisVisibilityOn_89(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_YAxisVisibilityOff_90(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void YAxisVisibilityOff()
	{
		vtkCubeAxesActor2D_YAxisVisibilityOff_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_YAxisVisibilityOn_91(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void YAxisVisibilityOn()
	{
		vtkCubeAxesActor2D_YAxisVisibilityOn_91(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_ZAxisVisibilityOff_92(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void ZAxisVisibilityOff()
	{
		vtkCubeAxesActor2D_ZAxisVisibilityOff_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor2D_ZAxisVisibilityOn_93(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void ZAxisVisibilityOn()
	{
		vtkCubeAxesActor2D_ZAxisVisibilityOn_93(GetCppThis());
	}
}
