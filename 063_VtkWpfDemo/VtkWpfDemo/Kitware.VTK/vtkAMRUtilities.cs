using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAMRUtilities
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
public class vtkAMRUtilities : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAMRUtilities";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAMRUtilities()
	{
		MRClassNameKey = "class vtkAMRUtilities";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRUtilities"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAMRUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRUtilities_BlankCells_01(HandleRef amr);

	/// <summary>
	/// Blank cells in overlapping AMR
	/// </summary>
	public static void BlankCells(vtkOverlappingAMR amr)
	{
		vtkAMRUtilities_BlankCells_01(amr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRUtilities_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAMRUtilities_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRUtilities_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAMRUtilities_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRUtilities_HasPartiallyOverlappingGhostCells_04(HandleRef amr);

	/// <summary>
	/// A quick test of whether partially overlapping ghost cells exist. This test
	/// starts from the highest-res boxes and checks if they have partially
	/// overlapping cells. The code returns with true once partially overlapping
	/// cells are detected. Otherwise, false is returned.
	/// </summary>
	public static bool HasPartiallyOverlappingGhostCells(vtkOverlappingAMR amr)
	{
		return (vtkAMRUtilities_HasPartiallyOverlappingGhostCells_04(amr?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRUtilities_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAMRUtilities_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRUtilities_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAMRUtilities_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRUtilities_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAMRUtilities NewInstance()
	{
		vtkAMRUtilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRUtilities_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRUtilities_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRUtilities SafeDownCast(vtkObjectBase o)
	{
		vtkAMRUtilities vtkAMRUtilities2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRUtilities_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMRUtilities2 = (vtkAMRUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMRUtilities2.Register(null);
			}
		}
		return vtkAMRUtilities2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRUtilities_StripGhostLayers_09(HandleRef ghostedAMRData, HandleRef strippedAMRData);

	/// <summary>
	/// This method detects and strips partially overlapping cells from a
	/// given AMR dataset. If ghost layers are detected, they are removed and
	/// new grid instances are created to represent the stripped
	/// data-set otherwise, each block is shallow-copied.
	///
	/// .SECTION Assumptions
	/// 1) The ghosted AMR data must have complete metadata information.
	/// </summary>
	public static void StripGhostLayers(vtkOverlappingAMR ghostedAMRData, vtkOverlappingAMR strippedAMRData)
	{
		vtkAMRUtilities_StripGhostLayers_09(ghostedAMRData?.GetCppThis() ?? default(HandleRef), strippedAMRData?.GetCppThis() ?? default(HandleRef));
	}
}
