using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitPlaneWidget
/// </summary>
/// <remarks>
///    3D widget for manipulating an infinite plane
///
/// This 3D widget defines an infinite plane that can be interactively placed
/// in a scene. The widget is represented by a plane with a normal vector; the
/// plane is contained by a bounding box, and where the plane intersects the
/// bounding box the edges are shown (possibly tubed). The normal can be
/// selected and moved to rotate the plane; the plane itself can be selected
/// and translated in various directions. As the plane is moved, the implicit
/// plane function and polygon (representing the plane cut against the bounding
/// box) is updated.
///
/// To use this object, just invoke SetInteractor() with the argument of the
/// method a vtkRenderWindowInteractor.  You may also wish to invoke
/// "PlaceWidget()" to initially position the widget. If the "i" key (for
/// "interactor") is pressed, the vtkImplicitPlaneWidget will appear. (See
/// superclass documentation for information about changing this behavior.)
/// If you select the normal vector, the plane can be arbitrarily rotated. The
/// plane can be translated along the normal by selecting the plane and moving
/// it. The plane (the plane origin) can also be arbitrary moved by selecting
/// the plane with the middle mouse button. The right mouse button can be used
/// to uniformly scale the bounding box (moving "up" the box scales larger;
/// moving "down" the box scales smaller). Events that occur outside of the
/// widget (i.e., no part of the widget is picked) are propagated to any other
/// registered obsevers (such as the interaction style).  Turn off the widget
/// by pressing the "i" key again (or invoke the Off() method).
///
/// The vtkImplicitPlaneWidget has several methods that can be used in
/// conjunction with other VTK objects.  The GetPolyData() method can be used
/// to get a polygonal representation (the single polygon clipped by the
/// bounding box).  Typical usage of the widget is to make use of the
/// StartInteractionEvent, InteractionEvent, and EndInteractionEvent
/// events. The InteractionEvent is called on mouse motion; the other two
/// events are called on button down and button up (either left or right
/// button). (Note: there is also a PlaceWidgetEvent that is invoked when
/// the widget is placed with PlaceWidget().)
///
/// Some additional features of this class include the ability to control the
/// properties of the widget. You do this by setting property values on the
/// normal vector (selected and unselected properties); the plane (selected
/// and unselected properties); the outline (selected and unselected
/// properties); and the edges. The edges may also be tubed or not.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkBoxWidget vtkPlaneWidget vtkLineWidget vtkPointWidget
/// vtkSphereWidget vtkImagePlaneWidget
/// </seealso>
public class vtkImplicitPlaneWidget : vtkPolyDataSourceWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitPlaneWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitPlaneWidget()
	{
		MRClassNameKey = "class vtkImplicitPlaneWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitPlaneWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitPlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkImplicitPlaneWidget New()
	{
		vtkImplicitPlaneWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkImplicitPlaneWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitPlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImplicitPlaneWidget_DrawPlaneOff_01(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual void DrawPlaneOff()
	{
		vtkImplicitPlaneWidget_DrawPlaneOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_DrawPlaneOn_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual void DrawPlaneOn()
	{
		vtkImplicitPlaneWidget_DrawPlaneOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitPlaneWidget_GetDiagonalRatio_03(HandleRef pThis);

	/// <summary>
	/// By default the arrow is 30% of the diagonal length. DiagonalRatio control
	/// this ratio in the interval [0-2]
	/// </summary>
	public virtual double GetDiagonalRatio()
	{
		return vtkImplicitPlaneWidget_GetDiagonalRatio_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitPlaneWidget_GetDiagonalRatioMaxValue_04(HandleRef pThis);

	/// <summary>
	/// By default the arrow is 30% of the diagonal length. DiagonalRatio control
	/// this ratio in the interval [0-2]
	/// </summary>
	public virtual double GetDiagonalRatioMaxValue()
	{
		return vtkImplicitPlaneWidget_GetDiagonalRatioMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitPlaneWidget_GetDiagonalRatioMinValue_05(HandleRef pThis);

	/// <summary>
	/// By default the arrow is 30% of the diagonal length. DiagonalRatio control
	/// this ratio in the interval [0-2]
	/// </summary>
	public virtual double GetDiagonalRatioMinValue()
	{
		return vtkImplicitPlaneWidget_GetDiagonalRatioMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneWidget_GetDrawPlane_06(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual int GetDrawPlane()
	{
		return vtkImplicitPlaneWidget_GetDrawPlane_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget_GetEdgesProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the intersection edges. (This property also
	/// applies to the edges when tubed.)
	/// </summary>
	public virtual vtkProperty GetEdgesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget_GetEdgesProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImplicitPlaneWidget_GetNormal_08(HandleRef pThis);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public double[] GetNormal()
	{
		IntPtr intPtr = vtkImplicitPlaneWidget_GetNormal_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_GetNormal_09(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public void GetNormal(IntPtr xyz)
	{
		vtkImplicitPlaneWidget_GetNormal_09(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget_GetNormalProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public virtual vtkProperty GetNormalProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget_GetNormalProperty_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImplicitPlaneWidget_GetNormalToXAxis_11(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToXAxis()
	{
		return vtkImplicitPlaneWidget_GetNormalToXAxis_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneWidget_GetNormalToYAxis_12(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToYAxis()
	{
		return vtkImplicitPlaneWidget_GetNormalToYAxis_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneWidget_GetNormalToZAxis_13(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToZAxis()
	{
		return vtkImplicitPlaneWidget_GetNormalToZAxis_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitPlaneWidget_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitPlaneWidget_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitPlaneWidget_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitPlaneWidget_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget_GetOrigin_16(HandleRef pThis);

	/// <summary>
	/// Get the origin of the plane.
	/// </summary>
	public double[] GetOrigin()
	{
		IntPtr intPtr = vtkImplicitPlaneWidget_GetOrigin_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_GetOrigin_17(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Get the origin of the plane.
	/// </summary>
	public void GetOrigin(IntPtr xyz)
	{
		vtkImplicitPlaneWidget_GetOrigin_17(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneWidget_GetOriginTranslation_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the origin (sphere)
	/// with the left mouse button.
	/// </summary>
	public virtual int GetOriginTranslation()
	{
		return vtkImplicitPlaneWidget_GetOriginTranslation_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget_GetOutlineProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the outline.
	/// </summary>
	public virtual vtkProperty GetOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget_GetOutlineProperty_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImplicitPlaneWidget_GetOutlineTranslation_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button.
	/// </summary>
	public virtual int GetOutlineTranslation()
	{
		return vtkImplicitPlaneWidget_GetOutlineTranslation_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneWidget_GetOutsideBounds_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the input's bound
	/// </summary>
	public virtual int GetOutsideBounds()
	{
		return vtkImplicitPlaneWidget_GetOutsideBounds_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_GetPlane_22(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Get the implicit function for the plane. The user must provide the
	/// instance of the class vtkPlane. Note that vtkPlane is a subclass of
	/// vtkImplicitFunction, meaning that it can be used by a variety of filters
	/// to perform clipping, cutting, and selection of data.
	/// </summary>
	public void GetPlane(vtkPlane plane)
	{
		vtkImplicitPlaneWidget_GetPlane_22(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget_GetPlaneProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plane properties. The properties of the plane when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetPlaneProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget_GetPlaneProperty_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImplicitPlaneWidget_GetPolyData_24(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata that defines the plane. The polydata contains a single
	/// polygon that is clipped by the bounding box.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkImplicitPlaneWidget_GetPolyData_24(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget_GetPolyDataAlgorithm_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Satisfies superclass API.  This returns a pointer to the underlying
	/// PolyData (which represents the plane).
	/// </summary>
	public override vtkPolyDataAlgorithm GetPolyDataAlgorithm()
	{
		vtkPolyDataAlgorithm vtkPolyDataAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget_GetPolyDataAlgorithm_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataAlgorithm2 = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataAlgorithm2.Register(null);
			}
		}
		return vtkPolyDataAlgorithm2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneWidget_GetScaleEnabled_26(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale with the mouse
	/// </summary>
	public virtual int GetScaleEnabled()
	{
		return vtkImplicitPlaneWidget_GetScaleEnabled_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget_GetSelectedNormalProperty_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public virtual vtkProperty GetSelectedNormalProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget_GetSelectedNormalProperty_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImplicitPlaneWidget_GetSelectedOutlineProperty_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the outline.
	/// </summary>
	public virtual vtkProperty GetSelectedOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget_GetSelectedOutlineProperty_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImplicitPlaneWidget_GetSelectedPlaneProperty_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plane properties. The properties of the plane when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedPlaneProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget_GetSelectedPlaneProperty_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImplicitPlaneWidget_GetTubing_30(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual int GetTubing()
	{
		return vtkImplicitPlaneWidget_GetTubing_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneWidget_IsA_31(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitPlaneWidget_IsA_31(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneWidget_IsTypeOf_32(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitPlaneWidget_IsTypeOf_32(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new vtkImplicitPlaneWidget NewInstance()
	{
		vtkImplicitPlaneWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget_NewInstance_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_NormalToXAxisOff_35(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToXAxisOff()
	{
		vtkImplicitPlaneWidget_NormalToXAxisOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_NormalToXAxisOn_36(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToXAxisOn()
	{
		vtkImplicitPlaneWidget_NormalToXAxisOn_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_NormalToYAxisOff_37(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToYAxisOff()
	{
		vtkImplicitPlaneWidget_NormalToYAxisOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_NormalToYAxisOn_38(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToYAxisOn()
	{
		vtkImplicitPlaneWidget_NormalToYAxisOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_NormalToZAxisOff_39(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToZAxisOff()
	{
		vtkImplicitPlaneWidget_NormalToZAxisOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_NormalToZAxisOn_40(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToZAxisOn()
	{
		vtkImplicitPlaneWidget_NormalToZAxisOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_OriginTranslationOff_41(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the origin (sphere)
	/// with the left mouse button.
	/// </summary>
	public virtual void OriginTranslationOff()
	{
		vtkImplicitPlaneWidget_OriginTranslationOff_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_OriginTranslationOn_42(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the origin (sphere)
	/// with the left mouse button.
	/// </summary>
	public virtual void OriginTranslationOn()
	{
		vtkImplicitPlaneWidget_OriginTranslationOn_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_OutlineTranslationOff_43(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button.
	/// </summary>
	public virtual void OutlineTranslationOff()
	{
		vtkImplicitPlaneWidget_OutlineTranslationOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_OutlineTranslationOn_44(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button.
	/// </summary>
	public virtual void OutlineTranslationOn()
	{
		vtkImplicitPlaneWidget_OutlineTranslationOn_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_OutsideBoundsOff_45(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the input's bound
	/// </summary>
	public virtual void OutsideBoundsOff()
	{
		vtkImplicitPlaneWidget_OutsideBoundsOff_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_OutsideBoundsOn_46(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the input's bound
	/// </summary>
	public virtual void OutsideBoundsOn()
	{
		vtkImplicitPlaneWidget_OutsideBoundsOn_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_PlaceWidget_47(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkImplicitPlaneWidget_PlaceWidget_47(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_PlaceWidget_48(HandleRef pThis);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget()
	{
		vtkImplicitPlaneWidget_PlaceWidget_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_PlaceWidget_49(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkImplicitPlaneWidget_PlaceWidget_49(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkImplicitPlaneWidget SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitPlaneWidget vtkImplicitPlaneWidget3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget_SafeDownCast_50(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitPlaneWidget3 = (vtkImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitPlaneWidget3.Register(null);
			}
		}
		return vtkImplicitPlaneWidget3;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_ScaleEnabledOff_51(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale with the mouse
	/// </summary>
	public virtual void ScaleEnabledOff()
	{
		vtkImplicitPlaneWidget_ScaleEnabledOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_ScaleEnabledOn_52(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale with the mouse
	/// </summary>
	public virtual void ScaleEnabledOn()
	{
		vtkImplicitPlaneWidget_ScaleEnabledOn_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetDiagonalRatio_53(HandleRef pThis, double _arg);

	/// <summary>
	/// By default the arrow is 30% of the diagonal length. DiagonalRatio control
	/// this ratio in the interval [0-2]
	/// </summary>
	public virtual void SetDiagonalRatio(double _arg)
	{
		vtkImplicitPlaneWidget_SetDiagonalRatio_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetDrawPlane_54(HandleRef pThis, int plane);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public void SetDrawPlane(int plane)
	{
		vtkImplicitPlaneWidget_SetDrawPlane_54(GetCppThis(), plane);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetEnabled_55(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkImplicitPlaneWidget_SetEnabled_55(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetNormal_56(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public void SetNormal(double x, double y, double z)
	{
		vtkImplicitPlaneWidget_SetNormal_56(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetNormal_57(HandleRef pThis, IntPtr n);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public void SetNormal(IntPtr n)
	{
		vtkImplicitPlaneWidget_SetNormal_57(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetNormalToXAxis_58(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetNormalToXAxis(int arg0)
	{
		vtkImplicitPlaneWidget_SetNormalToXAxis_58(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetNormalToYAxis_59(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetNormalToYAxis(int arg0)
	{
		vtkImplicitPlaneWidget_SetNormalToYAxis_59(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetNormalToZAxis_60(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetNormalToZAxis(int arg0)
	{
		vtkImplicitPlaneWidget_SetNormalToZAxis_60(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetOrigin_61(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Get the origin of the plane.
	/// </summary>
	public virtual void SetOrigin(double x, double y, double z)
	{
		vtkImplicitPlaneWidget_SetOrigin_61(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetOrigin_62(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Get the origin of the plane.
	/// </summary>
	public virtual void SetOrigin(IntPtr x)
	{
		vtkImplicitPlaneWidget_SetOrigin_62(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetOriginTranslation_63(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to translate the origin (sphere)
	/// with the left mouse button.
	/// </summary>
	public virtual void SetOriginTranslation(int _arg)
	{
		vtkImplicitPlaneWidget_SetOriginTranslation_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetOutlineTranslation_64(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button.
	/// </summary>
	public virtual void SetOutlineTranslation(int _arg)
	{
		vtkImplicitPlaneWidget_SetOutlineTranslation_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetOutsideBounds_65(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the input's bound
	/// </summary>
	public virtual void SetOutsideBounds(int _arg)
	{
		vtkImplicitPlaneWidget_SetOutsideBounds_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetScaleEnabled_66(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to scale with the mouse
	/// </summary>
	public virtual void SetScaleEnabled(int _arg)
	{
		vtkImplicitPlaneWidget_SetScaleEnabled_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SetTubing_67(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void SetTubing(int _arg)
	{
		vtkImplicitPlaneWidget_SetTubing_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_SizeHandles_68(HandleRef pThis);

	/// <summary>
	/// Control widget appearance
	/// </summary>
	public virtual void SizeHandles()
	{
		vtkImplicitPlaneWidget_SizeHandles_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_TubingOff_69(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void TubingOff()
	{
		vtkImplicitPlaneWidget_TubingOff_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_TubingOn_70(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void TubingOn()
	{
		vtkImplicitPlaneWidget_TubingOn_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget_UpdatePlacement_71(HandleRef pThis);

	/// <summary>
	/// Satisfies the superclass API.  This will change the state of the widget
	/// to match changes that have been made to the underlying PolyDataSource
	/// </summary>
	public override void UpdatePlacement()
	{
		vtkImplicitPlaneWidget_UpdatePlacement_71(GetCppThis());
	}
}
