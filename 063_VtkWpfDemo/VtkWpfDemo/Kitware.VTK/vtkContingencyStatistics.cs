using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContingencyStatistics
/// </summary>
/// <remarks>
///    A class for bivariate correlation contigency
/// tables, conditional probabilities, and information entropy
///
///
/// Given a pair of columns of interest, this class provides the
/// following functionalities, depending on the operation in which it is executed:
/// * Learn: calculate contigency tables and corresponding discrete joint
///   probability distribution.
/// * Derive: calculate conditional probabilities, information entropies, and
///   pointwise mutual information.
/// * Assess: given two columns of interest with the same number of entries as
///   input in port INPUT_DATA, and a corresponding bivariate probability distribution,
/// * Test: calculate Chi-square independence statistic and, if VTK to R interface is available,
///   retrieve corresponding p-value for independence testing.
///
/// @par Thanks:
/// Thanks to Philippe Pebay and David Thompson from Sandia National Laboratories
/// for implementing this class.
/// Updated by Philippe Pebay, Kitware SAS 2012
/// </remarks>
public class vtkContingencyStatistics : vtkStatisticsAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContingencyStatistics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContingencyStatistics()
	{
		MRClassNameKey = "class vtkContingencyStatistics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContingencyStatistics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContingencyStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContingencyStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContingencyStatistics New()
	{
		vtkContingencyStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContingencyStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContingencyStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkContingencyStatistics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContingencyStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContingencyStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Given a collection of models, calculate aggregate model
	/// NB: not implemented
	/// </summary>
	public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
	{
		vtkContingencyStatistics_Aggregate_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContingencyStatistics_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContingencyStatistics_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContingencyStatistics_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContingencyStatistics_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContingencyStatistics_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContingencyStatistics_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContingencyStatistics_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContingencyStatistics_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContingencyStatistics_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkContingencyStatistics NewInstance()
	{
		vtkContingencyStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContingencyStatistics_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContingencyStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContingencyStatistics_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContingencyStatistics SafeDownCast(vtkObjectBase o)
	{
		vtkContingencyStatistics vtkContingencyStatistics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContingencyStatistics_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContingencyStatistics2 = (vtkContingencyStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContingencyStatistics2.Register(null);
			}
		}
		return vtkContingencyStatistics2;
	}
}
