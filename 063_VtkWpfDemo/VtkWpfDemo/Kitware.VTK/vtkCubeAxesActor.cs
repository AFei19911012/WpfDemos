using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCubeAxesActor
/// </summary>
/// <remarks>
///    create a plot of a bounding box edges -
/// used for navigation
///
/// vtkCubeAxesActor is a composite actor that draws axes of the
/// bounding box of an input dataset. The axes include labels and titles
/// for the x-y-z axes. The algorithm selects which axes to draw based
/// on the user-defined 'fly' mode.  (STATIC is default).
/// 'STATIC' constructs axes from all edges of the bounding box.
/// 'CLOSEST_TRIAD' consists of the three axes x-y-z forming a triad that
/// lies closest to the specified camera.
/// 'FURTHEST_TRIAD' consists of the three axes x-y-z forming a triad that
/// lies furthest from the specified camera.
/// 'OUTER_EDGES' is constructed from edges that are on the "exterior" of the
/// bounding box, exterior as determined from examining outer edges of the
/// bounding box in projection (display) space.
///
/// To use this object you must define a bounding box and the camera used
/// to render the vtkCubeAxesActor. You can optionally turn on/off labels,
/// ticks, gridlines, and set tick location, number of labels, and text to
/// use for axis-titles.  A 'corner offset' can also be set.  This allows
/// the axes to be set partially away from the actual bounding box to perhaps
/// prevent overlap of labels between the various axes.
///
/// The Bounds instance variable (an array of six doubles) is used to determine
/// the bounding box.
///
/// @par Thanks:
/// This class was written by:
/// Hank Childs, Kathleen Bonnell, Amy Squillacote, Brad Whitlock, Will Schroeder,
/// Eric Brugger, Daniel Aguilera, Claire Guilbaud, Nicolas Dolegieviez,
/// Aashish Chaudhary, Philippe Pebay, David Gobbi, David Partyka, Utkarsh Ayachit
/// David Cole, Francois Bertel, and Mark Olesen
/// Part of this work was supported by CEA/DIF - Commissariat a l'Energie Atomique,
/// Centre DAM Ile-De-France, BP12, F-91297 Arpajon, France.
///
/// </remarks>
/// <seealso>
///
/// vtkActor vtkAxisActor vtkCubeAxesActor2D
/// </seealso>
public class vtkCubeAxesActor : vtkActor
{
	/// <summary>
	/// Set/Get the camera to perform scaling and translation of the
	/// vtkCubeAxesActor.
	/// </summary>
	public enum FlyMode
	{
		/// <summary>enum member</summary>
		VTK_FLY_CLOSEST_TRIAD = 1,
		/// <summary>enum member</summary>
		VTK_FLY_FURTHEST_TRIAD = 2,
		/// <summary>enum member</summary>
		VTK_FLY_OUTER_EDGES = 0,
		/// <summary>enum member</summary>
		VTK_FLY_STATIC_EDGES = 4,
		/// <summary>enum member</summary>
		VTK_FLY_STATIC_TRIAD = 3
	}

	/// <summary>
	/// Enable/Disable centering of axes when the Sticky option is
	/// on. If on, the axes bounds will be centered in the
	/// viewport. Otherwise, the axes can move about the longer of the
	/// horizontal or vertical directions of the viewport to follow the
	/// data. Defaults to on.
	/// </summary>
	public enum GridVisibility
	{
		/// <summary>enum member</summary>
		VTK_GRID_LINES_ALL,
		/// <summary>enum member</summary>
		VTK_GRID_LINES_CLOSEST,
		/// <summary>enum member</summary>
		VTK_GRID_LINES_FURTHEST
	}

