using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkConstrainedSmoothingFilter
/// </summary>
/// <remarks>
///    adjust point positions using constrained smoothing
///
/// vtkConstrainedSmoothingFilter is a filter that adjusts point coordinates
/// using a modified Laplacian smoothing approach. The effect is to "relax"
/// or "smooth" the mesh, making the cells better shaped and the points more
/// evenly distributed. Note that this filter operates on any vtkPointSet and
/// derived classes. Cell topology is never modified; note however if the
/// constraints are too lax, cells may self-intersect or otherwise be deformed
/// in unfavorable ways.
///
/// A central concept of this filter is the point smoothing stencil. A
/// smoothing stencil for a point pi is the list of points pj which connect to
/// pi via an edge. To smooth the point pi, pi is moved towards the average
/// position of pj multiplied by the relaxation factor, and limited by the
/// constraint distance. This process is repeated either until convergence
/// occurs, or the maximum number of iterations is reached. Note that
/// smoothing stencils may be specified; or if not provided, the stencils are
/// computed from the input cells connected edges (using vtkExtractEdges with
/// UseAllPoints enabled).
///
/// To constrain the motion of the points, either set the filter's constraint
/// distance, or provide an input point data array (of type vtkDoubleArray)
/// named "SmoothingConstraints." The filter's constraint distance is applied
/// to all points; whereas the smoothing data array may have different
/// constraint values per point. If provided by the user, by default the
/// smoothing data array takes precedence over the filter's constraint
/// distance.
///
/// @warning
/// The smoothing process reduces high frequency information in the geometry
/// of the mesh. With excessive smoothing important details may be lost, and
/// the surface may shrink towards the centroid. The constraints on point
/// movement help significantly in preventing shrinkage from happening.
///
/// </remarks>
/// <seealso>
///
/// vtkWindowedSincPolyDataFilter vtkSmoothPolyDataFilter vtkAttributeSmoothingFilter
/// vtkExtractEdges
/// </seealso>
public class vtkConstrainedSmoothingFilter : vtkPointSetAlgorithm
{
	/// <summary>
	/// Specify the relaxation factor for smoothing. As in all iterative
	/// methods, the stability of the process is sensitive to this parameter. In
	/// general, small relaxation factors and large numbers of iterations are
	/// more stable than larger relaxation factors and smaller numbers of
	/// iterations. The default value is 0.01.
	/// </summary>
	public enum ConstraintStrategyType
	{
		/// <summary>enum member</summary>
		CONSTRAINT_ARRAY = 2,
		/// <summary>enum member</summary>
		CONSTRAINT_DISTANCE = 1,
		/// <summary>enum member</summary>
		DEFAULT = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkConstrainedSmoothingFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkConstrainedSmoothingFilter()
	{
		MRClassNameKey = "class vtkConstrainedSmoothingFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkConstrainedSmoothingFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkConstrainedSmoothingFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedSmoothingFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public new static vtkConstrainedSmoothingFilter New()
	{
		vtkConstrainedSmoothingFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedSmoothingFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConstrainedSmoothingFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public vtkConstrainedSmoothingFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkConstrainedSmoothingFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_GenerateErrorScalarsOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of scalar distance values. By default, the
	/// generation of error scalars is disabled.
	/// </summary>
	public virtual void GenerateErrorScalarsOff()
	{
		vtkConstrainedSmoothingFilter_GenerateErrorScalarsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_GenerateErrorScalarsOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of scalar distance values. By default, the
	/// generation of error scalars is disabled.
	/// </summary>
	public virtual void GenerateErrorScalarsOn()
	{
		vtkConstrainedSmoothingFilter_GenerateErrorScalarsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_GenerateErrorVectorsOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of error vectors. By default, the generation
	/// of error vectors is disabled.
	/// </summary>
	public virtual void GenerateErrorVectorsOff()
	{
		vtkConstrainedSmoothingFilter_GenerateErrorVectorsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_GenerateErrorVectorsOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of error vectors. By default, the generation
	/// of error vectors is disabled.
	/// </summary>
	public virtual void GenerateErrorVectorsOn()
	{
		vtkConstrainedSmoothingFilter_GenerateErrorVectorsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConstrainedSmoothingFilter_GetConstraintDistance_05(HandleRef pThis);

	/// <summary>
	/// Specify a constraint distance for point motion. By default, if a point
	/// data array constraint distance (named "SmoothingConstraints") is provided
	/// in the input point data, then the array takes precedence. By default, the
	/// constraint distance is 0.001.
	/// </summary>
	public virtual double GetConstraintDistance()
	{
		return vtkConstrainedSmoothingFilter_GetConstraintDistance_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConstrainedSmoothingFilter_GetConstraintDistanceMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Specify a constraint distance for point motion. By default, if a point
	/// data array constraint distance (named "SmoothingConstraints") is provided
	/// in the input point data, then the array takes precedence. By default, the
	/// constraint distance is 0.001.
	/// </summary>
	public virtual double GetConstraintDistanceMaxValue()
	{
		return vtkConstrainedSmoothingFilter_GetConstraintDistanceMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConstrainedSmoothingFilter_GetConstraintDistanceMinValue_07(HandleRef pThis);

	/// <summary>
	/// Specify a constraint distance for point motion. By default, if a point
	/// data array constraint distance (named "SmoothingConstraints") is provided
	/// in the input point data, then the array takes precedence. By default, the
	/// constraint distance is 0.001.
	/// </summary>
	public virtual double GetConstraintDistanceMinValue()
	{
		return vtkConstrainedSmoothingFilter_GetConstraintDistanceMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedSmoothingFilter_GetConstraintStrategy_08(HandleRef pThis);

	/// <summary>
	/// Indicate how to apply constraints. By default, a constraint array takes
	/// precedence over the filter's constraint distance, but if not available
	/// then the constraint distance is used. If a CONSTRAINT_ARRAY strategy is
	/// specified, and no constraint array is available from the point data,
	/// then no constraints are provided. Note that is also possible to turn off
	/// constraints completely by simply specifying a very large constraint
	/// distance. The default constraint strategy is DEFAULT.
	/// </summary>
	public virtual int GetConstraintStrategy()
	{
		return vtkConstrainedSmoothingFilter_GetConstraintStrategy_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedSmoothingFilter_GetConstraintStrategyMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Indicate how to apply constraints. By default, a constraint array takes
	/// precedence over the filter's constraint distance, but if not available
	/// then the constraint distance is used. If a CONSTRAINT_ARRAY strategy is
	/// specified, and no constraint array is available from the point data,
	/// then no constraints are provided. Note that is also possible to turn off
	/// constraints completely by simply specifying a very large constraint
	/// distance. The default constraint strategy is DEFAULT.
	/// </summary>
	public virtual int GetConstraintStrategyMaxValue()
	{
		return vtkConstrainedSmoothingFilter_GetConstraintStrategyMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedSmoothingFilter_GetConstraintStrategyMinValue_10(HandleRef pThis);

	/// <summary>
	/// Indicate how to apply constraints. By default, a constraint array takes
	/// precedence over the filter's constraint distance, but if not available
	/// then the constraint distance is used. If a CONSTRAINT_ARRAY strategy is
	/// specified, and no constraint array is available from the point data,
	/// then no constraints are provided. Note that is also possible to turn off
	/// constraints completely by simply specifying a very large constraint
	/// distance. The default constraint strategy is DEFAULT.
	/// </summary>
	public virtual int GetConstraintStrategyMinValue()
	{
		return vtkConstrainedSmoothingFilter_GetConstraintStrategyMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConstrainedSmoothingFilter_GetConvergence_11(HandleRef pThis);

	/// <summary>
	/// Specify a convergence criterion for the iteration process. Smaller
	/// numbers result in more smoothing iterations. Convergence occurs
	/// when, for the current iteration, the maximum distance any point moves
	/// is less than or equal to Convergence. The default value is 0.
	/// </summary>
	public virtual double GetConvergence()
	{
		return vtkConstrainedSmoothingFilter_GetConvergence_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConstrainedSmoothingFilter_GetConvergenceMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Specify a convergence criterion for the iteration process. Smaller
	/// numbers result in more smoothing iterations. Convergence occurs
	/// when, for the current iteration, the maximum distance any point moves
	/// is less than or equal to Convergence. The default value is 0.
	/// </summary>
	public virtual double GetConvergenceMaxValue()
	{
		return vtkConstrainedSmoothingFilter_GetConvergenceMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConstrainedSmoothingFilter_GetConvergenceMinValue_13(HandleRef pThis);

	/// <summary>
	/// Specify a convergence criterion for the iteration process. Smaller
	/// numbers result in more smoothing iterations. Convergence occurs
	/// when, for the current iteration, the maximum distance any point moves
	/// is less than or equal to Convergence. The default value is 0.
	/// </summary>
	public virtual double GetConvergenceMinValue()
	{
		return vtkConstrainedSmoothingFilter_GetConvergenceMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkConstrainedSmoothingFilter_GetGenerateErrorScalars_14(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of scalar distance values. By default, the
	/// generation of error scalars is disabled.
	/// </summary>
	public virtual bool GetGenerateErrorScalars()
	{
		return (vtkConstrainedSmoothingFilter_GetGenerateErrorScalars_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkConstrainedSmoothingFilter_GetGenerateErrorVectors_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of error vectors. By default, the generation
	/// of error vectors is disabled.
	/// </summary>
	public virtual bool GetGenerateErrorVectors()
	{
		return (vtkConstrainedSmoothingFilter_GetGenerateErrorVectors_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConstrainedSmoothingFilter_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkConstrainedSmoothingFilter_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConstrainedSmoothingFilter_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkConstrainedSmoothingFilter_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedSmoothingFilter_GetNumberOfIterations_18(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of iterations for smoothing. The number
	/// of iterations may be less if the smoothing process converges. The
	/// default value is 10.
	/// </summary>
	public virtual int GetNumberOfIterations()
	{
		return vtkConstrainedSmoothingFilter_GetNumberOfIterations_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedSmoothingFilter_GetNumberOfIterationsMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of iterations for smoothing. The number
	/// of iterations may be less if the smoothing process converges. The
	/// default value is 10.
	/// </summary>
	public virtual int GetNumberOfIterationsMaxValue()
	{
		return vtkConstrainedSmoothingFilter_GetNumberOfIterationsMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedSmoothingFilter_GetNumberOfIterationsMinValue_20(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of iterations for smoothing. The number
	/// of iterations may be less if the smoothing process converges. The
	/// default value is 10.
	/// </summary>
	public virtual int GetNumberOfIterationsMinValue()
	{
		return vtkConstrainedSmoothingFilter_GetNumberOfIterationsMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedSmoothingFilter_GetOutputPointsPrecision_21(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkConstrainedSmoothingFilter_GetOutputPointsPrecision_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConstrainedSmoothingFilter_GetRelaxationFactor_22(HandleRef pThis);

	/// <summary>
	/// Specify the relaxation factor for smoothing. As in all iterative
	/// methods, the stability of the process is sensitive to this parameter. In
	/// general, small relaxation factors and large numbers of iterations are
	/// more stable than larger relaxation factors and smaller numbers of
	/// iterations. The default value is 0.01.
	/// </summary>
	public virtual double GetRelaxationFactor()
	{
		return vtkConstrainedSmoothingFilter_GetRelaxationFactor_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedSmoothingFilter_GetSmoothingStencils_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get the point smoothing stencils. Here we are repurposing a cell
	/// array to define stencils. Basically what's happening is that each point
	/// is treated a "cell" connected to a list of point ids (i.e., the
	/// "stencil") that defines the smoothing edge connections. By default, no
	/// smoothing stencils are defined.
	/// </summary>
	public virtual vtkCellArray GetSmoothingStencils()
	{
		vtkCellArray vtkCellArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedSmoothingFilter_GetSmoothingStencils_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellArray2 = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellArray2.Register(null);
			}
		}
		return vtkCellArray2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedSmoothingFilter_IsA_24(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkConstrainedSmoothingFilter_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedSmoothingFilter_IsTypeOf_25(string type);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkConstrainedSmoothingFilter_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedSmoothingFilter_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public new vtkConstrainedSmoothingFilter NewInstance()
	{
		vtkConstrainedSmoothingFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedSmoothingFilter_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConstrainedSmoothingFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedSmoothingFilter_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public new static vtkConstrainedSmoothingFilter SafeDownCast(vtkObjectBase o)
	{
		vtkConstrainedSmoothingFilter vtkConstrainedSmoothingFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedSmoothingFilter_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConstrainedSmoothingFilter2 = (vtkConstrainedSmoothingFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConstrainedSmoothingFilter2.Register(null);
			}
		}
		return vtkConstrainedSmoothingFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetConstraintDistance_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a constraint distance for point motion. By default, if a point
	/// data array constraint distance (named "SmoothingConstraints") is provided
	/// in the input point data, then the array takes precedence. By default, the
	/// constraint distance is 0.001.
	/// </summary>
	public virtual void SetConstraintDistance(double _arg)
	{
		vtkConstrainedSmoothingFilter_SetConstraintDistance_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetConstraintStrategy_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate how to apply constraints. By default, a constraint array takes
	/// precedence over the filter's constraint distance, but if not available
	/// then the constraint distance is used. If a CONSTRAINT_ARRAY strategy is
	/// specified, and no constraint array is available from the point data,
	/// then no constraints are provided. Note that is also possible to turn off
	/// constraints completely by simply specifying a very large constraint
	/// distance. The default constraint strategy is DEFAULT.
	/// </summary>
	public virtual void SetConstraintStrategy(int _arg)
	{
		vtkConstrainedSmoothingFilter_SetConstraintStrategy_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetConstraintStrategyToConstraintArray_31(HandleRef pThis);

	/// <summary>
	/// Indicate how to apply constraints. By default, a constraint array takes
	/// precedence over the filter's constraint distance, but if not available
	/// then the constraint distance is used. If a CONSTRAINT_ARRAY strategy is
	/// specified, and no constraint array is available from the point data,
	/// then no constraints are provided. Note that is also possible to turn off
	/// constraints completely by simply specifying a very large constraint
	/// distance. The default constraint strategy is DEFAULT.
	/// </summary>
	public void SetConstraintStrategyToConstraintArray()
	{
		vtkConstrainedSmoothingFilter_SetConstraintStrategyToConstraintArray_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetConstraintStrategyToConstraintDistance_32(HandleRef pThis);

	/// <summary>
	/// Indicate how to apply constraints. By default, a constraint array takes
	/// precedence over the filter's constraint distance, but if not available
	/// then the constraint distance is used. If a CONSTRAINT_ARRAY strategy is
	/// specified, and no constraint array is available from the point data,
	/// then no constraints are provided. Note that is also possible to turn off
	/// constraints completely by simply specifying a very large constraint
	/// distance. The default constraint strategy is DEFAULT.
	/// </summary>
	public void SetConstraintStrategyToConstraintDistance()
	{
		vtkConstrainedSmoothingFilter_SetConstraintStrategyToConstraintDistance_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetConstraintStrategyToDefault_33(HandleRef pThis);

	/// <summary>
	/// Indicate how to apply constraints. By default, a constraint array takes
	/// precedence over the filter's constraint distance, but if not available
	/// then the constraint distance is used. If a CONSTRAINT_ARRAY strategy is
	/// specified, and no constraint array is available from the point data,
	/// then no constraints are provided. Note that is also possible to turn off
	/// constraints completely by simply specifying a very large constraint
	/// distance. The default constraint strategy is DEFAULT.
	/// </summary>
	public void SetConstraintStrategyToDefault()
	{
		vtkConstrainedSmoothingFilter_SetConstraintStrategyToDefault_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetConvergence_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a convergence criterion for the iteration process. Smaller
	/// numbers result in more smoothing iterations. Convergence occurs
	/// when, for the current iteration, the maximum distance any point moves
	/// is less than or equal to Convergence. The default value is 0.
	/// </summary>
	public virtual void SetConvergence(double _arg)
	{
		vtkConstrainedSmoothingFilter_SetConvergence_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetGenerateErrorScalars_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the generation of scalar distance values. By default, the
	/// generation of error scalars is disabled.
	/// </summary>
	public virtual void SetGenerateErrorScalars(bool _arg)
	{
		vtkConstrainedSmoothingFilter_SetGenerateErrorScalars_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetGenerateErrorVectors_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the generation of error vectors. By default, the generation
	/// of error vectors is disabled.
	/// </summary>
	public virtual void SetGenerateErrorVectors(bool _arg)
	{
		vtkConstrainedSmoothingFilter_SetGenerateErrorVectors_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetNumberOfIterations_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the maximum number of iterations for smoothing. The number
	/// of iterations may be less if the smoothing process converges. The
	/// default value is 10.
	/// </summary>
	public virtual void SetNumberOfIterations(int _arg)
	{
		vtkConstrainedSmoothingFilter_SetNumberOfIterations_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetOutputPointsPrecision_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkConstrainedSmoothingFilter_SetOutputPointsPrecision_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetRelaxationFactor_39(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the relaxation factor for smoothing. As in all iterative
	/// methods, the stability of the process is sensitive to this parameter. In
	/// general, small relaxation factors and large numbers of iterations are
	/// more stable than larger relaxation factors and smaller numbers of
	/// iterations. The default value is 0.01.
	/// </summary>
	public virtual void SetRelaxationFactor(double _arg)
	{
		vtkConstrainedSmoothingFilter_SetRelaxationFactor_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedSmoothingFilter_SetSmoothingStencils_40(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Set / get the point smoothing stencils. Here we are repurposing a cell
	/// array to define stencils. Basically what's happening is that each point
	/// is treated a "cell" connected to a list of point ids (i.e., the
	/// "stencil") that defines the smoothing edge connections. By default, no
	/// smoothing stencils are defined.
	/// </summary>
	public virtual void SetSmoothingStencils(vtkCellArray _arg)
	{
		vtkConstrainedSmoothingFilter_SetSmoothingStencils_40(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}
}
