using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWindowNode
/// </summary>
/// <remarks>
///    vtkViewNode specialized for vtkRenderWindows
///
/// State storage and graph traversal for vtkRenderWindow
/// </remarks>
public class vtkWindowNode : vtkViewNode
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWindowNode";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWindowNode()
	{
		MRClassNameKey = "class vtkWindowNode";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindowNode"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWindowNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWindowNode New()
	{
		vtkWindowNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWindowNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkWindowNode()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWindowNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowNode_Build_01(HandleRef pThis, byte prepass);

	/// <summary>
	/// Build containers for our child nodes.
	/// </summary>
	public override void Build(bool prepass)
	{
		vtkWindowNode_Build_01(GetCppThis(), (byte)(prepass ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowNode_GetColorBuffer_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the most recent color buffer RGBA
	/// </summary>
	public virtual vtkUnsignedCharArray GetColorBuffer()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowNode_GetColorBuffer_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindowNode_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWindowNode_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindowNode_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWindowNode_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowNode_GetSize_05(HandleRef pThis);

	/// <summary>
	/// Return the size of the last rendered image
	/// </summary>
	public virtual IntPtr GetSize()
	{
		return vtkWindowNode_GetSize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowNode_GetZBuffer_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the most recent zbuffer buffer
	/// </summary>
	public virtual vtkFloatArray GetZBuffer()
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowNode_GetZBuffer_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowNode_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWindowNode_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowNode_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWindowNode_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowNode_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWindowNode NewInstance()
	{
		vtkWindowNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowNode_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWindowNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowNode_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWindowNode SafeDownCast(vtkObjectBase o)
	{
		vtkWindowNode vtkWindowNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowNode_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWindowNode2 = (vtkWindowNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWindowNode2.Register(null);
			}
		}
		return vtkWindowNode2;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowNode_Synchronize_12(HandleRef pThis, byte prepass);

	/// <summary>
	/// Get state of my renderable.
	/// </summary>
	public override void Synchronize(bool prepass)
	{
		vtkWindowNode_Synchronize_12(GetCppThis(), (byte)(prepass ? 1u : 0u));
	}
}
