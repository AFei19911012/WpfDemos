using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParticleTracerBase
/// </summary>
/// <remarks>
///    A particle tracer for vector fields
///
/// vtkParticleTracerBase is the base class for filters that advect particles
/// in a vector field. Note that the input vtkPointData structure must
/// be identical on all datasets.
///
/// </remarks>
/// <seealso>
///
/// vtkRibbonFilter vtkRuledSurfaceFilter vtkInitialValueProblemSolver
/// vtkRungeKutta2 vtkRungeKutta4 vtkRungeKutta45 vtkStreamTracer
/// </seealso>
public abstract class vtkParticleTracerBase : vtkPolyDataAlgorithm
{
	/// <summary>
	/// if StaticMesh is set, many optimizations for cell caching
	/// can be assumed. if StaticMesh is not set, the algorithm
	/// will attempt to find out if optimizations can be used, but
	/// setting it to true will force all optimizations.
	/// Do not Set StaticMesh to true if a dynamic mesh is being used
	/// as this will invalidate all results.
	/// The default is that StaticMesh is 0.
	/// </summary>
	public enum INTERPOLATOR_WITH_CELL_LOCATOR_WrapperEnum
	{
		/// <summary>enum member</summary>
		INTERPOLATOR_WITH_CELL_LOCATOR = 1,
		/// <summary>enum member</summary>
		INTERPOLATOR_WITH_DATASET_POINT_LOCATOR = 0
	}

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public enum MeshOverTimeTypes
	{
		/// <summary>enum member</summary>
		DIFFERENT = 0,
		/// <summary>enum member</summary>
		LINEAR_TRANSFORMATION = 2,
		/// <summary>enum member</summary>
		SAME_TOPOLOGY = 3,
		/// <summary>enum member</summary>
		STATIC = 1
	}

