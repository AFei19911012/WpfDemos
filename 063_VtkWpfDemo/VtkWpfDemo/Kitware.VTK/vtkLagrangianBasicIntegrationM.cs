using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLagrangianBasicIntegrationModel
/// </summary>
/// <remarks>
///    vtkFunctionSet abstract implementation to be used
/// in the vtkLagrangianParticleTracker integrator.
///
/// This vtkFunctionSet abstract implementation
/// is meant to be used as a parameter of vtkLagrangianParticleTracker.
/// It manages multiple dataset locators in order to evaluate the
/// vtkFunctionSet::FunctionValues method.
/// The actual FunctionValues implementation should be found in the class inheriting
/// this class.
/// Input Arrays to process are expected as follows:
/// Index 0 : "SurfaceType" array of surface input of the particle tracker
///
/// Inherited classes MUST implement
/// int FunctionValues(vtkDataSet* detaSet, vtkIdType cellId, double* weights,
///    double * x, double * f);
/// to define how the integration works.
///
/// Inherited classes could reimplement InteractWithSurface or other surface interaction methods
/// to change the way particles interact with surfaces.
///
/// Inherited classes could reimplement IntersectWithLine to use a specific algorithm
/// to intersect particles and surface cells.
///
/// Inherited classes could reimplement CheckFreeFlightTermination to set
/// the way particles terminate in free flight.
///
/// Inherited classes could reimplement Initialize*Data and Insert*Data in order
/// to customize the output of the tracker
///
/// </remarks>
/// <seealso>
///
/// vtkLagrangianParticleTracker vtkLagrangianParticle
/// vtkLagrangianMatidaIntegrationModel
/// </seealso>
public abstract class vtkLagrangianBasicIntegrationModel : vtkFunctionSet
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum SurfaceType
	{
		/// <summary>enum member</summary>
		SURFACE_TYPE_BOUNCE = 2,
		/// <summary>enum member</summary>
		SURFACE_TYPE_BREAK = 3,
		/// <summary>enum member</summary>
		SURFACE_TYPE_MODEL = 0,
		/// <summary>enum member</summary>
		SURFACE_TYPE_PASS = 4,
		/// <summary>enum member</summary>
		SURFACE_TYPE_TERM = 1
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum VariableStep
	{
		/// <summary>enum member</summary>
		VARIABLE_STEP_CURRENT = 0,
		/// <summary>enum member</summary>
		VARIABLE_STEP_NEXT = 1,
		/// <summary>enum member</summary>
		VARIABLE_STEP_PREV = -1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangianBasicIntegrationModel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLagrangianBasicIntegrationModel()
	{
		MRClassNameKey = "class vtkLagrangianBasicIntegrationModel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangianBasicIntegrationModel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLagrangianBasicIntegrationModel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkLagrangianBasicIntegrationModel_AddDataSet_01(HandleRef pThis, HandleRef dataset, byte surface, uint surfaceFlatIndex);

	/// <summary>
	/// Add a dataset to locate cells in
	/// This create a specific locator for the provided dataset
	/// using the Locator member of this class
	/// The surface flag allow to manage surfaces datasets for surface interaction
	/// instead of flow datasets
	/// surfaceFlatIndex, used only with composite surface, in order to identify the
	/// flatIndex of the surface for particle interaction
	/// </summary>
	public virtual void AddDataSet(vtkDataSet dataset, bool surface, uint surfaceFlatIndex)
	{
		vtkLagrangianBasicIntegrationModel_AddDataSet_01(GetCppThis(), dataset?.GetCppThis() ?? default(HandleRef), (byte)(surface ? 1u : 0u), surfaceFlatIndex);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_ClearDataSets_02(HandleRef pThis, byte surface);

	/// <summary>
	/// Add a dataset to locate cells in
	/// This create a specific locator for the provided dataset
	/// using the Locator member of this class
	/// The surface flag allow to manage surfaces datasets for surface interaction
	/// instead of flow datasets
	/// surfaceFlatIndex, used only with composite surface, in order to identify the
	/// flatIndex of the surface for particle interaction
	/// </summary>
	public virtual void ClearDataSets(bool surface)
	{
		vtkLagrangianBasicIntegrationModel_ClearDataSets_02(GetCppThis(), (byte)(surface ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLagrangianBasicIntegrationModel_FinalizeOutputs_03(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Enable model post process on output
	/// Return true if successful, false otherwise
	/// Empty and Always return true with basic model
	/// </summary>
	public virtual bool FinalizeOutputs(vtkPolyData arg0, vtkDataObject arg1)
	{
		return (vtkLagrangianBasicIntegrationModel_FinalizeOutputs_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangianBasicIntegrationModel_FunctionValues_04(HandleRef pThis, IntPtr x, IntPtr f, IntPtr userData);

	/// <summary>
	/// Evaluate integration model velocity f at position x.
	/// Look for the cell containing the position x in all its added datasets
	/// if found this will call
	/// FunctionValues(vtkDataSet* detaSet, vtkIdType cellId, double* x, double* f)
	/// This method is thread safe.
	/// </summary>
	public override int FunctionValues(IntPtr x, IntPtr f, IntPtr userData)
	{
		return vtkLagrangianBasicIntegrationModel_FunctionValues_04(GetCppThis(), x, f, userData);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetLocator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the locator used to locate cells in the datasets.
	/// Only the locator class matter here, as it is used only to
	/// create NewInstance of it.
	/// Default is a vtkCellLocator.
	/// </summary>
	public virtual vtkAbstractCellLocator GetLocator()
	{
		vtkAbstractCellLocator vtkAbstractCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_GetLocator_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractCellLocator2 = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractCellLocator2.Register(null);
			}
		}
		return vtkAbstractCellLocator2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLagrangianBasicIntegrationModel_GetLocatorTolerance_06(HandleRef pThis);

	/// <summary>
	/// Get the specific tolerance to use with the locators.
	/// </summary>
	public virtual double GetLocatorTolerance()
	{
		return vtkLagrangianBasicIntegrationModel_GetLocatorTolerance_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLagrangianBasicIntegrationModel_GetLocatorsBuilt_07(HandleRef pThis);

	/// <summary>
	/// Get the state of the current locators
	/// </summary>
	public virtual bool GetLocatorsBuilt()
	{
		return (vtkLagrangianBasicIntegrationModel_GetLocatorsBuilt_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLagrangianBasicIntegrationModel_GetNonPlanarQuadSupport_08(HandleRef pThis);

	/// <summary>
	/// Set/Get Non Planar Quad Support
	/// </summary>
	public virtual bool GetNonPlanarQuadSupport()
	{
		return (vtkLagrangianBasicIntegrationModel_GetNonPlanarQuadSupport_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLagrangianBasicIntegrationModel_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLagrangianBasicIntegrationModel_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLagrangianBasicIntegrationModel_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLagrangianBasicIntegrationModel_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangianBasicIntegrationModel_GetNumberOfTrackedUserData_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of tracked user data attached to the particles.
	/// Tracked user data are data that are related to each particle position
	/// but are not integrated like the user variables.
	/// They are not saved in the particle path.
	/// Default is 0.
	/// </summary>
	public virtual int GetNumberOfTrackedUserData()
	{
		return vtkLagrangianBasicIntegrationModel_GetNumberOfTrackedUserData_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSeedArray_12(HandleRef pThis, int idx, HandleRef pointData, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a seed array, as set in setInputArrayToProcess
	/// from the provided seed point data
	/// </summary>
	public virtual vtkAbstractArray GetSeedArray(int idx, vtkPointData pointData)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_GetSeedArray_12(GetCppThis(), idx, pointData?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSeedArrayComps_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the seed arrays expected number of components
	/// Used Only be the vtkLagrangianSeedHelper in ParaView plugins
	/// </summary>
	public virtual vtkIntArray GetSeedArrayComps()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_GetSeedArrayComps_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntArray2 = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntArray2.Register(null);
			}
		}
		return vtkIntArray2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSeedArrayNames_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the seed arrays expected name
	/// Used Only be the vtkLagrangianSeedHelper in ParaView plugins
	/// </summary>
	public virtual vtkStringArray GetSeedArrayNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_GetSeedArrayNames_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSeedArrayTypes_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the seed arrays expected type
	/// Used Only be the vtkLagrangianSeedHelper in ParaView plugins
	/// </summary>
	public virtual vtkIntArray GetSeedArrayTypes()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_GetSeedArrayTypes_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntArray2 = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntArray2.Register(null);
			}
		}
		return vtkIntArray2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSurfaceArrayComps_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the seed array expected number of components
	/// Used Only be the vtkLagrangianSurfaceHelper in ParaView plugins
	/// </summary>
	public virtual vtkIntArray GetSurfaceArrayComps()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_GetSurfaceArrayComps_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntArray2 = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntArray2.Register(null);
			}
		}
		return vtkIntArray2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSurfaceArrayDefaultValues_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the surface arrays default values for each leaf
	/// Used Only be the vtkLagrangianSurfaceHelper in ParaView plugins
	/// </summary>
	public virtual vtkDoubleArray GetSurfaceArrayDefaultValues()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_GetSurfaceArrayDefaultValues_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSurfaceArrayEnumValues_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the surface arrays expected values and associated enums
	/// Used Only be the vtkLagrangianSurfaceHelper in ParaView plugins
	/// </summary>
	public virtual vtkStringArray GetSurfaceArrayEnumValues()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_GetSurfaceArrayEnumValues_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSurfaceArrayNames_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the surface arrays expected name
	/// Used Only be the vtkLagrangianSurfaceHelper in ParaView plugins
	/// </summary>
	public virtual vtkStringArray GetSurfaceArrayNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_GetSurfaceArrayNames_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSurfaceArrayTypes_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the surface arrays expected type
	/// Used Only be the vtkLagrangianSurfaceHelper in ParaView plugins
	/// </summary>
	public virtual vtkIntArray GetSurfaceArrayTypes()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_GetSurfaceArrayTypes_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntArray2 = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntArray2.Register(null);
			}
		}
		return vtkIntArray2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLagrangianBasicIntegrationModel_GetTolerance_21(HandleRef pThis);

	/// <summary>
	/// Get the tolerance to use with this model.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkLagrangianBasicIntegrationModel_GetTolerance_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLagrangianBasicIntegrationModel_GetUseInitialIntegrationTime_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the Use of initial integration input array to process
	/// </summary>
	public virtual bool GetUseInitialIntegrationTime()
	{
		return (vtkLagrangianBasicIntegrationModel_GetUseInitialIntegrationTime_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangianBasicIntegrationModel_GetWeightsSize_23(HandleRef pThis);

	/// <summary>
	/// Get the maximum weights size necessary for calling
	/// FindInLocators with weights
	/// </summary>
	public virtual int GetWeightsSize()
	{
		return vtkLagrangianBasicIntegrationModel_GetWeightsSize_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_InitializeInteractionData_24(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Method used by the LPT to initialize data insertion in the provided
	/// vtkFieldData. It initializes Interaction.
	/// Reimplement as needed in accordance with InsertInteractionData.
	/// </summary>
	public virtual void InitializeInteractionData(vtkFieldData data)
	{
		vtkLagrangianBasicIntegrationModel_InitializeInteractionData_24(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_InitializeParticleData_25(HandleRef pThis, HandleRef particleData, int maxTuples);

	/// <summary>
	/// Method used by the LPT to initialize data insertion in the provided
	/// vtkFieldData. It initializes StepNumber, ParticleVelocity, IntegrationTime.
	/// Reimplement as needed in accordance with InsertParticleData.
	/// </summary>
	public virtual void InitializeParticleData(vtkFieldData particleData, int maxTuples)
	{
		vtkLagrangianBasicIntegrationModel_InitializeParticleData_25(GetCppThis(), particleData?.GetCppThis() ?? default(HandleRef), maxTuples);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_InitializePathData_26(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Method used by the LPT to initialize data insertion in the provided
	/// vtkFieldData. It initializes Id, ParentID, SeedID and Termination.
	/// Reimplement as needed in accordance with InsertPathData.
	/// </summary>
	public virtual void InitializePathData(vtkFieldData data)
	{
		vtkLagrangianBasicIntegrationModel_InitializePathData_26(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangianBasicIntegrationModel_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLagrangianBasicIntegrationModel_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangianBasicIntegrationModel_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLagrangianBasicIntegrationModel_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLagrangianBasicIntegrationModel NewInstance()
	{
		vtkLagrangianBasicIntegrationModel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLagrangianBasicIntegrationModel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_NonPlanarQuadSupportOff_30(HandleRef pThis);

	/// <summary>
	/// Set/Get Non Planar Quad Support
	/// </summary>
	public virtual void NonPlanarQuadSupportOff()
	{
		vtkLagrangianBasicIntegrationModel_NonPlanarQuadSupportOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_NonPlanarQuadSupportOn_31(HandleRef pThis);

	/// <summary>
	/// Set/Get Non Planar Quad Support
	/// </summary>
	public virtual void NonPlanarQuadSupportOn()
	{
		vtkLagrangianBasicIntegrationModel_NonPlanarQuadSupportOn_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_PreParticleInitalization_32(HandleRef pThis);

	/// <summary>
	/// Allow for model setup prior to Particle Initalization
	/// </summary>
	public virtual void PreParticleInitalization()
	{
		vtkLagrangianBasicIntegrationModel_PreParticleInitalization_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangianBasicIntegrationModel_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLagrangianBasicIntegrationModel SafeDownCast(vtkObjectBase o)
	{
		vtkLagrangianBasicIntegrationModel vtkLagrangianBasicIntegrationModel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangianBasicIntegrationModel_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLagrangianBasicIntegrationModel_SetInputArrayToProcess_34(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, string name);

	/// <summary>
	/// Set a input array to process at a specific index, identified by a port,
	/// connection, fieldAssociation and a name.
	/// Each inherited class can specify their own input array to process
	/// </summary>
	public virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, string name)
	{
		vtkLagrangianBasicIntegrationModel_SetInputArrayToProcess_34(GetCppThis(), idx, port, connection, fieldAssociation, name);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_SetLocator_35(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set/Get the locator used to locate cells in the datasets.
	/// Only the locator class matter here, as it is used only to
	/// create NewInstance of it.
	/// Default is a vtkCellLocator.
	/// </summary>
	public virtual void SetLocator(vtkAbstractCellLocator locator)
	{
		vtkLagrangianBasicIntegrationModel_SetLocator_35(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_SetLocatorsBuilt_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get the state of the current locators
	/// </summary>
	public virtual void SetLocatorsBuilt(bool _arg)
	{
		vtkLagrangianBasicIntegrationModel_SetLocatorsBuilt_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_SetNonPlanarQuadSupport_37(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get Non Planar Quad Support
	/// </summary>
	public virtual void SetNonPlanarQuadSupport(bool _arg)
	{
		vtkLagrangianBasicIntegrationModel_SetNonPlanarQuadSupport_37(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_SetNumberOfTrackedUserData_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of tracked user data attached to the particles.
	/// Tracked user data are data that are related to each particle position
	/// but are not integrated like the user variables.
	/// They are not saved in the particle path.
	/// Default is 0.
	/// </summary>
	public virtual void SetNumberOfTrackedUserData(int _arg)
	{
		vtkLagrangianBasicIntegrationModel_SetNumberOfTrackedUserData_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_SetTracker_39(HandleRef pThis, HandleRef Tracker);

	/// <summary>
	/// Set the parent tracker.
	/// </summary>
	public virtual void SetTracker(vtkLagrangianParticleTracker Tracker)
	{
		vtkLagrangianBasicIntegrationModel_SetTracker_39(GetCppThis(), Tracker?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_SetUseInitialIntegrationTime_40(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the Use of initial integration input array to process
	/// </summary>
	public virtual void SetUseInitialIntegrationTime(bool _arg)
	{
		vtkLagrangianBasicIntegrationModel_SetUseInitialIntegrationTime_40(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_UseInitialIntegrationTimeOff_41(HandleRef pThis);

	/// <summary>
	/// Set/Get the Use of initial integration input array to process
	/// </summary>
	public virtual void UseInitialIntegrationTimeOff()
	{
		vtkLagrangianBasicIntegrationModel_UseInitialIntegrationTimeOff_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangianBasicIntegrationModel_UseInitialIntegrationTimeOn_42(HandleRef pThis);

	/// <summary>
	/// Set/Get the Use of initial integration input array to process
	/// </summary>
	public virtual void UseInitialIntegrationTimeOn()
	{
		vtkLagrangianBasicIntegrationModel_UseInitialIntegrationTimeOn_42(GetCppThis());
	}
}
