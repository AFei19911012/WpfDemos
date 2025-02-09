using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLabelHierarchyIterator
/// </summary>
/// <remarks>
///    iterator over vtkLabelHierarchy
///
///
/// Abstract superclass for iterators over vtkLabelHierarchy.
/// </remarks>
public abstract class vtkLabelHierarchyIterator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLabelHierarchyIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLabelHierarchyIterator()
	{
		MRClassNameKey = "class vtkLabelHierarchyIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelHierarchyIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLabelHierarchyIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyIterator_Begin_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Initializes the iterator. lastLabels is an array holding labels
	/// which should be traversed before any other labels in the hierarchy.
	/// This could include labels placed during a previous rendering or
	/// a label located under the mouse pointer. You may pass a null pointer.
	/// </summary>
	public virtual void Begin(vtkIdTypeArray arg0)
	{
		vtkLabelHierarchyIterator_Begin_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyIterator_BoxAllNodes_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a representation for all existing octree nodes to the specified polydata.
	/// This is equivalent to setting TraversedBounds, iterating over the entire hierarchy,
	/// and then resetting TraversedBounds to its original value.
	/// </summary>
	public virtual void BoxAllNodes(vtkPolyData arg0)
	{
		vtkLabelHierarchyIterator_BoxAllNodes_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyIterator_BoxNode_03(HandleRef pThis);

	/// <summary>
	/// Add a representation to TraversedBounds for the current octree node.
	/// This should be called by subclasses inside Next().
	/// Does nothing if TraversedBounds is NULL.
	/// </summary>
	public virtual void BoxNode()
	{
		vtkLabelHierarchyIterator_BoxNode_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchyIterator_GetAllBounds_04(HandleRef pThis);

	/// <summary>
	/// Set/get whether all nodes in the hierarchy should be added to the TraversedBounds
	/// polydata or only those traversed.
	/// When non-zero, all nodes will be added.
	/// By default, AllBounds is 0.
	/// </summary>
	public virtual int GetAllBounds()
	{
		return vtkLabelHierarchyIterator_GetAllBounds_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyIterator_GetBoundedSize_05(HandleRef pThis, IntPtr sz);

	/// <summary>
	/// Retrieves the current label maximum width in world coordinates.
	/// </summary>
	public virtual void GetBoundedSize(IntPtr sz)
	{
		vtkLabelHierarchyIterator_GetBoundedSize_05(GetCppThis(), sz);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchyIterator_GetHierarchy_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the label hierarchy associated with the current label.
	/// </summary>
	public virtual vtkLabelHierarchy GetHierarchy()
	{
		vtkLabelHierarchy vtkLabelHierarchy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchyIterator_GetHierarchy_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern string vtkLabelHierarchyIterator_GetLabel_07(HandleRef pThis);

	/// <summary>
	/// Retrieves the current label string.
	/// </summary>
	public virtual string GetLabel()
	{
		return vtkLabelHierarchyIterator_GetLabel_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelHierarchyIterator_GetLabelId_08(HandleRef pThis);

	/// <summary>
	/// Retrieves the current label id.
	/// </summary>
	public virtual long GetLabelId()
	{
		return vtkLabelHierarchyIterator_GetLabelId_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyIterator_GetNodeGeometry_09(HandleRef pThis, IntPtr ctr, ref double size);

	/// <summary>
	/// Retrieve the coordinates of the center of the current hierarchy node
	/// and the size of the node.
	/// Nodes are n-cubes, so the size is the length of any edge of the cube.
	/// This is used by BoxNode().
	/// </summary>
	public virtual void GetNodeGeometry(IntPtr ctr, ref double size)
	{
		vtkLabelHierarchyIterator_GetNodeGeometry_09(GetCppThis(), ctr, ref size);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelHierarchyIterator_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLabelHierarchyIterator_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelHierarchyIterator_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLabelHierarchyIterator_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabelHierarchyIterator_GetOrientation_12(HandleRef pThis);

	/// <summary>
	/// Retrieves the current label orientation.
	/// </summary>
	public virtual double GetOrientation()
	{
		return vtkLabelHierarchyIterator_GetOrientation_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyIterator_GetPoint_13(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Retrieves the current label location.
	/// </summary>
	public virtual void GetPoint(IntPtr x)
	{
		vtkLabelHierarchyIterator_GetPoint_13(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyIterator_GetSize_14(HandleRef pThis, IntPtr sz);

	/// <summary>
	/// Retrieves the current label size.
	/// </summary>
	public virtual void GetSize(IntPtr sz)
	{
		vtkLabelHierarchyIterator_GetSize_14(GetCppThis(), sz);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchyIterator_GetType_15(HandleRef pThis);

	/// <summary>
	/// Retrieves the current label type.
	/// </summary>
	public virtual int GetTypeWrapper()
	{
		return vtkLabelHierarchyIterator_GetType_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchyIterator_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLabelHierarchyIterator_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelHierarchyIterator_IsAtEnd_17(HandleRef pThis);

	/// <summary>
	/// Returns true if the iterator is at the end.
	/// </summary>
	public virtual bool IsAtEnd()
	{
		return (vtkLabelHierarchyIterator_IsAtEnd_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchyIterator_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLabelHierarchyIterator_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchyIterator_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLabelHierarchyIterator NewInstance()
	{
		vtkLabelHierarchyIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchyIterator_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelHierarchyIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyIterator_Next_20(HandleRef pThis);

	/// <summary>
	/// Advance the iterator.
	/// </summary>
	public virtual void Next()
	{
		vtkLabelHierarchyIterator_Next_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchyIterator_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelHierarchyIterator SafeDownCast(vtkObjectBase o)
	{
		vtkLabelHierarchyIterator vtkLabelHierarchyIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchyIterator_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabelHierarchyIterator2 = (vtkLabelHierarchyIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabelHierarchyIterator2.Register(null);
			}
		}
		return vtkLabelHierarchyIterator2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyIterator_SetAllBounds_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get whether all nodes in the hierarchy should be added to the TraversedBounds
	/// polydata or only those traversed.
	/// When non-zero, all nodes will be added.
	/// By default, AllBounds is 0.
	/// </summary>
	public virtual void SetAllBounds(int _arg)
	{
		vtkLabelHierarchyIterator_SetAllBounds_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchyIterator_SetTraversedBounds_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Sets a polydata to fill with geometry representing
	/// the bounding boxes of the traversed octree nodes.
	/// </summary>
	public virtual void SetTraversedBounds(vtkPolyData arg0)
	{
		vtkLabelHierarchyIterator_SetTraversedBounds_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