	/// <summary>
	/// Get/Set axes gridPolys actors properties.
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkCubeAxesActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCubeAxesActor()
	{
		MRClassNameKey = "class vtkCubeAxesActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCubeAxesActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCubeAxesActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with label format "6.3g" and the number of labels
	/// per axis set to 3.
	/// </summary>
	public new static vtkCubeAxesActor New()
	{
		vtkCubeAxesActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCubeAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with label format "6.3g" and the number of labels
	/// per axis set to 3.
	/// </summary>
	public vtkCubeAxesActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCubeAxesActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCubeAxesActor_CenterStickyAxesOff_01(HandleRef pThis);

	/// <summary>
	/// Enable/Disable centering of axes when the Sticky option is
	/// on. If on, the axes bounds will be centered in the
	/// viewport. Otherwise, the axes can move about the longer of the
	/// horizontal or vertical directions of the viewport to follow the
	/// data. Defaults to on.
	/// </summary>
	public virtual void CenterStickyAxesOff()
	{
		vtkCubeAxesActor_CenterStickyAxesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_CenterStickyAxesOn_02(HandleRef pThis);

	/// <summary>
	/// Enable/Disable centering of axes when the Sticky option is
	/// on. If on, the axes bounds will be centered in the
	/// viewport. Otherwise, the axes can move about the longer of the
	/// horizontal or vertical directions of the viewport to follow the
	/// data. Defaults to on.
	/// </summary>
	public virtual void CenterStickyAxesOn()
	{
		vtkCubeAxesActor_CenterStickyAxesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawXGridlinesOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawXGridlinesOff()
	{
		vtkCubeAxesActor_DrawXGridlinesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawXGridlinesOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawXGridlinesOn()
	{
		vtkCubeAxesActor_DrawXGridlinesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawXGridpolysOff_05(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawXGridpolysOff()
	{
		vtkCubeAxesActor_DrawXGridpolysOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawXGridpolysOn_06(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawXGridpolysOn()
	{
		vtkCubeAxesActor_DrawXGridpolysOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawXInnerGridlinesOff_07(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawXInnerGridlinesOff()
	{
		vtkCubeAxesActor_DrawXInnerGridlinesOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawXInnerGridlinesOn_08(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawXInnerGridlinesOn()
	{
		vtkCubeAxesActor_DrawXInnerGridlinesOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawYGridlinesOff_09(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawYGridlinesOff()
	{
		vtkCubeAxesActor_DrawYGridlinesOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawYGridlinesOn_10(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawYGridlinesOn()
	{
		vtkCubeAxesActor_DrawYGridlinesOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawYGridpolysOff_11(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawYGridpolysOff()
	{
		vtkCubeAxesActor_DrawYGridpolysOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawYGridpolysOn_12(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawYGridpolysOn()
	{
		vtkCubeAxesActor_DrawYGridpolysOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawYInnerGridlinesOff_13(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawYInnerGridlinesOff()
	{
		vtkCubeAxesActor_DrawYInnerGridlinesOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawYInnerGridlinesOn_14(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawYInnerGridlinesOn()
	{
		vtkCubeAxesActor_DrawYInnerGridlinesOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawZGridlinesOff_15(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawZGridlinesOff()
	{
		vtkCubeAxesActor_DrawZGridlinesOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawZGridlinesOn_16(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawZGridlinesOn()
	{
		vtkCubeAxesActor_DrawZGridlinesOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawZGridpolysOff_17(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawZGridpolysOff()
	{
		vtkCubeAxesActor_DrawZGridpolysOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawZGridpolysOn_18(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawZGridpolysOn()
	{
		vtkCubeAxesActor_DrawZGridpolysOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawZInnerGridlinesOff_19(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawZInnerGridlinesOff()
	{
		vtkCubeAxesActor_DrawZInnerGridlinesOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_DrawZInnerGridlinesOn_20(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void DrawZInnerGridlinesOn()
	{
		vtkCubeAxesActor_DrawZInnerGridlinesOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetAxisBaseForX_21(HandleRef pThis);

	/// <summary>
	/// Vector that should be use as the base for X
	/// </summary>
	public virtual double[] GetAxisBaseForX()
	{
		IntPtr intPtr = vtkCubeAxesActor_GetAxisBaseForX_21(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetAxisBaseForX_22(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Vector that should be use as the base for X
	/// </summary>
	public virtual void GetAxisBaseForX(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCubeAxesActor_GetAxisBaseForX_22(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetAxisBaseForX_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Vector that should be use as the base for X
	/// </summary>
	public virtual void GetAxisBaseForX(IntPtr _arg)
	{
		vtkCubeAxesActor_GetAxisBaseForX_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetAxisBaseForY_24(HandleRef pThis);

	/// <summary>
	/// Vector that should be use as the base for Y
	/// </summary>
	public virtual double[] GetAxisBaseForY()
	{
		IntPtr intPtr = vtkCubeAxesActor_GetAxisBaseForY_24(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetAxisBaseForY_25(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Vector that should be use as the base for Y
	/// </summary>
	public virtual void GetAxisBaseForY(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCubeAxesActor_GetAxisBaseForY_25(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetAxisBaseForY_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Vector that should be use as the base for Y
	/// </summary>
	public virtual void GetAxisBaseForY(IntPtr _arg)
	{
		vtkCubeAxesActor_GetAxisBaseForY_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetAxisBaseForZ_27(HandleRef pThis);

	/// <summary>
	/// Vector that should be use as the base for Z
	/// </summary>
	public virtual double[] GetAxisBaseForZ()
	{
		IntPtr intPtr = vtkCubeAxesActor_GetAxisBaseForZ_27(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetAxisBaseForZ_28(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Vector that should be use as the base for Z
	/// </summary>
	public virtual void GetAxisBaseForZ(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCubeAxesActor_GetAxisBaseForZ_28(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetAxisBaseForZ_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Vector that should be use as the base for Z
	/// </summary>
	public virtual void GetAxisBaseForZ(IntPtr _arg)
	{
		vtkCubeAxesActor_GetAxisBaseForZ_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetAxisLabels_30(HandleRef pThis, int axis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Explicitly specify the axis labels along an axis as an array of strings
	/// instead of using the values.
	/// </summary>
	public vtkStringArray GetAxisLabels(int axis)
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetAxisLabels_30(GetCppThis(), axis, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetAxisOrigin_31(HandleRef pThis);

	/// <summary>
	/// Provide a custom AxisOrigin. This point must be inside the bounding box and
	/// will represent the point where the 3 axes will intersect
	/// </summary>
	public virtual double[] GetAxisOrigin()
	{
		IntPtr intPtr = vtkCubeAxesActor_GetAxisOrigin_31(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetAxisOrigin_32(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Provide a custom AxisOrigin. This point must be inside the bounding box and
	/// will represent the point where the 3 axes will intersect
	/// </summary>
	public virtual void GetAxisOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCubeAxesActor_GetAxisOrigin_32(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetAxisOrigin_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Provide a custom AxisOrigin. This point must be inside the bounding box and
	/// will represent the point where the 3 axes will intersect
	/// </summary>
	public virtual void GetAxisOrigin(IntPtr _arg)
	{
		vtkCubeAxesActor_GetAxisOrigin_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetBounds_34(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds is used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkCubeAxesActor_GetBounds_34(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetCamera_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the camera to perform scaling and translation of the
	/// vtkCubeAxesActor.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetCamera_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCubeAxesActor_GetCenterStickyAxes_36(HandleRef pThis);

	/// <summary>
	/// Enable/Disable centering of axes when the Sticky option is
	/// on. If on, the axes bounds will be centered in the
	/// viewport. Otherwise, the axes can move about the longer of the
	/// horizontal or vertical directions of the viewport to follow the
	/// data. Defaults to on.
	/// </summary>
	public virtual int GetCenterStickyAxes()
	{
		return vtkCubeAxesActor_GetCenterStickyAxes_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor_GetCornerOffset_37(HandleRef pThis);

	/// <summary>
	/// Specify an offset value to "pull back" the axes from the corner at
	/// which they are joined to avoid overlap of axes labels. The
	/// "CornerOffset" is the fraction of the axis length to pull back.
	/// </summary>
	public virtual double GetCornerOffset()
	{
		return vtkCubeAxesActor_GetCornerOffset_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor_GetDistanceLODThreshold_38(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetDistanceLODThreshold()
	{
		return vtkCubeAxesActor_GetDistanceLODThreshold_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor_GetDistanceLODThresholdMaxValue_39(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetDistanceLODThresholdMaxValue()
	{
		return vtkCubeAxesActor_GetDistanceLODThresholdMaxValue_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor_GetDistanceLODThresholdMinValue_40(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetDistanceLODThresholdMinValue()
	{
		return vtkCubeAxesActor_GetDistanceLODThresholdMinValue_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetDrawXGridlines_41(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetDrawXGridlines()
	{
		return vtkCubeAxesActor_GetDrawXGridlines_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetDrawXGridpolys_42(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetDrawXGridpolys()
	{
		return vtkCubeAxesActor_GetDrawXGridpolys_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetDrawXInnerGridlines_43(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetDrawXInnerGridlines()
	{
		return vtkCubeAxesActor_GetDrawXInnerGridlines_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetDrawYGridlines_44(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetDrawYGridlines()
	{
		return vtkCubeAxesActor_GetDrawYGridlines_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetDrawYGridpolys_45(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetDrawYGridpolys()
	{
		return vtkCubeAxesActor_GetDrawYGridpolys_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetDrawYInnerGridlines_46(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetDrawYInnerGridlines()
	{
		return vtkCubeAxesActor_GetDrawYInnerGridlines_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetDrawZGridlines_47(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetDrawZGridlines()
	{
		return vtkCubeAxesActor_GetDrawZGridlines_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetDrawZGridpolys_48(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetDrawZGridpolys()
	{
		return vtkCubeAxesActor_GetDrawZGridpolys_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetDrawZInnerGridlines_49(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetDrawZInnerGridlines()
	{
		return vtkCubeAxesActor_GetDrawZInnerGridlines_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetEnableDistanceLOD_50(HandleRef pThis);

	/// <summary>
	/// Enable and disable the use of distance based LOD for titles and labels.
	/// </summary>
	public virtual int GetEnableDistanceLOD()
	{
		return vtkCubeAxesActor_GetEnableDistanceLOD_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetEnableViewAngleLOD_51(HandleRef pThis);

	/// <summary>
	/// Enable and disable the use of view angle based LOD for titles and labels.
	/// </summary>
	public virtual int GetEnableViewAngleLOD()
	{
		return vtkCubeAxesActor_GetEnableViewAngleLOD_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetFlyMode_52(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either static,
	/// closest triad, furthest triad or outer edges in relation to the
	/// camera position.
	/// </summary>
	public virtual int GetFlyMode()
	{
		return vtkCubeAxesActor_GetFlyMode_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetFlyModeMaxValue_53(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either static,
	/// closest triad, furthest triad or outer edges in relation to the
	/// camera position.
	/// </summary>
	public virtual int GetFlyModeMaxValue()
	{
		return vtkCubeAxesActor_GetFlyModeMaxValue_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetFlyModeMinValue_54(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either static,
	/// closest triad, furthest triad or outer edges in relation to the
	/// camera position.
	/// </summary>
	public virtual int GetFlyModeMinValue()
	{
		return vtkCubeAxesActor_GetFlyModeMinValue_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetGridLineLocation_55(HandleRef pThis);

	/// <summary>
	/// Specify the mode in which the cube axes should render its gridLines
	/// </summary>
	public virtual int GetGridLineLocation()
	{
		return vtkCubeAxesActor_GetGridLineLocation_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetInertia_56(HandleRef pThis);

	/// <summary>
	/// Set/Get the inertial factor that controls how often (i.e, how
	/// many renders) the axes can switch position (jump from one axes
	/// to another).
	/// </summary>
	public virtual int GetInertia()
	{
		return vtkCubeAxesActor_GetInertia_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetInertiaMaxValue_57(HandleRef pThis);

	/// <summary>
	/// Set/Get the inertial factor that controls how often (i.e, how
	/// many renders) the axes can switch position (jump from one axes
	/// to another).
	/// </summary>
	public virtual int GetInertiaMaxValue()
	{
		return vtkCubeAxesActor_GetInertiaMaxValue_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetInertiaMinValue_58(HandleRef pThis);

	/// <summary>
	/// Set/Get the inertial factor that controls how often (i.e, how
	/// many renders) the axes can switch position (jump from one axes
	/// to another).
	/// </summary>
	public virtual int GetInertiaMinValue()
	{
		return vtkCubeAxesActor_GetInertiaMinValue_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor_GetLabelOffset_59(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the distance between labels and the axis.
	/// Default is 20.0.
	/// </summary>
	public virtual double GetLabelOffset()
	{
		return vtkCubeAxesActor_GetLabelOffset_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetLabelTextProperty_60(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the text property for the labels on an axis.
	/// </summary>
	public vtkTextProperty GetLabelTextProperty(int arg0)
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetLabelTextProperty_60(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCubeAxesActor_GetNumberOfGenerationsFromBase_61(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCubeAxesActor_GetNumberOfGenerationsFromBase_61(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCubeAxesActor_GetNumberOfGenerationsFromBaseType_62(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCubeAxesActor_GetNumberOfGenerationsFromBaseType_62(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetOrientedBounds_63(HandleRef pThis);

	/// <summary>
	/// Provide an oriented bounded box when using AxisBaseFor.
	/// </summary>
	public virtual double[] GetOrientedBounds()
	{
		IntPtr intPtr = vtkCubeAxesActor_GetOrientedBounds_63(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetOrientedBounds_64(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Provide an oriented bounded box when using AxisBaseFor.
	/// </summary>
	public virtual void GetOrientedBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkCubeAxesActor_GetOrientedBounds_64(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetOrientedBounds_65(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Provide an oriented bounded box when using AxisBaseFor.
	/// </summary>
	public virtual void GetOrientedBounds(IntPtr _arg)
	{
		vtkCubeAxesActor_GetOrientedBounds_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCubeAxesActor_GetRebuildAxes_66(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the RebuildAxes flag
	/// </summary>
	public virtual bool GetRebuildAxes()
	{
		return (vtkCubeAxesActor_GetRebuildAxes_66(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetRenderedBounds_67(HandleRef pThis, IntPtr rBounds);

	/// <summary>
	/// Method used to properly return the bounds of the cube axis itself with all
	/// its labels.
	/// </summary>
	public virtual void GetRenderedBounds(IntPtr rBounds)
	{
		vtkCubeAxesActor_GetRenderedBounds_67(GetCppThis(), rBounds);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetRenderedBounds_68(HandleRef pThis);

	/// <summary>
	/// Method used to properly return the bounds of the cube axis itself with all
	/// its labels.
	/// </summary>
	public virtual IntPtr GetRenderedBounds()
	{
		return vtkCubeAxesActor_GetRenderedBounds_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor_GetScreenSize_69(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the screen size of title and label text.
	/// ScreenSize determines the size of the text in terms of screen
	/// pixels. Default is 10.0.
	/// </summary>
	public virtual double GetScreenSize()
	{
		return vtkCubeAxesActor_GetScreenSize_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetStickyAxes_70(HandleRef pThis);

	/// <summary>
	/// Enable/Disable axis stickiness. When on, the axes will be adjusted to always
	/// be visible in the viewport unless the original bounds of the axes are entirely
	/// outside the viewport. Defaults to off.
	/// </summary>
	public virtual int GetStickyAxes()
	{
		return vtkCubeAxesActor_GetStickyAxes_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetTickLocation_71(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of ticks marks.
	/// </summary>
	public virtual int GetTickLocation()
	{
		return vtkCubeAxesActor_GetTickLocation_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetTickLocationMaxValue_72(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of ticks marks.
	/// </summary>
	public virtual int GetTickLocationMaxValue()
	{
		return vtkCubeAxesActor_GetTickLocationMaxValue_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetTickLocationMinValue_73(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of ticks marks.
	/// </summary>
	public virtual int GetTickLocationMinValue()
	{
		return vtkCubeAxesActor_GetTickLocationMinValue_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor_GetTitleOffset_74(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the distance between title and labels.
	/// Default is 20.0.
	/// </summary>
	public virtual double GetTitleOffset()
	{
		return vtkCubeAxesActor_GetTitleOffset_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetTitleTextProperty_75(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the text property for the title on an axis.
	/// </summary>
	public vtkTextProperty GetTitleTextProperty(int arg0)
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetTitleTextProperty_75(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCubeAxesActor_GetUse2DMode_76(HandleRef pThis);

	/// <summary>
	/// Get/Set 2D mode
	/// NB: Use vtkTextActor for titles in 2D instead of vtkAxisFollower
	/// </summary>
	public int GetUse2DMode()
	{
		return vtkCubeAxesActor_GetUse2DMode_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetUseAxisOrigin_77(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the usage of the AxisOrigin
	/// </summary>
	public virtual int GetUseAxisOrigin()
	{
		return vtkCubeAxesActor_GetUseAxisOrigin_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetUseOrientedBounds_78(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the usage of the OrientedBounds
	/// </summary>
	public virtual int GetUseOrientedBounds()
	{
		return vtkCubeAxesActor_GetUseOrientedBounds_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetUseTextActor3D_79(HandleRef pThis);

	/// <summary>
	/// Use or not vtkTextActor3D for titles and labels.
	/// See Also:
	/// vtkAxisActor::SetUseTextActor3D(), vtkAxisActor::GetUseTextActor3D()
	/// </summary>
	public int GetUseTextActor3D()
	{
		return vtkCubeAxesActor_GetUseTextActor3D_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor_GetViewAngleLODThreshold_80(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetViewAngleLODThreshold()
	{
		return vtkCubeAxesActor_GetViewAngleLODThreshold_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor_GetViewAngleLODThresholdMaxValue_81(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetViewAngleLODThresholdMaxValue()
	{
		return vtkCubeAxesActor_GetViewAngleLODThresholdMaxValue_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeAxesActor_GetViewAngleLODThresholdMinValue_82(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual double GetViewAngleLODThresholdMinValue()
	{
		return vtkCubeAxesActor_GetViewAngleLODThresholdMinValue_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetXAxesGridlinesProperty_83(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes (outer) gridlines actors properties.
	/// </summary>
	public vtkProperty GetXAxesGridlinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetXAxesGridlinesProperty_83(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor_GetXAxesGridpolysProperty_84(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes gridPolys actors properties.
	/// </summary>
	public vtkProperty GetXAxesGridpolysProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetXAxesGridpolysProperty_84(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor_GetXAxesInnerGridlinesProperty_85(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes inner gridlines actors properties.
	/// </summary>
	public vtkProperty GetXAxesInnerGridlinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetXAxesInnerGridlinesProperty_85(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor_GetXAxesLinesProperty_86(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes actors properties.
	/// </summary>
	public vtkProperty GetXAxesLinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetXAxesLinesProperty_86(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCubeAxesActor_GetXAxisLabelVisibility_87(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual int GetXAxisLabelVisibility()
	{
		return vtkCubeAxesActor_GetXAxisLabelVisibility_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetXAxisMinorTickVisibility_88(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetXAxisMinorTickVisibility()
	{
		return vtkCubeAxesActor_GetXAxisMinorTickVisibility_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetXAxisRange_89(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public virtual double[] GetXAxisRange()
	{
		IntPtr intPtr = vtkCubeAxesActor_GetXAxisRange_89(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetXAxisRange_90(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public virtual void GetXAxisRange(ref double _arg1, ref double _arg2)
	{
		vtkCubeAxesActor_GetXAxisRange_90(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetXAxisRange_91(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public virtual void GetXAxisRange(IntPtr _arg)
	{
		vtkCubeAxesActor_GetXAxisRange_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetXAxisTickVisibility_92(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual int GetXAxisTickVisibility()
	{
		return vtkCubeAxesActor_GetXAxisTickVisibility_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetXAxisVisibility_93(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual int GetXAxisVisibility()
	{
		return vtkCubeAxesActor_GetXAxisVisibility_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetXLabelFormat_94(HandleRef pThis);

	/// <summary>
	/// Set/Get the format with which to print the labels on each of the
	/// x-y-z axes.
	/// </summary>
	public virtual string GetXLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor_GetXLabelFormat_94(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetXTitle_95(HandleRef pThis);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual string GetXTitle()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor_GetXTitle_95(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetXUnits_96(HandleRef pThis);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual string GetXUnits()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor_GetXUnits_96(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetYAxesGridlinesProperty_97(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes (outer) gridlines actors properties.
	/// </summary>
	public vtkProperty GetYAxesGridlinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetYAxesGridlinesProperty_97(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor_GetYAxesGridpolysProperty_98(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes gridPolys actors properties.
	/// </summary>
	public vtkProperty GetYAxesGridpolysProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetYAxesGridpolysProperty_98(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor_GetYAxesInnerGridlinesProperty_99(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes inner gridlines actors properties.
	/// </summary>
	public vtkProperty GetYAxesInnerGridlinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetYAxesInnerGridlinesProperty_99(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor_GetYAxesLinesProperty_100(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes actors properties.
	/// </summary>
	public vtkProperty GetYAxesLinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetYAxesLinesProperty_100(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCubeAxesActor_GetYAxisLabelVisibility_101(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual int GetYAxisLabelVisibility()
	{
		return vtkCubeAxesActor_GetYAxisLabelVisibility_101(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetYAxisMinorTickVisibility_102(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetYAxisMinorTickVisibility()
	{
		return vtkCubeAxesActor_GetYAxisMinorTickVisibility_102(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetYAxisRange_103(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public virtual double[] GetYAxisRange()
	{
		IntPtr intPtr = vtkCubeAxesActor_GetYAxisRange_103(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetYAxisRange_104(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public virtual void GetYAxisRange(ref double _arg1, ref double _arg2)
	{
		vtkCubeAxesActor_GetYAxisRange_104(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetYAxisRange_105(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public virtual void GetYAxisRange(IntPtr _arg)
	{
		vtkCubeAxesActor_GetYAxisRange_105(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetYAxisTickVisibility_106(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual int GetYAxisTickVisibility()
	{
		return vtkCubeAxesActor_GetYAxisTickVisibility_106(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetYAxisVisibility_107(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual int GetYAxisVisibility()
	{
		return vtkCubeAxesActor_GetYAxisVisibility_107(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetYLabelFormat_108(HandleRef pThis);

	/// <summary>
	/// Set/Get the format with which to print the labels on each of the
	/// x-y-z axes.
	/// </summary>
	public virtual string GetYLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor_GetYLabelFormat_108(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetYTitle_109(HandleRef pThis);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual string GetYTitle()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor_GetYTitle_109(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetYUnits_110(HandleRef pThis);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual string GetYUnits()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor_GetYUnits_110(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetZAxesGridlinesProperty_111(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes (outer) gridlines actors properties.
	/// </summary>
	public vtkProperty GetZAxesGridlinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetZAxesGridlinesProperty_111(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor_GetZAxesGridpolysProperty_112(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes gridPolys actors properties.
	/// </summary>
	public vtkProperty GetZAxesGridpolysProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetZAxesGridpolysProperty_112(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor_GetZAxesInnerGridlinesProperty_113(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes inner gridlines actors properties.
	/// </summary>
	public vtkProperty GetZAxesInnerGridlinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetZAxesInnerGridlinesProperty_113(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCubeAxesActor_GetZAxesLinesProperty_114(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set axes actors properties.
	/// </summary>
	public vtkProperty GetZAxesLinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_GetZAxesLinesProperty_114(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCubeAxesActor_GetZAxisLabelVisibility_115(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual int GetZAxisLabelVisibility()
	{
		return vtkCubeAxesActor_GetZAxisLabelVisibility_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetZAxisMinorTickVisibility_116(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual int GetZAxisMinorTickVisibility()
	{
		return vtkCubeAxesActor_GetZAxisMinorTickVisibility_116(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetZAxisRange_117(HandleRef pThis);

	/// <summary>
	/// Explicitly specify the axis labels along an axis as an array of strings
	/// instead of using the values.
	/// </summary>
	public virtual double[] GetZAxisRange()
	{
		IntPtr intPtr = vtkCubeAxesActor_GetZAxisRange_117(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetZAxisRange_118(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Explicitly specify the axis labels along an axis as an array of strings
	/// instead of using the values.
	/// </summary>
	public virtual void GetZAxisRange(ref double _arg1, ref double _arg2)
	{
		vtkCubeAxesActor_GetZAxisRange_118(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_GetZAxisRange_119(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Explicitly specify the axis labels along an axis as an array of strings
	/// instead of using the values.
	/// </summary>
	public virtual void GetZAxisRange(IntPtr _arg)
	{
		vtkCubeAxesActor_GetZAxisRange_119(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetZAxisTickVisibility_120(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual int GetZAxisTickVisibility()
	{
		return vtkCubeAxesActor_GetZAxisTickVisibility_120(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_GetZAxisVisibility_121(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual int GetZAxisVisibility()
	{
		return vtkCubeAxesActor_GetZAxisVisibility_121(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetZLabelFormat_122(HandleRef pThis);

	/// <summary>
	/// Set/Get the format with which to print the labels on each of the
	/// x-y-z axes.
	/// </summary>
	public virtual string GetZLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor_GetZLabelFormat_122(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetZTitle_123(HandleRef pThis);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual string GetZTitle()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor_GetZTitle_123(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_GetZUnits_124(HandleRef pThis);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual string GetZUnits()
	{
		return Marshal.PtrToStringAnsi(vtkCubeAxesActor_GetZUnits_124(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_HasTranslucentPolygonalGeometry_125(HandleRef pThis);

	/// <summary>
	/// Draw the axes as per the vtkProp superclass' API.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkCubeAxesActor_HasTranslucentPolygonalGeometry_125(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_IsA_126(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCubeAxesActor_IsA_126(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_IsTypeOf_127(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCubeAxesActor_IsTypeOf_127(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_NewInstance_129(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCubeAxesActor NewInstance()
	{
		vtkCubeAxesActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_NewInstance_129(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCubeAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_ReleaseGraphicsResources_130(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkCubeAxesActor_ReleaseGraphicsResources_130(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_RenderOpaqueGeometry_131(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the axes as per the vtkProp superclass' API.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkCubeAxesActor_RenderOpaqueGeometry_131(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_RenderOverlay_132(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the axes as per the vtkProp superclass' API.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkCubeAxesActor_RenderOverlay_132(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_RenderTranslucentGeometry_133(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the axes as per the vtkProp superclass' API.
	/// </summary>
	public virtual int RenderTranslucentGeometry(vtkViewport arg0)
	{
		return vtkCubeAxesActor_RenderTranslucentGeometry_133(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeAxesActor_RenderTranslucentPolygonalGeometry_134(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the axes as per the vtkProp superclass' API.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkCubeAxesActor_RenderTranslucentPolygonalGeometry_134(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeAxesActor_SafeDownCast_135(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCubeAxesActor SafeDownCast(vtkObjectBase o)
	{
		vtkCubeAxesActor vtkCubeAxesActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeAxesActor_SafeDownCast_135(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCubeAxesActor2 = (vtkCubeAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCubeAxesActor2.Register(null);
			}
		}
		return vtkCubeAxesActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetAxisBaseForX_136(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Vector that should be use as the base for X
	/// </summary>
	public virtual void SetAxisBaseForX(double _arg1, double _arg2, double _arg3)
	{
		vtkCubeAxesActor_SetAxisBaseForX_136(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetAxisBaseForX_137(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Vector that should be use as the base for X
	/// </summary>
	public virtual void SetAxisBaseForX(IntPtr _arg)
	{
		vtkCubeAxesActor_SetAxisBaseForX_137(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetAxisBaseForY_138(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Vector that should be use as the base for Y
	/// </summary>
	public virtual void SetAxisBaseForY(double _arg1, double _arg2, double _arg3)
	{
		vtkCubeAxesActor_SetAxisBaseForY_138(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetAxisBaseForY_139(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Vector that should be use as the base for Y
	/// </summary>
	public virtual void SetAxisBaseForY(IntPtr _arg)
	{
		vtkCubeAxesActor_SetAxisBaseForY_139(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetAxisBaseForZ_140(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Vector that should be use as the base for Z
	/// </summary>
	public virtual void SetAxisBaseForZ(double _arg1, double _arg2, double _arg3)
	{
		vtkCubeAxesActor_SetAxisBaseForZ_140(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetAxisBaseForZ_141(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Vector that should be use as the base for Z
	/// </summary>
	public virtual void SetAxisBaseForZ(IntPtr _arg)
	{
		vtkCubeAxesActor_SetAxisBaseForZ_141(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetAxisLabels_142(HandleRef pThis, int axis, HandleRef value);

	/// <summary>
	/// Explicitly specify the axis labels along an axis as an array of strings
	/// instead of using the values.
	/// </summary>
	public void SetAxisLabels(int axis, vtkStringArray value)
	{
		vtkCubeAxesActor_SetAxisLabels_142(GetCppThis(), axis, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetAxisOrigin_143(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Provide a custom AxisOrigin. This point must be inside the bounding box and
	/// will represent the point where the 3 axes will intersect
	/// </summary>
	public virtual void SetAxisOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkCubeAxesActor_SetAxisOrigin_143(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetAxisOrigin_144(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Provide a custom AxisOrigin. This point must be inside the bounding box and
	/// will represent the point where the 3 axes will intersect
	/// </summary>
	public virtual void SetAxisOrigin(IntPtr _arg)
	{
		vtkCubeAxesActor_SetAxisOrigin_144(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetBounds_145(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds is used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkCubeAxesActor_SetBounds_145(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetBounds_146(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Explicitly specify the region in space around which to draw the bounds.
	/// The bounds is used only when no Input or Prop is specified. The bounds
	/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
	/// sure that the min's are less than the max's.
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkCubeAxesActor_SetBounds_146(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetCamera_147(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the camera to perform scaling and translation of the
	/// vtkCubeAxesActor.
	/// </summary>
	public virtual void SetCamera(vtkCamera arg0)
	{
		vtkCubeAxesActor_SetCamera_147(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetCenterStickyAxes_148(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable centering of axes when the Sticky option is
	/// on. If on, the axes bounds will be centered in the
	/// viewport. Otherwise, the axes can move about the longer of the
	/// horizontal or vertical directions of the viewport to follow the
	/// data. Defaults to on.
	/// </summary>
	public virtual void SetCenterStickyAxes(int _arg)
	{
		vtkCubeAxesActor_SetCenterStickyAxes_148(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetCornerOffset_149(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify an offset value to "pull back" the axes from the corner at
	/// which they are joined to avoid overlap of axes labels. The
	/// "CornerOffset" is the fraction of the axis length to pull back.
	/// </summary>
	public virtual void SetCornerOffset(double _arg)
	{
		vtkCubeAxesActor_SetCornerOffset_149(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetDistanceLODThreshold_150(HandleRef pThis, double _arg);

	/// <summary>
	/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual void SetDistanceLODThreshold(double _arg)
	{
		vtkCubeAxesActor_SetDistanceLODThreshold_150(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetDrawXGridlines_151(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetDrawXGridlines(int _arg)
	{
		vtkCubeAxesActor_SetDrawXGridlines_151(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetDrawXGridpolys_152(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetDrawXGridpolys(int _arg)
	{
		vtkCubeAxesActor_SetDrawXGridpolys_152(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetDrawXInnerGridlines_153(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetDrawXInnerGridlines(int _arg)
	{
		vtkCubeAxesActor_SetDrawXInnerGridlines_153(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetDrawYGridlines_154(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetDrawYGridlines(int _arg)
	{
		vtkCubeAxesActor_SetDrawYGridlines_154(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetDrawYGridpolys_155(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetDrawYGridpolys(int _arg)
	{
		vtkCubeAxesActor_SetDrawYGridpolys_155(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetDrawYInnerGridlines_156(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetDrawYInnerGridlines(int _arg)
	{
		vtkCubeAxesActor_SetDrawYInnerGridlines_156(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetDrawZGridlines_157(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetDrawZGridlines(int _arg)
	{
		vtkCubeAxesActor_SetDrawZGridlines_157(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetDrawZGridpolys_158(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetDrawZGridpolys(int _arg)
	{
		vtkCubeAxesActor_SetDrawZGridpolys_158(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetDrawZInnerGridlines_159(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetDrawZInnerGridlines(int _arg)
	{
		vtkCubeAxesActor_SetDrawZInnerGridlines_159(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetEnableDistanceLOD_160(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable and disable the use of distance based LOD for titles and labels.
	/// </summary>
	public virtual void SetEnableDistanceLOD(int _arg)
	{
		vtkCubeAxesActor_SetEnableDistanceLOD_160(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetEnableViewAngleLOD_161(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable and disable the use of view angle based LOD for titles and labels.
	/// </summary>
	public virtual void SetEnableViewAngleLOD(int _arg)
	{
		vtkCubeAxesActor_SetEnableViewAngleLOD_161(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetFlyMode_162(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either static,
	/// closest triad, furthest triad or outer edges in relation to the
	/// camera position.
	/// </summary>
	public virtual void SetFlyMode(int _arg)
	{
		vtkCubeAxesActor_SetFlyMode_162(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetFlyModeToClosestTriad_163(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either static,
	/// closest triad, furthest triad or outer edges in relation to the
	/// camera position.
	/// </summary>
	public void SetFlyModeToClosestTriad()
	{
		vtkCubeAxesActor_SetFlyModeToClosestTriad_163(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetFlyModeToFurthestTriad_164(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either static,
	/// closest triad, furthest triad or outer edges in relation to the
	/// camera position.
	/// </summary>
	public void SetFlyModeToFurthestTriad()
	{
		vtkCubeAxesActor_SetFlyModeToFurthestTriad_164(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetFlyModeToOuterEdges_165(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either static,
	/// closest triad, furthest triad or outer edges in relation to the
	/// camera position.
	/// </summary>
	public void SetFlyModeToOuterEdges()
	{
		vtkCubeAxesActor_SetFlyModeToOuterEdges_165(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetFlyModeToStaticEdges_166(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either static,
	/// closest triad, furthest triad or outer edges in relation to the
	/// camera position.
	/// </summary>
	public void SetFlyModeToStaticEdges()
	{
		vtkCubeAxesActor_SetFlyModeToStaticEdges_166(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetFlyModeToStaticTriad_167(HandleRef pThis);

	/// <summary>
	/// Specify a mode to control how the axes are drawn: either static,
	/// closest triad, furthest triad or outer edges in relation to the
	/// camera position.
	/// </summary>
	public void SetFlyModeToStaticTriad()
	{
		vtkCubeAxesActor_SetFlyModeToStaticTriad_167(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetGridLineLocation_168(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the mode in which the cube axes should render its gridLines
	/// </summary>
	public virtual void SetGridLineLocation(int _arg)
	{
		vtkCubeAxesActor_SetGridLineLocation_168(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetInertia_169(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the inertial factor that controls how often (i.e, how
	/// many renders) the axes can switch position (jump from one axes
	/// to another).
	/// </summary>
	public virtual void SetInertia(int _arg)
	{
		vtkCubeAxesActor_SetInertia_169(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetLabelOffset_170(HandleRef pThis, double offset);

	/// <summary>
	/// Explicitly specify the distance between labels and the axis.
	/// Default is 20.0.
	/// </summary>
	public void SetLabelOffset(double offset)
	{
		vtkCubeAxesActor_SetLabelOffset_170(GetCppThis(), offset);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetLabelScaling_171(HandleRef pThis, byte arg0, int arg1, int arg2, int arg3);

	/// <summary>
	/// Set/Get the location of ticks marks.
	/// </summary>
	public void SetLabelScaling(bool arg0, int arg1, int arg2, int arg3)
	{
		vtkCubeAxesActor_SetLabelScaling_171(GetCppThis(), (byte)(arg0 ? 1u : 0u), arg1, arg2, arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetOrientedBounds_172(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Provide an oriented bounded box when using AxisBaseFor.
	/// </summary>
	public virtual void SetOrientedBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkCubeAxesActor_SetOrientedBounds_172(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetOrientedBounds_173(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Provide an oriented bounded box when using AxisBaseFor.
	/// </summary>
	public virtual void SetOrientedBounds(IntPtr _arg)
	{
		vtkCubeAxesActor_SetOrientedBounds_173(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetRebuildAxes_174(HandleRef pThis, byte _arg);

	/// <summary>
	/// Gets/Sets the RebuildAxes flag
	/// </summary>
	public virtual void SetRebuildAxes(bool _arg)
	{
		vtkCubeAxesActor_SetRebuildAxes_174(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetSaveTitlePosition_175(HandleRef pThis, int val);

	/// <summary>
	/// For 2D mode only: save axis title positions for later use
	/// </summary>
	public void SetSaveTitlePosition(int val)
	{
		vtkCubeAxesActor_SetSaveTitlePosition_175(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetScreenSize_176(HandleRef pThis, double screenSize);

	/// <summary>
	/// Explicitly specify the screen size of title and label text.
	/// ScreenSize determines the size of the text in terms of screen
	/// pixels. Default is 10.0.
	/// </summary>
	public void SetScreenSize(double screenSize)
	{
		vtkCubeAxesActor_SetScreenSize_176(GetCppThis(), screenSize);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetStickyAxes_177(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable axis stickiness. When on, the axes will be adjusted to always
	/// be visible in the viewport unless the original bounds of the axes are entirely
	/// outside the viewport. Defaults to off.
	/// </summary>
	public virtual void SetStickyAxes(int _arg)
	{
		vtkCubeAxesActor_SetStickyAxes_177(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetTickLocation_178(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the location of ticks marks.
	/// </summary>
	public virtual void SetTickLocation(int _arg)
	{
		vtkCubeAxesActor_SetTickLocation_178(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetTickLocationToBoth_179(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of ticks marks.
	/// </summary>
	public void SetTickLocationToBoth()
	{
		vtkCubeAxesActor_SetTickLocationToBoth_179(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetTickLocationToInside_180(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of ticks marks.
	/// </summary>
	public void SetTickLocationToInside()
	{
		vtkCubeAxesActor_SetTickLocationToInside_180(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetTickLocationToOutside_181(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of ticks marks.
	/// </summary>
	public void SetTickLocationToOutside()
	{
		vtkCubeAxesActor_SetTickLocationToOutside_181(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetTitleOffset_182(HandleRef pThis, double offset);

	/// <summary>
	/// Explicitly specify the distance between title and labels.
	/// Default is 20.0.
	/// </summary>
	public void SetTitleOffset(double offset)
	{
		vtkCubeAxesActor_SetTitleOffset_182(GetCppThis(), offset);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetUse2DMode_183(HandleRef pThis, int val);

	/// <summary>
	/// Get/Set 2D mode
	/// NB: Use vtkTextActor for titles in 2D instead of vtkAxisFollower
	/// </summary>
	public void SetUse2DMode(int val)
	{
		vtkCubeAxesActor_SetUse2DMode_183(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetUseAxisOrigin_184(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable the usage of the AxisOrigin
	/// </summary>
	public virtual void SetUseAxisOrigin(int _arg)
	{
		vtkCubeAxesActor_SetUseAxisOrigin_184(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetUseOrientedBounds_185(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable the usage of the OrientedBounds
	/// </summary>
	public virtual void SetUseOrientedBounds(int _arg)
	{
		vtkCubeAxesActor_SetUseOrientedBounds_185(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetUseTextActor3D_186(HandleRef pThis, int val);

	/// <summary>
	/// Use or not vtkTextActor3D for titles and labels.
	/// See Also:
	/// vtkAxisActor::SetUseTextActor3D(), vtkAxisActor::GetUseTextActor3D()
	/// </summary>
	public void SetUseTextActor3D(int val)
	{
		vtkCubeAxesActor_SetUseTextActor3D_186(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetViewAngleLODThreshold_187(HandleRef pThis, double _arg);

	/// <summary>
	/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
	/// </summary>
	public virtual void SetViewAngleLODThreshold(double _arg)
	{
		vtkCubeAxesActor_SetViewAngleLODThreshold_187(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXAxesGridlinesProperty_188(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes (outer) gridlines actors properties.
	/// </summary>
	public void SetXAxesGridlinesProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetXAxesGridlinesProperty_188(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXAxesGridpolysProperty_189(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes gridPolys actors properties.
	/// </summary>
	public void SetXAxesGridpolysProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetXAxesGridpolysProperty_189(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXAxesInnerGridlinesProperty_190(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes inner gridlines actors properties.
	/// </summary>
	public void SetXAxesInnerGridlinesProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetXAxesInnerGridlinesProperty_190(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXAxesLinesProperty_191(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes actors properties.
	/// </summary>
	public void SetXAxesLinesProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetXAxesLinesProperty_191(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXAxisLabelVisibility_192(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual void SetXAxisLabelVisibility(int _arg)
	{
		vtkCubeAxesActor_SetXAxisLabelVisibility_192(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXAxisMinorTickVisibility_193(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetXAxisMinorTickVisibility(int _arg)
	{
		vtkCubeAxesActor_SetXAxisMinorTickVisibility_193(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXAxisRange_194(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public virtual void SetXAxisRange(double _arg1, double _arg2)
	{
		vtkCubeAxesActor_SetXAxisRange_194(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXAxisRange_195(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public void SetXAxisRange(IntPtr _arg)
	{
		vtkCubeAxesActor_SetXAxisRange_195(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXAxisTickVisibility_196(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual void SetXAxisTickVisibility(int _arg)
	{
		vtkCubeAxesActor_SetXAxisTickVisibility_196(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXAxisVisibility_197(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void SetXAxisVisibility(int _arg)
	{
		vtkCubeAxesActor_SetXAxisVisibility_197(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXLabelFormat_198(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the format with which to print the labels on each of the
	/// x-y-z axes.
	/// </summary>
	public virtual void SetXLabelFormat(string _arg)
	{
		vtkCubeAxesActor_SetXLabelFormat_198(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXTitle_199(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual void SetXTitle(string _arg)
	{
		vtkCubeAxesActor_SetXTitle_199(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetXUnits_200(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual void SetXUnits(string _arg)
	{
		vtkCubeAxesActor_SetXUnits_200(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYAxesGridlinesProperty_201(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes (outer) gridlines actors properties.
	/// </summary>
	public void SetYAxesGridlinesProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetYAxesGridlinesProperty_201(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYAxesGridpolysProperty_202(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes gridPolys actors properties.
	/// </summary>
	public void SetYAxesGridpolysProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetYAxesGridpolysProperty_202(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYAxesInnerGridlinesProperty_203(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes inner gridlines actors properties.
	/// </summary>
	public void SetYAxesInnerGridlinesProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetYAxesInnerGridlinesProperty_203(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYAxesLinesProperty_204(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes actors properties.
	/// </summary>
	public void SetYAxesLinesProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetYAxesLinesProperty_204(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYAxisLabelVisibility_205(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual void SetYAxisLabelVisibility(int _arg)
	{
		vtkCubeAxesActor_SetYAxisLabelVisibility_205(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYAxisMinorTickVisibility_206(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetYAxisMinorTickVisibility(int _arg)
	{
		vtkCubeAxesActor_SetYAxisMinorTickVisibility_206(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYAxisRange_207(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public virtual void SetYAxisRange(double _arg1, double _arg2)
	{
		vtkCubeAxesActor_SetYAxisRange_207(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYAxisRange_208(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public void SetYAxisRange(IntPtr _arg)
	{
		vtkCubeAxesActor_SetYAxisRange_208(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYAxisTickVisibility_209(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual void SetYAxisTickVisibility(int _arg)
	{
		vtkCubeAxesActor_SetYAxisTickVisibility_209(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYAxisVisibility_210(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void SetYAxisVisibility(int _arg)
	{
		vtkCubeAxesActor_SetYAxisVisibility_210(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYLabelFormat_211(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the format with which to print the labels on each of the
	/// x-y-z axes.
	/// </summary>
	public virtual void SetYLabelFormat(string _arg)
	{
		vtkCubeAxesActor_SetYLabelFormat_211(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYTitle_212(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual void SetYTitle(string _arg)
	{
		vtkCubeAxesActor_SetYTitle_212(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetYUnits_213(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual void SetYUnits(string _arg)
	{
		vtkCubeAxesActor_SetYUnits_213(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZAxesGridlinesProperty_214(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes (outer) gridlines actors properties.
	/// </summary>
	public void SetZAxesGridlinesProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetZAxesGridlinesProperty_214(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZAxesGridpolysProperty_215(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes gridPolys actors properties.
	/// </summary>
	public void SetZAxesGridpolysProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetZAxesGridpolysProperty_215(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZAxesInnerGridlinesProperty_216(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes inner gridlines actors properties.
	/// </summary>
	public void SetZAxesInnerGridlinesProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetZAxesInnerGridlinesProperty_216(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZAxesLinesProperty_217(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set axes actors properties.
	/// </summary>
	public void SetZAxesLinesProperty(vtkProperty arg0)
	{
		vtkCubeAxesActor_SetZAxesLinesProperty_217(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZAxisLabelVisibility_218(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual void SetZAxisLabelVisibility(int _arg)
	{
		vtkCubeAxesActor_SetZAxisLabelVisibility_218(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZAxisMinorTickVisibility_219(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void SetZAxisMinorTickVisibility(int _arg)
	{
		vtkCubeAxesActor_SetZAxisMinorTickVisibility_219(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZAxisRange_220(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public virtual void SetZAxisRange(double _arg1, double _arg2)
	{
		vtkCubeAxesActor_SetZAxisRange_220(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZAxisRange_221(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Explicitly specify the range of each axes that's used to define the prop.
	/// The default, (if you do not use these methods) is to use the bounds
	/// specified, or use the bounds of the Input Prop if one is specified. This
	/// method allows you to separate the notion of extent of the axes in physical
	/// space (bounds) and the extent of the values it represents. In other words,
	/// you can have the ticks and labels show a different range.
	/// </summary>
	public void SetZAxisRange(IntPtr _arg)
	{
		vtkCubeAxesActor_SetZAxisRange_221(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZAxisTickVisibility_222(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual void SetZAxisTickVisibility(int _arg)
	{
		vtkCubeAxesActor_SetZAxisTickVisibility_222(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZAxisVisibility_223(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void SetZAxisVisibility(int _arg)
	{
		vtkCubeAxesActor_SetZAxisVisibility_223(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZLabelFormat_224(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the format with which to print the labels on each of the
	/// x-y-z axes.
	/// </summary>
	public virtual void SetZLabelFormat(string _arg)
	{
		vtkCubeAxesActor_SetZLabelFormat_224(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZTitle_225(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual void SetZTitle(string _arg)
	{
		vtkCubeAxesActor_SetZTitle_225(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_SetZUnits_226(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the labels for the x, y, and z axes. By default,
	/// use "X-Axis", "Y-Axis" and "Z-Axis".
	/// </summary>
	public virtual void SetZUnits(string _arg)
	{
		vtkCubeAxesActor_SetZUnits_226(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_StickyAxesOff_227(HandleRef pThis);

	/// <summary>
	/// Enable/Disable axis stickiness. When on, the axes will be adjusted to always
	/// be visible in the viewport unless the original bounds of the axes are entirely
	/// outside the viewport. Defaults to off.
	/// </summary>
	public virtual void StickyAxesOff()
	{
		vtkCubeAxesActor_StickyAxesOff_227(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_StickyAxesOn_228(HandleRef pThis);

	/// <summary>
	/// Enable/Disable axis stickiness. When on, the axes will be adjusted to always
	/// be visible in the viewport unless the original bounds of the axes are entirely
	/// outside the viewport. Defaults to off.
	/// </summary>
	public virtual void StickyAxesOn()
	{
		vtkCubeAxesActor_StickyAxesOn_228(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_XAxisLabelVisibilityOff_229(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual void XAxisLabelVisibilityOff()
	{
		vtkCubeAxesActor_XAxisLabelVisibilityOff_229(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_XAxisLabelVisibilityOn_230(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual void XAxisLabelVisibilityOn()
	{
		vtkCubeAxesActor_XAxisLabelVisibilityOn_230(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_XAxisMinorTickVisibilityOff_231(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void XAxisMinorTickVisibilityOff()
	{
		vtkCubeAxesActor_XAxisMinorTickVisibilityOff_231(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_XAxisMinorTickVisibilityOn_232(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void XAxisMinorTickVisibilityOn()
	{
		vtkCubeAxesActor_XAxisMinorTickVisibilityOn_232(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_XAxisTickVisibilityOff_233(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual void XAxisTickVisibilityOff()
	{
		vtkCubeAxesActor_XAxisTickVisibilityOff_233(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_XAxisTickVisibilityOn_234(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual void XAxisTickVisibilityOn()
	{
		vtkCubeAxesActor_XAxisTickVisibilityOn_234(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_XAxisVisibilityOff_235(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void XAxisVisibilityOff()
	{
		vtkCubeAxesActor_XAxisVisibilityOff_235(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_XAxisVisibilityOn_236(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void XAxisVisibilityOn()
	{
		vtkCubeAxesActor_XAxisVisibilityOn_236(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_YAxisLabelVisibilityOff_237(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual void YAxisLabelVisibilityOff()
	{
		vtkCubeAxesActor_YAxisLabelVisibilityOff_237(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_YAxisLabelVisibilityOn_238(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual void YAxisLabelVisibilityOn()
	{
		vtkCubeAxesActor_YAxisLabelVisibilityOn_238(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_YAxisMinorTickVisibilityOff_239(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void YAxisMinorTickVisibilityOff()
	{
		vtkCubeAxesActor_YAxisMinorTickVisibilityOff_239(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_YAxisMinorTickVisibilityOn_240(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void YAxisMinorTickVisibilityOn()
	{
		vtkCubeAxesActor_YAxisMinorTickVisibilityOn_240(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_YAxisTickVisibilityOff_241(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual void YAxisTickVisibilityOff()
	{
		vtkCubeAxesActor_YAxisTickVisibilityOff_241(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_YAxisTickVisibilityOn_242(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual void YAxisTickVisibilityOn()
	{
		vtkCubeAxesActor_YAxisTickVisibilityOn_242(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_YAxisVisibilityOff_243(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void YAxisVisibilityOff()
	{
		vtkCubeAxesActor_YAxisVisibilityOff_243(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_YAxisVisibilityOn_244(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void YAxisVisibilityOn()
	{
		vtkCubeAxesActor_YAxisVisibilityOn_244(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_ZAxisLabelVisibilityOff_245(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual void ZAxisLabelVisibilityOff()
	{
		vtkCubeAxesActor_ZAxisLabelVisibilityOff_245(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_ZAxisLabelVisibilityOn_246(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of labels for each axis.
	/// </summary>
	public virtual void ZAxisLabelVisibilityOn()
	{
		vtkCubeAxesActor_ZAxisLabelVisibilityOn_246(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_ZAxisMinorTickVisibilityOff_247(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void ZAxisMinorTickVisibilityOff()
	{
		vtkCubeAxesActor_ZAxisMinorTickVisibilityOff_247(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_ZAxisMinorTickVisibilityOn_248(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of minor ticks for each axis.
	/// </summary>
	public virtual void ZAxisMinorTickVisibilityOn()
	{
		vtkCubeAxesActor_ZAxisMinorTickVisibilityOn_248(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_ZAxisTickVisibilityOff_249(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual void ZAxisTickVisibilityOff()
	{
		vtkCubeAxesActor_ZAxisTickVisibilityOff_249(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_ZAxisTickVisibilityOn_250(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of ticks for each axis.
	/// </summary>
	public virtual void ZAxisTickVisibilityOn()
	{
		vtkCubeAxesActor_ZAxisTickVisibilityOn_250(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_ZAxisVisibilityOff_251(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void ZAxisVisibilityOff()
	{
		vtkCubeAxesActor_ZAxisVisibilityOff_251(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeAxesActor_ZAxisVisibilityOn_252(HandleRef pThis);

	/// <summary>
	/// Turn on and off the visibility of each axis.
	/// </summary>
	public virtual void ZAxisVisibilityOn()
	{
		vtkCubeAxesActor_ZAxisVisibilityOn_252(GetCppThis());
	}
}
