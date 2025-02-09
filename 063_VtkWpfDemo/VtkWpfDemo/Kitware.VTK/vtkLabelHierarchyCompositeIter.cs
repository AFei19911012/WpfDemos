using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLabelHierarchyCompositeIterator
/// </summary>
/// <remarks>
///    Iterator over sub-iterators
///
///
/// Iterates over child iterators in a round-robin order. Each iterator may
/// have its own count, which is the number of times it is repeated until
/// moving to the next iterator.
///
/// For example, if you initialize the iterator with
/// &lt;pre&gt;
/// it-&gt;AddIterator(A, 1);
/// it-&gt;AddIterator(B, 3);
/// &lt;/pre&gt;
/// The order of iterators will be A,B,B,B,A,B,B,B,...
/// </remarks>
public class vtkLabelHierarchyCompositeIterator : vtkLabelHierarchyIterator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLabelHierarchyCompositeIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLabelHierarchyCompositeIterator()
	{
		MRClassNameKey = "class vtkLabelHierarchyCompositeIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelHierarchyCompositeIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLabelHierarchyCompositeIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchyCompositeIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelHierarchyCompositeIterator New()
	{
		vtkLabelHierarchyCompositeIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchyCompositeIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelHierarchyCompositeIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLabelHierarchyCompositeIterator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLabelHierarchyCompositeIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyCompositeIterator_AddIterator_01(HandleRef pThis, HandleRef it);

	/// <summary>
	/// Adds a label iterator to this composite iterator.
	/// The second optional argument is the number of times to repeat the iterator
	/// before moving to the next one round-robin style. Default is 1.
	/// </summary>
	public virtual void AddIterator(vtkLabelHierarchyIterator it)
	{
		vtkLabelHierarchyCompositeIterator_AddIterator_01(GetCppThis(), it?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyCompositeIterator_AddIterator_02(HandleRef pThis, HandleRef it, int count);

	/// <summary>
	/// Adds a label iterator to this composite iterator.
	/// The second optional argument is the number of times to repeat the iterator
	/// before moving to the next one round-robin style. Default is 1.
	/// </summary>
	public virtual void AddIterator(vtkLabelHierarchyIterator it, int count)
	{
		vtkLabelHierarchyCompositeIterator_AddIterator_02(GetCppThis(), it?.GetCppThis() ?? default(HandleRef), count);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyCompositeIterator_Begin_03(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Initializes the iterator. lastLabels is an array holding labels
	/// which should be traversed before any other labels in the hierarchy.
	/// This could include labels placed during a previous rendering or
	/// a label located under the mouse pointer. You may pass a null pointer.
	/// </summary>
	public override void Begin(vtkIdTypeArray arg0)
	{
		vtkLabelHierarchyCompositeIterator_Begin_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyCompositeIterator_BoxAllNodes_04(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Not implemented.
	/// </summary>
	public override void BoxAllNodes(vtkPolyData arg0)
	{
		vtkLabelHierarchyCompositeIterator_BoxAllNodes_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyCompositeIterator_BoxNode_05(HandleRef pThis);

	/// <summary>
	/// Not implemented.
	/// </summary>
	public override void BoxNode()
	{
		vtkLabelHierarchyCompositeIterator_BoxNode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyCompositeIterator_ClearIterators_06(HandleRef pThis);

	/// <summary>
	/// Remove all iterators from this composite iterator.
	/// </summary>
	public virtual void ClearIterators()
	{
		vtkLabelHierarchyCompositeIterator_ClearIterators_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchyCompositeIterator_GetHierarchy_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the current label hierarchy.
	/// </summary>
	public override vtkLabelHierarchy GetHierarchy()
	{
		vtkLabelHierarchy vtkLabelHierarchy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchyCompositeIterator_GetHierarchy_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabelHierarchy2 = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabelHierarchy2.Register(null);
			}
		}
		return vtkLabelHierarchy2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelHierarchyCompositeIterator_GetLabelId_08(HandleRef pThis);

	/// <summary>
	/// Retrieves the current label id.
	/// </summary>
	public override long GetLabelId()
	{
		return vtkLabelHierarchyCompositeIterator_GetLabelId_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyCompositeIterator_GetNodeGeometry_09(HandleRef pThis, IntPtr ctr, ref double size);

	/// <summary>
	/// Retrieve the coordinates of the center of the current hierarchy node
	/// and the size of the node.
	/// Nodes are n-cubes, so the size is the length of any edge of the cube.
	/// This is used by BoxNode().
	/// </summary>
	public override void GetNodeGeometry(IntPtr ctr, ref double size)
	{
		vtkLabelHierarchyCompositeIterator_GetNodeGeometry_09(GetCppThis(), ctr, ref size);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelHierarchyCompositeIterator_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLabelHierarchyCompositeIterator_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelHierarchyCompositeIterator_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLabelHierarchyCompositeIterator_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchyCompositeIterator_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLabelHierarchyCompositeIterator_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelHierarchyCompositeIterator_IsAtEnd_13(HandleRef pThis);

	/// <summary>
	/// Returns true if the iterator is at the end.
	/// </summary>
	public override bool IsAtEnd()
	{
		return (vtkLabelHierarchyCompositeIterator_IsAtEnd_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchyCompositeIterator_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLabelHierarchyCompositeIterator_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchyCompositeIterator_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLabelHierarchyCompositeIterator NewInstance()
	{
		vtkLabelHierarchyCompositeIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchyCompositeIterator_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelHierarchyCompositeIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyCompositeIterator_Next_17(HandleRef pThis);

	/// <summary>
	/// Advance the iterator.
	/// </summary>
	public override void Next()
	{
		vtkLabelHierarchyCompositeIterator_Next_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchyCompositeIterator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelHierarchyCompositeIterator SafeDownCast(vtkObjectBase o)
	{
		vtkLabelHierarchyCompositeIterator vtkLabelHierarchyCompositeIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchyCompositeIterator_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabelHierarchyCompositeIterator2 = (vtkLabelHierarchyCompositeIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabelHierarchyCompositeIterator2.Register(null);
			}
		}
		return vtkLabelHierarchyCompositeIterator2;
	}
}
