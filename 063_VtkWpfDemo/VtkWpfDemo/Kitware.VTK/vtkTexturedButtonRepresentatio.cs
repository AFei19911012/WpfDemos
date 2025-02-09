using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTexturedButtonRepresentation
/// </summary>
/// <remarks>
///    defines a representation for a vtkButtonWidget
///
/// This class implements one type of vtkButtonRepresentation. It changes the
/// appearance of a user-provided polydata by assigning textures according to the
/// current button state. It also provides highlighting (when hovering and
/// selecting the button) by fiddling with the actor's property.
///
/// To use this representation, always begin by specifying the number of
/// button states.  Then provide a polydata (the polydata should have associated
/// texture coordinates), and a list of textures corresponding to the button
/// states. Optionally, the HoveringProperty and SelectionProperty can be
/// adjusted to obtain the appropriate appearance.
///
/// This widget representation has two placement methods. The conventional
/// PlaceWidget() method is used to locate the textured button inside of a
/// user-specified bounding box (note that the button geometry is uniformly
/// scaled to fit, thus two of the three dimensions can be "large" and the
/// third used to perform the scaling). However this PlaceWidget() method will
/// align the geometry within x-y-z oriented bounds. To further control the
/// placement, use the additional PlaceWidget(scale,point,normal) method. This
/// scales the geometry, places its center at the specified point position,
/// and orients the geometry's z-direction parallel to the specified normal.
/// This can be used to attach "sticky notes" or "sticky buttons" to the
/// surface of objects.
///
/// </remarks>
/// <seealso>
///
/// vtkButtonWidget vtkButtonRepresentation vtkButtonSource vtkEllipticalButtonSource
/// vtkRectangularButtonSource
/// </seealso>
public class vtkTexturedButtonRepresentation : vtkButtonRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTexturedButtonRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTexturedButtonRepresentation()
	{
		MRClassNameKey = "class vtkTexturedButtonRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexturedButtonRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTexturedButtonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkTexturedButtonRepresentation New()
	{
		vtkTexturedButtonRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTexturedButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkTexturedButtonRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTexturedButtonRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTexturedButtonRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkTexturedButtonRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedButtonRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkTexturedButtonRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_FollowCameraOff_03(HandleRef pThis);

	/// <summary>
	/// Specify whether the button should always face the camera. If enabled,
	/// the button rotates as the camera moves.
	/// </summary>
	public virtual void FollowCameraOff()
	{
		vtkTexturedButtonRepresentation_FollowCameraOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_FollowCameraOn_04(HandleRef pThis);

	/// <summary>
	/// Specify whether the button should always face the camera. If enabled,
	/// the button rotates as the camera moves.
	/// </summary>
	public virtual void FollowCameraOn()
	{
		vtkTexturedButtonRepresentation_FollowCameraOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_GetActors_05(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override void GetActors(vtkPropCollection pc)
	{
		vtkTexturedButtonRepresentation_GetActors_05(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation_GetBounds_06(HandleRef pThis);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkTexturedButtonRepresentation_GetBounds_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation_GetButtonGeometry_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the polydata which defines the button geometry.
	/// </summary>
	public vtkPolyData GetButtonGeometry()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation_GetButtonGeometry_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation_GetButtonTexture_08(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Add the ith texture corresponding to the ith button state.
	/// The parameter i should be (0 &lt;= i &lt; NumberOfStates).
	/// </summary>
	public vtkImageData GetButtonTexture(int i)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation_GetButtonTexture_08(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedButtonRepresentation_GetFollowCamera_09(HandleRef pThis);

	/// <summary>
	/// Specify whether the button should always face the camera. If enabled,
	/// the button rotates as the camera moves.
	/// </summary>
	public virtual int GetFollowCamera()
	{
		return vtkTexturedButtonRepresentation_GetFollowCamera_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation_GetHoveringProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the property to use when the hovering over the button.
	/// </summary>
	public virtual vtkProperty GetHoveringProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation_GetHoveringProperty_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkTexturedButtonRepresentation_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTexturedButtonRepresentation_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTexturedButtonRepresentation_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTexturedButtonRepresentation_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation_GetProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the property to use when the button is to appear "normal"
	/// i.e., the mouse pointer is not hovering or selecting the button.
	/// </summary>
	public virtual vtkProperty GetProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation_GetProperty_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTexturedButtonRepresentation_GetSelectingProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the property to use when selecting the button.
	/// </summary>
	public virtual vtkProperty GetSelectingProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation_GetSelectingProperty_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTexturedButtonRepresentation_HasTranslucentPolygonalGeometry_15(HandleRef pThis);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkTexturedButtonRepresentation_HasTranslucentPolygonalGeometry_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_Highlight_16(HandleRef pThis, int state);

	/// <summary>
	/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override void Highlight(int state)
	{
		vtkTexturedButtonRepresentation_Highlight_16(GetCppThis(), state);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedButtonRepresentation_IsA_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTexturedButtonRepresentation_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedButtonRepresentation_IsTypeOf_18(string type);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTexturedButtonRepresentation_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public new vtkTexturedButtonRepresentation NewInstance()
	{
		vtkTexturedButtonRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTexturedButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_PlaceWidget_21(HandleRef pThis, double scale, IntPtr point, IntPtr normal);

	/// <summary>
	/// Alternative method for placing a button at a given position (defined by
	/// point[3]); at a given orientation (normal[3], where the z-axis of the
	/// button geometry is parallel to the normal); and scaled by the scale
	/// parameter. This method can bs used to attach "sticky notes" or "sticky
	/// buttons" to objects. A great way to attach interactive meta-data to 3D
	/// actors.
	/// </summary>
	public virtual void PlaceWidget(double scale, IntPtr point, IntPtr normal)
	{
		vtkTexturedButtonRepresentation_PlaceWidget_21(GetCppThis(), scale, point, normal);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_PlaceWidget_22(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkTexturedButtonRepresentation_PlaceWidget_22(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_RegisterPickers_23(HandleRef pThis);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override void RegisterPickers()
	{
		vtkTexturedButtonRepresentation_RegisterPickers_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkTexturedButtonRepresentation_ReleaseGraphicsResources_24(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedButtonRepresentation_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkTexturedButtonRepresentation_RenderOpaqueGeometry_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedButtonRepresentation_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkTexturedButtonRepresentation_RenderTranslucentPolygonalGeometry_26(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public new static vtkTexturedButtonRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkTexturedButtonRepresentation vtkTexturedButtonRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexturedButtonRepresentation2 = (vtkTexturedButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexturedButtonRepresentation2.Register(null);
			}
		}
		return vtkTexturedButtonRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_SetButtonGeometry_28(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Set/Get the polydata which defines the button geometry.
	/// </summary>
	public void SetButtonGeometry(vtkPolyData pd)
	{
		vtkTexturedButtonRepresentation_SetButtonGeometry_28(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_SetButtonGeometryConnection_29(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Set/Get the polydata which defines the button geometry.
	/// </summary>
	public void SetButtonGeometryConnection(vtkAlgorithmOutput algOutput)
	{
		vtkTexturedButtonRepresentation_SetButtonGeometryConnection_29(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_SetButtonTexture_30(HandleRef pThis, int i, HandleRef image);

	/// <summary>
	/// Add the ith texture corresponding to the ith button state.
	/// The parameter i should be (0 &lt;= i &lt; NumberOfStates).
	/// </summary>
	public void SetButtonTexture(int i, vtkImageData image)
	{
		vtkTexturedButtonRepresentation_SetButtonTexture_30(GetCppThis(), i, image?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_SetFollowCamera_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether the button should always face the camera. If enabled,
	/// the button rotates as the camera moves.
	/// </summary>
	public virtual void SetFollowCamera(int _arg)
	{
		vtkTexturedButtonRepresentation_SetFollowCamera_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_SetHoveringProperty_32(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Specify the property to use when the hovering over the button.
	/// </summary>
	public virtual void SetHoveringProperty(vtkProperty p)
	{
		vtkTexturedButtonRepresentation_SetHoveringProperty_32(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_SetProperty_33(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Specify the property to use when the button is to appear "normal"
	/// i.e., the mouse pointer is not hovering or selecting the button.
	/// </summary>
	public virtual void SetProperty(vtkProperty p)
	{
		vtkTexturedButtonRepresentation_SetProperty_33(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_SetSelectingProperty_34(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Specify the property to use when selecting the button.
	/// </summary>
	public virtual void SetSelectingProperty(vtkProperty p)
	{
		vtkTexturedButtonRepresentation_SetSelectingProperty_34(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation_ShallowCopy_35(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkTexturedButtonRepresentation_ShallowCopy_35(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
/// <summary>
///    vtkTexturedButtonRepresentation2D
/// </summary>
/// <remarks>
///    defines a representation for a vtkButtonWidget
///
/// This class implements one type of vtkButtonRepresentation. It changes the
/// appearance of a user-provided polydata by assigning textures according to
/// the current button state. It also provides highlighting (when hovering and
/// selecting the button) by fiddling with the actor's property. Since this is
/// a 2D version, the button is rendered in the overlay plane. Typically it is
/// positioned in display coordinates, but it can be anchored to a world
/// position so it will appear to move as the camera moves.
///
/// To use this representation, always begin by specifying the number of
/// button states.  Then provide a polydata (the polydata should have associated
/// texture coordinates), and a list of textures corresponding to the button
/// states. Optionally, the HoveringProperty and SelectionProperty can be
/// adjusted to obtain the appropriate appearance.
///
/// @warning
/// There are two variants of the PlaceWidget() method. The first PlaceWidget(bds[6])
/// allows the widget to be placed in the display coordinates fixed to the overlay
/// plane. The second PlaceWidget(anchor[3],size[2]) places the widget in world space;
/// hence it will appear to move as the camera moves around the scene.
///
/// </remarks>
/// <seealso>
///
/// vtkButtonWidget vtkButtonRepresentation vtkTexturedButtonRepresentation
/// vtkProp3DButtonRepresentation
/// </seealso>
public class vtkTexturedButtonRepresentation2D : vtkButtonRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTexturedButtonRepresentation2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTexturedButtonRepresentation2D()
	{
		MRClassNameKey = "class vtkTexturedButtonRepresentation2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexturedButtonRepresentation2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTexturedButtonRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkTexturedButtonRepresentation2D New()
	{
		vtkTexturedButtonRepresentation2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTexturedButtonRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkTexturedButtonRepresentation2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTexturedButtonRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTexturedButtonRepresentation2D_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkTexturedButtonRepresentation2D_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedButtonRepresentation2D_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkTexturedButtonRepresentation2D_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation2D_GetActors_03(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override void GetActors(vtkPropCollection pc)
	{
		vtkTexturedButtonRepresentation2D_GetActors_03(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetBalloon_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Grab the underlying vtkBalloonRepresentation used to position and display
	/// the button texture.
	/// </summary>
	public vtkBalloonRepresentation GetBalloon()
	{
		vtkBalloonRepresentation vtkBalloonRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation2D_GetBalloon_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBalloonRepresentation2 = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBalloonRepresentation2.Register(null);
			}
		}
		return vtkBalloonRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkTexturedButtonRepresentation2D_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetButtonTexture_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Add the ith texture corresponding to the ith button state.
	/// The parameter i should be 0&lt;=i&lt;NumberOfStates.
	/// </summary>
	public vtkImageData GetButtonTexture(int i)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation2D_GetButtonTexture_06(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetHoveringProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the property to use when the hovering over the button.
	/// </summary>
	public virtual vtkProperty2D GetHoveringProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation2D_GetHoveringProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTexturedButtonRepresentation2D_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTexturedButtonRepresentation2D_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTexturedButtonRepresentation2D_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTexturedButtonRepresentation2D_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the property to use when the button is to appear "normal"
	/// i.e., the mouse pointer is not hovering or selecting the button.
	/// </summary>
	public virtual vtkProperty2D GetProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation2D_GetProperty_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetSelectingProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the property to use when selecting the button.
	/// </summary>
	public virtual vtkProperty2D GetSelectingProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation2D_GetSelectingProperty_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedButtonRepresentation2D_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkTexturedButtonRepresentation2D_HasTranslucentPolygonalGeometry_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation2D_Highlight_13(HandleRef pThis, int state);

	/// <summary>
	/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override void Highlight(int state)
	{
		vtkTexturedButtonRepresentation2D_Highlight_13(GetCppThis(), state);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedButtonRepresentation2D_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTexturedButtonRepresentation2D_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedButtonRepresentation2D_IsTypeOf_15(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTexturedButtonRepresentation2D_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation2D_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkTexturedButtonRepresentation2D NewInstance()
	{
		vtkTexturedButtonRepresentation2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation2D_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTexturedButtonRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation2D_PlaceWidget_18(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Conventional PlaceWidget() method to satisfy the vtkWidgetRepresentation API.
	/// In this version, bounds[6] specifies a rectangle in *display* coordinates
	/// in which to place the button. The values for bounds[4] and bounds[5] can be
	/// set to zero. Note that PlaceWidget() is typically called at the end of configuring
	/// the button representation.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkTexturedButtonRepresentation2D_PlaceWidget_18(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation2D_PlaceWidget_19(HandleRef pThis, IntPtr anchor, IntPtr size);

	/// <summary>
	/// This alternative PlaceWidget() method can be used to anchor the button
	/// to a 3D point. In this case, the button representation will move around
	/// the screen as the camera moves around the world space. The first
	/// parameter anchor[3] is the world point anchor position (attached to the
	/// lower left portion of the button by default); and the size[2] parameter
	/// defines a x-y box in display coordinates in which the button will
	/// fit. Note that you can grab the vtkBalloonRepresentation and set an
	/// offset value if the anchor point is to be elsewhere on the button.
	/// </summary>
	public virtual void PlaceWidget(IntPtr anchor, IntPtr size)
	{
		vtkTexturedButtonRepresentation2D_PlaceWidget_19(GetCppThis(), anchor, size);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation2D_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkTexturedButtonRepresentation2D_ReleaseGraphicsResources_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexturedButtonRepresentation2D_RenderOverlay_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkTexturedButtonRepresentation2D_RenderOverlay_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexturedButtonRepresentation2D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkTexturedButtonRepresentation2D SafeDownCast(vtkObjectBase o)
	{
		vtkTexturedButtonRepresentation2D vtkTexturedButtonRepresentation2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexturedButtonRepresentation2D_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexturedButtonRepresentation2D2 = (vtkTexturedButtonRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexturedButtonRepresentation2D2.Register(null);
			}
		}
		return vtkTexturedButtonRepresentation2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation2D_SetButtonTexture_23(HandleRef pThis, int i, HandleRef image);

	/// <summary>
	/// Add the ith texture corresponding to the ith button state.
	/// The parameter i should be 0&lt;=i&lt;NumberOfStates.
	/// </summary>
	public void SetButtonTexture(int i, vtkImageData image)
	{
		vtkTexturedButtonRepresentation2D_SetButtonTexture_23(GetCppThis(), i, image?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation2D_SetHoveringProperty_24(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Specify the property to use when the hovering over the button.
	/// </summary>
	public virtual void SetHoveringProperty(vtkProperty2D p)
	{
		vtkTexturedButtonRepresentation2D_SetHoveringProperty_24(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation2D_SetProperty_25(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Specify the property to use when the button is to appear "normal"
	/// i.e., the mouse pointer is not hovering or selecting the button.
	/// </summary>
	public virtual void SetProperty(vtkProperty2D p)
	{
		vtkTexturedButtonRepresentation2D_SetProperty_25(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation2D_SetSelectingProperty_26(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Specify the property to use when selecting the button.
	/// </summary>
	public virtual void SetSelectingProperty(vtkProperty2D p)
	{
		vtkTexturedButtonRepresentation2D_SetSelectingProperty_26(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexturedButtonRepresentation2D_ShallowCopy_27(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkTexturedButtonRepresentation2D_ShallowCopy_27(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
