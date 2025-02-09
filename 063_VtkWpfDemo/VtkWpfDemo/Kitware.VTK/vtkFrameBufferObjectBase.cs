using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFrameBufferObjectBase
/// </summary>
/// <remarks>
///    abstract interface to OpenGL FBOs
///
/// API for classes that encapsulate an OpenGL Frame Buffer Object.
/// </remarks>
public abstract class vtkFrameBufferObjectBase : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFrameBufferObjectBase";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFrameBufferObjectBase()
	{
		MRClassNameKey = "class vtkFrameBufferObjectBase";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFrameBufferObjectBase"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFrameBufferObjectBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFrameBufferObjectBase_GetLastSize_01(HandleRef pThis);

	/// <summary>
	/// Dimensions in pixels of the framebuffer.
	/// </summary>
	public virtual IntPtr GetLastSize()
	{
		return vtkFrameBufferObjectBase_GetLastSize_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrameBufferObjectBase_GetLastSize_02(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Dimensions in pixels of the framebuffer.
	/// </summary>
	public virtual void GetLastSize(ref int _arg1, ref int _arg2)
	{
		vtkFrameBufferObjectBase_GetLastSize_02(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrameBufferObjectBase_GetLastSize_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Dimensions in pixels of the framebuffer.
	/// </summary>
	public virtual void GetLastSize(IntPtr _arg)
	{
		vtkFrameBufferObjectBase_GetLastSize_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFrameBufferObjectBase_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFrameBufferObjectBase_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFrameBufferObjectBase_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFrameBufferObjectBase_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFrameBufferObjectBase_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFrameBufferObjectBase_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFrameBufferObjectBase_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFrameBufferObjectBase_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFrameBufferObjectBase_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFrameBufferObjectBase NewInstance()
	{
		vtkFrameBufferObjectBase result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFrameBufferObjectBase_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFrameBufferObjectBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFrameBufferObjectBase_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFrameBufferObjectBase SafeDownCast(vtkObjectBase o)
	{
		vtkFrameBufferObjectBase vtkFrameBufferObjectBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFrameBufferObjectBase_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFrameBufferObjectBase2 = (vtkFrameBufferObjectBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFrameBufferObjectBase2.Register(null);
			}
		}
		return vtkFrameBufferObjectBase2;
	}
}
