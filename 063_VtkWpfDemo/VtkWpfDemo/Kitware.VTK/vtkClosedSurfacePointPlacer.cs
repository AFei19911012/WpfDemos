using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkClosedSurfacePointPlacer
/// </summary>
/// <remarks>
///    PointPlacer to constrain validity within a set of convex planes
///
/// This placer takes a set of boudning planes and constraints the validity
/// within the supplied convex planes. It is used by the
/// ParallelopPipedRepresentation to place constraints on the motion the
/// handles within the parallelopiped.
///
/// </remarks>
/// <seealso>
///
/// vtkParallelopipedRepresentation
/// </seealso>
public class vtkClosedSurfacePointPlacer : vtkPointPlacer
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkClosedSurfacePointPlacer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkClosedSurfacePointPlacer()
	{
		MRClassNameKey = "class vtkClosedSurfacePointPlacer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkClosedSurfacePointPlacer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkClosedSurfacePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClosedSurfacePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkClosedSurfacePointPlacer New()
	{
		vtkClosedSurfacePointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClosedSurfacePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClosedSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkClosedSurfacePointPlacer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkClosedSurfacePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkClosedSurfacePointPlacer_AddBoundingPlane_01(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public void AddBoundingPlane(vtkPlane plane)
	{
		vtkClosedSurfacePointPlacer_AddBoundingPlane_01(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClosedSurfacePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer and a display position, compute the
	/// world position and world orientation for this point.
	/// A plane is defined by a combination of the
	/// ProjectionNormal, ProjectionOrigin, and ObliquePlane
	/// ivars. The display position is projected onto this
	/// plane to determine a world position, and the
	/// orientation is set to the normal of the plane. If
	/// the point cannot project onto the plane or if it
	/// falls outside the bounds imposed by the
	/// BoundingPlanes, then 0 is returned, otherwise 1 is
	/// returned to indicate a valid return position and
	/// orientation.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkClosedSurfacePointPlacer_ComputeWorldPosition_02(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClosedSurfacePointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer, a display position and a reference position, "worldPos"
	/// is calculated as :
	/// Consider the line "L" that passes through the supplied "displayPos" and
	/// is parallel to the direction of projection of the camera. Clip this line
	/// segment with the parallelopiped, let's call it "L_segment". The computed
	/// world position, "worldPos" will be the point on "L_segment" that is
	/// closest to refWorldPos.
	/// NOTE: Note that a set of bounding planes must be supplied. The Oblique
	/// plane, if supplied is ignored.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkClosedSurfacePointPlacer_ComputeWorldPosition_03(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, refWorldPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClosedSurfacePointPlacer_GetBoundingPlanes_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public virtual vtkPlaneCollection GetBoundingPlanes()
	{
		vtkPlaneCollection vtkPlaneCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClosedSurfacePointPlacer_GetBoundingPlanes_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlaneCollection2 = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlaneCollection2.Register(null);
			}
		}
		return vtkPlaneCollection2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClosedSurfacePointPlacer_GetMinimumDistance_05(HandleRef pThis);

	/// <summary>
	/// Give a world position check if it is valid - does
	/// it lie on the plane and within the bounds? Returns
	/// 1 if it is valid, 0 otherwise.
	/// </summary>
	public virtual double GetMinimumDistance()
	{
		return vtkClosedSurfacePointPlacer_GetMinimumDistance_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClosedSurfacePointPlacer_GetMinimumDistanceMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Give a world position check if it is valid - does
	/// it lie on the plane and within the bounds? Returns
	/// 1 if it is valid, 0 otherwise.
	/// </summary>
	public virtual double GetMinimumDistanceMaxValue()
	{
		return vtkClosedSurfacePointPlacer_GetMinimumDistanceMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClosedSurfacePointPlacer_GetMinimumDistanceMinValue_07(HandleRef pThis);

	/// <summary>
	/// Give a world position check if it is valid - does
	/// it lie on the plane and within the bounds? Returns
	/// 1 if it is valid, 0 otherwise.
	/// </summary>
	public virtual double GetMinimumDistanceMinValue()
	{
		return vtkClosedSurfacePointPlacer_GetMinimumDistanceMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClosedSurfacePointPlacer_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkClosedSurfacePointPlacer_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClosedSurfacePointPlacer_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkClosedSurfacePointPlacer_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClosedSurfacePointPlacer_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkClosedSurfacePointPlacer_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClosedSurfacePointPlacer_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkClosedSurfacePointPlacer_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClosedSurfacePointPlacer_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkClosedSurfacePointPlacer NewInstance()
	{
		vtkClosedSurfacePointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClosedSurfacePointPlacer_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClosedSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClosedSurfacePointPlacer_RemoveAllBoundingPlanes_14(HandleRef pThis);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public void RemoveAllBoundingPlanes()
	{
		vtkClosedSurfacePointPlacer_RemoveAllBoundingPlanes_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClosedSurfacePointPlacer_RemoveBoundingPlane_15(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public void RemoveBoundingPlane(vtkPlane plane)
	{
		vtkClosedSurfacePointPlacer_RemoveBoundingPlane_15(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClosedSurfacePointPlacer_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkClosedSurfacePointPlacer SafeDownCast(vtkObjectBase o)
	{
		vtkClosedSurfacePointPlacer vtkClosedSurfacePointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClosedSurfacePointPlacer_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkClosedSurfacePointPlacer2 = (vtkClosedSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkClosedSurfacePointPlacer2.Register(null);
			}
		}
		return vtkClosedSurfacePointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClosedSurfacePointPlacer_SetBoundingPlanes_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public virtual void SetBoundingPlanes(vtkPlaneCollection arg0)
	{
		vtkClosedSurfacePointPlacer_SetBoundingPlanes_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClosedSurfacePointPlacer_SetBoundingPlanes_18(HandleRef pThis, HandleRef planes);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public void SetBoundingPlanes(vtkPlanes planes)
	{
		vtkClosedSurfacePointPlacer_SetBoundingPlanes_18(GetCppThis(), planes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClosedSurfacePointPlacer_SetMinimumDistance_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Give a world position check if it is valid - does
	/// it lie on the plane and within the bounds? Returns
	/// 1 if it is valid, 0 otherwise.
	/// </summary>
	public virtual void SetMinimumDistance(double _arg)
	{
		vtkClosedSurfacePointPlacer_SetMinimumDistance_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClosedSurfacePointPlacer_ValidateWorldPosition_20(HandleRef pThis, IntPtr worldPos);

	/// <summary>
	/// Give a world position check if it is valid - does
	/// it lie on the plane and within the bounds? Returns
	/// 1 if it is valid, 0 otherwise.
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos)
	{
		return vtkClosedSurfacePointPlacer_ValidateWorldPosition_20(GetCppThis(), worldPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClosedSurfacePointPlacer_ValidateWorldPosition_21(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Give a world position check if it is valid - does
	/// it lie on the plane and within the bounds? Returns
	/// 1 if it is valid, 0 otherwise.
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkClosedSurfacePointPlacer_ValidateWorldPosition_21(GetCppThis(), worldPos, worldOrient);
	}
}
