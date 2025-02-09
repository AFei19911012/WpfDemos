using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBarChartActor
/// </summary>
/// <remarks>
///    create a bar chart from an array
///
/// vtkBarChartActor generates a bar chart from an array of numbers defined in
/// field data (a vtkDataObject). To use this class, you must specify an input
/// data object. You'll probably also want to specify the position of the plot
/// be setting the Position and Position2 instance variables, which define a
/// rectangle in which the plot lies.  There are also many other instance
/// variables that control the look of the plot includes its title and legend.
///
/// Set the text property/attributes of the title and the labels through the
/// vtkTextProperty objects associated with these components.
///
/// </remarks>
/// <seealso>
///
/// vtkParallelCoordinatesActor vtkXYPlotActor vtkSpiderPlotActor
/// vtkPieChartActor
/// </seealso>
public class vtkBarChartActor : vtkActor2D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBarChartActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBarChartActor()
	{
		MRClassNameKey = "class vtkBarChartActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBarChartActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBarChartActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBarChartActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkBarChartActor New()
	{
		vtkBarChartActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBarChartActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBarChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkBarChartActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBarChartActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBarChartActor_GetBarColor_01(HandleRef pThis, int i);

	/// <summary>
	/// Specify colors for each bar. If not specified, they are
	/// automatically generated.
	/// </summary>
	public IntPtr GetBarColor(int i)
	{
		return vtkBarChartActor_GetBarColor_01(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBarChartActor_GetBarLabel_02(HandleRef pThis, int i);

	/// <summary>
	/// Specify the names of each bar. If
	/// not specified, then an integer number is automatically generated.
	/// </summary>
	public string GetBarLabel(int i)
	{
		return Marshal.PtrToStringAnsi(vtkBarChartActor_GetBarLabel_02(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBarChartActor_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input data object to this actor.
	/// </summary>
	public virtual vtkDataObject GetInput()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBarChartActor_GetInput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBarChartActor_GetLabelTextProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the labels text property. This controls the appearance
	/// of all bar bar labels.
	/// </summary>
	public virtual vtkTextProperty GetLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBarChartActor_GetLabelTextProperty_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkBarChartActor_GetLabelVisibility_05(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of bar labels.
	/// </summary>
	public virtual int GetLabelVisibility()
	{
		return vtkBarChartActor_GetLabelVisibility_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBarChartActor_GetLegendActor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBarChartActor_GetLegendActor_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkBarChartActor_GetLegendVisibility_07(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual int GetLegendVisibility()
	{
		return vtkBarChartActor_GetLegendVisibility_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBarChartActor_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBarChartActor_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBarChartActor_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBarChartActor_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBarChartActor_GetTitle_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the title of the bar chart.
	/// </summary>
	public virtual string GetTitle()
	{
		return Marshal.PtrToStringAnsi(vtkBarChartActor_GetTitle_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBarChartActor_GetTitleTextProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the title text property. The property controls the
	/// appearance of the plot title.
	/// </summary>
	public virtual vtkTextProperty GetTitleTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBarChartActor_GetTitleTextProperty_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkBarChartActor_GetTitleVisibility_12(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual int GetTitleVisibility()
	{
		return vtkBarChartActor_GetTitleVisibility_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBarChartActor_GetYTitle_13(HandleRef pThis);

	/// <summary>
	/// Specify the title of the y-axis.
	/// </summary>
	public virtual string GetYTitle()
	{
		return Marshal.PtrToStringAnsi(vtkBarChartActor_GetYTitle_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBarChartActor_HasTranslucentPolygonalGeometry_14(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkBarChartActor_HasTranslucentPolygonalGeometry_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBarChartActor_IsA_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBarChartActor_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBarChartActor_IsTypeOf_16(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBarChartActor_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_LabelVisibilityOff_17(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of bar labels.
	/// </summary>
	public virtual void LabelVisibilityOff()
	{
		vtkBarChartActor_LabelVisibilityOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_LabelVisibilityOn_18(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of bar labels.
	/// </summary>
	public virtual void LabelVisibilityOn()
	{
		vtkBarChartActor_LabelVisibilityOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_LegendVisibilityOff_19(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual void LegendVisibilityOff()
	{
		vtkBarChartActor_LegendVisibilityOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_LegendVisibilityOn_20(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual void LegendVisibilityOn()
	{
		vtkBarChartActor_LegendVisibilityOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBarChartActor_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkBarChartActor NewInstance()
	{
		vtkBarChartActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBarChartActor_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBarChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_ReleaseGraphicsResources_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkBarChartActor_ReleaseGraphicsResources_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBarChartActor_RenderOpaqueGeometry_24(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the bar plot.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkBarChartActor_RenderOpaqueGeometry_24(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBarChartActor_RenderOverlay_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the bar plot.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkBarChartActor_RenderOverlay_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBarChartActor_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the bar plot.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkBarChartActor_RenderTranslucentPolygonalGeometry_26(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBarChartActor_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkBarChartActor SafeDownCast(vtkObjectBase o)
	{
		vtkBarChartActor vtkBarChartActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBarChartActor_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBarChartActor2 = (vtkBarChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBarChartActor2.Register(null);
			}
		}
		return vtkBarChartActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_SetBarColor_28(HandleRef pThis, int i, double r, double g, double b);

	/// <summary>
	/// Specify colors for each bar. If not specified, they are
	/// automatically generated.
	/// </summary>
	public void SetBarColor(int i, double r, double g, double b)
	{
		vtkBarChartActor_SetBarColor_28(GetCppThis(), i, r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_SetBarColor_29(HandleRef pThis, int i, IntPtr color);

	/// <summary>
	/// Specify colors for each bar. If not specified, they are
	/// automatically generated.
	/// </summary>
	public void SetBarColor(int i, IntPtr color)
	{
		vtkBarChartActor_SetBarColor_29(GetCppThis(), i, color);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_SetBarLabel_30(HandleRef pThis, int i, string arg1);

	/// <summary>
	/// Specify the names of each bar. If
	/// not specified, then an integer number is automatically generated.
	/// </summary>
	public void SetBarLabel(int i, string arg1)
	{
		vtkBarChartActor_SetBarLabel_30(GetCppThis(), i, arg1);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_SetInput_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the input to the bar chart actor.
	/// </summary>
	public virtual void SetInput(vtkDataObject arg0)
	{
		vtkBarChartActor_SetInput_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_SetLabelTextProperty_32(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the labels text property. This controls the appearance
	/// of all bar bar labels.
	/// </summary>
	public virtual void SetLabelTextProperty(vtkTextProperty p)
	{
		vtkBarChartActor_SetLabelTextProperty_32(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_SetLabelVisibility_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable the display of bar labels.
	/// </summary>
	public virtual void SetLabelVisibility(int _arg)
	{
		vtkBarChartActor_SetLabelVisibility_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_SetLegendVisibility_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual void SetLegendVisibility(int _arg)
	{
		vtkBarChartActor_SetLegendVisibility_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_SetTitle_35(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the title of the bar chart.
	/// </summary>
	public virtual void SetTitle(string _arg)
	{
		vtkBarChartActor_SetTitle_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_SetTitleTextProperty_36(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the title text property. The property controls the
	/// appearance of the plot title.
	/// </summary>
	public virtual void SetTitleTextProperty(vtkTextProperty p)
	{
		vtkBarChartActor_SetTitleTextProperty_36(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_SetTitleVisibility_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual void SetTitleVisibility(int _arg)
	{
		vtkBarChartActor_SetTitleVisibility_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_SetYTitle_38(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the title of the y-axis.
	/// </summary>
	public virtual void SetYTitle(string _arg)
	{
		vtkBarChartActor_SetYTitle_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_TitleVisibilityOff_39(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual void TitleVisibilityOff()
	{
		vtkBarChartActor_TitleVisibilityOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBarChartActor_TitleVisibilityOn_40(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual void TitleVisibilityOn()
	{
		vtkBarChartActor_TitleVisibilityOn_40(GetCppThis());
	}
}
