using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBooleanOperationPolyDataFilter
///
///
/// Computes the boundary of the union, intersection, or difference
/// volume computed from the volumes defined by two input surfaces. The
/// two surfaces do not need to be manifold, but if they are not,
/// unexpected results may be obtained. The resulting surface is
/// available in the first output of the filter. The second output
/// contains a set of polylines that represent the intersection between
/// the two input surfaces.
///
/// @warning This filter is not designed to perform 2D boolean operations,
/// and in fact relies on the inputs having no co-planar, overlapping cells.
///
/// This code was contributed in the VTK Journal paper:
/// "Boolean Operations on Surfaces in VTK Without External Libraries"
/// by Cory Quammen, Chris Weigle C., Russ Taylor
/// http://hdl.handle.net/10380/3262
/// http://www.midasjournal.org/browse/publication/797
/// </summary>
public class vtkBooleanOperationPolyDataFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public enum OperationType
	{
		/// <summary>enum member</summary>
		VTK_DIFFERENCE = 2,
		/// <summary>enum member</summary>
		VTK_INTERSECTION = 1,
		/// <summary>enum member</summary>
		VTK_UNION = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBooleanOperationPolyDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBooleanOperationPolyDataFilter()
	{
		MRClassNameKey = "class vtkBooleanOperationPolyDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBooleanOperationPolyDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBooleanOperationPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanOperationPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public new static vtkBooleanOperationPolyDataFilter New()
	{
		vtkBooleanOperationPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBooleanOperationPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBooleanOperationPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public vtkBooleanOperationPolyDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBooleanOperationPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkBooleanOperationPolyDataFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBooleanOperationPolyDataFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBooleanOperationPolyDataFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBooleanOperationPolyDataFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBooleanOperationPolyDataFilter_GetOperation_03(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public virtual int GetOperation()
	{
		return vtkBooleanOperationPolyDataFilter_GetOperation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBooleanOperationPolyDataFilter_GetOperationMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public virtual int GetOperationMaxValue()
	{
		return vtkBooleanOperationPolyDataFilter_GetOperationMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBooleanOperationPolyDataFilter_GetOperationMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public virtual int GetOperationMinValue()
	{
		return vtkBooleanOperationPolyDataFilter_GetOperationMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBooleanOperationPolyDataFilter_GetReorientDifferenceCells_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off cell reorientation of the intersection portion of the
	/// surface when the operation is set to DIFFERENCE. Defaults to on.
	/// </summary>
	public virtual int GetReorientDifferenceCells()
	{
		return vtkBooleanOperationPolyDataFilter_GetReorientDifferenceCells_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBooleanOperationPolyDataFilter_GetTolerance_07(HandleRef pThis);

	/// <summary>
	/// Set/get the tolerance used to determine when a point's absolute
	/// distance is considered to be zero. Defaults to 1e-6.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkBooleanOperationPolyDataFilter_GetTolerance_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBooleanOperationPolyDataFilter_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBooleanOperationPolyDataFilter_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBooleanOperationPolyDataFilter_IsTypeOf_09(string type);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBooleanOperationPolyDataFilter_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanOperationPolyDataFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public new vtkBooleanOperationPolyDataFilter NewInstance()
	{
		vtkBooleanOperationPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBooleanOperationPolyDataFilter_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBooleanOperationPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanOperationPolyDataFilter_ReorientDifferenceCellsOff_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off cell reorientation of the intersection portion of the
	/// surface when the operation is set to DIFFERENCE. Defaults to on.
	/// </summary>
	public virtual void ReorientDifferenceCellsOff()
	{
		vtkBooleanOperationPolyDataFilter_ReorientDifferenceCellsOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanOperationPolyDataFilter_ReorientDifferenceCellsOn_13(HandleRef pThis);

	/// <summary>
	/// Turn on/off cell reorientation of the intersection portion of the
	/// surface when the operation is set to DIFFERENCE. Defaults to on.
	/// </summary>
	public virtual void ReorientDifferenceCellsOn()
	{
		vtkBooleanOperationPolyDataFilter_ReorientDifferenceCellsOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanOperationPolyDataFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public new static vtkBooleanOperationPolyDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkBooleanOperationPolyDataFilter vtkBooleanOperationPolyDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBooleanOperationPolyDataFilter_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBooleanOperationPolyDataFilter2 = (vtkBooleanOperationPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBooleanOperationPolyDataFilter2.Register(null);
			}
		}
		return vtkBooleanOperationPolyDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanOperationPolyDataFilter_SetOperation_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public virtual void SetOperation(int _arg)
	{
		vtkBooleanOperationPolyDataFilter_SetOperation_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanOperationPolyDataFilter_SetOperationToDifference_16(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public void SetOperationToDifference()
	{
		vtkBooleanOperationPolyDataFilter_SetOperationToDifference_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanOperationPolyDataFilter_SetOperationToIntersection_17(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public void SetOperationToIntersection()
	{
		vtkBooleanOperationPolyDataFilter_SetOperationToIntersection_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanOperationPolyDataFilter_SetOperationToUnion_18(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public void SetOperationToUnion()
	{
		vtkBooleanOperationPolyDataFilter_SetOperationToUnion_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanOperationPolyDataFilter_SetReorientDifferenceCells_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off cell reorientation of the intersection portion of the
	/// surface when the operation is set to DIFFERENCE. Defaults to on.
	/// </summary>
	public virtual void SetReorientDifferenceCells(int _arg)
	{
		vtkBooleanOperationPolyDataFilter_SetReorientDifferenceCells_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanOperationPolyDataFilter_SetTolerance_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the tolerance used to determine when a point's absolute
	/// distance is considered to be zero. Defaults to 1e-6.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkBooleanOperationPolyDataFilter_SetTolerance_20(GetCppThis(), _arg);
	}
}
