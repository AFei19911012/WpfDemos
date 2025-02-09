using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractPolyDataGeometry
/// </summary>
/// <remarks>
///    extract vtkPolyData cells that lies either entirely inside or outside of a specified
/// implicit function
///
///
/// vtkExtractPolyDataGeometry extracts from its input vtkPolyData all cells
/// that are either completely inside or outside of a specified implicit
/// function. This filter is specialized to vtkPolyData. On output the
/// filter generates vtkPolyData.
///
/// To use this filter you must specify an implicit function. You must also
/// specify whether to extract cells laying inside or outside of the implicit
/// function. (The inside of an implicit function is the negative values
/// region.) An option exists to extract cells that are neither inside nor
/// outside (i.e., boundary).
///
/// Note that this filter also has the option to directly pass all points or cull
/// the points that do not satisfy the implicit function test. Passing all points
/// is a tad faster, but then points remain that do not pass the test and may mess
/// up subsequent glyphing operations and so on. By default points are culled.
///
/// A more general version of this filter is available for arbitrary
/// vtkDataSet input (see vtkExtractGeometry).
///
/// </remarks>
/// <seealso>
///
/// vtkExtractGeometry vtkClipPolyData vtkImplicitFunction
/// </seealso>
public class vtkExtractPolyDataGeometry : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractPolyDataGeometry";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractPolyDataGeometry()
	{
		MRClassNameKey = "class vtkExtractPolyDataGeometry";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractPolyDataGeometry"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractPolyDataGeometry(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractPolyDataGeometry_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with ExtractInside turned on.
	/// </summary>
	public new static vtkExtractPolyDataGeometry New()
	{
		vtkExtractPolyDataGeometry result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractPolyDataGeometry_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractPolyDataGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with ExtractInside turned on.
	/// </summary>
	public vtkExtractPolyDataGeometry()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractPolyDataGeometry_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExtractPolyDataGeometry_ExtractBoundaryCellsOff_01(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual void ExtractBoundaryCellsOff()
	{
		vtkExtractPolyDataGeometry_ExtractBoundaryCellsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPolyDataGeometry_ExtractBoundaryCellsOn_02(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual void ExtractBoundaryCellsOn()
	{
		vtkExtractPolyDataGeometry_ExtractBoundaryCellsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPolyDataGeometry_ExtractInsideOff_03(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are inside of implicit
	/// function (ExtractInside == 1) or outside of implicit function
	/// (ExtractInside == 0).
	/// </summary>
	public virtual void ExtractInsideOff()
	{
		vtkExtractPolyDataGeometry_ExtractInsideOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPolyDataGeometry_ExtractInsideOn_04(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are inside of implicit
	/// function (ExtractInside == 1) or outside of implicit function
	/// (ExtractInside == 0).
	/// </summary>
	public virtual void ExtractInsideOn()
	{
		vtkExtractPolyDataGeometry_ExtractInsideOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractPolyDataGeometry_GetExtractBoundaryCells_05(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual int GetExtractBoundaryCells()
	{
		return vtkExtractPolyDataGeometry_GetExtractBoundaryCells_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractPolyDataGeometry_GetExtractInside_06(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract cells that are inside of implicit
	/// function (ExtractInside == 1) or outside of implicit function
	/// (ExtractInside == 0).
	/// </summary>
	public virtual int GetExtractInside()
	{
		return vtkExtractPolyDataGeometry_GetExtractInside_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractPolyDataGeometry_GetImplicitFunction_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function for inside/outside checks.
	/// </summary>
	public virtual vtkImplicitFunction GetImplicitFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractPolyDataGeometry_GetImplicitFunction_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkExtractPolyDataGeometry_GetMTime_08(HandleRef pThis);

	/// <summary>
	/// Return the MTime taking into account changes to the implicit function
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkExtractPolyDataGeometry_GetMTime_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractPolyDataGeometry_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractPolyDataGeometry_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractPolyDataGeometry_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractPolyDataGeometry_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractPolyDataGeometry_GetPassPoints_11(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether points are culled or simply passed through
	/// to the output.
	/// </summary>
	public virtual int GetPassPoints()
	{
		return vtkExtractPolyDataGeometry_GetPassPoints_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractPolyDataGeometry_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractPolyDataGeometry_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractPolyDataGeometry_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractPolyDataGeometry_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractPolyDataGeometry_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractPolyDataGeometry NewInstance()
	{
		vtkExtractPolyDataGeometry result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractPolyDataGeometry_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractPolyDataGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPolyDataGeometry_PassPointsOff_16(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether points are culled or simply passed through
	/// to the output.
	/// </summary>
	public virtual void PassPointsOff()
	{
		vtkExtractPolyDataGeometry_PassPointsOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPolyDataGeometry_PassPointsOn_17(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether points are culled or simply passed through
	/// to the output.
	/// </summary>
	public virtual void PassPointsOn()
	{
		vtkExtractPolyDataGeometry_PassPointsOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractPolyDataGeometry_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractPolyDataGeometry SafeDownCast(vtkObjectBase o)
	{
		vtkExtractPolyDataGeometry vtkExtractPolyDataGeometry2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractPolyDataGeometry_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractPolyDataGeometry2 = (vtkExtractPolyDataGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractPolyDataGeometry2.Register(null);
			}
		}
		return vtkExtractPolyDataGeometry2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPolyDataGeometry_SetExtractBoundaryCells_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether to extract cells that are partially inside.
	/// By default, ExtractBoundaryCells is off.
	/// </summary>
	public virtual void SetExtractBoundaryCells(int _arg)
	{
		vtkExtractPolyDataGeometry_SetExtractBoundaryCells_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPolyDataGeometry_SetExtractInside_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether to extract cells that are inside of implicit
	/// function (ExtractInside == 1) or outside of implicit function
	/// (ExtractInside == 0).
	/// </summary>
	public virtual void SetExtractInside(int _arg)
	{
		vtkExtractPolyDataGeometry_SetExtractInside_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPolyDataGeometry_SetImplicitFunction_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function for inside/outside checks.
	/// </summary>
	public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
	{
		vtkExtractPolyDataGeometry_SetImplicitFunction_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPolyDataGeometry_SetPassPoints_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether points are culled or simply passed through
	/// to the output.
	/// </summary>
	public virtual void SetPassPoints(int _arg)
	{
		vtkExtractPolyDataGeometry_SetPassPoints_22(GetCppThis(), _arg);
	}
}
