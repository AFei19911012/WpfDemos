using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkDataAssemblyVisitor
/// </summary>
/// <remarks>
///  visitor API for vtkDataAssembly
///
/// vtkDataAssemblyVisitor defines a visitor API for vtkDataAssembly. A concrete
/// subclass of vtkDataAssemblyVisitor can be passed to `vtkDataAssembly::Visit`
/// to execute custom code on each node in the data-assembly.
///
/// `vtkDataAssembly::Visit` will call `vtkDataAssemblyVisitor::Visit` on each
/// node in the assembly (or chosen subtree). The traversal order, i.e.
/// depth-first or breadth-first, is selected by the arguments passed to
/// `vtkDataAssembly::Visit`. Before traversing a sub-tree for a particular node,
/// `vtkDataAssemblyVisitor::GetTraverseSubtree` is called, if it returns false,
/// the subtree is skipped. If it returns true, then then
/// `vtkDataAssemblyVisitor::BeginSubTree` is called, followed by calls to
/// `vtkDataAssemblyVisitor::Visit` for each of the child nodes, and finally
/// `vtkDataAssemblyVisitor::EndSubTree` is called.
///
/// In depth-first order, the subtree traversal is recursive. Thus, after
/// `BeginSubTree` is called for specific node, all its children and their
/// subtrees are traversed before `EndSubTree` gets called for that node.
///
/// In breadth-first order, a first-in-first-out queue is used. A node is
/// visited, i.e. `vtkDataAssemblyVisitor::Visit` called on it, then if
/// `GetTraverseSubtree` returns true, `Visit` gets called on all its immediate
/// children one after another followed by `EndSubTree` on the parent node.
/// As each of the child nodes are visited, they get added to the queue.
/// Now, for each node in the queue, the process repeats i.e.
/// `GetTraverseSubtree` is called, followed by the subtree traversal for that
/// node. This continues until the queue empty.
///
/// </remarks>
/// <seealso>
///  vtkDataAssembly
/// </seealso>
public abstract class vtkDataAssemblyVisitor : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataAssemblyVisitor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataAssemblyVisitor()
	{
		MRClassNameKey = "class vtkDataAssemblyVisitor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataAssemblyVisitor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataAssemblyVisitor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkDataAssemblyVisitor_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataAssemblyVisitor_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataAssemblyVisitor_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataAssemblyVisitor_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssemblyVisitor_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataAssemblyVisitor_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssemblyVisitor_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataAssemblyVisitor_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssemblyVisitor_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataAssemblyVisitor NewInstance()
	{
		vtkDataAssemblyVisitor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataAssemblyVisitor_NewInstance_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataAssemblyVisitor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssemblyVisitor_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataAssemblyVisitor SafeDownCast(vtkObjectBase o)
	{
		vtkDataAssemblyVisitor vtkDataAssemblyVisitor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataAssemblyVisitor_SafeDownCast_06(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataAssemblyVisitor2 = (vtkDataAssemblyVisitor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataAssemblyVisitor2.Register(null);
			}
		}
		return vtkDataAssemblyVisitor2;
	}
}
