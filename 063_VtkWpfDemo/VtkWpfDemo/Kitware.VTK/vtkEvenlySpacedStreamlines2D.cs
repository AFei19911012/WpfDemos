using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEvenlySpacedStreamlines2D
/// </summary>
/// <remarks>
///    Evenly spaced streamline generator for 2D.
///
/// vtkEvenlySpacedStreamlines2D is a filter that integrates a 2D
/// vector field to generate evenly-spaced streamlines.
///
/// We implement
/// the algorithm described in:
/// Jobard, Bruno, and Wilfrid Lefer. "Creating evenly-spaced
/// streamlines of arbitrary density." Visualization in Scientific
/// Computing '97. Springer Vienna, 1997. 43-55.
/// The loop detection is described in:
/// Liu, Zhanping, Robert Moorhead, and Joe Groner.
/// "An advanced evenly-spaced streamline placement algorithm."
/// IEEE Transactions on Visualization and Computer Graphics 12.5 (2006): 965-972.
///
/// The integration is performed using a specified integrator,
/// by default Runge-Kutta2.
///
/// vtkEvenlySpacedStreamlines2D produces polylines as the output, with
/// each cell (i.e., polyline) representing a streamline. The attribute
/// values associated with each streamline are stored in the cell data,
/// whereas those associated with streamline-points are stored in the
/// point data.
///
/// vtkEvenlySpacedStreamlines2D integrates streamlines both forward
/// and backward. The integration for a streamline terminates upon
/// exiting the flow field domain, or if the particle speed is reduced
/// to a value less than a specified terminal speed, if the current
/// streamline gets too close to other streamlines
/// (vtkStreamTracer::FIXED_REASONS_FOR_TERMINATION_COUNT + 1) or if
/// the streamline forms a loop
/// (vtkStreamTracer::FIXED_REASONS_FOR_TERMINATION_COUNT). The
/// specific reason for the termination is stored in a cell array named
/// ReasonForTermination.
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
/// The quality of streamline integration can be controlled by setting
/// the initial integration step (InitialIntegrationStep), particularly
/// for Runge-Kutta2 and Runge-Kutta4 (with a fixed step size). We do
/// not support Runge-Kutta45 (with an adaptive step size and error
/// control) because a requirement of the algorithm is that sample
/// points along a streamline be evenly spaced. These steps are in
/// either LENGTH_UNIT or CELL_LENGTH_UNIT.
///
/// The integration time, vorticity, rotation and angular velocity are stored
/// in point data arrays named "IntegrationTime", "Vorticity", "Rotation" and
/// "AngularVelocity", respectively (vorticity, rotation and angular velocity
/// are computed only when ComputeVorticity is on). All point data attributes
/// in the source dataset are interpolated on the new streamline points.
///
/// vtkEvenlySpacedStreamlines2D supports integration through any type of 2D dataset.
///
/// The starting point, or the so-called 'seed', of the first streamline is set
/// by setting StartPosition
///
/// </remarks>
/// <seealso>
///
/// vtkStreamTracer vtkRibbonFilter vtkRuledSurfaceFilter vtkInitialValueProblemSolver
/// vtkRungeKutta2 vtkRungeKutta4 vtkRungeKutta45 vtkParticleTracerBase
/// vtkParticleTracer vtkParticlePathFilter vtkStreaklineFilter
/// vtkAbstractInterpolatedVelocityField vtkCompositeInterpolatedVelocityField
/// vtkAMRInterpolatedVelocityField
/// </seealso>
public class vtkEvenlySpacedStreamlines2D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEvenlySpacedStreamlines2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEvenlySpacedStreamlines2D()
	{
		MRClassNameKey = "class vtkEvenlySpacedStreamlines2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEvenlySpacedStreamlines2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEvenlySpacedStreamlines2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEvenlySpacedStreamlines2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object to start from position (0,0,0), with forward
	/// integration, terminal speed 1.0E-12, vorticity computation on,
	/// integration step size 0.5 (in cell length unit), maximum number
	/// of steps 2000, using Runge-Kutta2, and maximum propagation 1.0
	/// (in arc length unit).
	/// </summary>
	public new static vtkEvenlySpacedStreamlines2D New()
	{
		vtkEvenlySpacedStreamlines2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEvenlySpacedStreamlines2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEvenlySpacedStreamlines2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object to start from position (0,0,0), with forward
	/// integration, terminal speed 1.0E-12, vorticity computation on,
	/// integration step size 0.5 (in cell length unit), maximum number
	/// of steps 2000, using Runge-Kutta2, and maximum propagation 1.0
	/// (in arc length unit).
	/// </summary>
	public vtkEvenlySpacedStreamlines2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEvenlySpacedStreamlines2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkEvenlySpacedStreamlines2D_GetClosedLoopMaximumDistance_01(HandleRef pThis);

	/// <summary>
	/// Loops are considered closed if the have two points at distance less than this.
	/// This is expressed in IntegrationStepUnit.
	/// </summary>
	public virtual double GetClosedLoopMaximumDistance()
	{
		return vtkEvenlySpacedStreamlines2D_GetClosedLoopMaximumDistance_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkEvenlySpacedStreamlines2D_GetComputeVorticity_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off vorticity computation at streamline points
	/// (necessary for generating proper stream-ribbons using the
	/// vtkRibbonFilter.
	/// </summary>
	public virtual bool GetComputeVorticity()
	{
		return (vtkEvenlySpacedStreamlines2D_GetComputeVorticity_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEvenlySpacedStreamlines2D_GetInitialIntegrationStep_03(HandleRef pThis);

	/// <summary>
	/// Specify the Initial step size used for line integration, expressed in
	/// IntegrationStepUnit
	///
	/// This is the constant / fixed size for non-adaptive integration
	/// methods, i.e., RK2 and RK4
	/// </summary>
	public virtual double GetInitialIntegrationStep()
	{
		return vtkEvenlySpacedStreamlines2D_GetInitialIntegrationStep_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEvenlySpacedStreamlines2D_GetIntegrationStepUnit_04(HandleRef pThis);

	/// <summary>
	/// Specify a uniform integration step unit for
	/// InitialIntegrationStep, and SeparatingDistance. Valid units are
	/// LENGTH_UNIT (1) (value is in global coordinates) and CELL_LENGTH_UNIT (2)
	/// (the value is in number of cell lengths)
	/// </summary>
	public int GetIntegrationStepUnit()
	{
		return vtkEvenlySpacedStreamlines2D_GetIntegrationStepUnit_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEvenlySpacedStreamlines2D_GetIntegrator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// </summary>
	public virtual vtkInitialValueProblemSolver GetIntegrator()
	{
		vtkInitialValueProblemSolver vtkInitialValueProblemSolver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEvenlySpacedStreamlines2D_GetIntegrator_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkEvenlySpacedStreamlines2D_GetIntegratorType_06(HandleRef pThis);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// </summary>
	public int GetIntegratorType()
	{
		return vtkEvenlySpacedStreamlines2D_GetIntegratorType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEvenlySpacedStreamlines2D_GetLoopAngle_07(HandleRef pThis);

	/// <summary>
	/// The angle (in radians) between the vector created by p0p1 and the
	/// velocity in the point closing the loop. p0 is the current point
	/// and p1 is the point before that.  Default value is 20 degrees in radians.
	/// </summary>
	public virtual double GetLoopAngle()
	{
		return vtkEvenlySpacedStreamlines2D_GetLoopAngle_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEvenlySpacedStreamlines2D_GetMaximumNumberOfSteps_08(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of steps for integrating a streamline.
	/// </summary>
	public virtual long GetMaximumNumberOfSteps()
	{
		return vtkEvenlySpacedStreamlines2D_GetMaximumNumberOfSteps_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEvenlySpacedStreamlines2D_GetMinimumNumberOfLoopPoints_09(HandleRef pThis);

	/// <summary>
	/// We don't try to eliminate loops with fewer points than this. Default value
	/// is 4.
	/// </summary>
	public virtual long GetMinimumNumberOfLoopPoints()
	{
		return vtkEvenlySpacedStreamlines2D_GetMinimumNumberOfLoopPoints_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEvenlySpacedStreamlines2D_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEvenlySpacedStreamlines2D_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEvenlySpacedStreamlines2D_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEvenlySpacedStreamlines2D_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEvenlySpacedStreamlines2D_GetSeparatingDistance_12(HandleRef pThis);

	/// <summary>
	/// Specify the separation distance between streamlines expressed in
	/// IntegrationStepUnit.
	/// </summary>
	public virtual double GetSeparatingDistance()
	{
		return vtkEvenlySpacedStreamlines2D_GetSeparatingDistance_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEvenlySpacedStreamlines2D_GetSeparatingDistanceRatio_13(HandleRef pThis);

	/// <summary>
	/// Streamline integration is stopped if streamlines are closer than
	/// SeparatingDistance*SeparatingDistanceRatio to other streamlines.
	/// </summary>
	public virtual double GetSeparatingDistanceRatio()
	{
		return vtkEvenlySpacedStreamlines2D_GetSeparatingDistanceRatio_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEvenlySpacedStreamlines2D_GetStartPosition_14(HandleRef pThis);

	/// <summary>
	/// Specify the starting point (seed) of the first streamline in the global
	/// coordinate system. Search must be performed to find the initial cell
	/// from which to start integration. If the seed is not specified a
	/// random position in the input data is chosen.
	/// </summary>
	public virtual double[] GetStartPosition()
	{
		IntPtr intPtr = vtkEvenlySpacedStreamlines2D_GetStartPosition_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_GetStartPosition_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Specify the starting point (seed) of the first streamline in the global
	/// coordinate system. Search must be performed to find the initial cell
	/// from which to start integration. If the seed is not specified a
	/// random position in the input data is chosen.
	/// </summary>
	public virtual void GetStartPosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkEvenlySpacedStreamlines2D_GetStartPosition_15(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_GetStartPosition_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the starting point (seed) of the first streamline in the global
	/// coordinate system. Search must be performed to find the initial cell
	/// from which to start integration. If the seed is not specified a
	/// random position in the input data is chosen.
	/// </summary>
	public virtual void GetStartPosition(IntPtr _arg)
	{
		vtkEvenlySpacedStreamlines2D_GetStartPosition_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEvenlySpacedStreamlines2D_GetTerminalSpeed_17(HandleRef pThis);

	/// <summary>
	/// Specify the terminal speed value, below which integration is terminated.
	/// </summary>
	public virtual double GetTerminalSpeed()
	{
		return vtkEvenlySpacedStreamlines2D_GetTerminalSpeed_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEvenlySpacedStreamlines2D_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEvenlySpacedStreamlines2D_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEvenlySpacedStreamlines2D_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEvenlySpacedStreamlines2D_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEvenlySpacedStreamlines2D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEvenlySpacedStreamlines2D NewInstance()
	{
		vtkEvenlySpacedStreamlines2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEvenlySpacedStreamlines2D_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEvenlySpacedStreamlines2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEvenlySpacedStreamlines2D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEvenlySpacedStreamlines2D SafeDownCast(vtkObjectBase o)
	{
		vtkEvenlySpacedStreamlines2D vtkEvenlySpacedStreamlines2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEvenlySpacedStreamlines2D_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEvenlySpacedStreamlines2D2 = (vtkEvenlySpacedStreamlines2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEvenlySpacedStreamlines2D2.Register(null);
			}
		}
		return vtkEvenlySpacedStreamlines2D2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetClosedLoopMaximumDistance_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Loops are considered closed if the have two points at distance less than this.
	/// This is expressed in IntegrationStepUnit.
	/// </summary>
	public virtual void SetClosedLoopMaximumDistance(double _arg)
	{
		vtkEvenlySpacedStreamlines2D_SetClosedLoopMaximumDistance_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetComputeVorticity_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off vorticity computation at streamline points
	/// (necessary for generating proper stream-ribbons using the
	/// vtkRibbonFilter.
	/// </summary>
	public virtual void SetComputeVorticity(bool _arg)
	{
		vtkEvenlySpacedStreamlines2D_SetComputeVorticity_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetInitialIntegrationStep_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the Initial step size used for line integration, expressed in
	/// IntegrationStepUnit
	///
	/// This is the constant / fixed size for non-adaptive integration
	/// methods, i.e., RK2 and RK4
	/// </summary>
	public virtual void SetInitialIntegrationStep(double _arg)
	{
		vtkEvenlySpacedStreamlines2D_SetInitialIntegrationStep_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetIntegrationStepUnit_26(HandleRef pThis, int unit);

	/// <summary>
	/// Specify a uniform integration step unit for
	/// InitialIntegrationStep, and SeparatingDistance. Valid units are
	/// LENGTH_UNIT (1) (value is in global coordinates) and CELL_LENGTH_UNIT (2)
	/// (the value is in number of cell lengths)
	/// </summary>
	public void SetIntegrationStepUnit(int unit)
	{
		vtkEvenlySpacedStreamlines2D_SetIntegrationStepUnit_26(GetCppThis(), unit);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetIntegrator_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// </summary>
	public void SetIntegrator(vtkInitialValueProblemSolver arg0)
	{
		vtkEvenlySpacedStreamlines2D_SetIntegrator_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetIntegratorType_28(HandleRef pThis, int type);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// </summary>
	public void SetIntegratorType(int type)
	{
		vtkEvenlySpacedStreamlines2D_SetIntegratorType_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetIntegratorTypeToRungeKutta2_29(HandleRef pThis);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// </summary>
	public void SetIntegratorTypeToRungeKutta2()
	{
		vtkEvenlySpacedStreamlines2D_SetIntegratorTypeToRungeKutta2_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetIntegratorTypeToRungeKutta4_30(HandleRef pThis);

	/// <summary>
	/// Set/get the integrator type to be used for streamline generation.
	/// The object passed is not actually used but is cloned with
	/// NewInstance in the process of integration  (prototype pattern).
	/// The default is Runge-Kutta2. The integrator can also be changed
	/// using SetIntegratorType. The recognized solvers are:
	/// RUNGE_KUTTA2  = 0
	/// RUNGE_KUTTA4  = 1
	/// </summary>
	public void SetIntegratorTypeToRungeKutta4()
	{
		vtkEvenlySpacedStreamlines2D_SetIntegratorTypeToRungeKutta4_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetInterpolatorPrototype_31(HandleRef pThis, HandleRef ivf);

	/// <summary>
	/// The object used to interpolate the velocity field during
	/// integration is of the same class as this prototype.
	/// </summary>
	public void SetInterpolatorPrototype(vtkAbstractInterpolatedVelocityField ivf)
	{
		vtkEvenlySpacedStreamlines2D_SetInterpolatorPrototype_31(GetCppThis(), ivf?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetInterpolatorType_32(HandleRef pThis, int interpType);

	/// <summary>
	/// Set the type of the velocity field interpolator to determine whether
	/// INTERPOLATOR_WITH_DATASET_POINT_LOCATOR or INTERPOLATOR_WITH_CELL_LOCATOR
	/// is employed for locating cells during streamline integration. The latter
	/// (adopting vtkAbstractCellLocator sub-classes such as vtkCellLocator and
	/// vtkModifiedBSPTree) is more robust then the former (through vtkDataSet /
	/// vtkPointSet::FindCell() coupled with vtkPointLocator).
	/// </summary>
	public void SetInterpolatorType(int interpType)
	{
		vtkEvenlySpacedStreamlines2D_SetInterpolatorType_32(GetCppThis(), interpType);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetInterpolatorTypeToCellLocator_33(HandleRef pThis);

	/// <summary>
	/// Set the velocity field interpolator type to the one involving
	/// a cell locator.
	/// </summary>
	public void SetInterpolatorTypeToCellLocator()
	{
		vtkEvenlySpacedStreamlines2D_SetInterpolatorTypeToCellLocator_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetInterpolatorTypeToDataSetPointLocator_34(HandleRef pThis);

	/// <summary>
	/// Set the velocity field interpolator type to the one involving
	/// a dataset point locator.
	/// </summary>
	public void SetInterpolatorTypeToDataSetPointLocator()
	{
		vtkEvenlySpacedStreamlines2D_SetInterpolatorTypeToDataSetPointLocator_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetLoopAngle_35(HandleRef pThis, double _arg);

	/// <summary>
	/// The angle (in radians) between the vector created by p0p1 and the
	/// velocity in the point closing the loop. p0 is the current point
	/// and p1 is the point before that.  Default value is 20 degrees in radians.
	/// </summary>
	public virtual void SetLoopAngle(double _arg)
	{
		vtkEvenlySpacedStreamlines2D_SetLoopAngle_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetMaximumNumberOfSteps_36(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the maximum number of steps for integrating a streamline.
	/// </summary>
	public virtual void SetMaximumNumberOfSteps(long _arg)
	{
		vtkEvenlySpacedStreamlines2D_SetMaximumNumberOfSteps_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetMinimumNumberOfLoopPoints_37(HandleRef pThis, long _arg);

	/// <summary>
	/// We don't try to eliminate loops with fewer points than this. Default value
	/// is 4.
	/// </summary>
	public virtual void SetMinimumNumberOfLoopPoints(long _arg)
	{
		vtkEvenlySpacedStreamlines2D_SetMinimumNumberOfLoopPoints_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetSeparatingDistance_38(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the separation distance between streamlines expressed in
	/// IntegrationStepUnit.
	/// </summary>
	public virtual void SetSeparatingDistance(double _arg)
	{
		vtkEvenlySpacedStreamlines2D_SetSeparatingDistance_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetSeparatingDistanceRatio_39(HandleRef pThis, double _arg);

	/// <summary>
	/// Streamline integration is stopped if streamlines are closer than
	/// SeparatingDistance*SeparatingDistanceRatio to other streamlines.
	/// </summary>
	public virtual void SetSeparatingDistanceRatio(double _arg)
	{
		vtkEvenlySpacedStreamlines2D_SetSeparatingDistanceRatio_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetStartPosition_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify the starting point (seed) of the first streamline in the global
	/// coordinate system. Search must be performed to find the initial cell
	/// from which to start integration. If the seed is not specified a
	/// random position in the input data is chosen.
	/// </summary>
	public virtual void SetStartPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkEvenlySpacedStreamlines2D_SetStartPosition_40(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetStartPosition_41(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the starting point (seed) of the first streamline in the global
	/// coordinate system. Search must be performed to find the initial cell
	/// from which to start integration. If the seed is not specified a
	/// random position in the input data is chosen.
	/// </summary>
	public virtual void SetStartPosition(IntPtr _arg)
	{
		vtkEvenlySpacedStreamlines2D_SetStartPosition_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvenlySpacedStreamlines2D_SetTerminalSpeed_42(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the terminal speed value, below which integration is terminated.
	/// </summary>
	public virtual void SetTerminalSpeed(double _arg)
	{
		vtkEvenlySpacedStreamlines2D_SetTerminalSpeed_42(GetCppThis(), _arg);
	}
}
