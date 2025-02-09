using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRendererNode
/// </summary>
/// <remarks>
///    vtkViewNode specialized for vtkRenderers
///
/// State storage and graph traversal for vtkRenderer
/// </remarks>
public class vtkRendererNode : vtkViewNode
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRendererNode";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRendererNode()
	{
		MRClassNameKey = "class vtkRendererNode";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRendererNode"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRendererNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRendererNode New()
	{
		vtkRendererNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRendererNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRendererNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRendererNode()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRendererNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRendererNode_Build_01(HandleRef pThis, byte prepass);

	/// <summary>
	/// Build containers for our child nodes.
	/// </summary>
	public override void Build(bool prepass)
	{
		vtkRendererNode_Build_01(GetCppThis(), (byte)(prepass ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRendererNode_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRendererNode_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRendererNode_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRendererNode_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererNode_GetScale_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the window tile scale
	/// </summary>
	public virtual int[] GetScale()
	{
		IntPtr intPtr = vtkRendererNode_GetScale_04(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_GetScale_05(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get/Set the window tile scale
	/// </summary>
	public virtual void GetScale(ref int _arg1, ref int _arg2)
	{
		vtkRendererNode_GetScale_05(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_GetScale_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the window tile scale
	/// </summary>
	public virtual void GetScale(IntPtr _arg)
	{
		vtkRendererNode_GetScale_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererNode_GetSize_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the framebuffer size
	/// </summary>
	public virtual int[] GetSize()
	{
		IntPtr intPtr = vtkRendererNode_GetSize_07(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_GetSize_08(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get/Set the framebuffer size
	/// </summary>
	public virtual void GetSize(ref int _arg1, ref int _arg2)
	{
		vtkRendererNode_GetSize_08(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_GetSize_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the framebuffer size
	/// </summary>
	public virtual void GetSize(IntPtr _arg)
	{
		vtkRendererNode_GetSize_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererNode_GetViewport_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the window viewport
	/// </summary>
	public virtual double[] GetViewport()
	{
		IntPtr intPtr = vtkRendererNode_GetViewport_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_GetViewport_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Get/Set the window viewport
	/// </summary>
	public virtual void GetViewport(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkRendererNode_GetViewport_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_GetViewport_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the window viewport
	/// </summary>
	public virtual void GetViewport(IntPtr _arg)
	{
		vtkRendererNode_GetViewport_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRendererNode_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRendererNode_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRendererNode_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRendererNode_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererNode_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRendererNode NewInstance()
	{
		vtkRendererNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRendererNode_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRendererNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererNode_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRendererNode SafeDownCast(vtkObjectBase o)
	{
		vtkRendererNode vtkRendererNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRendererNode_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRendererNode2 = (vtkRendererNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRendererNode2.Register(null);
			}
		}
		return vtkRendererNode2;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_SetScale_18(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Get/Set the window tile scale
	/// </summary>
	public virtual void SetScale(int _arg1, int _arg2)
	{
		vtkRendererNode_SetScale_18(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_SetScale_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the window tile scale
	/// </summary>
	public void SetScale(IntPtr _arg)
	{
		vtkRendererNode_SetScale_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_SetSize_20(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Get/Set the framebuffer size
	/// </summary>
	public virtual void SetSize(int _arg1, int _arg2)
	{
		vtkRendererNode_SetSize_20(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_SetSize_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the framebuffer size
	/// </summary>
	public void SetSize(IntPtr _arg)
	{
		vtkRendererNode_SetSize_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_SetViewport_22(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Get/Set the window viewport
	/// </summary>
	public virtual void SetViewport(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkRendererNode_SetViewport_22(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererNode_SetViewport_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the window viewport
	/// </summary>
	public virtual void SetViewport(IntPtr _arg)
	{
		vtkRendererNode_SetViewport_23(GetCppThis(), _arg);
	}
}
