using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSpherePuzzleArrows
/// </summary>
/// <remarks>
///    Visualize permutation of the sphere puzzle.
///
/// vtkSpherePuzzleArrows creates
/// </remarks>
public class vtkSpherePuzzleArrows : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSpherePuzzleArrows";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSpherePuzzleArrows()
	{
		MRClassNameKey = "class vtkSpherePuzzleArrows";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpherePuzzleArrows"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSpherePuzzleArrows(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpherePuzzleArrows_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSpherePuzzleArrows New()
	{
		vtkSpherePuzzleArrows result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpherePuzzleArrows_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpherePuzzleArrows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSpherePuzzleArrows()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSpherePuzzleArrows_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpherePuzzleArrows_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSpherePuzzleArrows_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpherePuzzleArrows_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSpherePuzzleArrows_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpherePuzzleArrows_GetPermutation_03(HandleRef pThis);

	/// <summary>
	/// Permutation is an array of puzzle piece ids.
	/// Arrows will be generated for any id that does not contain itself.
	/// Permutation[3] = 3 will produce no arrow.
	/// Permutation[3] = 10 will draw an arrow from location 3 to 10.
	/// </summary>
	public virtual int[] GetPermutation()
	{
		IntPtr intPtr = vtkSpherePuzzleArrows_GetPermutation_03(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpherePuzzleArrows_GetPermutation_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Permutation is an array of puzzle piece ids.
	/// Arrows will be generated for any id that does not contain itself.
	/// Permutation[3] = 3 will produce no arrow.
	/// Permutation[3] = 10 will draw an arrow from location 3 to 10.
	/// </summary>
	public virtual void GetPermutation(IntPtr data)
	{
		vtkSpherePuzzleArrows_GetPermutation_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpherePuzzleArrows_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSpherePuzzleArrows_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpherePuzzleArrows_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSpherePuzzleArrows_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpherePuzzleArrows_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSpherePuzzleArrows NewInstance()
	{
		vtkSpherePuzzleArrows result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpherePuzzleArrows_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpherePuzzleArrows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpherePuzzleArrows_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSpherePuzzleArrows SafeDownCast(vtkObjectBase o)
	{
		vtkSpherePuzzleArrows vtkSpherePuzzleArrows2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpherePuzzleArrows_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSpherePuzzleArrows2 = (vtkSpherePuzzleArrows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSpherePuzzleArrows2.Register(null);
			}
		}
		return vtkSpherePuzzleArrows2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpherePuzzleArrows_SetPermutation_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Permutation is an array of puzzle piece ids.
	/// Arrows will be generated for any id that does not contain itself.
	/// Permutation[3] = 3 will produce no arrow.
	/// Permutation[3] = 10 will draw an arrow from location 3 to 10.
	/// </summary>
	public virtual void SetPermutation(IntPtr data)
	{
		vtkSpherePuzzleArrows_SetPermutation_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpherePuzzleArrows_SetPermutation_11(HandleRef pThis, HandleRef puz);

	/// <summary>
	/// Permutation is an array of puzzle piece ids.
	/// Arrows will be generated for any id that does not contain itself.
	/// Permutation[3] = 3 will produce no arrow.
	/// Permutation[3] = 10 will draw an arrow from location 3 to 10.
	/// </summary>
	public void SetPermutation(vtkSpherePuzzle puz)
	{
		vtkSpherePuzzleArrows_SetPermutation_11(GetCppThis(), puz?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpherePuzzleArrows_SetPermutationComponent_12(HandleRef pThis, int comp, int val);

	/// <summary>
	/// Permutation is an array of puzzle piece ids.
	/// Arrows will be generated for any id that does not contain itself.
	/// Permutation[3] = 3 will produce no arrow.
	/// Permutation[3] = 10 will draw an arrow from location 3 to 10.
	/// </summary>
	public void SetPermutationComponent(int comp, int val)
	{
		vtkSpherePuzzleArrows_SetPermutationComponent_12(GetCppThis(), comp, val);
	}
}
