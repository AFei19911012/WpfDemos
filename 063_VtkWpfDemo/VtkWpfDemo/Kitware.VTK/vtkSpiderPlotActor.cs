using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSpiderPlotActor
/// </summary>
/// <remarks>
///    create a spider plot from input field
///
/// vtkSpiderPlotActor generates a spider plot from an input field (i.e.,
/// vtkDataObject). A spider plot represents N-dimensional data by using a set
/// of N axes that originate from the center of a circle, and form the spokes
/// of a wheel (like a spider web).  Each N-dimensional point is plotted as a
/// polyline that forms a closed polygon; the vertices of the polygon
/// are plotted against the radial axes.
///
/// To use this class, you must specify an input data object. You'll probably
/// also want to specify the position of the plot be setting the Position and
/// Position2 instance variables, which define a rectangle in which the plot
/// lies. Another important parameter is the IndependentVariables ivar, which
/// tells the instance how to interpret the field data (independent variables
/// as the rows or columns of the field). There are also many other instance
/// variables that control the look of the plot includes its title and legend.
///
/// Set the text property/attributes of the title and the labels through the
/// vtkTextProperty objects associated with these components.
///
/// @warning
/// Field data is not necessarily "rectangular" in shape. In these cases, some
/// of the data may not be plotted.
///
/// @warning
/// Field data can contain non-numeric arrays (i.e. arrays not subclasses of
/// vtkDataArray). Such arrays are skipped.
///
/// </remarks>
/// <seealso>
///
/// vtkParallelCoordinatesActor vtkXYPlotActor2D
/// </seealso>
public class vtkSpiderPlotActor : vtkActor2D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSpiderPlotActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSpiderPlotActor()
	{
		MRClassNameKey = "class vtkSpiderPlotActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpiderPlotActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSpiderPlotActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpiderPlotActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkSpiderPlotActor New()
	{
		vtkSpiderPlotActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpiderPlotActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpiderPlotActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkSpiderPlotActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSpiderPlotActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSpiderPlotActor_GetAxisLabel_01(HandleRef pThis, int i);

	/// <summary>
	/// Specify the names of the radial spokes (i.e., the radial axes). If
	/// not specified, then an integer number is automatically generated.
	/// </summary>
	public string GetAxisLabel(int i)
	{
		return Marshal.PtrToStringAnsi(vtkSpiderPlotActor_GetAxisLabel_01(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_GetAxisRange_02(HandleRef pThis, int i, IntPtr range);

	/// <summary>
	/// Specify the range of data on each radial axis. If not specified,
	/// then the range is computed automatically.
	/// </summary>
	public void GetAxisRange(int i, IntPtr range)
	{
		vtkSpiderPlotActor_GetAxisRange_02(GetCppThis(), i, range);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_GetIndependentVariables_03(HandleRef pThis);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public virtual int GetIndependentVariables()
	{
		return vtkSpiderPlotActor_GetIndependentVariables_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_GetIndependentVariablesMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public virtual int GetIndependentVariablesMaxValue()
	{
		return vtkSpiderPlotActor_GetIndependentVariablesMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_GetIndependentVariablesMinValue_05(HandleRef pThis);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public virtual int GetIndependentVariablesMinValue()
	{
		return vtkSpiderPlotActor_GetIndependentVariablesMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpiderPlotActor_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input data object to this actor.
	/// </summary>
	public virtual vtkDataObject GetInput()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpiderPlotActor_GetInput_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpiderPlotActor_GetLabelTextProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual vtkTextProperty GetLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpiderPlotActor_GetLabelTextProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSpiderPlotActor_GetLabelVisibility_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual int GetLabelVisibility()
	{
		return vtkSpiderPlotActor_GetLabelVisibility_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpiderPlotActor_GetLegendActor_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve handles to the legend box. This is useful if you would like
	/// to manually control the legend appearance.
	/// </summary>
	public virtual vtkLegendBoxActor GetLegendActor()
	{
		vtkLegendBoxActor vtkLegendBoxActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpiderPlotActor_GetLegendActor_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLegendBoxActor2 = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLegendBoxActor2.Register(null);
			}
		}
		return vtkLegendBoxActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_GetLegendVisibility_10(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual int GetLegendVisibility()
	{
		return vtkSpiderPlotActor_GetLegendVisibility_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpiderPlotActor_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSpiderPlotActor_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpiderPlotActor_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSpiderPlotActor_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_GetNumberOfRings_13(HandleRef pThis);

	/// <summary>
	/// Specify the number of circumferential rings. If set to zero, then
	/// none will be shown; otherwise the specified number will be shown.
	/// </summary>
	public virtual int GetNumberOfRings()
	{
		return vtkSpiderPlotActor_GetNumberOfRings_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_GetNumberOfRingsMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Specify the number of circumferential rings. If set to zero, then
	/// none will be shown; otherwise the specified number will be shown.
	/// </summary>
	public virtual int GetNumberOfRingsMaxValue()
	{
		return vtkSpiderPlotActor_GetNumberOfRingsMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_GetNumberOfRingsMinValue_15(HandleRef pThis);

	/// <summary>
	/// Specify the number of circumferential rings. If set to zero, then
	/// none will be shown; otherwise the specified number will be shown.
	/// </summary>
	public virtual int GetNumberOfRingsMinValue()
	{
		return vtkSpiderPlotActor_GetNumberOfRingsMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpiderPlotActor_GetPlotColor_16(HandleRef pThis, int i);

	/// <summary>
	/// Specify colors for each plot. If not specified, they are automatically generated.
	/// </summary>
	public IntPtr GetPlotColor(int i)
	{
		return vtkSpiderPlotActor_GetPlotColor_16(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpiderPlotActor_GetTitle_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the title of the spider plot.
	/// </summary>
	public virtual string GetTitle()
	{
		return Marshal.PtrToStringAnsi(vtkSpiderPlotActor_GetTitle_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpiderPlotActor_GetTitleTextProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual vtkTextProperty GetTitleTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpiderPlotActor_GetTitleTextProperty_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSpiderPlotActor_GetTitleVisibility_19(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual int GetTitleVisibility()
	{
		return vtkSpiderPlotActor_GetTitleVisibility_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_HasTranslucentPolygonalGeometry_20(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkSpiderPlotActor_HasTranslucentPolygonalGeometry_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_IsA_21(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSpiderPlotActor_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_IsTypeOf_22(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSpiderPlotActor_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_LabelVisibilityOff_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual void LabelVisibilityOff()
	{
		vtkSpiderPlotActor_LabelVisibilityOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_LabelVisibilityOn_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual void LabelVisibilityOn()
	{
		vtkSpiderPlotActor_LabelVisibilityOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_LegendVisibilityOff_25(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual void LegendVisibilityOff()
	{
		vtkSpiderPlotActor_LegendVisibilityOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_LegendVisibilityOn_26(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual void LegendVisibilityOn()
	{
		vtkSpiderPlotActor_LegendVisibilityOn_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpiderPlotActor_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkSpiderPlotActor NewInstance()
	{
		vtkSpiderPlotActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpiderPlotActor_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpiderPlotActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_ReleaseGraphicsResources_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkSpiderPlotActor_ReleaseGraphicsResources_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_RenderOpaqueGeometry_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the spider plot.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkSpiderPlotActor_RenderOpaqueGeometry_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_RenderOverlay_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the spider plot.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkSpiderPlotActor_RenderOverlay_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpiderPlotActor_RenderTranslucentPolygonalGeometry_32(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the spider plot.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkSpiderPlotActor_RenderTranslucentPolygonalGeometry_32(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpiderPlotActor_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkSpiderPlotActor SafeDownCast(vtkObjectBase o)
	{
		vtkSpiderPlotActor vtkSpiderPlotActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpiderPlotActor_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSpiderPlotActor2 = (vtkSpiderPlotActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSpiderPlotActor2.Register(null);
			}
		}
		return vtkSpiderPlotActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetAxisLabel_34(HandleRef pThis, int i, string arg1);

	/// <summary>
	/// Specify the names of the radial spokes (i.e., the radial axes). If
	/// not specified, then an integer number is automatically generated.
	/// </summary>
	public void SetAxisLabel(int i, string arg1)
	{
		vtkSpiderPlotActor_SetAxisLabel_34(GetCppThis(), i, arg1);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetAxisRange_35(HandleRef pThis, int i, double min, double max);

	/// <summary>
	/// Specify the range of data on each radial axis. If not specified,
	/// then the range is computed automatically.
	/// </summary>
	public void SetAxisRange(int i, double min, double max)
	{
		vtkSpiderPlotActor_SetAxisRange_35(GetCppThis(), i, min, max);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetAxisRange_36(HandleRef pThis, int i, IntPtr range);

	/// <summary>
	/// Specify the range of data on each radial axis. If not specified,
	/// then the range is computed automatically.
	/// </summary>
	public void SetAxisRange(int i, IntPtr range)
	{
		vtkSpiderPlotActor_SetAxisRange_36(GetCppThis(), i, range);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetIndependentVariables_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public virtual void SetIndependentVariables(int _arg)
	{
		vtkSpiderPlotActor_SetIndependentVariables_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetIndependentVariablesToColumns_38(HandleRef pThis);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public void SetIndependentVariablesToColumns()
	{
		vtkSpiderPlotActor_SetIndependentVariablesToColumns_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetIndependentVariablesToRows_39(HandleRef pThis);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public void SetIndependentVariablesToRows()
	{
		vtkSpiderPlotActor_SetIndependentVariablesToRows_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetInputConnection_40(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the input to the pie chart actor. SetInputData()
	/// does not connect the pipeline whereas SetInputConnection()
	/// does.
	/// </summary>
	public virtual void SetInputConnection(vtkAlgorithmOutput arg0)
	{
		vtkSpiderPlotActor_SetInputConnection_40(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetInputData_41(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the input to the pie chart actor. SetInputData()
	/// does not connect the pipeline whereas SetInputConnection()
	/// does.
	/// </summary>
	public virtual void SetInputData(vtkDataObject arg0)
	{
		vtkSpiderPlotActor_SetInputData_41(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetLabelTextProperty_42(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual void SetLabelTextProperty(vtkTextProperty p)
	{
		vtkSpiderPlotActor_SetLabelTextProperty_42(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetLabelVisibility_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual void SetLabelVisibility(int _arg)
	{
		vtkSpiderPlotActor_SetLabelVisibility_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetLegendVisibility_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual void SetLegendVisibility(int _arg)
	{
		vtkSpiderPlotActor_SetLegendVisibility_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetNumberOfRings_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of circumferential rings. If set to zero, then
	/// none will be shown; otherwise the specified number will be shown.
	/// </summary>
	public virtual void SetNumberOfRings(int _arg)
	{
		vtkSpiderPlotActor_SetNumberOfRings_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetPlotColor_46(HandleRef pThis, int i, double r, double g, double b);

	/// <summary>
	/// Specify colors for each plot. If not specified, they are automatically generated.
	/// </summary>
	public void SetPlotColor(int i, double r, double g, double b)
	{
		vtkSpiderPlotActor_SetPlotColor_46(GetCppThis(), i, r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetPlotColor_47(HandleRef pThis, int i, IntPtr color);

	/// <summary>
	/// Specify colors for each plot. If not specified, they are automatically generated.
	/// </summary>
	public void SetPlotColor(int i, IntPtr color)
	{
		vtkSpiderPlotActor_SetPlotColor_47(GetCppThis(), i, color);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetTitle_48(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the title of the spider plot.
	/// </summary>
	public virtual void SetTitle(string _arg)
	{
		vtkSpiderPlotActor_SetTitle_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetTitleTextProperty_49(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual void SetTitleTextProperty(vtkTextProperty p)
	{
		vtkSpiderPlotActor_SetTitleTextProperty_49(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_SetTitleVisibility_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual void SetTitleVisibility(int _arg)
	{
		vtkSpiderPlotActor_SetTitleVisibility_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_TitleVisibilityOff_51(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual void TitleVisibilityOff()
	{
		vtkSpiderPlotActor_TitleVisibilityOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpiderPlotActor_TitleVisibilityOn_52(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual void TitleVisibilityOn()
	{
		vtkSpiderPlotActor_TitleVisibilityOn_52(GetCppThis());
	}
}
