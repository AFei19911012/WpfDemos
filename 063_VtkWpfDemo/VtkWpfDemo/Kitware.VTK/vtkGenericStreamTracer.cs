using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericStreamTracer
/// </summary>
/// <remarks>
///    Streamline generator
///
/// vtkGenericStreamTracer is a filter that integrates a vector field to
/// generate streamlines. The integration is performed using the provided
/// integrator. The default is second order Runge-Kutta.
///
/// vtkGenericStreamTracer generate polylines as output. Each cell (polyline)
/// corresponds to one streamline. The values associated with each streamline
/// are stored in the cell data whereas the values associated with points
/// are stored in point data.
///
/// Note that vtkGenericStreamTracer can integrate both forward and backward.
/// The length of the streamline is controlled by specifying either
/// a maximum value in the units of length, cell length or elapsed time
/// (the elapsed time is the time each particle would have traveled if
/// flow were steady). Otherwise, the integration terminates after exiting
/// the dataset or if the particle speed is reduced to a value less than
/// the terminal speed or when a maximum number of steps is reached.
/// The reason for the termination is stored in a cell array named
/// ReasonForTermination.
///
/// The quality of integration can be controlled by setting integration
/// step (InitialIntegrationStep) and in the case of adaptive solvers
/// the maximum error, the minimum integration step and the maximum
/// integration step. All of these can have units of length, cell length
/// or elapsed time.
///
/// The integration time, vorticity, rotation and angular velocity
/// are stored in point arrays named "IntegrationTime", "Vorticity",
/// "Rotation" and "AngularVelocity" respectively (vorticity, rotation
/// and angular velocity are computed only when ComputeVorticity is on).
/// All point attributes in the source data set are interpolated on the
/// new streamline points.
///
/// vtkGenericStreamTracer integrates through any type of dataset. As a result,
/// if the dataset contains 2D cells such as polygons or triangles, the
/// integration is constrained to lie on the surface defined by the 2D cells.
///
/// The starting point of traces may be defined in two different ways.
/// Starting from global x-y-z "position" allows you to start a single trace
/// at a specified x-y-z coordinate. If you specify a source object,
/// a trace will be generated for each point in the source that is
/// inside the dataset.
///
/// </remarks>
/// <seealso>
///
/// vtkRibbonFilter vtkRuledSurfaceFilter vtkInitialValueProblemSolver
/// vtkRungeKutta2 vtkRungeKutta4 vtkRungeKutta45
/// </seealso>
public class vtkGenericStreamTracer : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Simplified API to set an homogeneous unit across Min/Max/Init IntegrationStepUnit
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
	/// Specify the source object used to generate starting points (seeds).
	/// New style.
	/// </summary>
	public enum ReasonForTermination
	{
		/// <summary>enum member</summary>
		NOT_INITIALIZED = 2,
		/// <summary>enum member</summary>
		OUT_OF_DOMAIN = 1,
		/// <summary>enum member</summary>
		OUT_OF_STEPS = 5,
		/// <summary>enum member</summary>
		OUT_OF_TIME = 4,
		/// <summary>enum member</summary>
		STAGNATION = 6,
		/// <summary>enum member</summary>
		UNEXPECTED_VALUE = 3
	}

	/// <summary>
	/// Specify the source object used to generate starting points (seeds).
	/// New style.
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
	/// New style.
	/// </summary>
	public enum Units
	{
		/// <summary>enum member</summary>
		CELL_LENGTH_UNIT = 2,
		/// <summary>enum member</summary>
		LENGTH_UNIT = 1,
		/// <summary>enum member</summary>
		TIME_UNIT = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericStreamTracer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericStreamTracer()
	{
		MRClassNameKey = "class vtkGenericStreamTracer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericStreamTracer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericStreamTracer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericStreamTracer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object to start from position (0,0,0), integrate forward,
	/// terminal speed 1.0E-12, vorticity computation on, integration
	/// step length 0.5 (unit cell length), maximum number of steps 2000,
	/// using 2nd order Runge Kutta and maximum propagation 1.0 (unit length).
	/// </summary>
	public new static vtkGenericStreamTracer New()
	{
		vtkGenericStreamTracer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericStreamTracer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object to start from position (0,0,0), integrate forward,
	/// terminal speed 1.0E-12, vorticity computation on, integration
	/// step length 0.5 (unit cell length), maximum number of steps 2000,
	/// using 2nd order Runge Kutta and maximum propagation 1.0 (unit length).
	/// </summary>
	public vtkGenericStreamTracer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericStreamTracer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_AddInputData_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a dataset to the list inputs
	/// </summary>
	public void AddInputData(vtkGenericDataSet arg0)
	{
		vtkGenericStreamTracer_AddInputData_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_ComputeVorticityOff_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off calculation of vorticity at streamline points
	/// (necessary for generating proper streamribbons using the
	/// vtkRibbonFilter.
	/// </summary>
	public virtual void ComputeVorticityOff()
	{
		vtkGenericStreamTracer_ComputeVorticityOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_ComputeVorticityOn_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off calculation of vorticity at streamline points
	/// (necessary for generating proper streamribbons using the
	/// vtkRibbonFilter.
	/// </summary>
	public virtual void ComputeVorticityOn()
	{
		vtkGenericStreamTracer_ComputeVorticityOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_FillInputPortInformation_04(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Specify the source object used to generate starting points (seeds).
	/// New style.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkGenericStreamTracer_FillInputPortInformation_04(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_GetComputeVorticity_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off calculation of vorticity at streamline points
	/// (necessary for generating proper streamribbons using the
	/// vtkRibbonFilter.
	/// </summary>
	public virtual int GetComputeVorticity()
	{
		return vtkGenericStreamTracer_GetComputeVorticity_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericStreamTracer_GetInitialIntegrationStep_06(HandleRef pThis);

	/// <summary>
	/// Specify the initial step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// If the integrator is not adaptive, this is the actual
	/// step used.
	/// </summary>
	public double GetInitialIntegrationStep()
	{
		return vtkGenericStreamTracer_GetInitialIntegrationStep_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_GetInitialIntegrationStepUnit_07(HandleRef pThis);

	/// <summary>
	/// Specify the initial step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// If the integrator is not adaptive, this is the actual
	/// step used.
	/// </summary>
	public int GetInitialIntegrationStepUnit()
	{
		return vtkGenericStreamTracer_GetInitialIntegrationStepUnit_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericStreamTracer_GetInputVectorsSelection_08(HandleRef pThis);

	/// <summary>
	/// If you want to generate traces using an arbitrary vector array,
	/// then set its name here. By default this in nullptr and the filter will
	/// use the active vector array.
	/// </summary>
	public virtual string GetInputVectorsSelection()
	{
		return Marshal.PtrToStringAnsi(vtkGenericStreamTracer_GetInputVectorsSelection_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_GetIntegrationDirection_09(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamtrace will be generated in the
	/// upstream or downstream direction.
	/// </summary>
	public virtual int GetIntegrationDirection()
	{
		return vtkGenericStreamTracer_GetIntegrationDirection_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_GetIntegrationDirectionMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamtrace will be generated in the
	/// upstream or downstream direction.
	/// </summary>
	public virtual int GetIntegrationDirectionMaxValue()
	{
		return vtkGenericStreamTracer_GetIntegrationDirectionMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_GetIntegrationDirectionMinValue_11(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamtrace will be generated in the
	/// upstream or downstream direction.
	/// </summary>
	public virtual int GetIntegrationDirectionMinValue()
	{
		return vtkGenericStreamTracer_GetIntegrationDirectionMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericStreamTracer_GetIntegrator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the integrator type to be used in the stream line
	/// calculation. The object passed is not actually used but
	/// is cloned with NewInstance in the process of integration
	/// (prototype pattern). The default is 2nd order Runge Kutta.
	/// The integrator can also be changed using SetIntegratorType.
	/// The recognized solvers are:
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
		IntPtr intPtr = vtkGenericStreamTracer_GetIntegrator_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_GetIntegratorType_13(HandleRef pThis);

	/// <summary>
	/// Set/get the integrator type to be used in the stream line
	/// calculation. The object passed is not actually used but
	/// is cloned with NewInstance in the process of integration
	/// (prototype pattern). The default is 2nd order Runge Kutta.
	/// The integrator can also be changed using SetIntegratorType.
	/// The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public int GetIntegratorType()
	{
		return vtkGenericStreamTracer_GetIntegratorType_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericStreamTracer_GetMaximumError_14(HandleRef pThis);

	/// <summary>
	/// Specify the maximum error in the integration. This value
	/// is passed to the integrator. Therefore, it's meaning depends
	/// on the integrator used.
	/// </summary>
	public virtual double GetMaximumError()
	{
		return vtkGenericStreamTracer_GetMaximumError_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericStreamTracer_GetMaximumIntegrationStep_15(HandleRef pThis);

	/// <summary>
	/// Specify the maximum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public double GetMaximumIntegrationStep()
	{
		return vtkGenericStreamTracer_GetMaximumIntegrationStep_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_GetMaximumIntegrationStepUnit_16(HandleRef pThis);

	/// <summary>
	/// Specify the maximum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public int GetMaximumIntegrationStepUnit()
	{
		return vtkGenericStreamTracer_GetMaximumIntegrationStepUnit_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericStreamTracer_GetMaximumNumberOfSteps_17(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of steps used in the integration.
	/// </summary>
	public virtual long GetMaximumNumberOfSteps()
	{
		return vtkGenericStreamTracer_GetMaximumNumberOfSteps_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericStreamTracer_GetMaximumPropagation_18(HandleRef pThis);

	/// <summary>
	/// Specify the maximum length of the streamlines expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// </summary>
	public double GetMaximumPropagation()
	{
		return vtkGenericStreamTracer_GetMaximumPropagation_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_GetMaximumPropagationUnit_19(HandleRef pThis);

	/// <summary>
	/// Specify the maximum length of the streamlines expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// </summary>
	public int GetMaximumPropagationUnit()
	{
		return vtkGenericStreamTracer_GetMaximumPropagationUnit_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericStreamTracer_GetMinimumIntegrationStep_20(HandleRef pThis);

	/// <summary>
	/// Specify the minimum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public double GetMinimumIntegrationStep()
	{
		return vtkGenericStreamTracer_GetMinimumIntegrationStep_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_GetMinimumIntegrationStepUnit_21(HandleRef pThis);

	/// <summary>
	/// Specify the minimum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public int GetMinimumIntegrationStepUnit()
	{
		return vtkGenericStreamTracer_GetMinimumIntegrationStepUnit_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericStreamTracer_GetNumberOfGenerationsFromBase_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericStreamTracer_GetNumberOfGenerationsFromBase_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericStreamTracer_GetNumberOfGenerationsFromBaseType_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericStreamTracer_GetNumberOfGenerationsFromBaseType_23(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericStreamTracer_GetRotationScale_24(HandleRef pThis);

	/// <summary>
	/// This can be used to scale the rate with which the streamribbons
	/// twist. The default is 1.
	/// </summary>
	public virtual double GetRotationScale()
	{
		return vtkGenericStreamTracer_GetRotationScale_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericStreamTracer_GetSource_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the source object used to generate starting points.
	/// </summary>
	public vtkDataSet GetSource()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericStreamTracer_GetSource_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericStreamTracer_GetStartPosition_26(HandleRef pThis);

	/// <summary>
	/// Specify the start of the streamline in the global coordinate
	/// system. Search must be performed to find initial cell to start
	/// integration from.
	/// </summary>
	public virtual double[] GetStartPosition()
	{
		IntPtr intPtr = vtkGenericStreamTracer_GetStartPosition_26(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_GetStartPosition_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Specify the start of the streamline in the global coordinate
	/// system. Search must be performed to find initial cell to start
	/// integration from.
	/// </summary>
	public virtual void GetStartPosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkGenericStreamTracer_GetStartPosition_27(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_GetStartPosition_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the start of the streamline in the global coordinate
	/// system. Search must be performed to find initial cell to start
	/// integration from.
	/// </summary>
	public virtual void GetStartPosition(IntPtr _arg)
	{
		vtkGenericStreamTracer_GetStartPosition_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericStreamTracer_GetTerminalSpeed_29(HandleRef pThis);

	/// <summary>
	/// If at any point, the speed is below this value, the integration
	/// is terminated.
	/// </summary>
	public virtual double GetTerminalSpeed()
	{
		return vtkGenericStreamTracer_GetTerminalSpeed_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericStreamTracer_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericStreamTracer_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericStreamTracer_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericStreamTracer_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericStreamTracer NewInstance()
	{
		vtkGenericStreamTracer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericStreamTracer_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericStreamTracer_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericStreamTracer SafeDownCast(vtkObjectBase o)
	{
		vtkGenericStreamTracer vtkGenericStreamTracer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericStreamTracer_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericStreamTracer2 = (vtkGenericStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericStreamTracer2.Register(null);
			}
		}
		return vtkGenericStreamTracer2;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SelectInputVectors_35(HandleRef pThis, string fieldName);

	/// <summary>
	/// If you want to generate traces using an arbitrary vector array,
	/// then set its name here. By default this in nullptr and the filter will
	/// use the active vector array.
	/// </summary>
	public void SelectInputVectors(string fieldName)
	{
		vtkGenericStreamTracer_SelectInputVectors_35(GetCppThis(), fieldName);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetComputeVorticity_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off calculation of vorticity at streamline points
	/// (necessary for generating proper streamribbons using the
	/// vtkRibbonFilter.
	/// </summary>
	public virtual void SetComputeVorticity(int _arg)
	{
		vtkGenericStreamTracer_SetComputeVorticity_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStep_37(HandleRef pThis, int unit, double step);

	/// <summary>
	/// Specify the initial step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// If the integrator is not adaptive, this is the actual
	/// step used.
	/// </summary>
	public void SetInitialIntegrationStep(int unit, double step)
	{
		vtkGenericStreamTracer_SetInitialIntegrationStep_37(GetCppThis(), unit, step);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStep_38(HandleRef pThis, double step);

	/// <summary>
	/// Specify the initial step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// If the integrator is not adaptive, this is the actual
	/// step used.
	/// </summary>
	public void SetInitialIntegrationStep(double step)
	{
		vtkGenericStreamTracer_SetInitialIntegrationStep_38(GetCppThis(), step);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnit_39(HandleRef pThis, int unit);

	/// <summary>
	/// Specify the initial step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// If the integrator is not adaptive, this is the actual
	/// step used.
	/// </summary>
	public void SetInitialIntegrationStepUnit(int unit)
	{
		vtkGenericStreamTracer_SetInitialIntegrationStepUnit_39(GetCppThis(), unit);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnitToCellLengthUnit_40(HandleRef pThis);

	/// <summary>
	/// Specify the initial step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// If the integrator is not adaptive, this is the actual
	/// step used.
	/// </summary>
	public void SetInitialIntegrationStepUnitToCellLengthUnit()
	{
		vtkGenericStreamTracer_SetInitialIntegrationStepUnitToCellLengthUnit_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnitToLengthUnit_41(HandleRef pThis);

	/// <summary>
	/// Specify the initial step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// If the integrator is not adaptive, this is the actual
	/// step used.
	/// </summary>
	public void SetInitialIntegrationStepUnitToLengthUnit()
	{
		vtkGenericStreamTracer_SetInitialIntegrationStepUnitToLengthUnit_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnitToTimeUnit_42(HandleRef pThis);

	/// <summary>
	/// Specify the initial step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// If the integrator is not adaptive, this is the actual
	/// step used.
	/// </summary>
	public void SetInitialIntegrationStepUnitToTimeUnit()
	{
		vtkGenericStreamTracer_SetInitialIntegrationStepUnitToTimeUnit_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetIntegrationDirection_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether the streamtrace will be generated in the
	/// upstream or downstream direction.
	/// </summary>
	public virtual void SetIntegrationDirection(int _arg)
	{
		vtkGenericStreamTracer_SetIntegrationDirection_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetIntegrationDirectionToBackward_44(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamtrace will be generated in the
	/// upstream or downstream direction.
	/// </summary>
	public void SetIntegrationDirectionToBackward()
	{
		vtkGenericStreamTracer_SetIntegrationDirectionToBackward_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetIntegrationDirectionToBoth_45(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamtrace will be generated in the
	/// upstream or downstream direction.
	/// </summary>
	public void SetIntegrationDirectionToBoth()
	{
		vtkGenericStreamTracer_SetIntegrationDirectionToBoth_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetIntegrationDirectionToForward_46(HandleRef pThis);

	/// <summary>
	/// Specify whether the streamtrace will be generated in the
	/// upstream or downstream direction.
	/// </summary>
	public void SetIntegrationDirectionToForward()
	{
		vtkGenericStreamTracer_SetIntegrationDirectionToForward_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetIntegrationStepUnit_47(HandleRef pThis, int unit);

	/// <summary>
	/// Simplified API to set an homogeneous unit across Min/Max/Init IntegrationStepUnit
	/// </summary>
	public void SetIntegrationStepUnit(int unit)
	{
		vtkGenericStreamTracer_SetIntegrationStepUnit_47(GetCppThis(), unit);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetIntegrator_48(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get the integrator type to be used in the stream line
	/// calculation. The object passed is not actually used but
	/// is cloned with NewInstance in the process of integration
	/// (prototype pattern). The default is 2nd order Runge Kutta.
	/// The integrator can also be changed using SetIntegratorType.
	/// The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public void SetIntegrator(vtkInitialValueProblemSolver arg0)
	{
		vtkGenericStreamTracer_SetIntegrator_48(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetIntegratorType_49(HandleRef pThis, int type);

	/// <summary>
	/// Set/get the integrator type to be used in the stream line
	/// calculation. The object passed is not actually used but
	/// is cloned with NewInstance in the process of integration
	/// (prototype pattern). The default is 2nd order Runge Kutta.
	/// The integrator can also be changed using SetIntegratorType.
	/// The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public void SetIntegratorType(int type)
	{
		vtkGenericStreamTracer_SetIntegratorType_49(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta2_50(HandleRef pThis);

	/// <summary>
	/// Set/get the integrator type to be used in the stream line
	/// calculation. The object passed is not actually used but
	/// is cloned with NewInstance in the process of integration
	/// (prototype pattern). The default is 2nd order Runge Kutta.
	/// The integrator can also be changed using SetIntegratorType.
	/// The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public void SetIntegratorTypeToRungeKutta2()
	{
		vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta2_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta4_51(HandleRef pThis);

	/// <summary>
	/// Set/get the integrator type to be used in the stream line
	/// calculation. The object passed is not actually used but
	/// is cloned with NewInstance in the process of integration
	/// (prototype pattern). The default is 2nd order Runge Kutta.
	/// The integrator can also be changed using SetIntegratorType.
	/// The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public void SetIntegratorTypeToRungeKutta4()
	{
		vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta4_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta45_52(HandleRef pThis);

	/// <summary>
	/// Set/get the integrator type to be used in the stream line
	/// calculation. The object passed is not actually used but
	/// is cloned with NewInstance in the process of integration
	/// (prototype pattern). The default is 2nd order Runge Kutta.
	/// The integrator can also be changed using SetIntegratorType.
	/// The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// RUNGE_KUTTA45 = 2
	/// </summary>
	public void SetIntegratorTypeToRungeKutta45()
	{
		vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta45_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetInterpolatorPrototype_53(HandleRef pThis, HandleRef ivf);

	/// <summary>
	/// The object used to interpolate the velocity field during
	/// integration is of the same class as this prototype.
	/// </summary>
	public void SetInterpolatorPrototype(vtkGenericInterpolatedVelocityField ivf)
	{
		vtkGenericStreamTracer_SetInterpolatorPrototype_53(GetCppThis(), ivf?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumError_54(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the maximum error in the integration. This value
	/// is passed to the integrator. Therefore, it's meaning depends
	/// on the integrator used.
	/// </summary>
	public virtual void SetMaximumError(double _arg)
	{
		vtkGenericStreamTracer_SetMaximumError_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStep_55(HandleRef pThis, int unit, double step);

	/// <summary>
	/// Specify the maximum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMaximumIntegrationStep(int unit, double step)
	{
		vtkGenericStreamTracer_SetMaximumIntegrationStep_55(GetCppThis(), unit, step);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStep_56(HandleRef pThis, double step);

	/// <summary>
	/// Specify the maximum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMaximumIntegrationStep(double step)
	{
		vtkGenericStreamTracer_SetMaximumIntegrationStep_56(GetCppThis(), step);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnit_57(HandleRef pThis, int unit);

	/// <summary>
	/// Specify the maximum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMaximumIntegrationStepUnit(int unit)
	{
		vtkGenericStreamTracer_SetMaximumIntegrationStepUnit_57(GetCppThis(), unit);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToCellLengthUnit_58(HandleRef pThis);

	/// <summary>
	/// Specify the maximum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMaximumIntegrationStepUnitToCellLengthUnit()
	{
		vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToCellLengthUnit_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToLengthUnit_59(HandleRef pThis);

	/// <summary>
	/// Specify the maximum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMaximumIntegrationStepUnitToLengthUnit()
	{
		vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToLengthUnit_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToTimeUnit_60(HandleRef pThis);

	/// <summary>
	/// Specify the maximum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMaximumIntegrationStepUnitToTimeUnit()
	{
		vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToTimeUnit_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumNumberOfSteps_61(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the maximum number of steps used in the integration.
	/// </summary>
	public virtual void SetMaximumNumberOfSteps(long _arg)
	{
		vtkGenericStreamTracer_SetMaximumNumberOfSteps_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumPropagation_62(HandleRef pThis, int unit, double max);

	/// <summary>
	/// Specify the maximum length of the streamlines expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// </summary>
	public void SetMaximumPropagation(int unit, double max)
	{
		vtkGenericStreamTracer_SetMaximumPropagation_62(GetCppThis(), unit, max);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumPropagation_63(HandleRef pThis, double max);

	/// <summary>
	/// Specify the maximum length of the streamlines expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// </summary>
	public void SetMaximumPropagation(double max)
	{
		vtkGenericStreamTracer_SetMaximumPropagation_63(GetCppThis(), max);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnit_64(HandleRef pThis, int unit);

	/// <summary>
	/// Specify the maximum length of the streamlines expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// </summary>
	public void SetMaximumPropagationUnit(int unit)
	{
		vtkGenericStreamTracer_SetMaximumPropagationUnit_64(GetCppThis(), unit);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnitToCellLengthUnit_65(HandleRef pThis);

	/// <summary>
	/// Specify the maximum length of the streamlines expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// </summary>
	public void SetMaximumPropagationUnitToCellLengthUnit()
	{
		vtkGenericStreamTracer_SetMaximumPropagationUnitToCellLengthUnit_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnitToLengthUnit_66(HandleRef pThis);

	/// <summary>
	/// Specify the maximum length of the streamlines expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// </summary>
	public void SetMaximumPropagationUnitToLengthUnit()
	{
		vtkGenericStreamTracer_SetMaximumPropagationUnitToLengthUnit_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnitToTimeUnit_67(HandleRef pThis);

	/// <summary>
	/// Specify the maximum length of the streamlines expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// </summary>
	public void SetMaximumPropagationUnitToTimeUnit()
	{
		vtkGenericStreamTracer_SetMaximumPropagationUnitToTimeUnit_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStep_68(HandleRef pThis, int unit, double step);

	/// <summary>
	/// Specify the minimum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMinimumIntegrationStep(int unit, double step)
	{
		vtkGenericStreamTracer_SetMinimumIntegrationStep_68(GetCppThis(), unit, step);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStep_69(HandleRef pThis, double step);

	/// <summary>
	/// Specify the minimum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMinimumIntegrationStep(double step)
	{
		vtkGenericStreamTracer_SetMinimumIntegrationStep_69(GetCppThis(), step);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnit_70(HandleRef pThis, int unit);

	/// <summary>
	/// Specify the minimum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMinimumIntegrationStepUnit(int unit)
	{
		vtkGenericStreamTracer_SetMinimumIntegrationStepUnit_70(GetCppThis(), unit);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToCellLengthUnit_71(HandleRef pThis);

	/// <summary>
	/// Specify the minimum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMinimumIntegrationStepUnitToCellLengthUnit()
	{
		vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToCellLengthUnit_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToLengthUnit_72(HandleRef pThis);

	/// <summary>
	/// Specify the minimum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMinimumIntegrationStepUnitToLengthUnit()
	{
		vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToLengthUnit_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToTimeUnit_73(HandleRef pThis);

	/// <summary>
	/// Specify the minimum step used in the integration expressed in
	/// one of the:
	/// TIME_UNIT        = 0
	/// LENGTH_UNIT      = 1
	/// CELL_LENGTH_UNIT = 2
	/// Only valid when using adaptive integrators.
	/// </summary>
	public void SetMinimumIntegrationStepUnitToTimeUnit()
	{
		vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToTimeUnit_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetRotationScale_74(HandleRef pThis, double _arg);

	/// <summary>
	/// This can be used to scale the rate with which the streamribbons
	/// twist. The default is 1.
	/// </summary>
	public virtual void SetRotationScale(double _arg)
	{
		vtkGenericStreamTracer_SetRotationScale_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetSourceConnection_75(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the source object used to generate starting points (seeds).
	/// New style.
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkGenericStreamTracer_SetSourceConnection_75(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetSourceData_76(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the source object used to generate starting points.
	/// </summary>
	public void SetSourceData(vtkDataSet source)
	{
		vtkGenericStreamTracer_SetSourceData_76(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetStartPosition_77(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify the start of the streamline in the global coordinate
	/// system. Search must be performed to find initial cell to start
	/// integration from.
	/// </summary>
	public virtual void SetStartPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkGenericStreamTracer_SetStartPosition_77(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetStartPosition_78(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the start of the streamline in the global coordinate
	/// system. Search must be performed to find initial cell to start
	/// integration from.
	/// </summary>
	public virtual void SetStartPosition(IntPtr _arg)
	{
		vtkGenericStreamTracer_SetStartPosition_78(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericStreamTracer_SetTerminalSpeed_79(HandleRef pThis, double _arg);

	/// <summary>
	/// If at any point, the speed is below this value, the integration
	/// is terminated.
	/// </summary>
	public virtual void SetTerminalSpeed(double _arg)
	{
		vtkGenericStreamTracer_SetTerminalSpeed_79(GetCppThis(), _arg);
	}
}
