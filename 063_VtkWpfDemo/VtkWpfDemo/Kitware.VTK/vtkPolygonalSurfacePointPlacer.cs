using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolygonalSurfacePointPlacer
/// </summary>
/// <remarks>
///    Place points on the surface of polygonal data.
///
///
/// vtkPolygonalSurfacePointPlacer places points on polygonal data and is
/// meant to be used in conjunction with
/// vtkPolygonalSurfaceContourLineInterpolator.
///
/// @warning
/// You should have computed cell normals for the input polydata if you are
/// specifying a distance offset.
///
/// </remarks>
/// <seealso>
///
/// vtkPointPlacer vtkPolyDataNormals
/// </seealso>
public class vtkPolygonalSurfacePointPlacer : vtkPolyDataPointPlacer
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonalSurfacePointPlacer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolygonalSurfacePointPlacer()
	{
		MRClassNameKey = "class vtkPolygonalSurfacePointPlacer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonalSurfacePointPlacer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolygonalSurfacePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalSurfacePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkPolygonalSurfacePointPlacer New()
	{
		vtkPolygonalSurfacePointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygonalSurfacePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolygonalSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkPolygonalSurfacePointPlacer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolygonalSurfacePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPolygonalSurfacePointPlacer_AddProp_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override void AddProp(vtkProp arg0)
	{
		vtkPolygonalSurfacePointPlacer_AddProp_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer and a display position in pixel coordinates,
	/// compute the world position and orientation where this point
	/// will be placed. This method is typically used by the
	/// representation to place the point initially.
	/// For the Terrain point placer this computes world points that
	/// lie at the specified height above the terrain.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_02(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer, a display position, and a reference world
	/// position, compute the new world position and orientation
	/// of this point. This method is typically used by the
	/// representation to move the point.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_03(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, refWorldPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalSurfacePointPlacer_GetCellPicker_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the Prop picker.
	/// </summary>
	public virtual vtkCellPicker GetCellPicker()
	{
		vtkCellPicker vtkCellPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygonalSurfacePointPlacer_GetCellPicker_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellPicker2 = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellPicker2.Register(null);
			}
		}
		return vtkCellPicker2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolygonalSurfacePointPlacer_GetDistanceOffset_05(HandleRef pThis);

	/// <summary>
	/// Height offset at which points may be placed on the polygonal surface.
	/// If you specify a non-zero value here, be sure to compute cell normals
	/// on your input polygonal data (easily done with vtkPolyDataNormals).
	/// </summary>
	public virtual double GetDistanceOffset()
	{
		return vtkPolygonalSurfacePointPlacer_GetDistanceOffset_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolygonalSurfacePointPlacer_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolygonalSurfacePointPlacer_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolygonalSurfacePointPlacer_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolygonalSurfacePointPlacer_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalSurfacePointPlacer_GetPolys_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Be sure to add polydata on which you wish to place points to this list
	/// or they will not be considered for placement.
	/// </summary>
	public virtual vtkPolyDataCollection GetPolys()
	{
		vtkPolyDataCollection vtkPolyDataCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygonalSurfacePointPlacer_GetPolys_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataCollection2 = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataCollection2.Register(null);
			}
		}
		return vtkPolyDataCollection2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfacePointPlacer_GetSnapToClosestPoint_09(HandleRef pThis);

	/// <summary>
	/// Snap to the closest point on the surface ?
	/// This is useful for the vtkPolygonalSurfaceContourLineInterpolator, when
	/// drawing contours along the edges of a surface mesh.
	/// OFF by default.
	/// </summary>
	public virtual int GetSnapToClosestPoint()
	{
		return vtkPolygonalSurfacePointPlacer_GetSnapToClosestPoint_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfacePointPlacer_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolygonalSurfacePointPlacer_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfacePointPlacer_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolygonalSurfacePointPlacer_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalSurfacePointPlacer_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkPolygonalSurfacePointPlacer NewInstance()
	{
		vtkPolygonalSurfacePointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygonalSurfacePointPlacer_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolygonalSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalSurfacePointPlacer_RemoveAllProps_14(HandleRef pThis);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override void RemoveAllProps()
	{
		vtkPolygonalSurfacePointPlacer_RemoveAllProps_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalSurfacePointPlacer_RemoveViewProp_15(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override void RemoveViewProp(vtkProp prop)
	{
		vtkPolygonalSurfacePointPlacer_RemoveViewProp_15(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalSurfacePointPlacer_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkPolygonalSurfacePointPlacer SafeDownCast(vtkObjectBase o)
	{
		vtkPolygonalSurfacePointPlacer vtkPolygonalSurfacePointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygonalSurfacePointPlacer_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolygonalSurfacePointPlacer2 = (vtkPolygonalSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolygonalSurfacePointPlacer2.Register(null);
			}
		}
		return vtkPolygonalSurfacePointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalSurfacePointPlacer_SetDistanceOffset_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Height offset at which points may be placed on the polygonal surface.
	/// If you specify a non-zero value here, be sure to compute cell normals
	/// on your input polygonal data (easily done with vtkPolyDataNormals).
	/// </summary>
	public virtual void SetDistanceOffset(double _arg)
	{
		vtkPolygonalSurfacePointPlacer_SetDistanceOffset_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalSurfacePointPlacer_SetSnapToClosestPoint_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Snap to the closest point on the surface ?
	/// This is useful for the vtkPolygonalSurfaceContourLineInterpolator, when
	/// drawing contours along the edges of a surface mesh.
	/// OFF by default.
	/// </summary>
	public virtual void SetSnapToClosestPoint(int _arg)
	{
		vtkPolygonalSurfacePointPlacer_SetSnapToClosestPoint_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalSurfacePointPlacer_SnapToClosestPointOff_19(HandleRef pThis);

	/// <summary>
	/// Snap to the closest point on the surface ?
	/// This is useful for the vtkPolygonalSurfaceContourLineInterpolator, when
	/// drawing contours along the edges of a surface mesh.
	/// OFF by default.
	/// </summary>
	public virtual void SnapToClosestPointOff()
	{
		vtkPolygonalSurfacePointPlacer_SnapToClosestPointOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalSurfacePointPlacer_SnapToClosestPointOn_20(HandleRef pThis);

	/// <summary>
	/// Snap to the closest point on the surface ?
	/// This is useful for the vtkPolygonalSurfaceContourLineInterpolator, when
	/// drawing contours along the edges of a surface mesh.
	/// OFF by default.
	/// </summary>
	public virtual void SnapToClosestPointOn()
	{
		vtkPolygonalSurfacePointPlacer_SnapToClosestPointOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfacePointPlacer_UpdateNodeWorldPosition_21(HandleRef pThis, IntPtr worldPos, long nodePointId);

	/// <summary>
	/// Give the node a chance to update its auxiliary point id.
	/// </summary>
	public override int UpdateNodeWorldPosition(IntPtr worldPos, long nodePointId)
	{
		return vtkPolygonalSurfacePointPlacer_UpdateNodeWorldPosition_21(GetCppThis(), worldPos, nodePointId);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfacePointPlacer_ValidateDisplayPosition_22(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

	/// <summary>
	/// Given a display position, check the validity of this position.
	/// </summary>
	public override int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
	{
		return vtkPolygonalSurfacePointPlacer_ValidateDisplayPosition_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), displayPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_23(HandleRef pThis, IntPtr worldPos);

	/// <summary>
	/// Given a world position check the validity of this
	/// position according to the constraints of the placer
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos)
	{
		return vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_23(GetCppThis(), worldPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_24(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a world position and a world orientation,
	/// validate it according to the constraints of the placer.
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_24(GetCppThis(), worldPos, worldOrient);
	}
}
