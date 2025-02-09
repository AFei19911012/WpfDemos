using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGraphAnnotationLayersFilter
/// </summary>
/// <remarks>
///    Produce filled convex hulls around
/// subsets of vertices in a vtkGraph.
///
///
/// Produces a vtkPolyData comprised of filled polygons of the convex hull
/// of a cluster. Alternatively, you may choose to output bounding rectangles.
/// Clusters with fewer than three vertices are artificially expanded to
/// ensure visibility (see vtkConvexHull2D).
///
/// The first input is a vtkGraph with points, possibly set by
/// passing the graph through vtkGraphLayout (z-values are ignored). The second
/// input is a vtkAnnotationsLayer containing vtkSelectionNodeS of vertex
/// ids (the 'clusters' output of vtkTulipReader for example).
///
/// Setting OutlineOn() additionally produces outlines of the clusters on
/// output port 1.
///
/// Three arrays are added to the cells of the output: "Hull id"; "Hull name";
/// and "Hull color".
///
/// Note: This filter operates in the x,y-plane and as such works best with an
/// interactor style that does not allow camera rotation, such as
/// vtkInteractorStyleRubberBand2D.
///
/// </remarks>
/// <seealso>
///
/// vtkContext2D
///
/// @par Thanks:
/// Thanks to Colin Myers, University of Leeds for providing this implementation.
/// </seealso>
public class vtkGraphAnnotationLayersFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGraphAnnotationLayersFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGraphAnnotationLayersFilter()
	{
		MRClassNameKey = "class vtkGraphAnnotationLayersFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphAnnotationLayersFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGraphAnnotationLayersFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphAnnotationLayersFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphAnnotationLayersFilter New()
	{
		vtkGraphAnnotationLayersFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphAnnotationLayersFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphAnnotationLayersFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGraphAnnotationLayersFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGraphAnnotationLayersFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGraphAnnotationLayersFilter_GetMTime_01(HandleRef pThis);

	/// <summary>
	/// The modified time of this filter.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGraphAnnotationLayersFilter_GetMTime_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphAnnotationLayersFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGraphAnnotationLayersFilter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphAnnotationLayersFilter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGraphAnnotationLayersFilter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphAnnotationLayersFilter_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGraphAnnotationLayersFilter_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphAnnotationLayersFilter_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGraphAnnotationLayersFilter_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphAnnotationLayersFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGraphAnnotationLayersFilter NewInstance()
	{
		vtkGraphAnnotationLayersFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphAnnotationLayersFilter_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphAnnotationLayersFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphAnnotationLayersFilter_OutlineOff_08(HandleRef pThis);

	/// <summary>
	/// Produce outlines of the hulls on output port 1.
	/// </summary>
	public void OutlineOff()
	{
		vtkGraphAnnotationLayersFilter_OutlineOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphAnnotationLayersFilter_OutlineOn_09(HandleRef pThis);

	/// <summary>
	/// Produce outlines of the hulls on output port 1.
	/// </summary>
	public void OutlineOn()
	{
		vtkGraphAnnotationLayersFilter_OutlineOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphAnnotationLayersFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphAnnotationLayersFilter SafeDownCast(vtkObjectBase o)
	{
		vtkGraphAnnotationLayersFilter vtkGraphAnnotationLayersFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphAnnotationLayersFilter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphAnnotationLayersFilter2 = (vtkGraphAnnotationLayersFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphAnnotationLayersFilter2.Register(null);
			}
		}
		return vtkGraphAnnotationLayersFilter2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphAnnotationLayersFilter_SetHullShapeToBoundingRectangle_11(HandleRef pThis);

	/// <summary>
	/// Set the shape of the hulls to bounding rectangle.
	/// </summary>
	public void SetHullShapeToBoundingRectangle()
	{
		vtkGraphAnnotationLayersFilter_SetHullShapeToBoundingRectangle_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphAnnotationLayersFilter_SetHullShapeToConvexHull_12(HandleRef pThis);

	/// <summary>
	/// Set the shape of the hulls to convex hull. Default.
	/// </summary>
	public void SetHullShapeToConvexHull()
	{
		vtkGraphAnnotationLayersFilter_SetHullShapeToConvexHull_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphAnnotationLayersFilter_SetMinHullSizeInDisplay_13(HandleRef pThis, int size);

	/// <summary>
	/// Set the minimum x,y-dimensions of each hull in pixels. You must also set a
	/// vtkRenderer. Defaults to 1. Set to 0 to disable.
	/// </summary>
	public void SetMinHullSizeInDisplay(int size)
	{
		vtkGraphAnnotationLayersFilter_SetMinHullSizeInDisplay_13(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphAnnotationLayersFilter_SetMinHullSizeInWorld_14(HandleRef pThis, double size);

	/// <summary>
	/// Set the minimum x,y-dimensions of each hull in world coordinates. Defaults
	/// to 1.0. Set to 0.0 to disable.
	/// </summary>
	public void SetMinHullSizeInWorld(double size)
	{
		vtkGraphAnnotationLayersFilter_SetMinHullSizeInWorld_14(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphAnnotationLayersFilter_SetOutline_15(HandleRef pThis, byte b);

	/// <summary>
	/// Produce outlines of the hulls on output port 1.
	/// </summary>
	public void SetOutline(bool b)
	{
		vtkGraphAnnotationLayersFilter_SetOutline_15(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphAnnotationLayersFilter_SetRenderer_16(HandleRef pThis, HandleRef renderer);

	/// <summary>
	/// Renderer needed for MinHullSizeInDisplay calculation. Not reference counted.
	/// </summary>
	public void SetRenderer(vtkRenderer renderer)
	{
		vtkGraphAnnotationLayersFilter_SetRenderer_16(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphAnnotationLayersFilter_SetScaleFactor_17(HandleRef pThis, double scale);

	/// <summary>
	/// Scale each hull by the amount specified. Defaults to 1.0.
	/// </summary>
	public void SetScaleFactor(double scale)
	{
		vtkGraphAnnotationLayersFilter_SetScaleFactor_17(GetCppThis(), scale);
	}
}
