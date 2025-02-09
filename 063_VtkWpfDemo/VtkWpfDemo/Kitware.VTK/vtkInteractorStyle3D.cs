using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyle3D
/// </summary>
/// <remarks>
///    extends interaction to support 3D input
///
/// vtkInteractorStyle3D allows the user to interact with (rotate,
/// pan, etc.) objects in the scene independent of each other. It is
/// designed to use 3d positions and orientations instead of 2D.
///
/// The following interactions are specified by default.
///
/// A click and hold in 3D within the bounding box of a prop
/// will pick up that prop allowing you to translate and
/// orient that prop as desired with the 3D controller.
///
/// Click/dragging two controllers and pulling them apart or
/// pushing them together will initial a scale gesture
/// that will scale the world larger or smaller.
///
/// Click/dragging two controllers and translating them in the same
/// direction will translate the camera/world
/// pushing them together will initial a scale gesture
/// that will scale the world larger or smaller.
///
/// If a controller is right clicked (push touchpad on Vive)
/// then it starts a fly motion where the camer moves in the
/// direction the controller is pointing. It moves at a speed
/// scaled by the position of your thumb on the trackpad.
/// Higher moves faster forward. Lower moves faster backwards.
///
/// For the Vive left click is mapped to the trigger and right
/// click is mapped to pushing the trackpad down.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderWindowInteractor3D
/// </seealso>
public class vtkInteractorStyle3D : vtkInteractorStyle
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyle3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyle3D()
	{
		MRClassNameKey = "class vtkInteractorStyle3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyle3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyle3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyle3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyle3D New()
	{
		vtkInteractorStyle3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyle3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyle3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyle3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyle3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle3D_Dolly3D_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void Dolly3D(vtkEventData arg0)
	{
		vtkInteractorStyle3D_Dolly3D_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInteractorStyle3D_GetDollyPhysicalSpeed_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum dolly speed used when flying in 3D, in meters per second.
	/// Default is 1.6666, corresponding to walking speed (= 6 km/h).
	/// This speed is scaled by the touchpad position as well.
	/// </summary>
	public virtual double GetDollyPhysicalSpeed()
	{
		return vtkInteractorStyle3D_GetDollyPhysicalSpeed_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyle3D_GetInteractionPicker_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the interaction picker.
	/// By default, a vtkPropPicker is instancied.
	/// </summary>
	public virtual vtkAbstractPropPicker GetInteractionPicker()
	{
		vtkAbstractPropPicker vtkAbstractPropPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyle3D_GetInteractionPicker_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPropPicker2 = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPropPicker2.Register(null);
			}
		}
		return vtkAbstractPropPicker2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyle3D_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyle3D_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyle3D_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyle3D_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyle3D_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyle3D_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyle3D_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyle3D_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyle3D_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyle3D NewInstance()
	{
		vtkInteractorStyle3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyle3D_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyle3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle3D_PositionProp_10(HandleRef pThis, HandleRef arg0, IntPtr lwpos, IntPtr lwori);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void PositionProp(vtkEventData arg0, IntPtr lwpos, IntPtr lwori)
	{
		vtkInteractorStyle3D_PositionProp_10(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), lwpos, lwori);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyle3D_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyle3D SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyle3D vtkInteractorStyle3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyle3D_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyle3D2 = (vtkInteractorStyle3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyle3D2.Register(null);
			}
		}
		return vtkInteractorStyle3D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle3D_SetDollyPhysicalSpeed_12(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the maximum dolly speed used when flying in 3D, in meters per second.
	/// Default is 1.6666, corresponding to walking speed (= 6 km/h).
	/// This speed is scaled by the touchpad position as well.
	/// </summary>
	public virtual void SetDollyPhysicalSpeed(double _arg)
	{
		vtkInteractorStyle3D_SetDollyPhysicalSpeed_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle3D_SetInteractionPicker_13(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Get/Set the interaction picker.
	/// By default, a vtkPropPicker is instancied.
	/// </summary>
	public void SetInteractionPicker(vtkAbstractPropPicker prop)
	{
		vtkInteractorStyle3D_SetInteractionPicker_13(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle3D_SetScale_14(HandleRef pThis, HandleRef cam, double newScale);

	/// <summary>
	/// Set the scaling factor from world to physical space.
	/// In VR when we set it to a new value we also adjust the
	/// HMD position to maintain the same relative position.
	/// </summary>
	public virtual void SetScale(vtkCamera cam, double newScale)
	{
		vtkInteractorStyle3D_SetScale_14(GetCppThis(), cam?.GetCppThis() ?? default(HandleRef), newScale);
	}
}
