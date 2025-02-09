using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnsignedDistance
/// </summary>
/// <remarks>
///    compute unsigned (i.e., non-negative) distances from an input point cloud
///
/// vtkUnsignedDistance is a filter that computes non-negative (i.e., unsigned)
/// distances over a volume from an input point cloud. This filter is distinct
/// from vtkSignedDistance in that it does not require point normals. However,
/// isocontouring a zero-valued distance function (e.g., trying to fit a
/// surface will produce unsatisfactory results). Rather this filter, when
/// combined with an isocontouring filter such as vtkFlyingEdges3D, can
/// produce an offset, bounding surface surrounding the input point cloud.
///
/// To use this filter, specify the input vtkPolyData (which represents the
/// point cloud); define the sampling volume; specify a radius (which limits
/// the radius of influence of each point); and set an optional point locator
/// (to accelerate proximity operations, a vtkStaticPointLocator is used by
/// default). Note that large radius values may have significant impact on
/// performance. The volume is defined by specifying dimensions in the x-y-z
/// directions, as well as a domain bounds. By default the model bounds are
/// defined from the input points, but the user can also manually specify
/// them. Finally, because the radius data member limits the influence of the
/// distance calculation, some voxels may receive no contribution. These voxel
/// values are set to the CapValue.
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
/// @warning
/// Note that multiple, non-connected surfaces may be produced. For example,
/// if the point cloud is from the surface of the sphere, it is possible to
/// generate two surfaces (with isocontouring): one inside the sphere, one
/// outside the sphere. It is sometimes possible to select the surface you
/// want from the output of the contouring filter by using
/// vtkPolyDataConnectivityFilter.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkSignedDistance vtkExtractSurface vtkImplicitModeller
/// </seealso>
public class vtkUnsignedDistance : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedDistance";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnsignedDistance()
	{
		MRClassNameKey = "class vtkUnsignedDistance";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedDistance"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnsignedDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnsignedDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static vtkUnsignedDistance New()
	{
		vtkUnsignedDistance result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnsignedDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnsignedDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public vtkUnsignedDistance()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnsignedDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkUnsignedDistance_AdjustBoundsOff_01(HandleRef pThis);

	/// <summary>
	/// Control how the model bounds are computed. If the ivar AdjustBounds
	/// is set, then the bounds specified (or computed automatically) is modified
	/// by the fraction given by AdjustDistance. This means that the model
	/// bounds is expanded in each of the x-y-z directions.
	/// </summary>
	public virtual void AdjustBoundsOff()
	{
		vtkUnsignedDistance_AdjustBoundsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_AdjustBoundsOn_02(HandleRef pThis);

	/// <summary>
	/// Control how the model bounds are computed. If the ivar AdjustBounds
	/// is set, then the bounds specified (or computed automatically) is modified
	/// by the fraction given by AdjustDistance. This means that the model
	/// bounds is expanded in each of the x-y-z directions.
	/// </summary>
	public virtual void AdjustBoundsOn()
	{
		vtkUnsignedDistance_AdjustBoundsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_Append_03(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Append a data set to the existing output. To use this function,
	/// you'll have to invoke the StartAppend() method before doing
	/// successive appends. It's also a good idea to specify the model
	/// bounds; otherwise the input model bounds is used. When you've
	/// finished appending, use the EndAppend() method.
	/// </summary>
	public void Append(vtkPolyData input)
	{
		vtkUnsignedDistance_Append_03(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_CappingOff_04(HandleRef pThis);

	/// <summary>
	/// The outer boundary of the volume can be assigned a particular value
	/// after distances are computed. This can be used to close or "cap" all
	/// surfaces during isocontouring.
	/// </summary>
	public virtual void CappingOff()
	{
		vtkUnsignedDistance_CappingOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_CappingOn_05(HandleRef pThis);

	/// <summary>
	/// The outer boundary of the volume can be assigned a particular value
	/// after distances are computed. This can be used to close or "cap" all
	/// surfaces during isocontouring.
	/// </summary>
	public virtual void CappingOn()
	{
		vtkUnsignedDistance_CappingOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_EndAppend_06(HandleRef pThis);

	/// <summary>
	/// Method completes the append process.
	/// </summary>
	public void EndAppend()
	{
		vtkUnsignedDistance_EndAppend_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnsignedDistance_GetAdjustBounds_07(HandleRef pThis);

	/// <summary>
	/// Control how the model bounds are computed. If the ivar AdjustBounds
	/// is set, then the bounds specified (or computed automatically) is modified
	/// by the fraction given by AdjustDistance. This means that the model
	/// bounds is expanded in each of the x-y-z directions.
	/// </summary>
	public virtual int GetAdjustBounds()
	{
		return vtkUnsignedDistance_GetAdjustBounds_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnsignedDistance_GetAdjustDistance_08(HandleRef pThis);

	/// <summary>
	/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
	/// is set). The value is a fraction of the maximum length of the sides
	/// of the box specified by the model bounds.
	/// </summary>
	public virtual double GetAdjustDistance()
	{
		return vtkUnsignedDistance_GetAdjustDistance_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnsignedDistance_GetAdjustDistanceMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
	/// is set). The value is a fraction of the maximum length of the sides
	/// of the box specified by the model bounds.
	/// </summary>
	public virtual double GetAdjustDistanceMaxValue()
	{
		return vtkUnsignedDistance_GetAdjustDistanceMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnsignedDistance_GetAdjustDistanceMinValue_10(HandleRef pThis);

	/// <summary>
	/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
	/// is set). The value is a fraction of the maximum length of the sides
	/// of the box specified by the model bounds.
	/// </summary>
	public virtual double GetAdjustDistanceMinValue()
	{
		return vtkUnsignedDistance_GetAdjustDistanceMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnsignedDistance_GetBounds_11(HandleRef pThis);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual double[] GetBounds()
	{
		IntPtr intPtr = vtkUnsignedDistance_GetBounds_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_GetBounds_12(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual void GetBounds(IntPtr data)
	{
		vtkUnsignedDistance_GetBounds_12(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnsignedDistance_GetCapValue_13(HandleRef pThis);

	/// <summary>
	/// Specify the capping value to use. The CapValue is also used as an
	/// initial distance value at each point in the dataset. By default, the
	/// CapValue is VTK_FLOAT_MAX;
	/// </summary>
	public virtual double GetCapValue()
	{
		return vtkUnsignedDistance_GetCapValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnsignedDistance_GetCapping_14(HandleRef pThis);

	/// <summary>
	/// The outer boundary of the volume can be assigned a particular value
	/// after distances are computed. This can be used to close or "cap" all
	/// surfaces during isocontouring.
	/// </summary>
	public virtual int GetCapping()
	{
		return vtkUnsignedDistance_GetCapping_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnsignedDistance_GetDimensions_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to computer the distance function.
	/// </summary>
	public virtual int[] GetDimensions()
	{
		IntPtr intPtr = vtkUnsignedDistance_GetDimensions_15(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_GetDimensions_16(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to computer the distance function.
	/// </summary>
	public virtual void GetDimensions(IntPtr data)
	{
		vtkUnsignedDistance_GetDimensions_16(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnsignedDistance_GetLocator_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkUnsignedDistance_GetLocator_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkUnsignedDistance_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnsignedDistance_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnsignedDistance_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnsignedDistance_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnsignedDistance_GetOutputScalarType_20(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. Currently only real types are
	/// supported. By default, VTK_FLOAT scalars are created.
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkUnsignedDistance_GetOutputScalarType_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnsignedDistance_GetRadius_21(HandleRef pThis);

	/// <summary>
	/// Set / get the radius of influence of each point. Smaller values
	/// generally improve performance markedly.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkUnsignedDistance_GetRadius_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnsignedDistance_GetRadiusMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Set / get the radius of influence of each point. Smaller values
	/// generally improve performance markedly.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkUnsignedDistance_GetRadiusMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnsignedDistance_GetRadiusMinValue_23(HandleRef pThis);

	/// <summary>
	/// Set / get the radius of influence of each point. Smaller values
	/// generally improve performance markedly.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkUnsignedDistance_GetRadiusMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnsignedDistance_IsA_24(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnsignedDistance_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnsignedDistance_IsTypeOf_25(string type);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnsignedDistance_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnsignedDistance_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new vtkUnsignedDistance NewInstance()
	{
		vtkUnsignedDistance result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnsignedDistance_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnsignedDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnsignedDistance_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating the class, providing type information,
	/// and printing.
	/// </summary>
	public new static vtkUnsignedDistance SafeDownCast(vtkObjectBase o)
	{
		vtkUnsignedDistance vtkUnsignedDistance2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnsignedDistance_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedDistance2 = (vtkUnsignedDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedDistance2.Register(null);
			}
		}
		return vtkUnsignedDistance2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetAdjustBounds_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the model bounds are computed. If the ivar AdjustBounds
	/// is set, then the bounds specified (or computed automatically) is modified
	/// by the fraction given by AdjustDistance. This means that the model
	/// bounds is expanded in each of the x-y-z directions.
	/// </summary>
	public virtual void SetAdjustBounds(int _arg)
	{
		vtkUnsignedDistance_SetAdjustBounds_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetAdjustDistance_30(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
	/// is set). The value is a fraction of the maximum length of the sides
	/// of the box specified by the model bounds.
	/// </summary>
	public virtual void SetAdjustDistance(double _arg)
	{
		vtkUnsignedDistance_SetAdjustDistance_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetBounds_31(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkUnsignedDistance_SetBounds_31(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetBounds_32(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkUnsignedDistance_SetBounds_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetCapValue_33(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the capping value to use. The CapValue is also used as an
	/// initial distance value at each point in the dataset. By default, the
	/// CapValue is VTK_FLOAT_MAX;
	/// </summary>
	public virtual void SetCapValue(double _arg)
	{
		vtkUnsignedDistance_SetCapValue_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetCapping_34(HandleRef pThis, int _arg);

	/// <summary>
	/// The outer boundary of the volume can be assigned a particular value
	/// after distances are computed. This can be used to close or "cap" all
	/// surfaces during isocontouring.
	/// </summary>
	public virtual void SetCapping(int _arg)
	{
		vtkUnsignedDistance_SetCapping_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetDimensions_35(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to computer the distance function.
	/// </summary>
	public void SetDimensions(int i, int j, int k)
	{
		vtkUnsignedDistance_SetDimensions_35(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetDimensions_36(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to computer the distance function.
	/// </summary>
	public void SetDimensions(IntPtr dim)
	{
		vtkUnsignedDistance_SetDimensions_36(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetLocator_37(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// surrounding a voxel (within the specified radius).
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkUnsignedDistance_SetLocator_37(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetOutputScalarType_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the desired output scalar type. Currently only real types are
	/// supported. By default, VTK_FLOAT scalars are created.
	/// </summary>
	public virtual void SetOutputScalarType(int _arg)
	{
		vtkUnsignedDistance_SetOutputScalarType_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetOutputScalarTypeToDouble_39(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. Currently only real types are
	/// supported. By default, VTK_FLOAT scalars are created.
	/// </summary>
	public void SetOutputScalarTypeToDouble()
	{
		vtkUnsignedDistance_SetOutputScalarTypeToDouble_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetOutputScalarTypeToFloat_40(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. Currently only real types are
	/// supported. By default, VTK_FLOAT scalars are created.
	/// </summary>
	public void SetOutputScalarTypeToFloat()
	{
		vtkUnsignedDistance_SetOutputScalarTypeToFloat_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_SetRadius_41(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the radius of influence of each point. Smaller values
	/// generally improve performance markedly.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkUnsignedDistance_SetRadius_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnsignedDistance_StartAppend_42(HandleRef pThis);

	/// <summary>
	/// Initialize the filter for appending data. You must invoke the
	/// StartAppend() method before doing successive Appends(). It's also a
	/// good idea to manually specify the model bounds; otherwise the input
	/// bounds for the data will be used.
	/// </summary>
	public void StartAppend()
	{
		vtkUnsignedDistance_StartAppend_42(GetCppThis());
	}
}
