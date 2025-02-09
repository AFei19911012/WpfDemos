using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSignedDistance
/// </summary>
/// <remarks>
///    compute signed distances from an input point cloud
///
/// vtkSignedDistance is a filter that computes signed distances over a volume
/// from an input point cloud. The input point cloud must have point normals
/// defined, as well as an optional weighting function (e.g., probabilities
/// that the point measurements are accurate). Once the signed distance
/// function is computed, then the output volume may be isocontoured to with
/// vtkExtractSurface to extract a approximating surface to the point cloud.
///
/// To use this filter, specify the input vtkPolyData (which represents the
/// point cloud); define the sampling volume; specify a radius (which limits
/// the radius of influence of each point); and set an optional point locator
/// (to accelerate proximity operations, a vtkStaticPointLocator is used by
/// default). Note that large radius values may have significant impact on
/// performance. The volume is defined by specifying dimensions in the x-y-z
/// directions, as well as a domain bounds. By default the model bounds are
/// defined from the input points, but the user can also manually specify
/// them.
///
/// This filter has one other unusual capability: it is possible to append
/// data in a sequence of operations to generate a single output. This is
/// useful when you have multiple point clouds (e.g., possibly from multiple
/// acquisition scans) and want to incrementally accumulate all the data.
/// However, the user must be careful to either specify the Bounds or
/// order the input such that the bounds of the first input completely
/// contains all other input data.  This is because the geometry and topology
/// of the output sampling volume cannot be changed after the initial Append
/// operation.
///
/// This algorithm loosely follows the most excellent paper by Curless and
/// Levoy: "A Volumetric Method for Building Complex Models from Range
/// Images." As described in this paper it may produce a signed distance
/// volume that may contain the three data states for each voxel: near
/// surface, empty, or unseen (see vtkExtractSurface for additional
/// information). Note in this implementation the initial values of the volume
/// are set to &lt; this-&gt;Radius. This indicates that these voxels are
/// "empty". Of course voxels with value -this-&gt;Radius &lt;= d &lt;= this-&gt;Radius
/// are "near" the surface. (Voxels with values &gt; this-&gt;Radius are "unseen" --
/// this filter does not produce such values.)
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// @warning
/// Empty voxel values are set to -this-&gt;Radius.
///
/// </remarks>
/// <seealso>
///
/// vtkExtractSurface vtkImplicitModeller
/// </seealso>
public class vtkSignedDistance : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSignedDistance";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSignedDistance()
	{
		MRClassNameKey = "class vtkSignedDistance";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSignedDistance"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSignedDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSignedDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static vtkSignedDistance New()
	{
		vtkSignedDistance result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSignedDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSignedDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public vtkSignedDistance()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSignedDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSignedDistance_Append_01(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Append a data set to the existing output. To use this function,
	/// you'll have to invoke the StartAppend() method before doing
	/// successive appends. It's also a good idea to specify the model
	/// bounds; otherwise the input model bounds is used. When you've
	/// finished appending, use the EndAppend() method.
	/// </summary>
	public void Append(vtkPolyData input)
	{
		vtkSignedDistance_Append_01(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSignedDistance_EndAppend_02(HandleRef pThis);

	/// <summary>
	/// Method completes the append process.
	/// </summary>
	public void EndAppend()
	{
		vtkSignedDistance_EndAppend_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSignedDistance_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual double[] GetBounds()
	{
		IntPtr intPtr = vtkSignedDistance_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSignedDistance_GetBounds_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual void GetBounds(IntPtr data)
	{
		vtkSignedDistance_GetBounds_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSignedDistance_GetDimensions_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to computer the distance function.
	/// </summary>
	public virtual int[] GetDimensions()
	{
		IntPtr intPtr = vtkSignedDistance_GetDimensions_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSignedDistance_GetDimensions_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to computer the distance function.
	/// </summary>
	public virtual void GetDimensions(IntPtr data)
	{
		vtkSignedDistance_GetDimensions_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSignedDistance_GetLocator_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// surrounding a voxel (within the specified radius).
	/// </summary>
	public virtual vtkAbstractPointLocator GetLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSignedDistance_GetLocator_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPointLocator2 = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPointLocator2.Register(null);
			}
		}
		return vtkAbstractPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSignedDistance_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSignedDistance_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSignedDistance_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSignedDistance_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSignedDistance_GetRadius_10(HandleRef pThis);

	/// <summary>
	/// Set / get the radius of influence of each point. Smaller values
	/// generally improve performance markedly. Note that after the signed
	/// distance function is computed, any voxel taking on the value &gt;= Radius
	/// is presumed to be "unseen" or uninitialized.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkSignedDistance_GetRadius_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSignedDistance_GetRadiusMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set / get the radius of influence of each point. Smaller values
	/// generally improve performance markedly. Note that after the signed
	/// distance function is computed, any voxel taking on the value &gt;= Radius
	/// is presumed to be "unseen" or uninitialized.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkSignedDistance_GetRadiusMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSignedDistance_GetRadiusMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set / get the radius of influence of each point. Smaller values
	/// generally improve performance markedly. Note that after the signed
	/// distance function is computed, any voxel taking on the value &gt;= Radius
	/// is presumed to be "unseen" or uninitialized.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkSignedDistance_GetRadiusMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSignedDistance_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSignedDistance_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSignedDistance_IsTypeOf_14(string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSignedDistance_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSignedDistance_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new vtkSignedDistance NewInstance()
	{
		vtkSignedDistance result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSignedDistance_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSignedDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSignedDistance_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static vtkSignedDistance SafeDownCast(vtkObjectBase o)
	{
		vtkSignedDistance vtkSignedDistance2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSignedDistance_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSignedDistance2 = (vtkSignedDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSignedDistance2.Register(null);
			}
		}
		return vtkSignedDistance2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSignedDistance_SetBounds_18(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkSignedDistance_SetBounds_18(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSignedDistance_SetBounds_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkSignedDistance_SetBounds_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSignedDistance_SetDimensions_20(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to computer the distance function.
	/// </summary>
	public void SetDimensions(int i, int j, int k)
	{
		vtkSignedDistance_SetDimensions_20(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSignedDistance_SetDimensions_21(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to computer the distance function.
	/// </summary>
	public void SetDimensions(IntPtr dim)
	{
		vtkSignedDistance_SetDimensions_21(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSignedDistance_SetLocator_22(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// surrounding a voxel (within the specified radius).
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkSignedDistance_SetLocator_22(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSignedDistance_SetRadius_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the radius of influence of each point. Smaller values
	/// generally improve performance markedly. Note that after the signed
	/// distance function is computed, any voxel taking on the value &gt;= Radius
	/// is presumed to be "unseen" or uninitialized.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkSignedDistance_SetRadius_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSignedDistance_StartAppend_24(HandleRef pThis);

	/// <summary>
	/// Initialize the filter for appending data. You must invoke the
	/// StartAppend() method before doing successive Appends(). It's also a
	/// good idea to manually specify the model bounds; otherwise the input
	/// bounds for the data will be used.
	/// </summary>
	public void StartAppend()
	{
		vtkSignedDistance_StartAppend_24(GetCppThis());
	}
}
