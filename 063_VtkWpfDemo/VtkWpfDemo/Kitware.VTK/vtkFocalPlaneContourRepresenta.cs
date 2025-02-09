using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFocalPlaneContourRepresentation
/// </summary>
/// <remarks>
///    represent a contour drawn on the
/// focal plane.
///
///
/// The contour will stay on the focal plane irrespective of camera
/// position/orientation changes. The class was written in order to be able to
/// draw contours on a volume widget and have the contours overlaid on the
/// focal plane in order to do contour segmentation. The superclass,
/// vtkContourRepresentation handles contours that are drawn in actual world
/// position co-ordinates, so they would rotate with the camera position/
/// orientation changes
///
/// </remarks>
/// <seealso>
///
/// vtkContourWidget vtkHandleRepresentation vtkContourRepresentation
/// </seealso>
public abstract class vtkFocalPlaneContourRepresentation : vtkContourRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFocalPlaneContourRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFocalPlaneContourRepresentation()
	{
		MRClassNameKey = "class vtkFocalPlaneContourRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFocalPlaneContourRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFocalPlaneContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkFocalPlaneContourRepresentation_GetIntermediatePointDisplayPosition_01(HandleRef pThis, int n, int idx, IntPtr point);

	/// <summary>
	/// Get the world position of the intermediate point at
	/// index idx between nodes n and (n+1) (or n and 0 if
	/// n is the last node and the loop is closed). Returns
	/// 1 on success or 0 if n or idx are out of range.
	/// </summary>
	public virtual int GetIntermediatePointDisplayPosition(int n, int idx, IntPtr point)
	{
		return vtkFocalPlaneContourRepresentation_GetIntermediatePointDisplayPosition_01(GetCppThis(), n, idx, point);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFocalPlaneContourRepresentation_GetIntermediatePointWorldPosition_02(HandleRef pThis, int n, int idx, IntPtr point);

	/// <summary>
	/// Get the world position of the intermediate point at
	/// index idx between nodes n and (n+1) (or n and 0 if
	/// n is the last node and the loop is closed). Returns
	/// 1 on success or 0 if n or idx are out of range.
	/// </summary>
	public override int GetIntermediatePointWorldPosition(int n, int idx, IntPtr point)
	{
		return vtkFocalPlaneContourRepresentation_GetIntermediatePointWorldPosition_02(GetCppThis(), n, idx, point);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFocalPlaneContourRepresentation_GetNthNodeDisplayPosition_03(HandleRef pThis, int n, IntPtr pos);

	/// <summary>
	/// Get the nth node's display position. Will return
	/// 1 on success, or 0 if there are not at least
	/// (n+1) nodes (0 based counting).
	/// </summary>
	public override int GetNthNodeDisplayPosition(int n, IntPtr pos)
	{
		return vtkFocalPlaneContourRepresentation_GetNthNodeDisplayPosition_03(GetCppThis(), n, pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFocalPlaneContourRepresentation_GetNthNodeWorldPosition_04(HandleRef pThis, int n, IntPtr pos);

	/// <summary>
	/// Get the nth node's world position. Will return
	/// 1 on success, or 0 if there are not at least
	/// (n+1) nodes (0 based counting).
	/// </summary>
	public override int GetNthNodeWorldPosition(int n, IntPtr pos)
	{
		return vtkFocalPlaneContourRepresentation_GetNthNodeWorldPosition_04(GetCppThis(), n, pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFocalPlaneContourRepresentation_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFocalPlaneContourRepresentation_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFocalPlaneContourRepresentation_IsTypeOf_08(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFocalPlaneContourRepresentation_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFocalPlaneContourRepresentation_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkFocalPlaneContourRepresentation NewInstance()
	{
		vtkFocalPlaneContourRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFocalPlaneContourRepresentation_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFocalPlaneContourRepresentation_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkFocalPlaneContourRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkFocalPlaneContourRepresentation vtkFocalPlaneContourRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFocalPlaneContourRepresentation_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFocalPlaneContourRepresentation2 = (vtkFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFocalPlaneContourRepresentation2.Register(null);
			}
		}
		return vtkFocalPlaneContourRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFocalPlaneContourRepresentation_UpdateContour_11(HandleRef pThis);

	/// <summary>
	/// The method must be called whenever the contour needs to be updated, usually
	/// from RenderOpaqueGeometry()
	/// </summary>
	public virtual int UpdateContour()
	{
		return vtkFocalPlaneContourRepresentation_UpdateContour_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFocalPlaneContourRepresentation_UpdateContourWorldPositionsBasedOnDisplayPositions_12(HandleRef pThis);

	/// <summary>
	/// The class maintains its true contour locations based on display co-ords
	/// This method syncs the world co-ords data structure with the display co-ords.
	/// </summary>
	public virtual void UpdateContourWorldPositionsBasedOnDisplayPositions()
	{
		vtkFocalPlaneContourRepresentation_UpdateContourWorldPositionsBasedOnDisplayPositions_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFocalPlaneContourRepresentation_UpdateLines_13(HandleRef pThis, int index);

	/// <summary>
	/// The method must be called whenever the contour needs to be updated, usually
	/// from RenderOpaqueGeometry()
	/// </summary>
	public virtual void UpdateLines(int index)
	{
		vtkFocalPlaneContourRepresentation_UpdateLines_13(GetCppThis(), index);
	}
}
