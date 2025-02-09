using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProp3DButtonRepresentation
/// </summary>
/// <remarks>
///    defines a representation for a vtkButtonWidget
///
/// This class implements one type of vtkButtonRepresentation. Each button
/// state can be represented with a separate instance of vtkProp3D. Thus
/// buttons can be represented with vtkActor, vtkImageActor, volumes (e.g.,
/// vtkVolume) and/or any other vtkProp3D. Also, the class invokes events when
/// highlighting occurs (i.e., hovering, selecting) so that appropriate action
/// can be taken to highlight the button (if desired).
///
/// To use this representation, always begin by specifying the number of
/// button states.  Then provide, for each state, an instance of vtkProp3D.
///
/// This widget representation uses the conventional placement method. The
/// button is placed inside the bounding box defined by PlaceWidget by translating
/// and scaling the vtkProp3D to fit (each vtkProp3D is transformed). Therefore,
/// you must define the number of button states and each state (i.e., vtkProp3D)
/// prior to calling vtkPlaceWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkButtonWidget vtkButtonRepresentation vtkButtonSource vtkEllipticalButtonSource
/// vtkRectangularButtonSource
/// </seealso>
public class vtkProp3DButtonRepresentation : vtkButtonRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProp3DButtonRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProp3DButtonRepresentation()
	{
		MRClassNameKey = "class vtkProp3DButtonRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp3DButtonRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProp3DButtonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DButtonRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkProp3DButtonRepresentation New()
	{
		vtkProp3DButtonRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DButtonRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProp3DButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkProp3DButtonRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProp3DButtonRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkProp3DButtonRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkProp3DButtonRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DButtonRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkProp3DButtonRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DButtonRepresentation_FollowCameraOff_03(HandleRef pThis);

	/// <summary>
	/// Specify whether the button should always face the camera. If enabled,
	/// the button reorients itself towards the camera as the camera moves.
	/// </summary>
	public virtual void FollowCameraOff()
	{
		vtkProp3DButtonRepresentation_FollowCameraOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DButtonRepresentation_FollowCameraOn_04(HandleRef pThis);

	/// <summary>
	/// Specify whether the button should always face the camera. If enabled,
	/// the button reorients itself towards the camera as the camera moves.
	/// </summary>
	public virtual void FollowCameraOn()
	{
		vtkProp3DButtonRepresentation_FollowCameraOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DButtonRepresentation_GetActors_05(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override void GetActors(vtkPropCollection pc)
	{
		vtkProp3DButtonRepresentation_GetActors_05(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DButtonRepresentation_GetBounds_06(HandleRef pThis);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkProp3DButtonRepresentation_GetBounds_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DButtonRepresentation_GetButtonProp_07(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Add the ith texture corresponding to the ith button state.
	/// The parameter i should be (0 &lt;= i &lt; NumberOfStates).
	/// </summary>
	public vtkProp3D GetButtonProp(int i)
	{
		vtkProp3D vtkProp3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DButtonRepresentation_GetButtonProp_07(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkProp3DButtonRepresentation_GetFollowCamera_08(HandleRef pThis);

	/// <summary>
	/// Specify whether the button should always face the camera. If enabled,
	/// the button reorients itself towards the camera as the camera moves.
	/// </summary>
	public virtual int GetFollowCamera()
	{
		return vtkProp3DButtonRepresentation_GetFollowCamera_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProp3DButtonRepresentation_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProp3DButtonRepresentation_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProp3DButtonRepresentation_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProp3DButtonRepresentation_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DButtonRepresentation_HasTranslucentPolygonalGeometry_11(HandleRef pThis);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkProp3DButtonRepresentation_HasTranslucentPolygonalGeometry_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DButtonRepresentation_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProp3DButtonRepresentation_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DButtonRepresentation_IsTypeOf_13(string type);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProp3DButtonRepresentation_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DButtonRepresentation_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public new vtkProp3DButtonRepresentation NewInstance()
	{
		vtkProp3DButtonRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DButtonRepresentation_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProp3DButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DButtonRepresentation_PlaceWidget_16(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// This method positions (translates and scales the props) into the
	/// bounding box specified. Note all the button props are scaled.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkProp3DButtonRepresentation_PlaceWidget_16(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DButtonRepresentation_RegisterPickers_17(HandleRef pThis);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override void RegisterPickers()
	{
		vtkProp3DButtonRepresentation_RegisterPickers_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DButtonRepresentation_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkProp3DButtonRepresentation_ReleaseGraphicsResources_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DButtonRepresentation_RenderOpaqueGeometry_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkProp3DButtonRepresentation_RenderOpaqueGeometry_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DButtonRepresentation_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkProp3DButtonRepresentation_RenderTranslucentPolygonalGeometry_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DButtonRepresentation_RenderVolumetricGeometry_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override int RenderVolumetricGeometry(vtkViewport arg0)
	{
		return vtkProp3DButtonRepresentation_RenderVolumetricGeometry_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DButtonRepresentation_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of the class.
	/// </summary>
	public new static vtkProp3DButtonRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkProp3DButtonRepresentation vtkProp3DButtonRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DButtonRepresentation_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3DButtonRepresentation2 = (vtkProp3DButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3DButtonRepresentation2.Register(null);
			}
		}
		return vtkProp3DButtonRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DButtonRepresentation_SetButtonProp_23(HandleRef pThis, int i, HandleRef prop);

	/// <summary>
	/// Add the ith texture corresponding to the ith button state.
	/// The parameter i should be (0 &lt;= i &lt; NumberOfStates).
	/// </summary>
	public void SetButtonProp(int i, vtkProp3D prop)
	{
		vtkProp3DButtonRepresentation_SetButtonProp_23(GetCppThis(), i, prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DButtonRepresentation_SetFollowCamera_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether the button should always face the camera. If enabled,
	/// the button reorients itself towards the camera as the camera moves.
	/// </summary>
	public virtual void SetFollowCamera(int _arg)
	{
		vtkProp3DButtonRepresentation_SetFollowCamera_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DButtonRepresentation_SetState_25(HandleRef pThis, int state);

	/// <summary>
	/// Extend the vtkButtonRepresentation::SetState() method.
	/// </summary>
	public override void SetState(int state)
	{
		vtkProp3DButtonRepresentation_SetState_25(GetCppThis(), state);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DButtonRepresentation_ShallowCopy_26(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Provide the necessary methods to satisfy the rendering API.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkProp3DButtonRepresentation_ShallowCopy_26(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
