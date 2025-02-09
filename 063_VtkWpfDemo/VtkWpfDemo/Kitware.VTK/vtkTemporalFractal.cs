using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTemporalFractal
/// </summary>
/// <remarks>
///    A source to test AMR data object.
///
/// vtkTemporalFractal is a collection of uniform grids.  All have the same
/// dimensions. Each block has a different origin and spacing.  It uses
/// mandelbrot to create cell data. The fractal array is scaled to look like a
/// volume fraction.
///
/// I may also add block id and level as extra cell arrays.
/// This source produces a vtkHierarchicalBoxDataSet when
/// GenerateRectilinearGrids is off, otherwise produces a vtkMultiBlockDataSet.
/// </remarks>
public class vtkTemporalFractal : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalFractal";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTemporalFractal()
	{
		MRClassNameKey = "class vtkTemporalFractal";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalFractal"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTemporalFractal(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalFractal_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkTemporalFractal New()
	{
		vtkTemporalFractal result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalFractal_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalFractal)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkTemporalFractal()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTemporalFractal_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_AdaptiveSubdivisionOff_01(HandleRef pThis);

	/// <summary>
	/// Make the division adaptive or not, defaults to Adaptive
	/// </summary>
	public virtual void AdaptiveSubdivisionOff()
	{
		vtkTemporalFractal_AdaptiveSubdivisionOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_AdaptiveSubdivisionOn_02(HandleRef pThis);

	/// <summary>
	/// Make the division adaptive or not, defaults to Adaptive
	/// </summary>
	public virtual void AdaptiveSubdivisionOn()
	{
		vtkTemporalFractal_AdaptiveSubdivisionOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_DiscreteTimeStepsOff_03(HandleRef pThis);

	/// <summary>
	/// Limit this source to discrete integer time steps
	/// Default is off (continuous)
	/// </summary>
	public virtual void DiscreteTimeStepsOff()
	{
		vtkTemporalFractal_DiscreteTimeStepsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_DiscreteTimeStepsOn_04(HandleRef pThis);

	/// <summary>
	/// Limit this source to discrete integer time steps
	/// Default is off (continuous)
	/// </summary>
	public virtual void DiscreteTimeStepsOn()
	{
		vtkTemporalFractal_DiscreteTimeStepsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_GenerateRectilinearGridsOff_05(HandleRef pThis);

	/// <summary>
	/// Generate either rectilinear grids either uniform grids.
	/// Default is false.
	/// </summary>
	public virtual void GenerateRectilinearGridsOff()
	{
		vtkTemporalFractal_GenerateRectilinearGridsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_GenerateRectilinearGridsOn_06(HandleRef pThis);

	/// <summary>
	/// Generate either rectilinear grids either uniform grids.
	/// Default is false.
	/// </summary>
	public virtual void GenerateRectilinearGridsOn()
	{
		vtkTemporalFractal_GenerateRectilinearGridsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalFractal_GetAdaptiveSubdivision_07(HandleRef pThis);

	/// <summary>
	/// Make the division adaptive or not, defaults to Adaptive
	/// </summary>
	public virtual int GetAdaptiveSubdivision()
	{
		return vtkTemporalFractal_GetAdaptiveSubdivision_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalFractal_GetAsymmetric_08(HandleRef pThis);

	/// <summary>
	/// Test the case when the blocks do not have the same sizes.
	/// Adds 2 to the x extent of the far x blocks (level 1).
	/// </summary>
	public virtual int GetAsymmetric()
	{
		return vtkTemporalFractal_GetAsymmetric_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalFractal_GetDimensions_09(HandleRef pThis);

	/// <summary>
	/// XYZ dimensions of cells.
	/// </summary>
	public virtual int GetDimensions()
	{
		return vtkTemporalFractal_GetDimensions_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalFractal_GetDiscreteTimeSteps_10(HandleRef pThis);

	/// <summary>
	/// Limit this source to discrete integer time steps
	/// Default is off (continuous)
	/// </summary>
	public virtual int GetDiscreteTimeSteps()
	{
		return vtkTemporalFractal_GetDiscreteTimeSteps_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkTemporalFractal_GetFractalValue_11(HandleRef pThis);

	/// <summary>
	/// Essentially the iso surface value.  The fractal array is scaled to map
	/// this value to 0.5 for use as a volume fraction.
	/// </summary>
	public virtual float GetFractalValue()
	{
		return vtkTemporalFractal_GetFractalValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalFractal_GetGenerateRectilinearGrids_12(HandleRef pThis);

	/// <summary>
	/// Generate either rectilinear grids either uniform grids.
	/// Default is false.
	/// </summary>
	public virtual int GetGenerateRectilinearGrids()
	{
		return vtkTemporalFractal_GetGenerateRectilinearGrids_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalFractal_GetGhostLevels_13(HandleRef pThis);

	/// <summary>
	/// For testing ghost levels.
	/// </summary>
	public virtual int GetGhostLevels()
	{
		return vtkTemporalFractal_GetGhostLevels_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalFractal_GetMaximumLevel_14(HandleRef pThis);

	/// <summary>
	/// Any blocks touching a predefined line will be subdivided to this level.
	/// Other blocks are subdivided so that neighboring blocks only differ
	/// by one level.
	/// </summary>
	public virtual int GetMaximumLevel()
	{
		return vtkTemporalFractal_GetMaximumLevel_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalFractal_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTemporalFractal_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalFractal_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTemporalFractal_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalFractal_GetTwoDimensional_17(HandleRef pThis);

	/// <summary>
	/// Make a 2D data set to test.
	/// </summary>
	public virtual int GetTwoDimensional()
	{
		return vtkTemporalFractal_GetTwoDimensional_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_GhostLevelsOff_18(HandleRef pThis);

	/// <summary>
	/// For testing ghost levels.
	/// </summary>
	public virtual void GhostLevelsOff()
	{
		vtkTemporalFractal_GhostLevelsOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_GhostLevelsOn_19(HandleRef pThis);

	/// <summary>
	/// For testing ghost levels.
	/// </summary>
	public virtual void GhostLevelsOn()
	{
		vtkTemporalFractal_GhostLevelsOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalFractal_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTemporalFractal_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalFractal_IsTypeOf_21(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTemporalFractal_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalFractal_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkTemporalFractal NewInstance()
	{
		vtkTemporalFractal result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalFractal_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalFractal)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalFractal_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkTemporalFractal SafeDownCast(vtkObjectBase o)
	{
		vtkTemporalFractal vtkTemporalFractal2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalFractal_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTemporalFractal2 = (vtkTemporalFractal)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTemporalFractal2.Register(null);
			}
		}
		return vtkTemporalFractal2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_SetAdaptiveSubdivision_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Make the division adaptive or not, defaults to Adaptive
	/// </summary>
	public virtual void SetAdaptiveSubdivision(int _arg)
	{
		vtkTemporalFractal_SetAdaptiveSubdivision_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_SetAsymmetric_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Test the case when the blocks do not have the same sizes.
	/// Adds 2 to the x extent of the far x blocks (level 1).
	/// </summary>
	public virtual void SetAsymmetric(int _arg)
	{
		vtkTemporalFractal_SetAsymmetric_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_SetDimensions_27(HandleRef pThis, int _arg);

	/// <summary>
	/// XYZ dimensions of cells.
	/// </summary>
	public virtual void SetDimensions(int _arg)
	{
		vtkTemporalFractal_SetDimensions_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_SetDiscreteTimeSteps_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Limit this source to discrete integer time steps
	/// Default is off (continuous)
	/// </summary>
	public virtual void SetDiscreteTimeSteps(int _arg)
	{
		vtkTemporalFractal_SetDiscreteTimeSteps_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_SetFractalValue_29(HandleRef pThis, float _arg);

	/// <summary>
	/// Essentially the iso surface value.  The fractal array is scaled to map
	/// this value to 0.5 for use as a volume fraction.
	/// </summary>
	public virtual void SetFractalValue(float _arg)
	{
		vtkTemporalFractal_SetFractalValue_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_SetGenerateRectilinearGrids_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Generate either rectilinear grids either uniform grids.
	/// Default is false.
	/// </summary>
	public virtual void SetGenerateRectilinearGrids(int _arg)
	{
		vtkTemporalFractal_SetGenerateRectilinearGrids_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_SetGhostLevels_31(HandleRef pThis, int _arg);

	/// <summary>
	/// For testing ghost levels.
	/// </summary>
	public virtual void SetGhostLevels(int _arg)
	{
		vtkTemporalFractal_SetGhostLevels_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_SetMaximumLevel_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Any blocks touching a predefined line will be subdivided to this level.
	/// Other blocks are subdivided so that neighboring blocks only differ
	/// by one level.
	/// </summary>
	public virtual void SetMaximumLevel(int _arg)
	{
		vtkTemporalFractal_SetMaximumLevel_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_SetTwoDimensional_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Make a 2D data set to test.
	/// </summary>
	public virtual void SetTwoDimensional(int _arg)
	{
		vtkTemporalFractal_SetTwoDimensional_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_TwoDimensionalOff_34(HandleRef pThis);

	/// <summary>
	/// Make a 2D data set to test.
	/// </summary>
	public virtual void TwoDimensionalOff()
	{
		vtkTemporalFractal_TwoDimensionalOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalFractal_TwoDimensionalOn_35(HandleRef pThis);

	/// <summary>
	/// Make a 2D data set to test.
	/// </summary>
	public virtual void TwoDimensionalOn()
	{
		vtkTemporalFractal_TwoDimensionalOn_35(GetCppThis());
	}
}
