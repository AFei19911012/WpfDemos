using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///
/// Copyright (c) 2000 - 2009, Lawrence Livermore National Security, LLC
/// Produced at the Lawrence Livermore National Laboratory
/// LLNL-CODE-400124
/// All rights reserved.
///
/// This file was adapted from the VisIt clipper (vtkVisItClipper). For  details,
/// see https://visit.llnl.gov/.  The full copyright notice is contained in the
/// file COPYRIGHT located at the root of the VisIt distribution or at
/// http://www.llnl.gov/visit/copyright.html.
///
/// </summary>
public class vtkTableBasedClipDataSet : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTableBasedClipDataSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTableBasedClipDataSet()
	{
		MRClassNameKey = "class vtkTableBasedClipDataSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableBasedClipDataSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTableBasedClipDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableBasedClipDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an instance with a user-specified implicit function, turning off
	/// IVARs InsideOut and GenerateClipScalars and setting IVAR Value to 0.0.
	/// </summary>
	public new static vtkTableBasedClipDataSet New()
	{
		vtkTableBasedClipDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableBasedClipDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTableBasedClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create an instance with a user-specified implicit function, turning off
	/// IVARs InsideOut and GenerateClipScalars and setting IVAR Value to 0.0.
	/// </summary>
	public vtkTableBasedClipDataSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTableBasedClipDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_GenerateClipScalarsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get flag GenerateClipScalars, with 0 as the default value. With this
	/// flag on, the scalar point data values obtained by evaluating the implicit
	/// function will be exported to the output. Note that this flag requiries that
	/// an implicit function be provided.
	/// </summary>
	public virtual void GenerateClipScalarsOff()
	{
		vtkTableBasedClipDataSet_GenerateClipScalarsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_GenerateClipScalarsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get flag GenerateClipScalars, with 0 as the default value. With this
	/// flag on, the scalar point data values obtained by evaluating the implicit
	/// function will be exported to the output. Note that this flag requiries that
	/// an implicit function be provided.
	/// </summary>
	public virtual void GenerateClipScalarsOn()
	{
		vtkTableBasedClipDataSet_GenerateClipScalarsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_GenerateClippedOutputOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get whether a second output is generated. The second output contains the
	/// polygonal data that is clipped away by the iso-surface.
	/// </summary>
	public virtual void GenerateClippedOutputOff()
	{
		vtkTableBasedClipDataSet_GenerateClippedOutputOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_GenerateClippedOutputOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get whether a second output is generated. The second output contains the
	/// polygonal data that is clipped away by the iso-surface.
	/// </summary>
	public virtual void GenerateClippedOutputOn()
	{
		vtkTableBasedClipDataSet_GenerateClippedOutputOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkTableBasedClipDataSet_GetBatchSize_05(HandleRef pThis);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	///
	/// Default is 1000.
	/// </summary>
	public virtual uint GetBatchSize()
	{
		return vtkTableBasedClipDataSet_GetBatchSize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkTableBasedClipDataSet_GetBatchSizeMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	///
	/// Default is 1000.
	/// </summary>
	public virtual uint GetBatchSizeMaxValue()
	{
		return vtkTableBasedClipDataSet_GetBatchSizeMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkTableBasedClipDataSet_GetBatchSizeMinValue_07(HandleRef pThis);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	///
	/// Default is 1000.
	/// </summary>
	public virtual uint GetBatchSizeMinValue()
	{
		return vtkTableBasedClipDataSet_GetBatchSizeMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableBasedClipDataSet_GetClipFunction_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the implicit function with which to perform the clipping operation.
	/// Unless an implicit function is defined, the specified input scalar data will
	/// be used for clipping.
	/// </summary>
	public virtual vtkImplicitFunction GetClipFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableBasedClipDataSet_GetClipFunction_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunction2 = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunction2.Register(null);
			}
		}
		return vtkImplicitFunction2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableBasedClipDataSet_GetClippedOutput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the clipped output.
	/// </summary>
	public vtkUnstructuredGrid GetClippedOutput()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableBasedClipDataSet_GetClippedOutput_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableBasedClipDataSet_GetGenerateClipScalars_10(HandleRef pThis);

	/// <summary>
	/// Set/Get flag GenerateClipScalars, with 0 as the default value. With this
	/// flag on, the scalar point data values obtained by evaluating the implicit
	/// function will be exported to the output. Note that this flag requiries that
	/// an implicit function be provided.
	/// </summary>
	public virtual int GetGenerateClipScalars()
	{
		return vtkTableBasedClipDataSet_GetGenerateClipScalars_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableBasedClipDataSet_GetGenerateClippedOutput_11(HandleRef pThis);

	/// <summary>
	/// Set/Get whether a second output is generated. The second output contains the
	/// polygonal data that is clipped away by the iso-surface.
	/// </summary>
	public virtual int GetGenerateClippedOutput()
	{
		return vtkTableBasedClipDataSet_GetGenerateClippedOutput_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableBasedClipDataSet_GetInsideOut_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. With this flag off, a vertex is considered
	/// inside (the implicit function or the isosurface) if the (function or scalar)
	/// value is greater than IVAR Value. With this flag on, a vertex is considered
	/// inside (the implicit function or the isosurface) if the (function or scalar)
	/// value is less than or equal to IVAR Value. This flag is off by default.
	/// </summary>
	public virtual int GetInsideOut()
	{
		return vtkTableBasedClipDataSet_GetInsideOut_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTableBasedClipDataSet_GetMTime_13(HandleRef pThis);

	/// <summary>
	/// Get the MTime for which the clip function are considered.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkTableBasedClipDataSet_GetMTime_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTableBasedClipDataSet_GetMergeTolerance_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the tolerance used for merging duplicate points near the clipping
	/// intersection cells. This tolerance may prevent the generation of degenerate
	/// primitives. Note that only 3D cells actually use this IVAR when vtkClipDataSet
	/// is invoked as last resort.
	/// </summary>
	public virtual double GetMergeTolerance()
	{
		return vtkTableBasedClipDataSet_GetMergeTolerance_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTableBasedClipDataSet_GetMergeToleranceMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the tolerance used for merging duplicate points near the clipping
	/// intersection cells. This tolerance may prevent the generation of degenerate
	/// primitives. Note that only 3D cells actually use this IVAR when vtkClipDataSet
	/// is invoked as last resort.
	/// </summary>
	public virtual double GetMergeToleranceMaxValue()
	{
		return vtkTableBasedClipDataSet_GetMergeToleranceMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTableBasedClipDataSet_GetMergeToleranceMinValue_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the tolerance used for merging duplicate points near the clipping
	/// intersection cells. This tolerance may prevent the generation of degenerate
	/// primitives. Note that only 3D cells actually use this IVAR when vtkClipDataSet
	/// is invoked as last resort.
	/// </summary>
	public virtual double GetMergeToleranceMinValue()
	{
		return vtkTableBasedClipDataSet_GetMergeToleranceMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTableBasedClipDataSet_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTableBasedClipDataSet_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTableBasedClipDataSet_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTableBasedClipDataSet_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableBasedClipDataSet_GetOutputPointsPrecision_19(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkTableBasedClipDataSet_GetOutputPointsPrecision_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableBasedClipDataSet_GetOutputPointsPrecisionMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMaxValue()
	{
		return vtkTableBasedClipDataSet_GetOutputPointsPrecisionMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableBasedClipDataSet_GetOutputPointsPrecisionMinValue_21(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMinValue()
	{
		return vtkTableBasedClipDataSet_GetOutputPointsPrecisionMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTableBasedClipDataSet_GetUseValueAsOffset_22(HandleRef pThis);

	/// <summary>
	/// Set/Get flag UseValueAsOffset, with true as the default value. With this flag
	/// on, IVAR Value is used as an offset parameter to the implicit function. Value
	/// is used only when clipping using a scalar array.
	/// </summary>
	public virtual bool GetUseValueAsOffset()
	{
		return (vtkTableBasedClipDataSet_GetUseValueAsOffset_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTableBasedClipDataSet_GetValue_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the clipping value of the implicit function (if an implicit function
	/// is applied) or scalar data array (if a scalar data array is used), with 0.0
	/// as the default value. This value is ignored if flag UseValueAsOffset is true
	/// AND a clip function is defined.
	/// </summary>
	public virtual double GetValue()
	{
		return vtkTableBasedClipDataSet_GetValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_InsideOutOff_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. With this flag off, a vertex is considered
	/// inside (the implicit function or the isosurface) if the (function or scalar)
	/// value is greater than IVAR Value. With this flag on, a vertex is considered
	/// inside (the implicit function or the isosurface) if the (function or scalar)
	/// value is less than or equal to IVAR Value. This flag is off by default.
	/// </summary>
	public virtual void InsideOutOff()
	{
		vtkTableBasedClipDataSet_InsideOutOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_InsideOutOn_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. With this flag off, a vertex is considered
	/// inside (the implicit function or the isosurface) if the (function or scalar)
	/// value is greater than IVAR Value. With this flag on, a vertex is considered
	/// inside (the implicit function or the isosurface) if the (function or scalar)
	/// value is less than or equal to IVAR Value. This flag is off by default.
	/// </summary>
	public virtual void InsideOutOn()
	{
		vtkTableBasedClipDataSet_InsideOutOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableBasedClipDataSet_IsA_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTableBasedClipDataSet_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableBasedClipDataSet_IsTypeOf_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTableBasedClipDataSet_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableBasedClipDataSet_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTableBasedClipDataSet NewInstance()
	{
		vtkTableBasedClipDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableBasedClipDataSet_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTableBasedClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableBasedClipDataSet_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTableBasedClipDataSet SafeDownCast(vtkObjectBase o)
	{
		vtkTableBasedClipDataSet vtkTableBasedClipDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableBasedClipDataSet_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTableBasedClipDataSet2 = (vtkTableBasedClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTableBasedClipDataSet2.Register(null);
			}
		}
		return vtkTableBasedClipDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_SetBatchSize_31(HandleRef pThis, uint _arg);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	///
	/// Default is 1000.
	/// </summary>
	public virtual void SetBatchSize(uint _arg)
	{
		vtkTableBasedClipDataSet_SetBatchSize_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_SetClipFunction_32(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the implicit function with which to perform the clipping operation.
	/// Unless an implicit function is defined, the specified input scalar data will
	/// be used for clipping.
	/// </summary>
	public virtual void SetClipFunction(vtkImplicitFunction arg0)
	{
		vtkTableBasedClipDataSet_SetClipFunction_32(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_SetGenerateClipScalars_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get flag GenerateClipScalars, with 0 as the default value. With this
	/// flag on, the scalar point data values obtained by evaluating the implicit
	/// function will be exported to the output. Note that this flag requiries that
	/// an implicit function be provided.
	/// </summary>
	public virtual void SetGenerateClipScalars(int _arg)
	{
		vtkTableBasedClipDataSet_SetGenerateClipScalars_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_SetGenerateClippedOutput_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether a second output is generated. The second output contains the
	/// polygonal data that is clipped away by the iso-surface.
	/// </summary>
	public virtual void SetGenerateClippedOutput(int _arg)
	{
		vtkTableBasedClipDataSet_SetGenerateClippedOutput_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_SetInsideOut_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the InsideOut flag. With this flag off, a vertex is considered
	/// inside (the implicit function or the isosurface) if the (function or scalar)
	/// value is greater than IVAR Value. With this flag on, a vertex is considered
	/// inside (the implicit function or the isosurface) if the (function or scalar)
	/// value is less than or equal to IVAR Value. This flag is off by default.
	/// </summary>
	public virtual void SetInsideOut(int _arg)
	{
		vtkTableBasedClipDataSet_SetInsideOut_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_SetMergeTolerance_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the tolerance used for merging duplicate points near the clipping
	/// intersection cells. This tolerance may prevent the generation of degenerate
	/// primitives. Note that only 3D cells actually use this IVAR when vtkClipDataSet
	/// is invoked as last resort.
	/// </summary>
	public virtual void SetMergeTolerance(double _arg)
	{
		vtkTableBasedClipDataSet_SetMergeTolerance_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_SetOutputPointsPrecision_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkTableBasedClipDataSet_SetOutputPointsPrecision_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_SetUseValueAsOffset_38(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get flag UseValueAsOffset, with true as the default value. With this flag
	/// on, IVAR Value is used as an offset parameter to the implicit function. Value
	/// is used only when clipping using a scalar array.
	/// </summary>
	public virtual void SetUseValueAsOffset(bool _arg)
	{
		vtkTableBasedClipDataSet_SetUseValueAsOffset_38(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_SetValue_39(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the clipping value of the implicit function (if an implicit function
	/// is applied) or scalar data array (if a scalar data array is used), with 0.0
	/// as the default value. This value is ignored if flag UseValueAsOffset is true
	/// AND a clip function is defined.
	/// </summary>
	public virtual void SetValue(double _arg)
	{
		vtkTableBasedClipDataSet_SetValue_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_UseValueAsOffsetOff_40(HandleRef pThis);

	/// <summary>
	/// Set/Get flag UseValueAsOffset, with true as the default value. With this flag
	/// on, IVAR Value is used as an offset parameter to the implicit function. Value
	/// is used only when clipping using a scalar array.
	/// </summary>
	public virtual void UseValueAsOffsetOff()
	{
		vtkTableBasedClipDataSet_UseValueAsOffsetOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableBasedClipDataSet_UseValueAsOffsetOn_41(HandleRef pThis);

	/// <summary>
	/// Set/Get flag UseValueAsOffset, with true as the default value. With this flag
	/// on, IVAR Value is used as an offset parameter to the implicit function. Value
	/// is used only when clipping using a scalar array.
	/// </summary>
	public virtual void UseValueAsOffsetOn()
	{
		vtkTableBasedClipDataSet_UseValueAsOffsetOn_41(GetCppThis());
	}
}
