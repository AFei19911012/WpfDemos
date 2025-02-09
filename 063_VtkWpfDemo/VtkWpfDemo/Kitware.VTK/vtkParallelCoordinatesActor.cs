using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParallelCoordinatesActor
/// </summary>
/// <remarks>
///    create parallel coordinate display from input field
///
/// vtkParallelCoordinatesActor generates a parallel coordinates plot from an
/// input field (i.e., vtkDataObject). Parallel coordinates represent
/// N-dimensional data by using a set of N parallel axes (not orthogonal like
/// the usual x-y-z Cartesian axes). Each N-dimensional point is plotted as a
/// polyline, were each of the N components of the point lie on one of the
/// N axes, and the components are connected by straight lines.
///
/// To use this class, you must specify an input data object. You'll probably
/// also want to specify the position of the plot be setting the Position and
/// Position2 instance variables, which define a rectangle in which the plot
/// lies. Another important parameter is the IndependentVariables ivar, which
/// tells the instance how to interpret the field data (independent variables
/// as the rows or columns of the field). There are also many other instance
/// variables that control the look of the plot includes its title,
/// attributes, number of ticks on the axes, etc.
///
/// Set the text property/attributes of the title and the labels through the
/// vtkTextProperty objects associated to this actor.
///
/// @warning
/// Field data is not necessarily "rectangular" in shape. In these cases, some
/// of the data may not be plotted.
///
/// @warning
/// Field data can contain non-numeric arrays (i.e. arrays not subclasses of
/// vtkDataArray). Such arrays are skipped.
///
/// @warning
/// The early implementation lacks many features that could be added in the
/// future. This includes the ability to "brush" data (choose regions along an
/// axis and highlight any points/lines passing through the region);
/// efficiency is really bad; more control over the properties of the plot
/// (separate properties for each axes,title,etc.; and using the labels found
/// in the field to label each of the axes.
///
/// </remarks>
/// <seealso>
///
/// vtkAxisActor3D can be used to create axes in world coordinate space.
/// vtkActor2D vtkTextMapper vtkPolyDataMapper2D vtkScalarBarActor
/// vtkCoordinate vtkTextProperty
/// </seealso>
public class vtkParallelCoordinatesActor : vtkActor2D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParallelCoordinatesActor()
	{
		MRClassNameKey = "class vtkParallelCoordinatesActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParallelCoordinatesActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with autorange computation;
	/// the number of labels set to 5 for the x and y axes;
	/// a label format of "%-#6.3g"; and x coordinates computed from point
	/// ids.
	/// </summary>
	public new static vtkParallelCoordinatesActor New()
	{
		vtkParallelCoordinatesActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelCoordinatesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with autorange computation;
	/// the number of labels set to 5 for the x and y axes;
	/// a label format of "%-#6.3g"; and x coordinates computed from point
	/// ids.
	/// </summary>
	public vtkParallelCoordinatesActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParallelCoordinatesActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkParallelCoordinatesActor_GetIndependentVariables_01(HandleRef pThis);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public virtual int GetIndependentVariables()
	{
		return vtkParallelCoordinatesActor_GetIndependentVariables_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesActor_GetIndependentVariablesMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public virtual int GetIndependentVariablesMaxValue()
	{
		return vtkParallelCoordinatesActor_GetIndependentVariablesMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesActor_GetIndependentVariablesMinValue_03(HandleRef pThis);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public virtual int GetIndependentVariablesMinValue()
	{
		return vtkParallelCoordinatesActor_GetIndependentVariablesMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesActor_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Remove a dataset from the list of data to append.
	/// </summary>
	public vtkDataObject GetInput()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesActor_GetInput_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkParallelCoordinatesActor_GetLabelFormat_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the format with which to print the labels on the axes.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkParallelCoordinatesActor_GetLabelFormat_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesActor_GetLabelTextProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the labels text property.
	/// </summary>
	public virtual vtkTextProperty GetLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesActor_GetLabelTextProperty_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkParallelCoordinatesActor_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParallelCoordinatesActor_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelCoordinatesActor_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParallelCoordinatesActor_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesActor_GetNumberOfLabels_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of annotation labels to show along each axis.
	/// This values is a suggestion: the number of labels may vary depending
	/// on the particulars of the data.
	/// </summary>
	public virtual int GetNumberOfLabels()
	{
		return vtkParallelCoordinatesActor_GetNumberOfLabels_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesActor_GetNumberOfLabelsMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of annotation labels to show along each axis.
	/// This values is a suggestion: the number of labels may vary depending
	/// on the particulars of the data.
	/// </summary>
	public virtual int GetNumberOfLabelsMaxValue()
	{
		return vtkParallelCoordinatesActor_GetNumberOfLabelsMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesActor_GetNumberOfLabelsMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of annotation labels to show along each axis.
	/// This values is a suggestion: the number of labels may vary depending
	/// on the particulars of the data.
	/// </summary>
	public virtual int GetNumberOfLabelsMinValue()
	{
		return vtkParallelCoordinatesActor_GetNumberOfLabelsMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesActor_GetTitle_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the title of the parallel coordinates plot.
	/// </summary>
	public virtual string GetTitle()
	{
		return Marshal.PtrToStringAnsi(vtkParallelCoordinatesActor_GetTitle_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesActor_GetTitleTextProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual vtkTextProperty GetTitleTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesActor_GetTitleTextProperty_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkParallelCoordinatesActor_HasTranslucentPolygonalGeometry_14(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkParallelCoordinatesActor_HasTranslucentPolygonalGeometry_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesActor_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParallelCoordinatesActor_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesActor_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParallelCoordinatesActor_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesActor_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParallelCoordinatesActor NewInstance()
	{
		vtkParallelCoordinatesActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesActor_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelCoordinatesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesActor_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkParallelCoordinatesActor_ReleaseGraphicsResources_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesActor_RenderOpaqueGeometry_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the parallel coordinates plot.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkParallelCoordinatesActor_RenderOpaqueGeometry_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesActor_RenderOverlay_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the parallel coordinates plot.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkParallelCoordinatesActor_RenderOverlay_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesActor_RenderTranslucentPolygonalGeometry_22(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the parallel coordinates plot.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkParallelCoordinatesActor_RenderTranslucentPolygonalGeometry_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesActor_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParallelCoordinatesActor SafeDownCast(vtkObjectBase o)
	{
		vtkParallelCoordinatesActor vtkParallelCoordinatesActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesActor_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParallelCoordinatesActor2 = (vtkParallelCoordinatesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParallelCoordinatesActor2.Register(null);
			}
		}
		return vtkParallelCoordinatesActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesActor_SetIndependentVariables_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public virtual void SetIndependentVariables(int _arg)
	{
		vtkParallelCoordinatesActor_SetIndependentVariables_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesActor_SetIndependentVariablesToColumns_25(HandleRef pThis);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public void SetIndependentVariablesToColumns()
	{
		vtkParallelCoordinatesActor_SetIndependentVariablesToColumns_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesActor_SetIndependentVariablesToRows_26(HandleRef pThis);

	/// <summary>
	/// Specify whether to use the rows or columns as independent variables.
	/// If columns, then each row represents a separate point. If rows, then
	/// each column represents a separate point.
	/// </summary>
	public void SetIndependentVariablesToRows()
	{
		vtkParallelCoordinatesActor_SetIndependentVariablesToRows_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesActor_SetInputConnection_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the input to the parallel coordinates actor. Creates
	/// a pipeline connection.
	/// </summary>
	public virtual void SetInputConnection(vtkAlgorithmOutput arg0)
	{
		vtkParallelCoordinatesActor_SetInputConnection_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesActor_SetInputData_28(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the input to the parallel coordinates actor. Does not
	/// create a pipeline connection.
	/// </summary>
	public virtual void SetInputData(vtkDataObject arg0)
	{
		vtkParallelCoordinatesActor_SetInputData_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesActor_SetLabelFormat_29(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the format with which to print the labels on the axes.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkParallelCoordinatesActor_SetLabelFormat_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesActor_SetLabelTextProperty_30(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the labels text property.
	/// </summary>
	public virtual void SetLabelTextProperty(vtkTextProperty p)
	{
		vtkParallelCoordinatesActor_SetLabelTextProperty_30(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesActor_SetNumberOfLabels_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of annotation labels to show along each axis.
	/// This values is a suggestion: the number of labels may vary depending
	/// on the particulars of the data.
	/// </summary>
	public virtual void SetNumberOfLabels(int _arg)
	{
		vtkParallelCoordinatesActor_SetNumberOfLabels_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesActor_SetTitle_32(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the title of the parallel coordinates plot.
	/// </summary>
	public virtual void SetTitle(string _arg)
	{
		vtkParallelCoordinatesActor_SetTitle_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesActor_SetTitleTextProperty_33(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual void SetTitleTextProperty(vtkTextProperty p)
	{
		vtkParallelCoordinatesActor_SetTitleTextProperty_33(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}
}
