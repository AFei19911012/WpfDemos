using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRectilinearGridToTetrahedra
/// </summary>
/// <remarks>
///    create a Tetrahedral mesh from a RectilinearGrid
///
/// vtkRectilinearGridToTetrahedra forms a mesh of Tetrahedra from a
/// vtkRectilinearGrid.  The tetrahedra can be 5 per cell, 6 per cell,
/// or a mixture of 5 or 12 per cell. The resulting mesh is consistent,
/// meaning that there are no edge crossings and that each tetrahedron
/// face is shared by two tetrahedra, except those tetrahedra on the
/// boundary. All tetrahedra are right handed.
///
/// Note that 12 tetrahedra per cell means adding a point in the
/// center of the cell.
///
/// In order to subdivide some cells into 5 and some cells into 12 tetrahedra:
/// SetTetraPerCellTo5And12();
/// Set the Scalars of the Input RectilinearGrid to be 5 or 12
/// depending on what you want per cell of the RectilinearGrid.
///
/// If you set RememberVoxelId, the scalars of the tetrahedron
/// will be set to the Id of the Cell in the RectilinearGrid from which
/// the tetrahedron came.
///
/// @par Thanks:
///    This class was developed by Samson J. Timoner of the
///    MIT Artificial Intelligence Laboratory
///
/// </remarks>
/// <seealso>
///
///    vtkDelaunay3D
/// </seealso>
public class vtkRectilinearGridToTetrahedra : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridToTetrahedra";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRectilinearGridToTetrahedra()
	{
		MRClassNameKey = "class vtkRectilinearGridToTetrahedra";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridToTetrahedra"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRectilinearGridToTetrahedra(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridToTetrahedra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Form 5 Tetrahedra per cube. Do not RememberVoxelId.
	/// </summary>
	public new static vtkRectilinearGridToTetrahedra New()
	{
		vtkRectilinearGridToTetrahedra result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridToTetrahedra_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGridToTetrahedra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Form 5 Tetrahedra per cube. Do not RememberVoxelId.
	/// </summary>
	public vtkRectilinearGridToTetrahedra()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRectilinearGridToTetrahedra_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkRectilinearGridToTetrahedra_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRectilinearGridToTetrahedra_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGridToTetrahedra_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRectilinearGridToTetrahedra_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridToTetrahedra_GetRememberVoxelId_03(HandleRef pThis);

	/// <summary>
	/// Should the tetrahedra have scalar data
	/// indicating which Voxel they came from in the vtkRectilinearGrid?
	/// </summary>
	public virtual int GetRememberVoxelId()
	{
		return vtkRectilinearGridToTetrahedra_GetRememberVoxelId_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridToTetrahedra_GetTetraPerCell_04(HandleRef pThis);

	/// <summary>
	/// Set the method to divide each cell (voxel) in the RectilinearGrid
	/// into tetrahedra.
	/// </summary>
	public virtual int GetTetraPerCell()
	{
		return vtkRectilinearGridToTetrahedra_GetTetraPerCell_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridToTetrahedra_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRectilinearGridToTetrahedra_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridToTetrahedra_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRectilinearGridToTetrahedra_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridToTetrahedra_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRectilinearGridToTetrahedra NewInstance()
	{
		vtkRectilinearGridToTetrahedra result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridToTetrahedra_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGridToTetrahedra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridToTetrahedra_RememberVoxelIdOff_09(HandleRef pThis);

	/// <summary>
	/// Should the tetrahedra have scalar data
	/// indicating which Voxel they came from in the vtkRectilinearGrid?
	/// </summary>
	public virtual void RememberVoxelIdOff()
	{
		vtkRectilinearGridToTetrahedra_RememberVoxelIdOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridToTetrahedra_RememberVoxelIdOn_10(HandleRef pThis);

	/// <summary>
	/// Should the tetrahedra have scalar data
	/// indicating which Voxel they came from in the vtkRectilinearGrid?
	/// </summary>
	public virtual void RememberVoxelIdOn()
	{
		vtkRectilinearGridToTetrahedra_RememberVoxelIdOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridToTetrahedra_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearGridToTetrahedra SafeDownCast(vtkObjectBase o)
	{
		vtkRectilinearGridToTetrahedra vtkRectilinearGridToTetrahedra2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridToTetrahedra_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGridToTetrahedra2 = (vtkRectilinearGridToTetrahedra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGridToTetrahedra2.Register(null);
			}
		}
		return vtkRectilinearGridToTetrahedra2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridToTetrahedra_SetInput_12(HandleRef pThis, IntPtr Extent, IntPtr Spacing, double tol);

	/// <summary>
	/// This function for convenience for creating a Rectilinear Grid
	/// If Spacing does not fit evenly into extent, the last cell will
	/// have a different width (or height or depth).
	/// If Extent[i]/Spacing[i] is within tol of an integer, then
	/// assume the programmer meant an integer for direction i.
	/// </summary>
	public void SetInput(IntPtr Extent, IntPtr Spacing, double tol)
	{
		vtkRectilinearGridToTetrahedra_SetInput_12(GetCppThis(), Extent, Spacing, tol);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridToTetrahedra_SetInput_13(HandleRef pThis, double ExtentX, double ExtentY, double ExtentZ, double SpacingX, double SpacingY, double SpacingZ, double tol);

	/// <summary>
	/// This version of the function for the wrappers
	/// </summary>
	public void SetInput(double ExtentX, double ExtentY, double ExtentZ, double SpacingX, double SpacingY, double SpacingZ, double tol)
	{
		vtkRectilinearGridToTetrahedra_SetInput_13(GetCppThis(), ExtentX, ExtentY, ExtentZ, SpacingX, SpacingY, SpacingZ, tol);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridToTetrahedra_SetRememberVoxelId_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Should the tetrahedra have scalar data
	/// indicating which Voxel they came from in the vtkRectilinearGrid?
	/// </summary>
	public virtual void SetRememberVoxelId(int _arg)
	{
		vtkRectilinearGridToTetrahedra_SetRememberVoxelId_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCell_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the method to divide each cell (voxel) in the RectilinearGrid
	/// into tetrahedra.
	/// </summary>
	public virtual void SetTetraPerCell(int _arg)
	{
		vtkRectilinearGridToTetrahedra_SetTetraPerCell_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo12_16(HandleRef pThis);

	/// <summary>
	/// Set the method to divide each cell (voxel) in the RectilinearGrid
	/// into tetrahedra.
	/// </summary>
	public void SetTetraPerCellTo12()
	{
		vtkRectilinearGridToTetrahedra_SetTetraPerCellTo12_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5_17(HandleRef pThis);

	/// <summary>
	/// Set the method to divide each cell (voxel) in the RectilinearGrid
	/// into tetrahedra.
	/// </summary>
	public void SetTetraPerCellTo5()
	{
		vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5And12_18(HandleRef pThis);

	/// <summary>
	/// Set the method to divide each cell (voxel) in the RectilinearGrid
	/// into tetrahedra.
	/// </summary>
	public void SetTetraPerCellTo5And12()
	{
		vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5And12_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo6_19(HandleRef pThis);

	/// <summary>
	/// Set the method to divide each cell (voxel) in the RectilinearGrid
	/// into tetrahedra.
	/// </summary>
	public void SetTetraPerCellTo6()
	{
		vtkRectilinearGridToTetrahedra_SetTetraPerCellTo6_19(GetCppThis());
	}
}
