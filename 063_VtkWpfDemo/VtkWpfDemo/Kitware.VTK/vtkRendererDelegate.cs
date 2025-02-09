using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRendererDelegate
/// </summary>
/// <remarks>
///    Render the props of a vtkRenderer
///
/// vtkRendererDelegate is an abstract class with a pure virtual method Render.
/// This method replaces the Render method of vtkRenderer to allow custom
/// rendering from an external project. A RendererDelegate is connected to
/// a vtkRenderer with method SetDelegate(). An external project just
/// has to provide a concrete implementation of vtkRendererDelegate.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderer
/// </seealso>
public abstract class vtkRendererDelegate : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRendererDelegate";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRendererDelegate()
	{
		MRClassNameKey = "class vtkRendererDelegate";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRendererDelegate"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRendererDelegate(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkRendererDelegate_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRendererDelegate_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRendererDelegate_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRendererDelegate_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRendererDelegate_GetUsed_03(HandleRef pThis);

	/// <summary>
	/// Tells if the delegate has to be used by the renderer or not.
	/// Initial value is off.
	/// </summary>
	public virtual bool GetUsed()
	{
		return (vtkRendererDelegate_GetUsed_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRendererDelegate_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRendererDelegate_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRendererDelegate_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRendererDelegate_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererDelegate_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRendererDelegate NewInstance()
	{
		vtkRendererDelegate result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRendererDelegate_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRendererDelegate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererDelegate_Render_07(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Render the props of vtkRenderer if Used is on.
	/// </summary>
	public virtual void Render(vtkRenderer r)
	{
		vtkRendererDelegate_Render_07(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererDelegate_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRendererDelegate SafeDownCast(vtkObjectBase o)
	{
		vtkRendererDelegate vtkRendererDelegate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRendererDelegate_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRendererDelegate2 = (vtkRendererDelegate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRendererDelegate2.Register(null);
			}
		}
		return vtkRendererDelegate2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererDelegate_SetUsed_09(HandleRef pThis, byte _arg);

	/// <summary>
	/// Tells if the delegate has to be used by the renderer or not.
	/// Initial value is off.
	/// </summary>
	public virtual void SetUsed(bool _arg)
	{
		vtkRendererDelegate_SetUsed_09(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererDelegate_UsedOff_10(HandleRef pThis);

	/// <summary>
	/// Tells if the delegate has to be used by the renderer or not.
	/// Initial value is off.
	/// </summary>
	public virtual void UsedOff()
	{
		vtkRendererDelegate_UsedOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererDelegate_UsedOn_11(HandleRef pThis);

	/// <summary>
	/// Tells if the delegate has to be used by the renderer or not.
	/// Initial value is off.
	/// </summary>
	public virtual void UsedOn()
	{
		vtkRendererDelegate_UsedOn_11(GetCppThis());
	}
}
