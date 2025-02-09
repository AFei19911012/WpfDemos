using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtk3DWidget
/// </summary>
/// <remarks>
///    an abstract superclass for 3D widgets
///
/// vtk3DWidget is an abstract superclass for 3D interactor observers. These
/// 3D widgets represent themselves in the scene, and have special callbacks
/// associated with them that allows interactive manipulation of the widget.
/// Inparticular, the difference between a vtk3DWidget and its abstract
/// superclass vtkInteractorObserver is that vtk3DWidgets are "placed" in 3D
/// space.  vtkInteractorObservers have no notion of where they are placed,
/// and may not exist in 3D space at all.  3D widgets also provide auxiliary
/// functions like producing a transformation, creating polydata (for seeding
/// streamlines, probes, etc.) or creating implicit functions. See the
/// concrete subclasses for particulars.
///
/// Typically the widget is used by specifying a vtkProp3D or VTK dataset as
/// input, and then invoking the "On" method to activate it. (You can also
/// specify a bounding box to help position the widget.) Prior to invoking the
/// On() method, the user may also wish to use the PlaceWidget() to initially
/// position it. The 'i' (for "interactor") keypresses also can be used to
/// turn the widgets on and off (methods exist to change the key value
/// and enable keypress activiation).
///
/// To support interactive manipulation of objects, this class (and
/// subclasses) invoke the events StartInteractionEvent, InteractionEvent, and
/// EndInteractionEvent.  These events are invoked when the vtk3DWidget enters
/// a state where rapid response is desired: mouse motion, etc. The events can
/// be used, for example, to set the desired update frame rate
/// (StartInteractionEvent), operate on the vtkProp3D or other object
/// (InteractionEvent), and set the desired frame rate back to normal values
/// (EndInteractionEvent).
///
/// Note that the Priority attribute inherited from vtkInteractorObserver has
/// a new default value which is now 0.5 so that all 3D widgets have a higher
/// priority than the usual interactor styles.
///
/// </remarks>
/// <seealso>
///
/// vtkBoxWidget vtkPlaneWidget vtkLineWidget vtkPointWidget
/// vtkSphereWidget vtkImplicitPlaneWidget
/// </seealso>
public abstract class vtk3DWidget : vtkInteractorObserver
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtk3DWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtk3DWidget()
	{
		MRClassNameKey = "class vtk3DWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtk3DWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern double vtk3DWidget_GetHandleSize_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the size of the handles that
	/// appear as part of the widget. These handles (like spheres, etc.)
	/// are used to manipulate the widget, and are sized as a fraction of
	/// the screen diagonal.
	/// </summary>
	public virtual double GetHandleSize()
	{
		return vtk3DWidget_GetHandleSize_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtk3DWidget_GetHandleSizeMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the size of the handles that
	/// appear as part of the widget. These handles (like spheres, etc.)
	/// are used to manipulate the widget, and are sized as a fraction of
	/// the screen diagonal.
	/// </summary>
	public virtual double GetHandleSizeMaxValue()
	{
		return vtk3DWidget_GetHandleSizeMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtk3DWidget_GetHandleSizeMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the size of the handles that
	/// appear as part of the widget. These handles (like spheres, etc.)
	/// are used to manipulate the widget, and are sized as a fraction of
	/// the screen diagonal.
	/// </summary>
	public virtual double GetHandleSizeMinValue()
	{
		return vtk3DWidget_GetHandleSizeMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DWidget_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the input dataset. This is not required, but if supplied,
	/// and no vtkProp3D is specified, it is used to initially position
	/// the widget.
	/// </summary>
	public virtual vtkDataSet GetInput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DWidget_GetInput_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtk3DWidget_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtk3DWidget_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtk3DWidget_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtk3DWidget_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtk3DWidget_GetPlaceFactor_07(HandleRef pThis);

	/// <summary>
	/// Set/Get a factor representing the scaling of the widget upon placement
	/// (via the PlaceWidget() method). Normally the widget is placed so that
	/// it just fits within the bounding box defined in PlaceWidget(bounds).
	/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
	/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
	/// </summary>
	public virtual double GetPlaceFactor()
	{
		return vtk3DWidget_GetPlaceFactor_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtk3DWidget_GetPlaceFactorMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get a factor representing the scaling of the widget upon placement
	/// (via the PlaceWidget() method). Normally the widget is placed so that
	/// it just fits within the bounding box defined in PlaceWidget(bounds).
	/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
	/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
	/// </summary>
	public virtual double GetPlaceFactorMaxValue()
	{
		return vtk3DWidget_GetPlaceFactorMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtk3DWidget_GetPlaceFactorMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get a factor representing the scaling of the widget upon placement
	/// (via the PlaceWidget() method). Normally the widget is placed so that
	/// it just fits within the bounding box defined in PlaceWidget(bounds).
	/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
	/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
	/// </summary>
	public virtual double GetPlaceFactorMinValue()
	{
		return vtk3DWidget_GetPlaceFactorMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DWidget_GetProp3D_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a vtkProp3D around which to place the widget. This
	/// is not required, but if supplied, it is used to initially
	/// position the widget.
	/// </summary>
	public virtual vtkProp3D GetProp3D()
	{
		vtkProp3D vtkProp3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DWidget_GetProp3D_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3D2 = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3D2.Register(null);
			}
		}
		return vtkProp3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtk3DWidget_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtk3DWidget_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtk3DWidget_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtk3DWidget_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DWidget_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtk3DWidget NewInstance()
	{
		vtk3DWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DWidget_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtk3DWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DWidget_PlaceWidget_14(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// This method is used to initially place the widget.  The placement of the
	/// widget depends on whether a Prop3D or input dataset is provided. If one
	/// of these two is provided, they will be used to obtain a bounding box,
	/// around which the widget is placed. Otherwise, you can manually specify a
	/// bounds with the PlaceWidget(bounds) method. Note: PlaceWidget(bounds)
	/// is required by all subclasses; the other methods are provided as
	/// convenience methods.
	/// </summary>
	public virtual void PlaceWidget(IntPtr bounds)
	{
		vtk3DWidget_PlaceWidget_14(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DWidget_PlaceWidget_15(HandleRef pThis);

	/// <summary>
	/// This method is used to initially place the widget.  The placement of the
	/// widget depends on whether a Prop3D or input dataset is provided. If one
	/// of these two is provided, they will be used to obtain a bounding box,
	/// around which the widget is placed. Otherwise, you can manually specify a
	/// bounds with the PlaceWidget(bounds) method. Note: PlaceWidget(bounds)
	/// is required by all subclasses; the other methods are provided as
	/// convenience methods.
	/// </summary>
	public virtual void PlaceWidget()
	{
		vtk3DWidget_PlaceWidget_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DWidget_PlaceWidget_16(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// This method is used to initially place the widget.  The placement of the
	/// widget depends on whether a Prop3D or input dataset is provided. If one
	/// of these two is provided, they will be used to obtain a bounding box,
	/// around which the widget is placed. Otherwise, you can manually specify a
	/// bounds with the PlaceWidget(bounds) method. Note: PlaceWidget(bounds)
	/// is required by all subclasses; the other methods are provided as
	/// convenience methods.
	/// </summary>
	public virtual void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtk3DWidget_PlaceWidget_16(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DWidget_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtk3DWidget SafeDownCast(vtkObjectBase o)
	{
		vtk3DWidget vtk3DWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DWidget_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtk3DWidget2 = (vtk3DWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtk3DWidget2.Register(null);
			}
		}
		return vtk3DWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DWidget_SetHandleSize_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the factor that controls the size of the handles that
	/// appear as part of the widget. These handles (like spheres, etc.)
	/// are used to manipulate the widget, and are sized as a fraction of
	/// the screen diagonal.
	/// </summary>
	public virtual void SetHandleSize(double _arg)
	{
		vtk3DWidget_SetHandleSize_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DWidget_SetInputConnection_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the input dataset. This is not required, but if supplied,
	/// and no vtkProp3D is specified, it is used to initially position
	/// the widget.
	/// </summary>
	public virtual void SetInputConnection(vtkAlgorithmOutput arg0)
	{
		vtk3DWidget_SetInputConnection_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DWidget_SetInputData_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the input dataset. This is not required, but if supplied,
	/// and no vtkProp3D is specified, it is used to initially position
	/// the widget.
	/// </summary>
	public virtual void SetInputData(vtkDataSet arg0)
	{
		vtk3DWidget_SetInputData_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DWidget_SetPlaceFactor_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get a factor representing the scaling of the widget upon placement
	/// (via the PlaceWidget() method). Normally the widget is placed so that
	/// it just fits within the bounding box defined in PlaceWidget(bounds).
	/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
	/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
	/// </summary>
	public virtual void SetPlaceFactor(double _arg)
	{
		vtk3DWidget_SetPlaceFactor_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DWidget_SetProp3D_22(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify a vtkProp3D around which to place the widget. This
	/// is not required, but if supplied, it is used to initially
	/// position the widget.
	/// </summary>
	public virtual void SetProp3D(vtkProp3D arg0)
	{
		vtk3DWidget_SetProp3D_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