	/// <summary>
	///             Undocumented Block
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
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParticleTracerBase";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParticleTracerBase()
	{
		MRClassNameKey = "class vtkParticleTracerBase";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParticleTracerBase"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParticleTracerBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_AddSourceConnection_01(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Provide support for multiple seed sources
	/// </summary>
	public void AddSourceConnection(vtkAlgorithmOutput input)
	{
		vtkParticleTracerBase_AddSourceConnection_01(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_DisableResetCacheOff_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag to disable cache
	/// This is off by default and turned on in special circumstances
	/// such as in a coprocessing workflow
	/// </summary>
	public virtual void DisableResetCacheOff()
	{
		vtkParticleTracerBase_DisableResetCacheOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_DisableResetCacheOn_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag to disable cache
	/// This is off by default and turned on in special circumstances
	/// such as in a coprocessing workflow
	/// </summary>
	public virtual void DisableResetCacheOn()
	{
		vtkParticleTracerBase_DisableResetCacheOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_EnableParticleWritingOff_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the filename to be used with the particle writer when
	/// dumping particles to disk
	/// </summary>
	public virtual void EnableParticleWritingOff()
	{
		vtkParticleTracerBase_EnableParticleWritingOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_EnableParticleWritingOn_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the filename to be used with the particle writer when
	/// dumping particles to disk
	/// </summary>
	public virtual void EnableParticleWritingOn()
	{
		vtkParticleTracerBase_EnableParticleWritingOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_ForceSerialExecutionOff_06(HandleRef pThis);

	/// <summary>
	/// Force the filter to run particle tracer in serial. This affects
	/// the filter only if more than 100 particles is to be generated.
	/// </summary>
	public virtual void ForceSerialExecutionOff()
	{
		vtkParticleTracerBase_ForceSerialExecutionOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_ForceSerialExecutionOn_07(HandleRef pThis);

	/// <summary>
	/// Force the filter to run particle tracer in serial. This affects
	/// the filter only if more than 100 particles is to be generated.
	/// </summary>
	public virtual void ForceSerialExecutionOn()
	{
		vtkParticleTracerBase_ForceSerialExecutionOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkParticleTracerBase_GetComputeVorticity_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off vorticity computation at streamline points
	/// (necessary for generating proper stream-ribbons using the
	/// vtkRibbonFilter.
	/// </summary>
	public virtual bool GetComputeVorticity()
	{
		return (vtkParticleTracerBase_GetComputeVorticity_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleTracerBase_GetDisableResetCache_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag to disable cache
	/// This is off by default and turned on in special circumstances
	/// such as in a coprocessing workflow
	/// </summary>
	public virtual int GetDisableResetCache()
	{
		return vtkParticleTracerBase_GetDisableResetCache_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleTracerBase_GetEnableParticleWriting_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the filename to be used with the particle writer when
	/// dumping particles to disk
	/// </summary>
	public virtual int GetEnableParticleWriting()
	{
		return vtkParticleTracerBase_GetEnableParticleWriting_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleTracerBase_GetForceReinjectionEveryNSteps_11(HandleRef pThis);

	/// <summary>
	/// When animating particles, it is nice to inject new ones every Nth step
	/// to produce a continuous flow. Setting ForceReinjectionEveryNSteps to a
	/// non zero value will cause the particle source to reinject particles
	/// every Nth step even if it is otherwise unchanged.
	/// Note that if the particle source is also animated, this flag will be
	/// redundant as the particles will be reinjected whenever the source changes
	/// anyway
	/// </summary>
	public virtual int GetForceReinjectionEveryNSteps()
	{
		return vtkParticleTracerBase_GetForceReinjectionEveryNSteps_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkParticleTracerBase_GetForceSerialExecution_12(HandleRef pThis);

	/// <summary>
	/// Force the filter to run particle tracer in serial. This affects
	/// the filter only if more than 100 particles is to be generated.
	/// </summary>
	public virtual bool GetForceSerialExecution()
	{
		return (vtkParticleTracerBase_GetForceSerialExecution_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleTracerBase_GetIgnorePipelineTime_13(HandleRef pThis);

	/// <summary>
	/// To get around problems with the Paraview Animation controls
	/// we can just animate the time step and ignore the TIME_ requests
	/// </summary>
	public virtual int GetIgnorePipelineTime()
	{
		return vtkParticleTracerBase_GetIgnorePipelineTime_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParticleTracerBase_GetIntegrator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Setting TerminationTime to a positive value will cause particles
	/// to terminate when the time is reached. Use a vlue of zero to
	/// disable termination. The units of time should be consistent with the
	/// primary time variable.
	/// </summary>
	public virtual vtkInitialValueProblemSolver GetIntegrator()
	{
		vtkInitialValueProblemSolver vtkInitialValueProblemSolver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParticleTracerBase_GetIntegrator_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkParticleTracerBase_GetIntegratorType_15(HandleRef pThis);

	/// <summary>
	/// Setting TerminationTime to a positive value will cause particles
	/// to terminate when the time is reached. Use a vlue of zero to
	/// disable termination. The units of time should be consistent with the
	/// primary time variable.
	/// </summary>
	public int GetIntegratorType()
	{
		return vtkParticleTracerBase_GetIntegratorType_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleTracerBase_GetMeshOverTime_16(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public virtual int GetMeshOverTime()
	{
		return vtkParticleTracerBase_GetMeshOverTime_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleTracerBase_GetMeshOverTimeMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public virtual int GetMeshOverTimeMaxValue()
	{
		return vtkParticleTracerBase_GetMeshOverTimeMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleTracerBase_GetMeshOverTimeMinValue_18(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public virtual int GetMeshOverTimeMinValue()
	{
		return vtkParticleTracerBase_GetMeshOverTimeMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParticleTracerBase_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParticleTracerBase_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParticleTracerBase_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParticleTracerBase_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParticleTracerBase_GetParticleFileName_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the filename to be used with the particle writer when
	/// dumping particles to disk
	/// </summary>
	public virtual string GetParticleFileName()
	{
		return Marshal.PtrToStringAnsi(vtkParticleTracerBase_GetParticleFileName_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParticleTracerBase_GetParticleWriter_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the Writer associated with this Particle Tracer
	/// Ideally a parallel IO capable vtkH5PartWriter should be used
	/// which will collect particles from all parallel processes
	/// and write them to a single HDF5 file.
	/// </summary>
	public virtual vtkAbstractParticleWriter GetParticleWriter()
	{
		vtkAbstractParticleWriter vtkAbstractParticleWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParticleTracerBase_GetParticleWriter_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractParticleWriter2 = (vtkAbstractParticleWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractParticleWriter2.Register(null);
			}
		}
		return vtkAbstractParticleWriter2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParticleTracerBase_GetRotationScale_23(HandleRef pThis);

	/// <summary>
	/// This can be used to scale the rate with which the streamribbons
	/// twist. The default is 1.
	/// </summary>
	public virtual double GetRotationScale()
	{
		return vtkParticleTracerBase_GetRotationScale_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParticleTracerBase_GetStartTime_24(HandleRef pThis);

	/// <summary>
	/// Set the time value for particle tracing to begin. The units of time should
	/// be consistent with the primary time variable.
	/// </summary>
	public virtual double GetStartTime()
	{
		return vtkParticleTracerBase_GetStartTime_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleTracerBase_GetStaticSeeds_25(HandleRef pThis);

	/// <summary>
	/// if StaticSeeds is set and the mesh is static,
	/// then every time particles are injected we can re-use the same
	/// injection information. We classify particles according to
	/// processor just once before start.
	/// If StaticSeeds is set and a moving seed source is specified
	/// the motion will be ignored and results will not be as expected.
	/// The default is that StaticSeeds is 0.
	/// </summary>
	public virtual int GetStaticSeeds()
	{
		return vtkParticleTracerBase_GetStaticSeeds_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParticleTracerBase_GetTerminalSpeed_26(HandleRef pThis);

	/// <summary>
	/// Specify the terminal speed value, below which integration is terminated.
	/// </summary>
	public virtual double GetTerminalSpeed()
	{
		return vtkParticleTracerBase_GetTerminalSpeed_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParticleTracerBase_GetTerminationTime_27(HandleRef pThis);

	/// <summary>
	/// Setting TerminationTime to a positive value will cause particles
	/// to terminate when the time is reached. Use a vlue of zero to
	/// disable termination. The units of time should be consistent with the
	/// primary time variable.
	/// </summary>
	public virtual double GetTerminationTime()
	{
		return vtkParticleTracerBase_GetTerminationTime_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_IgnorePipelineTimeOff_28(HandleRef pThis);

	/// <summary>
	/// To get around problems with the Paraview Animation controls
	/// we can just animate the time step and ignore the TIME_ requests
	/// </summary>
	public virtual void IgnorePipelineTimeOff()
	{
		vtkParticleTracerBase_IgnorePipelineTimeOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_IgnorePipelineTimeOn_29(HandleRef pThis);

	/// <summary>
	/// To get around problems with the Paraview Animation controls
	/// we can just animate the time step and ignore the TIME_ requests
	/// </summary>
	public virtual void IgnorePipelineTimeOn()
	{
		vtkParticleTracerBase_IgnorePipelineTimeOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleTracerBase_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParticleTracerBase_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleTracerBase_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParticleTracerBase_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParticleTracerBase_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParticleTracerBase NewInstance()
	{
		vtkParticleTracerBase result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParticleTracerBase_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParticleTracerBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_PrintParticleHistories_33(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void PrintParticleHistories()
	{
		vtkParticleTracerBase_PrintParticleHistories_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_RemoveAllSources_34(HandleRef pThis);

	/// <summary>
	/// Provide support for multiple seed sources
	/// </summary>
	public void RemoveAllSources()
	{
		vtkParticleTracerBase_RemoveAllSources_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParticleTracerBase_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParticleTracerBase SafeDownCast(vtkObjectBase o)
	{
		vtkParticleTracerBase vtkParticleTracerBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParticleTracerBase_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParticleTracerBase2 = (vtkParticleTracerBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParticleTracerBase2.Register(null);
			}
		}
		return vtkParticleTracerBase2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetComputeVorticity_36(HandleRef pThis, byte arg0);

	/// <summary>
	/// Turn on/off vorticity computation at streamline points
	/// (necessary for generating proper stream-ribbons using the
	/// vtkRibbonFilter.
	/// </summary>
	public void SetComputeVorticity(bool arg0)
	{
		vtkParticleTracerBase_SetComputeVorticity_36(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetDisableResetCache_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag to disable cache
	/// This is off by default and turned on in special circumstances
	/// such as in a coprocessing workflow
	/// </summary>
	public virtual void SetDisableResetCache(int _arg)
	{
		vtkParticleTracerBase_SetDisableResetCache_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetEnableParticleWriting_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the filename to be used with the particle writer when
	/// dumping particles to disk
	/// </summary>
	public virtual void SetEnableParticleWriting(int _arg)
	{
		vtkParticleTracerBase_SetEnableParticleWriting_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetForceReinjectionEveryNSteps_39(HandleRef pThis, int arg0);

	/// <summary>
	/// When animating particles, it is nice to inject new ones every Nth step
	/// to produce a continuous flow. Setting ForceReinjectionEveryNSteps to a
	/// non zero value will cause the particle source to reinject particles
	/// every Nth step even if it is otherwise unchanged.
	/// Note that if the particle source is also animated, this flag will be
	/// redundant as the particles will be reinjected whenever the source changes
	/// anyway
	/// </summary>
	public void SetForceReinjectionEveryNSteps(int arg0)
	{
		vtkParticleTracerBase_SetForceReinjectionEveryNSteps_39(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetForceSerialExecution_40(HandleRef pThis, byte _arg);

	/// <summary>
	/// Force the filter to run particle tracer in serial. This affects
	/// the filter only if more than 100 particles is to be generated.
	/// </summary>
	public virtual void SetForceSerialExecution(bool _arg)
	{
		vtkParticleTracerBase_SetForceSerialExecution_40(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetIgnorePipelineTime_41(HandleRef pThis, int _arg);

	/// <summary>
	/// To get around problems with the Paraview Animation controls
	/// we can just animate the time step and ignore the TIME_ requests
	/// </summary>
	public virtual void SetIgnorePipelineTime(int _arg)
	{
		vtkParticleTracerBase_SetIgnorePipelineTime_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetIntegrator_42(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Setting TerminationTime to a positive value will cause particles
	/// to terminate when the time is reached. Use a vlue of zero to
	/// disable termination. The units of time should be consistent with the
	/// primary time variable.
	/// </summary>
	public void SetIntegrator(vtkInitialValueProblemSolver arg0)
	{
		vtkParticleTracerBase_SetIntegrator_42(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetIntegratorType_43(HandleRef pThis, int type);

	/// <summary>
	/// Setting TerminationTime to a positive value will cause particles
	/// to terminate when the time is reached. Use a vlue of zero to
	/// disable termination. The units of time should be consistent with the
	/// primary time variable.
	/// </summary>
	public void SetIntegratorType(int type)
	{
		vtkParticleTracerBase_SetIntegratorType_43(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetInterpolatorType_44(HandleRef pThis, int interpolatorType);

	/// <summary>
	/// Set the type of the velocity field interpolator to determine whether
	/// INTERPOLATOR_WITH_DATASET_POINT_LOCATOR or INTERPOLATOR_WITH_CELL_LOCATOR
	/// is employed for locating cells during streamline integration. The latter
	/// (adopting vtkAbstractCellLocator sub-classes such as vtkCellLocator and
	/// vtkModifiedBSPTree) is more robust than the former (through vtkDataSet /
	/// vtkPointSet::FindCell() coupled with vtkPointLocator). However the former
	/// can be much faster and produce adequate results.
	///
	/// Default is INTERPOLATOR_WITH_CELL_LOCATOR (to maintain backwards compatibility).
	/// </summary>
	public void SetInterpolatorType(int interpolatorType)
	{
		vtkParticleTracerBase_SetInterpolatorType_44(GetCppThis(), interpolatorType);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetInterpolatorTypeToCellLocator_45(HandleRef pThis);

	/// <summary>
	/// Set the velocity field interpolator type to one that uses a cell locator
	/// to perform spatial searching. Using a cell locator should always return
	/// the correct results, but it can be much slower that point locator-based
	/// searches. * By default a cell locator is used.
	/// </summary>
	public void SetInterpolatorTypeToCellLocator()
	{
		vtkParticleTracerBase_SetInterpolatorTypeToCellLocator_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetInterpolatorTypeToDataSetPointLocator_46(HandleRef pThis);

	/// <summary>
	/// Set the velocity field interpolator type to one that uses a point
	/// locator to perform local spatial searching. Typically a point locator is
	/// faster than searches with a cell locator, but it may not always find the
	/// correct cells enclosing a point. This is particularly true with meshes
	/// that are disjoint at seams, or abut meshes in an incompatible manner.
	/// </summary>
	public void SetInterpolatorTypeToDataSetPointLocator()
	{
		vtkParticleTracerBase_SetInterpolatorTypeToDataSetPointLocator_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetMeshOverTime_47(HandleRef pThis, int meshOverTime);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public virtual void SetMeshOverTime(int meshOverTime)
	{
		vtkParticleTracerBase_SetMeshOverTime_47(GetCppThis(), meshOverTime);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetMeshOverTimeToDifferent_48(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public void SetMeshOverTimeToDifferent()
	{
		vtkParticleTracerBase_SetMeshOverTimeToDifferent_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetMeshOverTimeToLinearTransformation_49(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public void SetMeshOverTimeToLinearTransformation()
	{
		vtkParticleTracerBase_SetMeshOverTimeToLinearTransformation_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetMeshOverTimeToSameTopology_50(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public void SetMeshOverTimeToSameTopology()
	{
		vtkParticleTracerBase_SetMeshOverTimeToSameTopology_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetMeshOverTimeToStatic_51(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public void SetMeshOverTimeToStatic()
	{
		vtkParticleTracerBase_SetMeshOverTimeToStatic_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetParticleFileName_52(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the filename to be used with the particle writer when
	/// dumping particles to disk
	/// </summary>
	public virtual void SetParticleFileName(string _arg)
	{
		vtkParticleTracerBase_SetParticleFileName_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetParticleWriter_53(HandleRef pThis, HandleRef pw);

	/// <summary>
	/// Set/Get the Writer associated with this Particle Tracer
	/// Ideally a parallel IO capable vtkH5PartWriter should be used
	/// which will collect particles from all parallel processes
	/// and write them to a single HDF5 file.
	/// </summary>
	public virtual void SetParticleWriter(vtkAbstractParticleWriter pw)
	{
		vtkParticleTracerBase_SetParticleWriter_53(GetCppThis(), pw?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetRotationScale_54(HandleRef pThis, double arg0);

	/// <summary>
	/// This can be used to scale the rate with which the streamribbons
	/// twist. The default is 1.
	/// </summary>
	public void SetRotationScale(double arg0)
	{
		vtkParticleTracerBase_SetRotationScale_54(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetStartTime_55(HandleRef pThis, double t);

	/// <summary>
	/// Set the time value for particle tracing to begin. The units of time should
	/// be consistent with the primary time variable.
	/// </summary>
	public void SetStartTime(double t)
	{
		vtkParticleTracerBase_SetStartTime_55(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetStaticSeeds_56(HandleRef pThis, int _arg);

	/// <summary>
	/// if StaticSeeds is set and the mesh is static,
	/// then every time particles are injected we can re-use the same
	/// injection information. We classify particles according to
	/// processor just once before start.
	/// If StaticSeeds is set and a moving seed source is specified
	/// the motion will be ignored and results will not be as expected.
	/// The default is that StaticSeeds is 0.
	/// </summary>
	public virtual void SetStaticSeeds(int _arg)
	{
		vtkParticleTracerBase_SetStaticSeeds_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetTerminalSpeed_57(HandleRef pThis, double arg0);

	/// <summary>
	/// Specify the terminal speed value, below which integration is terminated.
	/// </summary>
	public void SetTerminalSpeed(double arg0)
	{
		vtkParticleTracerBase_SetTerminalSpeed_57(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleTracerBase_SetTerminationTime_58(HandleRef pThis, double t);

	/// <summary>
	/// Setting TerminationTime to a positive value will cause particles
	/// to terminate when the time is reached. Use a vlue of zero to
	/// disable termination. The units of time should be consistent with the
	/// primary time variable.
	/// </summary>
	public void SetTerminationTime(double t)
	{
		vtkParticleTracerBase_SetTerminationTime_58(GetCppThis(), t);
	}
}
