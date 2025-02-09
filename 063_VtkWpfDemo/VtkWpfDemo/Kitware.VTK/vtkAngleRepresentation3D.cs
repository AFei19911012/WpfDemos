using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAngleRepresentation3D
/// </summary>
/// <remarks>
///    represent the vtkAngleWidget
///
/// The vtkAngleRepresentation3D is a representation for the
/// vtkAngleWidget. This representation consists of two rays and three
/// vtkHandleRepresentations to place and manipulate the three points defining
/// the angle representation. (Note: the three points are referred to as Point1,
/// Center, and Point2, at the two end points (Point1 and Point2) and Center
/// (around which the angle is measured). This particular implementation is a
/// 3D representation, meaning that it draws in the overlay plane.
///
/// </remarks>
/// <seealso>
///
/// vtkAngleWidget vtkHandleRepresentation
/// </seealso>
public class vtkAngleRepresentation3D : vtkAngleRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAngleRepresentation3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAngleRepresentation3D()
	{
		MRClassNameKey = "class vtkAngleRepresentation3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleRepresentation3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAngleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public new static vtkAngleRepresentation3D New()
	{
		vtkAngleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAngleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public vtkAngleRepresentation3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAngleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAngleRepresentation3D_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Method defined by vtkWidgetRepresentation superclass and
	/// needed here.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkAngleRepresentation3D_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAngleRepresentation3D_GetAngle_02(HandleRef pThis);

	/// <summary>
	/// Satisfy the superclasses API. Angle returned is in radians.
	/// </summary>
	public override double GetAngle()
	{
		return vtkAngleRepresentation3D_GetAngle_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation3D_GetArc_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the three leaders used to create this representation.
	/// By obtaining these leaders the user can set the appropriate
	/// properties, etc.
	/// </summary>
	public virtual vtkActor GetArc()
	{
		vtkActor vtkActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation3D_GetArc_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2 = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2.Register(null);
			}
		}
		return vtkActor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_GetCenterDisplayPosition_04(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetCenterDisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_GetCenterDisplayPosition_04(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_GetCenterWorldPosition_05(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetCenterWorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_GetCenterWorldPosition_05(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAngleRepresentation3D_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAngleRepresentation3D_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAngleRepresentation3D_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAngleRepresentation3D_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_GetPoint1DisplayPosition_08(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint1DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_GetPoint1DisplayPosition_08(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_GetPoint1WorldPosition_09(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint1WorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_GetPoint1WorldPosition_09(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_GetPoint2DisplayPosition_10(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint2DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_GetPoint2DisplayPosition_10(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_GetPoint2WorldPosition_11(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint2WorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_GetPoint2WorldPosition_11(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation3D_GetRay1_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the three leaders used to create this representation.
	/// By obtaining these leaders the user can set the appropriate
	/// properties, etc.
	/// </summary>
	public virtual vtkActor GetRay1()
	{
		vtkActor vtkActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation3D_GetRay1_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2 = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2.Register(null);
			}
		}
		return vtkActor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation3D_GetRay2_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the three leaders used to create this representation.
	/// By obtaining these leaders the user can set the appropriate
	/// properties, etc.
	/// </summary>
	public virtual vtkActor GetRay2()
	{
		vtkActor vtkActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation3D_GetRay2_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2 = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2.Register(null);
			}
		}
		return vtkActor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation3D_GetTextActor_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the three leaders used to create this representation.
	/// By obtaining these leaders the user can set the appropriate
	/// properties, etc.
	/// </summary>
	public virtual vtkFollower GetTextActor()
	{
		vtkFollower vtkFollower2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation3D_GetTextActor_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFollower2 = (vtkFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFollower2.Register(null);
			}
		}
		return vtkFollower2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation3D_GetTextActorScale_15(HandleRef pThis);

	/// <summary>
	/// Scale text.
	/// </summary>
	public virtual IntPtr GetTextActorScale()
	{
		return vtkAngleRepresentation3D_GetTextActorScale_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation3D_HasTranslucentPolygonalGeometry_16(HandleRef pThis);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkAngleRepresentation3D_HasTranslucentPolygonalGeometry_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation3D_IsA_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAngleRepresentation3D_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation3D_IsTypeOf_18(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAngleRepresentation3D_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation3D_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkAngleRepresentation3D NewInstance()
	{
		vtkAngleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation3D_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAngleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_ReleaseGraphicsResources_21(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkAngleRepresentation3D_ReleaseGraphicsResources_21(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation3D_RenderOpaqueGeometry_22(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkAngleRepresentation3D_RenderOpaqueGeometry_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation3D_RenderTranslucentPolygonalGeometry_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkAngleRepresentation3D_RenderTranslucentPolygonalGeometry_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation3D_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkAngleRepresentation3D SafeDownCast(vtkObjectBase o)
	{
		vtkAngleRepresentation3D vtkAngleRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation3D_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAngleRepresentation3D2 = (vtkAngleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAngleRepresentation3D2.Register(null);
			}
		}
		return vtkAngleRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_SetCenterDisplayPosition_25(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetCenterDisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_SetCenterDisplayPosition_25(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_SetCenterWorldPosition_26(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetCenterWorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_SetCenterWorldPosition_26(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_SetPoint1DisplayPosition_27(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint1DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_SetPoint1DisplayPosition_27(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_SetPoint1WorldPosition_28(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint1WorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_SetPoint1WorldPosition_28(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_SetPoint2DisplayPosition_29(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint2DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_SetPoint2DisplayPosition_29(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_SetPoint2WorldPosition_30(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint2WorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation3D_SetPoint2WorldPosition_30(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation3D_SetTextActorScale_31(HandleRef pThis, IntPtr scale);

	/// <summary>
	/// Scale text.
	/// </summary>
	public virtual void SetTextActorScale(IntPtr scale)
	{
		vtkAngleRepresentation3D_SetTextActorScale_31(GetCppThis(), scale);
	}
}
