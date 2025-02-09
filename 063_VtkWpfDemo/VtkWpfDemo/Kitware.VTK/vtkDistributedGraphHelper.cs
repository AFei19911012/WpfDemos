using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDistributedGraphHelper
/// </summary>
/// <remarks>
///    helper for the vtkGraph class
/// that allows the graph to be distributed across multiple memory spaces.
///
///
/// A distributed graph helper can be attached to an empty vtkGraph
/// object to turn the vtkGraph into a distributed graph, whose
/// vertices and edges are distributed across several different
/// processors. vtkDistributedGraphHelper is an abstract class. Use a
/// subclass of vtkDistributedGraphHelper, such as
/// vtkPBGLDistributedGraphHelper, to build distributed graphs.
///
/// The distributed graph helper provides facilities used by vtkGraph
/// to communicate with other processors that store other parts of the
/// same distributed graph. The only user-level functionality provided
/// by vtkDistributedGraphHelper involves this communication among
/// processors and the ability to map between "distributed" vertex and
/// edge IDs and their component parts (processor and local index). For
/// example, the Synchronize() method provides a barrier that allows
/// all processors to catch up to the same point in the code before any
/// processor can leave that Synchronize() call. For example, one would
/// call Synchronize() after adding many edges to a distributed graph,
/// so that all processors can handle the addition of inter-processor
/// edges and continue, after the Synchronize() call, with a consistent
/// view of the distributed graph. For more information about
/// manipulating (distributed) graphs, see the vtkGraph documentation.
///
/// </remarks>
/// <seealso>
///
/// vtkGraph
/// </seealso>
public abstract class vtkDistributedGraphHelper : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDistributedGraphHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDistributedGraphHelper()
	{
		MRClassNameKey = "class vtkDistributedGraphHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistributedGraphHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDistributedGraphHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern IntPtr vtkDistributedGraphHelper_Clone_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Clones the distributed graph helper, returning another
	/// distributed graph helper of the same kind that can be used in
	/// another vtkGraph.
	/// </summary>
	public virtual vtkDistributedGraphHelper Clone()
	{
		vtkDistributedGraphHelper vtkDistributedGraphHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistributedGraphHelper_Clone_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDistributedGraphHelper2 = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDistributedGraphHelper2.Register(null);
			}
		}
		return vtkDistributedGraphHelper2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistributedGraphHelper_DISTRIBUTEDEDGEIDS_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Information Keys that distributed graphs can append to attribute arrays
	/// to flag them as containing distributed IDs.  These can be used to let
	/// routines that migrate vertices (either repartitioning or collecting graphs
	/// to single nodes) to also modify the ids contained in the attribute arrays
	/// to maintain consistency.
	/// </summary>
	public static vtkInformationIntegerKey DISTRIBUTEDEDGEIDS()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistributedGraphHelper_DISTRIBUTEDEDGEIDS_02(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistributedGraphHelper_DISTRIBUTEDVERTEXIDS_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Information Keys that distributed graphs can append to attribute arrays
	/// to flag them as containing distributed IDs.  These can be used to let
	/// routines that migrate vertices (either repartitioning or collecting graphs
	/// to single nodes) to also modify the ids contained in the attribute arrays
	/// to maintain consistency.
	/// </summary>
	public static vtkInformationIntegerKey DISTRIBUTEDVERTEXIDS()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistributedGraphHelper_DISTRIBUTEDVERTEXIDS_03(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistributedGraphHelper_GetEdgeIndex_04(HandleRef pThis, long e_id);

	/// <summary>
	/// Returns local index of edge with ID e_id, by masking off top ceil(log2 P)
	/// bits of e_id.
	/// </summary>
	public long GetEdgeIndex(long e_id)
	{
		return vtkDistributedGraphHelper_GetEdgeIndex_04(GetCppThis(), e_id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistributedGraphHelper_GetEdgeOwner_05(HandleRef pThis, long e_id);

	/// <summary>
	/// Returns owner of edge with ID e_id, by extracting top ceil(log2 P) bits of e_id.
	/// </summary>
	public long GetEdgeOwner(long e_id)
	{
		return vtkDistributedGraphHelper_GetEdgeOwner_05(GetCppThis(), e_id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistributedGraphHelper_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDistributedGraphHelper_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistributedGraphHelper_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDistributedGraphHelper_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistributedGraphHelper_GetVertexIndex_08(HandleRef pThis, long v);

	/// <summary>
	/// Returns local index of vertex v, by masking off top ceil(log2 P) bits of v.
	/// </summary>
	public long GetVertexIndex(long v)
	{
		return vtkDistributedGraphHelper_GetVertexIndex_08(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistributedGraphHelper_GetVertexOwner_09(HandleRef pThis, long v);

	/// <summary>
	/// Returns owner of vertex v, by extracting top ceil(log2 P) bits of v.
	/// </summary>
	public long GetVertexOwner(long v)
	{
		return vtkDistributedGraphHelper_GetVertexOwner_09(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistributedGraphHelper_GetVertexOwnerByPedigreeId_10(HandleRef pThis, HandleRef pedigreeId);

	/// <summary>
	/// Determine which processor owns the vertex with the given pedigree ID.
	/// </summary>
	public long GetVertexOwnerByPedigreeId(vtkVariant pedigreeId)
	{
		return vtkDistributedGraphHelper_GetVertexOwnerByPedigreeId_10(GetCppThis(), pedigreeId?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistributedGraphHelper_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDistributedGraphHelper_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistributedGraphHelper_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDistributedGraphHelper_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistributedGraphHelper_MakeDistributedId_13(HandleRef pThis, int owner, long local);

	/// <summary>
	/// Builds a distributed ID consisting of the given owner and the local ID.
	/// </summary>
	public long MakeDistributedId(int owner, long local)
	{
		return vtkDistributedGraphHelper_MakeDistributedId_13(GetCppThis(), owner, local);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistributedGraphHelper_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDistributedGraphHelper NewInstance()
	{
		vtkDistributedGraphHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistributedGraphHelper_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistributedGraphHelper_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDistributedGraphHelper SafeDownCast(vtkObjectBase o)
	{
		vtkDistributedGraphHelper vtkDistributedGraphHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistributedGraphHelper_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDistributedGraphHelper2 = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDistributedGraphHelper2.Register(null);
			}
		}
		return vtkDistributedGraphHelper2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedGraphHelper_Synchronize_16(HandleRef pThis);

	/// <summary>
	/// Synchronizes all of the processors involved in this distributed
	/// graph, so that all processors have a consistent view of the
	/// distributed graph for the computation that follows. This routine
	/// should be invoked after adding new edges into the distributed
	/// graph, so that other processors will see those edges (or their
	/// corresponding back-edges).
	/// </summary>
	public virtual void Synchronize()
	{
		vtkDistributedGraphHelper_Synchronize_16(GetCppThis());
	}
}
