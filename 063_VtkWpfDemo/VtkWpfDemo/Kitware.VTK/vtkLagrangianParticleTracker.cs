using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLagrangianParticleTracker
/// </summary>
/// <remarks>
///    Filter to inject and track particles in a flow
///
///
///
/// Introduce LagrangianParticleTracker
///
/// This is a very flexible and adaptive filter to inject and track particles in a
/// flow. It takes three inputs :
/// * port 0 : Flow Input, a volumic dataset containing data to integrate with,
///     any kind of data object, support distributed input.
/// * port 1 : Seed (source) Input, a dataset containing point to generate particles
///     with, any kind of data object, support distributed input. Only first leaf
///     of composite dataset is used.
/// * port 2 : Optional Surface Input, containing dataset to interact with, any
///     kind of data object, support distributed input.
///
/// It has two outputs :
/// * port 0 : ParticlePaths : a multipiece of polyData (one per thread) of polyLines showing the
/// paths of particles in the flow
/// * port 1 : ParticleInteractions : empty if no surface input, contains a
///     a multiblock with as many children as the number of threads, each children containing a
/// multiblock with the same structure as the surfaces. The leafs of these structures contain a
/// polydata of vertexes corresponding to the interactions. with the same composite layout of surface
/// input if any, showing all interactions between particles and the surface input.
///
/// It has a parallel implementation which streams particle between domains.
///
/// The most important parameters of this filter is it's integrationModel.
/// Only one integration model implementation exist currently in ParaView
/// ,vtkLagrangianMatidaIntegrationModel but the design enables plugin developers
/// to expand this tracker by creating new models.
/// A model can define  :
/// * The number of integration variable and new user defined integration variable
/// * the way the particle are integrated
/// * the way particles intersect and interact with the surface
/// * the way freeFlight termination is handled
/// * PreProcess and PostProcess methods
/// * Manual Integration, Manual partichle shifting
/// see vtkLagrangianBasicIntegrationModel and vtkLagrangianMatidaIntegrationModel
/// for more information
///
/// It also let the user choose the Locator to use when integrating in the flow,
/// as well as the Integrator to use. Integration steps are also highly configurable,
/// step, step min and step max are passed down to the integrator (hence min and max
/// does not matter with a non adaptive integrator like RK4/5)
///
///  An IntegrationModel is a very specific vtkFunctionSet with a lot of features
/// allowing inherited classes
/// to concentrate on the mathematical part of the code.
///  a Particle is basically a class wrapper around three table containing variables
/// about the particle at previous, current and next position.
///  The particle is passed to the integrator, which use the integration model to
/// integrate the particle in the flow.
///
/// It has other features also, including :
///  * Adaptative Step Reintegration, to retry the step with different time step
///      when the next position is too far
///  * Different kind of cell length computation, including a divergence theorem
///      based computation
///  * Optional lines rendering controlled by a threshold
///  * Ghost cell support
///  * Non planar quad interaction support
///  * Built-in support for surface interaction including, terminate, bounce,
///      break-up and pass-through surface
/// The serial and parallel filters are fully tested.
///
/// </remarks>
/// <seealso>
///
/// vtkLagrangianMatidaIntegrationModel vtkLagrangianParticle
/// vtkLagrangianBasicIntegrationModel
/// </seealso>
public class vtkLagrangianParticleTracker : vtkDataObjectAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum CellLengthComputation
	{
		/// <summary>enum member</summary>
		STEP_CUR_CELL_DIV_THEO = 5,
		/// <summary>enum member</summary>
		STEP_CUR_CELL_LENGTH = 1,
		/// <summary>enum member</summary>
		STEP_CUR_CELL_VEL_DIR = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangianParticleTracker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLagrangianParticleTracker()
	{
		MRClassNameKey = "class vtkLagrangianParticleTracker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangianParticleTracker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLagrangianParticleTracker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianParticleTracker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLagrangianParticleTracker New()
	{
		vtkLagrangianParticleTracker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianParticleTracker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLagrangianParticleTracker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLagrangianParticleTracker()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLagrangianParticleTracker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLagrangianParticleTracker_AdaptiveStepReintegrationOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the Adaptive Step Reintegration feature.
	/// it checks the step size after the integration
	/// and if it is too big will retry with a smaller step
	/// Default is false.
	/// </summary>
	public virtual void AdaptiveStepReintegrationOff()
	{
		vtkLagrangianParticleTracker_AdaptiveStepReintegrationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_AdaptiveStepReintegrationOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the Adaptive Step Reintegration feature.
	/// it checks the step size after the integration
	/// and if it is too big will retry with a smaller step
	/// Default is false.
	/// </summary>
	public virtual void AdaptiveStepReintegrationOn()
	{
		vtkLagrangianParticleTracker_AdaptiveStepReintegrationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangianParticleTracker_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Declare input port type
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkLagrangianParticleTracker_FillInputPortInformation_03(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangianParticleTracker_FillOutputPortInformation_04(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Declare output port type
	/// </summary>
	public virtual int FillOutputPortInformation(int port, vtkInformation info)
	{
		return vtkLagrangianParticleTracker_FillOutputPortInformation_04(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_GenerateParticlePathsOutputOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of the particle path output,
	/// Default is true.
	/// </summary>
	public virtual void GenerateParticlePathsOutputOff()
	{
		vtkLagrangianParticleTracker_GenerateParticlePathsOutputOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_GenerateParticlePathsOutputOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of the particle path output,
	/// Default is true.
	/// </summary>
	public virtual void GenerateParticlePathsOutputOn()
	{
		vtkLagrangianParticleTracker_GenerateParticlePathsOutputOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLagrangianParticleTracker_GetAdaptiveStepReintegration_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the Adaptive Step Reintegration feature.
	/// it checks the step size after the integration
	/// and if it is too big will retry with a smaller step
	/// Default is false.
	/// </summary>
	public virtual bool GetAdaptiveStepReintegration()
	{
		return (vtkLagrangianParticleTracker_GetAdaptiveStepReintegration_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangianParticleTracker_GetCellLengthComputationMode_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the cell length computation mode.
	/// Available modes are :
	/// - STEP_CUR_CELL_LENGTH :
	/// Compute cell length using getLength method
	/// on the current cell the particle is in
	/// - STEP_CUR_CELL_VEL_DIR :
	/// Compute cell length using the particle velocity
	/// and the edges of the last cell the particle was in.
	/// - STEP_CUR_CELL_DIV_THEO :
	/// Compute cell length using the particle velocity
	/// and the divergence theorem.
	/// </summary>
	public virtual int GetCellLengthComputationMode()
	{
		return vtkLagrangianParticleTracker_GetCellLengthComputationMode_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLagrangianParticleTracker_GetGenerateParticlePathsOutput_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of the particle path output,
	/// Default is true.
	/// </summary>
	public virtual bool GetGenerateParticlePathsOutput()
	{
		return (vtkLagrangianParticleTracker_GetGenerateParticlePathsOutput_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLagrangianParticleTracker_GetGeneratePolyVertexInteractionOutput_10(HandleRef pThis);

	/// <summary>
	/// Set/Get whether or not to use PolyVertex cell type
	/// for the interaction output
	/// Default is false
	/// </summary>
	public virtual bool GetGeneratePolyVertexInteractionOutput()
	{
		return (vtkLagrangianParticleTracker_GetGeneratePolyVertexInteractionOutput_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianParticleTracker_GetIntegrationModel_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the integration model.
	/// Default is vtkLagrangianMatidaIntegrationModel
	/// </summary>
	public virtual vtkLagrangianBasicIntegrationModel GetIntegrationModel()
	{
		vtkLagrangianBasicIntegrationModel vtkLagrangianBasicIntegrationModel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianParticleTracker_GetIntegrationModel_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLagrangianBasicIntegrationModel2 = (vtkLagrangianBasicIntegrationModel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLagrangianBasicIntegrationModel2.Register(null);
			}
		}
		return vtkLagrangianBasicIntegrationModel2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianParticleTracker_GetIntegrator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the integrator.
	/// Default is vtkRungeKutta2
	/// </summary>
	public virtual vtkInitialValueProblemSolver GetIntegrator()
	{
		vtkInitialValueProblemSolver vtkInitialValueProblemSolver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianParticleTracker_GetIntegrator_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkLagrangianParticleTracker_GetMTime_13(HandleRef pThis);

	/// <summary>
	/// Get the tracker modified time taking into account the integration model
	/// and the integrator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkLagrangianParticleTracker_GetMTime_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLagrangianParticleTracker_GetMaximumIntegrationTime_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum integration time. A negative value means no limit.
	/// Default is -1.
	/// </summary>
	public virtual double GetMaximumIntegrationTime()
	{
		return vtkLagrangianParticleTracker_GetMaximumIntegrationTime_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangianParticleTracker_GetMaximumNumberOfSteps_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of steps. -1 means no limit. Default is 100.
	/// </summary>
	public virtual int GetMaximumNumberOfSteps()
	{
		return vtkLagrangianParticleTracker_GetMaximumNumberOfSteps_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLagrangianParticleTracker_GetNewParticleId_16(HandleRef pThis);

	/// <summary>
	/// Get an unique id for a particle
	/// This method is thread safe
	/// </summary>
	public virtual long GetNewParticleId()
	{
		return vtkLagrangianParticleTracker_GetNewParticleId_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLagrangianParticleTracker_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLagrangianParticleTracker_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLagrangianParticleTracker_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLagrangianParticleTracker_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianParticleTracker_GetSource_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the source object used to generate particle initial position (seeds).
	/// Note that this method does not connect the pipeline. The algorithm will
	/// work on the input data as it is without updating the producer of the data.
	/// See SetSourceConnection for connecting the pipeline.
	/// </summary>
	public vtkDataObject GetSource()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianParticleTracker_GetSource_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLagrangianParticleTracker_GetStepFactor_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the integration step factor. Default is 1.0.
	/// </summary>
	public virtual double GetStepFactor()
	{
		return vtkLagrangianParticleTracker_GetStepFactor_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLagrangianParticleTracker_GetStepFactorMax_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the integration step factor max. Default is 1.5.
	/// </summary>
	public virtual double GetStepFactorMax()
	{
		return vtkLagrangianParticleTracker_GetStepFactorMax_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLagrangianParticleTracker_GetStepFactorMin_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the integration step factor min. Default is 0.5.
	/// </summary>
	public virtual double GetStepFactorMin()
	{
		return vtkLagrangianParticleTracker_GetStepFactorMin_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianParticleTracker_GetSurface_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the source object used to compute surface interaction with
	/// Note that this method does not connect the pipeline. The algorithm will
	/// work on the input data as it is without updating the producer of the data.
	/// See SetSurfaceConnection for connecting the pipeline.
	/// </summary>
	public vtkDataObject GetSurface()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianParticleTracker_GetSurface_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangianParticleTracker_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLagrangianParticleTracker_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangianParticleTracker_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLagrangianParticleTracker_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianParticleTracker_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLagrangianParticleTracker NewInstance()
	{
		vtkLagrangianParticleTracker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianParticleTracker_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLagrangianParticleTracker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianParticleTracker_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLagrangianParticleTracker SafeDownCast(vtkObjectBase o)
	{
		vtkLagrangianParticleTracker vtkLagrangianParticleTracker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianParticleTracker_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLagrangianParticleTracker2 = (vtkLagrangianParticleTracker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLagrangianParticleTracker2.Register(null);
			}
		}
		return vtkLagrangianParticleTracker2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetAdaptiveStepReintegration_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the Adaptive Step Reintegration feature.
	/// it checks the step size after the integration
	/// and if it is too big will retry with a smaller step
	/// Default is false.
	/// </summary>
	public virtual void SetAdaptiveStepReintegration(bool _arg)
	{
		vtkLagrangianParticleTracker_SetAdaptiveStepReintegration_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetCellLengthComputationMode_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the cell length computation mode.
	/// Available modes are :
	/// - STEP_CUR_CELL_LENGTH :
	/// Compute cell length using getLength method
	/// on the current cell the particle is in
	/// - STEP_CUR_CELL_VEL_DIR :
	/// Compute cell length using the particle velocity
	/// and the edges of the last cell the particle was in.
	/// - STEP_CUR_CELL_DIV_THEO :
	/// Compute cell length using the particle velocity
	/// and the divergence theorem.
	/// </summary>
	public virtual void SetCellLengthComputationMode(int _arg)
	{
		vtkLagrangianParticleTracker_SetCellLengthComputationMode_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetGenerateParticlePathsOutput_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the generation of the particle path output,
	/// Default is true.
	/// </summary>
	public virtual void SetGenerateParticlePathsOutput(bool _arg)
	{
		vtkLagrangianParticleTracker_SetGenerateParticlePathsOutput_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetGeneratePolyVertexInteractionOutput_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether or not to use PolyVertex cell type
	/// for the interaction output
	/// Default is false
	/// </summary>
	public virtual void SetGeneratePolyVertexInteractionOutput(bool _arg)
	{
		vtkLagrangianParticleTracker_SetGeneratePolyVertexInteractionOutput_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetIntegrationModel_33(HandleRef pThis, HandleRef integrationModel);

	/// <summary>
	/// Set/Get the integration model.
	/// Default is vtkLagrangianMatidaIntegrationModel
	/// </summary>
	public void SetIntegrationModel(vtkLagrangianBasicIntegrationModel integrationModel)
	{
		vtkLagrangianParticleTracker_SetIntegrationModel_33(GetCppThis(), integrationModel?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetIntegrator_34(HandleRef pThis, HandleRef integrator);

	/// <summary>
	/// Set/Get the integrator.
	/// Default is vtkRungeKutta2
	/// </summary>
	public void SetIntegrator(vtkInitialValueProblemSolver integrator)
	{
		vtkLagrangianParticleTracker_SetIntegrator_34(GetCppThis(), integrator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetMaximumIntegrationTime_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the maximum integration time. A negative value means no limit.
	/// Default is -1.
	/// </summary>
	public virtual void SetMaximumIntegrationTime(double _arg)
	{
		vtkLagrangianParticleTracker_SetMaximumIntegrationTime_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetMaximumNumberOfSteps_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum number of steps. -1 means no limit. Default is 100.
	/// </summary>
	public virtual void SetMaximumNumberOfSteps(int _arg)
	{
		vtkLagrangianParticleTracker_SetMaximumNumberOfSteps_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetSourceConnection_37(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the source object used to generate particle initial position (seeds).
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkLagrangianParticleTracker_SetSourceConnection_37(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetSourceData_38(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the source object used to generate particle initial position (seeds).
	/// Note that this method does not connect the pipeline. The algorithm will
	/// work on the input data as it is without updating the producer of the data.
	/// See SetSourceConnection for connecting the pipeline.
	/// </summary>
	public void SetSourceData(vtkDataObject source)
	{
		vtkLagrangianParticleTracker_SetSourceData_38(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetStepFactor_39(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the integration step factor. Default is 1.0.
	/// </summary>
	public virtual void SetStepFactor(double _arg)
	{
		vtkLagrangianParticleTracker_SetStepFactor_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetStepFactorMax_40(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the integration step factor max. Default is 1.5.
	/// </summary>
	public virtual void SetStepFactorMax(double _arg)
	{
		vtkLagrangianParticleTracker_SetStepFactorMax_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetStepFactorMin_41(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the integration step factor min. Default is 0.5.
	/// </summary>
	public virtual void SetStepFactorMin(double _arg)
	{
		vtkLagrangianParticleTracker_SetStepFactorMin_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetSurfaceConnection_42(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the object used to compute surface interaction with.
	/// </summary>
	public void SetSurfaceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkLagrangianParticleTracker_SetSurfaceConnection_42(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianParticleTracker_SetSurfaceData_43(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the source object used to compute surface interaction with
	/// Note that this method does not connect the pipeline. The algorithm will
	/// work on the input data as it is without updating the producer of the data.
	/// See SetSurfaceConnection for connecting the pipeline.
	/// </summary>
	public void SetSurfaceData(vtkDataObject source)
	{
		vtkLagrangianParticleTracker_SetSurfaceData_43(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}
}
