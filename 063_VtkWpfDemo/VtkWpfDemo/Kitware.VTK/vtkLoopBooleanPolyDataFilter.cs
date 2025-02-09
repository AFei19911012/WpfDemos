using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLoopBooleanPolyDataFilter
///
///
/// Computes the boundary of the union, intersection, or difference
/// volume computed from the volumes defined by two input surfaces. The
/// two surfaces do not need to be manifold, but if they are not,
/// unexpected results may be obtained. The resulting surface is
/// available in the first output of the filter. The second output
/// contains a set of polylines that represent the intersection between
/// the two input surfaces.
/// The filter uses vtkIntersectionPolyDataFilter. Must have information
/// about the cells on mesh that the intersection lines touch. Filter assumes
/// this information is given.
/// The output result will have data about the Original Surface,
/// BoundaryPoints, Boundary Cells,
/// Free Edges, and Bad Triangles
/// </summary>
public class vtkLoopBooleanPolyDataFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
	/// Variable to determine what is output if no intersection occurs.
	/// 0 = neither (default), 1 = first, 2 = second, 3 = both
	/// </summary>
	public enum NoIntersectionOutputType
	{
		/// <summary>enum member</summary>
		VTK_BOTH = 3,
		/// <summary>enum member</summary>
		VTK_FIRST = 1,
		/// <summary>enum member</summary>
		VTK_NEITHER = 0,
		/// <summary>enum member</summary>
		VTK_SECOND = 2
	}

	/// <summary>
	/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
	/// Variable to determine what is output if no intersection occurs.
	/// 0 = neither (default), 1 = first, 2 = second, 3 = both
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkLoopBooleanPolyDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLoopBooleanPolyDataFilter()
	{
		MRClassNameKey = "class vtkLoopBooleanPolyDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLoopBooleanPolyDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLoopBooleanPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLoopBooleanPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public new static vtkLoopBooleanPolyDataFilter New()
	{
		vtkLoopBooleanPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLoopBooleanPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLoopBooleanPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public vtkLoopBooleanPolyDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLoopBooleanPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkLoopBooleanPolyDataFilter_GetNoIntersectionOutput_01(HandleRef pThis);

	/// <summary>
	/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
	/// Variable to determine what is output if no intersection occurs.
	/// 0 = neither (default), 1 = first, 2 = second, 3 = both
	/// </summary>
	public virtual int GetNoIntersectionOutput()
	{
		return vtkLoopBooleanPolyDataFilter_GetNoIntersectionOutput_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLoopBooleanPolyDataFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLoopBooleanPolyDataFilter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLoopBooleanPolyDataFilter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLoopBooleanPolyDataFilter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLoopBooleanPolyDataFilter_GetNumberOfIntersectionLines_04(HandleRef pThis);

	/// <summary>
	/// Integer describing the number of intersection points and lines
	/// </summary>
	public virtual int GetNumberOfIntersectionLines()
	{
		return vtkLoopBooleanPolyDataFilter_GetNumberOfIntersectionLines_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLoopBooleanPolyDataFilter_GetNumberOfIntersectionPoints_05(HandleRef pThis);

	/// <summary>
	/// Integer describing the number of intersection points and lines
	/// </summary>
	public virtual int GetNumberOfIntersectionPoints()
	{
		return vtkLoopBooleanPolyDataFilter_GetNumberOfIntersectionPoints_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLoopBooleanPolyDataFilter_GetOperation_06(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public virtual int GetOperation()
	{
		return vtkLoopBooleanPolyDataFilter_GetOperation_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLoopBooleanPolyDataFilter_GetOperationMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public virtual int GetOperationMaxValue()
	{
		return vtkLoopBooleanPolyDataFilter_GetOperationMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLoopBooleanPolyDataFilter_GetOperationMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public virtual int GetOperationMinValue()
	{
		return vtkLoopBooleanPolyDataFilter_GetOperationMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLoopBooleanPolyDataFilter_GetStatus_09(HandleRef pThis);

	/// <summary>
	/// Check the status of the filter after update. If the status is zero,
	/// there was an error in the operation. If status is one, everything
	/// went smoothly
	/// </summary>
	public virtual int GetStatus()
	{
		return vtkLoopBooleanPolyDataFilter_GetStatus_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLoopBooleanPolyDataFilter_GetTolerance_10(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for geometric tests
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkLoopBooleanPolyDataFilter_GetTolerance_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLoopBooleanPolyDataFilter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLoopBooleanPolyDataFilter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLoopBooleanPolyDataFilter_IsTypeOf_12(string type);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLoopBooleanPolyDataFilter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLoopBooleanPolyDataFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public new vtkLoopBooleanPolyDataFilter NewInstance()
	{
		vtkLoopBooleanPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLoopBooleanPolyDataFilter_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLoopBooleanPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLoopBooleanPolyDataFilter_NoIntersectionOutputOff_15(HandleRef pThis);

	/// <summary>
	/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
	/// Variable to determine what is output if no intersection occurs.
	/// 0 = neither (default), 1 = first, 2 = second, 3 = both
	/// </summary>
	public virtual void NoIntersectionOutputOff()
	{
		vtkLoopBooleanPolyDataFilter_NoIntersectionOutputOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLoopBooleanPolyDataFilter_NoIntersectionOutputOn_16(HandleRef pThis);

	/// <summary>
	/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
	/// Variable to determine what is output if no intersection occurs.
	/// 0 = neither (default), 1 = first, 2 = second, 3 = both
	/// </summary>
	public virtual void NoIntersectionOutputOn()
	{
		vtkLoopBooleanPolyDataFilter_NoIntersectionOutputOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLoopBooleanPolyDataFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object that computes the boolean surface.
	/// </summary>
	public new static vtkLoopBooleanPolyDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkLoopBooleanPolyDataFilter vtkLoopBooleanPolyDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLoopBooleanPolyDataFilter_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLoopBooleanPolyDataFilter2 = (vtkLoopBooleanPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLoopBooleanPolyDataFilter2.Register(null);
			}
		}
		return vtkLoopBooleanPolyDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLoopBooleanPolyDataFilter_SetNoIntersectionOutput_18(HandleRef pThis, int _arg);

	/// <summary>
	/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
	/// Variable to determine what is output if no intersection occurs.
	/// 0 = neither (default), 1 = first, 2 = second, 3 = both
	/// </summary>
	public virtual void SetNoIntersectionOutput(int _arg)
	{
		vtkLoopBooleanPolyDataFilter_SetNoIntersectionOutput_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLoopBooleanPolyDataFilter_SetOperation_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public virtual void SetOperation(int _arg)
	{
		vtkLoopBooleanPolyDataFilter_SetOperation_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLoopBooleanPolyDataFilter_SetOperationToDifference_20(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public void SetOperationToDifference()
	{
		vtkLoopBooleanPolyDataFilter_SetOperationToDifference_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLoopBooleanPolyDataFilter_SetOperationToIntersection_21(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public void SetOperationToIntersection()
	{
		vtkLoopBooleanPolyDataFilter_SetOperationToIntersection_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLoopBooleanPolyDataFilter_SetOperationToUnion_22(HandleRef pThis);

	/// <summary>
	/// Set the boolean operation to perform. Defaults to union.
	/// </summary>
	public void SetOperationToUnion()
	{
		vtkLoopBooleanPolyDataFilter_SetOperationToUnion_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLoopBooleanPolyDataFilter_SetTolerance_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the tolerance for geometric tests
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkLoopBooleanPolyDataFilter_SetTolerance_23(GetCppThis(), _arg);
	}
}
