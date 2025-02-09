using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLHardwareSelector
/// </summary>
/// <remarks>
///    implements the device specific code of
///  vtkOpenGLHardwareSelector.
///
///
/// Implements the device specific code of vtkOpenGLHardwareSelector.
///
/// </remarks>
/// <seealso>
///
/// vtkHardwareSelector
/// </seealso>
public class vtkOpenGLHardwareSelector : vtkHardwareSelector
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLHardwareSelector";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLHardwareSelector()
	{
		MRClassNameKey = "class vtkOpenGLHardwareSelector";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLHardwareSelector"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLHardwareSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLHardwareSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLHardwareSelector New()
	{
		vtkOpenGLHardwareSelector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLHardwareSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLHardwareSelector()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLHardwareSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLHardwareSelector_BeginRenderProp_01(HandleRef pThis);

	/// <summary>
	/// Called by the mapper before and after
	/// rendering each prop.
	/// </summary>
	public override void BeginRenderProp()
	{
		vtkOpenGLHardwareSelector_BeginRenderProp_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLHardwareSelector_BeginSelection_02(HandleRef pThis);

	/// <summary>
	/// Called by any vtkMapper or subclass to render process id. This has any
	/// effect when this-&gt;UseProcessIdFromData is true.
	/// </summary>
	public virtual void BeginSelection()
	{
		vtkOpenGLHardwareSelector_BeginSelection_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLHardwareSelector_EndRenderProp_03(HandleRef pThis);

	/// <summary>
	/// Called by the mapper before and after
	/// rendering each prop.
	/// </summary>
	public override void EndRenderProp()
	{
		vtkOpenGLHardwareSelector_EndRenderProp_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLHardwareSelector_EndSelection_04(HandleRef pThis);

	/// <summary>
	/// Called by any vtkMapper or subclass to render process id. This has any
	/// effect when this-&gt;UseProcessIdFromData is true.
	/// </summary>
	public virtual void EndSelection()
	{
		vtkOpenGLHardwareSelector_EndSelection_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLHardwareSelector_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLHardwareSelector_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLHardwareSelector_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLHardwareSelector_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLHardwareSelector_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLHardwareSelector_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLHardwareSelector_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLHardwareSelector_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLHardwareSelector_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLHardwareSelector NewInstance()
	{
		vtkOpenGLHardwareSelector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLHardwareSelector_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLHardwareSelector_RenderCompositeIndex_11(HandleRef pThis, uint index);

	/// <summary>
	/// Called by any vtkMapper or vtkProp subclass to render a composite-index.
	/// Currently indices &gt;= 0xffffff are not supported.
	/// </summary>
	public override void RenderCompositeIndex(uint index)
	{
		vtkOpenGLHardwareSelector_RenderCompositeIndex_11(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLHardwareSelector_RenderProcessId_12(HandleRef pThis, uint processid);

	/// <summary>
	/// Called by any vtkMapper or subclass to render process id. This has any
	/// effect when this-&gt;UseProcessIdFromData is true.
	/// </summary>
	public override void RenderProcessId(uint processid)
	{
		vtkOpenGLHardwareSelector_RenderProcessId_12(GetCppThis(), processid);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLHardwareSelector_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLHardwareSelector SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLHardwareSelector vtkOpenGLHardwareSelector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLHardwareSelector_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLHardwareSelector2 = (vtkOpenGLHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLHardwareSelector2.Register(null);
			}
		}
		return vtkOpenGLHardwareSelector2;
	}
}
