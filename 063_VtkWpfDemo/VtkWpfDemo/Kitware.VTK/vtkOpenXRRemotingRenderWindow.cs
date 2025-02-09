using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenXRRemotingRenderWindow
/// </summary>
/// <remarks>
///    OpenXR remoting rendering window
///
///
/// </remarks>
public class vtkOpenXRRemotingRenderWindow : vtkOpenXRRenderWindow
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenXRRemotingRenderWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenXRRemotingRenderWindow()
	{
		MRClassNameKey = "class vtkOpenXRRemotingRenderWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenXRRemotingRenderWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenXRRemotingRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenXRRemotingRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenXRRemotingRenderWindow New()
	{
		vtkOpenXRRemotingRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenXRRemotingRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenXRRemotingRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenXRRemotingRenderWindow()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenXRRemotingRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRemotingRenderWindow_CopyResultFrame_01(HandleRef pThis);

	/// <summary>
	/// Overriden to lock the opengl rendering while copying.
	/// </summary>
	public override void CopyResultFrame()
	{
		vtkOpenXRRemotingRenderWindow_CopyResultFrame_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenXRRemotingRenderWindow_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenXRRemotingRenderWindow_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenXRRemotingRenderWindow_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenXRRemotingRenderWindow_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRemotingRenderWindow_Initialize_04(HandleRef pThis);

	/// <summary>
	/// Initialize helper window ressources.
	/// </summary>
	public override void Initialize()
	{
		vtkOpenXRRemotingRenderWindow_Initialize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenXRRemotingRenderWindow_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenXRRemotingRenderWindow_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenXRRemotingRenderWindow_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenXRRemotingRenderWindow_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenXRRemotingRenderWindow_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenXRRemotingRenderWindow NewInstance()
	{
		vtkOpenXRRemotingRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenXRRemotingRenderWindow_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenXRRemotingRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenXRRemotingRenderWindow_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenXRRemotingRenderWindow SafeDownCast(vtkObjectBase o)
	{
		vtkOpenXRRemotingRenderWindow vtkOpenXRRemotingRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenXRRemotingRenderWindow_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenXRRemotingRenderWindow2 = (vtkOpenXRRemotingRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenXRRemotingRenderWindow2.Register(null);
			}
		}
		return vtkOpenXRRemotingRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRemotingRenderWindow_SetRemotingIPAddress_10(HandleRef pThis, string host);

	/// <summary>
	/// Set the OpenXR remoting IP address to connect to.
	/// </summary>
	public void SetRemotingIPAddress(string host)
	{
		vtkOpenXRRemotingRenderWindow_SetRemotingIPAddress_10(GetCppThis(), host);
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRemotingRenderWindow_StereoMidpoint_11(HandleRef pThis);

	/// <summary>
	/// Overriden to draw to the shared D3D texture
	/// </summary>
	public override void StereoMidpoint()
	{
		vtkOpenXRRemotingRenderWindow_StereoMidpoint_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRemotingRenderWindow_StereoRenderComplete_12(HandleRef pThis);

	/// <summary>
	/// Overriden to draw to the shared D3D texture
	/// </summary>
	public override void StereoRenderComplete()
	{
		vtkOpenXRRemotingRenderWindow_StereoRenderComplete_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRemotingRenderWindow_StereoUpdate_13(HandleRef pThis);

	/// <summary>
	/// Overriden to draw to the shared D3D texture
	/// </summary>
	public override void StereoUpdate()
	{
		vtkOpenXRRemotingRenderWindow_StereoUpdate_13(GetCppThis());
	}
}
