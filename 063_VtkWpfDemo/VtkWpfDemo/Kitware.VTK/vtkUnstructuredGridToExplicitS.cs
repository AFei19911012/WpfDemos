using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridToExplicitStructuredGrid
/// </summary>
/// <remarks>
///    Filter which converts an unstructured grid data into an explicit structured grid.
///          The input grid must have a structured coordinates int cell array.
///          Moreover, its cell must be listed in the i-j-k order (k varying more ofter)
/// </remarks>
public class vtkUnstructuredGridToExplicitStructuredGrid : vtkExplicitStructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridToExplicitStructuredGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridToExplicitStructuredGrid()
	{
		MRClassNameKey = "class vtkUnstructuredGridToExplicitStructuredGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridToExplicitStructuredGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridToExplicitStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridToExplicitStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridToExplicitStructuredGrid New()
	{
		vtkUnstructuredGridToExplicitStructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridToExplicitStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridToExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUnstructuredGridToExplicitStructuredGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnstructuredGridToExplicitStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridToExplicitStructuredGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridToExplicitStructuredGrid_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridToExplicitStructuredGrid_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridToExplicitStructuredGrid_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the whole extents for the grid to produce. The size of the grid
	/// must match the number of cells in the input.
	/// </summary>
	public virtual int[] GetWholeExtent()
	{
		IntPtr intPtr = vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_03(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Get/Set the whole extents for the grid to produce. The size of the grid
	/// must match the number of cells in the input.
	/// </summary>
	public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the whole extents for the grid to produce. The size of the grid
	/// must match the number of cells in the input.
	/// </summary>
	public virtual void GetWholeExtent(IntPtr _arg)
	{
		vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridToExplicitStructuredGrid_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridToExplicitStructuredGrid_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridToExplicitStructuredGrid_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridToExplicitStructuredGrid_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridToExplicitStructuredGrid_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridToExplicitStructuredGrid NewInstance()
	{
		vtkUnstructuredGridToExplicitStructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridToExplicitStructuredGrid_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridToExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridToExplicitStructuredGrid_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridToExplicitStructuredGrid SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridToExplicitStructuredGrid vtkUnstructuredGridToExplicitStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridToExplicitStructuredGrid_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridToExplicitStructuredGrid2 = (vtkUnstructuredGridToExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridToExplicitStructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGridToExplicitStructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridToExplicitStructuredGrid_SetWholeExtent_11(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Get/Set the whole extents for the grid to produce. The size of the grid
	/// must match the number of cells in the input.
	/// </summary>
	public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkUnstructuredGridToExplicitStructuredGrid_SetWholeExtent_11(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridToExplicitStructuredGrid_SetWholeExtent_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the whole extents for the grid to produce. The size of the grid
	/// must match the number of cells in the input.
	/// </summary>
	public virtual void SetWholeExtent(IntPtr _arg)
	{
		vtkUnstructuredGridToExplicitStructuredGrid_SetWholeExtent_12(GetCppThis(), _arg);
	}
}
