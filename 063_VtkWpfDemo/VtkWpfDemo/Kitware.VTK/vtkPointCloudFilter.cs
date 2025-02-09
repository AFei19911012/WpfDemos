using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointCloudFilter
/// </summary>
/// <remarks>
///    abstract class for filtering a point cloud
///
///
/// vtkPointCloudFilter serves as a base for classes that filter point clouds.
/// It takes as input any vtkPointSet (which represents points explicitly
/// using vtkPoints) and produces as output an explicit representation of
/// filtered points via a vtkPolyData. This output vtkPolyData will populate
/// its instance of vtkPoints, and typically no cells will be defined (i.e.,
/// no vtkVertex or vtkPolyVertex are contained in the output unless
/// explicitly requested). Also, after filter execution, the user can request
/// a vtkIdType* point map which indicates how the input points were mapped to
/// the output. A value of PointMap[i] &lt; 0 (where i is the ith input point)
/// means that the ith input point was removed. Otherwise PointMap[i]
/// indicates the position in the output vtkPoints array (point cloud).
///
/// Optionally the filter may produce a second output. This second output is
/// another vtkPolyData with a vtkPoints that contains the points that were
/// removed during processing. To produce this second output, you must enable
/// GenerateOutliers. If this optional, second output is created, then the
/// contents of the PointMap are modified as well. In this case, a PointMap[i]
/// &lt; 0 means that the ith input point has been mapped to the (-PointMap[i])-1
/// position in the second output's vtkPoints.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// @warning
/// The filter copies point attributes from input to output consistent
/// with the filtering operation.
///
/// @warning
/// It is convenient to use vtkPointGaussianMapper to render the points (since
/// this mapper does not require cells to be defined, and it is quite fast).
///
/// </remarks>
/// <seealso>
///
/// vtkRadiusOutlierRemoval vtkPointGaussianMapper vtkThresholdPoints
/// </seealso>
public abstract class vtkPointCloudFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointCloudFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointCloudFilter()
	{
		MRClassNameKey = "class vtkPointCloudFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointCloudFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointCloudFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudFilter_GenerateOutliersOff_01(HandleRef pThis);

	/// <summary>
	/// If this method is enabled (true), then a second output will be created
	/// that contains the outlier points. By default this is off (false).  Note
	/// that if enabled, the PointMap is modified as well: the outlier points
	/// are listed as well, with similar meaning, except their value is negated
	/// and shifted by -1.
	/// </summary>
	public virtual void GenerateOutliersOff()
	{
		vtkPointCloudFilter_GenerateOutliersOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudFilter_GenerateOutliersOn_02(HandleRef pThis);

	/// <summary>
	/// If this method is enabled (true), then a second output will be created
	/// that contains the outlier points. By default this is off (false).  Note
	/// that if enabled, the PointMap is modified as well: the outlier points
	/// are listed as well, with similar meaning, except their value is negated
	/// and shifted by -1.
	/// </summary>
	public virtual void GenerateOutliersOn()
	{
		vtkPointCloudFilter_GenerateOutliersOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudFilter_GenerateVerticesOff_03(HandleRef pThis);

	/// <summary>
	/// If this method is enabled (true), then the outputs will contain a vertex
	/// cells (i.e., a vtkPolyVertex for each output). This takes a lot more
	/// memory but some VTK filters need cells to function properly. By default
	/// this is off (false).
	/// </summary>
	public virtual void GenerateVerticesOff()
	{
		vtkPointCloudFilter_GenerateVerticesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudFilter_GenerateVerticesOn_04(HandleRef pThis);

	/// <summary>
	/// If this method is enabled (true), then the outputs will contain a vertex
	/// cells (i.e., a vtkPolyVertex for each output). This takes a lot more
	/// memory but some VTK filters need cells to function properly. By default
	/// this is off (false).
	/// </summary>
	public virtual void GenerateVerticesOn()
	{
		vtkPointCloudFilter_GenerateVerticesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointCloudFilter_GetGenerateOutliers_05(HandleRef pThis);

	/// <summary>
	/// If this method is enabled (true), then a second output will be created
	/// that contains the outlier points. By default this is off (false).  Note
	/// that if enabled, the PointMap is modified as well: the outlier points
	/// are listed as well, with similar meaning, except their value is negated
	/// and shifted by -1.
	/// </summary>
	public virtual bool GetGenerateOutliers()
	{
		return (vtkPointCloudFilter_GetGenerateOutliers_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointCloudFilter_GetGenerateVertices_06(HandleRef pThis);

	/// <summary>
	/// If this method is enabled (true), then the outputs will contain a vertex
	/// cells (i.e., a vtkPolyVertex for each output). This takes a lot more
	/// memory but some VTK filters need cells to function properly. By default
	/// this is off (false).
	/// </summary>
	public virtual bool GetGenerateVertices()
	{
		return (vtkPointCloudFilter_GetGenerateVertices_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointCloudFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to obtain type information, and print information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointCloudFilter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointCloudFilter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods to obtain type information, and print information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointCloudFilter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointCloudFilter_GetNumberOfPointsRemoved_09(HandleRef pThis);

	/// <summary>
	/// Return the number of points removed after filter execution. The
	/// information returned is valid only after the filter executes.
	/// </summary>
	public long GetNumberOfPointsRemoved()
	{
		return vtkPointCloudFilter_GetNumberOfPointsRemoved_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointCloudFilter_GetPointMap_10(HandleRef pThis);

	/// <summary>
	/// Retrieve a map which indicates, on a point-by-point basis, where each
	/// input point was placed into the output. In other words, map[i] indicates
	/// where the ith input point is located in the output array of points. If
	/// map[i] &lt; 0, then the ith input point was removed during filter
	/// execution.  This method returns valid information only after the filter
	/// executes.
	/// </summary>
	public IntPtr GetPointMap()
	{
		return vtkPointCloudFilter_GetPointMap_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudFilter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to obtain type information, and print information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointCloudFilter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointCloudFilter_IsTypeOf_12(string type);

	/// <summary>
	/// Standard methods to obtain type information, and print information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointCloudFilter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointCloudFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to obtain type information, and print information.
	/// </summary>
	public new vtkPointCloudFilter NewInstance()
	{
		vtkPointCloudFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointCloudFilter_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointCloudFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointCloudFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to obtain type information, and print information.
	/// </summary>
	public new static vtkPointCloudFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPointCloudFilter vtkPointCloudFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointCloudFilter_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointCloudFilter2 = (vtkPointCloudFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointCloudFilter2.Register(null);
			}
		}
		return vtkPointCloudFilter2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudFilter_SetGenerateOutliers_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// If this method is enabled (true), then a second output will be created
	/// that contains the outlier points. By default this is off (false).  Note
	/// that if enabled, the PointMap is modified as well: the outlier points
	/// are listed as well, with similar meaning, except their value is negated
	/// and shifted by -1.
	/// </summary>
	public virtual void SetGenerateOutliers(bool _arg)
	{
		vtkPointCloudFilter_SetGenerateOutliers_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointCloudFilter_SetGenerateVertices_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// If this method is enabled (true), then the outputs will contain a vertex
	/// cells (i.e., a vtkPolyVertex for each output). This takes a lot more
	/// memory but some VTK filters need cells to function properly. By default
	/// this is off (false).
	/// </summary>
	public virtual void SetGenerateVertices(bool _arg)
	{
		vtkPointCloudFilter_SetGenerateVertices_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
