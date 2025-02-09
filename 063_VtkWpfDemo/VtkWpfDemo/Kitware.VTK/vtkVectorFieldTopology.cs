using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVectorFieldTopology
/// </summary>
/// <remarks>
///    Extract the topological skeleton as output datasets
///
/// vtkVectorFieldTopology is a filter that extracts the critical points and the 1D separatrices
/// (lines) If the data is 3D and the user enables ComputeSurfaces, also the 2D separatrices are
/// computed (surfaces)
///
/// @par Thanks:
/// Developed by Roxana Bujack and Karen Tsai at Los Alamos National Laboratory under LDRD 20190143ER
/// </remarks>
public class vtkVectorFieldTopology : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVectorFieldTopology";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVectorFieldTopology()
	{
		MRClassNameKey = "class vtkVectorFieldTopology";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVectorFieldTopology"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVectorFieldTopology(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorFieldTopology_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVectorFieldTopology New()
	{
		vtkVectorFieldTopology result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVectorFieldTopology_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVectorFieldTopology)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVectorFieldTopology()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVectorFieldTopology_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkVectorFieldTopology_GetComputeSurfaces_01(HandleRef pThis);

	/// <summary>
	/// Specify/see if the separating surfaces (separatrices in 3D) are computed or not
	/// </summary>
	public virtual bool GetComputeSurfaces()
	{
		return (vtkVectorFieldTopology_GetComputeSurfaces_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVectorFieldTopology_GetEpsilonCriticalPoint_02(HandleRef pThis);

	/// <summary>
	/// Specify EpsilonCriticalPoint for classifying critical points. The default is 1e-10.
	/// </summary>
	public virtual double GetEpsilonCriticalPoint()
	{
		return vtkVectorFieldTopology_GetEpsilonCriticalPoint_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVectorFieldTopology_GetExcludeBoundary_03(HandleRef pThis);

	/// <summary>
	/// Specify/see if the boundary cells are treated or not
	/// </summary>
	public virtual bool GetExcludeBoundary()
	{
		return (vtkVectorFieldTopology_GetExcludeBoundary_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVectorFieldTopology_GetIntegrationStepSize_04(HandleRef pThis);

	/// <summary>
	/// Specify the Initial, minimum, and maximum step size used for line integration,
	/// expressed in IntegrationStepUnit
	/// </summary>
	public virtual double GetIntegrationStepSize()
	{
		return vtkVectorFieldTopology_GetIntegrationStepSize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVectorFieldTopology_GetIntegrationStepUnit_05(HandleRef pThis);

	/// <summary>
	/// Specify a uniform integration step unit for MinimumIntegrationStep,
	/// InitialIntegrationStep, and MaximumIntegrationStep.
	/// 1 = LENGTH_UNIT, i.e. all sizes are expresed in coordinate scale or cell scale
	/// 2 = CELL_LENGTH_UNIT, i.e. all sizes are expresed in cell scale
	/// </summary>
	public virtual int GetIntegrationStepUnit()
	{
		return vtkVectorFieldTopology_GetIntegrationStepUnit_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVectorFieldTopology_GetMaxNumSteps_06(HandleRef pThis);

	/// <summary>
	/// Specify/see the maximal number of iterations in this class and in vtkStreamTracer
	/// </summary>
	public virtual int GetMaxNumSteps()
	{
		return vtkVectorFieldTopology_GetMaxNumSteps_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVectorFieldTopology_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVectorFieldTopology_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVectorFieldTopology_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVectorFieldTopology_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVectorFieldTopology_GetOffsetAwayFromBoundary_09(HandleRef pThis);

	/// <summary>
	/// Specify the OffsetAwayFromBoundary to shift seeds for computing separating lines/surfaces
	/// </summary>
	public virtual double GetOffsetAwayFromBoundary()
	{
		return vtkVectorFieldTopology_GetOffsetAwayFromBoundary_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVectorFieldTopology_GetSeparatrixDistance_10(HandleRef pThis);

	/// <summary>
	/// Specify/see the distance by which the seedpoints of the separatrices are placed away from the
	/// saddle expressed in IntegrationStepUnit
	/// </summary>
	public virtual double GetSeparatrixDistance()
	{
		return vtkVectorFieldTopology_GetSeparatrixDistance_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVectorFieldTopology_GetUseBoundarySwitchPoints_11(HandleRef pThis);

	/// <summary>
	/// Specify/see whether to use boundary switch points/lines points as seeds or not
	/// </summary>
	public virtual bool GetUseBoundarySwitchPoints()
	{
		return (vtkVectorFieldTopology_GetUseBoundarySwitchPoints_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVectorFieldTopology_GetUseIterativeSeeding_12(HandleRef pThis);

	/// <summary>
	/// Specify/see if the simple (fast) or iterative (correct) version is called
	/// </summary>
	public virtual bool GetUseIterativeSeeding()
	{
		return (vtkVectorFieldTopology_GetUseIterativeSeeding_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVectorFieldTopology_GetVectorAngleThreshold_13(HandleRef pThis);

	/// <summary>
	/// Specify the VectorAngleThreshold to remove noisy boundary switch points/lines
	/// When computing boundary switch point, if the vectors of the two points within a cell are almost
	/// parallel, the boundary switch point computed is considered as a noise point. Let v0 and v1 be
	/// the vectors of the two points, and their norm equal to 1. The dot product between them
	/// Dot(v0,v1) = cos(theta), where theta is the angle between v0 and v1. When v0 and v1 are almost
	/// parallel, abs(Dot(v0,v1)) is close to 1. The range of this threshold is [0,1]. For any
	/// abs(Dot(v0,v1)) &gt; VectorAngleThreshold, the boundary switch point computed is a noise point.
	/// </summary>
	public virtual double GetVectorAngleThreshold()
	{
		return vtkVectorFieldTopology_GetVectorAngleThreshold_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVectorFieldTopology_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVectorFieldTopology_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVectorFieldTopology_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVectorFieldTopology_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorFieldTopology_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVectorFieldTopology NewInstance()
	{
		vtkVectorFieldTopology result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVectorFieldTopology_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVectorFieldTopology)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorFieldTopology_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVectorFieldTopology SafeDownCast(vtkObjectBase o)
	{
		vtkVectorFieldTopology vtkVectorFieldTopology2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVectorFieldTopology_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVectorFieldTopology2 = (vtkVectorFieldTopology)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVectorFieldTopology2.Register(null);
			}
		}
		return vtkVectorFieldTopology2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetComputeSurfaces_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify/see if the separating surfaces (separatrices in 3D) are computed or not
	/// </summary>
	public virtual void SetComputeSurfaces(bool _arg)
	{
		vtkVectorFieldTopology_SetComputeSurfaces_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetEpsilonCriticalPoint_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify EpsilonCriticalPoint for classifying critical points. The default is 1e-10.
	/// </summary>
	public virtual void SetEpsilonCriticalPoint(double _arg)
	{
		vtkVectorFieldTopology_SetEpsilonCriticalPoint_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetExcludeBoundary_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify/see if the boundary cells are treated or not
	/// </summary>
	public virtual void SetExcludeBoundary(bool _arg)
	{
		vtkVectorFieldTopology_SetExcludeBoundary_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetIntegrationStepSize_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the Initial, minimum, and maximum step size used for line integration,
	/// expressed in IntegrationStepUnit
	/// </summary>
	public virtual void SetIntegrationStepSize(double _arg)
	{
		vtkVectorFieldTopology_SetIntegrationStepSize_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetIntegrationStepUnit_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify a uniform integration step unit for MinimumIntegrationStep,
	/// InitialIntegrationStep, and MaximumIntegrationStep.
	/// 1 = LENGTH_UNIT, i.e. all sizes are expresed in coordinate scale or cell scale
	/// 2 = CELL_LENGTH_UNIT, i.e. all sizes are expresed in cell scale
	/// </summary>
	public virtual void SetIntegrationStepUnit(int _arg)
	{
		vtkVectorFieldTopology_SetIntegrationStepUnit_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetInterpolatorType_24(HandleRef pThis, int interpType);

	/// <summary>
	/// Set the type of the velocity field interpolator to determine whether
	/// INTERPOLATOR_WITH_DATASET_POINT_LOCATOR or INTERPOLATOR_WITH_CELL_LOCATOR is employed for
	/// locating cells during streamline integration.
	/// </summary>
	public void SetInterpolatorType(int interpType)
	{
		vtkVectorFieldTopology_SetInterpolatorType_24(GetCppThis(), interpType);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetInterpolatorTypeToCellLocator_25(HandleRef pThis);

	/// <summary>
	/// Set the velocity field interpolator type to the one involving a cell locator.
	/// </summary>
	public void SetInterpolatorTypeToCellLocator()
	{
		vtkVectorFieldTopology_SetInterpolatorTypeToCellLocator_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetInterpolatorTypeToDataSetPointLocator_26(HandleRef pThis);

	/// <summary>
	/// Set the velocity field interpolator type to the one involving a dataset point locator.
	/// </summary>
	public void SetInterpolatorTypeToDataSetPointLocator()
	{
		vtkVectorFieldTopology_SetInterpolatorTypeToDataSetPointLocator_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetMaxNumSteps_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify/see the maximal number of iterations in this class and in vtkStreamTracer
	/// </summary>
	public virtual void SetMaxNumSteps(int _arg)
	{
		vtkVectorFieldTopology_SetMaxNumSteps_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetOffsetAwayFromBoundary_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the OffsetAwayFromBoundary to shift seeds for computing separating lines/surfaces
	/// </summary>
	public virtual void SetOffsetAwayFromBoundary(double _arg)
	{
		vtkVectorFieldTopology_SetOffsetAwayFromBoundary_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetSeparatrixDistance_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify/see the distance by which the seedpoints of the separatrices are placed away from the
	/// saddle expressed in IntegrationStepUnit
	/// </summary>
	public virtual void SetSeparatrixDistance(double _arg)
	{
		vtkVectorFieldTopology_SetSeparatrixDistance_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetUseBoundarySwitchPoints_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify/see whether to use boundary switch points/lines points as seeds or not
	/// </summary>
	public virtual void SetUseBoundarySwitchPoints(bool _arg)
	{
		vtkVectorFieldTopology_SetUseBoundarySwitchPoints_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetUseIterativeSeeding_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify/see if the simple (fast) or iterative (correct) version is called
	/// </summary>
	public virtual void SetUseIterativeSeeding(bool _arg)
	{
		vtkVectorFieldTopology_SetUseIterativeSeeding_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorFieldTopology_SetVectorAngleThreshold_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the VectorAngleThreshold to remove noisy boundary switch points/lines
	/// When computing boundary switch point, if the vectors of the two points within a cell are almost
	/// parallel, the boundary switch point computed is considered as a noise point. Let v0 and v1 be
	/// the vectors of the two points, and their norm equal to 1. The dot product between them
	/// Dot(v0,v1) = cos(theta), where theta is the angle between v0 and v1. When v0 and v1 are almost
	/// parallel, abs(Dot(v0,v1)) is close to 1. The range of this threshold is [0,1]. For any
	/// abs(Dot(v0,v1)) &gt; VectorAngleThreshold, the boundary switch point computed is a noise point.
	/// </summary>
	public virtual void SetVectorAngleThreshold(double _arg)
	{
		vtkVectorFieldTopology_SetVectorAngleThreshold_32(GetCppThis(), _arg);
	}
}
