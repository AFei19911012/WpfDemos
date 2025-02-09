using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStreamTracer
/// </summary>
/// <remarks>
///    Streamline generator
///
/// vtkStreamTracer is a filter that integrates a vector field to generate
/// streamlines. The integration is performed using a specified integrator,
/// by default Runge-Kutta2.
///
/// vtkStreamTracer produces polylines as the output, with each cell (i.e.,
/// polyline) representing a streamline. The attribute values associated
/// with each streamline are stored in the cell data, whereas those
/// associated with streamline-points are stored in the point data.
///
/// vtkStreamTracer supports forward (the default), backward, and combined
/// (i.e., BOTH) integration. The length of a streamline is governed by
/// specifying a maximum value either in physical arc length or in (local)
/// cell length. Otherwise, the integration terminates upon exiting the
/// flow field domain, or if the particle speed is reduced to a value less
/// than a specified terminal speed, or when a maximum number of steps is
/// completed. The specific reason for the termination is stored in a cell
/// array named ReasonForTermination.
///
/// Note that normalized vectors are adopted in streamline integration,
/// which achieves high numerical accuracy/smoothness of flow lines that is
/// particularly guaranteed for Runge-Kutta45 with adaptive step size and
/// error control). In support of this feature, the underlying step size is
/// ALWAYS in arc length unit (LENGTH_UNIT) while the 'real' time interval
/// (virtual for steady flows) that a particle actually takes to trave in a
/// single step is obtained by dividing the arc length by the LOCAL speed.
/// The overall elapsed time (i.e., the life span) of the particle is the
/// sum of those individual step-wise time intervals.
///
/// The quality of streamline integration can be controlled by setting the
/// initial integration step (InitialIntegrationStep), particularly for
/// Runge-Kutta2 and Runge-Kutta4 (with a fixed step size), and in the case
/// of Runge-Kutta45 (with an adaptive step size and error control) the
/// minimum integration step, the maximum integration step, and the maximum
/// error. These steps are in either LENGTH_UNIT or CELL_LENGTH_UNIT while
/// the error is in physical arc length. For the former two integrators,
/// there is a trade-off between integration speed and streamline quality.
///
/// The integration time, vorticity, rotation and angular velocity are stored
/// in point data arrays named "IntegrationTime", "Vorticity", "Rotation" and
/// "AngularVelocity", respectively (vorticity, rotation and angular velocity
/// are computed only when ComputeVorticity is on). All point data attributes
/// in the source dataset are interpolated on the new streamline points.
///
/// vtkStreamTracer supports integration through any type of dataset. Thus if
/// the dataset contains 2D cells like polygons or triangles, the integration
/// is constrained to lie on the surface defined by 2D cells.
///
/// The starting point, or the so-called 'seed', of a streamline may be set in
/// two different ways. Starting from global x-y-z "position" allows you to
/// start a single trace at a specified x-y-z coordinate. If you specify a
/// source object, traces will be generated from each point in the source that
/// is inside the dataset. Note that if the integration direction is BOTH,
/// then potentially 2N streamlines will be generated given N seed points.
///
/// @note This class has been threaded using vtkSMPTools. Each separate
/// streamline (corresponding to the initial seeds) is processed in a
/// separate thread. Consequently, if threading is enabled and many
/// streamlines are generated, significant performance improvement is
/// possible.
///
/// @note Field data is shallow copied to the output. When the input is a
/// composite data set, field data associated with the root block is shallow-
/// copied to the output vtkPolyData.
///
/// </remarks>
/// <seealso>
///
/// vtkRibbonFilter vtkRuledSurfaceFilter vtkInitialValueProblemSolver
/// vtkRungeKutta2 vtkRungeKutta4 vtkRungeKutta45 vtkParticleTracerBase
/// vtkParticleTracer vtkParticlePathFilter vtkStreaklineFilter
/// vtkAbstractInterpolatedVelocityField vtkCompositeInterpolatedVelocityField
/// vtkAMRInterpolatedVelocityField vtkSMPTools vtkPStreamTracer
/// </seealso>
public class vtkStreamTracer : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Specify whether streamlines should be computed on a surface.
	/// </summary>
	public enum BACKWARD_WrapperEnum
	{
		/// <summary>enum member</summary>
		BACKWARD = 1,
		/// <summary>enum member</summary>
		BOTH = 2,
		/// <summary>enum member</summary>
		FORWARD = 0
	}

	/// <summary>
	/// Specify whether streamlines should be computed on a surface.
	/// </summary>
	public enum INTERPOLATOR_WITH_CELL_LOCATOR_WrapperEnum
	{
		/// <summary>enum member</summary>
		INTERPOLATOR_WITH_CELL_LOCATOR = 1,
		/// <summary>enum member</summary>
		INTERPOLATOR_WITH_DATASET_POINT_LOCATOR = 0
	}

	/// <summary>
	/// Specify the source object used to generate starting points (seeds).
	/// This method connects to the pipeline: the Source will be updated
	/// and the results used as streamline seeds.
	/// </summary>
	public enum ReasonForTermination
	{
		/// <summary>enum member</summary>
		FIXED_REASONS_FOR_TERMINATION_COUNT = 7,
		/// <summary>enum member</summary>
		NOT_INITIALIZED = 2,
		/// <summary>enum member</summary>
		OUT_OF_DOMAIN = 1,
		/// <summary>enum member</summary>
		OUT_OF_LENGTH = 4,
		/// <summary>enum member</summary>
		OUT_OF_STEPS = 5,
		/// <summary>enum member</summary>
		STAGNATION = 6,
		/// <summary>enum member</summary>
		UNEXPECTED_VALUE = 3
	}

	/// <summary>
	/// Specify the source object used to generate starting points (seeds).
	/// This method connects to the pipeline: the Source will be updated
	/// and the results used as streamline seeds.
	/// </summary>
	public enum Solvers
	{
		/// <summary>enum member</summary>
		NONE = 3,
		/// <summary>enum member</summary>
		RUNGE_KUTTA2 = 0,
		/// <summary>enum member</summary>
		RUNGE_KUTTA4 = 1,
		/// <summary>enum member</summary>
		RUNGE_KUTTA45 = 2,
		/// <summary>enum member</summary>
		UNKNOWN = 4
	}

	/// <summary>
	/// Specify the source object used to generate starting points (seeds).
	/// This method connects to the pipeline: the Source will be updated
	/// and the results used as streamline seeds.
	/// </summary>
	public enum Units
	{
		/// <summary>enum member</summary>
		CELL_LENGTH_UNIT = 2,
		/// <summary>enum member</summary>
		LENGTH_UNIT = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStreamTracer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStreamTracer()
	{
		MRClassNameKey = "class vtkStreamTracer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamTracer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStreamTracer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamTracer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct the object to start from position (0,0,0), with forward
	/// integration, terminal speed 1.0E-12, vorticity computation on,
	/// integration step size 0.5 (in cell length unit), maximum number
	/// of steps 2000, using Runge-Kutta2, and maximum propagation 1.0
	/// (in arc length unit).
	/// </summary>
	public new static vtkStreamTracer New()
	{
		vtkStreamTracer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamTracer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct the object to start from position (0,0,0), with forward
	/// integration, terminal speed 1.0E-12, vorticity computation on,
	/// integration step size 0.5 (in cell length unit), maximum number
	/// of steps 2000, using Runge-Kutta2, and maximum propagation 1.0
	/// (in arc length unit).
	/// </summary>
	public vtkStreamTracer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStreamTracer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_CalculateVorticity_01(HandleRef pThis, HandleRef cell, IntPtr pcoords, HandleRef cellVectors, IntPtr vorticity);

	/// <summary>
	/// Helper methods to generate normals on streamlines. Made public so internal threaded
	/// classes in anonymous namespace can invoke the methods.
	/// </summary>
	public void CalculateVorticity(vtkGenericCell cell, IntPtr pcoords, vtkDoubleArray cellVectors, IntPtr vorticity)
	{
		vtkStreamTracer_CalculateVorticity_01(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), pcoords, cellVectors?.GetCppThis() ?? default(HandleRef), vorticity);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_ConvertIntervals_02(HandleRef pThis, ref double step, ref double minStep, ref double maxStep, int direction, double cellLength);

	/// <summary>
	/// Helper method to convert between length scales. Made public so internal threaded
	/// classes in anonymous namespace can invoke the method.
	/// </summary>
	public void ConvertIntervals(ref double step, ref double minStep, ref double maxStep, int direction, double cellLength)
	{
		vtkStreamTracer_ConvertIntervals_02(GetCppThis(), ref step, ref minStep, ref maxStep, direction, cellLength);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_ForceSerialExecutionOff_03(HandleRef pThis);

	/// <summary>
	/// Force the filter to run stream tracer advection in serial. This affects
	/// the filter only if more than one streamline is to be generated.
	/// </summary>
	public virtual void ForceSerialExecutionOff()
	{
		vtkStreamTracer_ForceSerialExecutionOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_ForceSerialExecutionOn_04(HandleRef pThis);

	/// <summary>
	/// Force the filter to run stream tracer advection in serial. This affects
	/// the filter only if more than one streamline is to be generated.
	/// </summary>
	public virtual void ForceSerialExecutionOn()
	{
		vtkStreamTracer_ForceSerialExecutionOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_GenerateNormals_05(HandleRef pThis, HandleRef output, IntPtr firstNormal, string vecName);

	/// <summary>
	/// Helper methods to generate normals on streamlines. Made public so internal threaded
	/// classes in anonymous namespace can invoke the methods.
	/// </summary>
	public void GenerateNormals(vtkPolyData output, IntPtr firstNormal, string vecName)
	{
		vtkStreamTracer_GenerateNormals_05(GetCppThis(), output?.GetCppThis() ?? default(HandleRef), firstNormal, vecName);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStreamTracer_GetComputeVorticity_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off vorticity computation at streamline points
	/// (necessary for generating proper stream-ribbons using the
	/// vtkRibbonFilter).
	/// </summary>
	public virtual bool GetComputeVorticity()
	{
		return (vtkStreamTracer_GetComputeVorticity_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStreamTracer_GetForceSerialExecution_07(HandleRef pThis);

	/// <summary>
	/// Force the filter to run stream tracer advection in serial. This affects
	/// the filter only if more than one streamline is to be generated.
	/// </summary>
	public virtual bool GetForceSerialExecution()
	{
		return (vtkStreamTracer_GetForceSerialExecution_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStreamTracer_GetInitialIntegrationStep_08(HandleRef pThis);

	/// <summary>
	/// Specify the Initial step size used for line integration, expressed in:
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// (either the starting size for an adaptive integrator, e.g., RK45,
	/// or the constant / fixed size for non-adaptive ones, i.e., RK2 and RK4)
	/// </summary>
	public virtual double GetInitialIntegrationStep()
	{
		return vtkStreamTracer_GetInitialIntegrationStep_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamTracer_GetIntegrationDirection_09(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamline is integrated in the upstream or
	/// downstream direction, or in both directions. (If integrated in both
	/// directions, two separate streamlines are generated, both of which which
	/// start at the seed point with one traveling in the forward direction, and
	/// one in the backward direction.)
	/// </summary>
	public virtual int GetIntegrationDirection()
	{
		return vtkStreamTracer_GetIntegrationDirection_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamTracer_GetIntegrationDirectionMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamline is integrated in the upstream or
	/// downstream direction, or in both directions. (If integrated in both
	/// directions, two separate streamlines are generated, both of which which
	/// start at the seed point with one traveling in the forward direction, and
	/// one in the backward direction.)
	/// </summary>
	public virtual int GetIntegrationDirectionMaxValue()
	{
		return vtkStreamTracer_GetIntegrationDirectionMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamTracer_GetIntegrationDirectionMinValue_11(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamline is integrated in the upstream or
	/// downstream direction, or in both directions. (If integrated in both
	/// directions, two separate streamlines are generated, both of which which
	/// start at the seed point with one traveling in the forward direction, and
	/// one in the backward direction.)
	/// </summary>
	public virtual int GetIntegrationDirectionMinValue()
	{
		return vtkStreamTracer_GetIntegrationDirectionMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamTracer_GetIntegrationStepUnit_12(HandleRef pThis);

	/// <summary>
	/// Specify a uniform integration step unit for MinimumIntegrationStep,
	/// InitialIntegrationStep, and MaximumIntegrationStep. NOTE: The valid
	/// unit is now limited to only LENGTH_UNIT (1) and CELL_LENGTH_UNIT (2),
	/// EXCLUDING the previously-supported TIME_UNIT.
	/// </summary>
	public int GetIntegrationStepUnit()
	{
		return vtkStreamTracer_GetIntegrationStepUnit_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamTracer_GetIntegrator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public virtual vtkInitialValueProblemSolver GetIntegrator()
	{
		vtkInitialValueProblemSolver vtkInitialValueProblemSolver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamTracer_GetIntegrator_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInitialValueProblemSolver2 = (vtkInitialValueProblemSolver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInitialValueProblemSolver2.Register(null);
			}
		}
		return vtkInitialValueProblemSolver2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamTracer_GetIntegratorType_14(HandleRef pThis);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public int GetIntegratorType()
	{
		return vtkStreamTracer_GetIntegratorType_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStreamTracer_GetMaximumError_15(HandleRef pThis);

	/// <summary>
	/// Specify the maximum error tolerated throughout streamline integration.
	/// </summary>
	public virtual double GetMaximumError()
	{
		return vtkStreamTracer_GetMaximumError_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStreamTracer_GetMaximumIntegrationStep_16(HandleRef pThis);

	/// <summary>
	/// Specify the Maximum step size used for line integration, expressed in:
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// (Only valid for an adaptive integrator, e.g., RK45)
	/// </summary>
	public virtual double GetMaximumIntegrationStep()
	{
		return vtkStreamTracer_GetMaximumIntegrationStep_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStreamTracer_GetMaximumNumberOfSteps_17(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of steps for integrating a streamline. Note
	/// that the number of steps generated is always one greater than
	/// MaximumNumberOfSteps. So if MaximumNumberOfSteps==0, then only one step
	/// will be generated. This is useful for advection situations when the
	/// stream tracer is to be propagated just one step at a time (e.g., see
	/// vtkStreamSurface which depends on this behavior).
	/// </summary>
	public virtual long GetMaximumNumberOfSteps()
	{
		return vtkStreamTracer_GetMaximumNumberOfSteps_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStreamTracer_GetMaximumPropagation_18(HandleRef pThis);

	/// <summary>
	/// Specify the maximum length of a streamline expressed in LENGTH_UNIT.
	/// </summary>
	public virtual double GetMaximumPropagation()
	{
		return vtkStreamTracer_GetMaximumPropagation_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStreamTracer_GetMinimumIntegrationStep_19(HandleRef pThis);

	/// <summary>
	/// Specify the Minimum step size used for line integration, expressed in:
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// (Only valid for an adaptive integrator, e.g., RK45)
	/// </summary>
	public virtual double GetMinimumIntegrationStep()
	{
		return vtkStreamTracer_GetMinimumIntegrationStep_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStreamTracer_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to obtain type information and print object state.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStreamTracer_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStreamTracer_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	/// Standard methods to obtain type information and print object state.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStreamTracer_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStreamTracer_GetRotationScale_22(HandleRef pThis);

	/// <summary>
	/// This can be used to scale the rate with which the streamribbons
	/// twist. The default is 1.
	/// </summary>
	public virtual double GetRotationScale()
	{
		return vtkStreamTracer_GetRotationScale_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamTracer_GetSource_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the source object used to generate starting points (seeds).
	/// Note that this method does not connect the pipeline. The algorithm will
	/// work on the input data as it is without updating the producer of the data.
	/// See SetSourceConnection for connecting the pipeline.
	/// </summary>
	public vtkDataSet GetSource()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamTracer_GetSource_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamTracer_GetStartPosition_24(HandleRef pThis);

	/// <summary>
	/// Specify the starting point (seed) of a streamline in the global
	/// coordinate system. Search must be performed to find the initial cell
	/// from which to start integration.
	/// </summary>
	public virtual double[] GetStartPosition()
	{
		IntPtr intPtr = vtkStreamTracer_GetStartPosition_24(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_GetStartPosition_25(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Specify the starting point (seed) of a streamline in the global
	/// coordinate system. Search must be performed to find the initial cell
	/// from which to start integration.
	/// </summary>
	public virtual void GetStartPosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkStreamTracer_GetStartPosition_25(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_GetStartPosition_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the starting point (seed) of a streamline in the global
	/// coordinate system. Search must be performed to find the initial cell
	/// from which to start integration.
	/// </summary>
	public virtual void GetStartPosition(IntPtr _arg)
	{
		vtkStreamTracer_GetStartPosition_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStreamTracer_GetSurfaceStreamlines_27(HandleRef pThis);

	/// <summary>
	/// Specify whether streamlines should be computed on a surface.
	/// </summary>
	public virtual bool GetSurfaceStreamlines()
	{
		return (vtkStreamTracer_GetSurfaceStreamlines_27(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStreamTracer_GetTerminalSpeed_28(HandleRef pThis);

	/// <summary>
	/// Specify the terminal speed value, below which streamline integration is
	/// terminated.
	/// </summary>
	public virtual double GetTerminalSpeed()
	{
		return vtkStreamTracer_GetTerminalSpeed_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStreamTracer_GetUseLocalSeedSource_29(HandleRef pThis);

	/// <summary>
	/// If true the filter considers that the whole seed source is available on all ranks.
	/// Else the filter will aggregate all seed sources from all ranks and merge their points.
	///
	/// This property only makes sense when the filter is parallelized and is a no-op for its
	/// sequential version. However, this member function needs to be defined in this class to
	/// maintain a uniform interface between vtkStreamTracer and its parallel override class,
	/// vtkPStreamTracer.
	/// Default is true.
	/// </summary>
	public virtual bool GetUseLocalSeedSource()
	{
		return (vtkStreamTracer_GetUseLocalSeedSource_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamTracer_IsA_30(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to obtain type information and print object state.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStreamTracer_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamTracer_IsTypeOf_31(string type);

	/// <summary>
	/// Standard methods to obtain type information and print object state.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStreamTracer_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamTracer_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to obtain type information and print object state.
	/// </summary>
	public new vtkStreamTracer NewInstance()
	{
		vtkStreamTracer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamTracer_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamTracer_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to obtain type information and print object state.
	/// </summary>
	public new static vtkStreamTracer SafeDownCast(vtkObjectBase o)
	{
		vtkStreamTracer vtkStreamTracer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamTracer_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStreamTracer2 = (vtkStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStreamTracer2.Register(null);
			}
		}
		return vtkStreamTracer2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetComputeVorticity_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off vorticity computation at streamline points
	/// (necessary for generating proper stream-ribbons using the
	/// vtkRibbonFilter).
	/// </summary>
	public virtual void SetComputeVorticity(bool _arg)
	{
		vtkStreamTracer_SetComputeVorticity_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetForceSerialExecution_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Force the filter to run stream tracer advection in serial. This affects
	/// the filter only if more than one streamline is to be generated.
	/// </summary>
	public virtual void SetForceSerialExecution(bool _arg)
	{
		vtkStreamTracer_SetForceSerialExecution_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetInitialIntegrationStep_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the Initial step size used for line integration, expressed in:
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// (either the starting size for an adaptive integrator, e.g., RK45,
	/// or the constant / fixed size for non-adaptive ones, i.e., RK2 and RK4)
	/// </summary>
	public virtual void SetInitialIntegrationStep(double _arg)
	{
		vtkStreamTracer_SetInitialIntegrationStep_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetIntegrationDirection_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether the streamline is integrated in the upstream or
	/// downstream direction, or in both directions. (If integrated in both
	/// directions, two separate streamlines are generated, both of which which
	/// start at the seed point with one traveling in the forward direction, and
	/// one in the backward direction.)
	/// </summary>
	public virtual void SetIntegrationDirection(int _arg)
	{
		vtkStreamTracer_SetIntegrationDirection_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetIntegrationDirectionToBackward_39(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamline is integrated in the upstream or
	/// downstream direction, or in both directions. (If integrated in both
	/// directions, two separate streamlines are generated, both of which which
	/// start at the seed point with one traveling in the forward direction, and
	/// one in the backward direction.)
	/// </summary>
	public void SetIntegrationDirectionToBackward()
	{
		vtkStreamTracer_SetIntegrationDirectionToBackward_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetIntegrationDirectionToBoth_40(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamline is integrated in the upstream or
	/// downstream direction, or in both directions. (If integrated in both
	/// directions, two separate streamlines are generated, both of which which
	/// start at the seed point with one traveling in the forward direction, and
	/// one in the backward direction.)
	/// </summary>
	public void SetIntegrationDirectionToBoth()
	{
		vtkStreamTracer_SetIntegrationDirectionToBoth_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetIntegrationDirectionToForward_41(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamline is integrated in the upstream or
	/// downstream direction, or in both directions. (If integrated in both
	/// directions, two separate streamlines are generated, both of which which
	/// start at the seed point with one traveling in the forward direction, and
	/// one in the backward direction.)
	/// </summary>
	public void SetIntegrationDirectionToForward()
	{
		vtkStreamTracer_SetIntegrationDirectionToForward_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetIntegrationStepUnit_42(HandleRef pThis, int unit);

	/// <summary>
	/// Specify a uniform integration step unit for MinimumIntegrationStep,
	/// InitialIntegrationStep, and MaximumIntegrationStep. NOTE: The valid
	/// unit is now limited to only LENGTH_UNIT (1) and CELL_LENGTH_UNIT (2),
	/// EXCLUDING the previously-supported TIME_UNIT.
	/// </summary>
	public void SetIntegrationStepUnit(int unit)
	{
		vtkStreamTracer_SetIntegrationStepUnit_42(GetCppThis(), unit);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetIntegrator_43(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public void SetIntegrator(vtkInitialValueProblemSolver arg0)
	{
		vtkStreamTracer_SetIntegrator_43(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetIntegratorType_44(HandleRef pThis, int type);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public void SetIntegratorType(int type)
	{
		vtkStreamTracer_SetIntegratorType_44(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetIntegratorTypeToRungeKutta2_45(HandleRef pThis);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public void SetIntegratorTypeToRungeKutta2()
	{
		vtkStreamTracer_SetIntegratorTypeToRungeKutta2_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetIntegratorTypeToRungeKutta4_46(HandleRef pThis);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public void SetIntegratorTypeToRungeKutta4()
	{
		vtkStreamTracer_SetIntegratorTypeToRungeKutta4_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetIntegratorTypeToRungeKutta45_47(HandleRef pThis);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public void SetIntegratorTypeToRungeKutta45()
	{
		vtkStreamTracer_SetIntegratorTypeToRungeKutta45_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetInterpolatorPrototype_48(HandleRef pThis, HandleRef ivf);

	/// <summary>
	/// The object used to interpolate the velocity field during integration is
	/// of the same class as this prototype. The performance of streamline
	/// generations can be significantly affected by the choice of the
	/// interpolator, particularly its use of the locator to use.
	///
	/// For non AMR datasets, initialize a vtkCompositeInterpolatedVelocityField
	/// and set the FindCellStrategyType.
	/// </summary>
	public void SetInterpolatorPrototype(vtkAbstractInterpolatedVelocityField ivf)
	{
		vtkStreamTracer_SetInterpolatorPrototype_48(GetCppThis(), ivf?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetInterpolatorType_49(HandleRef pThis, int interpType);

	/// <summary>
	/// Set the type of the velocity field interpolator to determine whether
	/// INTERPOLATOR_WITH_DATASET_POINT_LOCATOR or INTERPOLATOR_WITH_CELL_LOCATOR
	/// is employed for locating cells during streamline integration. The latter
	/// (adopting vtkAbstractCellLocator sub-classes such as vtkCellLocator and
	/// vtkModifiedBSPTree) is more robust than the former (through vtkDataSet /
	/// vtkPointSet::FindCell() coupled with vtkPointLocator). However the former
	/// can be much faster and produce adequate results.
	/// </summary>
	public void SetInterpolatorType(int interpType)
	{
		vtkStreamTracer_SetInterpolatorType_49(GetCppThis(), interpType);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetInterpolatorTypeToCellLocator_50(HandleRef pThis);

	/// <summary>
	/// Set the velocity field interpolator type to one that uses a cell locator
	/// to perform spatial searching. Using a cell locator should always return
	/// the correct results, but it can be much slower that point locator-based
	/// searches.
	/// </summary>
	public void SetInterpolatorTypeToCellLocator()
	{
		vtkStreamTracer_SetInterpolatorTypeToCellLocator_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetInterpolatorTypeToDataSetPointLocator_51(HandleRef pThis);

	/// <summary>
	/// Set the velocity field interpolator type to one that uses a point
	/// locator to perform local spatial searching. Typically a point locator is
	/// faster than searches with a cell locator, but it may not always find the
	/// correct cells enclosing a point. This is particularly true with meshes
	/// that are disjoint at seams, or abut meshes in an incompatible manner.
	/// By default (and if a InterpolationPrototype is not set), a point locator
	/// is used.
	/// </summary>
	public void SetInterpolatorTypeToDataSetPointLocator()
	{
		vtkStreamTracer_SetInterpolatorTypeToDataSetPointLocator_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetMaximumError_52(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the maximum error tolerated throughout streamline integration.
	/// </summary>
	public virtual void SetMaximumError(double _arg)
	{
		vtkStreamTracer_SetMaximumError_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetMaximumIntegrationStep_53(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the Maximum step size used for line integration, expressed in:
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// (Only valid for an adaptive integrator, e.g., RK45)
	/// </summary>
	public virtual void SetMaximumIntegrationStep(double _arg)
	{
		vtkStreamTracer_SetMaximumIntegrationStep_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetMaximumNumberOfSteps_54(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the maximum number of steps for integrating a streamline. Note
	/// that the number of steps generated is always one greater than
	/// MaximumNumberOfSteps. So if MaximumNumberOfSteps==0, then only one step
	/// will be generated. This is useful for advection situations when the
	/// stream tracer is to be propagated just one step at a time (e.g., see
	/// vtkStreamSurface which depends on this behavior).
	/// </summary>
	public virtual void SetMaximumNumberOfSteps(long _arg)
	{
		vtkStreamTracer_SetMaximumNumberOfSteps_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetMaximumPropagation_55(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the maximum length of a streamline expressed in LENGTH_UNIT.
	/// </summary>
	public virtual void SetMaximumPropagation(double _arg)
	{
		vtkStreamTracer_SetMaximumPropagation_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetMinimumIntegrationStep_56(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the Minimum step size used for line integration, expressed in:
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// (Only valid for an adaptive integrator, e.g., RK45)
	/// </summary>
	public virtual void SetMinimumIntegrationStep(double _arg)
	{
		vtkStreamTracer_SetMinimumIntegrationStep_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetRotationScale_57(HandleRef pThis, double _arg);

	/// <summary>
	/// This can be used to scale the rate with which the streamribbons
	/// twist. The default is 1.
	/// </summary>
	public virtual void SetRotationScale(double _arg)
	{
		vtkStreamTracer_SetRotationScale_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetSourceConnection_58(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the source object used to generate starting points (seeds).
	/// This method connects to the pipeline: the Source will be updated
	/// and the results used as streamline seeds.
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkStreamTracer_SetSourceConnection_58(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetSourceData_59(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the source object used to generate starting points (seeds).
	/// Note that this method does not connect the pipeline. The algorithm will
	/// work on the input data as it is without updating the producer of the data.
	/// See SetSourceConnection for connecting the pipeline.
	/// </summary>
	public void SetSourceData(vtkDataSet source)
	{
		vtkStreamTracer_SetSourceData_59(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetStartPosition_60(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify the starting point (seed) of a streamline in the global
	/// coordinate system. Search must be performed to find the initial cell
	/// from which to start integration.
	/// </summary>
	public virtual void SetStartPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkStreamTracer_SetStartPosition_60(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetStartPosition_61(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the starting point (seed) of a streamline in the global
	/// coordinate system. Search must be performed to find the initial cell
	/// from which to start integration.
	/// </summary>
	public virtual void SetStartPosition(IntPtr _arg)
	{
		vtkStreamTracer_SetStartPosition_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetSurfaceStreamlines_62(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether streamlines should be computed on a surface.
	/// </summary>
	public virtual void SetSurfaceStreamlines(bool _arg)
	{
		vtkStreamTracer_SetSurfaceStreamlines_62(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetTerminalSpeed_63(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the terminal speed value, below which streamline integration is
	/// terminated.
	/// </summary>
	public virtual void SetTerminalSpeed(double _arg)
	{
		vtkStreamTracer_SetTerminalSpeed_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SetUseLocalSeedSource_64(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true the filter considers that the whole seed source is available on all ranks.
	/// Else the filter will aggregate all seed sources from all ranks and merge their points.
	///
	/// This property only makes sense when the filter is parallelized and is a no-op for its
	/// sequential version. However, this member function needs to be defined in this class to
	/// maintain a uniform interface between vtkStreamTracer and its parallel override class,
	/// vtkPStreamTracer.
	/// Default is true.
	/// </summary>
	public virtual void SetUseLocalSeedSource(bool _arg)
	{
		vtkStreamTracer_SetUseLocalSeedSource_64(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SurfaceStreamlinesOff_65(HandleRef pThis);

	/// <summary>
	/// Specify whether streamlines should be computed on a surface.
	/// </summary>
	public virtual void SurfaceStreamlinesOff()
	{
		vtkStreamTracer_SurfaceStreamlinesOff_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_SurfaceStreamlinesOn_66(HandleRef pThis);

	/// <summary>
	/// Specify whether streamlines should be computed on a surface.
	/// </summary>
	public virtual void SurfaceStreamlinesOn()
	{
		vtkStreamTracer_SurfaceStreamlinesOn_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_UseLocalSeedSourceOff_67(HandleRef pThis);

	/// <summary>
	/// If true the filter considers that the whole seed source is available on all ranks.
	/// Else the filter will aggregate all seed sources from all ranks and merge their points.
	///
	/// This property only makes sense when the filter is parallelized and is a no-op for its
	/// sequential version. However, this member function needs to be defined in this class to
	/// maintain a uniform interface between vtkStreamTracer and its parallel override class,
	/// vtkPStreamTracer.
	/// Default is true.
	/// </summary>
	public virtual void UseLocalSeedSourceOff()
	{
		vtkStreamTracer_UseLocalSeedSourceOff_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamTracer_UseLocalSeedSourceOn_68(HandleRef pThis);

	/// <summary>
	/// If true the filter considers that the whole seed source is available on all ranks.
	/// Else the filter will aggregate all seed sources from all ranks and merge their points.
	///
	/// This property only makes sense when the filter is parallelized and is a no-op for its
	/// sequential version. However, this member function needs to be defined in this class to
	/// maintain a uniform interface between vtkStreamTracer and its parallel override class,
	/// vtkPStreamTracer.
	/// Default is true.
	/// </summary>
	public virtual void UseLocalSeedSourceOn()
	{
		vtkStreamTracer_UseLocalSeedSourceOn_68(GetCppThis());
	}
}
