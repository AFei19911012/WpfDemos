using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAngleRepresentation2D
/// </summary>
/// <remarks>
///    represent the vtkAngleWidget
///
/// The vtkAngleRepresentation2D is a representation for the
/// vtkAngleWidget. This representation consists of two rays and three
/// vtkHandleRepresentations to place and manipulate the three points defining
/// the angle representation. (Note: the three points are referred to as Point1,
/// Center, and Point2, at the two end points (Point1 and Point2) and Center
/// (around which the angle is measured). This particular implementation is a
/// 2D representation, meaning that it draws in the overlay plane.
///
/// </remarks>
/// <seealso>
///
/// vtkAngleWidget vtkHandleRepresentation
/// </seealso>
public class vtkAngleRepresentation2D : vtkAngleRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAngleRepresentation2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAngleRepresentation2D()
	{
		MRClassNameKey = "class vtkAngleRepresentation2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleRepresentation2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAngleRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public new static vtkAngleRepresentation2D New()
	{
		vtkAngleRepresentation2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAngleRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public vtkAngleRepresentation2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAngleRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAngleRepresentation2D_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Method defined by vtkWidgetRepresentation superclass and
	/// needed here.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkAngleRepresentation2D_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAngleRepresentation2D_GetAngle_02(HandleRef pThis);

	/// <summary>
	/// Satisfy the superclasses API.
	/// </summary>
	public override double GetAngle()
	{
		return vtkAngleRepresentation2D_GetAngle_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation2D_GetArc_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the three leaders used to create this representation.
	/// By obtaining these leaders the user can set the appropriate
	/// properties, etc.
	/// </summary>
	public virtual vtkLeaderActor2D GetArc()
	{
		vtkLeaderActor2D vtkLeaderActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation2D_GetArc_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLeaderActor2D2 = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLeaderActor2D2.Register(null);
			}
		}
		return vtkLeaderActor2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation2D_GetCenterDisplayPosition_04(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetCenterDisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation2D_GetCenterDisplayPosition_04(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation2D_GetCenterWorldPosition_05(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetCenterWorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation2D_GetCenterWorldPosition_05(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAngleRepresentation2D_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAngleRepresentation2D_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAngleRepresentation2D_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAngleRepresentation2D_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation2D_GetPoint1DisplayPosition_08(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint1DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation2D_GetPoint1DisplayPosition_08(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation2D_GetPoint1WorldPosition_09(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint1WorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation2D_GetPoint1WorldPosition_09(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation2D_GetPoint2DisplayPosition_10(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint2DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation2D_GetPoint2DisplayPosition_10(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation2D_GetPoint2WorldPosition_11(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint2WorldPosition(IntPtr pos)
	{
		vtkAngleRepresentation2D_GetPoint2WorldPosition_11(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation2D_GetRay1_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the three leaders used to create this representation.
	/// By obtaining these leaders the user can set the appropriate
	/// properties, etc.
	/// </summary>
	public virtual vtkLeaderActor2D GetRay1()
	{
		vtkLeaderActor2D vtkLeaderActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation2D_GetRay1_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLeaderActor2D2 = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLeaderActor2D2.Register(null);
			}
		}
		return vtkLeaderActor2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation2D_GetRay2_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the three leaders used to create this representation.
	/// By obtaining these leaders the user can set the appropriate
	/// properties, etc.
	/// </summary>
	public virtual vtkLeaderActor2D GetRay2()
	{
		vtkLeaderActor2D vtkLeaderActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation2D_GetRay2_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLeaderActor2D2 = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLeaderActor2D2.Register(null);
			}
		}
		return vtkLeaderActor2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation2D_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAngleRepresentation2D_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation2D_IsTypeOf_15(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAngleRepresentation2D_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation2D_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkAngleRepresentation2D NewInstance()
	{
		vtkAngleRepresentation2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation2D_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAngleRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation2D_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkAngleRepresentation2D_ReleaseGraphicsResources_18(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleRepresentation2D_RenderOverlay_19(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkAngleRepresentation2D_RenderOverlay_19(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleRepresentation2D_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkAngleRepresentation2D SafeDownCast(vtkObjectBase o)
	{
		vtkAngleRepresentation2D vtkAngleRepresentation2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleRepresentation2D_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAngleRepresentation2D2 = (vtkAngleRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAngleRepresentation2D2.Register(null);
			}
		}
		return vtkAngleRepresentation2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation2D_SetCenterDisplayPosition_21(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetCenterDisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation2D_SetCenterDisplayPosition_21(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation2D_SetPoint1DisplayPosition_22(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint1DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation2D_SetPoint1DisplayPosition_22(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleRepresentation2D_SetPoint2DisplayPosition_23(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint2DisplayPosition(IntPtr pos)
	{
		vtkAngleRepresentation2D_SetPoint2DisplayPosition_23(GetCppThis(), pos);
	}
}
