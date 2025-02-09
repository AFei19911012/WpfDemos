using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolygonalSurfaceContourLineInterpolator
/// </summary>
/// <remarks>
///    Contour interpolator for to place points on polygonal surfaces.
///
///
/// vtkPolygonalSurfaceContourLineInterpolator interpolates and places
/// contour points on polygonal surfaces. The class interpolates nodes by
/// computing a \em graph \em geodesic laying on the polygonal data. By \em
/// graph \em Geodesic, we mean that the line interpolating the two end
/// points traverses along on the mesh edges so as to form the shortest
/// path. A Dijkstra algorithm is used to compute the path. See
/// vtkDijkstraGraphGeodesicPath.
///
/// The class is mean to be used in conjunction with
/// vtkPolygonalSurfacePointPlacer. The reason for this weak coupling is a
/// performance issue, both classes need to perform a cell pick, and
/// coupling avoids multiple cell picks (cell picks are slow).
///
/// @warning
/// You should have computed cell normals for the input polydata.
///
/// </remarks>
/// <seealso>
///
/// vtkDijkstraGraphGeodesicPath, vtkPolyDataNormals
/// </seealso>
public class vtkPolygonalSurfaceContourLineInterpolator : vtkPolyDataContourLineInterpolator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonalSurfaceContourLineInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolygonalSurfaceContourLineInterpolator()
	{
		MRClassNameKey = "class vtkPolygonalSurfaceContourLineInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonalSurfaceContourLineInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolygonalSurfaceContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalSurfaceContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkPolygonalSurfaceContourLineInterpolator New()
	{
		vtkPolygonalSurfaceContourLineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygonalSurfaceContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolygonalSurfaceContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public vtkPolygonalSurfaceContourLineInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolygonalSurfaceContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPolygonalSurfaceContourLineInterpolator_GetContourPointIds_01(HandleRef pThis, HandleRef rep, HandleRef ids);

	/// <summary>
	/// Get the contour point ids. These point ids correspond to those on the
	/// polygonal surface
	/// </summary>
	public void GetContourPointIds(vtkContourRepresentation rep, vtkIdList ids)
	{
		vtkPolygonalSurfaceContourLineInterpolator_GetContourPointIds_01(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef), ids?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolygonalSurfaceContourLineInterpolator_GetDistanceOffset_02(HandleRef pThis);

	/// <summary>
	/// Height offset at which points may be placed on the polygonal surface.
	/// If you specify a non-zero value here, be sure to have computed vertex
	/// normals on your input polygonal data. (easily done with
	/// vtkPolyDataNormals).
	/// </summary>
	public virtual double GetDistanceOffset()
	{
		return vtkPolygonalSurfaceContourLineInterpolator_GetDistanceOffset_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolygonalSurfaceContourLineInterpolator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolygonalSurfaceContourLineInterpolator_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolygonalSurfaceContourLineInterpolator_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolygonalSurfaceContourLineInterpolator_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfaceContourLineInterpolator_InterpolateLine_05(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

	/// <summary>
	/// Subclasses that wish to interpolate a line segment must implement this.
	/// For instance vtkBezierContourLineInterpolator adds nodes between idx1
	/// and idx2, that allow the contour to adhere to a bezier curve.
	/// </summary>
	public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
	{
		return vtkPolygonalSurfaceContourLineInterpolator_InterpolateLine_05(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), rep?.GetCppThis() ?? default(HandleRef), idx1, idx2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfaceContourLineInterpolator_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolygonalSurfaceContourLineInterpolator_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfaceContourLineInterpolator_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolygonalSurfaceContourLineInterpolator_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalSurfaceContourLineInterpolator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkPolygonalSurfaceContourLineInterpolator NewInstance()
	{
		vtkPolygonalSurfaceContourLineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygonalSurfaceContourLineInterpolator_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolygonalSurfaceContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalSurfaceContourLineInterpolator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkPolygonalSurfaceContourLineInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkPolygonalSurfaceContourLineInterpolator vtkPolygonalSurfaceContourLineInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygonalSurfaceContourLineInterpolator_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolygonalSurfaceContourLineInterpolator2 = (vtkPolygonalSurfaceContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolygonalSurfaceContourLineInterpolator2.Register(null);
			}
		}
		return vtkPolygonalSurfaceContourLineInterpolator2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalSurfaceContourLineInterpolator_SetDistanceOffset_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Height offset at which points may be placed on the polygonal surface.
	/// If you specify a non-zero value here, be sure to have computed vertex
	/// normals on your input polygonal data. (easily done with
	/// vtkPolyDataNormals).
	/// </summary>
	public virtual void SetDistanceOffset(double _arg)
	{
		vtkPolygonalSurfaceContourLineInterpolator_SetDistanceOffset_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalSurfaceContourLineInterpolator_UpdateNode_12(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

	/// <summary>
	/// The interpolator is given a chance to update the node.
	/// vtkImageContourLineInterpolator updates the idx'th node in the contour,
	/// so it automatically sticks to edges in the vicinity as the user
	/// constructs the contour.
	/// Returns 0 if the node (world position) is unchanged.
	/// </summary>
	public override int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
	{
		return vtkPolygonalSurfaceContourLineInterpolator_UpdateNode_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2, arg3);
	}
}
