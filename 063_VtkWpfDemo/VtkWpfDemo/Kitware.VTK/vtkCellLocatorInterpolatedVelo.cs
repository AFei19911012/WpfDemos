using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellLocatorInterpolatedVelocityField
/// </summary>
/// <remarks>
///    A concrete class for
///  obtaining the interpolated velocity values at a point.
///
///
///  vtkCellLocatorInterpolatedVelocityField acts as a continuous velocity
///  field via cell interpolation on a vtkDataSet, NumberOfIndependentVariables
///  = 4 (x,y,z,t) and NumberOfFunctions = 3 (u,v,w). As a concrete sub-class
///  of vtkCompositeInterpolatedVelocityField, it adopts vtkAbstractCellLocator's
///  sub-classes, e.g., vtkCellLocator and vtkModifiedBSPTree, without the use
///  of vtkPointLocator ( employed by vtkDataSet::FindCell() and
///  vtkPointSet::FindCell() in vtkInterpolatedVelocityField ).
///  vtkCellLocatorInterpolatedVelocityField adopts one level of cell caching.
///  Specifically, if the next point is still within the previous cell, cell
///  location is then simply skipped and vtkCell:: EvaluatePosition() is called
///  to obtain the new parametric coordinates and weights that are used to
///  interpolate the velocity function values across the vertices of this cell.
///  Otherwise a global cell (the target containing the next point) location is
///  instead directly invoked, without exploiting the clue that
///  vtkInterpolatedVelocityField makes use of from the previous cell (an
///  immediate neighbor). Although ignoring the neighbor cell may incur a
///  relatively high computational cost, vtkCellLocatorInterpolatedVelocityField
///  is more robust in locating the target cell than its sibling class
///  vtkInterpolatedVelocityField.
///
/// @warning
///  vtkCellLocatorInterpolatedVelocityField is not thread safe. A new instance
///  should be created by each thread.
///
/// </remarks>
/// <seealso>
///
///  vtkCompositeInterpolatedVelocityField vtkInterpolatedVelocityField
///  vtkGenericInterpolatedVelocityField vtkCachingInterpolatedVelocityField
///  vtkTemporalInterpolatedVelocityField vtkFunctionSet vtkStreamTracer
/// </seealso>
public class vtkCellLocatorInterpolatedVelocityField : vtkCompositeInterpolatedVelocityField
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellLocatorInterpolatedVelocityField";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellLocatorInterpolatedVelocityField()
	{
		MRClassNameKey = "class vtkCellLocatorInterpolatedVelocityField";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellLocatorInterpolatedVelocityField"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellLocatorInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellLocatorInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vtkCompositeInterpolatedVelocityField subclass.
	/// </summary>
	public new static vtkCellLocatorInterpolatedVelocityField New()
	{
		vtkCellLocatorInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellLocatorInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellLocatorInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a vtkCompositeInterpolatedVelocityField subclass.
	/// </summary>
	public vtkCellLocatorInterpolatedVelocityField()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellLocatorInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCellLocatorInterpolatedVelocityField_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellLocatorInterpolatedVelocityField_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellLocatorInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellLocatorInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellLocatorInterpolatedVelocityField_IsA_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellLocatorInterpolatedVelocityField_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellLocatorInterpolatedVelocityField_IsTypeOf_04(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellLocatorInterpolatedVelocityField_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellLocatorInterpolatedVelocityField_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkCellLocatorInterpolatedVelocityField NewInstance()
	{
		vtkCellLocatorInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellLocatorInterpolatedVelocityField_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellLocatorInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellLocatorInterpolatedVelocityField_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkCellLocatorInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
	{
		vtkCellLocatorInterpolatedVelocityField vtkCellLocatorInterpolatedVelocityField2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellLocatorInterpolatedVelocityField_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellLocatorInterpolatedVelocityField2 = (vtkCellLocatorInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellLocatorInterpolatedVelocityField2.Register(null);
			}
		}
		return vtkCellLocatorInterpolatedVelocityField2;
	}
}
