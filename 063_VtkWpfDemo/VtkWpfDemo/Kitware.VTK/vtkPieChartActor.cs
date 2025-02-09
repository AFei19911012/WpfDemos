using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPieChartActor
/// </summary>
/// <remarks>
///    create a pie chart from an array
///
/// vtkPieChartActor generates a pie chart from an array of numbers defined in
/// field data (a vtkDataObject). To use this class, you must specify an input
/// data object. You'll probably also want to specify the position of the plot
/// be setting the Position and Position2 instance variables, which define a
/// rectangle in which the plot lies.  There are also many other instance
/// variables that control the look of the plot includes its title,
/// and legend.
///
/// Set the text property/attributes of the title and the labels through the
/// vtkTextProperty objects associated with these components.
///
/// </remarks>
/// <seealso>
///
/// vtkParallelCoordinatesActor vtkXYPlotActor2D vtkSpiderPlotActor
/// </seealso>
public class vtkPieChartActor : vtkActor2D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPieChartActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPieChartActor()
	{
		MRClassNameKey = "class vtkPieChartActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPieChartActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPieChartActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPieChartActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkPieChartActor New()
	{
		vtkPieChartActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPieChartActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPieChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkPieChartActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPieChartActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPieChartActor_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input data object to this actor.
	/// </summary>
	public virtual vtkDataObject GetInput()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPieChartActor_GetInput_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPieChartActor_GetLabelTextProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the labels text property. This controls the appearance
	/// of all pie piece labels.
	/// </summary>
	public virtual vtkTextProperty GetLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPieChartActor_GetLabelTextProperty_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPieChartActor_GetLabelVisibility_03(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of pie piece labels.
	/// </summary>
	public virtual int GetLabelVisibility()
	{
		return vtkPieChartActor_GetLabelVisibility_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPieChartActor_GetLegendActor_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkPieChartActor_GetLegendActor_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPieChartActor_GetLegendVisibility_05(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual int GetLegendVisibility()
	{
		return vtkPieChartActor_GetLegendVisibility_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPieChartActor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPieChartActor_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPieChartActor_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPieChartActor_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPieChartActor_GetPieceColor_08(HandleRef pThis, int i);

	/// <summary>
	/// Specify colors for each piece of pie. If not specified, they are
	/// automatically generated.
	/// </summary>
	public IntPtr GetPieceColor(int i)
	{
		return vtkPieChartActor_GetPieceColor_08(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPieChartActor_GetPieceLabel_09(HandleRef pThis, int i);

	/// <summary>
	/// Specify the names for each piece of pie.  not specified, then an integer
	/// number is automatically generated.
	/// </summary>
	public string GetPieceLabel(int i)
	{
		return Marshal.PtrToStringAnsi(vtkPieChartActor_GetPieceLabel_09(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPieChartActor_GetTitle_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the title of the pie chart.
	/// </summary>
	public virtual string GetTitle()
	{
		return Marshal.PtrToStringAnsi(vtkPieChartActor_GetTitle_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPieChartActor_GetTitleTextProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkPieChartActor_GetTitleTextProperty_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPieChartActor_GetTitleVisibility_12(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual int GetTitleVisibility()
	{
		return vtkPieChartActor_GetTitleVisibility_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPieChartActor_HasTranslucentPolygonalGeometry_13(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkPieChartActor_HasTranslucentPolygonalGeometry_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPieChartActor_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPieChartActor_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPieChartActor_IsTypeOf_15(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPieChartActor_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_LabelVisibilityOff_16(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of pie piece labels.
	/// </summary>
	public virtual void LabelVisibilityOff()
	{
		vtkPieChartActor_LabelVisibilityOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_LabelVisibilityOn_17(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of pie piece labels.
	/// </summary>
	public virtual void LabelVisibilityOn()
	{
		vtkPieChartActor_LabelVisibilityOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_LegendVisibilityOff_18(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual void LegendVisibilityOff()
	{
		vtkPieChartActor_LegendVisibilityOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_LegendVisibilityOn_19(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual void LegendVisibilityOn()
	{
		vtkPieChartActor_LegendVisibilityOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPieChartActor_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkPieChartActor NewInstance()
	{
		vtkPieChartActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPieChartActor_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPieChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_ReleaseGraphicsResources_22(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkPieChartActor_ReleaseGraphicsResources_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPieChartActor_RenderOpaqueGeometry_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the pie plot.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkPieChartActor_RenderOpaqueGeometry_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPieChartActor_RenderOverlay_24(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the pie plot.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkPieChartActor_RenderOverlay_24(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPieChartActor_RenderTranslucentPolygonalGeometry_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the pie plot.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkPieChartActor_RenderTranslucentPolygonalGeometry_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPieChartActor_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkPieChartActor SafeDownCast(vtkObjectBase o)
	{
		vtkPieChartActor vtkPieChartActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPieChartActor_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPieChartActor2 = (vtkPieChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPieChartActor2.Register(null);
			}
		}
		return vtkPieChartActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_SetInputConnection_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the input to the pie chart actor. SetInputData()
	/// does not connect the pipeline whereas SetInputConnection()
	/// does.
	/// </summary>
	public virtual void SetInputConnection(vtkAlgorithmOutput arg0)
	{
		vtkPieChartActor_SetInputConnection_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_SetInputData_28(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the input to the pie chart actor. SetInputData()
	/// does not connect the pipeline whereas SetInputConnection()
	/// does.
	/// </summary>
	public virtual void SetInputData(vtkDataObject arg0)
	{
		vtkPieChartActor_SetInputData_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_SetLabelTextProperty_29(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the labels text property. This controls the appearance
	/// of all pie piece labels.
	/// </summary>
	public virtual void SetLabelTextProperty(vtkTextProperty p)
	{
		vtkPieChartActor_SetLabelTextProperty_29(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_SetLabelVisibility_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable the display of pie piece labels.
	/// </summary>
	public virtual void SetLabelVisibility(int _arg)
	{
		vtkPieChartActor_SetLabelVisibility_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_SetLegendVisibility_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable the creation of a legend. If on, the legend labels will
	/// be created automatically unless the per plot legend symbol has been
	/// set.
	/// </summary>
	public virtual void SetLegendVisibility(int _arg)
	{
		vtkPieChartActor_SetLegendVisibility_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_SetPieceColor_32(HandleRef pThis, int i, double r, double g, double b);

	/// <summary>
	/// Specify colors for each piece of pie. If not specified, they are
	/// automatically generated.
	/// </summary>
	public void SetPieceColor(int i, double r, double g, double b)
	{
		vtkPieChartActor_SetPieceColor_32(GetCppThis(), i, r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_SetPieceColor_33(HandleRef pThis, int i, IntPtr color);

	/// <summary>
	/// Specify colors for each piece of pie. If not specified, they are
	/// automatically generated.
	/// </summary>
	public void SetPieceColor(int i, IntPtr color)
	{
		vtkPieChartActor_SetPieceColor_33(GetCppThis(), i, color);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_SetPieceLabel_34(HandleRef pThis, int i, string arg1);

	/// <summary>
	/// Specify the names for each piece of pie.  not specified, then an integer
	/// number is automatically generated.
	/// </summary>
	public void SetPieceLabel(int i, string arg1)
	{
		vtkPieChartActor_SetPieceLabel_34(GetCppThis(), i, arg1);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_SetTitle_35(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the title of the pie chart.
	/// </summary>
	public virtual void SetTitle(string _arg)
	{
		vtkPieChartActor_SetTitle_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_SetTitleTextProperty_36(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the title text property. The property controls the
	/// appearance of the plot title.
	/// </summary>
	public virtual void SetTitleTextProperty(vtkTextProperty p)
	{
		vtkPieChartActor_SetTitleTextProperty_36(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_SetTitleVisibility_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual void SetTitleVisibility(int _arg)
	{
		vtkPieChartActor_SetTitleVisibility_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_TitleVisibilityOff_38(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual void TitleVisibilityOff()
	{
		vtkPieChartActor_TitleVisibilityOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPieChartActor_TitleVisibilityOn_39(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the display of a plot title.
	/// </summary>
	public virtual void TitleVisibilityOn()
	{
		vtkPieChartActor_TitleVisibilityOn_39(GetCppThis());
	}
}
