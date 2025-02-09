using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEdgeTable
/// </summary>
/// <remarks>
///    keep track of edges (edge is pair of integer id's)
///
/// vtkEdgeTable is a general object for keeping track of lists of edges. An
/// edge is defined by the pair of point id's (p1,p2). Methods are available
/// to insert edges, check if edges exist, and traverse the list of edges.
/// Also, it's possible to associate attribute information with each edge.
/// The attribute information may take the form of vtkIdType id's, void*
/// pointers, or points. To store attributes, make sure that
/// InitEdgeInsertion() is invoked with the storeAttributes flag set properly.
/// If points are inserted, use the methods InitPointInsertion() and
/// InsertUniquePoint().
/// </remarks>
public class vtkEdgeTable : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeTable";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEdgeTable()
	{
		MRClassNameKey = "class vtkEdgeTable";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeTable"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEdgeTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEdgeTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object assuming that 1000 edges are to be inserted.
	/// </summary>
	public new static vtkEdgeTable New()
	{
		vtkEdgeTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEdgeTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object assuming that 1000 edges are to be inserted.
	/// </summary>
	public vtkEdgeTable()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEdgeTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkEdgeTable_GetNextEdge_01(HandleRef pThis, ref long p1, ref long p2);

	/// <summary>
	/// Traverse list of edges in table. Return the edge as (p1,p2), where p1
	/// and p2 are point id's. Method return value is &lt;0 if list is exhausted;
	/// non-zero otherwise. The value of p1 is guaranteed to be &lt;= p2.
	/// </summary>
	public long GetNextEdge(ref long p1, ref long p2)
	{
		return vtkEdgeTable_GetNextEdge_01(GetCppThis(), ref p1, ref p2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEdgeTable_GetNumberOfEdges_02(HandleRef pThis);

	/// <summary>
	/// Return the number of edges that have been inserted thus far.
	/// </summary>
	public virtual long GetNumberOfEdges()
	{
		return vtkEdgeTable_GetNumberOfEdges_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEdgeTable_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object assuming that 1000 edges are to be inserted.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEdgeTable_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEdgeTable_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Instantiate object assuming that 1000 edges are to be inserted.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEdgeTable_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeTable_InitEdgeInsertion_05(HandleRef pThis, long numPoints, int storeAttributes);

	/// <summary>
	/// Initialize the edge insertion process. Provide an estimate of the number
	/// of points in a dataset (the maximum range value of p1 or p2).  The
	/// storeAttributes variable controls whether attributes are to be stored
	/// with the edge, and what type of attributes. If storeAttributes==1, then
	/// attributes of vtkIdType can be stored. If storeAttributes==2, then
	/// attributes of type void* can be stored. In either case, additional
	/// memory will be required by the data structure to store attribute data
	/// per each edge.  This method is used in conjunction with one of the three
	/// InsertEdge() methods described below (don't mix the InsertEdge()
	/// methods---make sure that the one used is consistent with the
	/// storeAttributes flag set in InitEdgeInsertion()).
	/// </summary>
	public int InitEdgeInsertion(long numPoints, int storeAttributes)
	{
		return vtkEdgeTable_InitEdgeInsertion_05(GetCppThis(), numPoints, storeAttributes);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeTable_InitPointInsertion_06(HandleRef pThis, HandleRef newPts, long estSize);

	/// <summary>
	/// Initialize the point insertion process. The newPts is an object
	/// representing point coordinates into which incremental insertion methods
	/// place their data. The points are associated with the edge.
	/// </summary>
	public int InitPointInsertion(vtkPoints newPts, long estSize)
	{
		return vtkEdgeTable_InitPointInsertion_06(GetCppThis(), newPts?.GetCppThis() ?? default(HandleRef), estSize);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEdgeTable_InitTraversal_07(HandleRef pThis);

	/// <summary>
	/// Initialize traversal of edges in table.
	/// </summary>
	public void InitTraversal()
	{
		vtkEdgeTable_InitTraversal_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEdgeTable_Initialize_08(HandleRef pThis);

	/// <summary>
	/// Free memory and return to the initially instantiated state.
	/// </summary>
	public void Initialize()
	{
		vtkEdgeTable_Initialize_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEdgeTable_InsertEdge_09(HandleRef pThis, long p1, long p2);

	/// <summary>
	/// Insert the edge (p1,p2) into the table. It is the user's
	/// responsibility to check if the edge has already been inserted
	/// (use IsEdge()). If the storeAttributes flag in InitEdgeInsertion()
	/// has been set, then the method returns a unique integer id (i.e.,
	/// the edge id) that can be used to set and get edge
	/// attributes. Otherwise, the method will return 1. Do not mix this
	/// method with the InsertEdge() method that follows.
	/// </summary>
	public long InsertEdge(long p1, long p2)
	{
		return vtkEdgeTable_InsertEdge_09(GetCppThis(), p1, p2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEdgeTable_InsertEdge_10(HandleRef pThis, long p1, long p2, long attributeId);

	/// <summary>
	/// Insert the edge (p1,p2) into the table with the attribute id
	/// specified (make sure the attributeId &gt;= 0). Note that the
	/// attributeId is ignored if the storeAttributes variable was set to
	/// 0 in the InitEdgeInsertion() method. It is the user's
	/// responsibility to check if the edge has already been inserted
	/// (use IsEdge()). Do not mix this method with the other two
	/// InsertEdge() methods.
	/// </summary>
	public void InsertEdge(long p1, long p2, long attributeId)
	{
		vtkEdgeTable_InsertEdge_10(GetCppThis(), p1, p2, attributeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEdgeTable_InsertEdge_11(HandleRef pThis, long p1, long p2, IntPtr ptr);

	/// <summary>
	/// Insert the edge (p1,p2) into the table with the attribute id
	/// specified (make sure the attributeId &gt;= 0). Note that the
	/// attributeId is ignored if the storeAttributes variable was set to
	/// 0 in the InitEdgeInsertion() method. It is the user's
	/// responsibility to check if the edge has already been inserted
	/// (use IsEdge()). Do not mix this method with the other two
	/// InsertEdge() methods.
	/// </summary>
	public void InsertEdge(long p1, long p2, IntPtr ptr)
	{
		vtkEdgeTable_InsertEdge_11(GetCppThis(), p1, p2, ptr);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeTable_InsertUniquePoint_12(HandleRef pThis, long p1, long p2, IntPtr x, ref long ptId);

	/// <summary>
	/// Insert a unique point on the specified edge. Invoke this method only
	/// after InitPointInsertion() has been called. Return 0 if point was
	/// already in the list, otherwise return 1.
	/// </summary>
	public int InsertUniquePoint(long p1, long p2, IntPtr x, ref long ptId)
	{
		return vtkEdgeTable_InsertUniquePoint_12(GetCppThis(), p1, p2, x, ref ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeTable_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object assuming that 1000 edges are to be inserted.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEdgeTable_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEdgeTable_IsEdge_14(HandleRef pThis, long p1, long p2);

	/// <summary>
	/// Return an integer id for the edge, or an attribute id of the edge
	/// (p1,p2) if the edge has been previously defined (it depends upon
	/// which version of InsertEdge() is being used); otherwise -1. The
	/// unique integer id can be used to set and retrieve attributes to
	/// the edge.
	/// </summary>
	public long IsEdge(long p1, long p2)
	{
		return vtkEdgeTable_IsEdge_14(GetCppThis(), p1, p2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeTable_IsTypeOf_15(string type);

	/// <summary>
	/// Instantiate object assuming that 1000 edges are to be inserted.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEdgeTable_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEdgeTable_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object assuming that 1000 edges are to be inserted.
	/// </summary>
	public new vtkEdgeTable NewInstance()
	{
		vtkEdgeTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEdgeTable_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEdgeTable_Reset_18(HandleRef pThis);

	/// <summary>
	/// Reset the object and prepare for reinsertion of edges. Does not delete
	/// memory like the Initialize() method.
	/// </summary>
	public void Reset()
	{
		vtkEdgeTable_Reset_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEdgeTable_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object assuming that 1000 edges are to be inserted.
	/// </summary>
	public new static vtkEdgeTable SafeDownCast(vtkObjectBase o)
	{
		vtkEdgeTable vtkEdgeTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEdgeTable_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEdgeTable2 = (vtkEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEdgeTable2.Register(null);
			}
		}
		return vtkEdgeTable2;
	}
}
