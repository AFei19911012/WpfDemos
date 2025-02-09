using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLineWidget
/// </summary>
/// <remarks>
///    3D widget for manipulating a line
///
/// This 3D widget defines a line that can be interactively placed in a
/// scene. The line has two handles (at its endpoints), plus the line can be
/// picked to translate it in the scene.  A nice feature of the object is that
/// the vtkLineWidget, like any 3D widget, will work with the current
/// interactor style and any other widgets present in the scene. That is, if
/// vtkLineWidget does not handle an event, then all other registered
/// observers (including the interactor style) have an opportunity to process
/// the event. Otherwise, the vtkLineWidget will terminate the processing of
/// the event that it handles.
///
/// To use this object, just invoke SetInteractor() with the argument of the
/// method a vtkRenderWindowInteractor.  You may also wish to invoke
/// "PlaceWidget()" to initially position the widget. The interactor will act
/// normally until the "i" key (for "interactor") is pressed, at which point
/// the vtkLineWidget will appear. (See superclass documentation for
/// information about changing this behavior.) By grabbing one of the two end
/// point handles (use the left mouse button), the line can be oriented and
/// stretched (the other end point remains fixed). By grabbing the line
/// itself, or using the middle mouse button, the entire line can be
/// translated.  Scaling (about the center of the line) is achieved by using
/// the right mouse button. By moving the mouse "up" the render window the
/// line will be made bigger; by moving "down" the render window the widget
/// will be made smaller. Turn off the widget by pressing the "i" key again
/// (or invoke the Off() method). (Note: picking the line or either one of the
/// two end point handles causes a vtkPointWidget to appear.  This widget has
/// the ability to constrain motion to an axis by pressing the "shift" key
/// while moving the mouse.)
///
/// The vtkLineWidget has several methods that can be used in conjunction with
/// other VTK objects. The Set/GetResolution() methods control the number of
/// subdivisions of the line; the GetPolyData() method can be used to get the
/// polygonal representation and can be used for things like seeding
/// streamlines. Typical usage of the widget is to make use of the
/// StartInteractionEvent, InteractionEvent, and EndInteractionEvent
/// events. The InteractionEvent is called on mouse motion; the other two
/// events are called on button down and button up (either left or right
/// button).
///
/// Some additional features of this class include the ability to control the
/// properties of the widget. You can set the properties of the selected and
/// unselected representations of the line. For example, you can set the
/// property for the handles and line. In addition there are methods to
/// constrain the line so that it is aligned along the x-y-z axes.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkBoxWidget vtkPlaneWidget
/// </seealso>
public class vtkLineWidget : vtk3DWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLineWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLineWidget()
	{
		MRClassNameKey = "class vtkLineWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLineWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLineWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkLineWidget New()
	{
		vtkLineWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkLineWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLineWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLineWidget_ClampToBoundsOff_01(HandleRef pThis);

	/// <summary>
	/// Enable/disable clamping of the point end points to the bounding box
	/// of the data. The bounding box is defined from the last PlaceWidget()
	/// invocation, and includes the effect of the PlaceFactor which is used
	/// to gram/shrink the bounding box.
	/// </summary>
	public virtual void ClampToBoundsOff()
	{
		vtkLineWidget_ClampToBoundsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_ClampToBoundsOn_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable clamping of the point end points to the bounding box
	/// of the data. The bounding box is defined from the last PlaceWidget()
	/// invocation, and includes the effect of the PlaceFactor which is used
	/// to gram/shrink the bounding box.
	/// </summary>
	public virtual void ClampToBoundsOn()
	{
		vtkLineWidget_ClampToBoundsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineWidget_GetAlign_03(HandleRef pThis);

	/// <summary>
	/// Force the line widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the line to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetAlign()
	{
		return vtkLineWidget_GetAlign_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineWidget_GetAlignMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Force the line widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the line to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetAlignMaxValue()
	{
		return vtkLineWidget_GetAlignMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineWidget_GetAlignMinValue_05(HandleRef pThis);

	/// <summary>
	/// Force the line widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the line to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetAlignMinValue()
	{
		return vtkLineWidget_GetAlignMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineWidget_GetClampToBounds_06(HandleRef pThis);

	/// <summary>
	/// Enable/disable clamping of the point end points to the bounding box
	/// of the data. The bounding box is defined from the last PlaceWidget()
	/// invocation, and includes the effect of the PlaceFactor which is used
	/// to gram/shrink the bounding box.
	/// </summary>
	public virtual int GetClampToBounds()
	{
		return vtkLineWidget_GetClampToBounds_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineWidget_GetHandleProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles when selected and normal can be
	/// manipulated.
	/// </summary>
	public virtual vtkProperty GetHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineWidget_GetHandleProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLineWidget_GetLineProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineWidget_GetLineProperty_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkLineWidget_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLineWidget_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLineWidget_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLineWidget_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineWidget_GetPoint1_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of first end point.
	/// </summary>
	public double[] GetPoint1()
	{
		IntPtr intPtr = vtkLineWidget_GetPoint1_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_GetPoint1_12(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of first end point.
	/// </summary>
	public void GetPoint1(IntPtr xyz)
	{
		vtkLineWidget_GetPoint1_12(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineWidget_GetPoint2_13(HandleRef pThis);

	/// <summary>
	/// Set position of other end point.
	/// </summary>
	public double[] GetPoint2()
	{
		IntPtr intPtr = vtkLineWidget_GetPoint2_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_GetPoint2_14(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set position of other end point.
	/// </summary>
	public void GetPoint2(IntPtr xyz)
	{
		vtkLineWidget_GetPoint2_14(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_GetPolyData_15(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that defines the line.  The
	/// polydata consists of n+1 points, where n is the resolution of the
	/// line. These point values are guaranteed to be up-to-date when either the
	/// InteractionEvent or EndInteraction events are invoked. The user provides
	/// the vtkPolyData and the points and polyline are added to it.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkLineWidget_GetPolyData_15(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineWidget_GetResolution_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution (number of subdivisions) of the line.
	/// </summary>
	public int GetResolution()
	{
		return vtkLineWidget_GetResolution_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineWidget_GetSelectedHandleProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles when selected and normal can be
	/// manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineWidget_GetSelectedHandleProperty_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLineWidget_GetSelectedLineProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineWidget_GetSelectedLineProperty_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkLineWidget_IsA_19(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLineWidget_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineWidget_IsTypeOf_20(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLineWidget_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineWidget_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new vtkLineWidget NewInstance()
	{
		vtkLineWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineWidget_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_PlaceWidget_23(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkLineWidget_PlaceWidget_23(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_PlaceWidget_24(HandleRef pThis);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget()
	{
		vtkLineWidget_PlaceWidget_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_PlaceWidget_25(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkLineWidget_PlaceWidget_25(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineWidget_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkLineWidget SafeDownCast(vtkObjectBase o)
	{
		vtkLineWidget vtkLineWidget3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineWidget_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLineWidget3 = (vtkLineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLineWidget3.Register(null);
			}
		}
		return vtkLineWidget3;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetAlign_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Force the line widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the line to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void SetAlign(int _arg)
	{
		vtkLineWidget_SetAlign_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetAlignToNone_28(HandleRef pThis);

	/// <summary>
	/// Force the line widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the line to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetAlignToNone()
	{
		vtkLineWidget_SetAlignToNone_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetAlignToXAxis_29(HandleRef pThis);

	/// <summary>
	/// Force the line widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the line to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetAlignToXAxis()
	{
		vtkLineWidget_SetAlignToXAxis_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetAlignToYAxis_30(HandleRef pThis);

	/// <summary>
	/// Force the line widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the line to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetAlignToYAxis()
	{
		vtkLineWidget_SetAlignToYAxis_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetAlignToZAxis_31(HandleRef pThis);

	/// <summary>
	/// Force the line widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the line to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetAlignToZAxis()
	{
		vtkLineWidget_SetAlignToZAxis_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetClampToBounds_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable clamping of the point end points to the bounding box
	/// of the data. The bounding box is defined from the last PlaceWidget()
	/// invocation, and includes the effect of the PlaceFactor which is used
	/// to gram/shrink the bounding box.
	/// </summary>
	public virtual void SetClampToBounds(int _arg)
	{
		vtkLineWidget_SetClampToBounds_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetEnabled_33(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkLineWidget_SetEnabled_33(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetPoint1_34(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of first end point.
	/// </summary>
	public void SetPoint1(double x, double y, double z)
	{
		vtkLineWidget_SetPoint1_34(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetPoint1_35(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the position of first end point.
	/// </summary>
	public void SetPoint1(IntPtr x)
	{
		vtkLineWidget_SetPoint1_35(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetPoint2_36(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set position of other end point.
	/// </summary>
	public void SetPoint2(double x, double y, double z)
	{
		vtkLineWidget_SetPoint2_36(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetPoint2_37(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set position of other end point.
	/// </summary>
	public void SetPoint2(IntPtr x)
	{
		vtkLineWidget_SetPoint2_37(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget_SetResolution_38(HandleRef pThis, int r);

	/// <summary>
	/// Set/Get the resolution (number of subdivisions) of the line.
	/// </summary>
	public void SetResolution(int r)
	{
		vtkLineWidget_SetResolution_38(GetCppThis(), r);
	}
}
