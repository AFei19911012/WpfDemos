using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractGeometry
/// </summary>
/// <remarks>
///    extract cells that lie either entirely inside or outside of a specified implicit
/// function
///
///
/// vtkExtractGeometry extracts from its input dataset all cells that are either
/// completely inside or outside of a specified implicit function. Any type of
/// dataset can be input to this filter. On output the filter generates an
/// unstructured grid.
///
/// To use this filter you must specify an implicit function. You must also
/// specify whether to extract cells laying inside or outside of the implicit
/// function. (The inside of an implicit function is the negative values
/// region.) An option exists to extract cells that are neither inside or
/// outside (i.e., boundary).
///
/// A more efficient version of this filter is available for vtkPolyData input.
/// See vtkExtractPolyDataGeometry.
///
/// </remarks>
/// <seealso>
///
/// vtkExtractPolyDataGeometry vtkGeometryFilter vtkExtractVOI
/// </seealso>
public class vtkExtractGeometry : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractGeometry";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractGeometry()
	{
		MRClassNameKey = "class vtkExtractGeometry";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractGeometry"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractGeometry(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractGeometry_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with ExtractInside turned on.
	/// </summary>
	public new static vtkExtractGeometry New()
	{
		vtkExtractGeometry result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractGeometry_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with ExtractInside turned on.
	/// </summary>
	public vtkExtractGeometry()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractGeometry_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractGeometry_ExtractBoundaryCellsOff_01(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual void ExtractBoundaryCellsOff()
	{
		vtkExtractGeometry_ExtractBoundaryCellsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractGeometry_ExtractBoundaryCellsOn_02(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual void ExtractBoundaryCellsOn()
	{
		vtkExtractGeometry_ExtractBoundaryCellsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractGeometry_ExtractInsideOff_03(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are inside of implicit
	/// function (ExtractInside == 1) or outside of implicit function
	/// (ExtractInside == 0).
	/// </summary>
	public virtual void ExtractInsideOff()
	{
		vtkExtractGeometry_ExtractInsideOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractGeometry_ExtractInsideOn_04(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are inside of implicit
	/// function (ExtractInside == 1) or outside of implicit function
	/// (ExtractInside == 0).
	/// </summary>
	public virtual void ExtractInsideOn()
	{
		vtkExtractGeometry_ExtractInsideOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractGeometry_ExtractOnlyBoundaryCellsOff_05(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual void ExtractOnlyBoundaryCellsOff()
	{
		vtkExtractGeometry_ExtractOnlyBoundaryCellsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractGeometry_ExtractOnlyBoundaryCellsOn_06(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual void ExtractOnlyBoundaryCellsOn()
	{
		vtkExtractGeometry_ExtractOnlyBoundaryCellsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractGeometry_GetExtractBoundaryCells_07(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual int GetExtractBoundaryCells()
	{
		return vtkExtractGeometry_GetExtractBoundaryCells_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractGeometry_GetExtractInside_08(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are inside of implicit
	/// function (ExtractInside == 1) or outside of implicit function
	/// (ExtractInside == 0).
	/// </summary>
	public virtual int GetExtractInside()
	{
		return vtkExtractGeometry_GetExtractInside_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractGeometry_GetExtractOnlyBoundaryCells_09(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual int GetExtractOnlyBoundaryCells()
	{
		return vtkExtractGeometry_GetExtractOnlyBoundaryCells_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractGeometry_GetImplicitFunction_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function for inside/outside checks.
	/// </summary>
	public virtual vtkImplicitFunction GetImplicitFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractGeometry_GetImplicitFunction_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkExtractGeometry_GetMTime_11(HandleRef pThis);

	/// <summary>
	/// Return the MTime taking into account changes to the implicit function
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkExtractGeometry_GetMTime_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractGeometry_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractGeometry_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractGeometry_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractGeometry_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractGeometry_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractGeometry_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractGeometry_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractGeometry_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractGeometry_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractGeometry NewInstance()
	{
		vtkExtractGeometry result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractGeometry_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractGeometry_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractGeometry SafeDownCast(vtkObjectBase o)
	{
		vtkExtractGeometry vtkExtractGeometry2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractGeometry_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractGeometry2 = (vtkExtractGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractGeometry2.Register(null);
			}
		}
		return vtkExtractGeometry2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractGeometry_SetExtractBoundaryCells_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual void SetExtractBoundaryCells(int _arg)
	{
		vtkExtractGeometry_SetExtractBoundaryCells_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractGeometry_SetExtractInside_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether to extract cells that are inside of implicit
	/// function (ExtractInside == 1) or outside of implicit function
	/// (ExtractInside == 0).
	/// </summary>
	public virtual void SetExtractInside(int _arg)
	{
		vtkExtractGeometry_SetExtractInside_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractGeometry_SetExtractOnlyBoundaryCells_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual void SetExtractOnlyBoundaryCells(int _arg)
	{
		vtkExtractGeometry_SetExtractOnlyBoundaryCells_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractGeometry_SetImplicitFunction_22(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function for inside/outside checks.
	/// </summary>
	public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
	{
		vtkExtractGeometry_SetImplicitFunction_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
