using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDistanceRepresentation2D
/// </summary>
/// <remarks>
///    represent the vtkDistanceWidget
///
/// The vtkDistanceRepresentation2D is a representation for the
/// vtkDistanceWidget. This representation consists of a measuring line (axis)
/// and two vtkHandleWidgets to place the end points of the line. Note that
/// this particular widget draws its representation in the overlay plane, and
/// the handles also operate in the 2D overlay plane. (If you desire to use
/// the distance widget for 3D measurements, use the
/// vtkDistanceRepresentation3D.)
///
/// </remarks>
/// <seealso>
///
/// vtkDistanceWidget vtkDistanceRepresentation vtkDistanceRepresentation3D
/// </seealso>
public class vtkDistanceRepresentation2D : vtkDistanceRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceRepresentation2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDistanceRepresentation2D()
	{
		MRClassNameKey = "class vtkDistanceRepresentation2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceRepresentation2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDistanceRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public new static vtkDistanceRepresentation2D New()
	{
		vtkDistanceRepresentation2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistanceRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public vtkDistanceRepresentation2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDistanceRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDistanceRepresentation2D_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkDistanceRepresentation2D_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation2D_GetAxis_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the vtkAxisActor2D used to draw the measurement axis. With this
	/// properties can be set and so on. There is also a convenience method to
	/// get the axis property.
	/// </summary>
	public vtkAxisActor2D GetAxis()
	{
		vtkAxisActor2D vtkAxisActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation2D_GetAxis_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisActor2D2 = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisActor2D2.Register(null);
			}
		}
		return vtkAxisActor2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation2D_GetAxisProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the vtkAxisActor2D used to draw the measurement axis. With this
	/// properties can be set and so on. There is also a convenience method to
	/// get the axis property.
	/// </summary>
	public vtkProperty2D GetAxisProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation2D_GetAxisProperty_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkDistanceRepresentation2D_GetDistance_04(HandleRef pThis);

	/// <summary>
	/// Satisfy the superclasses API.
	/// </summary>
	public override double GetDistance()
	{
		return vtkDistanceRepresentation2D_GetDistance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistanceRepresentation2D_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDistanceRepresentation2D_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistanceRepresentation2D_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDistanceRepresentation2D_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation2D_GetPoint1DisplayPosition_07(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint1DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation2D_GetPoint1DisplayPosition_07(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation2D_GetPoint1WorldPosition_08(HandleRef pThis);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override double[] GetPoint1WorldPosition()
	{
		IntPtr intPtr = vtkDistanceRepresentation2D_GetPoint1WorldPosition_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation2D_GetPoint1WorldPosition_09(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint1WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation2D_GetPoint1WorldPosition_09(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation2D_GetPoint2DisplayPosition_10(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint2DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation2D_GetPoint2DisplayPosition_10(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation2D_GetPoint2WorldPosition_11(HandleRef pThis);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override double[] GetPoint2WorldPosition()
	{
		IntPtr intPtr = vtkDistanceRepresentation2D_GetPoint2WorldPosition_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation2D_GetPoint2WorldPosition_12(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint2WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation2D_GetPoint2WorldPosition_12(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation2D_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDistanceRepresentation2D_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation2D_IsTypeOf_14(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDistanceRepresentation2D_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation2D_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkDistanceRepresentation2D NewInstance()
	{
		vtkDistanceRepresentation2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation2D_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistanceRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation2D_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkDistanceRepresentation2D_ReleaseGraphicsResources_17(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation2D_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkDistanceRepresentation2D_RenderOpaqueGeometry_18(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation2D_RenderOverlay_19(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkDistanceRepresentation2D_RenderOverlay_19(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation2D_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkDistanceRepresentation2D SafeDownCast(vtkObjectBase o)
	{
		vtkDistanceRepresentation2D vtkDistanceRepresentation2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation2D_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDistanceRepresentation2D2 = (vtkDistanceRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDistanceRepresentation2D2.Register(null);
			}
		}
		return vtkDistanceRepresentation2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation2D_SetPoint1DisplayPosition_21(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint1DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation2D_SetPoint1DisplayPosition_21(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation2D_SetPoint1WorldPosition_22(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint1WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation2D_SetPoint1WorldPosition_22(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation2D_SetPoint2DisplayPosition_23(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint2DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation2D_SetPoint2DisplayPosition_23(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation2D_SetPoint2WorldPosition_24(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint2WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation2D_SetPoint2WorldPosition_24(GetCppThis(), pos);
	}
}
