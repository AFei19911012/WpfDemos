using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkClipClosedSurface
/// </summary>
/// <remarks>
///    Clip a closed surface with a plane collection
///
/// vtkClipClosedSurface will clip a closed polydata surface with a
/// collection of clipping planes.  It will produce a new closed surface
/// by creating new polygonal faces where the input data was clipped.
///
/// Non-manifold surfaces should not be used as input for this filter.
/// The input surface should have no open edges, and must not have any
/// edges that are shared by more than two faces.  The vtkFeatureEdges
/// filter can be used to verify that a data set satisfies these conditions.
/// In addition, the input surface should not self-intersect, meaning
/// that the faces of the surface should only touch at their edges.
///
/// If GenerateOutline is on, this filter will generate an outline wherever
/// the clipping planes intersect the data.  The ScalarMode option
/// will add cell scalars to the output, so that the generated faces
/// can be visualized in a different color from the original surface.
///
/// @warning
/// The triangulation of new faces is done in O(n) time for simple convex
/// inputs, but for non-convex inputs the worst-case time is O(n^2*m^2)
/// where n is the number of points and m is the number of 3D cavities.
/// The best triangulation algorithms, in contrast, are O(n log n).
/// There are also rare cases where the triangulation will fail to produce
/// a watertight output.  Turn on TriangulationErrorDisplay to be notified
/// of these failures.
///
/// </remarks>
/// <seealso>
///
/// vtkOutlineFilter vtkOutlineSource vtkVolumeOutlineSource
/// vtkContourTriangulator
///
/// @par Thanks:
/// Thanks to David Gobbi for contributing this class to VTK.
/// </seealso>
public class vtkClipClosedSurface : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkClipClosedSurface";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkClipClosedSurface()
	{
		MRClassNameKey = "class vtkClipClosedSurface";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipClosedSurface"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkClipClosedSurface(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipClosedSurface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkClipClosedSurface New()
	{
		vtkClipClosedSurface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipClosedSurface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClipClosedSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public vtkClipClosedSurface()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkClipClosedSurface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_GenerateFacesOff_01(HandleRef pThis);

	/// <summary>
	/// Set whether to generate polygonal faces for the output.  This is
	/// on by default.  If it is off, then the output will have no polys.
	/// </summary>
	public virtual void GenerateFacesOff()
	{
		vtkClipClosedSurface_GenerateFacesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_GenerateFacesOn_02(HandleRef pThis);

	/// <summary>
	/// Set whether to generate polygonal faces for the output.  This is
	/// on by default.  If it is off, then the output will have no polys.
	/// </summary>
	public virtual void GenerateFacesOn()
	{
		vtkClipClosedSurface_GenerateFacesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_GenerateOutlineOff_03(HandleRef pThis);

	/// <summary>
	/// Set whether to generate an outline wherever an input face was
	/// cut by a plane.  This is off by default.
	/// </summary>
	public virtual void GenerateOutlineOff()
	{
		vtkClipClosedSurface_GenerateOutlineOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_GenerateOutlineOn_04(HandleRef pThis);

	/// <summary>
	/// Set whether to generate an outline wherever an input face was
	/// cut by a plane.  This is off by default.
	/// </summary>
	public virtual void GenerateOutlineOn()
	{
		vtkClipClosedSurface_GenerateOutlineOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipClosedSurface_GetActivePlaneColor_05(HandleRef pThis);

	/// <summary>
	/// Set the color for any new geometry produced by clipping with the
	/// ActivePlane, if ActivePlaneId is set.  Default is yellow.
	/// Requires SetScalarModeToColors.
	/// </summary>
	public virtual double[] GetActivePlaneColor()
	{
		IntPtr intPtr = vtkClipClosedSurface_GetActivePlaneColor_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_GetActivePlaneColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the color for any new geometry produced by clipping with the
	/// ActivePlane, if ActivePlaneId is set.  Default is yellow.
	/// Requires SetScalarModeToColors.
	/// </summary>
	public virtual void GetActivePlaneColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkClipClosedSurface_GetActivePlaneColor_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_GetActivePlaneColor_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color for any new geometry produced by clipping with the
	/// ActivePlane, if ActivePlaneId is set.  Default is yellow.
	/// Requires SetScalarModeToColors.
	/// </summary>
	public virtual void GetActivePlaneColor(IntPtr _arg)
	{
		vtkClipClosedSurface_GetActivePlaneColor_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipClosedSurface_GetActivePlaneId_08(HandleRef pThis);

	/// <summary>
	/// Set the active plane, so that the clipping from that plane can be
	/// displayed in a different color.  Set this to -1 if there is no active
	/// plane.  The default value is -1.
	/// </summary>
	public virtual int GetActivePlaneId()
	{
		return vtkClipClosedSurface_GetActivePlaneId_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipClosedSurface_GetBaseColor_09(HandleRef pThis);

	/// <summary>
	/// Set the color for all cells were part of the original geometry.
	/// If the input data already has color cell scalars, then those
	/// values will be used and parameter will be ignored.  The default color
	/// is red.  Requires SetScalarModeToColors.
	/// </summary>
	public virtual double[] GetBaseColor()
	{
		IntPtr intPtr = vtkClipClosedSurface_GetBaseColor_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_GetBaseColor_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the color for all cells were part of the original geometry.
	/// If the input data already has color cell scalars, then those
	/// values will be used and parameter will be ignored.  The default color
	/// is red.  Requires SetScalarModeToColors.
	/// </summary>
	public virtual void GetBaseColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkClipClosedSurface_GetBaseColor_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_GetBaseColor_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color for all cells were part of the original geometry.
	/// If the input data already has color cell scalars, then those
	/// values will be used and parameter will be ignored.  The default color
	/// is red.  Requires SetScalarModeToColors.
	/// </summary>
	public virtual void GetBaseColor(IntPtr _arg)
	{
		vtkClipClosedSurface_GetBaseColor_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipClosedSurface_GetClipColor_12(HandleRef pThis);

	/// <summary>
	/// Set the color for any new geometry, either faces or outlines, that are
	/// created as a result of the clipping. The default color is orange.
	/// Requires SetScalarModeToColors.
	/// </summary>
	public virtual double[] GetClipColor()
	{
		IntPtr intPtr = vtkClipClosedSurface_GetClipColor_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_GetClipColor_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the color for any new geometry, either faces or outlines, that are
	/// created as a result of the clipping. The default color is orange.
	/// Requires SetScalarModeToColors.
	/// </summary>
	public virtual void GetClipColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkClipClosedSurface_GetClipColor_13(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_GetClipColor_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color for any new geometry, either faces or outlines, that are
	/// created as a result of the clipping. The default color is orange.
	/// Requires SetScalarModeToColors.
	/// </summary>
	public virtual void GetClipColor(IntPtr _arg)
	{
		vtkClipClosedSurface_GetClipColor_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipClosedSurface_GetClippingPlanes_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the vtkPlaneCollection that holds the clipping planes.
	/// </summary>
	public virtual vtkPlaneCollection GetClippingPlanes()
	{
		vtkPlaneCollection vtkPlaneCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipClosedSurface_GetClippingPlanes_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipClosedSurface_GetGenerateFaces_16(HandleRef pThis);

	/// <summary>
	/// Set whether to generate polygonal faces for the output.  This is
	/// on by default.  If it is off, then the output will have no polys.
	/// </summary>
	public virtual int GetGenerateFaces()
	{
		return vtkClipClosedSurface_GetGenerateFaces_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipClosedSurface_GetGenerateOutline_17(HandleRef pThis);

	/// <summary>
	/// Set whether to generate an outline wherever an input face was
	/// cut by a plane.  This is off by default.
	/// </summary>
	public virtual int GetGenerateOutline()
	{
		return vtkClipClosedSurface_GetGenerateOutline_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClipClosedSurface_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkClipClosedSurface_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClipClosedSurface_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkClipClosedSurface_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipClosedSurface_GetPassPointData_20(HandleRef pThis);

	/// <summary>
	/// Pass the point data to the output.  Point data will be interpolated
	/// when new points are generated.  This is off by default.
	/// </summary>
	public virtual int GetPassPointData()
	{
		return vtkClipClosedSurface_GetPassPointData_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipClosedSurface_GetScalarMode_21(HandleRef pThis);

	/// <summary>
	/// Set whether to add cell scalars, so that new faces and outlines
	/// can be distinguished from original faces and lines.  The options
	/// are "None", "Colors", and "Labels".  For the "Labels" option,
	/// a scalar value of "0" indicates an original cell, "1" indicates
	/// a new cell on a cut face, and "2" indicates a new cell on the
	/// ActivePlane as set by the SetActivePlane() method.  The default
	/// scalar mode is "None".
	/// </summary>
	public virtual int GetScalarMode()
	{
		return vtkClipClosedSurface_GetScalarMode_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipClosedSurface_GetScalarModeAsString_22(HandleRef pThis);

	/// <summary>
	/// Set whether to add cell scalars, so that new faces and outlines
	/// can be distinguished from original faces and lines.  The options
	/// are "None", "Colors", and "Labels".  For the "Labels" option,
	/// a scalar value of "0" indicates an original cell, "1" indicates
	/// a new cell on a cut face, and "2" indicates a new cell on the
	/// ActivePlane as set by the SetActivePlane() method.  The default
	/// scalar mode is "None".
	/// </summary>
	public string GetScalarModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkClipClosedSurface_GetScalarModeAsString_22(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipClosedSurface_GetScalarModeMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set whether to add cell scalars, so that new faces and outlines
	/// can be distinguished from original faces and lines.  The options
	/// are "None", "Colors", and "Labels".  For the "Labels" option,
	/// a scalar value of "0" indicates an original cell, "1" indicates
	/// a new cell on a cut face, and "2" indicates a new cell on the
	/// ActivePlane as set by the SetActivePlane() method.  The default
	/// scalar mode is "None".
	/// </summary>
	public virtual int GetScalarModeMaxValue()
	{
		return vtkClipClosedSurface_GetScalarModeMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipClosedSurface_GetScalarModeMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set whether to add cell scalars, so that new faces and outlines
	/// can be distinguished from original faces and lines.  The options
	/// are "None", "Colors", and "Labels".  For the "Labels" option,
	/// a scalar value of "0" indicates an original cell, "1" indicates
	/// a new cell on a cut face, and "2" indicates a new cell on the
	/// ActivePlane as set by the SetActivePlane() method.  The default
	/// scalar mode is "None".
	/// </summary>
	public virtual int GetScalarModeMinValue()
	{
		return vtkClipClosedSurface_GetScalarModeMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkClipClosedSurface_GetTolerance_25(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for creating new points while clipping.  If the
	/// tolerance is too small, then degenerate triangles might be produced.
	/// The default tolerance is 1e-6.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkClipClosedSurface_GetTolerance_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipClosedSurface_GetTriangulationErrorDisplay_26(HandleRef pThis);

	/// <summary>
	/// Generate errors when the triangulation fails.  Usually the
	/// triangulation errors are too small to see, but they result in
	/// a surface that is not watertight.  This option has no impact
	/// on performance.
	/// </summary>
	public virtual int GetTriangulationErrorDisplay()
	{
		return vtkClipClosedSurface_GetTriangulationErrorDisplay_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipClosedSurface_IsA_27(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkClipClosedSurface_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClipClosedSurface_IsTypeOf_28(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkClipClosedSurface_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipClosedSurface_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkClipClosedSurface NewInstance()
	{
		vtkClipClosedSurface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipClosedSurface_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClipClosedSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_PassPointDataOff_31(HandleRef pThis);

	/// <summary>
	/// Pass the point data to the output.  Point data will be interpolated
	/// when new points are generated.  This is off by default.
	/// </summary>
	public virtual void PassPointDataOff()
	{
		vtkClipClosedSurface_PassPointDataOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_PassPointDataOn_32(HandleRef pThis);

	/// <summary>
	/// Pass the point data to the output.  Point data will be interpolated
	/// when new points are generated.  This is off by default.
	/// </summary>
	public virtual void PassPointDataOn()
	{
		vtkClipClosedSurface_PassPointDataOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClipClosedSurface_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkClipClosedSurface SafeDownCast(vtkObjectBase o)
	{
		vtkClipClosedSurface vtkClipClosedSurface2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClipClosedSurface_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkClipClosedSurface2 = (vtkClipClosedSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkClipClosedSurface2.Register(null);
			}
		}
		return vtkClipClosedSurface2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetActivePlaneColor_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the color for any new geometry produced by clipping with the
	/// ActivePlane, if ActivePlaneId is set.  Default is yellow.
	/// Requires SetScalarModeToColors.
	/// </summary>
	public virtual void SetActivePlaneColor(double _arg1, double _arg2, double _arg3)
	{
		vtkClipClosedSurface_SetActivePlaneColor_34(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetActivePlaneColor_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color for any new geometry produced by clipping with the
	/// ActivePlane, if ActivePlaneId is set.  Default is yellow.
	/// Requires SetScalarModeToColors.
	/// </summary>
	public virtual void SetActivePlaneColor(IntPtr _arg)
	{
		vtkClipClosedSurface_SetActivePlaneColor_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetActivePlaneId_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the active plane, so that the clipping from that plane can be
	/// displayed in a different color.  Set this to -1 if there is no active
	/// plane.  The default value is -1.
	/// </summary>
	public virtual void SetActivePlaneId(int _arg)
	{
		vtkClipClosedSurface_SetActivePlaneId_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetBaseColor_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the color for all cells were part of the original geometry.
	/// If the input data already has color cell scalars, then those
	/// values will be used and parameter will be ignored.  The default color
	/// is red.  Requires SetScalarModeToColors.
	/// </summary>
	public virtual void SetBaseColor(double _arg1, double _arg2, double _arg3)
	{
		vtkClipClosedSurface_SetBaseColor_37(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetBaseColor_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color for all cells were part of the original geometry.
	/// If the input data already has color cell scalars, then those
	/// values will be used and parameter will be ignored.  The default color
	/// is red.  Requires SetScalarModeToColors.
	/// </summary>
	public virtual void SetBaseColor(IntPtr _arg)
	{
		vtkClipClosedSurface_SetBaseColor_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetClipColor_39(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the color for any new geometry, either faces or outlines, that are
	/// created as a result of the clipping. The default color is orange.
	/// Requires SetScalarModeToColors.
	/// </summary>
	public virtual void SetClipColor(double _arg1, double _arg2, double _arg3)
	{
		vtkClipClosedSurface_SetClipColor_39(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetClipColor_40(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color for any new geometry, either faces or outlines, that are
	/// created as a result of the clipping. The default color is orange.
	/// Requires SetScalarModeToColors.
	/// </summary>
	public virtual void SetClipColor(IntPtr _arg)
	{
		vtkClipClosedSurface_SetClipColor_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetClippingPlanes_41(HandleRef pThis, HandleRef planes);

	/// <summary>
	/// Set the vtkPlaneCollection that holds the clipping planes.
	/// </summary>
	public virtual void SetClippingPlanes(vtkPlaneCollection planes)
	{
		vtkClipClosedSurface_SetClippingPlanes_41(GetCppThis(), planes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetGenerateFaces_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to generate polygonal faces for the output.  This is
	/// on by default.  If it is off, then the output will have no polys.
	/// </summary>
	public virtual void SetGenerateFaces(int _arg)
	{
		vtkClipClosedSurface_SetGenerateFaces_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetGenerateOutline_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to generate an outline wherever an input face was
	/// cut by a plane.  This is off by default.
	/// </summary>
	public virtual void SetGenerateOutline(int _arg)
	{
		vtkClipClosedSurface_SetGenerateOutline_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetPassPointData_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Pass the point data to the output.  Point data will be interpolated
	/// when new points are generated.  This is off by default.
	/// </summary>
	public virtual void SetPassPointData(int _arg)
	{
		vtkClipClosedSurface_SetPassPointData_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetScalarMode_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to add cell scalars, so that new faces and outlines
	/// can be distinguished from original faces and lines.  The options
	/// are "None", "Colors", and "Labels".  For the "Labels" option,
	/// a scalar value of "0" indicates an original cell, "1" indicates
	/// a new cell on a cut face, and "2" indicates a new cell on the
	/// ActivePlane as set by the SetActivePlane() method.  The default
	/// scalar mode is "None".
	/// </summary>
	public virtual void SetScalarMode(int _arg)
	{
		vtkClipClosedSurface_SetScalarMode_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetScalarModeToColors_46(HandleRef pThis);

	/// <summary>
	/// Set whether to add cell scalars, so that new faces and outlines
	/// can be distinguished from original faces and lines.  The options
	/// are "None", "Colors", and "Labels".  For the "Labels" option,
	/// a scalar value of "0" indicates an original cell, "1" indicates
	/// a new cell on a cut face, and "2" indicates a new cell on the
	/// ActivePlane as set by the SetActivePlane() method.  The default
	/// scalar mode is "None".
	/// </summary>
	public void SetScalarModeToColors()
	{
		vtkClipClosedSurface_SetScalarModeToColors_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetScalarModeToLabels_47(HandleRef pThis);

	/// <summary>
	/// Set whether to add cell scalars, so that new faces and outlines
	/// can be distinguished from original faces and lines.  The options
	/// are "None", "Colors", and "Labels".  For the "Labels" option,
	/// a scalar value of "0" indicates an original cell, "1" indicates
	/// a new cell on a cut face, and "2" indicates a new cell on the
	/// ActivePlane as set by the SetActivePlane() method.  The default
	/// scalar mode is "None".
	/// </summary>
	public void SetScalarModeToLabels()
	{
		vtkClipClosedSurface_SetScalarModeToLabels_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetScalarModeToNone_48(HandleRef pThis);

	/// <summary>
	/// Set whether to add cell scalars, so that new faces and outlines
	/// can be distinguished from original faces and lines.  The options
	/// are "None", "Colors", and "Labels".  For the "Labels" option,
	/// a scalar value of "0" indicates an original cell, "1" indicates
	/// a new cell on a cut face, and "2" indicates a new cell on the
	/// ActivePlane as set by the SetActivePlane() method.  The default
	/// scalar mode is "None".
	/// </summary>
	public void SetScalarModeToNone()
	{
		vtkClipClosedSurface_SetScalarModeToNone_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetTolerance_49(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the tolerance for creating new points while clipping.  If the
	/// tolerance is too small, then degenerate triangles might be produced.
	/// The default tolerance is 1e-6.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkClipClosedSurface_SetTolerance_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_SetTriangulationErrorDisplay_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Generate errors when the triangulation fails.  Usually the
	/// triangulation errors are too small to see, but they result in
	/// a surface that is not watertight.  This option has no impact
	/// on performance.
	/// </summary>
	public virtual void SetTriangulationErrorDisplay(int _arg)
	{
		vtkClipClosedSurface_SetTriangulationErrorDisplay_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_TriangulationErrorDisplayOff_51(HandleRef pThis);

	/// <summary>
	/// Generate errors when the triangulation fails.  Usually the
	/// triangulation errors are too small to see, but they result in
	/// a surface that is not watertight.  This option has no impact
	/// on performance.
	/// </summary>
	public virtual void TriangulationErrorDisplayOff()
	{
		vtkClipClosedSurface_TriangulationErrorDisplayOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClipClosedSurface_TriangulationErrorDisplayOn_52(HandleRef pThis);

	/// <summary>
	/// Generate errors when the triangulation fails.  Usually the
	/// triangulation errors are too small to see, but they result in
	/// a surface that is not watertight.  This option has no impact
	/// on performance.
	/// </summary>
	public virtual void TriangulationErrorDisplayOn()
	{
		vtkClipClosedSurface_TriangulationErrorDisplayOn_52(GetCppThis());
	}
}
