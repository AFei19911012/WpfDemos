using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkConvexHull2D
/// </summary>
/// <remarks>
///    Produce filled convex hulls around a set of points.
///
///
/// Produces a vtkPolyData comprised of a filled polygon of the convex hull
/// of the input points. You may alternatively choose to output a bounding
/// rectangle. Static methods are provided that calculate a (counter-clockwise)
/// hull based on a set of input points.
///
/// To help maintain the property of &lt;i&gt;guaranteed visibility&lt;/i&gt; hulls may be
/// artificially scaled by setting MinHullSizeInWorld. This is particularly
/// helpful in the case that there are only one or two points as it avoids
/// producing a degenerate polygon. This setting is also available as an
/// argument to the static methods.
///
/// Setting a vtkRenderer on the filter enables the possibility to set
/// MinHullSizeInDisplay to the desired number of display pixels to cover in
/// each of the x- and y-dimensions.
///
/// Setting OutlineOn() additionally produces an outline of the hull on output
/// port 1.
///
/// @attention
/// This filter operates in the x,y-plane and as such works best with an
/// interactor style that does not permit camera rotation such as
/// vtkInteractorStyleRubberBand2D.
///
/// @par Thanks:
/// Thanks to Colin Myers, University of Leeds for providing this implementation.
/// </remarks>
public class vtkConvexHull2D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Produce an outline (polyline) of the hull on output port 1.
	/// </summary>
	public enum HullShapes
	{
		/// <summary>enum member</summary>
		BoundingRectangle,
		/// <summary>enum member</summary>
		ConvexHull
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkConvexHull2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkConvexHull2D()
	{
		MRClassNameKey = "class vtkConvexHull2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvexHull2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkConvexHull2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvexHull2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConvexHull2D New()
	{
		vtkConvexHull2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvexHull2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConvexHull2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkConvexHull2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkConvexHull2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkConvexHull2D_CalculateBoundingRectangle_01(HandleRef inPoints, HandleRef outPoints, double minimumHullSize);

	/// <summary>
	/// Convenience methods to calculate a convex hull from a set of vtkPointS.
	/// </summary>
	public static void CalculateBoundingRectangle(vtkPoints inPoints, vtkPoints outPoints, double minimumHullSize)
	{
		vtkConvexHull2D_CalculateBoundingRectangle_01(inPoints?.GetCppThis() ?? default(HandleRef), outPoints?.GetCppThis() ?? default(HandleRef), minimumHullSize);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexHull2D_CalculateConvexHull_02(HandleRef inPoints, HandleRef outPoints, double minimumHullSize);

	/// <summary>
	/// Convenience methods to calculate a convex hull from a set of vtkPointS.
	/// </summary>
	public static void CalculateConvexHull(vtkPoints inPoints, vtkPoints outPoints, double minimumHullSize)
	{
		vtkConvexHull2D_CalculateConvexHull_02(inPoints?.GetCppThis() ?? default(HandleRef), outPoints?.GetCppThis() ?? default(HandleRef), minimumHullSize);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexHull2D_GetHullShape_03(HandleRef pThis);

	/// <summary>
	/// Set the shape of the hull to BoundingRectangle or ConvexHull.
	/// </summary>
	public virtual int GetHullShape()
	{
		return vtkConvexHull2D_GetHullShape_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexHull2D_GetHullShapeMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set the shape of the hull to BoundingRectangle or ConvexHull.
	/// </summary>
	public virtual int GetHullShapeMaxValue()
	{
		return vtkConvexHull2D_GetHullShapeMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexHull2D_GetHullShapeMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set the shape of the hull to BoundingRectangle or ConvexHull.
	/// </summary>
	public virtual int GetHullShapeMinValue()
	{
		return vtkConvexHull2D_GetHullShapeMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkConvexHull2D_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// The modified time of this filter.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkConvexHull2D_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexHull2D_GetMinHullSizeInDisplay_07(HandleRef pThis);

	/// <summary>
	/// Set the minimum x,y-dimensions of each hull in pixels. You must also set a
	/// vtkRenderer. Defaults to 1. Set to 0 to disable.
	/// </summary>
	public virtual int GetMinHullSizeInDisplay()
	{
		return vtkConvexHull2D_GetMinHullSizeInDisplay_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexHull2D_GetMinHullSizeInDisplayMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set the minimum x,y-dimensions of each hull in pixels. You must also set a
	/// vtkRenderer. Defaults to 1. Set to 0 to disable.
	/// </summary>
	public virtual int GetMinHullSizeInDisplayMaxValue()
	{
		return vtkConvexHull2D_GetMinHullSizeInDisplayMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexHull2D_GetMinHullSizeInDisplayMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set the minimum x,y-dimensions of each hull in pixels. You must also set a
	/// vtkRenderer. Defaults to 1. Set to 0 to disable.
	/// </summary>
	public virtual int GetMinHullSizeInDisplayMinValue()
	{
		return vtkConvexHull2D_GetMinHullSizeInDisplayMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConvexHull2D_GetMinHullSizeInWorld_10(HandleRef pThis);

	/// <summary>
	/// Set the minimum x,y-dimensions of each hull in world coordinates. Defaults
	/// to 1.0. Set to 0.0 to disable.
	/// </summary>
	public virtual double GetMinHullSizeInWorld()
	{
		return vtkConvexHull2D_GetMinHullSizeInWorld_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConvexHull2D_GetMinHullSizeInWorldMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set the minimum x,y-dimensions of each hull in world coordinates. Defaults
	/// to 1.0. Set to 0.0 to disable.
	/// </summary>
	public virtual double GetMinHullSizeInWorldMaxValue()
	{
		return vtkConvexHull2D_GetMinHullSizeInWorldMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConvexHull2D_GetMinHullSizeInWorldMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set the minimum x,y-dimensions of each hull in world coordinates. Defaults
	/// to 1.0. Set to 0.0 to disable.
	/// </summary>
	public virtual double GetMinHullSizeInWorldMinValue()
	{
		return vtkConvexHull2D_GetMinHullSizeInWorldMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConvexHull2D_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkConvexHull2D_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConvexHull2D_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkConvexHull2D_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkConvexHull2D_GetOutline_15(HandleRef pThis);

	/// <summary>
	/// Produce an outline (polyline) of the hull on output port 1.
	/// </summary>
	public virtual bool GetOutline()
	{
		return (vtkConvexHull2D_GetOutline_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvexHull2D_GetRenderer_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Renderer needed for MinHullSizeInDisplay calculation. Not reference counted.
	/// </summary>
	public vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvexHull2D_GetRenderer_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConvexHull2D_GetScaleFactor_17(HandleRef pThis);

	/// <summary>
	/// Scale the hull by the amount specified. Defaults to 1.0.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkConvexHull2D_GetScaleFactor_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexHull2D_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkConvexHull2D_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexHull2D_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkConvexHull2D_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvexHull2D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkConvexHull2D NewInstance()
	{
		vtkConvexHull2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvexHull2D_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConvexHull2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexHull2D_OutlineOff_22(HandleRef pThis);

	/// <summary>
	/// Produce an outline (polyline) of the hull on output port 1.
	/// </summary>
	public virtual void OutlineOff()
	{
		vtkConvexHull2D_OutlineOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexHull2D_OutlineOn_23(HandleRef pThis);

	/// <summary>
	/// Produce an outline (polyline) of the hull on output port 1.
	/// </summary>
	public virtual void OutlineOn()
	{
		vtkConvexHull2D_OutlineOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvexHull2D_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConvexHull2D SafeDownCast(vtkObjectBase o)
	{
		vtkConvexHull2D vtkConvexHull2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvexHull2D_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConvexHull2D2 = (vtkConvexHull2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConvexHull2D2.Register(null);
			}
		}
		return vtkConvexHull2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexHull2D_SetHullShape_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the shape of the hull to BoundingRectangle or ConvexHull.
	/// </summary>
	public virtual void SetHullShape(int _arg)
	{
		vtkConvexHull2D_SetHullShape_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexHull2D_SetMinHullSizeInDisplay_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the minimum x,y-dimensions of each hull in pixels. You must also set a
	/// vtkRenderer. Defaults to 1. Set to 0 to disable.
	/// </summary>
	public virtual void SetMinHullSizeInDisplay(int _arg)
	{
		vtkConvexHull2D_SetMinHullSizeInDisplay_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexHull2D_SetMinHullSizeInWorld_27(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the minimum x,y-dimensions of each hull in world coordinates. Defaults
	/// to 1.0. Set to 0.0 to disable.
	/// </summary>
	public virtual void SetMinHullSizeInWorld(double _arg)
	{
		vtkConvexHull2D_SetMinHullSizeInWorld_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexHull2D_SetOutline_28(HandleRef pThis, byte _arg);

	/// <summary>
	/// Produce an outline (polyline) of the hull on output port 1.
	/// </summary>
	public virtual void SetOutline(bool _arg)
	{
		vtkConvexHull2D_SetOutline_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexHull2D_SetRenderer_29(HandleRef pThis, HandleRef renderer);

	/// <summary>
	/// Renderer needed for MinHullSizeInDisplay calculation. Not reference counted.
	/// </summary>
	public void SetRenderer(vtkRenderer renderer)
	{
		vtkConvexHull2D_SetRenderer_29(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexHull2D_SetScaleFactor_30(HandleRef pThis, double _arg);

	/// <summary>
	/// Scale the hull by the amount specified. Defaults to 1.0.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkConvexHull2D_SetScaleFactor_30(GetCppThis(), _arg);
	}
}
