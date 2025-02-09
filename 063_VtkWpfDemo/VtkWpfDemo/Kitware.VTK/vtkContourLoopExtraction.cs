using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContourLoopExtraction
/// </summary>
/// <remarks>
///    extract closed loops (polygons) from lines and polylines
///
/// This filter takes an input consisting of lines and polylines and
/// constructs polygons (i.e., closed loops) from them. It combines some of
/// the capability of connectivity filters and the line stripper to produce
/// manifold loops that are suitable for geometric operations. For example,
/// the vtkCookieCutter works well with this filter.
///
/// Note that the input structure for this filter consists of points and line
/// or polyline cells. All other topological types (verts, polygons, triangle
/// strips) are ignored. The output of this filter is by default manifold
/// polygons. Note however, that optionally polyline loops may also be output
/// if requested.
///
/// @warning
/// Although the loops are constructed in 3-space, a normal vector must be
/// supplied to help choose a turn direction when multiple choices are
/// possible. By default the normal vector is n={0,0,1} but may be user
/// specified. Note also that some filters require that the loops are located
/// in the z=constant or z=0 plane. Hence a transform filter of some sort may
/// be necesssary to project the loops to a plane.
///
/// @warning
/// Note that lines that do not close in on themselves can be optionally
/// forced closed. This occurs when for example, 2D contours end and begin at
/// the boundaries of data. By forcing closure, the last point is joined to
/// the first point (with boundary points possibly added). Note that there are
/// different closure modes: 1) do not close (and hence reject the polygon);
/// 2) close along the dataset boundaries (i.e., the bounding box of a dataset
/// used to generate the contour lines); and 3) close all open loops by
/// connectiong the first and last point. If Option #2 is chosen, only loops
/// that start and end on either a horizontal or vertical boundary are closed.
///
/// @warning
/// Scalar thresholding can be enabled. If enabled, then only those loops with
/// *any" scalar point data within the thresholded range are extracted.
///
/// @warning
/// Any detached lines forming degenerate loops of defined by two points or
/// less are discarded. Non-manifold junctions are broken into separate,
/// independent loops.
///
/// @warning
/// Boundary closure only works if the end points are both on a vertical
/// boundary or horizontal boundary. Otherwise new points would have to be
/// added which this filter does not (currently) do.
///
/// </remarks>
/// <seealso>
///
/// vtkCookieCutter vtkFlyingEdges2D vtkMarchingSquares vtkFeatureEdges
/// vtkConnectivityFilter vtkPolyDataConnectivityFilter
/// vtkDiscreteFlyingEdges2D vtkStripper vtkImprintFilter
/// vtkCleanPolyData vtkStaticCleanPolyData
/// </seealso>
public class vtkContourLoopExtraction : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContourLoopExtraction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContourLoopExtraction()
	{
		MRClassNameKey = "class vtkContourLoopExtraction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourLoopExtraction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContourLoopExtraction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourLoopExtraction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print and provide type information.
	/// </summary>
	public new static vtkContourLoopExtraction New()
	{
		vtkContourLoopExtraction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourLoopExtraction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourLoopExtraction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods to instantiate, print and provide type information.
	/// </summary>
	public vtkContourLoopExtraction()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContourLoopExtraction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_CleanPointsOff_01(HandleRef pThis);

	/// <summary>
	/// Indicate whether to clean the output points. Cleaning means discarding
	/// any points that are unused by the output polylines or polygons. This
	/// results in a potential renumbering of the points. By default, cleaning
	/// points is on. (This feature is useful because some filters output
	/// points in addition to those used to represent output lines and
	/// polylines, and this method is faster than using
	/// vtkCleanPolyData/vtkStaticCleanPolyData).
	/// </summary>
	public virtual void CleanPointsOff()
	{
		vtkContourLoopExtraction_CleanPointsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_CleanPointsOn_02(HandleRef pThis);

	/// <summary>
	/// Indicate whether to clean the output points. Cleaning means discarding
	/// any points that are unused by the output polylines or polygons. This
	/// results in a potential renumbering of the points. By default, cleaning
	/// points is on. (This feature is useful because some filters output
	/// points in addition to those used to represent output lines and
	/// polylines, and this method is faster than using
	/// vtkCleanPolyData/vtkStaticCleanPolyData).
	/// </summary>
	public virtual void CleanPointsOn()
	{
		vtkContourLoopExtraction_CleanPointsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContourLoopExtraction_GetCleanPoints_03(HandleRef pThis);

	/// <summary>
	/// Indicate whether to clean the output points. Cleaning means discarding
	/// any points that are unused by the output polylines or polygons. This
	/// results in a potential renumbering of the points. By default, cleaning
	/// points is on. (This feature is useful because some filters output
	/// points in addition to those used to represent output lines and
	/// polylines, and this method is faster than using
	/// vtkCleanPolyData/vtkStaticCleanPolyData).
	/// </summary>
	public virtual bool GetCleanPoints()
	{
		return (vtkContourLoopExtraction_GetCleanPoints_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLoopExtraction_GetLoopClosure_04(HandleRef pThis);

	/// <summary>
	/// Specify whether to close loops or not. All non-closed loops can be
	/// rejected; boundary loops (end points lie on vertical or horizontal
	/// porions of the boundary) can be closed (default); or all loops can be
	/// forced closed by connecting first and last points.
	/// </summary>
	public virtual int GetLoopClosure()
	{
		return vtkContourLoopExtraction_GetLoopClosure_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourLoopExtraction_GetLoopClosureAsString_05(HandleRef pThis);

	/// <summary>
	/// Specify whether to close loops or not. All non-closed loops can be
	/// rejected; boundary loops (end points lie on vertical or horizontal
	/// porions of the boundary) can be closed (default); or all loops can be
	/// forced closed by connecting first and last points.
	/// </summary>
	public string GetLoopClosureAsString()
	{
		return Marshal.PtrToStringAnsi(vtkContourLoopExtraction_GetLoopClosureAsString_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLoopExtraction_GetLoopClosureMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Specify whether to close loops or not. All non-closed loops can be
	/// rejected; boundary loops (end points lie on vertical or horizontal
	/// porions of the boundary) can be closed (default); or all loops can be
	/// forced closed by connecting first and last points.
	/// </summary>
	public virtual int GetLoopClosureMaxValue()
	{
		return vtkContourLoopExtraction_GetLoopClosureMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLoopExtraction_GetLoopClosureMinValue_07(HandleRef pThis);

	/// <summary>
	/// Specify whether to close loops or not. All non-closed loops can be
	/// rejected; boundary loops (end points lie on vertical or horizontal
	/// porions of the boundary) can be closed (default); or all loops can be
	/// forced closed by connecting first and last points.
	/// </summary>
	public virtual int GetLoopClosureMinValue()
	{
		return vtkContourLoopExtraction_GetLoopClosureMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourLoopExtraction_GetNormal_08(HandleRef pThis);

	/// <summary>
	/// Set the normal vector used to orient the algorithm (controlling turns
	/// around the loop). By default the normal points in the +z direction.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkContourLoopExtraction_GetNormal_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_GetNormal_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the normal vector used to orient the algorithm (controlling turns
	/// around the loop). By default the normal points in the +z direction.
	/// </summary>
	public virtual void GetNormal(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkContourLoopExtraction_GetNormal_09(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_GetNormal_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the normal vector used to orient the algorithm (controlling turns
	/// around the loop). By default the normal points in the +z direction.
	/// </summary>
	public virtual void GetNormal(IntPtr _arg)
	{
		vtkContourLoopExtraction_GetNormal_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourLoopExtraction_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, print and provide type information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContourLoopExtraction_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourLoopExtraction_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Standard methods to instantiate, print and provide type information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContourLoopExtraction_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLoopExtraction_GetOutputMode_13(HandleRef pThis);

	/// <summary>
	/// Specify the form of the output. Polygons can be output (default);
	/// polylines can be output (the first and last point is repeated); or both
	/// can be output.
	/// </summary>
	public virtual int GetOutputMode()
	{
		return vtkContourLoopExtraction_GetOutputMode_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourLoopExtraction_GetOutputModeAsString_14(HandleRef pThis);

	/// <summary>
	/// Specify the form of the output. Polygons can be output (default);
	/// polylines can be output (the first and last point is repeated); or both
	/// can be output.
	/// </summary>
	public string GetOutputModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkContourLoopExtraction_GetOutputModeAsString_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLoopExtraction_GetOutputModeMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Specify the form of the output. Polygons can be output (default);
	/// polylines can be output (the first and last point is repeated); or both
	/// can be output.
	/// </summary>
	public virtual int GetOutputModeMaxValue()
	{
		return vtkContourLoopExtraction_GetOutputModeMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLoopExtraction_GetOutputModeMinValue_16(HandleRef pThis);

	/// <summary>
	/// Specify the form of the output. Polygons can be output (default);
	/// polylines can be output (the first and last point is repeated); or both
	/// can be output.
	/// </summary>
	public virtual int GetOutputModeMinValue()
	{
		return vtkContourLoopExtraction_GetOutputModeMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourLoopExtraction_GetScalarRange_17(HandleRef pThis);

	/// <summary>
	/// Set the scalar range to use to extract loop based on scalar
	/// thresholding.  If any scalar, point data, in the loop falls into the
	/// scalar range given, then the loop is extracted.
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkContourLoopExtraction_GetScalarRange_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_GetScalarRange_18(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the scalar range to use to extract loop based on scalar
	/// thresholding.  If any scalar, point data, in the loop falls into the
	/// scalar range given, then the loop is extracted.
	/// </summary>
	public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
	{
		vtkContourLoopExtraction_GetScalarRange_18(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_GetScalarRange_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range to use to extract loop based on scalar
	/// thresholding.  If any scalar, point data, in the loop falls into the
	/// scalar range given, then the loop is extracted.
	/// </summary>
	public virtual void GetScalarRange(IntPtr _arg)
	{
		vtkContourLoopExtraction_GetScalarRange_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContourLoopExtraction_GetScalarThresholding_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of loops based on scalar thresholding.  Loops
	/// with scalar values in a specified range can be extracted. If no scalars
	/// are available from the input than this data member is ignored.
	/// </summary>
	public virtual bool GetScalarThresholding()
	{
		return (vtkContourLoopExtraction_GetScalarThresholding_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLoopExtraction_IsA_21(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, print and provide type information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContourLoopExtraction_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLoopExtraction_IsTypeOf_22(string type);

	/// <summary>
	/// Standard methods to instantiate, print and provide type information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContourLoopExtraction_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourLoopExtraction_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print and provide type information.
	/// </summary>
	public new vtkContourLoopExtraction NewInstance()
	{
		vtkContourLoopExtraction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourLoopExtraction_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourLoopExtraction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourLoopExtraction_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print and provide type information.
	/// </summary>
	public new static vtkContourLoopExtraction SafeDownCast(vtkObjectBase o)
	{
		vtkContourLoopExtraction vtkContourLoopExtraction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourLoopExtraction_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourLoopExtraction2 = (vtkContourLoopExtraction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourLoopExtraction2.Register(null);
			}
		}
		return vtkContourLoopExtraction2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_ScalarThresholdingOff_26(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of loops based on scalar thresholding.  Loops
	/// with scalar values in a specified range can be extracted. If no scalars
	/// are available from the input than this data member is ignored.
	/// </summary>
	public virtual void ScalarThresholdingOff()
	{
		vtkContourLoopExtraction_ScalarThresholdingOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_ScalarThresholdingOn_27(HandleRef pThis);

	/// <summary>
	/// Turn on/off the extraction of loops based on scalar thresholding.  Loops
	/// with scalar values in a specified range can be extracted. If no scalars
	/// are available from the input than this data member is ignored.
	/// </summary>
	public virtual void ScalarThresholdingOn()
	{
		vtkContourLoopExtraction_ScalarThresholdingOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetCleanPoints_28(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to clean the output points. Cleaning means discarding
	/// any points that are unused by the output polylines or polygons. This
	/// results in a potential renumbering of the points. By default, cleaning
	/// points is on. (This feature is useful because some filters output
	/// points in addition to those used to represent output lines and
	/// polylines, and this method is faster than using
	/// vtkCleanPolyData/vtkStaticCleanPolyData).
	/// </summary>
	public virtual void SetCleanPoints(bool _arg)
	{
		vtkContourLoopExtraction_SetCleanPoints_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetLoopClosure_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to close loops or not. All non-closed loops can be
	/// rejected; boundary loops (end points lie on vertical or horizontal
	/// porions of the boundary) can be closed (default); or all loops can be
	/// forced closed by connecting first and last points.
	/// </summary>
	public virtual void SetLoopClosure(int _arg)
	{
		vtkContourLoopExtraction_SetLoopClosure_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetLoopClosureToAll_30(HandleRef pThis);

	/// <summary>
	/// Specify whether to close loops or not. All non-closed loops can be
	/// rejected; boundary loops (end points lie on vertical or horizontal
	/// porions of the boundary) can be closed (default); or all loops can be
	/// forced closed by connecting first and last points.
	/// </summary>
	public void SetLoopClosureToAll()
	{
		vtkContourLoopExtraction_SetLoopClosureToAll_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetLoopClosureToBoundary_31(HandleRef pThis);

	/// <summary>
	/// Specify whether to close loops or not. All non-closed loops can be
	/// rejected; boundary loops (end points lie on vertical or horizontal
	/// porions of the boundary) can be closed (default); or all loops can be
	/// forced closed by connecting first and last points.
	/// </summary>
	public void SetLoopClosureToBoundary()
	{
		vtkContourLoopExtraction_SetLoopClosureToBoundary_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetLoopClosureToOff_32(HandleRef pThis);

	/// <summary>
	/// Specify whether to close loops or not. All non-closed loops can be
	/// rejected; boundary loops (end points lie on vertical or horizontal
	/// porions of the boundary) can be closed (default); or all loops can be
	/// forced closed by connecting first and last points.
	/// </summary>
	public void SetLoopClosureToOff()
	{
		vtkContourLoopExtraction_SetLoopClosureToOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetNormal_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the normal vector used to orient the algorithm (controlling turns
	/// around the loop). By default the normal points in the +z direction.
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkContourLoopExtraction_SetNormal_33(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetNormal_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the normal vector used to orient the algorithm (controlling turns
	/// around the loop). By default the normal points in the +z direction.
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkContourLoopExtraction_SetNormal_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetOutputMode_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the form of the output. Polygons can be output (default);
	/// polylines can be output (the first and last point is repeated); or both
	/// can be output.
	/// </summary>
	public virtual void SetOutputMode(int _arg)
	{
		vtkContourLoopExtraction_SetOutputMode_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetOutputModeToBoth_36(HandleRef pThis);

	/// <summary>
	/// Specify the form of the output. Polygons can be output (default);
	/// polylines can be output (the first and last point is repeated); or both
	/// can be output.
	/// </summary>
	public void SetOutputModeToBoth()
	{
		vtkContourLoopExtraction_SetOutputModeToBoth_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetOutputModeToPolygons_37(HandleRef pThis);

	/// <summary>
	/// Specify the form of the output. Polygons can be output (default);
	/// polylines can be output (the first and last point is repeated); or both
	/// can be output.
	/// </summary>
	public void SetOutputModeToPolygons()
	{
		vtkContourLoopExtraction_SetOutputModeToPolygons_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetOutputModeToPolylines_38(HandleRef pThis);

	/// <summary>
	/// Specify the form of the output. Polygons can be output (default);
	/// polylines can be output (the first and last point is repeated); or both
	/// can be output.
	/// </summary>
	public void SetOutputModeToPolylines()
	{
		vtkContourLoopExtraction_SetOutputModeToPolylines_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetScalarRange_39(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the scalar range to use to extract loop based on scalar
	/// thresholding.  If any scalar, point data, in the loop falls into the
	/// scalar range given, then the loop is extracted.
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkContourLoopExtraction_SetScalarRange_39(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetScalarRange_40(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range to use to extract loop based on scalar
	/// thresholding.  If any scalar, point data, in the loop falls into the
	/// scalar range given, then the loop is extracted.
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkContourLoopExtraction_SetScalarRange_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLoopExtraction_SetScalarThresholding_41(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the extraction of loops based on scalar thresholding.  Loops
	/// with scalar values in a specified range can be extracted. If no scalars
	/// are available from the input than this data member is ignored.
	/// </summary>
	public virtual void SetScalarThresholding(bool _arg)
	{
		vtkContourLoopExtraction_SetScalarThresholding_41(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
