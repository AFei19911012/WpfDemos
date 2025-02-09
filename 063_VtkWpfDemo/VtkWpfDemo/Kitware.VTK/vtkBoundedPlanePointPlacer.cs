using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBoundedPlanePointPlacer
/// </summary>
/// <remarks>
///    a placer that constrains a handle to a finite plane
///
/// vtkBoundedPlanePointPlacer is a type of point placer that constrains its
/// points to a finite (i.e., bounded) plance.
///
/// </remarks>
/// <seealso>
///
/// vtkPointPlacer vtkHandleWidget vtkHandleRepresentation
/// </seealso>
public class vtkBoundedPlanePointPlacer : vtkPointPlacer
{
	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public enum Oblique_WrapperEnum
	{
		/// <summary>enum member</summary>
		Oblique = 3,
		/// <summary>enum member</summary>
		XAxis = 0,
		/// <summary>enum member</summary>
		YAxis = 1,
		/// <summary>enum member</summary>
		ZAxis = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBoundedPlanePointPlacer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBoundedPlanePointPlacer()
	{
		MRClassNameKey = "class vtkBoundedPlanePointPlacer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoundedPlanePointPlacer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBoundedPlanePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoundedPlanePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkBoundedPlanePointPlacer New()
	{
		vtkBoundedPlanePointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoundedPlanePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoundedPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkBoundedPlanePointPlacer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBoundedPlanePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBoundedPlanePointPlacer_AddBoundingPlane_01(HandleRef pThis, HandleRef plane);

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
		vtkBoundedPlanePointPlacer_AddBoundingPlane_01(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPlanePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

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
		return vtkBoundedPlanePointPlacer_ComputeWorldPosition_02(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPlanePointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer, a display position, and a reference world
	/// position, compute the new world position and orientation
	/// of this point. This method is typically used by the
	/// representation to move the point.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkBoundedPlanePointPlacer_ComputeWorldPosition_03(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, refWorldPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoundedPlanePointPlacer_GetBoundingPlanes_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBoundedPlanePointPlacer_GetBoundingPlanes_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkBoundedPlanePointPlacer_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBoundedPlanePointPlacer_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoundedPlanePointPlacer_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBoundedPlanePointPlacer_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoundedPlanePointPlacer_GetObliquePlane_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the ProjectionNormal is set to Oblique, then this is the
	/// oblique plane used to constrain the handle position.
	/// </summary>
	public virtual vtkPlane GetObliquePlane()
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoundedPlanePointPlacer_GetObliquePlane_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlane2 = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlane2.Register(null);
			}
		}
		return vtkPlane2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPlanePointPlacer_GetProjectionNormal_08(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public virtual int GetProjectionNormal()
	{
		return vtkBoundedPlanePointPlacer_GetProjectionNormal_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPlanePointPlacer_GetProjectionNormalMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public virtual int GetProjectionNormalMaxValue()
	{
		return vtkBoundedPlanePointPlacer_GetProjectionNormalMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPlanePointPlacer_GetProjectionNormalMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public virtual int GetProjectionNormalMinValue()
	{
		return vtkBoundedPlanePointPlacer_GetProjectionNormalMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBoundedPlanePointPlacer_GetProjectionPosition_11(HandleRef pThis);

	/// <summary>
	/// The position of the bounding plane from the origin along the
	/// normal. The origin and normal are defined in the oblique plane
	/// when the ProjectionNormal is oblique. For the X, Y, and Z
	/// axes projection normals, the normal is the axis direction, and
	/// the origin is (0,0,0).
	/// </summary>
	public virtual double GetProjectionPosition()
	{
		return vtkBoundedPlanePointPlacer_GetProjectionPosition_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPlanePointPlacer_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBoundedPlanePointPlacer_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPlanePointPlacer_IsTypeOf_13(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBoundedPlanePointPlacer_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoundedPlanePointPlacer_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkBoundedPlanePointPlacer NewInstance()
	{
		vtkBoundedPlanePointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoundedPlanePointPlacer_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoundedPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPlanePointPlacer_RemoveAllBoundingPlanes_16(HandleRef pThis);

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
		vtkBoundedPlanePointPlacer_RemoveAllBoundingPlanes_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPlanePointPlacer_RemoveBoundingPlane_17(HandleRef pThis, HandleRef plane);

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
		vtkBoundedPlanePointPlacer_RemoveBoundingPlane_17(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoundedPlanePointPlacer_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkBoundedPlanePointPlacer SafeDownCast(vtkObjectBase o)
	{
		vtkBoundedPlanePointPlacer vtkBoundedPlanePointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoundedPlanePointPlacer_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBoundedPlanePointPlacer2 = (vtkBoundedPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBoundedPlanePointPlacer2.Register(null);
			}
		}
		return vtkBoundedPlanePointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPlanePointPlacer_SetBoundingPlanes_19(HandleRef pThis, HandleRef arg0);

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
		vtkBoundedPlanePointPlacer_SetBoundingPlanes_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPlanePointPlacer_SetBoundingPlanes_20(HandleRef pThis, HandleRef planes);

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
		vtkBoundedPlanePointPlacer_SetBoundingPlanes_20(GetCppThis(), planes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPlanePointPlacer_SetObliquePlane_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// If the ProjectionNormal is set to Oblique, then this is the
	/// oblique plane used to constrain the handle position.
	/// </summary>
	public void SetObliquePlane(vtkPlane arg0)
	{
		vtkBoundedPlanePointPlacer_SetObliquePlane_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormal_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public virtual void SetProjectionNormal(int _arg)
	{
		vtkBoundedPlanePointPlacer_SetProjectionNormal_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToOblique_23(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public void SetProjectionNormalToOblique()
	{
		vtkBoundedPlanePointPlacer_SetProjectionNormalToOblique_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToXAxis_24(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public void SetProjectionNormalToXAxis()
	{
		vtkBoundedPlanePointPlacer_SetProjectionNormalToXAxis_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToYAxis_25(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public void SetProjectionNormalToYAxis()
	{
		vtkBoundedPlanePointPlacer_SetProjectionNormalToYAxis_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToZAxis_26(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public void SetProjectionNormalToZAxis()
	{
		vtkBoundedPlanePointPlacer_SetProjectionNormalToZAxis_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPlanePointPlacer_SetProjectionPosition_27(HandleRef pThis, double position);

	/// <summary>
	/// The position of the bounding plane from the origin along the
	/// normal. The origin and normal are defined in the oblique plane
	/// when the ProjectionNormal is oblique. For the X, Y, and Z
	/// axes projection normals, the normal is the axis direction, and
	/// the origin is (0,0,0).
	/// </summary>
	public void SetProjectionPosition(double position)
	{
		vtkBoundedPlanePointPlacer_SetProjectionPosition_27(GetCppThis(), position);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPlanePointPlacer_UpdateWorldPosition_28(HandleRef pThis, HandleRef ren, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// If the constraints on this placer are changed, then
	/// this method will be called by the representation on
	/// each of its points. For this placer, the world
	/// position will be converted to a display position, then
	/// ComputeWorldPosition will be used to update the
	/// point.
	/// </summary>
	public override int UpdateWorldPosition(vtkRenderer ren, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkBoundedPlanePointPlacer_UpdateWorldPosition_28(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPlanePointPlacer_ValidateWorldPosition_29(HandleRef pThis, IntPtr worldPos);

	/// <summary>
	/// Give a world position check if it is valid - does
	/// it lie on the plane and within the bounds? Returns
	/// 1 if it is valid, 0 otherwise.
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos)
	{
		return vtkBoundedPlanePointPlacer_ValidateWorldPosition_29(GetCppThis(), worldPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPlanePointPlacer_ValidateWorldPosition_30(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Give a world position check if it is valid - does
	/// it lie on the plane and within the bounds? Returns
	/// 1 if it is valid, 0 otherwise.
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkBoundedPlanePointPlacer_ValidateWorldPosition_30(GetCppThis(), worldPos, worldOrient);
	}
}
