using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericEdgeTable
/// </summary>
/// <remarks>
///    keep track of edges (defined by pair of integer id's)
///
/// vtkGenericEdgeTable is used to indicate the existence of and hold
/// information about edges. Similar to vtkEdgeTable, this class is
/// more sophisticated in that it uses reference counting to keep track
/// of when information about an edge should be deleted.
///
/// vtkGenericEdgeTable is a helper class used in the adaptor framework.  It
/// is used during the tessellation process to hold information about the
/// error metric on each edge. This avoids recomputing the error metric each
/// time the same edge is visited.
/// </remarks>
public class vtkGenericEdgeTable : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericEdgeTable";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericEdgeTable()
	{
		MRClassNameKey = "class vtkGenericEdgeTable";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericEdgeTable"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericEdgeTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEdgeTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate an empty edge table.
	/// </summary>
	public new static vtkGenericEdgeTable New()
	{
		vtkGenericEdgeTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericEdgeTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate an empty edge table.
	/// </summary>
	public vtkGenericEdgeTable()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericEdgeTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEdgeTable_CheckEdge_01(HandleRef pThis, long e1, long e2, ref long ptId);

	/// <summary>
	/// Method to determine whether an edge is in the table (0 or 1), or not (-1).
	/// It returns whether the edge was split (1) or not (0),
	/// and the point id exists.
	/// </summary>
	public int CheckEdge(long e1, long e2, ref long ptId)
	{
		return vtkGenericEdgeTable_CheckEdge_01(GetCppThis(), e1, e2, ref ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEdgeTable_CheckEdgeReferenceCount_02(HandleRef pThis, long e1, long e2);

	/// <summary>
	/// Return the edge reference count.
	/// </summary>
	public int CheckEdgeReferenceCount(long e1, long e2)
	{
		return vtkGenericEdgeTable_CheckEdgeReferenceCount_02(GetCppThis(), e1, e2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEdgeTable_CheckPoint_03(HandleRef pThis, long ptId);

	/// <summary>
	/// Check if a point is already in the point table.
	/// </summary>
	public int CheckPoint(long ptId)
	{
		return vtkGenericEdgeTable_CheckPoint_03(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEdgeTable_CheckPoint_04(HandleRef pThis, long ptId, IntPtr point, IntPtr scalar);

	/// <summary>
	/// Check for the existence of a point and return its coordinate value.
	/// \pre scalar_size: sizeof(scalar)==this-&gt;GetNumberOfComponents()
	/// </summary>
	public int CheckPoint(long ptId, IntPtr point, IntPtr scalar)
	{
		return vtkGenericEdgeTable_CheckPoint_04(GetCppThis(), ptId, point, scalar);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEdgeTable_DumpTable_05(HandleRef pThis);

	/// <summary>
	/// For debugging purposes. It is particularly useful to dump the table
	/// and check that nothing is left after a complete iteration. LoadFactor
	/// should ideally be very low to be able to have a constant time access
	/// </summary>
	public void DumpTable()
	{
		vtkGenericEdgeTable_DumpTable_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEdgeTable_GetNumberOfComponents_06(HandleRef pThis);

	/// <summary>
	/// Return the total number of components for the point-centered attributes.
	/// \post positive_result: result&gt;0
	/// </summary>
	public int GetNumberOfComponents()
	{
		return vtkGenericEdgeTable_GetNumberOfComponents_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericEdgeTable_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericEdgeTable_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericEdgeTable_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericEdgeTable_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEdgeTable_IncrementEdgeReferenceCount_09(HandleRef pThis, long e1, long e2, long cellId);

	/// <summary>
	/// Method that increments the referencecount and returns it.
	/// </summary>
	public int IncrementEdgeReferenceCount(long e1, long e2, long cellId)
	{
		return vtkGenericEdgeTable_IncrementEdgeReferenceCount_09(GetCppThis(), e1, e2, cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEdgeTable_IncrementPointReferenceCount_10(HandleRef pThis, long ptId);

	/// <summary>
	/// Increment the reference count for the indicated point.
	/// </summary>
	public void IncrementPointReferenceCount(long ptId)
	{
		vtkGenericEdgeTable_IncrementPointReferenceCount_10(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEdgeTable_Initialize_11(HandleRef pThis, long start);

	/// <summary>
	/// To specify the starting point id. It will initialize LastPointId
	/// This is very sensitive the start point should be cautiously chosen
	/// </summary>
	public void Initialize(long start)
	{
		vtkGenericEdgeTable_Initialize_11(GetCppThis(), start);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEdgeTable_InsertEdge_12(HandleRef pThis, long e1, long e2, long cellId, int arg3, ref long ptId);

	/// <summary>
	/// Split the edge with the indicated point id.
	/// </summary>
	public void InsertEdge(long e1, long e2, long cellId, int arg3, ref long ptId)
	{
		vtkGenericEdgeTable_InsertEdge_12(GetCppThis(), e1, e2, cellId, arg3, ref ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEdgeTable_InsertEdge_13(HandleRef pThis, long e1, long e2, long cellId, int arg3);

	/// <summary>
	/// Insert an edge but do not split it.
	/// </summary>
	public void InsertEdge(long e1, long e2, long cellId, int arg3)
	{
		vtkGenericEdgeTable_InsertEdge_13(GetCppThis(), e1, e2, cellId, arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEdgeTable_InsertPoint_14(HandleRef pThis, long ptId, IntPtr point);

	/// <summary>
	/// Insert point associated with an edge.
	/// </summary>
	public void InsertPoint(long ptId, IntPtr point)
	{
		vtkGenericEdgeTable_InsertPoint_14(GetCppThis(), ptId, point);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEdgeTable_InsertPointAndScalar_15(HandleRef pThis, long ptId, IntPtr pt, IntPtr s);

	/// <summary>
	/// Insert point associated with an edge.
	/// </summary>
	public void InsertPointAndScalar(long ptId, IntPtr pt, IntPtr s)
	{
		vtkGenericEdgeTable_InsertPointAndScalar_15(GetCppThis(), ptId, pt, s);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEdgeTable_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericEdgeTable_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEdgeTable_IsTypeOf_17(string type);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericEdgeTable_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEdgeTable_LoadFactor_18(HandleRef pThis);

	/// <summary>
	/// For debugging purposes. It is particularly useful to dump the table
	/// and check that nothing is left after a complete iteration. LoadFactor
	/// should ideally be very low to be able to have a constant time access
	/// </summary>
	public void LoadFactor()
	{
		vtkGenericEdgeTable_LoadFactor_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEdgeTable_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public new vtkGenericEdgeTable NewInstance()
	{
		vtkGenericEdgeTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericEdgeTable_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEdgeTable_RemoveEdge_21(HandleRef pThis, long e1, long e2);

	/// <summary>
	/// Method to remove an edge from the table. The method returns the
	/// current reference count.
	/// </summary>
	public int RemoveEdge(long e1, long e2)
	{
		return vtkGenericEdgeTable_RemoveEdge_21(GetCppThis(), e1, e2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEdgeTable_RemovePoint_22(HandleRef pThis, long ptId);

	/// <summary>
	/// Remove a point from the point table.
	/// </summary>
	public void RemovePoint(long ptId)
	{
		vtkGenericEdgeTable_RemovePoint_22(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEdgeTable_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public new static vtkGenericEdgeTable SafeDownCast(vtkObjectBase o)
	{
		vtkGenericEdgeTable vtkGenericEdgeTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericEdgeTable_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericEdgeTable2 = (vtkGenericEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericEdgeTable2.Register(null);
			}
		}
		return vtkGenericEdgeTable2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEdgeTable_SetNumberOfComponents_24(HandleRef pThis, int count);

	/// <summary>
	/// Set the total number of components for the point-centered attributes.
	/// \pre positive_count: count&gt;0
	/// </summary>
	public void SetNumberOfComponents(int count)
	{
		vtkGenericEdgeTable_SetNumberOfComponents_24(GetCppThis(), count);
	}
}
