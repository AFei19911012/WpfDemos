using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAssemblyPath
/// </summary>
/// <remarks>
///    a list of nodes that form an assembly path
///
/// vtkAssemblyPath represents an ordered list of assembly nodes that
/// represent a fully evaluated assembly path. This class is used primarily
/// for picking. Note that the use of this class is to add one or more
/// assembly nodes to form the path. (An assembly node consists of an instance
/// of vtkProp and vtkMatrix4x4, the matrix may be NULL.) As each node is
/// added, the matrices are concatenated to create a final, evaluated matrix.
///
/// </remarks>
/// <seealso>
///
/// vtkAssemblyNode vtkAssembly vtkActor vtkMatrix4x4 vtkProp vtkAbstractPicker
/// </seealso>
public class vtkAssemblyPath : vtkCollection
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAssemblyPath";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAssemblyPath()
	{
		MRClassNameKey = "class vtkAssemblyPath";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssemblyPath"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAssemblyPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssemblyPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate empty path with identify matrix.
	/// </summary>
	public new static vtkAssemblyPath New()
	{
		vtkAssemblyPath result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssemblyPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate empty path with identify matrix.
	/// </summary>
	public vtkAssemblyPath()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAssemblyPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssemblyPath_AddNode_01(HandleRef pThis, HandleRef p, HandleRef m);

	/// <summary>
	/// Convenience method adds a prop and matrix together,
	/// creating an assembly node transparently. The matrix
	/// pointer m may be NULL. Note: that matrix is the one,
	/// if any, associated with the prop.
	/// </summary>
	public void AddNode(vtkProp p, vtkMatrix4x4 m)
	{
		vtkAssemblyPath_AddNode_01(GetCppThis(), p?.GetCppThis() ?? default(HandleRef), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssemblyPath_DeleteLastNode_02(HandleRef pThis);

	/// <summary>
	/// Delete the last assembly node in the list. This is like
	/// a stack pop.
	/// </summary>
	public void DeleteLastNode()
	{
		vtkAssemblyPath_DeleteLastNode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssemblyPath_GetFirstNode_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the first assembly node in the list. See the comments for
	/// GetNextNode() regarding the contents of the returned node. (Note: This
	/// node corresponds to the vtkProp associated with the vtkRenderer.
	/// </summary>
	public vtkAssemblyNode GetFirstNode()
	{
		vtkAssemblyNode vtkAssemblyNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssemblyPath_GetFirstNode_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyNode2 = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyNode2.Register(null);
			}
		}
		return vtkAssemblyNode2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssemblyPath_GetLastNode_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the last assembly node in the list. See the comments
	/// for GetNextNode() regarding the contents of the returned node.
	/// </summary>
	public vtkAssemblyNode GetLastNode()
	{
		vtkAssemblyNode vtkAssemblyNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssemblyPath_GetLastNode_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyNode2 = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyNode2.Register(null);
			}
		}
		return vtkAssemblyNode2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkAssemblyPath_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// Override the standard GetMTime() to check for the modified times
	/// of the nodes in this path.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkAssemblyPath_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssemblyPath_GetNextNode_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the next assembly node in the list. The node returned
	/// contains a pointer to a prop and a 4x4 matrix. The matrix
	/// is evaluated based on the preceding assembly hierarchy
	/// (i.e., the matrix is not necessarily as the same as the
	/// one that was added with AddNode() because of the
	/// concatenation of matrices in the assembly hierarchy).
	/// </summary>
	public vtkAssemblyNode GetNextNode()
	{
		vtkAssemblyNode vtkAssemblyNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssemblyPath_GetNextNode_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyNode2 = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyNode2.Register(null);
			}
		}
		return vtkAssemblyNode2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAssemblyPath_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAssemblyPath_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAssemblyPath_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAssemblyPath_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssemblyPath_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAssemblyPath_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssemblyPath_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAssemblyPath_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssemblyPath_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAssemblyPath NewInstance()
	{
		vtkAssemblyPath result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssemblyPath_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssemblyPath_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAssemblyPath SafeDownCast(vtkObjectBase o)
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssemblyPath_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssemblyPath_ShallowCopy_14(HandleRef pThis, HandleRef path);

	/// <summary>
	/// Perform a shallow copy (reference counted) on the
	/// incoming path.
	/// </summary>
	public void ShallowCopy(vtkAssemblyPath path)
	{
		vtkAssemblyPath_ShallowCopy_14(GetCppThis(), path?.GetCppThis() ?? default(HandleRef));
	}
}
