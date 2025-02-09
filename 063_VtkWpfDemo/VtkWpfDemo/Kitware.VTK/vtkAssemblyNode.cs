using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAssemblyNode
/// </summary>
/// <remarks>
///    represent a node in an assembly
///
/// vtkAssemblyNode represents a node in an assembly. It is used by
/// vtkAssemblyPath to create hierarchical assemblies of props. The
/// props can be either 2D or 3D.
///
/// An assembly node refers to a vtkProp, and possibly a vtkMatrix4x4.
/// Nodes are used by vtkAssemblyPath to build fully evaluated path
/// (matrices are concatenated through the path) that is used by picking
/// and other operations involving assemblies.
///
/// @warning
/// The assembly node is guaranteed to contain a reference to an instance
/// of vtkMatrix4x4 if the prop referred to by the node is of type
/// vtkProp3D (or subclass). The matrix is evaluated through the assembly
/// path, so the assembly node's matrix is a function of its location in
/// the vtkAssemblyPath.
///
/// @warning
/// vtkAssemblyNode does not reference count its association with vtkProp.
/// Therefore, do not create an assembly node, associate a prop with it,
/// delete the prop, and then try to dereference the prop. The program
/// will break! (Reason: vtkAssemblyPath (which uses vtkAssemblyNode)
/// create self-referencing loops that destroy reference counting.)
///
/// </remarks>
/// <seealso>
///
/// vtkAssemblyPath vtkProp vtkPicker vtkMatrix4x4
/// </seealso>
public class vtkAssemblyNode : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAssemblyNode";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAssemblyNode()
	{
		MRClassNameKey = "class vtkAssemblyNode";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssemblyNode"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAssemblyNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssemblyNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an assembly node.
	/// </summary>
	public new static vtkAssemblyNode New()
	{
		vtkAssemblyNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssemblyNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create an assembly node.
	/// </summary>
	public vtkAssemblyNode()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAssemblyNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkAssemblyNode_GetMTime_01(HandleRef pThis);

	/// <summary>
	/// Override the standard GetMTime() to check for the modified times
	/// of the prop and matrix.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkAssemblyNode_GetMTime_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssemblyNode_GetMatrix_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a transformation matrix associated with the prop.
	/// Note: if the prop is not a type of vtkProp3D, then the
	/// transformation matrix is ignored (and expected to be NULL).
	/// Also, internal to this object the matrix is copied because
	/// the matrix is used for computation by vtkAssemblyPath.
	/// </summary>
	public virtual vtkMatrix4x4 GetMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssemblyNode_GetMatrix_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAssemblyNode_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Create an assembly node.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAssemblyNode_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAssemblyNode_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Create an assembly node.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAssemblyNode_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssemblyNode_GetViewProp_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the prop that this assembly node refers to.
	/// </summary>
	public virtual vtkProp GetViewProp()
	{
		vtkProp vtkProp2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssemblyNode_GetViewProp_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp2 = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp2.Register(null);
			}
		}
		return vtkProp2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssemblyNode_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Create an assembly node.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAssemblyNode_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssemblyNode_IsTypeOf_07(string type);

	/// <summary>
	/// Create an assembly node.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAssemblyNode_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssemblyNode_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an assembly node.
	/// </summary>
	public new vtkAssemblyNode NewInstance()
	{
		vtkAssemblyNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssemblyNode_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssemblyNode_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an assembly node.
	/// </summary>
	public new static vtkAssemblyNode SafeDownCast(vtkObjectBase o)
	{
		vtkAssemblyNode vtkAssemblyNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssemblyNode_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAssemblyNode_SetMatrix_11(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Specify a transformation matrix associated with the prop.
	/// Note: if the prop is not a type of vtkProp3D, then the
	/// transformation matrix is ignored (and expected to be NULL).
	/// Also, internal to this object the matrix is copied because
	/// the matrix is used for computation by vtkAssemblyPath.
	/// </summary>
	public void SetMatrix(vtkMatrix4x4 matrix)
	{
		vtkAssemblyNode_SetMatrix_11(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssemblyNode_SetViewProp_12(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Set/Get the prop that this assembly node refers to.
	/// </summary>
	public virtual void SetViewProp(vtkProp prop)
	{
		vtkAssemblyNode_SetViewProp_12(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
