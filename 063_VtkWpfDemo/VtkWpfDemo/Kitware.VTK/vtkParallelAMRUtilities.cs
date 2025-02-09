using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParallelAMRUtilities
///
///
///  A concrete instance of vtkObject that employs a singleton design
///  pattern and implements functionality for AMR specific operations.
///
/// </summary>
/// <seealso>
///
///  vtkOverlappingAMR, vtkAMRBox
/// </seealso>
public class vtkParallelAMRUtilities : vtkAMRUtilities
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParallelAMRUtilities";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParallelAMRUtilities()
	{
		MRClassNameKey = "class vtkParallelAMRUtilities";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelAMRUtilities"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParallelAMRUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelAMRUtilities_BlankCells_01(HandleRef amr, HandleRef myController);

	/// <summary>
	/// Blank cells in overlapping AMR
	/// </summary>
	public static void BlankCells(vtkOverlappingAMR amr, vtkMultiProcessController myController)
	{
		vtkParallelAMRUtilities_BlankCells_01(amr?.GetCppThis() ?? default(HandleRef), myController?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelAMRUtilities_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParallelAMRUtilities_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelAMRUtilities_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParallelAMRUtilities_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelAMRUtilities_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParallelAMRUtilities_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelAMRUtilities_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParallelAMRUtilities_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelAMRUtilities_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParallelAMRUtilities NewInstance()
	{
		vtkParallelAMRUtilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelAMRUtilities_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelAMRUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelAMRUtilities_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParallelAMRUtilities SafeDownCast(vtkObjectBase o)
	{
		vtkParallelAMRUtilities vtkParallelAMRUtilities2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelAMRUtilities_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParallelAMRUtilities2 = (vtkParallelAMRUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParallelAMRUtilities2.Register(null);
			}
		}
		return vtkParallelAMRUtilities2;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelAMRUtilities_StripGhostLayers_08(HandleRef ghostedAMRData, HandleRef strippedAMRData, HandleRef myController);

	/// <summary>
	/// This method detects and strips partially overlapping cells from a
	/// given AMR dataset. If ghost layers are detected, they are removed and
	/// new grid instances are created to represent the stripped
	/// data-set otherwise, each block is shallow-copied.
	///
	/// .SECTION Assumptions
	/// 1) The ghosted AMR data must have complete metadata information.
	/// </summary>
	public static void StripGhostLayers(vtkOverlappingAMR ghostedAMRData, vtkOverlappingAMR strippedAMRData, vtkMultiProcessController myController)
	{
		vtkParallelAMRUtilities_StripGhostLayers_08(ghostedAMRData?.GetCppThis() ?? default(HandleRef), strippedAMRData?.GetCppThis() ?? default(HandleRef), myController?.GetCppThis() ?? default(HandleRef));
	}
}
