using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointWidget
/// </summary>
/// <remarks>
///    position a point in 3D space
///
/// This 3D widget allows the user to position a point in 3D space using a 3D
/// cursor. The cursor has an outline bounding box, axes-aligned cross-hairs,
/// and axes shadows. (The outline and shadows can be turned off.) Any of
/// these can be turned off. A nice feature of the object is that the
/// vtkPointWidget, like any 3D widget, will work with the current interactor
/// style. That is, if vtkPointWidget does not handle an event, then all other
/// registered observers (including the interactor style) have an opportunity
/// to process the event. Otherwise, the vtkPointWidget will terminate the
/// processing of the event that it handles.
///
/// To use this object, just invoke SetInteractor() with the argument of the
/// method a vtkRenderWindowInteractor.  You may also wish to invoke
/// "PlaceWidget()" to initially position the widget. The interactor will act
/// normally until the "i" key (for "interactor") is pressed, at which point
/// the vtkPointWidget will appear. (See superclass documentation for
/// information about changing this behavior.) To move the point, the user can
/// grab (left mouse) on any widget line and "slide" the point into
/// position. Scaling is achieved by using the right mouse button "up" the
/// render window (makes the widget bigger) or "down" the render window (makes
/// the widget smaller). To translate the widget use the middle mouse button.
/// (Note: all of the translation interactions can be constrained to one of
/// the x-y-z axes by using the "shift" key.) The vtkPointWidget produces as
/// output a polydata with a single point and a vertex cell.
///
/// Some additional features of this class include the ability to control the
/// rendered properties of the widget. You can set the properties of the
/// selected and unselected representations of the parts of the widget. For
/// example, you can set the property of the 3D cursor in its normal and
/// selected states.
///
///
/// The constrained translation/sliding action (i.e., when the "shift" key is
/// depressed) along the axes is based on a combination of a "hot" spot around
/// the cursor focus plus the initial mouse motion after selection. That is,
/// if the user selects an axis outside of the hot spot, then the motion is
/// constrained along that axis. If the user selects the point widget near the
/// focus (within the hot spot), the initial motion defines a vector which is
/// compared to the x-y-z axes. The motion is constrained to the axis that is
/// most parallel to the initial motion vector.
///
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkLineWidget vtkBoxWidget vtkPlaneWidget
/// </seealso>
public class vtkPointWidget : vtk3DWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointWidget()
	{
		MRClassNameKey = "class vtkPointWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this widget
	/// </summary>
	public new static vtkPointWidget New()
	{
		vtkPointWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this widget
	/// </summary>
	public vtkPointWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_AllOff_01(HandleRef pThis);

	/// <summary>
	/// Convenience methods to turn outline and shadows on and off.
	/// </summary>
	public void AllOff()
	{
		vtkPointWidget_AllOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_AllOn_02(HandleRef pThis);

	/// <summary>
	/// Convenience methods to turn outline and shadows on and off.
	/// </summary>
	public void AllOn()
	{
		vtkPointWidget_AllOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointWidget_GetHotSpotSize_03(HandleRef pThis);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual double GetHotSpotSize()
	{
		return vtkPointWidget_GetHotSpotSize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointWidget_GetHotSpotSizeMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual double GetHotSpotSizeMaxValue()
	{
		return vtkPointWidget_GetHotSpotSizeMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointWidget_GetHotSpotSizeMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual double GetHotSpotSizeMinValue()
	{
		return vtkPointWidget_GetHotSpotSizeMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointWidget_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate this widget
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointWidget_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointWidget_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Instantiate this widget
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointWidget_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointWidget_GetOutline_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public int GetOutline()
	{
		return vtkPointWidget_GetOutline_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_GetPolyData_09(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that defines the point. A
	/// single point and a vertex compose the vtkPolyData.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkPointWidget_GetPolyData_09(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointWidget_GetPosition_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the point. Note that if the position is set
	/// outside of the bounding box, it will be clamped to the boundary of
	/// the bounding box.
	/// </summary>
	public double[] GetPosition()
	{
		IntPtr intPtr = vtkPointWidget_GetPosition_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_GetPosition_11(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the point. Note that if the position is set
	/// outside of the bounding box, it will be clamped to the boundary of
	/// the bounding box.
	/// </summary>
	public void GetPosition(IntPtr xyz)
	{
		vtkPointWidget_GetPosition_11(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointWidget_GetProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles when selected and normal can be
	/// set.
	/// </summary>
	public virtual vtkProperty GetProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointWidget_GetProperty_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointWidget_GetSelectedProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles when selected and normal can be
	/// set.
	/// </summary>
	public virtual vtkProperty GetSelectedProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointWidget_GetSelectedProperty_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointWidget_GetTranslationMode_14(HandleRef pThis);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated simultaneously as the point
	/// moves.
	/// </summary>
	public int GetTranslationMode()
	{
		return vtkPointWidget_GetTranslationMode_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointWidget_GetXShadows_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public int GetXShadows()
	{
		return vtkPointWidget_GetXShadows_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointWidget_GetYShadows_16(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public int GetYShadows()
	{
		return vtkPointWidget_GetYShadows_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointWidget_GetZShadows_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public int GetZShadows()
	{
		return vtkPointWidget_GetZShadows_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointWidget_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate this widget
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointWidget_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointWidget_IsTypeOf_19(string type);

	/// <summary>
	/// Instantiate this widget
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointWidget_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointWidget_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this widget
	/// </summary>
	public new vtkPointWidget NewInstance()
	{
		vtkPointWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointWidget_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_OutlineOff_22(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public void OutlineOff()
	{
		vtkPointWidget_OutlineOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_OutlineOn_23(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public void OutlineOn()
	{
		vtkPointWidget_OutlineOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_PlaceWidget_24(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkPointWidget_PlaceWidget_24(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_PlaceWidget_25(HandleRef pThis);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget()
	{
		vtkPointWidget_PlaceWidget_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_PlaceWidget_26(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkPointWidget_PlaceWidget_26(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointWidget_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this widget
	/// </summary>
	public new static vtkPointWidget SafeDownCast(vtkObjectBase o)
	{
		vtkPointWidget vtkPointWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointWidget_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointWidget2 = (vtkPointWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointWidget2.Register(null);
			}
		}
		return vtkPointWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_SetEnabled_28(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkPointWidget_SetEnabled_28(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_SetHotSpotSize_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual void SetHotSpotSize(double _arg)
	{
		vtkPointWidget_SetHotSpotSize_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_SetOutline_30(HandleRef pThis, int o);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public void SetOutline(int o)
	{
		vtkPointWidget_SetOutline_30(GetCppThis(), o);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_SetPosition_31(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of the point. Note that if the position is set
	/// outside of the bounding box, it will be clamped to the boundary of
	/// the bounding box.
	/// </summary>
	public void SetPosition(double x, double y, double z)
	{
		vtkPointWidget_SetPosition_31(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_SetPosition_32(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the position of the point. Note that if the position is set
	/// outside of the bounding box, it will be clamped to the boundary of
	/// the bounding box.
	/// </summary>
	public void SetPosition(IntPtr x)
	{
		vtkPointWidget_SetPosition_32(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_SetTranslationMode_33(HandleRef pThis, int mode);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated simultaneously as the point
	/// moves.
	/// </summary>
	public void SetTranslationMode(int mode)
	{
		vtkPointWidget_SetTranslationMode_33(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_SetXShadows_34(HandleRef pThis, int o);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public void SetXShadows(int o)
	{
		vtkPointWidget_SetXShadows_34(GetCppThis(), o);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_SetYShadows_35(HandleRef pThis, int o);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public void SetYShadows(int o)
	{
		vtkPointWidget_SetYShadows_35(GetCppThis(), o);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_SetZShadows_36(HandleRef pThis, int o);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public void SetZShadows(int o)
	{
		vtkPointWidget_SetZShadows_36(GetCppThis(), o);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_TranslationModeOff_37(HandleRef pThis);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated simultaneously as the point
	/// moves.
	/// </summary>
	public void TranslationModeOff()
	{
		vtkPointWidget_TranslationModeOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_TranslationModeOn_38(HandleRef pThis);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated simultaneously as the point
	/// moves.
	/// </summary>
	public void TranslationModeOn()
	{
		vtkPointWidget_TranslationModeOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_XShadowsOff_39(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public void XShadowsOff()
	{
		vtkPointWidget_XShadowsOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_XShadowsOn_40(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public void XShadowsOn()
	{
		vtkPointWidget_XShadowsOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_YShadowsOff_41(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public void YShadowsOff()
	{
		vtkPointWidget_YShadowsOff_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_YShadowsOn_42(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public void YShadowsOn()
	{
		vtkPointWidget_YShadowsOn_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_ZShadowsOff_43(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public void ZShadowsOff()
	{
		vtkPointWidget_ZShadowsOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointWidget_ZShadowsOn_44(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public void ZShadowsOn()
	{
		vtkPointWidget_ZShadowsOn_44(GetCppThis());
	}
}
