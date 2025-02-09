using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInterpolatedVelocityField
/// </summary>
/// <remarks>
///    A concrete class for obtaining
///  the interpolated velocity values at a point.
///
///
/// vtkInterpolatedVelocityField acts as a continuous velocity field via
/// cell interpolation on a vtkDataSet, NumberOfIndependentVariables = 4
/// (x,y,z,t) and NumberOfFunctions = 3 (u,v,w). As a concrete sub-class
/// of vtkCompositeInterpolatedVelocityField, this class adopts two levels
/// of cell caching for faster though less robust cell location than its
/// sibling class vtkCellLocatorInterpolatedVelocityField. Level #0 begins
/// with intra-cell caching. Specifically, if the previous cell is valid
/// and the next point is still within it, ( vtkCell::EvaluatePosition()
/// returns 1, coupled with the new parametric coordinates and weights ),
/// the function values are interpolated and vtkCell::EvaluatePosition()
/// is invoked only. If it fails, level #1 follows by inter-cell location
/// of the target cell (that contains the next point). By inter-cell, the
/// previous cell gives an important clue / guess or serves as an immediate
/// neighbor to aid in the location of the target cell (as is typically the
/// case with integrating a streamline across cells) by means of vtkDataSet::
/// FindCell(). If this still fails, a global cell search is invoked via
/// vtkDataSet::FindCell().
///
/// Regardless of inter-cell or global search, a point locator is employed as
/// a crucial tool underlying the interpolation process. The use of a point
/// locator, while faster than a cell locator, is not optimal and may cause
/// vtkInterpolatedVelocityField to return incorrect results (i.e., premature
/// streamline termination) for datasets defined on complex grids (especially
/// those this discontinuous/incompatible cells). In these cases, try
/// vtkCellLocatorInterpolatedVelocityField which produces the best results at
/// the cost of speed.
///
/// @warning
/// vtkInterpolatedVelocityField is not thread safe. A new instance should be
/// created by each thread.
///
/// </remarks>
/// <seealso>
///
///  vtkCompositeInterpolatedVelocityField vtkCellLocatorInterpolatedVelocityField
///  vtkGenericInterpolatedVelocityField vtkCachingInterpolatedVelocityField
///  vtkTemporalInterpolatedVelocityField vtkFunctionSet vtkStreamTracer
/// </seealso>
public class vtkInterpolatedVelocityField : vtkCompositeInterpolatedVelocityField
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInterpolatedVelocityField";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInterpolatedVelocityField()
	{
		MRClassNameKey = "class vtkInterpolatedVelocityField";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInterpolatedVelocityField"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vtkCompositeInterpolatedVelocityField subclass.
	/// </summary>
	public new static vtkInterpolatedVelocityField New()
	{
		vtkInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a vtkCompositeInterpolatedVelocityField subclass.
	/// </summary>
	public vtkInterpolatedVelocityField()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInterpolatedVelocityField_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInterpolatedVelocityField_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInterpolatedVelocityField_IsA_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInterpolatedVelocityField_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInterpolatedVelocityField_IsTypeOf_04(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInterpolatedVelocityField_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInterpolatedVelocityField_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkInterpolatedVelocityField NewInstance()
	{
		vtkInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInterpolatedVelocityField_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInterpolatedVelocityField_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
	{
		vtkInterpolatedVelocityField vtkInterpolatedVelocityField2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInterpolatedVelocityField_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInterpolatedVelocityField2 = (vtkInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInterpolatedVelocityField2.Register(null);
			}
		}
		return vtkInterpolatedVelocityField2;
	}
}
