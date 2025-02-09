using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class ExternalVTKWidget : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.ExternalVTKWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static ExternalVTKWidget()
	{
		MRClassNameKey = "class ExternalVTKWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.ExternalVTKWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public ExternalVTKWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr ExternalVTKWidget_AddRenderer_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkExternalOpenGLRenderer AddRenderer()
	{
		vtkExternalOpenGLRenderer vtkExternalOpenGLRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = ExternalVTKWidget_AddRenderer_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExternalOpenGLRenderer2 = (vtkExternalOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExternalOpenGLRenderer2.Register(null);
			}
		}
		return vtkExternalOpenGLRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long ExternalVTKWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return ExternalVTKWidget_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long ExternalVTKWidget_GetNumberOfGenerationsFromBaseType_03(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return ExternalVTKWidget_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr ExternalVTKWidget_GetRenderWindow_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkExternalOpenGLRenderWindow GetRenderWindow()
	{
		vtkExternalOpenGLRenderWindow vtkExternalOpenGLRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = ExternalVTKWidget_GetRenderWindow_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExternalOpenGLRenderWindow2 = (vtkExternalOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExternalOpenGLRenderWindow2.Register(null);
			}
		}
		return vtkExternalOpenGLRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int ExternalVTKWidget_IsA_05(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return ExternalVTKWidget_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int ExternalVTKWidget_IsTypeOf_06(string type);

	public new static int IsTypeOf(string type)
	{
		return ExternalVTKWidget_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr ExternalVTKWidget_New_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static ExternalVTKWidget New()
	{
		ExternalVTKWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = ExternalVTKWidget_New_07(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (ExternalVTKWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr ExternalVTKWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new ExternalVTKWidget NewInstance()
	{
		ExternalVTKWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = ExternalVTKWidget_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (ExternalVTKWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr ExternalVTKWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static ExternalVTKWidget SafeDownCast(vtkObjectBase o)
	{
		ExternalVTKWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = ExternalVTKWidget_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (ExternalVTKWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void ExternalVTKWidget_SetRenderWindow_10(HandleRef pThis, HandleRef renWin);

	public void SetRenderWindow(vtkExternalOpenGLRenderWindow renWin)
	{
		ExternalVTKWidget_SetRenderWindow_10(GetCppThis(), renWin?.GetCppThis() ?? default(HandleRef));
	}
}
