using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProjectedTerrainPath
/// </summary>
/// <remarks>
///    project a polyline onto a terrain
///
/// vtkProjectedTerrainPath projects an input polyline onto a terrain. (The
/// terrain is defined by a 2D height image and is the second input to the
/// filter.) The polyline projection is controlled via several modes as
/// follows. 1) Simple mode projects the polyline points onto the terrain,
/// taking into account the height offset instance variable. 2) Non-occluded
/// mode insures that no parts of the polyline are occluded by the terrain
/// (e.g. a line passes through a mountain). This may require recursive
/// subdivision of the polyline. 3) Hug mode insures that the polyine points
/// remain within a constant distance from the surface. This may also require
/// recursive subdivision of the polyline. Note that both non-occluded mode
/// and hug mode also take into account the height offset, so it is possible
/// to create paths that hug terrain a certain distance above it. To use this
/// filter, define two inputs: 1) a polyline, and 2) an image whose scalar
/// values represent a height field. Then specify the mode, and the height
/// offset to use.
///
/// An description of the algorithm is as follows. The filter begins by
/// projecting the polyline points to the image (offset by the specified
/// height offset).  If the mode is non-occluded or hug, then the maximum
/// error along each line segment is computed and placed into a priority
/// queue. Each line segment is then split at the point of maximum error, and
/// the two new line segments are evaluated for maximum error. This process
/// continues until the line is not occluded by the terrain (non-occluded
/// mode) or satisfies the error on variation from the surface (hug
/// mode). (Note this process is repeated for each polyline in the
/// input. Also, the maximum error is computed in two parts: a maximum
/// positive error and maximum negative error. If the polyline is above the
/// terrain--i.e., the height offset is positive--in non-occluded or hug mode
/// all negative errors are eliminated. If the polyline is below the
/// terrain--i.e., the height offset is negative--in non-occluded or hug mode
/// all positive errors are eliminated.)
///
/// @warning
/// This algorithm requires the entire input image to be in memory, hence it
/// may not work for extremely large images.
///
/// @warning
/// The input height image is assumed to be positioned in the x-y plane so the
/// scalar value is the z-coordinate, height value.
///
/// @warning
/// A priority queue is used so that the 1) the total number of line segments
/// can be controlled, and 2) the algorithm can terminate when the errors in
/// the queue are less than the specified error tolerance.
///
/// </remarks>
/// <seealso>
///
/// vtkGreedyTerrainDecimation
/// </seealso>
public class vtkProjectedTerrainPath : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Specify the second input (the terrain) onto which the polyline(s) should be projected.
	/// Note: vtkImageData* is required
	/// </summary>
	public enum HUG_PROJECTION_WrapperEnum
	{
		/// <summary>enum member</summary>
		HUG_PROJECTION = 2,
		/// <summary>enum member</summary>
		NONOCCLUDED_PROJECTION = 1,
		/// <summary>enum member</summary>
		SIMPLE_PROJECTION = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProjectedTerrainPath";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProjectedTerrainPath()
	{
		MRClassNameKey = "class vtkProjectedTerrainPath";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectedTerrainPath"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProjectedTerrainPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTerrainPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkProjectedTerrainPath New()
	{
		vtkProjectedTerrainPath result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectedTerrainPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkProjectedTerrainPath()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProjectedTerrainPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProjectedTerrainPath_GetHeightOffset_01(HandleRef pThis);

	/// <summary>
	/// This is the height above (or below) the terrain that the projected
	/// path should be. Positive values indicate distances above the terrain;
	/// negative values indicate distances below the terrain.
	/// </summary>
	public virtual double GetHeightOffset()
	{
		return vtkProjectedTerrainPath_GetHeightOffset_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProjectedTerrainPath_GetHeightTolerance_02(HandleRef pThis);

	/// <summary>
	/// This is the allowable variation in the altitude of the path
	/// with respect to the variation in the terrain. It only comes
	/// into play if the hug projection mode is enabled.
	/// </summary>
	public virtual double GetHeightTolerance()
	{
		return vtkProjectedTerrainPath_GetHeightTolerance_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProjectedTerrainPath_GetHeightToleranceMaxValue_03(HandleRef pThis);

	/// <summary>
	/// This is the allowable variation in the altitude of the path
	/// with respect to the variation in the terrain. It only comes
	/// into play if the hug projection mode is enabled.
	/// </summary>
	public virtual double GetHeightToleranceMaxValue()
	{
		return vtkProjectedTerrainPath_GetHeightToleranceMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProjectedTerrainPath_GetHeightToleranceMinValue_04(HandleRef pThis);

	/// <summary>
	/// This is the allowable variation in the altitude of the path
	/// with respect to the variation in the terrain. It only comes
	/// into play if the hug projection mode is enabled.
	/// </summary>
	public virtual double GetHeightToleranceMinValue()
	{
		return vtkProjectedTerrainPath_GetHeightToleranceMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectedTerrainPath_GetMaximumNumberOfLines_05(HandleRef pThis);

	/// <summary>
	/// This instance variable can be used to limit the total number of line
	/// segments created during subdivision. Note that the number of input line
	/// segments will be the minimum number that cab be output.
	/// </summary>
	public virtual long GetMaximumNumberOfLines()
	{
		return vtkProjectedTerrainPath_GetMaximumNumberOfLines_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectedTerrainPath_GetMaximumNumberOfLinesMaxValue_06(HandleRef pThis);

	/// <summary>
	/// This instance variable can be used to limit the total number of line
	/// segments created during subdivision. Note that the number of input line
	/// segments will be the minimum number that cab be output.
	/// </summary>
	public virtual long GetMaximumNumberOfLinesMaxValue()
	{
		return vtkProjectedTerrainPath_GetMaximumNumberOfLinesMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectedTerrainPath_GetMaximumNumberOfLinesMinValue_07(HandleRef pThis);

	/// <summary>
	/// This instance variable can be used to limit the total number of line
	/// segments created during subdivision. Note that the number of input line
	/// segments will be the minimum number that cab be output.
	/// </summary>
	public virtual long GetMaximumNumberOfLinesMinValue()
	{
		return vtkProjectedTerrainPath_GetMaximumNumberOfLinesMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectedTerrainPath_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProjectedTerrainPath_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectedTerrainPath_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProjectedTerrainPath_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectedTerrainPath_GetProjectionMode_10(HandleRef pThis);

	/// <summary>
	/// Determine how to control the projection process. Simple projection
	/// just projects the original polyline points. Non-occluded projection
	/// insures that the polyline does not intersect the terrain surface.
	/// Hug projection is similar to non-occulded projection except that
	/// produces a path that is nearly parallel to the terrain (within the
	/// user specified height tolerance).
	/// </summary>
	public virtual int GetProjectionMode()
	{
		return vtkProjectedTerrainPath_GetProjectionMode_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectedTerrainPath_GetProjectionModeMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Determine how to control the projection process. Simple projection
	/// just projects the original polyline points. Non-occluded projection
	/// insures that the polyline does not intersect the terrain surface.
	/// Hug projection is similar to non-occulded projection except that
	/// produces a path that is nearly parallel to the terrain (within the
	/// user specified height tolerance).
	/// </summary>
	public virtual int GetProjectionModeMaxValue()
	{
		return vtkProjectedTerrainPath_GetProjectionModeMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectedTerrainPath_GetProjectionModeMinValue_12(HandleRef pThis);

	/// <summary>
	/// Determine how to control the projection process. Simple projection
	/// just projects the original polyline points. Non-occluded projection
	/// insures that the polyline does not intersect the terrain surface.
	/// Hug projection is similar to non-occulded projection except that
	/// produces a path that is nearly parallel to the terrain (within the
	/// user specified height tolerance).
	/// </summary>
	public virtual int GetProjectionModeMinValue()
	{
		return vtkProjectedTerrainPath_GetProjectionModeMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTerrainPath_GetSource_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the second input (the terrain) onto which the polyline(s) should be projected.
	/// Note: This assigns a data object as the input terrain.
	/// To establish a pipeline connection, use
	/// SetSourceConnection() method.
	/// </summary>
	public vtkImageData GetSource()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectedTerrainPath_GetSource_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectedTerrainPath_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProjectedTerrainPath_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectedTerrainPath_IsTypeOf_15(string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProjectedTerrainPath_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTerrainPath_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new vtkProjectedTerrainPath NewInstance()
	{
		vtkProjectedTerrainPath result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectedTerrainPath_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTerrainPath_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new static vtkProjectedTerrainPath SafeDownCast(vtkObjectBase o)
	{
		vtkProjectedTerrainPath vtkProjectedTerrainPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectedTerrainPath_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProjectedTerrainPath2 = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProjectedTerrainPath2.Register(null);
			}
		}
		return vtkProjectedTerrainPath2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTerrainPath_SetHeightOffset_19(HandleRef pThis, double _arg);

	/// <summary>
	/// This is the height above (or below) the terrain that the projected
	/// path should be. Positive values indicate distances above the terrain;
	/// negative values indicate distances below the terrain.
	/// </summary>
	public virtual void SetHeightOffset(double _arg)
	{
		vtkProjectedTerrainPath_SetHeightOffset_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTerrainPath_SetHeightTolerance_20(HandleRef pThis, double _arg);

	/// <summary>
	/// This is the allowable variation in the altitude of the path
	/// with respect to the variation in the terrain. It only comes
	/// into play if the hug projection mode is enabled.
	/// </summary>
	public virtual void SetHeightTolerance(double _arg)
	{
		vtkProjectedTerrainPath_SetHeightTolerance_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTerrainPath_SetMaximumNumberOfLines_21(HandleRef pThis, long _arg);

	/// <summary>
	/// This instance variable can be used to limit the total number of line
	/// segments created during subdivision. Note that the number of input line
	/// segments will be the minimum number that cab be output.
	/// </summary>
	public virtual void SetMaximumNumberOfLines(long _arg)
	{
		vtkProjectedTerrainPath_SetMaximumNumberOfLines_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTerrainPath_SetProjectionMode_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Determine how to control the projection process. Simple projection
	/// just projects the original polyline points. Non-occluded projection
	/// insures that the polyline does not intersect the terrain surface.
	/// Hug projection is similar to non-occulded projection except that
	/// produces a path that is nearly parallel to the terrain (within the
	/// user specified height tolerance).
	/// </summary>
	public virtual void SetProjectionMode(int _arg)
	{
		vtkProjectedTerrainPath_SetProjectionMode_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTerrainPath_SetProjectionModeToHug_23(HandleRef pThis);

	/// <summary>
	/// Determine how to control the projection process. Simple projection
	/// just projects the original polyline points. Non-occluded projection
	/// insures that the polyline does not intersect the terrain surface.
	/// Hug projection is similar to non-occulded projection except that
	/// produces a path that is nearly parallel to the terrain (within the
	/// user specified height tolerance).
	/// </summary>
	public void SetProjectionModeToHug()
	{
		vtkProjectedTerrainPath_SetProjectionModeToHug_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTerrainPath_SetProjectionModeToNonOccluded_24(HandleRef pThis);

	/// <summary>
	/// Determine how to control the projection process. Simple projection
	/// just projects the original polyline points. Non-occluded projection
	/// insures that the polyline does not intersect the terrain surface.
	/// Hug projection is similar to non-occulded projection except that
	/// produces a path that is nearly parallel to the terrain (within the
	/// user specified height tolerance).
	/// </summary>
	public void SetProjectionModeToNonOccluded()
	{
		vtkProjectedTerrainPath_SetProjectionModeToNonOccluded_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTerrainPath_SetProjectionModeToSimple_25(HandleRef pThis);

	/// <summary>
	/// Determine how to control the projection process. Simple projection
	/// just projects the original polyline points. Non-occluded projection
	/// insures that the polyline does not intersect the terrain surface.
	/// Hug projection is similar to non-occulded projection except that
	/// produces a path that is nearly parallel to the terrain (within the
	/// user specified height tolerance).
	/// </summary>
	public void SetProjectionModeToSimple()
	{
		vtkProjectedTerrainPath_SetProjectionModeToSimple_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTerrainPath_SetSourceConnection_26(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the second input (the terrain) onto which the polyline(s) should be projected.
	/// Note: vtkImageData* is required
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkProjectedTerrainPath_SetSourceConnection_26(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTerrainPath_SetSourceData_27(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the second input (the terrain) onto which the polyline(s) should be projected.
	/// Note: This assigns a data object as the input terrain.
	/// To establish a pipeline connection, use
	/// SetSourceConnection() method.
	/// </summary>
	public void SetSourceData(vtkImageData source)
	{
		vtkProjectedTerrainPath_SetSourceData_27(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}
}
